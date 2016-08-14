//_______________________________________________________________
//  Title   : Extensions
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
  /// Class Extensions - collection of helpers functions.
  /// </summary>
  public static class Extensions
  {
    /// <summary>
    /// Determines whether the is null or empty. Indicates whether the specified <paramref name="value"/> is null or <see cref="XmlQualifiedName.IsEmpty"/>.
    /// </summary>
    /// <param name="value">The value to test.</param>
    /// <returns><c>true</c> if the <paramref name="value"/> null or the property <see cref="XmlQualifiedName.IsEmpty"/> returns <c>true</c>; otherwise, <c>false</c>.</returns>
    public static bool IsNullOrEmpty(this XmlQualifiedName value)
    {
      return (value == null) || (value.IsEmpty);
    }
  }
}
