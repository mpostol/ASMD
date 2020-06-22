//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UAOOI.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal partial class ModelObserver : SelectedItemObserver
  {
    #region constructor

    public ModelObserver() : base()
    {
      InitializeComponent();
      this.m_TreeView.ImageList = this.m_ImagesForNodes.ImageListNodes;
      m_TreeView.CoupledNodesAreEnabled = Settings.Default.CoupledNodesAreEnabled;
      //solution initialization:
      m_BackForwardTreViewToolStrip.TreeView = this.m_TreeView;
      m_SearchTreeViewToolStrip.TreeView = this.m_TreeView;
      m_SearchTreeViewToolStrip.SetAdditionalNodeTestDelegate = new SearchTreeViewHelper.AdditionalNodeTestDelegate(NodeSearchTest);
      m_FiltersControl = new FiltersControl();
      m_filterForm = new OKCancelForm("Set Filters...")
      {
        SetUserControl = m_FiltersControl
      };
      m_filterForm.CanBeAccepted(true);
      m_FiltersControlSettings = new FiltersControl.FilterSettings();
    }

    #endregion constructor

    #region internal

    internal void PerformNodeClassFiltering()
    {
      m_FiltersControl.MyFilterSettings = m_FiltersControlSettings;
      if (m_filterForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        m_FiltersControlSettings = m_FiltersControl.MyFilterSettings;
        m_TreeView.SetTypeFilter(m_FiltersControlSettings.AllTypes, m_FiltersControlSettings.SelectedTypes);
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

    internal bool ModelTreeViewIsFocused => this.m_TreeView.Focused;
    internal List<ToolStripMenuItem> GoToMenuItemList => m_TreeView.SelectedNode.GoToMenuItemList;

    internal bool CoupledNodesAreEnabled
    {
      get => m_TreeView.CoupledNodesAreEnabled;
      set => m_TreeView.CoupledNodesAreEnabled = value;
    }

    internal void ImportNodeSet()
    {
      m_Solution.ImportNodeSet();
    }

    internal void Build(TextWriter textWriterStream)
    {
      m_Solution.Build(textWriterStream);
    }

    internal void Save(bool prompt)
    {
      m_Solution.Save(prompt);
    }

    internal void GetImportMenu(ToolStripItemCollection items)
    {
      //TODO NullReferenceException after opening the file\import menu before selecting the root node in the TreeView #88 - root node is not selected after starting the application.
      this.m_TreeView.SelectedNode.GetImportMenu(items);
    }

    internal void GetServerUAMenu(ToolStripItemCollection toolStripItemCollection)
    {
      m_Solution.GetPluginMenuItems(toolStripItemCollection);
      IInstanceDesignTreeNode _sn = SelectedNode as IInstanceDesignTreeNode;
      if (_sn == null)
        return;
      _sn.GetServerUAMenu(toolStripItemCollection);
    }

    #endregion internal

    #region private

    //vars
    private OKCancelForm m_filterForm;

    private FiltersControl m_FiltersControl;
    private FiltersControl.FilterSettings m_FiltersControlSettings;
    private TreeNode m_SelectedTreeNode = null;
    private SolutionTreeNode m_Solution = null;

    //methods
    private bool NodeSearchTest(TreeNode FoundNode)
    {
      IWrapperTreeNode IWrapperTreeNodeFoundNode = FoundNode as IWrapperTreeNode;
      if (IWrapperTreeNodeFoundNode == null)
        return false;
      return IWrapperTreeNodeFoundNode.Wrapper4PropertyGrid != null;
    }

    private void AddSolution(ISolutionConfigurationManagement Solution)
    {
      m_TreeView.Nodes.Clear();
      m_Solution = new SolutionTreeNode(new ToForms.MessageBoxHandling(), Solution, (x, y) => Solution.SetChangesArePresent(), x => m_TreeView.Nodes.Add(new LibraryTreeNodeControl(x)));
      SolutionTreeNodeControl _solutionRootTreeNode = new SolutionTreeNodeControl(m_Solution);
      m_Solution.OnDataChanged += new EventHandler<EventArgs>(Solution_OnDataChanged);
      m_TreeView.Nodes.Insert(0, _solutionRootTreeNode);
      this.SelectedNode = _solutionRootTreeNode;
      _solutionRootTreeNode.Expand();
      m_TreeView.SelectedNode = _solutionRootTreeNode;
      m_TreeView.RebuildDictionary();
      Refresh();
    }

    private void Solution_OnDataChanged(object sender, EventArgs e)
    {
      this.Refresh();
      AfterSolution_OnDataChanged(sender, e);
    }

    private void m_TreeView_AfterSelect(object sender, DictionaryTreeView.DictionaryTreeViewEventArgs e)
    {
      IValidate node = m_TreeView.SelectedNode as IValidate;
      if (node != null)
        node.Validate();
      SelectedNode = e.Node;
      IWrapperTreeNode child = e.Node as IWrapperTreeNode;
      if (child == null)
        return;
      SelectedItemEventArgs args = new SelectedItemEventArgs(child, false);
      RaiseSelectedItemIsChanged(args);
    }

    protected override void AfterSolutionChange(object sender, SolutionConfigurationManagementRoot.AfterSolutionChangeEventArgs e)
    {
      this.AddSolution(e.Solution);
    }

    protected override void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
      if (e.SelectedIModelNode == null || e.SelectedIModelNode.SymbolicName == null)
        return;
      m_TreeView.GoToNode(e.SelectedIModelNode.SymbolicName);
    }

    private void m_TreeView_RefreshNeeded(object sender, DictionaryTreeView.RefreshScopeEventArgs e)
    {
      //TODO: this event occurs when Selected node is changed - maybe we can remove it??
      UniqueIdentifier ui = new UniqueIdentifier();
      if (!m_TreeView.SelectedNode.GetUniqueIdentifier(ui))
        ui = null;
      //TODO uncomment
      //SelectedItemEventArgs args = new SelectedItemEventArgs(m_TreeView.SelectedNode.BaseModelNode, false);
      //RaiseSelectedItemIsChanged(args);
    }

    private TreeNode SelectedNode
    {
      get => m_SelectedTreeNode;
      set
      {
        if (m_SelectedTreeNode != null)
          m_SelectedTreeNode.BackColor = Color.Empty;
        m_SelectedTreeNode = value;
        if (m_SelectedTreeNode != null)
          m_SelectedTreeNode.BackColor = Color.LightGray;
      }
    }

    private void toolStripButton_filter_Click(object sender, System.EventArgs e)
    {
      PerformNodeClassFiltering();
    }

    #endregion private
  }
}