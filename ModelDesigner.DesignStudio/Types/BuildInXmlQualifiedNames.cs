//<summary>
//  Title   : Browse View Tree View
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

using System.Xml;

namespace CAS.UA.Model.Designer.Types
{
  /// <summary>
  /// Name of the buildin OPC UA Information Model nodes 
  /// </summary>
  static class BuildInXmlQualifiedNames
  {
    //#region private
    //private const string hasComponentString = "HasComponent";
    //private const string hasSubtypeString = "HasSubtype";
    //private const string hasPropertyString = "HasProperty";
    //private const string baseObjectTypeString = "BaseObjectType";
    //private const string baseVariableTypeString = "BaseVariableType";
    //private const string baseReferenceTypeString = "BaseReferenceType";
    //private const string baseDataVariableType = "BaseDataVariableType";
    //private const string baseDataType = "BaseDataType";
    //private const string propertyType = "PropertyType";
    private const string rootFolder = "RootFolder"; // The browse name is different then the 
    //private const string m_HasTypeDefinition = "HasTypeDefinition";
    //private const string hasModelParentString = "HasModelParent";
    //private const string hasModellingRuleString = "HasModellingRule";
    private static string uaNamespace = "http://opcfoundation.org/UA/";
    private static string modelingRulePrefixString = "ModellingRule_";
    //#endregion

    #region public
    internal static XmlQualifiedName HasComponent { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.HasComponent, uaNamespace); } }
    internal static XmlQualifiedName HasSubtype { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.HasSubtype, uaNamespace); } }
    internal static XmlQualifiedName HasProperty { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.HasProperty, uaNamespace); } }
    internal static XmlQualifiedName BaseObjectType { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.BaseObjectType, uaNamespace); } }
    internal static XmlQualifiedName BaseVariableType { get { return new XmlQualifiedName( Opc.Ua.BrowseNames.BaseVariableType, uaNamespace ); } }
    internal static XmlQualifiedName BaseReferenceType { get { return new XmlQualifiedName( Opc.Ua.BrowseNames.References, uaNamespace ); } }
    internal static XmlQualifiedName BaseDataVariableType { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.BaseDataVariableType, uaNamespace); } }
    internal static XmlQualifiedName BaseDataType { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.BaseDataType, uaNamespace); } }
    internal static XmlQualifiedName PropertyType { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.PropertyType, uaNamespace); } }
    internal static XmlQualifiedName RootFolder { get { return new XmlQualifiedName(rootFolder, uaNamespace); } }
    internal static XmlQualifiedName HasTypeDefinition { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.HasTypeDefinition, uaNamespace); } }
    //internal static XmlQualifiedName HasModelParent { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.HasModelParent, uaNamespace); } }
    internal static XmlQualifiedName HasModelingRule { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.HasModellingRule, uaNamespace); } }
    internal static XmlQualifiedName ModelingRuleSymbolicName( Opc.Ua.ModelCompiler.ModellingRule modelingRule )
    {
      return new XmlQualifiedName( modelingRulePrefixString + modelingRule.ToString(), uaNamespace );
    }
    #endregion
  }
}

