//<summary>
//  Title   : Type Design wrapper
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
using CAS.UA.Model.Designer.Types;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.Collections.Generic;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal interface ITypeDesign : INodeDesign
  {
    /// <summary>
    /// Start processing instance declarations.
    /// </summary>
    /// <param name="children">The children - collections of children processes as the inheritance chain.</param>
    /// <param name="parent">The parent.</param>
    void InstanceDeclarations(IInstanceNodesCollection children, IInstanceNodeContext parent);
  }
  /// <summary>
  /// The class represent all types in the Information Model.
  /// </summary>
  /// <typeparam name="type">The type to be used as a wrapper for GUI editor.</typeparam>
  /// <typeparam name="MT">The type of the node represented by an instance of this class.</typeparam>
  internal abstract class TypeDesign<type, MT> : NodeDesign<type, MT>, ITypeDesign
    where type : Wrappers4ProperyGrid.TypeDesign<MT>
    where MT : Opc.Ua.ModelCompiler.TypeDesign, new()
  {

    #region creators
    protected TypeDesign(type child)
      : base(child)
    { }
    protected TypeDesign(type child, MT node)
      : base(child, node)
    { }
    #endregion

    #region private
    protected abstract class TreeNode<T> : NodeDesignTreeNodeControl<T, type, MT>
      where T : TypeDesign<type, MT>
    {
      public TreeNode(T parent)
        : base(parent)
      { }
      protected override void BeforeMenuStripOpening()
      {
        AddMenuItemGoTo(Resources.WrapperTreeNodeAddMenuItemGoto
          + Resources.WrapperTreeNodeAddMenuItemGoto_BaseType,
          Resources.WrapperTreeNodeAddMenuItemGoto_BaseType_tooltip,
          new EventHandler(AddMenuItemGoTo_Click));
        base.BeforeMenuStripOpening();
      }
      private void AddMenuItemGoTo_Click(object sender, System.EventArgs e)
      {
        TreeView.GoToNode(ModelEntity.Wrapper.BaseType.XmlQualifiedName);
      }
      internal override Dictionary<string, XmlQualifiedName> GetCoupledNodesXmlQualifiedNames()
      {
        var list = base.GetCoupledNodesXmlQualifiedNames();
        if (ModelEntity.Wrapper.BaseType.XmlQualifiedName != null && !ModelEntity.Wrapper.BaseType.XmlQualifiedName.IsEmpty)
          list.Add(Resources.WrapperTreeNodeAddMenuItemGoto_BaseType, ModelEntity.Wrapper.BaseType.XmlQualifiedName);
        return list;
      }
      /// <summary>
      /// Gets the unique identifier.
      /// </summary>
      /// <param name="ui">The instance of <see cref="UniqueIdentifier"/> that represents an unique identifier.</param>
      /// <returns>
      /// 	<c>true</c> if it is not top level element; <c>false</c> otherwise if it is top level element
      /// </returns>
      internal override bool GetUniqueIdentifier(UniqueIdentifier ui)
      {
        if (!base.GetUniqueIdentifier(ui))
          ui.Update(false, ModelEntity.Wrapper.SymbolicName.XmlQualifiedName, true);
        return true;
      }
    }
    private static byte m_InheritanceDepth = 0;
    private const byte m_MaxInheritanceDepth = 20;
    /// <summary>
    /// Adds the node to the address space <see cref="IAddressSpaceCreator" />.
    /// </summary>
    /// <param name="space">The address space as a tree of nodes.</param>
    protected override void AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      int _addressSpaceIndex = space.AddNode2AddressSpace(this, SymbolicName.ToString());
      foreach (Reference item in this.References)
        space.AddReference(_addressSpaceIndex, item.Wrapper.ReferenceType.XmlQualifiedName, item.Wrapper.IsInverse, item.Wrapper.TargetId.XmlQualifiedName);
      IInstanceNodesCollection children = AddChildren(space, SymbolicName, _addressSpaceIndex, false);
      children.RegisterChildrenInAddressSpace();
      space.AddReference(_addressSpaceIndex, BuildInXmlQualifiedNames.HasSubtype, true, this.Wrapper.BaseType.ValueOrDefault);
    }
    #endregion

    #region public
    public override string CalculateReferenceRelativeName(string targetIdName)
    {
      return InstanceIdentifier.RemovePrefix(targetIdName, this.SymbolicName.Name);
    }
    #endregion

    #region ITypeDesign Members
    /// <summary>
    /// Instances the declarations.
    /// </summary>
    /// <param name="childrenCollection">The children collection.</param>
    /// <param name="parent">The parent.</param>
    void ITypeDesign.InstanceDeclarations(IInstanceNodesCollection childrenCollection, IInstanceNodeContext parent)
    {
      m_InheritanceDepth++;
      try
      {
        if (m_InheritanceDepth > m_MaxInheritanceDepth)
        {
          parent.Assert(false, String.Format("The depth of instance declaration is greater than the maximum {0}", m_MaxInheritanceDepth));
          return;
        }
        foreach (IInstanceNode _childItem in this.Children)
        {
          if (!_childItem.IsMandatory)
            continue;
          childrenCollection.Add(_childItem, parent, parent.NodeID);
        }
        foreach (Reference item in References)
          parent.AddReference(item, this, parent.NodeID);
        XmlQualifiedName myType = this.Wrapper.BaseType.ValueOrDefault;
        ITypeDesign type = Root.FindType(myType);
        if (this.Wrapper.IsItRootType)
          return;
        if (type == null)
        {
          parent.Assert(false, "Broken inheritance chain of the base type for this node.");
          return;
        }
        type.InstanceDeclarations(childrenCollection, parent);
      }
      finally
      {
        m_InheritanceDepth--;
      }
    }

    #endregion

  }
}
