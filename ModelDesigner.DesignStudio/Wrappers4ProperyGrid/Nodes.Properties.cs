//<summary>
//  Title   : ModelDesign : Nodes.Properties
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

using System.ComponentModel;
using System.Xml;
using CAS.Lib.ControlLibrary;
using CAS.UA.Common;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using CAS.UA.IServerConfiguration;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  #region class Design
  /// <summary>
  /// Base Design class
  /// </summary>
  /// <typeparam name="T">Class from Opc UA Model Designer</typeparam>
  internal abstract partial class Design<T>
  { }
  #endregion

  #region class ModelDesign
  /// <summary>
  ///The primary objective of the OPC UA AddressSpace is to provide a standard way 
  ///for servers to represent Objects to clients. 
  ///The OPC UA Object Model has been designed to meet this objective. 
  ///It defines Objects in terms of Variables and Methods. 
  ///It also allows relationships to other Objects to be expressed. 
  ///The elements of this model are represented in the AddressSpace as Nodes. 
  ///Each Node is assigned to a NodeClass and each NodeClass represents a different 
  ///element of the Object Model. 
  /// </summary>
  internal partial class ModelDesign : Design<Opc.Ua.ModelCompiler.ModelDesign>
  {
    #region public properties
    /// <summary>
    /// Gets or sets the target namespace.
    /// </summary>
    /// <value>The target namespace.</value>
    [
    DisplayName("Target Namespace"),
    BrowsableAttribute(true),
    DescriptionAttribute("The URI for the target namespace of the model."),
    CategoryAttribute("Namespace")
    ]
    public string TargetNamespace { get; set; }
    [
    DisplayName("Target Namespace Version"),
    BrowsableAttribute(true),
    DescriptionAttribute("Version of the model. Attribute is optional."),
    CategoryAttribute("Namespace")
    ]
    public string TargetNamespaceVersion { get; set; }
    /// <summary>
    /// Gets or sets the target XML namespace.
    /// </summary>
    /// <value>The target XML namespace.</value>
    [
    DisplayName("Target XML Namespace"),
    BrowsableAttribute(true),
    DescriptionAttribute("The URI for the target XML namespace, which the model belong to."),
    CategoryAttribute("Namespace")
    ]
    public string TargetXmlNamespace { get; set; }
    /// <summary>
    /// Gets or sets the default locale.
    /// </summary>
    /// <value>The default locale.</value>
    [
    DisplayName("Default Locale"),
    BrowsableAttribute(true),
    DescriptionAttribute("The default locale of the model. Default language is 'en' - English ."),
    CategoryAttribute("Model")
    ]
    public string DefaultLocale { get; set; }
    /// <summary>
    /// Gets or sets any attr.
    /// </summary>
    /// <value>Any attr.</value>
    [
    DisplayName("Any attribute"),
    BrowsableAttribute(false),
    DescriptionAttribute("Any attribute"),
    CategoryAttribute("Model")
    ]
    public XmlAttribute[] AnyAttr { get; set; }

    #endregion
  }
  #endregion

  #region class Namespace
  /// <summary>
  /// In general, a namespace is an abstract container providing context for the items 
  ///   it holds and allowing disambiguation of items having the same name (residing in different namespaces).
  ///   As a rule, names in a namespace cannot have more than one meaning, that is, two or more things cannot share the same name. 
  ///   A namespace is also called a context, as the valid meaning of a name can change depending on what namespace applies. 
  ///   Names in it can represent objects as well as concept, whether it is a natural or ethnic language, 
  ///   a constructed language, the technical terminology of a profession, a dialect, a sociolect, or an artificial language (e.g., a programming language).
  /// </summary>
  internal partial class Namespace : Design<Opc.Ua.ModelCompiler.Namespace>
  {
    #region public properties
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [
    DisplayName("Name"),
    BrowsableAttribute(true),
    DescriptionAttribute("A symbolic name for the namespace, that can be used as a variable name."),
    CategoryAttribute("Namespace")
    ]
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the prefix.The Prefix is the C# namespace which qualifies the generated types.
    /// </summary>
    /// <value>The prefix.</value>
    [
    DisplayName("Prefix"),
    BrowsableAttribute(true),
    DescriptionAttribute("The .NET namespace used for the classes produced by the generator."),
    CategoryAttribute("Namespace")
    ]
    public string Prefix { get; set; }
    /// <summary>
    /// Gets or sets the internal prefix.The InternalPrefix is an optional C# namespace which qualifies the generated types used only by the server.
    /// </summary>
    /// <value>The internal prefix.</value>
    [
    DisplayName("Internal Prefix"),
    BrowsableAttribute(true),
    DescriptionAttribute("The .NET namespace used for classes, that are only used within a server application. The InternalPrefix is an optional C# namespace which qualifies the generated types used only by the server."),
    CategoryAttribute("Namespace")
    ]
    public string InternalPrefix { get; set; }
    /// <summary>
    /// Gets or sets the XML namespace.
    /// </summary>
    /// <value>The XML namespace.</value>
    [
      //EditorAttribute( typeof( System.Web.UI.Design.XmlUrlEditor ), typeof( UITypeEditor ) ),
    DisplayName("Xml Namespace"),
    BrowsableAttribute(true),
    DescriptionAttribute("The URI for the XML namespace, which the data types belong to, if it is different from the URI for the model namespace."),
    CategoryAttribute("Namespace")
    ]
    public string XmlNamespace { get; set; }
    /// <summary>
    /// Gets or sets the file path of the model.
    /// </summary>
    /// <value>The file path.</value>
    [
    DisplayName("File Path"),
    BrowsableAttribute(true),
    DescriptionAttribute("The path to the file containing the design file for the namespace. This file name should not contain any extension."),
    CategoryAttribute("Namespace"),
    ReadOnlyAttribute(false)
    ]
    public string FilePath { get; set; }
    /// <summary>
    /// Gets or sets the value of the Namespace element in the xml document. The value represents the model Namespace URI.
    /// </summary>
    /// <value>The value.</value>
    [
    DisplayName("Namespace URI"),
    BrowsableAttribute(true),
    DescriptionAttribute("The value of the model namespace URI. It is a container for a set of BrowseNames. The namespace is a URI that identifies the naming authority responsible for assigning the identifier element of the BrowseName. Defining BrowseName in context of namespace make it possible to distinguish between BrowseNames with the same exact name, but defined by independent authorities, i.e. the namespace is employed for the purpose of identifiers around a particular OPC UA Information Model."),
    CategoryAttribute("Namespace")
    ]
    public string Value { get; set; }
    /// <summary>
    /// Gets or sets the XML prefix.The Prefix is the XML namespace.
    /// </summary>
    /// <value>The XML prefix.</value>
    [
    DisplayName("XML Prefix"),
    BrowsableAttribute(true),
    DescriptionAttribute("The prefix is used in the XML file for the XML namespace, which the data types belong to. Used only XmlNamespace is set."),
    CategoryAttribute("Namespace")
    ]
    public string XmlPrefix { get; set; }
    #endregion
  }
  #endregion

  #region class Reference
  /// <summary>
  /// Defines a reference between two nodes.
  /// </summary>
  internal partial class Reference : Design<Opc.Ua.ModelCompiler.Reference>
  {
    #region public properties
    /// <summary>
    /// Gets or sets the type of the reference.
    /// </summary>
    /// <value>The type of the reference.</value>
    [
    DisplayName("ReferenceType"),
    BrowsableAttribute(true),
    DescriptionAttribute("The type of the reference"),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Reference"),
    DocumentationAttribute("ReferenceType", typeof(GetterOfNameAsString))
    ]
    public XmlQualifiedNameEditorWithDefaultValue ReferenceType { get; set; }
    /// <summary>
    /// Gets or sets the target id.
    /// </summary>
    /// <value>The target id.</value>
    [
    DisplayName("TargetId"),
    BrowsableAttribute(true),
    DescriptionAttribute("The identifier of the TargetNode. TargetNode is a Node that is referenced by another Node. " +
      "For example, in the Reference “A Contains B”, “B” is the TargetNode and it is pointed by the TargetId. "),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Reference"),
    DocumentationAttribute("TargetId", typeof(GetterOfNameAsString))
    ]
    public XmlQualifiedNameEditor TargetId { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether this instance is inverse (the  value indicating whether this instance is inverse).
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is inverse; otherwise, <c>false</c>.
    /// </value>
    [
    DisplayName("IsInverse"),
    BrowsableAttribute(true),
    DescriptionAttribute("The  value indicating whether this reference is inverse"),
    CategoryAttribute("Reference"),
    DocumentationAttribute("IsInverse")
    ]
    public bool IsInverse { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether this instance is one way.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is one way; otherwise, <c>false</c>.
    /// </value>
    [
    DisplayName("Is One Way"),
    BrowsableAttribute(true),
    DescriptionAttribute("The value indicating whether this reference is one way."),
    CategoryAttribute("Reference")
    ]
    public bool IsOneWay { get; set; }
    #endregion
  }
  #endregion

  #region class Parameter
  /// <summary>
  /// Defines a Field in a DataType or Argument of a Method.
  /// </summary>
  internal partial class Parameter : Design<Opc.Ua.ModelCompiler.Parameter>
  {
    #region public properties
    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>The description.</value>
    [
    DisplayName("Description"),
    BrowsableAttribute(true),
    DescriptionAttribute("The localised description of the Parameter"),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Parameter"),
    DocumentationAttribute("Description", typeof(GetterOfNameAsString))
    ]
    public LocalizedText Description { get; set; }
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [
    DisplayName("Name"),
    BrowsableAttribute(true),
    DescriptionAttribute("The name of the Parameter"),
    CategoryAttribute("Parameter"),
    DocumentationAttribute("Name")
    ]
    public string Name { get; set; }
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [
    DisplayName("Identifier"),
    BrowsableAttribute(true),
    DescriptionAttribute("Numeric identifier of the Parameter"),
    CategoryAttribute("Parameter"),
    DocumentationAttribute("Identifier", typeof(GetterOfNameAsString))
    ]
    public int? Identifier { get; set; }
    /// <summary>
    /// Gets or sets the type of the data.
    /// </summary>
    /// <value>The type of the data.</value>
    [
    DisplayName("DataType"),
    BrowsableAttribute(true),
    DescriptionAttribute("The type of the data"),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Parameter"),
    DocumentationAttribute("DataType", typeof(GetterOfNameAsString))
    ]
    public XmlQualifiedNameEditor DataType { get; set; }
    /// <summary>
    /// Gets or sets the value rank.
    /// </summary>
    /// <value>The value rank.</value>
    [
    DisplayName("Value Rank"),
    BrowsableAttribute(true),
    DescriptionAttribute("This Attribute indicates whether the Value Attribute of the Parameter is an array and how many dimensions the array has. " +
      "It may have the following values: " +
      "n>1 - the Value is an array with the specified number of dimensions; " +
      "OneDimension (1)- the value is an array with one dimension; " +
      "OneOrMoreDimensions (0) - the value is an array with one or more dimensions. " +
      "Scalar (-1)- the value is not an array; " +
      "Any (-2)- the value can be a scalar or an array with any number of dimensions; " +
      "ScalarOrOneDimension (-3)- the value can be a scalar or a one dimensional array."), CategoryAttribute("Parameter"),
    DocumentationAttribute("ValueRank", typeof(GetterOfNameAsString), "-1/[0]")
    ]
    public Opc.Ua.ModelCompiler.ValueRank ValueRank { get; set; }
    #endregion
  }
  #endregion

  #region class MethodDesign
  internal interface IMethodDesign : IInstanceDesign
  {
    bool? NonExecutable { get; set; }
  }
  /// <summary>
  /// Defines the a Method in the information model.
  /// </summary>
  internal partial class MethodDesign : InstanceDesign<Opc.Ua.ModelCompiler.MethodDesign>, IMethodDesign
  {
    #region public properties
    /// <summary>
    /// Gets or sets a value indicating whether [non executable].
    /// </summary>
    /// <value><c>true</c> if [non executable]; otherwise, <c>false</c>.</value>
    [
    DisplayName("Non Executable"),
    BrowsableAttribute(true),
    DescriptionAttribute("The Executable Attribute indicates if the Method is currently executable " +
      "(“False” means not executable, “True” means executable). The Executable Attribute does not take any user access rights into account, " +
      "i.e. although the Method is executable this may be restricted to a certain user / user group."),
    CategoryAttribute("Method")
    ]
    public bool? NonExecutable { get; set; }
    #endregion
  }
  #endregion

  #region class InstanceDesign
  internal interface IInstanceDesign : INodeDesign
  {
    XmlQualifiedNameEditorWithDefaultValue ReferenceType { get; set; }

    XmlQualifiedNameEditor Declaration { get; set; }

    XmlQualifiedNameEditorWithDefaultValue TypeDefinition { get; set; }

    Opc.Ua.ModelCompiler.ModellingRule? ModellingRule { get; set; }

    uint MinCardinality { get; set; }

    uint MaxCardinality { get; set; }

    bool PreserveDefaultAttributes { get; set; }

    IInstanceDesign DerivePropertyValuesFrom(IInstanceDesign source);

    INodeDescriptor GetINodeDescriptor(InstanceIdentifier uniqueNodeIdentifier, NodeClassesEnum nodeClasses);

  }
  /// <summary>
  /// A base type for all Instance Nodes (Object, Variable, and Method).
  /// </summary>
  /// <typeparam name="T">Class from Opc UA Model Designer</typeparam>
  internal partial class InstanceDesign<T> : NodeDesign<T>, IInstanceDesign
    where T : Opc.Ua.ModelCompiler.InstanceDesign, new()
  {

    #region public properties
    /// <summary>
    /// Gets or sets the type of the reference.
    /// </summary>
    /// <value>The type of the reference.</value>
    [
    DisplayName("Reference Type"),
    BrowsableAttribute(false),
    DescriptionAttribute(
      "If this instance belongs to a source node - it is added to the Children folder - this property contains " +
      "symbolic name of the reference type that must be used to couple it with the parent node. The type must be " +
      "any reference type that is derived from Aggregates. For the Property node the default value is HasProperty type, " +
      "otherwise the default value is HasComponent."),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Instance")
    ]
    public XmlQualifiedNameEditorWithDefaultValue ReferenceType { get; set; }
    /// <summary>
    /// Gets or sets the declaration.
    /// </summary>
    /// <value>The declaration.</value>
    [
    DisplayName("Declaration"),
    BrowsableAttribute(false),
    DescriptionAttribute("The Declaration"),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Instance")
    ]
    public XmlQualifiedNameEditor Declaration { get; set; }
    /// <summary>
    /// Gets or sets the type definition.
    /// </summary>
    /// <value>The type definition.</value>
    [
     DisplayName("Type Definition"),
     BrowsableAttribute(true),
     DescriptionAttribute("The type of this instance pointed out by the HasTypeDefinition reference."),
     TypeConverterAttribute(typeof(ExpandableObjectConverter)),
     CategoryAttribute("Instance"),
     DocumentationAttribute("TypeDefinition", typeof(GetterOfNameAsString))
     ]
    public XmlQualifiedNameEditorWithDefaultValue TypeDefinition { get; set; }
    /// <summary>
    /// Gets or sets the modelling rule.
    /// </summary>
    /// <value>The modelling rule.</value>
    [
    DisplayName("Modelling Rule"),
    BrowsableAttribute(true),
    DescriptionAttribute(
      "Dependent on the value of this properties specified for the components of a type they " +
      "are used to create appropriate instances while the parent type is instantiated in the address space. " +
      "The default value is Mandatory. In this case the component is always created with the values of the " +
      "attributes derived from the inheritance chain. If the value is None it indicates that this node only " +
      "belongs to the type and is not used to create an instance while the parent type is instantiated. " +
      "See help documentation to learn more about other valid values. If the node is not a type component the " +
      "value of this property is ignored. "),
    CategoryAttribute("Instance"),
    DocumentationAttribute("ModellingRule", typeof(StringGetter), "Mandatory")
    ]
    public Opc.Ua.ModelCompiler.ModellingRule? ModellingRule { get; set; }
    /// <summary>
    /// Gets or sets the min cardinality.
    /// </summary>
    /// <value>The min cardinality.</value>
    [
    DisplayName("Min Cardinality"),
    BrowsableAttribute(true),
    DescriptionAttribute("This  the component  indicates the minimum number of possibly existing instances of this element. " +
      "If the element has minimal cardinality greater than 0, it is possible to check that it exists in the instantiated nodes."),
    CategoryAttribute("Instance"),
    DocumentationAttribute("MinCardinality", typeof(GetterOfNameAsString))
    ]
    public uint MinCardinality { get; set; }
    /// <summary>
    /// Gets or sets the max cardinality.
    /// </summary>
    /// <value>The max cardinality.</value>
    [
    DisplayName("Max Cardinality"),
    DescriptionAttribute("This attribute indicates the maximum number of possibly existing instances of this element."),
    CategoryAttribute("Instance"),
    DocumentationAttribute("MaxCardinality", typeof(GetterOfNameAsString))
    ]
    public uint MaxCardinality { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether [preserve default attributes].
    /// </summary>
    /// <value>
    /// 	<c>true</c> if [preserve default attributes]; otherwise, <c>false</c>.
    /// </value>
    [
    DisplayName("Preserve Default Attributes"),
    DescriptionAttribute("The value indicating whether to preserve default attributes."),
    CategoryAttribute("Instance")
    ]
    public bool PreserveDefaultAttributes { get; set; }
    #endregion

  }
  #endregion

  #region class NodeDesign
  public interface INodeDesign
  {
    string BrowseName { get; set; }
    LocalizedText DisplayName { get; set; }

    LocalizedText Description { get; set; }

    XmlQualifiedNameEditor SymbolicName { get; set; }

    XmlQualifiedNameEditor SymbolicId { get; set; }
    bool IsDeclaration { get; set; }

    uint NumericId { get; set; }

    bool NumericIdSpecified { get; set; }

    string StringId { get; set; }

    uint WriteAccess { get; set; }

  }
  /// <summary>
  /// Base class for all based on the BaseNode 
  /// </summary>
  /// <typeparam name="T">Class from Opc UA Model Designer</typeparam>
  internal abstract partial class NodeDesign<T> : Design<T>, INodeDesign
    where T : Opc.Ua.ModelCompiler.NodeDesign, new()
  {
    #region public properties
    /// <summary>
    /// Gets or sets the name of the browse.The BrowseName is the name used in the information model. 
    ///  The validator will create the BrowseName automatically from the SymbolicName.
    ///  The BrowseName is qualified by the namespace used for the SymbolicName.
    /// </summary>
    /// <value>The name of the browse.</value>
    [
    DisplayName("Browse Name"),
    BrowsableAttribute(true),
    DescriptionAttribute("The BrowseName is the name used in the information model. " +
      "The validator will create the BrowseName automatically from the SymbolicName. " +
      "The BrowseName is qualified by the namespace used for the SymbolicName."),
    CategoryAttribute("Node"),
    DocumentationAttribute("BrowseName")
    ]
    public string BrowseName { get; set; }
    /// <summary>
    /// Gets or sets the display name.
    /// </summary>
    /// <value>The display name.The DisplayName is a LocalizedText. 
    /// Each server shall provide the DisplayName identical to the BrowseName of the Node for the LocaleId "en". 
    /// Whether the server provides translated names for other LocaleIds is vendor specific.</value>
    [
    DisplayName("DisplayName"),
    BrowsableAttribute(true),
    DescriptionAttribute(" The DisplayName human readable name for the Node. " +
      "This element includes an optional key that can be used to look up the display name for other " +
      "locales in a resource DB. The validator automatically creates the DisplayName from the BrowseName."),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Node")
    ]
    public LocalizedText DisplayName { get; set; }
    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>The description. Optionally a vendor specific description is provided: The Description value of the Description attribute for the Node. 
    /// This element includes an optional key that can be used to look up the Description for other 
    /// locales in a resource DB. The validator automatically creates a generic Description from the 
    /// BrowseName and NodeClass. </value>
    [
    DisplayName("Description"),
    BrowsableAttribute(true),
    DescriptionAttribute("Optionally a vendor specific description is provided: The Description value of the Description attribute for the Node. " +
      "This element includes an optional key that can be used to look up the Description for other " +
      "locales in a resource DB. The validator automatically creates a generic Description from the " +
      "BrowseName and NodeClass. "),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Node"),
    DocumentationAttribute("Description")
    ]
    public LocalizedText Description { get; set; }
    /// <summary>
    /// Gets or sets the name of the symbolic.
    /// </summary>
    /// <value>The name of the symbolic.</value>
    [
    DisplayName("SymbolicName"),
    BrowsableAttribute(true),
    DescriptionAttribute("The SymbolicName identifies the Node within the ModelDesign or within the " +
      "containing Node. The SymbolicName should always be specified. It is used to create " +
      "the BrowseName and SymbolicId if they are not specified."),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Node"),
    DocumentationAttribute("SymbolicName", typeof(GetterOfNameAsString))
    ]
    public XmlQualifiedNameEditor SymbolicName { get; set; }
    /// <summary>
    /// Gets or sets the symbolic id.
    /// </summary>
    /// <value>The symbolic id.</value>
    [
    DisplayName("SymbolicId"),
    BrowsableAttribute(false),
    DescriptionAttribute("The SymbolicId is a globally unique identifier for the Node. The validator will create " +
      "the SymbolicId automatically from the SymbolicName if it is not specified."),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Node")
    ]
    public XmlQualifiedNameEditor SymbolicId { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether this instance is declaration.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is declaration; otherwise, <c>false</c>.
    /// </value>
    [
    DisplayName("IsDeclaration"),
    BrowsableAttribute(true),
    DescriptionAttribute("The IsDeclaration flag indicates that the Node is defined elsewhere and no code will be generated. " +
      "Nodes that are declarations do not need to be completely defined. They only need to have the information " +
      "required to generate code for nodes that reference it (e.g. the BaseType)."),
    CategoryAttribute("Node")
    ]
    public bool IsDeclaration { get; set; }
    /// <summary>
    /// Gets or sets the numeric id.
    /// </summary>
    /// <value>The numeric id.</value>
    [
    DisplayName("NumericId"),
    BrowsableAttribute(false),
    DescriptionAttribute("The NumericId specifies the unique numeric id for the Node. " +
      "It is filled in automatically by reading a CSV file containing the SymbolicIds and an associated UInt32. " +
      "The validator will automatically assign a unique id if no CSV input is provided." +
      "The NumericId or StringId are combined with the Namespace used for the SymbolicId to create the " +
      "well known UA NodeId for the Node. The generator will create programmatic constants that can be " +
      "used to reference the Node in code."),
    CategoryAttribute("Node")
    ]
    public uint NumericId { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether [numeric id specified].
    /// </summary>
    /// <value><c>true</c> if [numeric id specified]; otherwise, <c>false</c>.</value>
    [
    DisplayName("NumericIdSpecified"),
    BrowsableAttribute(false),
    DescriptionAttribute("Numeric Identifier Specified"),
    CategoryAttribute("Node")
    ]
    public bool NumericIdSpecified { get; set; }
    /// <summary>
    /// Gets or sets the string id.
    /// </summary>
    /// <value>The string id.</value>
    [
    DisplayName("StringId"),
    BrowsableAttribute(true),
    DescriptionAttribute(" The StringId is an alternate unique identfier for the node. " +
      "It is used instead of the NumericId if it is specified in the CSV input file."),
    CategoryAttribute("Node")
    ]
    public string StringId { get; set; }
    /// <summary>
    /// Gets or sets the write access.
    /// </summary>
    /// <value>The write access.Optionally the WriteMask Attribute can be provided. 
    /// If the WriteMask Attribute is provided, it shall set all Attributes to 
    /// not writeable that are not said to be vendor-specific. 
    /// For example, the Description Attribute may be set to writeable 
    /// since a Server may provide a server-specific description for the Node. 
    /// The NodeId shall not be writeable, because it is defined for each Node 
    /// in this specification. </value>
    [
    DisplayName("WriteAccess"),
    BrowsableAttribute(true),
    DescriptionAttribute("The bit mask which indicates which attributes are writable."
      + "Optionally the WriteMask Attribute can be provided. If the WriteMask Attribute is provided, " +
      "it shall set all Attributes to not writable that are not said to be vendor-specific. For example, " +
      "the Description Attribute may be set to writable since a Server may provide a " +
      "server-specific description for the Node. The NodeId shall not be writable, " +
      "because it is defined for each Node in this specification. "),
    CategoryAttribute("Node")
    ]
    public uint WriteAccess { get; set; }
    /// <summary>
    /// Gets or sets the part no.
    /// </summary>
    /// <value>
    /// The part no.
    /// </value>
    [
    DisplayName("PartNo"),
    BrowsableAttribute(true),
    DescriptionAttribute("The OPC UA specification part that defines the node."),
    CategoryAttribute("Node")
    ]
    public uint PartNo { get; set; }
    #endregion
  }//NodeDesign 
  #endregion

  #region class TypeDesign
  /// <summary>
  /// A base type for all Type Nodes (ObjectType, VariableType, DataType and ReferenceType).
  /// </summary>
  /// <typeparam name="T">Type of the node from the Opc.Ua.ModelCompiler namespace, 
  /// must inherit <see cref="Opc.Ua.ModelCompiler.TypeDesign"/></typeparam>
  internal partial class TypeDesign<T> : NodeDesign<T>
    where T : Opc.Ua.ModelCompiler.TypeDesign, new()
  {
    #region public properties
    /// <summary>
    /// Gets or sets the name of the class.This is the name for the instance of the type. If not specified the validator 
    /// creates it by removing the 'Type' suffix from the SymbolicName for the Node. 
    /// </summary>
    /// <value>The name of the class.</value>
    [
    DisplayName("Class Name"),
    BrowsableAttribute(true),
    DescriptionAttribute("This is the name for the instance of the type. If not specified the validator " +
      "creates it by removing the 'Type' suffix from the SymbolicName for the Node. "),
    CategoryAttribute("Type")
    ]
    public string ClassName { get; set; }
    /// <summary>
    /// Gets or sets the type of the base.The SymbolicId for the BaseType.
    /// </summary>
    /// <value>The type of the base.</value>
    [
    DisplayName("Base Type"),
    BrowsableAttribute(true),
    DescriptionAttribute("The name of the base type pointed out by the HasSubtype reference. The semantic of" +
                           " the HasSubtype type is to express a subtype relationship of types."),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Type")
    ]
    public XmlQualifiedNameEditorWithDefaultValue BaseType { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether this instance is abstract.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is abstract; otherwise, <c>false</c>.
    /// </value>
    [
    DisplayName("Is Abstract"),
    BrowsableAttribute(true),
    DescriptionAttribute("Indicates whether this type is abstract."),
    CategoryAttribute("Type")
    ]
    public bool IsAbstract { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether to supress class generation for the type..
    /// </summary>
    /// <value><c>true</c> if supress class generation; otherwise, <c>false</c>.</value>
    [
    DisplayName("No Class Generation"),
    BrowsableAttribute(true),
    DescriptionAttribute("Indicates whether to supress class generation for the type."),
    CategoryAttribute("Type")
    ]
    public bool NoClassGeneration { get; set; }
    #endregion
  }
  #endregion

  #region class ReferenceTypeDesign
  /// <summary>
  /// ReferenceType define typed references between Nodes.
  /// </summary>
  internal partial class ReferenceTypeDesign : TypeDesign<Opc.Ua.ModelCompiler.ReferenceTypeDesign>
  {
    #region public properties
    /// <summary>
    /// Gets or sets the name of the inverse.
    /// </summary>
    /// <value>The name of the inverse.</value>
    [
    DisplayName("Inverse Name"),
    BrowsableAttribute(true),
    DescriptionAttribute("The inverse name of the Reference, i.e. the meaning of the ReferenceType as seen from the TargetNode."),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("ReferenceType")
    ]
    public LocalizedText InverseName { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="ReferenceTypeDesign"/> is symmetric.
    /// </summary>
    /// <value><c>true</c> if symmetric; otherwise, <c>false</c>.</value>
    [
    DisplayName("Symmetric"),
    BrowsableAttribute(true),
    DescriptionAttribute("A boolean Attribute with the following values: " +
"TRUE the meaning of the ReferenceType is the same as seen from both the SourceNode and the TargetNode; " +
"FALSE the meaning of the ReferenceType as seen from the TargetNode is the inverse of that as seen from the SourceNode."),
    CategoryAttribute("ReferenceType")
    ]
    public bool? Symmetric { get; set; }
    #endregion
  }
  #endregion

  #region class DataTypeDesign
  /// <summary>
  /// DataTypes define structure of a Value for Variables in the information model.
  /// </summary>
  internal partial class DataTypeDesign : TypeDesign<Opc.Ua.ModelCompiler.DataTypeDesign>
  {
    #region public properties
    /// <summary>
    /// Gets or sets a value indicating whether no arrays are allowed.
    /// </summary>
    /// <value><c>true</c> if [no arrays allowed]; otherwise, <c>false</c>.</value>
    [
    DisplayName("No Arrays Allowed"),
    BrowsableAttribute(true),
    DescriptionAttribute("A value indicating whether no arrays are allowed."),
    CategoryAttribute("DataType")
    ]
    public bool NoArraysAllowed { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether [not in address space].
    /// </summary>
    /// <value><c>true</c> if [not in address space]; otherwise, <c>false</c>.</value>
    [
    DisplayName("Not In AddressSpace"),
    BrowsableAttribute(true),
    DescriptionAttribute("A value indicating whether node is not in Address Space."),
    CategoryAttribute("DataType")
    ]
    public bool NotInAddressSpace { get; set; }
    #endregion
  }
  #endregion

  #region class EncodingDesign
  /// <summary>
  /// Defines an Object which is a Data Type Encoding for a DataType.
  /// </summary>
  internal partial class EncodingDesign : ObjectDesign<Opc.Ua.ModelCompiler.EncodingDesign>
  {
  }
  #endregion

  #region class ObjectDesign
  internal interface IObjectDesign : IInstanceDesign
  {
    bool? SupportsEvents { get; set; }
  }
  /// <summary>
  /// Defines the structure of an Object in the information model.
  /// </summary>
  /// <typeparam name="T">Class from Opc UA Model Designer</typeparam>
  internal partial class ObjectDesign<T> : InstanceDesign<T>, IObjectDesign
    where T : Opc.Ua.ModelCompiler.ObjectDesign, new()
  {
    #region public properties
    /// <summary>
    /// Gets or sets a value indicating whether it supports events.
    /// </summary>
    /// <value><c>true</c> if [supports events]; otherwise, <c>false</c>.</value>
    [
    DisplayName("Supports Events"),
    BrowsableAttribute(true),
    DescriptionAttribute("The value indicating whether the Object class node supports events"),
    CategoryAttribute("Object")
    ]
    public bool? SupportsEvents { get; set; }
    #endregion
  }
  #endregion

  #region class VariableTypeDesign
  /// <summary>
  /// VariableTypes define structure of a Variable in the information model.
  /// </summary>
  internal partial class VariableTypeDesign : TypeDesign<Opc.Ua.ModelCompiler.VariableTypeDesign>
  {
    #region public properties
    /// <summary>
    /// Gets or sets the default value.
    /// </summary>
    /// <value>The default value.</value>
    [
    DisplayName("Default Value"),
    BrowsableAttribute(true),
    ReadOnly(true),
    DescriptionAttribute("The default value"),
    CategoryAttribute("VariableType")
    ]
    public System.Xml.XmlElement DefaultValue { get; set; }
    /// <summary>
    /// Gets or sets the type of the data.
    /// </summary>
    /// <value>The type of the data.</value>
    [
    DisplayName("Data Type"),
    BrowsableAttribute(true),
    DescriptionAttribute("The type of the data"),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("VariableType"),
    DocumentationAttribute("DataType", typeof(GetterOfNameAsString))
    ]
    public XmlQualifiedNameEditor DataType { get; set; }
    /// <summary>
    /// Gets or sets the value rank.
    /// </summary>
    /// <value>The value rank.</value>
    [
    DisplayName("Value Rank"),
    BrowsableAttribute(true),
    DescriptionAttribute("This Attribute indicates whether the Value Attribute of the VariableType is an array and how many dimensions the array has. " +
      "It may have the following values: " +
      "n>1 - the Value is an array with the specified number of dimensions; " +
      "OneDimension (1)- the value is an array with one dimension; " +
      "OneOrMoreDimensions (0) - the value is an array with one or more dimensions. " +
      "Scalar (-1)- the value is not an array; " +
      "Any (-2)- the value can be a scalar or an array with any number of dimensions; " +
      "ScalarOrOneDimension (-3)- the value can be a scalar or a one dimensional array."), CategoryAttribute("VariableType")
    ]
    public Opc.Ua.ModelCompiler.ValueRank? ValueRank { get; set; }
    /// <summary>
    /// Gets or sets the array dimensions.
    /// </summary>
    /// <value>The array dimensions.</value>
    [
    DisplayName("Array Dimensions"),
    BrowsableAttribute(true),
    DescriptionAttribute("If the Value Rank does not identify an array of a specific dimension (i.e. ValueRank <= 0)" +
      "the Array Dimensions attribute can either be set to null or the attribute is missing. This behaviour is vendor-specific." +
      "If the Value Rank attribute specifies an array of a specific dimension (i.e. ValueRank > 0) then the Array Dimensions attribute" +
      "shall be specified in the table defining the Variable."),
    CategoryAttribute("VariableType")
    ]
    public string ArrayDimensions { get; set; }
    /// <summary>
    /// Gets or sets the access level.
    /// </summary>
    /// <value>The access level.</value>
    [
    DisplayName("Access Level"),
    BrowsableAttribute(true),
    DescriptionAttribute("This property defines a value of the AccessLevel attribute of the VariableType node class. " +
      "The access level for variables used for type definitions is vendor-specific, for all other variables defined " +
      "in the specification , the access level shall allow a current read; other settings are vendor specific."),
    CategoryAttribute("VariableType")
    ]
    public Opc.Ua.ModelCompiler.AccessLevel? AccessLevel { get; set; }
    /// <summary>
    /// Gets or sets the minimum sampling interval.
    /// </summary>
    /// <value>The minimum sampling interval.</value>
    [
    DisplayName("Minimum Sampling Interval"),
    BrowsableAttribute(true),
    DescriptionAttribute("Optionally, a vendor-specific minimum sampling interval is provided. It indicates how “current” the Value of " +
      "the Variable will be kept. It specifies (in milliseconds) how fast the server " +
      "can reasonably sample the value for changes (see Part 4 for a detailed " +
      "description of sampling interval). A MinimumSamplingInterval of 0 indicates that the server is to monitor the " +
      "item continuously. A MinimumSamplingInterval of -1 means indeterminate."), CategoryAttribute("VariableType")
    ]
    public int? MinimumSamplingInterval { get; set; }
    [
    DisplayName("Historizing"),
    BrowsableAttribute(true),
    DescriptionAttribute("The Historizing Attribute indicates whether the Server is actively collecting " +
      "data for the history of the Variable. This differs from the AccessLevel " +
      "Attribute which identifies if the Variable has any historical data. A value of " +
      "TRUE indicates that the Server is actively collecting data. A value of FALSE " +
      "indicates the Server is not actively collecting data."),
    CategoryAttribute("VariableType")
    ]
    public bool? Historizing { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether [exposes its children].
    /// </summary>
    /// <value><c>true</c> if [exposes its children]; otherwise, <c>false</c>.</value>
    [
    DisplayName("Exposes Its Children"),
    BrowsableAttribute(true),
    DescriptionAttribute("The value indicating whether the children should be exposed."),
    CategoryAttribute("VariableType")
    ]
    public bool ExposesItsChildren { get; set; }
    #endregion
  }
  #endregion

  #region class ObjectTypeDesign
  /// <summary>
  /// ObjectTypes define structure of an Object in the information model.
  /// </summary>
  /// <typeparam name="T">Class from Opc UA Model Designer</typeparam>
  internal partial class ObjectTypeDesign<T> : TypeDesign<T>
    where T : Opc.Ua.ModelCompiler.ObjectTypeDesign, new()
  {
    /// <summary>
    /// Gets or sets a value indicating whether the Object class node supports events.
    /// </summary>
    /// <value><c>true</c> if the Object class node supports events; otherwise, <c>false</c>.</value>
    [
    DisplayName("Supports Events"),
    BrowsableAttribute(true),
    DescriptionAttribute("The value indicating whether the instance of this ObjectType class node supports events"),
    CategoryAttribute("ObjectType")
    ]
    public bool? SupportsEvents { get; set; }
  }
  #endregion

  #region class ViewDesign
  /// <summary>
  /// ViewDesign define structure of an View in the information model.
  /// </summary>
  internal partial class ViewDesign : NodeDesign<Opc.Ua.ModelCompiler.ViewDesign>
  {
    #region public properties
    /// <summary>
    /// Gets or sets a value indicating whether this Object node class supports events.
    /// </summary>
    /// <value><c>true</c> if this Object node class supports events; otherwise, <c>false</c>.</value>
    [
    DisplayName("Supports Events"),
    BrowsableAttribute(true),
    DescriptionAttribute("A value indicating whether this View node class supports events."),
    CategoryAttribute("View")
    ]
    public bool SupportsEvents { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether [contains no loops].
    /// </summary>
    /// <value><c>true</c> if [contains no loops]; otherwise, <c>false</c>.</value>
    [
    DisplayName("Contains No Loops"),
    BrowsableAttribute(true),
    DescriptionAttribute("If set to true this Attribute indicates that following References in the context " +
    "of the View contains no loops, i.e. starting from a Node “A” contained in the " +
    "View and following the forward References in the context of the View Node" +
    "“A” will not be reached again. It does not specify that there is only one path" +
    "starting from the View Node to reach a Node contained in the View." +
    "If set to “false” this Attribute indicates that following References in the" +
    "context of the View may lead to loops."),
    CategoryAttribute("View")
    ]
    public bool ContainsNoLoops { get; set; }
    #endregion properties
  }
  #endregion

  #region class VariableDesign
  internal interface IVariableDesign : IInstanceDesign
  {
    VariableValueEditor DefaultValue { get; set; }
    XmlQualifiedNameEditor DataType { get; set; }
    Opc.Ua.ModelCompiler.ValueRank? ValueRank { get; set; }
    string ArrayDimensions { get; set; }
    Opc.Ua.ModelCompiler.AccessLevel? AccessLevel { get; set; }
    int? MinimumSamplingInterval { get; set; }
    bool? Historizing { get; set; }
  }
  /// <summary>
  /// Defines the structure of a Variable in the information model.
  /// </summary>
  /// <typeparam name="T">Class from Opc UA Model Designer</typeparam>
  internal partial class VariableDesign<T> : InstanceDesign<T>, IVariableDesign
    where T : Opc.Ua.ModelCompiler.VariableDesign, new()
  {
    #region public properties
    /// <summary>
    /// Gets or sets the default value.
    /// </summary>
    /// <value>The default value.</value>
    [
    DisplayName("Default Value"),
    BrowsableAttribute(true),
    DescriptionAttribute("The default value of the variable"),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Variable"),
    NotifyParentPropertyAttribute(true)
    ]
    public VariableValueEditor DefaultValue { get; set; }
    /// <summary>
    /// Gets or sets the type of the data.
    /// </summary>
    /// <value>The type of the data.</value>
    [
    DisplayName("Data Type"),
    BrowsableAttribute(true),
    DescriptionAttribute("The type of the data"),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Variable"),
    DocumentationAttribute("DataType", typeof(GetterOfNameAsString))
    ]
    public XmlQualifiedNameEditor DataType { get; set; }
    /// <summary>
    /// Gets or sets the value rank.
    /// </summary>
    /// <value>The value rank.</value>
    [
    DisplayName("Value Rank"),
    BrowsableAttribute(true),
    DescriptionAttribute("This Attribute indicates whether the Value Attribute of the Variable is an array and how many dimensions the array has. " +
      "It may have the following values: " +
      "n>1 - the Value is an array with the specified number of dimensions; " +
      "OneDimension (1)- the value is an array with one dimension; " +
      "OneOrMoreDimensions (0) - the value is an array with one or more dimensions. " +
      "Scalar (-1)- the value is not an array; " +
      "Any (-2)- the value can be a scalar or an array with any number of dimensions; " +
      "ScalarOrOneDimension (-3)- the value can be a scalar or a one dimensional array."),
    CategoryAttribute("Variable")
    ]
    public Opc.Ua.ModelCompiler.ValueRank? ValueRank { get; set; }
    /// <summary>
    /// Gets or sets the array dimensions.
    /// </summary>
    /// <value>The array dimensions.</value>
    [
    DisplayName("Array Dimensions"),
    BrowsableAttribute(true),
    DescriptionAttribute("If the Value Rank does not identify an array of a specific dimension (i.e. ValueRank <= 0)" +
      "the Array Dimensions attribute can either be set to null or the attribute is missing. This behaviour is vendor-specific." +
      "If the Value Rank attribute specifies an array of a specific dimension (i.e. ValueRank > 0) then the Array Dimensions attribute" +
      "shall be specified in the table defining the Variable."),
    CategoryAttribute("Variable")
    ]
    public string ArrayDimensions { get; set; }
    /// <summary>
    /// Gets or sets the access level.
    /// </summary>
    /// <value>The access level.</value>
    [
    DisplayName("Access Level"),
    BrowsableAttribute(true),
    DescriptionAttribute("This property defines a value of the AccessLevel attribute of the VariableType node class. " +
      "The access level for variables used for type definitions is vendor-specific, for all other variables defined " +
      "in the specification , the access level shall allow a current read; other settings are vendor specific."),
    CategoryAttribute("Variable")
    ]
    public Opc.Ua.ModelCompiler.AccessLevel? AccessLevel { get; set; }
    /// <summary>
    /// Gets or sets the minimum sampling interval.
    /// </summary>
    /// <value>The minimum sampling interval.</value>
    [
    DisplayName("Minimum Sampling Interval"),
    BrowsableAttribute(true),
    DescriptionAttribute("Optionally, a vendor-specific minimum sampling interval is provided. It indicates how “current” the Value of " +
      "the Variable will be kept. It specifies (in milliseconds) how fast the server " +
      "can reasonably sample the value for changes (see Part 4 for a detailed " +
      "description of sampling interval). A MinimumSamplingInterval of 0 indicates that the server is to monitor the " +
      "item continuously. A MinimumSamplingInterval of -1 means indeterminate."),
    CategoryAttribute("Variable")
    ]
    public int? MinimumSamplingInterval { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="VariableDesign&lt;T&gt;"/> is historizing.
    /// </summary>
    /// <value><c>true</c> if historizing; otherwise, <c>false</c>.</value>
    [
    DisplayName("Historizing"),
    BrowsableAttribute(true),
    DescriptionAttribute("The Historizing Attribute indicates whether the Server is actively collecting " +
      "data for the history of the Variable. This differs from the AccessLevel " +
      "Attribute which identifies if the Variable has any historical data. A value of " +
      "TRUE indicates that the Server is actively collecting data. A value of FALSE " +
      "indicates the Server is not actively collecting data."),
    CategoryAttribute("Variable")
    ]
    public bool? Historizing { get; set; }
    #endregion
  }
  #endregion

  #region class DictionaryDesign
  internal interface IDictionaryDesign : IVariableDesign
  {
    XmlQualifiedNameEditor EncodingName { get; set; }
  }
  /// <summary>
  /// Defines an Variable which is a DataTypeDictionary.
  /// </summary>
  internal partial class DictionaryDesign : VariableDesign<Opc.Ua.ModelCompiler.DictionaryDesign>, IDictionaryDesign
  {
    #region public properties
    /// <summary>
    /// Gets or sets the name of the encoding.
    /// </summary>
    /// <value>The name of the encoding.</value>
    [
    DisplayName("Encoding Name"),
    BrowsableAttribute(true),
    DescriptionAttribute("the name of the encoding."),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    CategoryAttribute("Dictionary")
    ]
    public XmlQualifiedNameEditor EncodingName { get; set; }
    #endregion
  }
  #endregion

  #region class PropertyDesign
  /// <summary>
  /// Defines a Variable which is a Property for a Node.
  /// </summary>
  internal partial class PropertyDesign : VariableDesign<Opc.Ua.ModelCompiler.PropertyDesign>
  {
  }
  #endregion
}