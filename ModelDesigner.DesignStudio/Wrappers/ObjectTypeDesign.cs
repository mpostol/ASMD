//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________


using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Properties;
using BaseModelType = Opc.Ua.ModelCompiler.ObjectTypeDesign;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class ObjectTypeDesign: TypeDesign<Wrappers4ProperyGrid.ObjectTypeDesign<BaseModelType>, BaseModelType>
  {
    #region private
    //private class ObjectTypeDesignTreeNodeControl : TypeDesignTreeNodeControl<ObjectTypeDesign, Wrappers4ProperyGrid.ObjectTypeDesign<BaseModelType>, BaseModelType>
    //{
    //  public ObjectTypeDesignTreeNodeControl( ObjectTypeDesign parent )
    //    : base( parent )
    //  { }
    //}
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
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      return new ObjectTypeDesignTreeNodeControl( this );
    }
    #endregion
  }

}
