//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

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
  
    #region constructor
    public DictionaryTreeView()
    {
      InitializeComponent();
      Dictionary = new Dictionary<XmlQualifiedName, DictionaryTreeNode>();
      base.AfterSelect += new TreeViewEventHandler(DictionaryTreeView_AfterSelect);
      this.NodeMouseClick += new TreeNodeMouseClickEventHandler(DictionaryTreeView_NodeMouseClick);
    }
    #endregion

    #region public
    //classes
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
    public class RefreshScopeEventArgs : EventArgs
    {
      public enum ModificationType { Data, Structure }
      public ModificationType Scope { get; private set; }
      public RefreshScopeEventArgs(ModificationType scope)
      {
        Scope = scope;
      }
    }
    //VAR
    internal new event DictionaryTreeViewEventHandler AfterSelect;
    public event EventHandler<RefreshScopeEventArgs> RefreshNeeded;
    public new DictionaryTreeNode SelectedNode
    {
      get => base.SelectedNode as DictionaryTreeNode;
      set
      {
        base.SelectedNode = value;
        RefreshNeeded?.Invoke(this, new RefreshScopeEventArgs(RefreshScopeEventArgs.ModificationType.Data));
      }
    }
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
    //methods
    internal void AddIfNew(XmlQualifiedName name, DictionaryTreeNode node)
    {
      if (Dictionary.TryGetValue(name, out DictionaryTreeNode value))
        return;
      Dictionary.Add(name, node);
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
    #endregion

    #region private
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
          CoupledNodesDictionaryTreeNode _node = selectedNode.GetEmptyCoupledNode() as CoupledNodesDictionaryTreeNode;
          if (_node == null)
            return;
          if (!m_CoupledNodesDictionaryTreeNodeList.Contains(_node))
            m_CoupledNodesDictionaryTreeNodeList.Add(_node);
          foreach (KeyValuePair<string, XmlQualifiedName> item in selectedNode.GetCoupledNodesXmlQualifiedNames())
          {
            DictionaryTreeNode _coupledNode = GetNode(item.Value);
            if (!(_coupledNode is IDictionaryTreeNodeCreateCopy))
              throw new ArgumentOutOfRangeException($"{nameof(DictionaryTreeView)} Cannot create coupled node for {_coupledNode.GetType().FullName}");
            DictionaryTreeNode newNode = ((IDictionaryTreeNodeCreateCopy)_coupledNode).CreateCopy();
            newNode.Text = string.Format("{0}: {1}", item.Key, newNode.Text);
            _node.Nodes.Add(newNode);
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
