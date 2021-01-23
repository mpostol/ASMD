//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Class OpcUaModelCompilerModelDesigner - helper class providing common functionality against
  /// </summary>
  internal static class OpcUaModelCompilerModelDesigner
  {
    internal static OpcUaModelCompiler.ModelDesign GetDefault()
    {
      return new OpcUaModelCompiler.ModelDesign()
      {
        TargetNamespace = Settings.Default.TargetNamespace,
        Namespaces = new OpcUaModelCompiler.Namespace[]
        {
          new  OpcUaModelCompiler.Namespace()
               {
                 Name = Settings.Default.TargetNamespaceXmlPrefix,
                 Value = Settings.Default.TargetNamespace,
                 XmlPrefix = Settings.Default.TargetNamespaceXmlPrefix,
               },
          new OpcUaModelCompiler.Namespace()
               {
                 Name = Settings.Default.XmlUAName,
                 Value = Settings.Default.XmlUANamespaceURI,
                 XmlNamespace = Settings.Default.XmlUATypesNamespace,
                 Prefix = Settings.Default.XmlUAPrefix
               }
        }
      };
    }
  }
}