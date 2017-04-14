//<summary>
//  Title   : ReferenceType Design wrapper
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

using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class ReferenceTypeDesign: TypeDesign<Wrappers4ProperyGrid.ReferenceTypeDesign, Opc.Ua.ModelCompiler.ReferenceTypeDesign>
  {
    #region creatores
    public ReferenceTypeDesign()
      : base( new Wrappers4ProperyGrid.ReferenceTypeDesign( new Opc.Ua.ModelCompiler.ReferenceTypeDesign() ) )
    { }
    public ReferenceTypeDesign( Opc.Ua.ModelCompiler.ReferenceTypeDesign node )
      : base( new Wrappers4ProperyGrid.ReferenceTypeDesign( node ), node )
    { }
    #endregion

    #region private
    private class TreeNode: TypeDesign<Wrappers4ProperyGrid.ReferenceTypeDesign, Opc.Ua.ModelCompiler.ReferenceTypeDesign>.TreeNode<ReferenceTypeDesign>
    {
      public TreeNode( ReferenceTypeDesign parent )
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
      get { return Resources.NodeClasses_Types_ReferenceType; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.ReferenceType; }
    }
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    internal override DictionaryTreeView.DictionaryTreeNode GetTreeNode()
    {
      return new TreeNode( this );
    }
    #endregion

  }
}
