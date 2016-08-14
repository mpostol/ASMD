//<summary>
//  Title   : Browse View Tree View
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

using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers.AddressSpaceDictionary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{

  internal partial class BrowseViewTreeView : TreeView
  {
    #region creators
    internal BrowseViewTreeView()
    {
      InitializeComponent();
      Initialize();
    }
    #endregion
    
    #region public
    internal new event BrowseViewTreeViewEventHandler AfterSelect;
    internal void Show(IElement[] content, bool SelectRootNodeAfterCreation)
    {
      this.Nodes.Clear();
      foreach (var item in content)
        Nodes.Add(new ModelNode(item));
      if (this.Nodes.Count > 0)
        this.SelectedNode = this.Nodes[0]; // selection of root node (first node on the tree)
    }

    #region classes
    internal delegate void BrowseViewTreeViewEventHandler(object sender, BrowseViewTreeViewEventArgs e);
    internal class BrowseViewTreeViewEventArgs : TreeViewEventArgs
    {
      public BrowseViewTreeViewEventArgs(TreeViewEventArgs treeViewEventArgs) :
        base(treeViewEventArgs.Node, treeViewEventArgs.Action)
      {
        if (treeViewEventArgs.Node is ModelNode)
        {
          this.ModelNode = (((ModelNode)treeViewEventArgs.Node).Target).ModelNode;
        }
        else
          this.ModelNode = null;
      }
      internal IModelNode ModelNode { get; private set; }
    }
    #endregion classes

    #endregion public

    #region private
    private const string ErrorList = "ErrorList";
    private class ModelNode : BrowseViewTreeNode
    {
      internal bool DeadEnd { get; set; }
      internal IElement Target { get; private set; }
      internal override void AddChildren()
      {
        if (!DeadEnd)
          return;
        this.Nodes.Clear();
        this.DeadEnd = false;
        IElement[] ase = Target.GetChildren(false, true);
        foreach (var item in ase)
        {
          Reference _rfr = null;
          if (!this.Nodes.ContainsKey(item.ReferenceName))
          {
            _rfr = new Reference(item.ReferenceName);
            this.Nodes.Add(_rfr);
          }
          else
            _rfr = (Reference)this.Nodes[item.ReferenceName];
          _rfr.AddModelNode(item);
        }
        if (Target.ErrorsList == null || Target.ErrorsList.Count == 0)
          return;
        this.Nodes.Add(new Error(Target.ErrorsList));
      }
      public ModelNode(IElement target)
        : base(target.Name, ImagesForNodes.GetIconNumber(target, false, false), ImagesForNodes.GetIconNumber(target, false, true))
      {
        this.Target = target;
        this.DeadEnd = true;
        this.Nodes.Add("DeadEnd");
      }
    }
    private class Reference : BrowseViewTreeNode
    {
      internal void AddModelNode(IElement target)
      {
        this.Nodes.Add(new ModelNode(target));
      }
      /// <summary>
      /// Adds the children.
      /// </summary>
      /// <param name="addressSpace">The address space.</param>
      internal override void AddChildren() { }
      internal Reference(string name)
        : base(name, ImagesForNodes.GetIconNumber(null, true, false), ImagesForNodes.GetIconNumber(null, true, true))
      {
        this.Expand();
      }
    }
    private class Error : BrowseViewTreeNode
    {
      internal Error(IList<Diagnostics> errors)
        : base(ErrorList, ErrorListIcoIdx(), SelectedErrorListIcoIdx())
      {
        ForeColor = Color.Red;
        foreach (Diagnostics item in errors)
          Nodes.Add(new TreeNode(item.Message));
        this.Expand();
      }
      /// <summary>
      /// Adds the children.
      /// </summary>
      /// <param name="addressSpace">The address space.</param>
      internal override void AddChildren() { }
      private static int SelectedErrorListIcoIdx()
      {
        return (int)ImagesForNodes.IconsIndex.SelectedError;
      }
      private static int ErrorListIcoIdx()
      {
        return (int)ImagesForNodes.IconsIndex.Error;
      }
    }
    private abstract class BrowseViewTreeNode : TreeNode
    {
      internal BrowseViewTreeNode(string name, int imageIndex, int selectedImageIndex)
      {
        this.Text = name;
        this.Name = name;
        this.ImageIndex = imageIndex;
        this.SelectedImageIndex = selectedImageIndex;
      }
      /// <summary>
      /// Adds the children.
      /// </summary>
      /// <param name="addressSpace">The address space.</param>
      internal abstract void AddChildren();
    }
    private void Initialize()
    {
      base.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.BrowseViewTreeView_AfterSelect);
      this.ImageList = m_ImagesForNodes.ImageListNodes;
      //TODO Uncomment after implementing BrowseOptions mechanism
      //MenuItem[] miTab = new MenuItem[ 1 ];
      //miTab[ 0 ] = new MenuItem( "Browse options" );
      //this.ContextMenu = new ContextMenu( miTab );
      //this.ContextMenu.MenuItems[ 0 ].Click += new System.EventHandler( OpenBrowseViewOptionsWindow );
    }

    #region handlers
    private void OpenBrowseViewOptionsWindow(object sender, EventArgs e)
    {
      BrowseOptionsDlg bod = new BrowseOptionsDlg();
      bod.ShowDialog();
    }
    private void BrowseViewTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (this.AfterSelect != null)
        this.AfterSelect(sender, new BrowseViewTreeViewEventArgs(e));
    }
    private void BrowseViewTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
      BrowseViewTreeNode m_SelectedNode = (BrowseViewTreeNode)e.Node;
      //TODO use filter setting to select the directions.
      m_SelectedNode.AddChildren();
    }
    #endregion

    #endregion private
  }
}