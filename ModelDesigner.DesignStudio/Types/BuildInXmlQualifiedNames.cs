//__________________________________________________________________________________________________
//
//  Copyright (C) 2022, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.Xml;
using UAOOI.SemanticData.InformationModelFactory.UAConstants;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Types
{
  /// <summary>
  /// Name of the building OPC UA Information Model nodes
  /// </summary>
  internal static class BuildInXmlQualifiedNames
  {
    #region private

    private const string rootFolder = "RootFolder"; // The browse name is different then the
    private static readonly string uaNamespace = "http://opcfoundation.org/UA/";
    private static readonly string modelingRulePrefixString = "ModellingRule_";

    #endregion private

    #region public

    internal static XmlQualifiedName HasComponent => new XmlQualifiedName(BrowseNames.HasComponent, uaNamespace);
    internal static XmlQualifiedName HasSubtype => new XmlQualifiedName(BrowseNames.HasSubtype, uaNamespace);
    internal static XmlQualifiedName HasProperty => new XmlQualifiedName(BrowseNames.HasProperty, uaNamespace);
    internal static XmlQualifiedName BaseObjectType => new XmlQualifiedName(BrowseNames.BaseObjectType, uaNamespace);
    internal static XmlQualifiedName BaseVariableType => new XmlQualifiedName(BrowseNames.BaseVariableType, uaNamespace);
    internal static XmlQualifiedName BaseReferenceType => new XmlQualifiedName(BrowseNames.References, uaNamespace);
    internal static XmlQualifiedName BaseDataVariableType => new XmlQualifiedName(BrowseNames.BaseDataVariableType, uaNamespace);
    internal static XmlQualifiedName BaseDataType => new XmlQualifiedName(BrowseNames.BaseDataType, uaNamespace);
    internal static XmlQualifiedName PropertyType => new XmlQualifiedName(BrowseNames.PropertyType, uaNamespace);
    internal static XmlQualifiedName RootFolder => new XmlQualifiedName(rootFolder, uaNamespace);
    internal static XmlQualifiedName HasTypeDefinition => new XmlQualifiedName(BrowseNames.HasTypeDefinition, uaNamespace);

    //internal static XmlQualifiedName HasModelParent { get { return new XmlQualifiedName(Opc.Ua.BrowseNames.HasModelParent, uaNamespace); } }
    internal static XmlQualifiedName HasModelingRule => new XmlQualifiedName(BrowseNames.HasModellingRule, uaNamespace);

    internal static XmlQualifiedName ModelingRuleSymbolicName(OpcUaModelCompiler.ModellingRule modelingRule)
    {
      return new XmlQualifiedName(modelingRulePrefixString + modelingRule.ToString(), uaNamespace);
    }

    #endregion public
  }
}