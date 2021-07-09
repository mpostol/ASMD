//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class DictionaryTreeNode : BaseDictionaryTreeNode
  {
    #region creator

    public DictionaryTreeNode()
      : base()
    {
      ContextMenuStrip = new ContextMenuStrip();
    }

    #endregion creator

    #region private

    private DictionaryTreeNode m_CoupledNodeFolder = null;
    protected new DictionaryTreeView TreeView => base.TreeView as DictionaryTreeView;
    protected new DictionaryTreeNode Parent => base.Parent as DictionaryTreeNode;

    protected void AddToDictionary(XmlQualifiedName name, DictionaryTreeNode node)
    {
      if (name == null)
        return;
      TreeView.AddIfNew(name, node);
    }

    /// <summary>
    /// Checks the type filter.
    /// </summary>
    /// <param name="AllTypes">if set to <c>true</c> display all nodes.</param>
    /// <param name="types">The types to display.</param>
    /// <returns></returns>
    protected virtual bool CheckTypeFilter(bool AllTypes, IEnumerable<NodeClassesEnum> types)
    {
      return true;
    }

    protected abstract void Unregister();

    protected void ClearChildren()
    {
      foreach (DictionaryTreeNode item in Nodes)
        item.Unregister();
      Nodes.Clear();
    }

    protected void ApplyTypeFiltersToChildren(bool allTypes, IEnumerable<NodeClassesEnum> types)
    {
      List<DictionaryTreeNode> visible = new List<DictionaryTreeNode>();
      foreach (DictionaryTreeNode node in Nodes)
        if (node.CheckTypeFilter(allTypes, types))
          visible.Add(node);
        else
          node.ClearChildren();
      Nodes.Clear();
      Nodes.AddRange(visible.ToArray());
    }

    #region Menu

    private List<ToolStripMenuItem> m_GoToMenuItemList = new List<ToolStripMenuItem>();

    protected void AddMenuItemGoTo(string text, string tip, EventHandler ClickEventHandler)
    {
      ToolStripMenuItem menu = new ToolStripMenuItem(text)
      {
        ToolTipText = tip
      };
      menu.Click += ClickEventHandler;
      m_GoToMenuItemList.Add(menu);
    }

    /// <summary>
    /// Is called befores the menu strip opening to add all required menu items.
    /// </summary>
    protected virtual void BeforeMenuStripOpening() { }

    #endregion Menu

    #endregion private

    #region public

    /// <summary>
    /// Gets the unique identifier.
    /// </summary>
    /// <param name="ui">The instance of <see cref="UniqueIdentifier"/> that represents an unique identifier.</param>
    /// <returns><c>true</c> if it is not top level element; <c>false</c> otherwise if it is top level element</returns>
    internal virtual bool GetUniqueIdentifier(UniqueIdentifier ui)
    {
      if (this.Parent == null)
        return false;
      else
        return this.Parent.GetUniqueIdentifier(ui);
    }

    internal List<ToolStripMenuItem> GoToMenuItemList => m_GoToMenuItemList;

    internal virtual Dictionary<string, XmlQualifiedName> GetCoupledNodesXmlQualifiedNames()
    {
      return new Dictionary<string, XmlQualifiedName>();
    }

    internal DictionaryTreeNode GetEmptyCoupledNode()
    {
      Dictionary<string, XmlQualifiedName> coupledXmlQualifiedName = GetCoupledNodesXmlQualifiedNames();
      if (coupledXmlQualifiedName.Count > 0)
      {
        // if coupled tree node does not exist we create one:
        if (m_CoupledNodeFolder == null)
          m_CoupledNodeFolder = new CoupledNodesDictionaryTreeNode();
        else
          m_CoupledNodeFolder.Nodes.Clear();
        //if coupled node is not connected, we attach it
        if (!this.Nodes.Contains(m_CoupledNodeFolder))
          this.Nodes.Add(m_CoupledNodeFolder);
      }
      return m_CoupledNodeFolder;
    }

    internal virtual void AddNodeToDictionary()
    {
      foreach (DictionaryTreeNode node in this.Nodes)
        node.AddNodeToDictionary();
    }

    public virtual void SetTypeFilter(bool allTypes, IEnumerable<NodeClassesEnum> types)
    {
      foreach (DictionaryTreeNode node in Nodes)
        node.SetTypeFilter(allTypes, types);
    }

    /// <summary>
    /// Called when the node is selected on the tree. It must create a menu for the node.
    /// </summary>
    internal void OnNodeSelected()
    {
      this.ContextMenuStrip.Items.Clear();
      this.m_GoToMenuItemList.Clear();
      BeforeMenuStripOpening();
      if (ContextMenuStrip.Items.Count > 0 && m_GoToMenuItemList.Count > 0)
        this.ContextMenuStrip.Items.Add(new ToolStripSeparator());
      ContextMenuStrip.Items.AddRange(m_GoToMenuItemList.ToArray());
    }

    protected internal virtual void GetImportMenu(ToolStripItemCollection items)
    {
      if (Parent == null)
        return;
      Parent.GetImportMenu(items);
    }

    //internal abstract IBaseModel BaseModelNode { get; }

    #endregion public
  }//DictionaryTreeNode
}