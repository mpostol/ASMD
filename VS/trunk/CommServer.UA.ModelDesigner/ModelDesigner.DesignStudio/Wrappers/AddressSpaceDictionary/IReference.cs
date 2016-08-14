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

namespace CAS.UA.Model.Designer.Wrappers.AddressSpaceDictionary
{
  /// <summary>
  /// Interface IReference - represents reference of an instance declaration
  /// </summary>
  internal interface IReference
  {
    /// <summary>
    /// Gets the type of the reference.
    /// </summary>
    /// <value>An instance of <see cref="XmlQualifiedName"/> that represents the type name of the reference.</value>
    XmlQualifiedName ReferenceType { get; }
    /// <summary>
    /// Gets a value indicating whether this <see cref="IReference"/> is inverse.
    /// </summary>
    /// <value><c>true</c> if inverse; otherwise, <c>false</c>.</value>
    bool Inverse { get; }
    /// <summary>
    /// Gets the name of the target.
    /// </summary>
    /// <value>An instance of <see cref="XmlQualifiedName"/> that represents the name of the target.</value>
    XmlQualifiedName TargetName { get; }
  }
}
