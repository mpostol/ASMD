//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  internal class UniqueIdentifier : InstanceIdentifier
  {
    #region constructor

    internal UniqueIdentifier()
    {
      InstanceDeclaration = false;
    }

    #endregion constructor

    #region public

    internal static bool IsNullOrEmpty(UniqueIdentifier ui)
    {
      if (ui != null)
        return (string.IsNullOrEmpty(ui.Name) && string.IsNullOrEmpty(ui.Namespace));
      return true;
    }

    internal string Namespace => m_Namespace;
    internal string Name => m_Name;

    /// <summary>
    /// Updates this instance of <see cref="UniqueIdentifier"/> .
    /// </summary>
    /// <param name="intermediate">
    /// if set to <c>true</c> current node is intermediate. <paramref name="Namespace"/> is assigned only
    /// if this parameter is set to <c>false</c>
    /// </param>
    /// <param name="name">The name of the node.</param>
    /// <param name="instanceDeclaration">if set to <c>true</c> it is instance declaration.</param>
    internal void Update(bool intermediate, XmlQualifiedName name, bool instanceDeclaration)
    {
      UpdateName(name);
      if (!intermediate)
      {
        m_Namespace = XmlQualifiedNameEditor.GetNamespaceOrGenerateIfInstanceIsNull(name);
        InstanceDeclaration = instanceDeclaration;
      }
    }

    internal new UniqueIdentifier MemberwiseClone()
    {
      return (UniqueIdentifier)base.MemberwiseClone();
    }

    #endregion public
  }
}