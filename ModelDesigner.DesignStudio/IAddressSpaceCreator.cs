//<summary>
//  Title   : Interface that is used to create Address Space
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Wrappers;
using System.Collections.Generic;
using System.Xml;

namespace CAS.UA.Model.Designer
{
  /// <summary>
  /// Interface IAddressSpaceCreator - represent functionality used to build step by step the address space. 
  /// </summary>
  internal interface IAddressSpaceCreator
  {

    /// <summary>
    /// Adds the reference to the address space.
    /// </summary>
    /// <param name="sourceIndex">Index of the source node in the address space.</param>
    /// <param name="referenceTypeName">Name of the reference type.</param>
    /// <param name="inverse">if set to <c>true</c> it is inverse reference.</param>
    /// <param name="targetName">Name of the target node.</param>
    void AddReference(int sourceIndex, XmlQualifiedName referenceTypeName, bool inverse, XmlQualifiedName targetName);
    /// <summary>
    /// Adds the node of the information model to the Address Space.
    /// </summary>
    /// <param name="node">The node to be added.</param>
    /// <param name="uniqueName">Unique name of the node in the address space.</param>
    /// <returns>Unique index in the AddressSpace</returns>
    int AddNode2AddressSpace(IModelNode node, string uniqueName);
    /// <summary>
    /// Adds an information model instance node <paramref name="node" /> to address space. 
    /// It is used to register an existing node.
    /// </summary>
    /// <param name="node">The node to be added to the address space.</param>
    void AddNode2AddressSpace(IInstanceNode node);
    /// <summary>
    /// Creates the nodes collection to start processing instance declarations recursively and override nodes in the derived types. 
    /// All collected nodes must be added to the address space together at the end of processing.
    /// </summary>
    /// <returns>An instance of <see cref="IInstanceNodesCollection"/>IAddressSpaceNodesCollection.</returns>
    IInstanceNodesCollection CreateNodesCollection();

  }
}
