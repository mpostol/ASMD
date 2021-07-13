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
      string builtInTypesPath = Path.Combine(Environment.CurrentDirectory, @"BuiltInTypes\XML\BuiltInTypes.xsd");
      Assert.IsTrue(File.Exists(builtInTypesPath));
      XmlReaderSettings _settings = new XmlReaderSettings();
      string _ns = "http://opcfoundation.org/UA/TypeDictionary/";
      _settings.Schemas.Add(_ns, builtInTypesPath);
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
            typeNamesList.Add(_node.Attributes["Name"].InnerText);
          Assert.AreEqual<int>(25, typeNamesList.Count);
        }
        BuiltInTypesEnumTemplate generator = new BuiltInTypesEnumTemplate(typeNamesList);
        string pageContent = generator.TransformText();
        File.WriteAllText("BuiltInType.cs", pageContent);
      }
      //Assert.Fail("uncomment to prevent file BuiltInType.cs deletion");
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
