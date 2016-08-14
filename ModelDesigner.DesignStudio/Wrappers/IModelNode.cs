//<summary>
//  Title   : Interface representing node in the AddressSpaceDictionary 
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

using CAS.UA.Common;
using CAS.UA.IServerConfiguration;
using CAS.UA.Model.Designer.Types;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Opc.Ua.ModelCompiler;
using System.Collections.Generic;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Interface representing the node in the AddressSpaceDictionary
  /// </summary>
  internal interface IModelNode
  {
    /// <summary>
    /// Gets the name of the node.
    /// </summary>
    /// <value>The name represented as an instance of the <see cref="string"/>.</value>
    string Name { get; }
    /// <summary>
    /// Gets the symbolic name.
    /// </summary>
    /// <value>The symbolic name.</value>
    XmlQualifiedName SymbolicName { get; }
    /// <summary>
    /// Gets the error list.
    /// </summary>
    /// <value>The error list.</value>
    IList<Diagnostics> ErrorList { get; }
    /// <summary>
    /// Gets an editor that wraps the node in the property grid user interface.*-
    /// </summary>
    /// <value>The wrapper.</value>
    object Wrapper4PropertyGrid { get; }
    /// <summary>
    /// An instance of the interface <see cref="INodeDescriptor"/> that provides the description of the node to be 
    /// bind with an external data source.
    /// </summary>
    /// <return>An instance of the interface <see cref="INodeDescriptor"/> to be bound with external data source.</return>
    INodeDescriptor GetINodeDescriptor();
    /// <summary>
    /// Gets the name of the node class.
    /// </summary>
    /// <value>The name <see cref="NodeClassesEnum"/> of the node class.</value>
    NodeClassesEnum NodeClass { get; }
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>Unique identifier to be used as the key to select the help topic.</value>
    string HelpTopicName { get; }
    /// <summary>
    /// Gets a value indicating whether this instance is read only.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is read only; otherwise, <c>false</c>.
    /// </value>
    bool IsReadOnly { get; }
  }


  #region IModelNodeAdvance
  internal interface IModelNodeAdvance : IModelNode
  {
    #region menu
    /// <summary>
    /// Should the paste menu be enabled.
    /// </summary>
    /// <returns>true if it should be enabled</returns>
    bool ShouldPasteMenuBeEnabled();
    void MenuItemCopy_Action();
    void MenuItemCut_Action();
    void MenuItemPaste_Action();
    #endregion menu

    /// <summary>
    /// Gets the folders dictionary (list) that contains other nodes.
    /// </summary>
    /// <returns>folders dictionary (list) </returns>
    Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> GetFolders();
    /// <summary>
    /// Gets the type of the node(ua noe, project, solution, folder, etc..).
    /// </summary>
    /// <value>The type of the node.</value>
    NodeTypeEnum NodeType { get; }
  }
  internal enum FolderType
  {
    Children,
    References,
    Encodings,
    InputArguments,
    OutputArguments,
    Fields,
    Model,
    Project,
    ModelNodes
  }
  internal enum NodeTypeEnum
  {
    OpcUaNode,
    ModelNode,
    ProjectNode,
    SolutionNode,
    NamespaceNode,
    NamespaceFolderNode,
    EncodinsForlderNode,
    ParameterNode,
    ParametersFolderNode,
    ReferencesFolderNode,
    ChildrenFolderNode
  }
  #endregion IModelNodeAdvance

  /// <summary>
  /// Instance of this class is used to represent errors discovered in the model.
  /// </summary>
  internal class Diagnostics
  {
    /// <summary>
    /// Gets or sets the error message.
    /// </summary>
    /// <value>The message of the error.</value>
    public string Message { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Diagnostics"/> class.
    /// </summary>
    /// <param name="message">The message.</param>
    public Diagnostics(string message)
    {
      Message = message;
    }
  }
}
