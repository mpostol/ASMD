//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class BaseTreeNodeControl<TModel> : DictionaryTreeNode
    where TModel : IBaseModel
  {

    #region private
    /// <summary>
    /// It provides reference to a Wrapper object - a view model for this . 
    /// </summary>
    protected TModel ModelEntity { get; private set; }
    private void OnTextChanged(object sender, TextEventArgs e)
    {
      Text = e.Node.Text;
      Name = e.Node.Text;
      ToolTipText = e.Node.ToolTipText;
      if (TreeView != null)
        TreeView.RebuildDictionary();
    }
    private void OnSubtreeChanged(object sender, ProjectEventArgs e)
    {
      if (this.TreeView != null)
        this.TreeView.SuspendLayout();
      RecreateSubtree();
      if (this.TreeView != null)
      {
        this.TreeView.SelectedNode = this;
        TreeView.RebuildDictionary();
        this.TreeView.ResumeLayout();
      }
    }
    internal void RecreateSubtree()
    {
      ClearChildren();
      AddChildren();
    }
    protected void AddChildren()
    {
      foreach (IBaseModel node in ModelEntity)
        this.Nodes.Add(TreeNodesFactory.Factory.GetTreeNode(node));
    }
    protected override void Unregister()
    {
      ClearChildren();
      ModelEntity.TextChanged -= new EventHandler<TextEventArgs>(OnTextChanged);
      ModelEntity.SubtreeChanged -= new EventHandler<ProjectEventArgs>(OnSubtreeChanged);
    }
    #endregion

    #region creator
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseTreeNodeControl{T}"/> class. It is specialized <see cref="System.Windows.Forms.TreeNode"/> 
    /// dedicated to represent all items of the model represented as a tree node.
    /// </summary>
    /// <param name="model">The model entity to be represented an the tree node.</param>
    public BaseTreeNodeControl(TModel model) : base()
    {
      ModelEntity = model;
      Name = model.Text;
      Text = model.Text;
      ToolTipText = model.ToolTipText;
      ImageIndex = ImagesForNodes.SetIconIndexForNodeAndSelectedNode(ModelEntity.GetType().Name, false);
      SelectedImageIndex = ImagesForNodes.SetIconIndexForNodeAndSelectedNode(ModelEntity.GetType().Name, true);
      model.TextChanged += new EventHandler<TextEventArgs>(OnTextChanged);
      model.SubtreeChanged += new EventHandler<ProjectEventArgs>(OnSubtreeChanged);
      AddChildren();
    }
    #endregion

  }

}
