//<summary>
//  Title   : Class to save and restore solution configuration to/from external file.
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Solution;
using System;
using System.Diagnostics;
using System.IO;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Singleton class to save and restore solution configuration to/from external file.
  /// </summary>
  internal class OPCFSolutionConfigurationManagement : TypeGenericConfigurationManagement<UAModelDesignerSolution>//, IBaseDirectoryProvider
  {

    #region private
    private static OPCFSolutionConfigurationManagement m_This;
    private string m_LastOpenedFile = string.Empty;
    protected override string ReadErrorInvalidOperationStringFormat
    {
      get
      {
        return Resources.OPCFSolutionConfigurationManagement_ReadError;
      }
    }
    //private void m_TSMI_AddProject_New_Click(object sender, System.EventArgs e)
    //{
    //  SolutionRootNode.AddProject();
    //}
    //private void m_TSMI_AddProject_Existing_Click(object sender, System.EventArgs e)
    //{
    //  SolutionRootNode.AddProject(x => AssemblyTraceEvent.TraceMessage(x, nameof(m_TSMI_AddProject_Existing_Click), 54), ReadModelDesign);
    //}
    //private void ImportNodeSetHandler(object sender, EventArgs e)
    //{
    //  SolutionRootNode.ImportNodeSetHandler(sender, e);
    //}
    protected override void RaiseConfigurationChanged(UAModelDesignerSolution model)
    {
      base.RaiseConfigurationChanged(model);
      if (model == null)
        model = UAModelDesignerSolution.CreateEmptyModel();
      AfterSolutionChange?.Invoke(this, new AfterSolutionChangeEventArgs(model));
      //e.Configuration.SetHomeDirectory(Path.GetDirectoryName(DefaultFileName));
      //SolutionRootNode = new SolutionTreeNode(e.Configuration, new ViewModelFactory(), Path.GetDirectoryName(DefaultFileName), new EventHandler<EventArgs>(OnNodeChange));
    }
    //private void OnNodeChange(object sender, EventArgs e)
    //{
    //  SetChangesArePresent();
    //}
    /// <summary>
    /// Solution representation in the whole environment.
    /// </summary>
    //private class PrivateSolution : SolutionTreeNode
    //{
    //  #region creator
    //  public PrivateSolution(OPCFSolutionConfigurationManagement parent, UAModelDesignerSolution configuration, IViewModelFactory viewModelFactory, string solutionPath, EventHandler<EventArgs> OnChangeHandler) :
    //    base(configuration, viewModelFactory, solutionPath, OnChangeHandler)
    //  {
    //    m_Parent = parent;
    //  }
    //  #endregion

    //  #region public
    //  ///// <summary>
    //  ///// Gets the tree node and all children.
    //  ///// </summary>
    //  ///// <returns>
    //  ///// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    //  ///// </returns>
    //  //internal override DictionaryTreeView.DictionaryTreeNode GetTreeNode()
    //  //{
    //  //  return new TreeNode(this);
    //  //}
    //  #endregion

    //  #region private
    //  private OPCFSolutionConfigurationManagement m_Parent;
    //  //private class TreeNode : SolutionTreeNode.TreeNode<PrivateSolution>
    //  //{
    //  //  public TreeNode(PrivateSolution parent)
    //  //    : base(parent)
    //  //  { }
    //  //  /// <summary>
    //  //  /// Before the menu strip opening.
    //  //  /// </summary>
    //  //  protected override void BeforeMenuStripOpening()
    //  //  {
    //  //    Creator.m_Parent.AddItemsToMenu(this.ContextMenuStrip);
    //  //    base.BeforeMenuStripOpening();
    //  //  }
    //  //}
    //  #endregion

    //}
    private void CommonInitialization()
    {
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 144, "Starting CommonInitialization and checking SaveConstrain");
      //SaveConstrain.CheckConstrain();
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 146, "Creating Libraries");
      // 
      // OpenFileDialog
      // 
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 151, "Updating Settings Open File Dialog");
      UpdateSettingsOpenFileDialog
        (
          Resources.Solution_FileDialogDefaultExt,
          Path.Combine(DefaultDirectory, Resources.Solution_FileDialogDefaultFilename),
          Resources.Solution_FileDialogFilter,
          Resources.Solution_FileDialogTitle
        );
      // 
      // SaveFileDialog
      // 
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 162, "Updating Settings Save File Dialog");
      UpdateSettingsSaveFileDialog
        (
          Resources.Solution_FileDialogDefaultExt,
          Path.Combine(DefaultDirectory, Resources.Solution_FileDialogDefaultFilename),
          Resources.Solution_FileDialogFilter,
          Resources.Solution_FileDialogTitle
        );
      //ConfigurationChanged = new EventHandler<OPCFSolutionConfigurationManagement.ConfigurationEventArg>(OnConfigurationChanged);
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 172, "Creating new private solution using Empty model");
      //SolutionRootNode = new PrivateSolution(this, UAModelDesignerSolution.CreateEmptyModel(), new ViewModelFactory(), DefaultDirectory, new EventHandler<EventArgs>(OnNodeChange));
      BeforeRead += new EventHandler<StringEventArgs>(OPCFSolutionConfigurationManagement_BeforeRead);
      if (string.IsNullOrEmpty(Settings.Default.DefaultSolutionFileName))
      {
        Settings.Default.DefaultSolutionFileName = DefaultFileName;
        Settings.Default.Save();
      }
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 146, "Finished successfully CommonInitialization");
    }
    private void OPCFSolutionConfigurationManagement_BeforeRead(object sender, StringEventArgs e)
    {
      m_LastOpenedFile = e.String;
    }
    private OPCFSolutionConfigurationManagement()
        : base()
    { }
    #endregion

    #region override
    protected override XmlFile.DataToSerialize<UAModelDesignerSolution> GetConfiguration(UAModelDesignerSolution configuration)
    {
      string homeDirectory = Path.GetDirectoryName(this.DefaultFileName);
      XmlFile.DataToSerialize<UAModelDesignerSolution> _config;
      _config.Data = configuration;
      _config.XmlNamespaces = null;
      _config.StylesheetName = "UAModelDesignerSolution.xslt";
      return _config;
    }
    //public override bool Save(bool prompt)
    //{
    //  if (!base.Save(prompt))
    //    return false;
    //  return true;
    //}
    public override void New()
    {
      DefaultFileName = Settings.Default.DefaultSolutionFileName;
      base.New();
    }
    ///// <summary>
    ///// Creates a configurable tree node.
    ///// </summary>
    ///// <param name="nodeCopnfiguration">The node copnfiguration.</param>
    ///// <returns>An inctance of <see cref="!:TypeForConfiguration" /> represnting the node of the navigation tree.</returns>
    ///// <exception cref="System.NotImplementedException"></exception>
    //protected override UAModelDesignerSolutionWrapper CreateTreeNode(UAModelDesignerSolution nodeCopnfiguration)
    //{
    //  SolutionRootNode = new PrivateSolution(this, nodeCopnfiguration, new ViewModelFactory(), this.DefaultDirectory, OnNodeChange);
    //  return (UAModelDesignerSolutionWrapper)this.SolutionRootNode.Wrapper4PropertyGrid;
    //}
    #endregion override

    #region internal singleton
    internal static OPCFSolutionConfigurationManagement DefaultInstance
    {
      get
      {
        if (m_This == null)
        {
          try
          {
            AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 204, "Creating new instance OPCFSolutionConfigurationManagement");
            m_This = new OPCFSolutionConfigurationManagement();
            m_This.CommonInitialization();
            m_This.DefaultDirectory = global::CAS.UA.Model.Designer.Properties.Resources.SolutionTreeNode;
            m_This.DefaultFileName = "UAModelDesignerSolution";
          }
          catch (Exception ex)
          {
            string _tmp = "Cannot initialize {0} at {1} because of exception: {2}.";
            AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Critical, 212, String.Format(_tmp, typeof(OPCFSolutionConfigurationManagement).FullName, DefaultInstance, ex.Message));
            throw;
          }
        }
        return m_This;
      }
    }
    //internal override void AddItemsToMenu(ContextMenuStrip contextMenuStrip)
    //{
    //  base.AddItemsToMenu(contextMenuStrip);
    //  if (contextMenuStrip.Items.Count > 0)
    //    contextMenuStrip.Items.Add(new ToolStripSeparator());
    //  contextMenuStrip.Items.Add(MenuFactory.AddProject(m_TSMI_AddProject_New_Click, m_TSMI_AddProject_Existing_Click));
    //  contextMenuStrip.Items.Add(MenuFactory.ImportSubmenu(new ToolStripMenuItem[] { MenuFactory.ImportNodeSetMenuItem(ImportNodeSetHandler) }));
    //}
    internal class AfterSolutionChangeEventArgs : EventArgs
    {
      public UAModelDesignerSolution Solution { get; private set; }
      public AfterSolutionChangeEventArgs(UAModelDesignerSolution solution)
      {
        Solution = solution;
      }
    }
    internal event EventHandler<AfterSolutionChangeEventArgs> AfterSolutionChange;
    //internal UAModelDesignerSolution SolutionRootNode
    ////{
    //  get { { return m_Root; }; }
    //  private set
    //  {
    //    m_Root = value;
    //    RaiseAfterSolutionChange(value);
    //  }
    //}
    //internal void GetServerUAMenu(ToolStripItemCollection toolStripItemCollection)
    //{
    //  Root.SolutionRoot.GetServerUAMenu(toolStripItemCollection);
    //}
    //internal static bool IsLicensed
    //{
    //  get { return SaveConstrain.IsLicensed; }
    //}
    #endregion

    //#region IBaseDirectoryProvider Members
    //string IBaseDirectoryProvider.GetBaseDirectory()
    //{
    //  if (!string.IsNullOrEmpty(m_LastOpenedFile))
    //    return Path.GetDirectoryName(m_LastOpenedFile);
    //  string _assemblyLocation = Assembly.GetExecutingAssembly().Location;
    //  string _assemblyDirectory = string.Empty;
    //  if (!string.IsNullOrEmpty(_assemblyLocation))
    //    _assemblyDirectory = Path.GetDirectoryName(_assemblyLocation);
    //  if (!string.IsNullOrEmpty( SolutionRootNode.HomeDirectory) && SolutionRootNode.HomeDirectory != _assemblyDirectory)
    //    return SolutionRootNode.HomeDirectory;
    //  return string.Empty;
    //}
    //#endregion

  }
}
