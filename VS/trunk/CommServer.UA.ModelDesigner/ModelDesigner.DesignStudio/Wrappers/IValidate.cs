//<summary>
//  Title   : IValidate and IParent interface
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>


namespace CAS.UA.Model.Designer
{
  interface IValidate
  {
    /// <summary>
    /// Validates this instance.
    /// </summary>
    void Validate();
  }
  interface IParent: IValidate
  {
    /// <summary>
    /// Gets the model designer node and initialize it with the data from the tree.
    /// </summary>
    /// <value>The model designer node derived from <see cref="Opc.Ua.ModelCompiler.NodeDesign"/>.</value>
    object ModelDesignerNode { get; }
    /// <summary>
    /// Gets the availiable namespaces.
    /// </summary>
    /// <value>The availiable namespaces.</value>
    string[] AvailiableNamespaces { get; }
    /// <summary>
    /// Gets the target namespace of the current project.
    /// </summary>
    /// <returns>The target namespace.</returns>
    string GetTargetNamespace (); 
  }
}
