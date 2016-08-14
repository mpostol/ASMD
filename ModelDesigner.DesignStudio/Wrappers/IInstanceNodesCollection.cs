//<summary>
//  Title   : IInstanceDeclarationsCollection
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

using System.Collections.Generic;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Interface IInstanceNodesCollection - represents collection of instances and help to override attributes according to the inheritance chain.
  /// </summary>
  interface IInstanceNodesCollection
  {
    /// <summary>
    /// Adds the <see cref="IInstanceNode" /> to the collection of an instance or a type children with goal to build inheritance chain and override the attributes of the base type by the derived type.
    /// </summary>
    /// <param name="childItem">The child item.</param>
    /// <param name="parentNodeID">The parent node identifier.</param>
    /// <param name="parentAddressSpaceIndex">Index of the parent address space.</param>
    /// <param name="isInstanceDeclaration">if set to <c>true</c> if it is instance declaration.</param>
    void Add(IInstanceNode childItem, XmlQualifiedName parentNodeID, int parentAddressSpaceIndex, bool isInstanceDeclaration);
    /// <summary>
    /// Adds the <see cref="IInstanceNode" /> to the collection of a type children with goal to build inheritance chain and override the attributes of the base type by the derived type.
    /// </summary>
    /// <param name="childItem">The child item of the <paramref name="modelParentNode" />.</param>
    /// <param name="modelParentNode">The model parent node.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    void Add(IInstanceNode childItem, IInstanceNodeContext modelParentNode, XmlQualifiedName typeParentID);
    /// <summary>
    /// Finally registers the children in the address space.
    /// </summary>
    void RegisterChildrenInAddressSpace();

  }
}
