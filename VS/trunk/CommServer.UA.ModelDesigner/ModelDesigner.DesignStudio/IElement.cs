//<summary>
//  Title   : Interface representing model nodes for the browse tree view.
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

namespace CAS.UA.Model.Designer
{
  /// <summary>
  /// Interface representing model nodes for the <see cref="BrowseViewTreeView"/>.
  /// </summary>
  internal interface IElement
  {
    object ReferenceTypeWrapper4PropertyGrid { get; }
    object NodeWrapper4PropertyGrid { get; }
    /// <summary>
    /// Gets the children of the node.
    /// </summary>
    /// <param name="backward">if set to <c>true</c> return all nodes in the backward direction.</param>
    /// <param name="forward">if set to <c>true</c> return all nodes in the forward direction.</param>
    /// <returns>IElement[].</returns>
    /// <value>The children elements represented by an instance of this interface.</value>
    IElement[] GetChildren(bool backward, bool forward);
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    string Name { get; set; }
    string ReferenceName { get; }
    NodeClassesEnum NodeClass { get; }
    IList<Diagnostics> ErrorsList { get; }
    /// <summary>
    /// Gets an instance of thy <see cref="IModelNode"/>.
    /// </summary>
    /// <value>The instance implementing IModelNode.</value>
    /// <remarks>
    /// If the target represented by this instance is the instance declaration the <see cref="IModelNode"/> is provided 
    /// by a read only stub.
    /// </remarks>
    IModelNode ModelNode { get; }
  }
}
