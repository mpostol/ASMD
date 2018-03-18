//<summary>
//  Title   : Instance Unique Identifier class
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

using CAS.Lib.ControlLibrary;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class UniqueIdentifier: InstanceIdentifier
  {
    #region creator
    internal UniqueIdentifier()
    {
      InstanceDeclaration = false;
    }
    #endregion

    #region public
    internal static bool IsNullOrEmpty( UniqueIdentifier ui )
    {
      if ( ui != null )
        return ( string.IsNullOrEmpty( ui.Name ) && string.IsNullOrEmpty( ui.Namespace ) );
      return true;
    }
    internal string Namespace { get { return m_Namespace; } }
    internal string Name { get { return m_Name; } }
    /// <summary>
    /// Updates this instance of <see cref="UniqueIdentifier"/> .
    /// </summary>
    /// <param name="intermediate">
    /// if set to <c>true</c> current node is intermediate. <paramref name="Namespace"/> is assigned only 
    /// if this parameter is set to <c>false</c>
    /// </param>
    /// <param name="name">The name of the node.</param>
    /// <param name="instanceDeclaration">if set to <c>true</c> it is instance declaration.</param>
    internal void Update( bool intermediate, XmlQualifiedName name, bool instanceDeclaration )
    {
      UpdateName( name );
      if ( !intermediate )
      {
        m_Namespace = XmlQualifiedNameEditor.GetNamespaceOrGenerateIfInstanceIsNull( name );
        InstanceDeclaration = instanceDeclaration;
      }
    }
    internal new UniqueIdentifier MemberwiseClone()
    {
      return (UniqueIdentifier)base.MemberwiseClone();
    }
    #endregion
  }
}
