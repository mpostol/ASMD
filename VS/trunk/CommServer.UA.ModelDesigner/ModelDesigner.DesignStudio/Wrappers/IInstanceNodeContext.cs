//_______________________________________________________________
//  Title   : IInstanceNodeContext
//  System  : Microsoft VisualStudio 2013 / C#
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2015, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{

  /// <summary>
  /// Interface IInstanceNodeContext - provides context data and functionality for instance node to support inheritance and instance declarations.
  /// </summary>
  internal interface IInstanceNodeContext
  {

    /// <summary>
    /// Gets the index of the node in the address space.
    /// </summary>
    /// <value>The index of the address space.</value>
    int AddressSpaceIndex { get; }
    /// <summary>
    /// Gets the node unique identifier - dash separated symbolic path.
    /// </summary>
    /// <value>The node identifier.</value>
    XmlQualifiedName NodeID { get; }
    /// <summary>
    /// Gets the type definition of the node.
    /// </summary>
    /// <value>The type definition.</value>
    XmlQualifiedName TypeDefinition { get; }
    /// <summary>
    /// Adds the modeling rule to the node provided it is instance declaration. If the node is not instance declaration an error is reported.
    /// </summary>
    /// <param name="isInstanceDeclaration">if set to <c>true</c> this node is an instance declaration.</param>
    void AddModelingRule();
    /// <summary>
    /// Adds the reference from the type definition of an instance.
    /// </summary>
    /// <param name="reference">The reference to be added.</param>
    /// <param name="referenceParent">A child of type design node defining this reference.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    void AddReference(Reference reference, INodeDesign referenceParent, XmlQualifiedName typeParentID);
    /// <summary>
    /// Adds the instance declaration of.
    /// </summary>
    /// <param name="node">The node to be duplicated by deriving from the instance declaration.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    void AddInstanceDeclarationOf(IInstanceNode node, XmlQualifiedName typeParentID);
    /// <summary>
    /// Registers the instance node in address space - recursively process the compilation of inheritance chain and instance declarations..
    /// </summary>
    void RegisterInstanceNodeInAddressSpace();
    /// <summary>
    /// Checks for a condition; if the condition is false, trace the <paramref name="errorMessage" /> message and adds diagnostic information <see cref="Diagnostics" />
    /// to the node pointed out by the <paramref name="sourceIndex" />.
    /// </summary>
    /// <param name="condition">The conditional expression to evaluate. If the condition is not true, the specified message is 
    /// reported as the compilation error.</param>
    /// <param name="errorMessage">The error message.</param>
    void Assert(bool condition, string errorMessage);

  }
}
