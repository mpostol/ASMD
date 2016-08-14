//<summary>
//  Title   : InstanceInAddressSpaceCollection
//  System  : Microsoft VisualStudio 2013 / C#
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2014, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.Collections.Generic;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers.AddressSpaceDictionary
{
  /// <summary>
  /// Instances of this class represent inheritance functionality for instance nodes collection
  /// </summary>
  internal class InstanceNodesCollection : IInstanceNodesCollection
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceNodesCollection"/> class.
    /// </summary>
    /// <param name="compiler">The compiler.</param>
    public InstanceNodesCollection(AddressSpaceCompiler compiler)
    {
      m_compiler = compiler;
    }

    #region IAddressSpaceNodesCollection
    /// <summary>
    /// Adds the <see cref="IInstanceNode" /> to the collection of a type children with goal to build inheritance chain and override the attributes of the base type by the derived type.
    /// </summary>
    /// <param name="childItem">The child item of the <paramref name="modelParentNode" />.</param>
    /// <param name="modelParentNode">The model parent node - the node, which type is processed and <paramref name="childItem" /> added.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    void IInstanceNodesCollection.Add(IInstanceNode childItem, IInstanceNodeContext modelParentNode, XmlQualifiedName typeParentID)
    {
      XmlQualifiedName _itemNodeID = InstanceIdentifier.AddSuffix(modelParentNode.NodeID, childItem.SymbolicName.Name);
      string _stringItemNodeID = InstanceIdentifier.NodeId(_itemNodeID);
      if (this.m_dictionary.ContainsKey(_stringItemNodeID))
        this.m_dictionary[_stringItemNodeID].AddInstanceDeclarationOf(childItem, typeParentID);
      else
        this.Add(_stringItemNodeID, childItem, _itemNodeID, modelParentNode.AddressSpaceIndex, true);
    }
    void IInstanceNodesCollection.Add(IInstanceNode childItem, XmlQualifiedName parentNodeID, int parentAddressSpaceIndex, bool isInstanceDeclaration)
    {
      XmlQualifiedName _itemNodeID = InstanceIdentifier.AddSuffix(parentNodeID, childItem.SymbolicName.Name);
      string _stringItemNodeId = InstanceIdentifier.NodeId(_itemNodeID);
      if (!this.m_dictionary.ContainsKey(_stringItemNodeId))
        this.Add(_stringItemNodeId, childItem, _itemNodeID, parentAddressSpaceIndex, isInstanceDeclaration);
      else
      {
        string _msg = String.Format("The node {0} is declared twice and has been removed from the model", childItem.SymbolicName.ToString());
        m_compiler.Assert(false, parentAddressSpaceIndex, _msg);
      }
    }
    /// <summary>
    /// Finally registers the children in the address space.
    /// </summary>
    void IInstanceNodesCollection.RegisterChildrenInAddressSpace()
    {
      foreach (IInstanceNodeContext item in m_dictionary.Values)
        item.RegisterInstanceNodeInAddressSpace();
    }
    #endregion

    #region private
    private void Add(string nodeId, IInstanceNode node, XmlQualifiedName nodeID, int parentAddressSpaceIndex, bool isInstanceDeclaration)
    {
      this.m_dictionary.Add(nodeId, new InstanceNodeContext(m_compiler, node, nodeID, parentAddressSpaceIndex, isInstanceDeclaration));
    }
    private AddressSpaceCompiler m_compiler;
    private SortedList<string, IInstanceNodeContext> m_dictionary = new SortedList<string, IInstanceNodeContext>();
    #endregion

  }
}
