//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace UAOOI.OPCUA.CoreDefinitionsUnitTest.BuiltInTypes
{
  [TestClass]
  [DeploymentItem(@"BuiltInTypes\XML\", @"BuiltInTypes\XML\")]
  public class BuiltInTypesGenerator
  {
    [TestMethod]
    public void BuiltInTypesTest()
    {
      string _xsdPath = Path.Combine(Environment.CurrentDirectory, @"BuiltInTypes\XML\BuiltInTypes.xsd");
      Assert.IsTrue(File.Exists(_xsdPath));
      XmlReaderSettings _settings = new XmlReaderSettings();
      string _ns = "http://opcfoundation.org/UA/TypeDictionary/";
      _settings.Schemas.Add(_ns, _xsdPath);
      _settings.ValidationType = ValidationType.Schema;
      string _path = Path.Combine(Environment.CurrentDirectory, @"BuiltInTypes\XML\BuiltInTypes.xml");
      //XElement purchaseOrder = XElement.Load(_path);
      //purchaseOrder.DescendantNodesAndSelf().Where(x=>x.)
      using (XmlReader _errorsReader = XmlReader.Create(_path, _settings))
      {
        XmlDocument _doc = new XmlDocument();
        _doc.Load(_errorsReader);
        XmlNamespaceManager _nsmgr = new XmlNamespaceManager(_errorsReader.NameTable);
        _nsmgr.AddNamespace("opc", _ns);
        XmlNode _list = _doc.SelectSingleNode("//opc:TypeDictionary", _nsmgr);
        List<string> typeNamesList = new List<string>();
        using (XmlNodeList nodes = _list.SelectNodes("opc:DataType", _nsmgr))
        {
          foreach (XmlNode _node in nodes)
            typeNamesList.Add(_node.Name);
          Assert.AreEqual<int>(25, typeNamesList.Count);
        }
        BuiltInTypesEnumTemplate generator = new BuiltInTypesEnumTemplate(typeNamesList);
        string pageContent = generator.TransformText();
        File.WriteAllText("BuiltInTypes.cs", pageContent);
      }
      Assert.Fail();
    }
    [ClassInitializeAttribute()]
    public static void ClassInitializeAttributeMethod(TestContext context)
    {
      
    }

    [ClassCleanup()]
    public static void ClassCleanupMethod()
    {

    }
  }
}

//namespace UAOOI.SemanticData.BuildingErrorsHandling
//{
//  /// <summary>
//  /// Class BuildError - provides building descriptions of building errors.
//  /// </summary>
//  public partial class BuildError
//  {
//<#
//      EnvDTE.DTE dte = (EnvDTE.DTE)((IServiceProvider)this.Host).GetService(typeof(EnvDTE.DTE));
//    // Open the prototype document.
//    XmlReaderSettings _settings = new XmlReaderSettings();
//    string _ns = "http://commsvr.com/UAOOI/SemanticData/UANodeSetValidation/BuildErrorsCollection.xsd";
//    _settings.Schemas.Add(_ns, _xsdPath);
//      _settings.ValidationType = ValidationType.Schema;
//	  string _path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(dte.ActiveDocument.FullName), @"XML\BuildErrorsCollection.xml");
//    XmlReader _errorsReader = XmlReader.Create(_path, _settings);
//    XmlDocument _doc = new XmlDocument();
//    _doc.Load(_errorsReader);
//	  XmlNamespaceManager _nsmgr = new XmlNamespaceManager(_errorsReader.NameTable);
//    _nsmgr.AddNamespace("ns", _ns);
//      XmlNode _list = _doc.SelectSingleNode("//ns:BuildErrorsCollection/ns:ListOfBuildErrors", _nsmgr);
//      foreach (XmlNode _node in _list.SelectNodes("ns:NamedBuildError", _nsmgr))
//      {
//        string Name = _node.SelectSingleNode("ns:Name", _nsmgr).InnerText;
//    string Focus = _node.SelectSingleNode("ns:Focus", _nsmgr).InnerText;
//    string Identifier = _node.SelectSingleNode("ns:Identifier", _nsmgr).InnerText;
//    string Descriptor = _node.SelectSingleNode("ns:Descriptor", _nsmgr).InnerText;
//#>
//    /// <summary>
//    /// Error: <#=Identifier#>; Focus: <#= Focus #>; <#= Descriptor #>
//    /// </summary>
//    /// <value>An instance of <see cref="BuildError"/> describing the error <#=Identifier#>.</value>
//    public static BuildError<#=Name#> { get { return new BuildError()
//                  { Focus = Focus.<#=Focus#>,
//                    Identifier = "<#=Identifier#>",
//                    Descriptor = "<#=Descriptor #>" };
//} }
//<#
//      }
//#>