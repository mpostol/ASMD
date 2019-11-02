//<summary>
//  Title   : View Design wrapper
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class ViewDesign: NodeDesign<Wrappers4ProperyGrid.ViewDesign, Opc.Ua.ModelCompiler.ViewDesign>
  {
    #region creators
    public ViewDesign()
      : base( new Designer.Wrappers4ProperyGrid.ViewDesign( new Opc.Ua.ModelCompiler.ViewDesign() ) )
    { }
    public ViewDesign( Opc.Ua.ModelCompiler.ViewDesign node )
      : base( new Wrappers4ProperyGrid.ViewDesign( node ), node )
    { }
    #endregion

    #region private
    private class TreeNode: CAS.UA.Model.Designer.Controls.NodeDesignTreeNodeControl<ViewDesign, Wrappers4ProperyGrid.ViewDesign, Opc.Ua.ModelCompiler.ViewDesign>
    {
      public TreeNode( ViewDesign parent )
        : base( parent )
      { }
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Objects_View; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.View; }
    }
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      return new TreeNode( this );
    }
    #endregion
  }
}
