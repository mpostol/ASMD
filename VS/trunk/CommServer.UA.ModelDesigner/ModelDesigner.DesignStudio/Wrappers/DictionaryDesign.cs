//<summary>
//  Title   : Dictionary Design Wrapper
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

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class DictionaryDesign: VariableDesignGeneric<Wrappers4ProperyGrid.DictionaryDesign, Opc.Ua.ModelCompiler.DictionaryDesign>
  {

    #region creators
    public DictionaryDesign()
      : base( new Wrappers4ProperyGrid.DictionaryDesign( new Opc.Ua.ModelCompiler.DictionaryDesign() ) )
    { }
    public DictionaryDesign( Opc.Ua.ModelCompiler.DictionaryDesign node )
      : base( new Wrappers4ProperyGrid.DictionaryDesign( node ), node )
    { }
    #endregion

    #region public
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
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.Dictionary; }
    }
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Objects_Dictionary; }
    }
    #endregion

    #region private
    private class TreeNode: VariableDesignGeneric<Wrappers4ProperyGrid.DictionaryDesign, Opc.Ua.ModelCompiler.DictionaryDesign>.TreeNode<DictionaryDesign>
    {
      public TreeNode( DictionaryDesign parent )
        : base( parent )
      { }
    }
    #endregion

  }
}
