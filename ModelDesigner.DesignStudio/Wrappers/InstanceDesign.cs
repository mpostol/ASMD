//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Types;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System.Collections.Generic;
using System.Xml;
using UAOOI.Configuration.Core;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal abstract class InstanceDesign<type, OPCType> : NodeDesign<type, OPCType>, IInstanceNode
    where type : Wrappers4ProperyGrid.InstanceDesign<OPCType>, IInstanceDesign
    where OPCType : Opc.Ua.ModelCompiler.InstanceDesign, new()
  {
    #region constructors
    protected InstanceDesign(type child) : base(child) { }
    protected InstanceDesign(type child, OPCType node) : base(child, node) { }
    #endregion

    #region private
    protected override void AddNodeDescriptors(List<INodeDescriptor> dsptrs, UniqueIdentifier ui)
    {
      ui.Update(false, Wrapper.SymbolicName.XmlQualifiedName, false);
      base.AddNodeDescriptors(dsptrs, ui);
    }
    /// <summary>
    /// Adds to address space.
    /// </summary>
    /// <param name="children">The children.</param>
    /// <returns></returns>
    protected void InstanceDeclarations(IInstanceNodesCollection children, IInstanceNodeContext thisInstance)
    {
      //Methods do not have equivalent of type definition reference.
      if (this.NodeClass == NodeClassesEnum.Method)
        return;
      ITypeDesign type = SolutionTreeNode.SolutionRoot.FindType(thisInstance.TypeDefinition);
      if (type == null)
      {
        thisInstance.Assert(false, "Cannot find TypeDefinition for the instance.");
        return;
      }
      type.InstanceDeclarations(children, thisInstance);
    }
    /// <summary>
    /// Adds this instance to the address space.
    /// </summary>
    /// <param name="space">The space.</param>
    /// <returns></returns>
    protected override void AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      space.AddNode2AddressSpace(this);
    }
    #endregion

    #region public
    public override string CalculateReferenceRelativeName(string targetIdName)
    {
      if (Parent == null)
        return targetIdName;
      ChildrenFolder parent = this.Parent as ChildrenFolder;
      if (parent == null)
        return targetIdName;
      return (parent.CalculateReferenceRelativeName(targetIdName));
    }
    /// <summary>
    /// Gets the node descriptors.
    /// </summary>
    /// <returns>
    /// Instance of <see cref="INodeDescriptor"/> containing node descriptor.
    /// </returns>
    internal override INodeDescriptor[] GetNodeDescriptors()
    {
      List<INodeDescriptor> _descriptors = new List<INodeDescriptor>();
      UniqueIdentifier ui = new UniqueIdentifier();
      AddNodeDescriptors(_descriptors, ui);
      return _descriptors.ToArray();
    }
    /// <summary>
    /// Retrieves aa instance of the interface <see cref="INodeDescriptor"/> that provides the description of the node to be
    /// bind with an external data source.
    /// </summary>
    /// <param name="UniqueIdentifierOfRequestedWrapper">The unique identifier of requested node descriptor.</param>
    /// <returns>
    /// An instance of the interface <see cref="INodeDescriptor"/> to be bound with external data source.
    /// </returns>
    internal override INodeDescriptor GetINodeDescriptor(UniqueIdentifier UniqueIdentifierOfRequestedWrapper)
    {
      return Wrapper.GetINodeDescriptor(UniqueIdentifierOfRequestedWrapper, NodeClass);
    }
    #endregion

    #region IInstanceNode Members
    /// <summary>
    /// Adds all references for an instance declaration recursively.
    /// </summary>
    /// <param name="references">The references collection already collected traversing the inheritance chain.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    void IInstanceNode.AddAllReferences4InstanceDeclaration(IInstanceReferencesCollection references, XmlQualifiedName typeParentID)
    {
      foreach (Reference item in References)
        references.AddReference(item, this, typeParentID);
    }
    IInstanceDesign IInstanceNode.DerivePropertyValuesFrom(IInstanceDesign source)
    {
      return this.Wrapper.DerivePropertyValuesFrom(source);
    }
    /// <summary>
    /// Processes the node.
    /// </summary>
    /// <param name="space">The address space.</param>
    /// <param name="nodeContext">The parent.</param>
    /// <param name="modelParent">The model parent.</param>
    /// <param name="isInstanceDeclaration">if set to <c>true</c> it is instance declaration.</param>
    void IInstanceNode.CompileNode(IAddressSpaceCreator space, IInstanceNodeContext nodeContext, bool isInstanceDeclaration)
    {
      IInstanceNodesCollection children = AddChildren(space, nodeContext.NodeID, nodeContext.AddressSpaceIndex, isInstanceDeclaration);
      InstanceDeclarations(children, nodeContext);
      children.RegisterChildrenInAddressSpace();
      foreach (Reference item in this.References)
        space.AddReference(nodeContext.AddressSpaceIndex, item.Wrapper.ReferenceType.XmlQualifiedName, item.Wrapper.IsInverse, item.Wrapper.TargetId.XmlQualifiedName);
      space.AddReference(nodeContext.AddressSpaceIndex, BuildInXmlQualifiedNames.HasTypeDefinition, false, nodeContext.TypeDefinition);
      nodeContext.AddModelingRule();
    }
    /// <summary>
    /// Determines whether this instance is mandatory.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance has associated mandatory modeling rule; otherwise, <c>false</c>.
    /// </value>
    bool IInstanceNode.IsMandatory => this.Wrapper.IsMandatory;
    #endregion
  }
  /// <summary>
  /// Dedicated InstanceDesign interface to be used to represent this TreeNode in the user interface
  /// </summary>
  internal interface IInstanceDesignTreeNode
  {
    /// <summary>
    /// Gets the server UA menu.
    /// </summary>
    /// <param name="items">The items collection to expand.</param>
    void GetServerUAMenu(System.Windows.Forms.ToolStripItemCollection items);
  }
}

