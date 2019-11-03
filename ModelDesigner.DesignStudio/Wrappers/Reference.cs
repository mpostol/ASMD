//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{

  /// <summary>
  /// Class Reference. - represents reference in the address space.
  /// </summary>
  internal partial class Reference: WrapperBase<Wrappers4ProperyGrid.Reference, Opc.Ua.ModelCompiler.Reference>
  {

    #region creatores
    public Reference()
      : this( new Opc.Ua.ModelCompiler.Reference() )
    { }
    public Reference( Opc.Ua.ModelCompiler.Reference reference )
      : base( new Wrappers4ProperyGrid.Reference( reference ) )
    { }
    #endregion

    #region private
    protected override string NodeName()
    {
      return Wrapper.ReferenceType.Name;
    }
    protected override string NodeTip()
    {
      return Wrapper.ReferenceType.ToString();
    }
    //private class ReferenceTreeNodeControl : WrapperBaseTreeNodeControl<Reference, Wrappers4ProperyGrid.Reference, Opc.Ua.ModelCompiler.Reference>
    //{
    //  public ReferenceTreeNodeControl( Reference parent )
    //    : base( parent )
    //  { }
    //  internal override Dictionary<string, System.Xml.XmlQualifiedName> GetCoupledNodesXmlQualifiedNames()
    //  {
    //    var list = base.GetCoupledNodesXmlQualifiedNames();
    //    if ( ModelEntity.Wrapper.ReferenceType.XmlQualifiedName != null && !ModelEntity.Wrapper.ReferenceType.XmlQualifiedName.IsEmpty )
    //      list.Add( Resources.WrapperTreeNodeAddMenuItemGoto_ReferenceType,
    //        ModelEntity.Wrapper.ReferenceType.XmlQualifiedName );
    //    if ( ModelEntity.Wrapper.TargetId.XmlQualifiedName != null && !ModelEntity.Wrapper.TargetId.XmlQualifiedName.IsEmpty )
    //      list.Add( Resources.WrapperTreeNodeAddMenuItemGoto_Target,
    //        ModelEntity.Wrapper.TargetId.XmlQualifiedName );
    //    return list;
    //  }
    //}
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Objects_Reference; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.ReferenceType; }
    }
    public override string ToString()
    {
      return Wrapper.ReferenceType.ToString();
    }
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      return new ReferenceTreeNodeControl( this );
    }
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.OpcUaNode; }
    }
    #endregion

  }
}
