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

using CAS.CommServer.UA.Common;
using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Singleton class to save and restore solution configuration to/from external file.
  /// </summary>
  internal class OPCFSolutionConfigurationManagement : TypeGenericConfigurationManagement<UAModelDesignerSolution>, IBaseDirectoryProvider
  {
    #region private
    private static OPCFSolutionConfigurationManagement m_This;
    private string LastOpenedFile = string.Empty;
    protected override string ReadErrorInvalidOperationStringFormat
    {
      get
      {
        return Resources.OPCFSolutionConfigurationManagement_ReadError;
      }
    }
    private void m_TSMI_AddProject_New_Click(object sender, System.EventArgs e)
    {
      SolutionRootNode.AddProject(false);
    }
    private void m_TSMI_AddProject_Existing_Click(object sender, System.EventArgs e)
    {
      SolutionRootNode.AddProject(true);
    }
    private void ImportNodeSetHandler(object sender, EventArgs e)
    {
      SolutionRootNode.ImportNodeSetHandler(sender, e);
    }
    private void OnConfigurationChnged(object sender, OPCFSolutionConfigurationManagement.ConfigurationEventArg e)
    {
      if (e.Configuration == null)
        e.Configuration = EmptyModel;
      e.Configuration.SetHomeDirectory(Path.GetDirectoryName(DefaultFileName));
      SolutionRootNode = new PrivateSolution(this, e.Configuration, e.Configuration.Name, new EventHandler<EventArgs>(OnNodeChange));
    }
    private void OnNodeChange(object sender, EventArgs e)
    {
      SetChangesArePresent();
    }
    /// <summary>
    /// Solution representation in the whole environment.
    /// </summary>
    private class PrivateSolution : SolutionTreeNode
    {
      #region creator
      public PrivateSolution(OPCFSolutionConfigurationManagement parent, UAModelDesignerSolution configuration, string nodeName, EventHandler<EventArgs> OnChangeHandler) :
        base(configuration, nodeName, OnChangeHandler)
      {
        m_Parent = parent;
      }
      #endregion

      #region public
      /// <summary>
      /// Gets the tree node and all children.
      /// </summary>
      /// <returns>
      /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
      /// </returns>
      internal override DictionaryTreeView.DictionaryTreeNode GetTreeNode()
      {
        return new TreeNode(this);
      }
      #endregion

      #region private
      private OPCFSolutionConfigurationManagement m_Parent;
      private class TreeNode : SolutionTreeNode.TreeNode<PrivateSolution>
      {
        public TreeNode(PrivateSolution parent)
          : base(parent)
        { }
        /// <summary>
        /// Before the menu strip opening.
        /// </summary>
        protected override void BeforeMenuStripOpening()
        {
          Creator.m_Parent.AddItemsToMenu(this.ContextMenuStrip);
          base.BeforeMenuStripOpening();
        }
      }
      #endregion
    }
    private UAModelDesignerSolution EmptyModel
    {
      get { return new UAModelDesignerSolution(DefaultFileName, Resources.DefaultSolutionName); }
    }
    protected override TypeGenericConfigurationManagement<UAModelDesignerSolution>.Configuration GetConfiguration
    {
      get
      {
        string homeDirectory = Path.GetDirectoryName(this.DefaultFileName);
        UAModelDesignerSolution solution = SolutionRootNode.SaveProjectsCreateConfiguration(homeDirectory);
        TypeGenericConfigurationManagement<UAModelDesignerSolution>.Configuration config;
        config.Data = solution;
        config.XmlNamespaces = null;
        return config;
      }
    }
    private Libraries m_Libraries;
    private void RaiseAfterSolutionChange(SolutionTreeNode solution)
    {
      if (AfterSolutionChange == null)
        return;
      AfterSolutionChange(this, new AfterSolutionChangeEventArgs(solution));
    }
    private SolutionTreeNode m_Root;
    private void CommonInitialization()
    {
      TraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 144, "Starting CommonInitialization and checking SaveConstrain");
      SaveConstrain.CheckConstrain();
      TraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 146, "Creating Libraries");
      m_Libraries = new Libraries(this.Components);
      // 
      // OpenFileDialog
      // 
      TraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 151, "Updating Settings Open File Dialog");
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
      TraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 162, "Updating Settings Save File Dialog");
      UpdateSettingsSaveFileDialog
        (
          Resources.Solution_FileDialogDefaultExt,
          Path.Combine(DefaultDirectory, Resources.Solution_FileDialogDefaultFilename),
          Resources.Solution_FileDialogFilter,
          Resources.Solution_FileDialogTitle
        );
      BaseDirectoryHelper.Instance.SetBaseDirectoryProvider(this);
      ConfigurationChanged += new EventHandler<OPCFSolutionConfigurationManagement.ConfigurationEventArg>(OnConfigurationChnged);
      TraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 172, "Creating new private solution using Empty model");
      SolutionRootNode = new PrivateSolution(this, EmptyModel, "Solution", new EventHandler<EventArgs>(OnNodeChange));
      BeforeRead += new EventHandler<StringEventArgs>(OPCFSolutionConfigurationManagement_BeforeRead);
      if (string.IsNullOrEmpty(Settings.Default.DefaultSolutionFileName))
      {
        Settings.Default.DefaultSolutionFileName = DefaultFileName;
        Settings.Default.Save();
      }
      TraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 146, "Finished successfully CommonInitialization");
    }
    private void OPCFSolutionConfigurationManagement_BeforeRead(object sender, StringEventArgs e)
    {
      LastOpenedFile = e.String;
    }
    public OPCFSolutionConfigurationManagement()
      : base()
    { }
    public OPCFSolutionConfigurationManagement(IContainer container)
      : base(container)
    { }
    #endregion

    #region internal singleton
    internal static OPCFSolutionConfigurationManagement DefaultInstance
    {
      get
      {
        if (m_This == null)
        {
          try
          {
            TraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 204, "Creating new instance OPCFSolutionConfigurationManagement");
            m_This = new OPCFSolutionConfigurationManagement();
            m_This.CommonInitialization();
            m_This.DefaultDirectory = global::CAS.UA.Model.Designer.Properties.Resources.SolutionTreeNode;
            m_This.DefaultFileName = "UAModelDesignerSolution";
          }
          catch (Exception ex)
          {
            string _tmp = "Cannot initialize {0} at {1} because of exception: {2}.";
            TraceEvent.Tracer.TraceEvent(TraceEventType.Critical, 212, String.Format(_tmp, typeof(OPCFSolutionConfigurationManagement).FullName, DefaultInstance, ex.Message));
            throw;
          }
        }
        return m_This;
      }
    }
    #region override
    public override bool Save(bool prompt)
    {
      if (!base.Save(prompt))
        return false;
      return true;
    }
    public override void New()
    {
      DefaultFileName = Settings.Default.DefaultSolutionFileName;
      base.New();
    }
    #endregion override
    internal override void AddItemsToMenu(ContextMenuStrip contextMenuStrip)
    {
      base.AddItemsToMenu(contextMenuStrip);
      if (contextMenuStrip.Items.Count > 0)
        contextMenuStrip.Items.Add(new ToolStripSeparator());
      contextMenuStrip.Items.Add(MenuFactory.AddProject(m_TSMI_AddProject_New_Click, m_TSMI_AddProject_Existing_Click));
      contextMenuStrip.Items.Add(MenuFactory.ImportSubmenu(new ToolStripMenuItem[] { MenuFactory.ImportNodeSetMenuItem(ImportNodeSetHandler) }));
    }
    internal void AddLibrariesTreeNodes(TreeNodeCollection nodes)
    {
      m_Libraries.AddTreeNodes(nodes);
    }
    internal class AfterSolutionChangeEventArgs : EventArgs
    {
      public SolutionTreeNode Solution { get; private set; }
      public AfterSolutionChangeEventArgs(SolutionTreeNode solution)
      {
        Solution = solution;
      }
    }
    internal event EventHandler<AfterSolutionChangeEventArgs> AfterSolutionChange;
    internal SolutionTreeNode SolutionRootNode
    {
      get { { return m_Root; }; }
      private set
      {
        m_Root = value;
        RaiseAfterSolutionChange(value);
      }
    }
    internal void GetServerUAMenu(ToolStripItemCollection toolStripItemCollection)
    {
      SolutionRootNode.GetServerUAMenu(toolStripItemCollection);
    }
    internal static bool IsLicensed
    {
      get { return SaveConstrain.IsLicensed; }
    }
    #region IBaseDirectoryProvider Members
    string IBaseDirectoryProvider.GetBaseDirectory()
    {
      if (!string.IsNullOrEmpty(LastOpenedFile))
        return Path.GetDirectoryName(LastOpenedFile);
      string assemblyLocation = Assembly.GetExecutingAssembly().Location;
      string assemblydirectory = string.Empty;
      if (!string.IsNullOrEmpty(assemblyLocation))
        assemblydirectory = Path.GetDirectoryName(assemblyLocation);
      if (!string.IsNullOrEmpty(SolutionRootNode.CurrentSoultionDirectory) && SolutionRootNode.CurrentSoultionDirectory != assemblydirectory)
        return SolutionRootNode.CurrentSoultionDirectory;
      return string.Empty;
    }
    #endregion
    #endregion
  }
}
