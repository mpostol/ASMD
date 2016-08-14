//<summary>
//  Title   : Name of Application
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2010, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System.Xml;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Interface provided by the <see cref="InstanceDesign"/> objects.
  /// </summary>
  internal interface IInstanceNode : IModelNode
  {

    /// <summary>
    /// Adds all references4 defined by the <see cref="IInstanceNode" /> representing an instance declaration.
    /// </summary>
    /// <param name="references">The references.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    void AddAllReferences4InstanceDeclaration(IInstanceReferencesCollection references, XmlQualifiedName typeParentID);
    /// <summary>
    /// Compiles the nodes - adds children, references and base type to the address space
    /// </summary>
    /// <param name="compiler">The compiler.</param>
    /// <param name="parent">The parent node.</param>
    /// <param name="isInstanceDeclaration">if set to <c>true</c> it is instance declaration - new node created from the node base type definition.</param>
    void CompileNode(IAddressSpaceCreator compiler, IInstanceNodeContext parent, bool isInstanceDeclaration);
    /// <summary>
    /// Creates the new instance and derived not overridden property values from the <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The base node that is source for attributes values not overridden by this node.</param>
    /// <returns>New instance of <see cref="IInstanceDesign"/>.</returns>
    IInstanceDesign DerivePropertyValuesFrom(IInstanceDesign source);
    /// <summary>
    /// Determines whether this instance is mandatory.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance has associated mandatory modeling rule; otherwise, <c>false</c>.
    /// </value>
    bool IsMandatory { get; }
  
  }
}
