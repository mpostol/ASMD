//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace CAS.UA.Model.Designer.Controls
{
  /// <summary>
  /// TreeView supporting dictionary lookup.
  /// </summary>
  internal partial class DictionaryTreeView : TreeView
  {
    #region creator
    public DictionaryTreeView()
    {
      InitializeComponent();
      Dictionary = new Dictionary<XmlQualifiedName, DictionaryTreeNode>();
      base.AfterSelect += new TreeViewEventHandler(DictionaryTreeView_AfterSelect);
      this.NodeMouseClick += new TreeNodeMouseClickEventHandler(DictionaryTreeView_NodeMouseClick);
    }
    internal void AddIfNew(XmlQualifiedName name, DictionaryTreeNode node)
    {
      if (Dictionary.TryGetValue(name, out DictionaryTreeNode value))
        return;
      Dictionary.Add(name, node);
    }
    #endregion

    #region classes
    internal delegate void DictionaryTreeViewEventHandler(object sender, DictionaryTreeViewEventArgs e);
    internal class DictionaryTreeViewEventArgs : TreeViewEventArgs
    {
      /// <summary>
      /// Initializes a new instance of the <see cref="DictionaryTreeViewEventArgs"/> class for the specified tree node and with the specified type of action that raised the event.
      /// </summary>
      /// <param name="node">The <see cref="DictionaryTreeNode"/> that the event is responding to.</param>
      /// <param name="action">The type of <see cref="System.Windows.Forms.TreeViewAction"/> that raised the event.</param>
      public DictionaryTreeViewEventArgs(DictionaryTreeNode node, TreeViewAction action) : base(node, action)
      { }
      /// <summary>
      /// Gets the tree node that has been checked, expanded, collapsed, or selected.
      /// </summary>
      /// <value></value>
      /// <returns>
      /// The <see cref="T:CAS.UA.Model.Designer.Controls.DictionaryTreeView.DictionaryTreeNode"/> 
      /// that has been checked, expanded, collapsed, or selected.
      /// </returns>
      public new DictionaryTreeNode Node => (DictionaryTreeNode)base.Node;
    }
    


    #endregion classes

    #region public
    internal new event DictionaryTreeViewEventHandler AfterSelect;
    public new DictionaryTreeNode SelectedNode
    {
      get => base.SelectedNode as DictionaryTreeNode;
      set
      {
        base.SelectedNode = value;
        if (RefreshNeeded != null)
          RefreshNeeded(this, new RefreshScopeEventArgs(RefreshScopeEventArgs.ModificationType.Data));
      }
    }
    public class RefreshScopeEventArgs : EventArgs
    {
      public enum ModificationType { Data, Structure }
      public ModificationType Scope { get; private set; }
      public RefreshScopeEventArgs(ModificationType scope)
      {
        Scope = scope;
      }
    }
    public event EventHandler<RefreshScopeEventArgs> RefreshNeeded;
    public bool CoupledNodesAreEnabled
    {
      get
      {
        lock (m_CoupledNodesLock)
        {
          return m_CoupledNodesAreEnabled;
        }
      }
      set
      {
        lock (m_CoupledNodesLock)
        {
          m_CoupledNodesAreEnabled = value;
          if (!value)
            ClearCoupledNodesDictionaryTreeNodeList();
        }
      }
    }
    public void SetTypeFilter(bool allTypes, IEnumerable<NodeClassesEnum> types)
    {
      Application.UseWaitCursor = true;
      this.BeginUpdate();
      foreach (DictionaryTreeNode item in this.Nodes)
        item.SetTypeFilter(allTypes, types);
      this.EndUpdate();
      RebuildDictionary();
      Application.UseWaitCursor = false;
    }
    public DictionaryTreeNode GetNode(XmlQualifiedName name)
    {
      if (name == null)
        return null;
      Dictionary.TryGetValue(name, out DictionaryTreeNode NodeToBereturned);
      if (NodeToBereturned == null && name.Name.Contains("_"))
      {
        //lets try also get last part of the name just after '_'
        string lastPartOfTheName = name.Name.Substring(name.Name.LastIndexOf("_") + 1);
        XmlQualifiedName newName = new XmlQualifiedName(lastPartOfTheName, name.Namespace);
        Dictionary.TryGetValue(newName, out NodeToBereturned);
      }
      return NodeToBereturned;
    }
    public void GoToNode(XmlQualifiedName name)
    {
      if (name == null)
      {
        System.Windows.Forms.MessageBox.Show
          ("Type Definition not set", "Find Type Definition", MessageBoxButtons.OK, MessageBoxIcon.Question);
        return;
      }
      DictionaryTreeNode value = GetNode(name);
      if (value != null)
        this.SelectedNode = value;
      else
      {
        string msg = string.Format("Cannot find the target {0}", name.ToString());
        MessageBox.Show(msg, "Find node", MessageBoxButtons.OK, MessageBoxIcon.Question);
      }
    }
    public void RebuildDictionary()
    {
      try
      {
        Application.UseWaitCursor = true;
        Dictionary.Clear();
        foreach (DictionaryTreeNode rtn in this.Nodes)
          rtn.AddNodeToDictionary();
      }
      catch (Exception ex)
      {
        string msg = string.Format(Properties.Resources.MainBuildError, ex.Message);
        MessageBox.Show(msg, Properties.Resources.MainBuildErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Question);
      }
      finally
      {
        Application.UseWaitCursor = false;
      }
    }
    /// <summary>
    /// Adds the solution tree node.
    /// </summary>
    /// <param name="treeNode">The tree node <see cref="DictionaryTreeNode"/>.</param>
    internal void AddSolution(DictionaryTreeNode treeNode)
    {
      if (m_Soluton != null)
        m_Soluton.Remove();
      m_Soluton = treeNode;
      Nodes.Insert(0, treeNode);
      this.SelectedNode = treeNode;
      treeNode.Expand();
      Refresh();
    }
    #endregion

    #region private
    private TreeNode m_Soluton = null;
    private Dictionary<XmlQualifiedName, DictionaryTreeNode> Dictionary { get; set; }
    private bool m_CoupledNodesAreEnabled = true;
    private object m_CoupledNodesLock = new object();
    private List<CoupledNodesDictionaryTreeNode> m_CoupledNodesDictionaryTreeNodeList = new List<CoupledNodesDictionaryTreeNode>();
    private void ClearCoupledNodesDictionaryTreeNodeList()
    {
      lock (m_CoupledNodesLock)
      {
        foreach (CoupledNodesDictionaryTreeNode cndTN in m_CoupledNodesDictionaryTreeNodeList)
        {
          if (cndTN != null && cndTN.TreeView != null)
            cndTN.Remove();
        }
        m_CoupledNodesDictionaryTreeNodeList.Clear();
      }
    }
    private void CoupledNodes_AfterSelect(DictionaryTreeNode selectedNode)
    {
      if (selectedNode != null)
      {
        lock (m_CoupledNodesLock)
        {
          CoupledNodesDictionaryTreeNode node = selectedNode.GetEmptyCoupledNode() as CoupledNodesDictionaryTreeNode;
          if (node == null)
            return;
          if (!m_CoupledNodesDictionaryTreeNodeList.Contains(node))
            m_CoupledNodesDictionaryTreeNodeList.Add(node);
          foreach (KeyValuePair<string, XmlQualifiedName> item in selectedNode.GetCoupledNodesXmlQualifiedNames())
          {
            DictionaryTreeNode couplednode = GetNode(item.Value);
            if (couplednode == null)
              continue;
            BaseDictionaryTreeNode newNode = couplednode.CreateCopy();
            newNode.Text = string.Format("{0}: {1}", item.Key, newNode.Text);
            node.Nodes.Add(newNode);
          }
        }
      }
    }
    #region Event handlers
    private void DictionaryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      DictionaryTreeNode selectedNode = (DictionaryTreeNode)e.Node;
      if (m_CoupledNodesAreEnabled)
        CoupledNodes_AfterSelect(selectedNode);
      this.AfterSelect?.Invoke(sender, new DictionaryTreeViewEventArgs(selectedNode, e.Action));
    }
    private void DictionaryTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      ((DictionaryTreeNode)e.Node).OnNodeSelected();
    }
    #endregion

    #endregion
  }
}
