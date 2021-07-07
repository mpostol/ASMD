//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Types;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using UAOOI.Configuration.Core;
using UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Wrappers.AddressSpaceDictionary
{
  /// <summary>
  /// Class AddressSpaceNode - provides context data and functionality for instance node to support inheritance and instance declarations.
  /// </summary>
  internal class InstanceNodeContext : IInstanceNodeContext, IModelNode
  {
    #region constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceDeclaration"/> class it represents existing child or an instance of instance declarations.
    /// </summary>
    /// <param name="space">The address space.</param>
    /// <param name="node">The node to be represented by the instance of this class.</param>
    /// <param name="nodeID">The node unique identifier - key in the directory created as the browse path.</param>
    /// <param name="parentAddressSpaceIndex">Index of the parent in the address space if exist.</param>
    /// <param name="isInstanceDeclaration">If set to <c>true</c> object of this type represents an instance declaration.</param>
    /// <param name="modelParent">The model parent.</param>
    internal InstanceNodeContext(AddressSpaceCompiler addressSpaceCompiler, IInstanceNode node, XmlQualifiedName nodeID, int? parentAddressSpaceIndex, bool isInstanceDeclaration)
    {
      Initialize(addressSpaceCompiler, node, nodeID, isInstanceDeclaration, parentAddressSpaceIndex);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceNodeContext"/> class that represents an instance  that is on top of inheritance chain.
    /// </summary>
    /// <param name="addressSpaceCompiler">The address space compiler.</param>
    /// <param name="node">The node.</param>
    internal InstanceNodeContext(AddressSpaceCompiler addressSpaceCompiler, IInstanceNode node)
    {
      Initialize(addressSpaceCompiler, node, node.SymbolicName, false, new Nullable<int>());
      this.RegisterInstanceNodeInAddressSpace();
    }

    #endregion constructor

    #region IModelNode

    public INodeDescriptor GetINodeDescriptor()
    {
      UniqueIdentifier ui = new UniqueIdentifier();
      ui.Update(false, NodeID, true);
      return InstanceWrapper.GetINodeDescriptor(ui, NodeClass);
    }

    public string Name => m_Node.Name;
    public XmlQualifiedName SymbolicName => m_Node.SymbolicName;
    public IList<Diagnostics> ErrorList { get; set; }
    public virtual object Wrapper4PropertyGrid => InstanceWrapper;
    public NodeClassesEnum NodeClass => m_Node.NodeClass;
    public string HelpTopicName => m_Node.HelpTopicName;

    public virtual bool IsReadOnly()
    {
      return true;
    }

    #endregion IModelNode

    #region IInstanceNodeContext

    /// <summary>
    /// Registers the instance node in address space.
    /// </summary>
    public void RegisterInstanceNodeInAddressSpace()
    {
      Debug.Assert(NodeID != null, "NodeID cannot be null");
      m_Node.CompileNode(m_Compiler, this, m_IsInstanceDeclaration);
      if (m_ParentAddressSpaceIndex.HasValue)
      {
        XmlQualifiedName _childReference = InstanceWrapper.ReferenceType.ValueOrDefault;
        m_Compiler.AddReference(AddressSpaceIndex, _childReference, true, m_ParentAddressSpaceIndex.Value);
      }
      foreach (IReference item in m_References)
        m_Compiler.AddReference(AddressSpaceIndex, item.ReferenceType, item.Inverse, item.TargetName);
    }

    /// <summary>
    /// Adds the instance declaration of.
    /// </summary>
    /// <param name="node">The node to be duplicated by deriving from the instance declaration.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    void IInstanceNodeContext.AddInstanceDeclarationOf(IInstanceNode node, XmlQualifiedName typeParentID)
    {
      InstanceWrapper = InstanceWrapper.DerivePropertyValuesFrom((IInstanceDesign)node.Wrapper4PropertyGrid);
      node.AddAllReferences4InstanceDeclaration(m_References, typeParentID);
    }

    /// <summary>
    /// Gets the node unique identifier - dash separated symbolic path.
    /// </summary>
    /// <value>The node identifier.</value>
    public XmlQualifiedName NodeID => m_NodeID;

    /// <summary>
    /// Adds the reference from the type definition of this instance.
    /// </summary>
    /// <param name="reference">The reference.</param>
    /// <param name="referenceParent">The reference parent.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    void IInstanceNodeContext.AddReference(Reference reference, INodeDesign referenceParent, XmlQualifiedName typeParentID)
    {
      m_References.AddReference(reference, referenceParent, typeParentID);
    }

    /// <summary>
    /// Gets the type definition of the node.
    /// </summary>
    /// <value>The type definition.</value>
    public XmlQualifiedName TypeDefinition => InstanceWrapper.TypeDefinition.ValueOrDefault;

    /// <summary>
    /// Adds the modeling rule to the node provided it is instance declaration. If the node is not instance declaration an error is reported.
    /// </summary>
    void IInstanceNodeContext.AddModelingRule()
    {
      if (m_IsInstanceDeclaration)
        return;
      if (ModelingRulesObject != ModellingRule.None)
        m_Compiler.AddReference(AddressSpaceIndex, BuildInXmlQualifiedNames.HasModelingRule, false, BuildInXmlQualifiedNames.ModelingRuleSymbolicName(ModelingRulesObject));
    }

    /// <summary>
    /// Gets the node index in the address space.
    /// </summary>
    /// <value>The index of node in the address space.</value>
    public int AddressSpaceIndex { get; private set; }

    /// <summary>
    /// Checks for a condition; if the condition is false, trace the <paramref name="errorMessage" /> message and adds diagnostic information <see cref="Diagnostics" />
    /// to the node pointed out by the <paramref name="sourceIndex" />.
    /// </summary>
    /// <param name="condition">The conditional expression to evaluate. If the condition is not true, the specified message is
    /// reported as the compilation error.</param>
    /// <param name="errorMessage">The error message.</param>
    void IInstanceNodeContext.Assert(bool condition, string errorMessage)
    {
      m_Compiler.Assert(condition, this.AddressSpaceIndex, errorMessage);
    }

    #endregion IInstanceNodeContext

    #region private

    private InstanceReferencesCollection m_References;
    private XmlQualifiedName m_NodeID;
    private int? m_ParentAddressSpaceIndex;
    private AddressSpaceCompiler m_Compiler;
    private bool m_IsInstanceDeclaration = false;
    private IInstanceNode m_Node;
    private IInstanceDesign InstanceWrapper { get; set; }

    private void Initialize(AddressSpaceCompiler addressSpaceCompiler, IInstanceNode node, XmlQualifiedName nodeID, bool isInstanceDeclaration, int? parentAddressSpaceIndex)
    {
      Debug.Assert(node != null, "Parameter error at AddressSpaceNode creator: node cannot be null");
      Debug.Assert(nodeID != null, "NodeID cannot be null");
      ErrorList = new List<Diagnostics>();
      m_References = new InstanceReferencesCollection(this);
      m_Compiler = addressSpaceCompiler;
      m_IsInstanceDeclaration = isInstanceDeclaration;
      m_ParentAddressSpaceIndex = parentAddressSpaceIndex;
      m_Node = node;
      m_NodeID = nodeID;
      AddressSpaceIndex = m_Compiler.AddNode2AddressSpace(this, m_NodeID.ToString());
      InstanceWrapper = m_Node.DerivePropertyValuesFrom(null);
    }

    private ModellingRule ModelingRulesObject => InstanceWrapper.ModellingRule.GetValueOrDefault(ModellingRule.Mandatory);

    #endregion private
  }
}