//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Types;
using System;
using System.Xml;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

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
    where MT : OpcUaModelCompiler.TypeDesign, new()
  {
    #region constructor

    protected TypeDesign(type wrapper4PropertyGrid)
      : base(wrapper4PropertyGrid)
    { }

    protected TypeDesign(type wrapper4PropertyGrid, MT node)
      : base(wrapper4PropertyGrid, node)
    { }

    #endregion constructor

    #region private

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

    #endregion private

    #region public

    public override string CalculateReferenceRelativeName(string targetIdName)
    {
      return InstanceIdentifier.RemovePrefix(targetIdName, this.SymbolicName.Name);
    }

    #endregion public

    #region ITypeDesign

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
        ITypeDesign type = SolutionTreeNode.SolutionRoot.FindType(myType);
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

    #endregion ITypeDesign
  }
}