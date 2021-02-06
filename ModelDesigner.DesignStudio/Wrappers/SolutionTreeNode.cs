﻿//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.ToForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using UAOOI.Configuration.Core;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal interface ISolutionModel : IBaseModel
  {
    void GetPluginMenuItems(System.Windows.Forms.ToolStripItemCollection items);

    void AddProject(bool existing);

    void ImportNodeSet();

    void Save(bool prompt);

    void Open(IGraphicalUserInterface gui);

    void OnNew(IGraphicalUserInterface gui);
  }

  internal interface ISolutionTreeNodeUI : IBaseModel
  {
    /// <summary>
    /// Gets the home directory.
    /// </summary>
    /// <value>The home directory.</value>
    ISolutionDirectoryPathManagement HomeDirectory { get; }

    /// <summary>
    /// Gets the UI to select a server plug-in.
    /// </summary>
    /// <value>An instance of <see cref="ServerSelector"/> used by a software user to select a server plug-in.</value>
    ServerSelector Server { get; }
  }

  /// <summary>
  /// The class representing the solution node in the model.
  /// </summary>
  internal class SolutionTreeNode : WrapperTreeNode, IViewModel, ISolutionModel, ISolutionTreeNodeUI
  {
    #region private

    private readonly EventHandler m_OnChangeHandler = null;

    private void configuration_OnNameChanged(object sender, EventArgs e)
    {
    }

    private void AddProjectsNodes(IEnumerable<IProjectConfigurationManagement> configuration)
    {
      if (configuration == null)
        return;
      List<ProjectTreeNode> _nodes = new List<ProjectTreeNode>();
      foreach (IProjectConfigurationManagement _projectDescriptor in configuration)
      {
        ProjectTreeNode _newProject = null;
        try
        {
          _newProject = new ProjectTreeNode(_projectDescriptor);
          _nodes.Add(_newProject);
        }
        catch (FileNotFoundException _ex)
        {
          this.MessageBoxHandling.Show(string.Format(Resources.ProjectFileNotFound_Info, _ex.Message), Resources.ProjectFileNotFound_Header, ToForms.MessageBoxButtons.OK, ToForms.MessageBoxIcon.Error);
        }
        catch (Exception _ex)
        {
          this.MessageBoxHandling.Show(string.Format(Properties.Resources.Project_FileOpenError, _ex.Message), Properties.Resources.Project_OpenFileCaption, ToForms.MessageBoxButtons.OK, ToForms.MessageBoxIcon.Error);
        }
      }
      this.AddRange(_nodes);
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
        ServerSelector.ServerDescriptor _descriptor = this.Server.ServerConfiguration;
        if (_descriptor == null)
          return null;
        if (!string.IsNullOrEmpty(_descriptor.Codebase))
          _descriptor.Codebase = RelativeFilePathsCalculator.TryComputeRelativePath(HomeDirectory.DefaultDirectory, _descriptor.Codebase);
        if (!string.IsNullOrEmpty(_descriptor.Configuration))
          _descriptor.Configuration = RelativeFilePathsCalculator.TryComputeRelativePath(HomeDirectory.DefaultDirectory, _descriptor.Configuration);
        return _descriptor;
      }
    }

    /// <summary>
    /// Gets or sets the library root.
    /// </summary>
    /// <value>The library root.</value>
    private Libraries LibraryRoot { get; set; } = new Libraries();

    #endregion private

    #region constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="SolutionTreeNode" /> class.
    /// </summary>
    /// <param name="messageBoxHandling">The Message Box instance to provide messages on the screen.</param>
    /// <param name="solution">The configuration.</param>
    /// <param name="OnChangeHandler">The on change handler.</param>
    /// <param name="creteLibraryTreeNode">The call back to create <see cref="LibraryTreeNode"/>.</param>
    /// <exception cref="ArgumentNullException">configuration
    /// or
    /// messageBoxHandling</exception>
    internal SolutionTreeNode(IMessageBoxHandling messageBoxHandling, ISolutionConfigurationManagement solution, EventHandler<EventArgs> OnChangeHandler, Action<LibraryTreeNode> creteLibraryTreeNode) :
      base(null, solution == null ? Guid.NewGuid().ToString() : solution.Name)
    {
      MessageBoxHandling = messageBoxHandling ?? throw new ArgumentNullException(nameof(messageBoxHandling));
      m_ISolutionConfigurationManagement = solution ?? throw new ArgumentNullException(nameof(solution), $"In constructor {nameof(SolutionTreeNode)} this argument must not be null.");
      Server.OnConfigurationChanged += new EventHandler<UAServerConfigurationEventArgs>(Server_OnConfigurationChanged);
      //TODO OnDataChanged += OnChangeHandler;
      //TODO OnNameChanged += new EventHandler(configuration_OnNameChanged);
      AddProjectsNodes(solution.Projects);
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 325542572, "Creating Libraries");
      SolutionRoot = this;
      LibraryRoot.AddNodes(creteLibraryTreeNode);
    }

    #endregion constructor

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

    #endregion WrapperTreeNode

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

    /// <summary>
    /// Builds the solution and write any massages to specified output.
    /// </summary>
    /// <param name="traceMessage">Delegate to trace message.</param>
    internal void Build(Action<string> traceMessage)
    {
      Save(false);
      traceMessage(Resources.Build_all);
      foreach (ProjectTreeNode _project in this)
        _project.Build(traceMessage);
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
    /// <param name="typeName">The type name to find.</param>
    /// <returns></returns>
    internal ITypeDesign FindType(XmlQualifiedName typeName)
    {
      foreach (ProjectTreeNode node in this)
      {
        ITypeDesign ret = node.Find(typeName);
        if (ret != null)
          return ret;
      }
      return LibraryRoot.FindType(typeName);
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

    private readonly ISolutionConfigurationManagement m_ISolutionConfigurationManagement;

    #endregion public

    #region ISolutionTreeNodeUI

    /// <summary>
    /// Gets the UI to select a server plug-in.
    /// </summary>
    /// <value>An instance of <see cref="ServerSelector" /> used by a software user to select a server plug-in.</value>
    public ServerSelector Server => m_ISolutionConfigurationManagement.ServerSelector;

    public ISolutionDirectoryPathManagement HomeDirectory => m_ISolutionConfigurationManagement ?? throw new System.ArgumentNullException();

    #endregion ISolutionTreeNodeUI

    #region ISolutionModel

    public void GetPluginMenuItems(System.Windows.Forms.ToolStripItemCollection menu)
    {
      ICollection<System.Windows.Forms.ToolStripItem> _items = new List<System.Windows.Forms.ToolStripItem>();
      Server.GetPluginMenuItems(_items);
      menu.AddRange(_items.ToArray<ToolStripItem>());
    }

    public void AddProject(bool existing)
    {
      if (existing)
        m_ISolutionConfigurationManagement.ImportModelDesign();
      else
        m_ISolutionConfigurationManagement.NewModelDesign();
    }

    public void ImportNodeSet()
    {
      m_ISolutionConfigurationManagement.ImportNodeSet();
    }

    public void Save(bool prompt)
    {
      foreach (ProjectTreeNode _project in this)
        _project.Save();
      m_ISolutionConfigurationManagement.Save(prompt);
    }

    public void Open(IGraphicalUserInterface gui)
    {
      SolutionConfigurationManagementRoot.OpenExisting(null, gui);
    }

    public void OnNew(IGraphicalUserInterface gui)
    {
      SolutionConfigurationManagementRoot.NewSoliution(gui);
    }

    #endregion ISolutionModel

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

    #endregion WrapperTreeNode

    #region Diagnostics

    /// <summary>
    /// Gets the libraries.
    /// </summary>
    /// <param name="callBack">The call back.</param>
    [System.Diagnostics.Conditional("DEBUG")]
    internal void GetLibraries(Action<Libraries> callBack)
    {
      callBack(LibraryRoot);
    }

    #endregion Diagnostics
  }
}