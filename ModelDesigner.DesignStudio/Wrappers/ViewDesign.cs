//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class ViewDesign : NodeDesign<Wrappers4ProperyGrid.ViewDesign, Opc.Ua.ModelCompiler.ViewDesign>
  {
    
    #region constructors
    public ViewDesign()
      : base(new Designer.Wrappers4ProperyGrid.ViewDesign(new Opc.Ua.ModelCompiler.ViewDesign())) { }
    public ViewDesign(Opc.Ua.ModelCompiler.ViewDesign node)
      : base(new Wrappers4ProperyGrid.ViewDesign(node), node) { }
    #endregion

    #region private
    //private class ViewDesignTreeNodeControl : CAS.UA.Model.Designer.Controls.NodeDesignTreeNodeControl<ViewDesign, Wrappers4ProperyGrid.ViewDesign, Opc.Ua.ModelCompiler.ViewDesign>
    //{
    //  public ViewDesignTreeNodeControl( ViewDesign parent )
    //    : base( parent )
    //  { }
    //}
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_View;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.View;
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      return new TreeNode(this);
    }
    #endregion
  }
}
