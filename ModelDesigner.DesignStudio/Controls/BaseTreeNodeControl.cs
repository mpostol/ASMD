//_______________________________________________________________
//  Title   : BaseTreeNodeControl
//  System  : Microsoft VisualStudio 2015 / C#
//  $LastChangedDate:  $
//  $Rev: $
//  $LastChangedBy: $
//  $URL: $
//  $Id:  $
//
//  Copyright (C) 2017, CAS LODZ POLAND.
//  TEL: +48 608 61 98 99 
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using System;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class BaseTreeNodeControl<TModel, TChildModel> : DictionaryTreeNode
    where TModel : IBaseModel
    where TChildModel : IBaseModel
  {

    #region private
    /// <summary>
    /// Gets or sets the creator. 
    /// This is the Wrapper object (from CAS.UA.Model.Designer.Wrappers), 
    /// so this is a link to a mesh that store the model
    /// </summary>
    /// <value>The creator.</value>
    protected TModel ModelEntity { get; private set; }
    private void OnTextChanged(object sender, BaseTreeNode.TextEventArgs e)
    {
      Text = e.Node.Text;
      ToolTipText = e.Node.ToolTipText;
      //TODO Tree view could be null while adding Variable - fixed but impact must be analized.
      //Completed: At revision: 9178  
      if (TreeView != null)
        TreeView.RebuildDictionary();
    }
    private void OnSubtreeChanged(object sender, BaseTreeNode.ProjectEventArgs e)
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
    private void RecreateSubtree()
    {
      ClearChildren();
      AddChildren(ModelEntity);
    }
    protected override void Unregister()
    {
      ClearChildren();
      ModelEntity.TextChanged -= new EventHandler<BaseTreeNode.TextEventArgs>(OnTextChanged);
      ModelEntity.SubtreeChanged -= new EventHandler<BaseTreeNode.ProjectEventArgs>(OnSubtreeChanged);
    }
    protected void AddChildren(TModel parent)
    {
      foreach (TChildModel node in parent)
        Nodes.Add(GetChildTreeNodeControl(node));
    }
    protected abstract BaseDictionaryTreeNode GetChildTreeNodeControl(TChildModel modelEntity);
    #endregion

    #region creator
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseTreeNodeControl{T}"/> class. It is specialized <see cref="System.Windows.Forms.TreeNode"/> 
    /// dedicated to represent all items of the model represented as a tree node.
    /// </summary>
    /// <param name="model">The model entity to be represented an the tree node.</param>
    public BaseTreeNodeControl(TModel model)
      : base()
    {
      ModelEntity = model;
      Name = model.Text;
      Text = model.Text;
      ToolTipText = model.ToolTipText;
      ImageIndex = ImagesForNodes.SetIconIndexForNodeAndSelectedNode(ModelEntity.GetType().Name, false);
      SelectedImageIndex = ImagesForNodes.SetIconIndexForNodeAndSelectedNode(ModelEntity.GetType().Name, true);
      model.TextChanged += (x, y) => this.Name = model.Text;
      model.TextChanged += new EventHandler<BaseTreeNode.TextEventArgs>(OnTextChanged);
      model.SubtreeChanged += new EventHandler<BaseTreeNode.ProjectEventArgs>(OnSubtreeChanged);
      AddChildren(ModelEntity);
    }
    #endregion

    #region public
    internal override BaseDictionaryTreeNode CreateCopy()
    {
      return ModelEntity.GetTreeNode();
    }
    internal override IBaseModel BaseModelNode => ModelEntity;
    #endregion

  }

}
