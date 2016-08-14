//_______________________________________________________________
//  Title   : Name of Application
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
  /// Interface IInstanceReferencesCollection - represents a collections of references for an instance declaration.
  /// </summary>
  internal interface IInstanceReferencesCollection
  {
    /// <summary>
    /// Adds the reference to the collection.
    /// </summary>
    /// <param name="reference">The reference to be added.</param>
    /// <param name="referenceParent">The reference parent.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    void AddReference(Reference reference, INodeDesign referenceParent, XmlQualifiedName typeParentID);
  }
}
