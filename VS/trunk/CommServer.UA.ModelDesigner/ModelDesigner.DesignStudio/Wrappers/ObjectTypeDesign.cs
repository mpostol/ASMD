//<summary>
//  Title   : Object Type Design wrapper
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
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using BaseModelType = Opc.Ua.ModelCompiler.ObjectTypeDesign;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class ObjectTypeDesign: ObjectTypeDesignGeneric<Wrappers4ProperyGrid.ObjectTypeDesign<BaseModelType>, BaseModelType>
  {
    #region private
    private class TreeNode: ObjectTypeDesignGeneric<Wrappers4ProperyGrid.ObjectTypeDesign<BaseModelType>, BaseModelType>.TreeNode<ObjectTypeDesign>
    {
      public TreeNode( ObjectTypeDesign parent )
        : base( parent )
      { }
    }
    protected static ObjectTypeDesign FolderType { get; private set; }
    #endregion

    #region creators
    public ObjectTypeDesign()
      : base( new Wrappers4ProperyGrid.ObjectTypeDesign<BaseModelType>( new BaseModelType() ) )
    { }
    public ObjectTypeDesign( BaseModelType node ) :
      base( new Wrappers4ProperyGrid.ObjectTypeDesign<BaseModelType>( node ), node )
    { }
    #endregion

    #region public
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Types_ObjectType; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.ObjectType; }
    }
    internal enum StandardTypes { FolderType };
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
  internal abstract class ObjectTypeDesignGeneric<T, MT>: TypeDesign<T, MT>
    where T: Wrappers4ProperyGrid.ObjectTypeDesign<MT>
    where MT: BaseModelType, new()
  {

    protected ObjectTypeDesignGeneric( T child )
      : base( child )
    { }
    public ObjectTypeDesignGeneric( T child, MT node )
      : base( child, node )
    { }

  }
}
