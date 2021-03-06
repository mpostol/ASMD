﻿//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System.Xml;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Types
{
  /// <summary>
  /// Name of the building OPC UA Information Model nodes
  /// </summary>
  internal static class BuildInXmlQualifiedNames
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
    private static readonly string uaNamespace = "http://opcfoundation.org/UA/";

    private static readonly string modelingRulePrefixString = "ModellingRule_";
    //#endregion

    #region public

    internal static XmlQualifiedName HasComponent => new XmlQualifiedName(Opc.Ua.BrowseNames.HasComponent, uaNamespace);
    internal static XmlQualifiedName HasSubtype => new XmlQualifiedName(Opc.Ua.BrowseNames.HasSubtype, uaNamespace);
    internal static XmlQualifiedName HasProperty => new XmlQualifiedName(Opc.Ua.BrowseNames.HasProperty, uaNamespace);
    internal static XmlQualifiedName BaseObjectType => new XmlQualifiedName(Opc.Ua.BrowseNames.BaseObjectType, uaNamespace);
    internal static XmlQualifiedName BaseVariableType => new XmlQualifiedName(Opc.Ua.BrowseNames.BaseVariableType, uaNamespace);
    internal static XmlQualifiedName BaseReferenceType => new XmlQualifiedName(Opc.Ua.BrowseNames.References, uaNamespace);
    internal static XmlQualifiedName BaseDataVariableType => new XmlQualifiedName(Opc.Ua.BrowseNames.BaseDataVariableType, uaNamespace);
    internal static XmlQualifiedName BaseDataType => new XmlQualifiedName(Opc.Ua.BrowseNames.BaseDataType, uaNamespace);
    internal static XmlQualifiedName PropertyType => new XmlQualifiedName(Opc.Ua.BrowseNames.PropertyType, uaNamespace);
    internal static XmlQualifiedName RootFolder => new XmlQualifiedName(rootFolder, uaNamespace);
    internal static XmlQualifiedName HasTypeDefinition => new XmlQualifiedName(Opc.Ua.BrowseNames.HasTypeDefinition, uaNamespace);

    //internal static XmlQualifiedName HasModelParent { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.HasModelParent, uaNamespace); } }
    internal static XmlQualifiedName HasModelingRule => new XmlQualifiedName(Opc.Ua.BrowseNames.HasModellingRule, uaNamespace);

    internal static XmlQualifiedName ModelingRuleSymbolicName(OpcUaModelCompiler.ModellingRule modelingRule)
    {
      return new XmlQualifiedName(modelingRulePrefixString + modelingRule.ToString(), uaNamespace);
    }

    #endregion public
  }
}