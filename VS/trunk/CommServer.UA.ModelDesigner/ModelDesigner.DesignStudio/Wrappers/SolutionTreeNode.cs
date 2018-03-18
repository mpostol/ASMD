﻿//<summary>
//  Title   : Solution Root TreeNode
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  20090106: mzbrzezny created
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.CommServer.UA.Common;
using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.Lib.RTLib.Utils;
using CAS.UA.IServerConfiguration;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Solution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms; //TODO Must be removed
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{

  internal interface ISolutionModel : IBaseModel
  {
    void GetPluginMenuItems(ToolStripItemCollection items);
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
    private EventHandler m_OnChangeHandler = null;
    private void configuration_OnNameChanged(object sender, EventArgs e)
    { }
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
        catch (FileNotFoundException _fnfe)
        {
          MessageBox.Show(String.Format(Resources.ProjectFileNotFound_Info, _fnfe.Message), Resources.ProjectFileNotFound_Header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception _ex)
        {
          MessageBox.Show
            (
              String.Format(Properties.Resources.Project_FileOpenError, _ex.Message),
              Properties.Resources.Project_OpenFileCaption,
              MessageBoxButtons.OK,
              MessageBoxIcon.Error
            );
        }
        if (_project != null)
          _nodes.Add(_newProject);
      }
      this.AddRange(_nodes);
      //foreach (var node in nodes) //AddRange does the same
      //  Add(node);
    }
    private UAModelDesignerSolution SaveProjectsCreateConfiguration()
    {
      Server.Save(HomeDirectory);
      List<ProjectTreeNode> nodes = new List<ProjectTreeNode>();
      foreach (ProjectTreeNode _project in this)
      {
        if (_project.Save())
          nodes.Add(_project.CloneProject());
      }
      this.AddRange(nodes);
      this.Clear();
      this.AddRange(nodes);
      return new UAModelDesignerSolution()
      {
        Name = this.Name,
        Projects = this.Cast<ProjectTreeNode>().Select<ProjectTreeNode, UAModelDesignerProject>(x => x.UAModelDesignerProject).ToArray<UAModelDesignerProject>(),
        ServerDetails = this.ServerDetails == null ? null : new UAModelDesignerSolutionServerDetails() { codebase = ServerDetails.codebase, configuration = ServerDetails.configuration }
      };
    }
    private void Server_OnConfigurationChanged(object sender, UAServerConfigurationEventArgs e)
    {
      if (e.ConfigurationFileChanged)
        this.RaiseSubtreeChanged();
    }
    #endregion

    #region constructor
    /// <summary>
    /// Initializes a new instance of the <see cref="SolutionTreeNode"/> class.
    /// </summary>
    /// <param name="configuration">The configuration.</param>
    /// <param name="NodeName">Name of the node.</param>
    /// <param name="OnChangeHandler">The on change handler.</param>
    internal SolutionTreeNode(UAModelDesignerSolution configuration, string solutionPath, EventHandler<EventArgs> OnChangeHandler)
      : base(null, configuration.Name)
    {
      HomeDirectory = solutionPath; //TODO must be managed by IO 
      if (configuration == null)
        throw new ArgumentNullException("configuration");
      Server = new ServerSelector() { ServerConfiguration = new ServerSelector.ServerDescriptor() { codebase = configuration.ServerDetails.codebase, configuration = configuration.ServerDetails.configuration } };
      Server.OnConfigurationChanged += new EventHandler<UAServerConfigurationEventArgs>(Server_OnConfigurationChanged);
      //TODO OnDataChanged += OnChangeHandler;
      //TODO OnNameChanged += new EventHandler(configuration_OnNameChanged);
      AddProjectsNodes(configuration.Projects);
      Root.SolutionRoot = this;
      BaseDirectoryHelper.Instance.SetBaseDirectoryProvider(this);
    }
    #endregion

    #region WrapperTreeNode 
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.SolutionNode; }
    }
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.SolutionTreeNode; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.None; }
    }
    internal override bool TestIfReadOnlyAndRetrunTrueIfReadOnly()
    {
      return false;
    }
    public override object Wrapper
    {
      get
      {
        return this.Create();
      }
    }
    #endregion

    #region public
    /// <summary>
    /// Gets or sets detailed information on localization of the plug-in and configuration file.
    /// </summary>
    /// <value>The server descriptor.</value>
    internal ServerSelector.ServerDescriptor ServerDetails
    {
      set { Server.ServerConfiguration = value; }
      get
      {
        ServerSelector.ServerDescriptor _descriptor = Server.ServerConfiguration;
        if (_descriptor == null)
          return null;
        if (!String.IsNullOrEmpty(_descriptor.codebase))
          _descriptor.codebase = RelativeFilePathsCalculator.TryComputeRelativePath(HomeDirectory, _descriptor.codebase); //TODO must refer to the plugin directory.
        if (!String.IsNullOrEmpty(_descriptor.configuration))
          _descriptor.configuration = RelativeFilePathsCalculator.TryComputeRelativePath(HomeDirectory, _descriptor.configuration);
        return _descriptor;
      }
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
    internal ITypeDesign FindType(XmlQualifiedName myType)
    {
      foreach (ProjectTreeNode node in this)
      {
        ITypeDesign ret = node.Find(myType);
        if (ret != null)
          return ret;
      }
      return null;
    }
    internal IInstanceConfiguration GetInstanceConfiguration(INodeDescriptor nodeUniqueIdentifier)
    {
      return Server.GetInstanceConfiguration(nodeUniqueIdentifier);
    }
    internal string HomeDirectory { get; private set; }  //TODO to be moved to IO
    #endregion

    #region ISolutionModel
    public void GetPluginMenuItems(ToolStripItemCollection menu)
    {
      ICollection<ToolStripItem> _items = new List<ToolStripItem>();
      Server.GetPluginMenuItems(_items);
      menu.AddRange(_items.ToArray<ToolStripItem>());
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
    //public Tuple<Opc.Ua.ModelCompiler.ModelDesign, string> ReadModelDesign(string filePath, Action<TraceMessage> tracer)
    //{
    //  return OPCFSolutionConfigurationManagement.DefaultInstance.ReadModelDesign(filePath, tracer);
    //}
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
    [Obsolete]
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      throw new NotImplementedException();
    }
    #endregion

    #region WrapperTreeNode
    internal protected override void RaiseOnChangeHandler()
    {
      m_OnChangeHandler?.Invoke(this, EventArgs.Empty);
      OnDataChanged?.Invoke(this, EventArgs.Empty);
    }
    protected override void CreateInstanceConfigurations(BaseTreeNode node, bool SkipOpeningConfigurationFile, out bool CancelWasPressed)
    {
      IConfiguration svr = Server.GetIServerConfiguration();
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
