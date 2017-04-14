//<summary>
//  Title   : ModelObserver - this control contains the DictionaryTreeView with the model
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.Lib.ControlLibrary;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal partial class ModelObserver: MainController.SelectedItemObserver
  {

    #region creator
    public ModelObserver()
    {
      InitializeComponent();
      this.m_TreeView.ImageList = this.m_ImagesForNodes.ImageListNodes;
      m_TreeView.CoupledNodesAreEnabled = Settings.Default.CoupledNodesAreEnabled;
      //solution initialization:
      OPCFSolutionConfigurationManagement.DefaultInstance.AddLibrariesTreeNodes( m_TreeView.Nodes );
      this.AddSolution( OPCFSolutionConfigurationManagement.DefaultInstance.SolutionRootNode.GetTreeNode() );
      //toolstrip initialization:
      m_BackForwardTreViewToolStrip.TreeView = this.m_TreeView;
      m_SearchTreeViewToolStrip.TreeView = this.m_TreeView;
      m_SearchTreeViewToolStrip.SetAdditionalNodeTestDelegate = new SearchTreeViewHelper.AdditionalNodeTestDelegate( NodeSearchTest );
      //filtering initialization:
      m_filterform = new OKCancelForm( "Set Filters..." );
      m_FiltersControl = new FiltersControl();
      m_filterform.SetUserControl = m_FiltersControl;
      m_filterform.CanBeAccepted( true );
      m_FiltersControlSettings = new FiltersControl.FilterSettings();
    }
    #endregion creator

    #region internal
    internal void PerformNodeClassFiltering()
    {
      m_FiltersControl.MyFilterSettings = m_FiltersControlSettings;
      if ( m_filterform.ShowDialog() == DialogResult.OK )
      {
        m_FiltersControlSettings = m_FiltersControl.MyFilterSettings;
        m_TreeView.SetTypeFilter( m_FiltersControlSettings.AllTypes, m_FiltersControlSettings.SelectedTypes );
      }
    }
    internal void NavigateModelTreeViewForward()
    {
      m_BackForwardTreViewToolStrip.GoForward();
    }
    internal void NavigateModelTreeViewBackward()
    {
      m_BackForwardTreViewToolStrip.GoBackward();
    }
    internal bool ModelTreeViewIsFocused
    {
      get
      {
        return this.m_TreeView.Focused;
      }
    }
    internal List<ToolStripMenuItem> GoToMenuItemList
    {
      get
      {
        if ( m_TreeView.SelectedNode != null )
        {
          DictionaryTreeView.DictionaryTreeNode dTn = m_TreeView.SelectedNode as DictionaryTreeView.DictionaryTreeNode;
          if ( dTn != null )
          {
            return dTn.GoToMenuItemList;
          }
        }
        return null;
      }
    }
    internal bool CoupledNodesAreEnabled
    {
      get { return m_TreeView.CoupledNodesAreEnabled; }
      set { m_TreeView.CoupledNodesAreEnabled = value; }
    }
    internal void GetImportMenu( ToolStripItemCollection items )
    {
      this.m_TreeView.SelectedNode.GetImportMenu( items );
    }
    internal void GetServerUAMenu( ToolStripItemCollection toolStripItemCollection )
    {
      IInstanceDesignTreeNode cn = SelectedNode as IInstanceDesignTreeNode;
      if ( cn == null )
        return;
      cn.GetServerUAMenu( toolStripItemCollection );
    }
    #endregion internal

    #region private
    //vars
    private OKCancelForm m_filterform;
    private FiltersControl m_FiltersControl;
    private FiltersControl.FilterSettings m_FiltersControlSettings;
    private TreeNode m_SelectedTreeNode = null;
    //methods
    private bool NodeSearchTest( TreeNode FoundNode )
    {
      IWrapperTreeNode IWrapperTreeNodeFoundNode = FoundNode as IWrapperTreeNode;
      if ( IWrapperTreeNodeFoundNode == null )
        return false;
      return IWrapperTreeNodeFoundNode.Wrapper4PropertyGrid != null;
    }
    private void AddSolution( DictionaryTreeView.DictionaryTreeNode SolutionRootTreeNode )
    {
      m_TreeView.AddSolution( SolutionRootTreeNode );
      m_TreeView.RebuildDictionary();
    }
    private void m_TreeView_AfterSelect( object sender, DictionaryTreeView.DictionaryTreeViewEventArgs e )
    {
      IValidate node = m_TreeView.SelectedNode as IValidate;
      if ( node != null )
        node.Validate();
      SelectedNode = e.Node;
      IWrapperTreeNode child = e.Node as IWrapperTreeNode;
      if ( child == null )
        return;
      SelectedItemEventArgs args =
        new SelectedItemEventArgs( child, false );
      RaiseSelectedItemIsChanged( args );
    }
    protected override void AfterSolutionChange( object sender, OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs e )
    {
      this.AddSolution( e.Solution.GetTreeNode() );
    }
    protected override void OnSelectedItemIsChanged( object sender, SelectedItemEventArgs e )
    {
      if ( e.SelectedIModelNode == null || e.SelectedIModelNode.SymbolicName == null )
        return;
      m_TreeView.GoToNode( e.SelectedIModelNode.SymbolicName );
    }
    private void m_TreeView_RefreshNeeded( object sender, DictionaryTreeView.RefreshScopeEventArgs e )
    {
      //TODO: this event occurs when Selected node is changed - maybe we can remove it??
      UniqueIdentifier ui = new UniqueIdentifier();
      if ( !m_TreeView.SelectedNode.GetUniqueIdentifier( ui ) )
        ui = null;
      SelectedItemEventArgs args =
        new SelectedItemEventArgs( (IWrapperTreeNode)m_TreeView.SelectedNode, false );
      RaiseSelectedItemIsChanged( args );
    }
    private TreeNode SelectedNode
    {
      get { return m_SelectedTreeNode; }
      set
      {
        if ( m_SelectedTreeNode != null )
          m_SelectedTreeNode.BackColor = Color.Empty;
        m_SelectedTreeNode = value;
        if ( m_SelectedTreeNode != null )
          m_SelectedTreeNode.BackColor = Color.LightGray;
      }
    }
    private void toolStripButton_filter_Click( object sender, System.EventArgs e )
    {
      PerformNodeClassFiltering();
    }
    #endregion private

  }
}
