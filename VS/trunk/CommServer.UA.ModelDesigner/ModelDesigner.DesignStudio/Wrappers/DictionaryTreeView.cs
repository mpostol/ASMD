//<summary>
//  Title   : TreeView supporting dictionary lookup.
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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// TreeView supporting dictionary lookup.
  /// </summary>
  internal partial class DictionaryTreeView: TreeView
  {
    #region creator
    public DictionaryTreeView()
    {
      InitializeComponent();
      Dictionary = new Dictionary<XmlQualifiedName, DictionaryTreeNode>();
      base.AfterSelect += new TreeViewEventHandler( DictionaryTreeView_AfterSelect );
      this.NodeMouseClick += new TreeNodeMouseClickEventHandler( DictionaryTreeView_NodeMouseClick );
    }
    #endregion

    #region classes
    internal delegate void DictionaryTreeViewEventHandler( object sender, DictionaryTreeViewEventArgs e );
    internal class DictionaryTreeViewEventArgs: TreeViewEventArgs
    {
      public DictionaryTreeViewEventArgs( TreeViewEventArgs treeViewEventArgs ) :
        base( treeViewEventArgs.Node, treeViewEventArgs.Action )
      {
        this.Node = (DictionaryTreeNode)treeViewEventArgs.Node;
      }
      /// <summary>
      /// Gets the tree node that has been checked, expanded, collapsed, or selected.
      /// </summary>
      /// <value></value>
      /// <returns>
      /// The <see cref="T:CAS.UA.Model.Designer.Controls.DictionaryTreeView.DictionaryTreeNode"/> 
      /// that has been checked, expanded, collapsed, or selected.
      /// </returns>
      public new DictionaryTreeNode Node { get; private set; }
    }
    internal abstract class DictionaryTreeNode: TreeNode
    {
      #region creator
      public DictionaryTreeNode()
        : base()
      {
        ContextMenuStrip = new ContextMenuStrip();
      }
      #endregion

      #region private
      private DictionaryTreeNode m_CoupledNodeFolder = null;
      protected new DictionaryTreeView TreeView { get { return base.TreeView as DictionaryTreeView; } }
      protected new DictionaryTreeNode Parent { get { return base.Parent as DictionaryTreeNode; } }
      protected void AddToDictionary( XmlQualifiedName name, DictionaryTreeNode node )
      {
        if ( name == null )
          return;
        DictionaryTreeNode value;
        if ( TreeView.Dictionary.TryGetValue( name, out value ) )
          return;
        TreeView.Dictionary.Add( name, node );
      }
      /// <summary>
      /// Checks the type filter.
      /// </summary>
      /// <param name="AllTypes">if set to <c>true</c> display all nodes.</param>
      /// <param name="types">The types to display.</param>
      /// <returns></returns>
      protected virtual bool CheckTypeFilter( bool AllTypes, IEnumerable<NodeClassesEnum> types )
      {
        return true;
      }
      protected abstract void Unregister();
      protected void ClearChildren()
      {
        foreach ( DictionaryTreeNode item in Nodes )
          item.Unregister();
        Nodes.Clear();
      }
      protected void ApplyTypeFiltersToChildreen( bool allTypes, IEnumerable<NodeClassesEnum> types )
      {
        List<DictionaryTreeNode> visible = new List<DictionaryTreeNode>();
        foreach ( DictionaryTreeNode node in Nodes )
          if ( node.CheckTypeFilter( allTypes, types ) )
            visible.Add( node );
          else
            node.ClearChildren();
        Nodes.Clear();
        Nodes.AddRange( visible.ToArray() );
      }
      #region Menu
      private List<ToolStripMenuItem> m_GoToMenuItemList = new List<ToolStripMenuItem>();
      protected void AddMenuItemGoTo( string text, string tip, EventHandler ClickEventHandler )
      {
        ToolStripMenuItem menu = new ToolStripMenuItem( text );
        menu.ToolTipText = tip;
        menu.Click += ClickEventHandler;
        m_GoToMenuItemList.Add( menu );
      }
      /// <summary>
      /// Is called befores the menu strip opening to add all required menu items.
      /// </summary>
      protected virtual void BeforeMenuStripOpening() { }
      #endregion
      #endregion

      #region public
      /// <summary>
      /// Gets the unique identifier.
      /// </summary>
      /// <param name="ui">The instance of <see cref="UniqueIdentifier"/> that represents an unique identifier.</param>
      /// <returns><c>true</c> if it is not top level element; <c>false</c> othervise if it is top level element</returns>
      internal virtual bool GetUniqueIdentifier( UniqueIdentifier ui )
      {
        if ( this.Parent == null )
          return false;
        else
          return this.Parent.GetUniqueIdentifier( ui );
      }
      internal List<ToolStripMenuItem> GoToMenuItemList
      {
        get
        {
          return m_GoToMenuItemList;
        }
      }
      internal virtual Dictionary<string, XmlQualifiedName> GetCoupledNodesXmlQualifiedNames()
      {
        return new Dictionary<string, XmlQualifiedName>();
      }
      internal abstract DictionaryTreeNode CreateCopy();
      internal DictionaryTreeNode GetEmptyCoupledNode()
      {
        Dictionary<string, XmlQualifiedName> coupledXmlQualifiedName = GetCoupledNodesXmlQualifiedNames();
        if ( coupledXmlQualifiedName.Count > 0 )
        {
          // if coupled tree node does not exist we create one:
          if ( m_CoupledNodeFolder == null )
            m_CoupledNodeFolder = new CoupledNodesDictionaryTreeNode();
          else
            m_CoupledNodeFolder.Nodes.Clear();
          //if coupled node is not connected, we attach it
          if ( !this.Nodes.Contains( m_CoupledNodeFolder ) )
            this.Nodes.Add( m_CoupledNodeFolder );
        }
        return m_CoupledNodeFolder;
      }
      internal virtual void AddNodeToDictionary()
      {
        foreach ( DictionaryTreeNode node in this.Nodes )
          node.AddNodeToDictionary();
      }
      public virtual void SetTypeFilter( bool allTypes, IEnumerable<NodeClassesEnum> types )
      {
        foreach ( DictionaryTreeNode node in Nodes )
          node.SetTypeFilter( allTypes, types );
      }
      /// <summary>
      /// Called when the node is selected on the tree. It nust create a menu for the node.
      /// </summary>
      internal void OnNodeSelected()
      {
        this.ContextMenuStrip.Items.Clear();
        this.m_GoToMenuItemList.Clear();
        BeforeMenuStripOpening();
        if ( ContextMenuStrip.Items.Count > 0 && m_GoToMenuItemList.Count > 0 )
          this.ContextMenuStrip.Items.Add( new ToolStripSeparator() );
        ContextMenuStrip.Items.AddRange( m_GoToMenuItemList.ToArray() );
      }
      internal protected virtual void GetImportMenu( ToolStripItemCollection items )
      {
        if ( Parent == null )
          return;
        Parent.GetImportMenu( items );
      }
      #endregion

    }//DictionaryTreeNode

    private class CoupledNodesDictionaryTreeNode: DictionaryTreeNode
    {
      internal override DictionaryTreeNode CreateCopy()
      {
        return null;
      }
      /// <summary>
      /// Is called befores the menu strip opening to add all required menu items.
      /// </summary>
      protected override void BeforeMenuStripOpening()
      {
        base.BeforeMenuStripOpening();
      }
      protected override void Unregister()
      { }
      internal override void AddNodeToDictionary()
      { }
      internal CoupledNodesDictionaryTreeNode()
      {
        this.Text = Resources.DictionaryTreeNode_CoupledNodes;
      }
    }
    #endregion classes

    #region public
    internal new event DictionaryTreeViewEventHandler AfterSelect;
    public new DictionaryTreeNode SelectedNode
    {
      get { return base.SelectedNode as DictionaryTreeNode; }
      set
      {
        base.SelectedNode = value;
        if ( RefreshNeeded != null )
          RefreshNeeded( this, new RefreshScopeEventArgs( RefreshScopeEventArgs.ModificationType.Data ) );
      }
    }
    public class RefreshScopeEventArgs: EventArgs
    {
      public enum ModificationType { Data, Structure }
      public ModificationType Scope { get; private set; }
      public RefreshScopeEventArgs( ModificationType scope )
      {
        Scope = scope;
      }
    }
    public event EventHandler<RefreshScopeEventArgs> RefreshNeeded;
    public bool CoupledNodesAreEnabled
    {
      get
      {
        lock ( m_CoupledNodesLock )
        {
          return m_CoupledNodesAreEnabled;
        }
      }
      set
      {
        lock ( m_CoupledNodesLock )
        {
          m_CoupledNodesAreEnabled = value;
          if ( !value )
            ClearCoupledNodesDictionaryTreeNodeList();
        }
      }
    }
    public void SetTypeFilter( bool allTypes, IEnumerable<NodeClassesEnum> types )
    {
      Application.UseWaitCursor = true;
      this.BeginUpdate();
      foreach ( DictionaryTreeNode item in this.Nodes )
        item.SetTypeFilter( allTypes, types );
      this.EndUpdate();
      RebuildDictionary();
      Application.UseWaitCursor = false;
    }
    public DictionaryTreeNode GetNode( XmlQualifiedName name )
    {
      if ( name == null )
        return null;
      DictionaryTreeNode NodeToBereturned;
      Dictionary.TryGetValue( name, out NodeToBereturned );
      if ( NodeToBereturned == null && name.Name.Contains( "_" ) )
      {
        //lets try also get last part of the name just after '_'
        string lastPartOfTheName = name.Name.Substring( name.Name.LastIndexOf( "_" ) + 1 );
        XmlQualifiedName newName = new XmlQualifiedName( lastPartOfTheName, name.Namespace );
        Dictionary.TryGetValue( newName, out NodeToBereturned );
      }
      return NodeToBereturned;
    }
    public void GoToNode( XmlQualifiedName name )
    {
      if ( name == null )
      {
        System.Windows.Forms.MessageBox.Show
          ( "Type Definition not set", "Find Type Definition", MessageBoxButtons.OK, MessageBoxIcon.Question );
        return;
      }
      DictionaryTreeNode value = GetNode( name );
      if ( value != null )
        this.SelectedNode = value;
      else
      {
        string msg = String.Format( "Cannot find the target {0}", name.ToString() );
        MessageBox.Show( msg, "Find node", MessageBoxButtons.OK, MessageBoxIcon.Question );
      }
    }
    public void RebuildDictionary()
    {
      try
      {
        Application.UseWaitCursor = true;
        Dictionary.Clear();
        foreach ( DictionaryTreeNode rtn in this.Nodes )
          rtn.AddNodeToDictionary();
      }
      catch ( Exception ex )
      {
        string msg = String.Format( Properties.Resources.MainBuildError, ex.Message );
        MessageBox.Show( msg, Properties.Resources.MainBuildErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Question );
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
    internal void AddSolution( DictionaryTreeNode treeNode )
    {
      if ( m_Soluton != null )
        m_Soluton.Remove();
      m_Soluton = treeNode;
      Nodes.Insert( 0, treeNode );
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
      lock ( m_CoupledNodesLock )
      {
        foreach ( CoupledNodesDictionaryTreeNode cndTN in m_CoupledNodesDictionaryTreeNodeList )
        {
          if ( cndTN != null && cndTN.TreeView != null )
            cndTN.Remove();
        }
        m_CoupledNodesDictionaryTreeNodeList.Clear();
      }
    }
    private void CoupledNodes_AfterSelect( DictionaryTreeNode selectedNode )
    {
      if ( selectedNode != null )
      {
        lock ( m_CoupledNodesLock )
        {
          CoupledNodesDictionaryTreeNode node = selectedNode.GetEmptyCoupledNode() as CoupledNodesDictionaryTreeNode;
          if ( node == null )
            return;
          if ( !m_CoupledNodesDictionaryTreeNodeList.Contains( node ) )
            m_CoupledNodesDictionaryTreeNodeList.Add( node );
          foreach ( var item in selectedNode.GetCoupledNodesXmlQualifiedNames() )
          {
            DictionaryTreeNode couplednode = GetNode( item.Value );
            if ( couplednode == null )
              continue;
            DictionaryTreeNode newNode = couplednode.CreateCopy();
            newNode.Text = String.Format( "{0}: {1}", item.Key, newNode.Text );
            node.Nodes.Add( newNode );
          }
        }
      }
    }
    #region Event handlers
    private void DictionaryTreeView_AfterSelect( object sender, TreeViewEventArgs e )
    {
      DictionaryTreeNode selectedNode = e.Node as DictionaryTreeNode;
      if ( m_CoupledNodesAreEnabled )
        CoupledNodes_AfterSelect( selectedNode );
      if ( this.AfterSelect != null )
      {
        this.AfterSelect( sender, new DictionaryTreeViewEventArgs( e ) );
      }
    }
    private void DictionaryTreeView_NodeMouseClick( object sender, TreeNodeMouseClickEventArgs e )
    {
      ( (DictionaryTreeNode)e.Node ).OnNodeSelected();
    }
    #endregion
    #endregion
  }
}
