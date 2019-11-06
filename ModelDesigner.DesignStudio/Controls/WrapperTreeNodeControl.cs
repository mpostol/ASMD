//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.IServerConfiguration;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Collections.Generic;
using System.Xml;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class WrapperTreeNodeControl<T> : BaseTreeNodeControl<T>, IWrapperTreeNode
    where T : WrapperTreeNode, IModelNode, IModelNodeAdvance
  {
    #region creator
    public WrapperTreeNodeControl(T entity) : base(entity)
    {
      entity.MessageBoxHandling = new MessageBoxHandling();
    }
    #endregion

    #region private
    private readonly List<Diagnostics> m_ErrorList = new List<Diagnostics>();
    protected IModelNode MyIModelNode => ModelEntity as IModelNode;
    /// <summary>
    /// Gets the wrappers to be used in the <see cref="System.Windows.Forms.PropertyGrid"/>.
    /// </summary>
    /// <value>The wrappers,i.e. node configuration wrappers.</value>
    protected virtual void AddMenuItemAdd(INodeFactory[] listOfNodes)
    {
      System.Windows.Forms.ToolStripMenuItem menu = new System.Windows.Forms.ToolStripMenuItem(Properties.Resources.WrapperTreeNode_menu_add_object, Resources.AdddItem)
      {
        Enabled = !ModelEntity.TestIfReadOnlyAndRetrunTrueIfReadOnly()
      };
      ContextMenuStrip.Items.Add(menu);
      foreach (INodeFactory item in listOfNodes)
      {
        string node_name = item.ToString().Replace("Design", "");
        System.Windows.Forms.ToolStripMenuItem sm = new System.Windows.Forms.ToolStripMenuItem(node_name)
        {
          Tag = item,
          Enabled = !ModelEntity.TestIfReadOnlyAndRetrunTrueIfReadOnly()
        };
        sm.Click += new EventHandler(ModelEntity.AddMenuItemAdd_Click);
        menu.DropDownItems.Add(sm);
      }
    }
    protected void AddMenuItemCopyPasteCut()
    {
      if (ContextMenuStrip.Items.Count > 0)
        ContextMenuStrip.Items.Add(new System.Windows.Forms.ToolStripSeparator());
      AddMenuItemCopy();
      AddMenuItemPaste();
      AddMenuItemCut();
    }
    protected void AddMenuItemCut()
    {
      System.Windows.Forms.ToolStripMenuItem menu;
      menu = new System.Windows.Forms.ToolStripMenuItem(Properties.Resources.WrapperTreeNode_menu_cut, Resources.cut)
      {
        Enabled = !ModelEntity.TestIfReadOnlyAndRetrunTrueIfReadOnly()
      };
      menu.Click += new EventHandler(ModelEntity.AddMenuItemCut_Click);
      ContextMenuStrip.Items.Add(menu);
    }
    protected void AddMenuItemCopy()
    {
      System.Windows.Forms.ToolStripMenuItem menu = new System.Windows.Forms.ToolStripMenuItem(Properties.Resources.WrapperTreeNode_menu_copy, Resources.copy);
      menu.Click += new EventHandler(ModelEntity.AddMenuItemCopy_Click);
      ContextMenuStrip.Items.Add(menu);
    }
    protected void AddMenuItemPaste()
    {
      System.Windows.Forms.ToolStripMenuItem MenuPaste = new System.Windows.Forms.ToolStripMenuItem(Properties.Resources.WrapperTreeNode_menu_paste, Resources.paste)
      {
        Enabled = !ModelEntity.TestIfReadOnlyAndRetrunTrueIfReadOnly() && ModelEntity.ShouldPasteMenuBeEnabled()
      };
      MenuPaste.Click += new EventHandler(ModelEntity.AddMenuItemPaste_Click);
      ContextMenuStrip.Items.Add(MenuPaste);
    }
    protected virtual void AddMenuItemDelete()
    {
      System.Windows.Forms.ToolStripMenuItem menu = new System.Windows.Forms.ToolStripMenuItem(Properties.Resources.WrapperTreeNode_menu_delete, Resources.delete)
      {
        Enabled = !ModelEntity.TestIfReadOnlyAndRetrunTrueIfReadOnly()
      };
      menu.Click += new EventHandler(ModelEntity.AddMenuItemDelete_Click);
      ContextMenuStrip.Items.Add(menu);
    }
    protected override void AddChildren(T entity)
    {
      foreach (T node in entity)
        Nodes.Add(TreeNodesFactory.Factory.GetTreeNode(entity));
    }
    #endregion

    #region IWrapperTreeNode Members
    /// <summary>
    /// Gets the instance of the model node. Model node represents the location of the node in the model hierarchy.
    /// </summary>
    /// <value>
    /// An instance of class inherited from <see cref="IModelNodeAdvance"/>.
    /// </value>
    IModelNodeAdvance IWrapperTreeNode.IModelNodeAdvance => this.ModelEntity as IModelNodeAdvance;
    /// <summary>
    /// Gets or sets the name of the tree node.
    /// </summary>
    /// <value></value>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the name of the tree node.
    /// </returns>
    string IModelNode.Name => ModelEntity.Name;
    /// <summary>
    /// Gets the error list.
    /// </summary>
    /// <value>The error list.</value>
    IList<Diagnostics> IModelNode.ErrorList => m_ErrorList;
    /// <summary>
    /// Gets the wrapper of the node to be used in the property grid user interface.
    /// </summary>
    /// <value>The wrapper.</value>
    object IModelNode.Wrapper4PropertyGrid => ModelEntity.Wrapper4PropertyGrid;
    /// <summary>
    /// Gets the wrapper for property grid of data bindings.
    /// </summary>
    /// <returns></returns>
    /// <return>The wrapper data bindings property grid.</return>
    INodeDescriptor IModelNode.GetINodeDescriptor()
    {
      UniqueIdentifier ui = new UniqueIdentifier();
      if (!GetUniqueIdentifier(ui))
        return null;
      return ModelEntity.GetINodeDescriptor(ui);
    }
    /// <summary>
    /// Gets the name of the node class.
    /// </summary>
    /// <value>The name of the node class.</value>
    NodeClassesEnum IModelNode.NodeClass => ModelEntity.NodeClass;
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>
    /// Unique identifier to be used as the key to select the help topic.
    /// </value>
    string IModelNode.HelpTopicName => ModelEntity.HelpTopicName;
    /// <summary>
    /// Gets a value indicating whether this instance is read only.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is read only; otherwise, <c>false</c>.
    /// </value>
    bool IModelNode.IsReadOnly => ModelEntity.IsReadOnly;
    /// <summary>
    /// Gets the symbolic name.
    /// </summary>
    /// <value>The symbolic name.</value>
    public virtual XmlQualifiedName SymbolicName => new XmlQualifiedName();

    private class MessageBoxHandling : IMessageBoxHandling
    {
      public void Show(string message)
      {
        System.Windows.Forms.MessageBox.Show(message);
      }
      public DialogResult Show(string text, string caption, Wrappers.MessageBoxButtons buttons, Wrappers.MessageBoxIcon icon)
      {
        return (DialogResult)System.Windows.Forms.MessageBox.Show(text, caption, (System.Windows.Forms.MessageBoxButtons)buttons, (System.Windows.Forms.MessageBoxIcon)icon);
      }
    }
    #endregion
  }

}
