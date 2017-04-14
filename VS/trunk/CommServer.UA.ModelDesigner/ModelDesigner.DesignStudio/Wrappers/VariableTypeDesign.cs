//<summary>
//  Title   : Variable Type Design wrapper
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
  internal partial class VariableTypeDesign: VariableTypeDesignGeneric
  {
    #region creators
    public VariableTypeDesign()
      : base( new Wrappers4ProperyGrid.VariableTypeDesign( new Opc.Ua.ModelCompiler.VariableTypeDesign() ) )
    { }
    public VariableTypeDesign( Opc.Ua.ModelCompiler.VariableTypeDesign node )
      : base( new Wrappers4ProperyGrid.VariableTypeDesign( node ), node )
    { }
    #endregion

    #region private
    private class TreeNode: VariableTypeDesignGeneric.TreeNode<VariableTypeDesign>
    {
      public TreeNode( VariableTypeDesign parent )
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
      get { return Resources.NodeClasses_Types_VariableType; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.VariableType; }
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
  internal abstract class VariableTypeDesignGeneric: TypeDesign<Wrappers4ProperyGrid.VariableTypeDesign, Opc.Ua.ModelCompiler.VariableTypeDesign>
  {
    public VariableTypeDesignGeneric( Wrappers4ProperyGrid.VariableTypeDesign child )
      : base( child )
    { }
    public VariableTypeDesignGeneric( Wrappers4ProperyGrid.VariableTypeDesign child, Opc.Ua.ModelCompiler.VariableTypeDesign node )
      : base( child, node )
    { }

  }
}

