//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  /// <summary>
  /// Interface responsible for creating the list of available namespaces
  /// </summary>
  public interface IXmlQualifiedNameEditorNamespaceProvider
  {
    /// <summary>
    /// Gets the available namespaces.
    /// </summary>
    /// <returns></returns>
    string[] GetAvailiableNamespaces();

    /// <summary>
    /// Gets the target namespaces of the current model.
    /// </summary>
    /// <returns>The target namespace.</returns>
    string GetTargetNamespace();
  }
}