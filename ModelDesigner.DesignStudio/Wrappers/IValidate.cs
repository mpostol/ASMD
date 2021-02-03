//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer
{
  internal interface IValidate
  {
    /// <summary>
    /// Validates this instance.
    /// </summary>
    void Validate();
  }

  internal interface IParent : IValidate
  {
    /// <summary>
    /// Gets the model designer node and initialize it with the data from the tree.
    /// </summary>
    /// <value>The model designer node derived from <see cref="OpcUaModelCompiler.NodeDesign"/>.</value>
    object ModelDesignerNode { get; }

    /// <summary>
    /// Gets the available namespaces.
    /// </summary>
    /// <value>The available namespaces.</value>
    string[] AvailiableNamespaces { get; }

    /// <summary>
    /// Gets the target namespace of the current project.
    /// </summary>
    /// <returns>The target namespace.</returns>
    string GetTargetNamespace();
  }
}