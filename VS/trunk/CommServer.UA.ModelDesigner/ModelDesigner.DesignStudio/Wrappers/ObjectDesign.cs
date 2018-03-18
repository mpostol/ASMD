//<summary>
//  Title   : Object Design wrapper
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
  /// <summary>
  /// Represents all object node instances in the Information Model
  /// </summary>
  internal partial class ObjectDesign: InstanceDesign<Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>, Opc.Ua.ModelCompiler.ObjectDesign>
  {
    #region creators
    public ObjectDesign()
      : base( new Designer.Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>( new Opc.Ua.ModelCompiler.ObjectDesign() ) )
    { }
    public ObjectDesign( Opc.Ua.ModelCompiler.ObjectDesign node )
      : base( new Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>( node ), node )
    { }
    #endregion

    #region private
    private class TreeNode:
      InstanceDesign<Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>, Opc.Ua.ModelCompiler.ObjectDesign>.TreeNode<ObjectDesign>
    {
      public TreeNode( ObjectDesign parent )
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
      get { return Resources.NodeClasses_Objects_Object; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.Object; }
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
