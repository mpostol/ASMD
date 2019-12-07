//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.Common;
using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.Lib.RTLib.Utils;
using CAS.UA.IServerConfiguration;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Solution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{

  internal interface ISolutionModel : IBaseModel
  {
    void GetPluginMenuItems(System.Windows.Forms.ToolStripItemCollection items);
    void AddProject(bool existing);
    void ImportNodeSet();
    void Save(bool prompt);
    void Open();
    void OnNew();
  }
  /// <summary>
  /// The class representing the solution node in the model.
  /// </summary>
  internal class SolutionTreeNode : WrapperTreeNode, IBaseDirectoryProvider, IViewModel, ISolutionModel
  {

    #region private
    private readonly EventHandler m_OnChangeHandler = null;
    private void configuration_OnNameChanged(object sender, EventArgs e) { }
    private void AddProjectsNodes(IEnumerable<UAModelDesignerProject> configuration)
    {
      if (configuration == null)
        return;
      List<ProjectTreeNode> _nodes = new List<ProjectTreeNode>();
      foreach (UAModelDesignerProject _project in configuration)
      {
        ProjectTreeNode _newProject = null;
        try
        {
          _newProject = new ProjectTreeNode(this, _project);
        }
        catch (FileNotFoundException _ex)
        {
          this.MessageBoxHandling.Show(string.Format(Resources.ProjectFileNotFound_Info, _ex.Message), Resources.ProjectFileNotFound_Header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception _ex)
        {
          this.MessageBoxHandling.Show
            (
              string.Format(Properties.Resources.Project_FileOpenError, _ex.Message),
              Properties.Resources.Project_OpenFileCaption,
              MessageBoxButtons.OK,
              MessageBoxIcon.Error
            );
        }
        if (_project != null)
          _nodes.Add(_newProject);
      }
      this.AddRange(_nodes);
    }
    private UAModelDesignerSolution SaveProjectsCreateConfiguration()
    {
      Server.Save(HomeDirectory);
      List<ProjectTreeNode> _ListOfProjects = new List<ProjectTreeNode>();
      foreach (ProjectTreeNode _project in this)
        if (_project.Save())
          _ListOfProjects.Add(_project.CloneProject());
      this.Clear();
      this.AddRange(_ListOfProjects);
      return new UAModelDesignerSolution()
      {
        Name = this.Name,
        Projects = this.Cast<ProjectTreeNode>().Select<ProjectTreeNode, UAModelDesignerProject>(x => x.UAModelDesignerProject).ToArray<UAModelDesignerProject>(),
        ServerDetails = this.ServerDetails == null ? null : new UAModelDesignerSolutionServerDetails() { codebase = ServerDetails.Codebase, configuration = ServerDetails.Configuration }
      };
    }
    private void Server_OnConfigurationChanged(object sender, UAServerConfigurationEventArgs e)
    {
      if (e.ConfigurationFileChanged)
        this.RaiseSubtreeChanged();
    }
    /// <summary>
    /// Gets or sets detailed information on localization of the plug-in and configuration file.
    /// </summary>
    /// <value>The server descriptor.</value>
    private ServerSelector.ServerDescriptor ServerDetails
    {
      get
      {
        ServerSelector.ServerDescriptor _descriptor = Server.ServerConfiguration;
        if (_descriptor == null)
          return null;
        if (!string.IsNullOrEmpty(_descriptor.Codebase))
          _descriptor.Codebase = RelativeFilePathsCalculator.TryComputeRelativePath(HomeDirectory, _descriptor.Codebase);
        if (!string.IsNullOrEmpty(_descriptor.Configuration))
          _descriptor.Configuration = RelativeFilePathsCalculator.TryComputeRelativePath(HomeDirectory, _descriptor.Configuration);
        return _descriptor;
      }
    }
    /// <summary>
    /// Gets or sets the library root.
    /// </summary>
    /// <value>The library root.</value>
    private Libraries LibraryRoot { get; set; } = new Libraries();
    #endregion

    #region constructor
    internal SolutionTreeNode(UAModelDesignerSolution configuration, string solutionPath, EventHandler<EventArgs> OnChangeHandler, Action<LibraryTreeNode> callBack) : this(configuration, solutionPath, OnChangeHandler)
    {
      LibraryRoot.AddNodes(callBack);
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="SolutionTreeNode"/> class.
    /// </summary>
    /// <param name="configuration">The configuration.</param>
    /// <param name="NodeName">Name of the node.</param>
    /// <param name="OnChangeHandler">The on change handler.</param>
    internal SolutionTreeNode(UAModelDesignerSolution configuration, string solutionPath, EventHandler<EventArgs> OnChangeHandler) : base(null, configuration.Name)
    {
      if (configuration == null)
        throw new ArgumentNullException("configuration");
      HomeDirectory = solutionPath;
      Server = new ServerSelector(new GraphicalUserInterface(), solutionPath, configuration.ServerDetails.codebase, configuration.ServerDetails.configuration);
      Server.OnConfigurationChanged += new EventHandler<UAServerConfigurationEventArgs>(Server_OnConfigurationChanged);
      //TODO OnDataChanged += OnChangeHandler;
      //TODO OnNameChanged += new EventHandler(configuration_OnNameChanged);
      AddProjectsNodes(configuration.Projects);
      BaseDirectoryHelper.Instance.SetBaseDirectoryProvider(this);
      SolutionRoot = this;
    }
    #endregion

    #region WrapperTreeNode 
    public override NodeTypeEnum NodeType => NodeTypeEnum.SolutionNode;
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.SolutionTreeNode;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.None;
    internal override bool TestIfReadOnlyAndRetrunTrueIfReadOnly()
    {
      return false;
    }
    public override object Wrapper => this.Create();
    #endregion

    #region public
    /// <summary>
    /// Gets or sets the solution root.
    /// </summary>
    /// <value>The solution root.</value>
    internal static SolutionTreeNode SolutionRoot { get; set; }
    /// <summary>
    /// Resets the information model and adds recursively all nodes to the address space from <see cref="Root.LibraryRoot"/> and next from <see cref="Root.SolutionRoot"/>.
    /// </summary>
    /// <param name="space">The address space.</param>
    internal void ResetAndAddToAddressSpace(IAddressSpaceCreator space)
    {
      LibraryRoot.AddNode2AddressSpace(space);
      AddNode2AddressSpace(space);
    }
    internal ServerSelector Server { get; private set; }
    /// <summary>
    /// Builds the solution and write any massages to specified output.
    /// </summary>
    /// <param name="output">The compiler output.</param>
    internal void Build(TextWriter output)
    {
      Save(false);
      output.WriteLine(Resources.Build_all);
      foreach (ProjectTreeNode _project in this)
        _project.Build(output);
    }
    internal event EventHandler<EventArgs> OnDataChanged;
    internal void AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      foreach (ProjectTreeNode node in this)
        node.AddNode2AddressSpace(space);
    }
    /// <summary>
    /// Finds the type starting form <see cref="Root.SolutionRoot"/> and if not succeeded tries <see cref="Root.LibraryRoot"/>.
    /// </summary>
    /// <param name="myType">My type.</param>
    /// <returns></returns>
    internal ITypeDesign FindType(XmlQualifiedName myType)
    {
      foreach (ProjectTreeNode node in this)
      {
        ITypeDesign ret = node.Find(myType);
        if (ret != null)
          return ret;
      }
      return LibraryRoot.FindType(myType);
    }
    /// <summary>
    /// Gets the instance configuration.
    /// </summary>
    /// <param name="nodeUniqueIdentifier">The node unique identifier.</param>
    /// <returns>IInstanceConfiguration.</returns>
    internal IInstanceConfiguration GetInstanceConfiguration(INodeDescriptor nodeUniqueIdentifier)
    {
      return Server.GetInstanceConfiguration(nodeUniqueIdentifier);
    }
    internal string HomeDirectory { get; private set; }
    #endregion

    #region ISolutionModel
    public void GetPluginMenuItems(System.Windows.Forms.ToolStripItemCollection menu)
    {
      //TODO UA Server menu is empty #67
      ICollection<System.Windows.Forms.ToolStripItem> _items = new List<System.Windows.Forms.ToolStripItem>();
      Server.GetPluginMenuItems(_items);
      menu.AddRange(_items.ToArray<System.Windows.Forms.ToolStripItem>());
    }
    public void AddProject(bool existing)
    {
      ProjectTreeNode _node = null;
      if (existing)
      {
        string _DefaultFileName = Path.Combine(HomeDirectory, Resources.DefaultProjectName);
        _node = ProjectTreeNode.ImportNodeSet(this, x => AssemblyTraceEvent.Tracer.TraceEvent(x.TraceLevel, 186, x.ToString()), OPCFModelConfigurationManagement.ReadModelDesign);
      }
      else
        _node = ProjectTreeNode.CreateNewModel(this);
      Add(_node);
    }
    public void ImportNodeSet()
    {
      ProjectTreeNode node = ProjectTreeNode.ImportNodeSet(this, x => AssemblyTraceEvent.Tracer.TraceEvent(x.TraceLevel, 186, x.ToString()), IO.ImportNodeSet.Import);
      if (node == null)
        return;
      Add(node);
    }
    public void Save(bool prompt)
    {
      OPCFSolutionConfigurationManagement.DefaultInstance.Save(prompt, SaveProjectsCreateConfiguration());
    }
    public void Open()
    {
      OPCFSolutionConfigurationManagement.DefaultInstance.Open();
    }
    public void OnNew()
    {
      OPCFSolutionConfigurationManagement.DefaultInstance.OnNew();
    }
    #endregion

    #region IBaseDirectoryProvider
    public string GetBaseDirectory()
    {
      return HomeDirectory;
    }
    #endregion

    #region WrapperTreeNode
    protected internal override void RaiseOnChangeHandler()
    {
      m_OnChangeHandler?.Invoke(this, EventArgs.Empty);
      OnDataChanged?.Invoke(this, EventArgs.Empty);
    }
    protected override void CreateInstanceConfigurations(BaseTreeNode node, bool SkipOpeningConfigurationFile, out bool CancelWasPressed)
    {
      IConfiguration svr = Server.IServerConfiguration;
      if (svr == null)
      {
        CancelWasPressed = SkipOpeningConfigurationFile;
        return;
      }
      INodeDescriptor[] _descriptors = node.GetNodeDescriptors();
      svr.CreateInstanceConfigurations(_descriptors, SkipOpeningConfigurationFile, out CancelWasPressed);
    }
    #endregion

  }

}
