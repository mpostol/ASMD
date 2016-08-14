//<summary>
//  Title   : Reference
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
using System.Collections.Generic;

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
    private class TreeNode: WrapperBase<Wrappers4ProperyGrid.Reference, Opc.Ua.ModelCompiler.Reference>.TreeNode<Reference>
    {
      public TreeNode( Reference parent )
        : base( parent )
      { }
      internal override Dictionary<string, System.Xml.XmlQualifiedName> GetCoupledNodesXmlQualifiedNames()
      {
        var list = base.GetCoupledNodesXmlQualifiedNames();
        if ( Creator.Wrapper.ReferenceType.XmlQualifiedName != null && !Creator.Wrapper.ReferenceType.XmlQualifiedName.IsEmpty )
          list.Add( Resources.WrapperTreeNodeAddMenuItemGoto_ReferenceType,
            Creator.Wrapper.ReferenceType.XmlQualifiedName );
        if ( Creator.Wrapper.TargetId.XmlQualifiedName != null && !Creator.Wrapper.TargetId.XmlQualifiedName.IsEmpty )
          list.Add( Resources.WrapperTreeNodeAddMenuItemGoto_Target,
            Creator.Wrapper.TargetId.XmlQualifiedName );
        return list;
      }
    }
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
    internal override DictionaryTreeView.DictionaryTreeNode GetTreeNode()
    {
      return new TreeNode( this );
    }
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.OpcUaNode; }
    }
    #endregion

  }
}
