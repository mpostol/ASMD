//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid.Editors
{
  [TestClass]
  public class XmlStandardValueEditorUnitTest
  {
    [TestMethod]
    public void ConstructorTestMethod()
    {
      XmlDocument valueDocument = new XmlDocument();
      XmlElement value = valueDocument.CreateElement("uax", OpcUaTypesList.String.ToString(), "http://opcfoundation.org/UA/2008/02/Types.xsd");
      value.InnerText = "TR88.00.02-2015";
      XmlStandardValueEditor instance2Test = new XmlStandardValueEditor(value);
      Assert.IsFalse(string.IsNullOrEmpty(instance2Test.TypeName));
      Assert.AreEqual<string>(OpcUaTypesList.String.ToString(), instance2Test.TypeName);
      Assert.IsFalse(string.IsNullOrEmpty(instance2Test.ToString()));
      Assert.AreEqual<string>($"{OpcUaTypesList.String} : TR88.00.02-2015", instance2Test.ToString());
      XmlElement retValue = instance2Test.XmlElement;
      Assert.IsNotNull(retValue);
      Assert.AreEqual<string>(OpcUaTypesList.String.ToString(), retValue.LocalName);
      Assert.AreEqual<string>("http://opcfoundation.org/UA/2008/02/Types.xsd", retValue.NamespaceURI);
      Assert.AreEqual<string>("uax", retValue.Prefix);
    }

    [TestMethod]
    public void ConstructorNullTest()
    {
      XmlStandardValueEditor instance2Test = new XmlStandardValueEditor(OpcUaTypesList.String.ToString());
      Assert.IsFalse(string.IsNullOrEmpty(instance2Test.TypeName));
      Assert.AreEqual<string>(OpcUaTypesList.String.ToString(), instance2Test.TypeName);
      Assert.IsFalse(string.IsNullOrEmpty(instance2Test.ToString()));
      Assert.AreEqual<string>($"{OpcUaTypesList.String} : <null>", instance2Test.ToString());
      XmlElement retValue = instance2Test.XmlElement;
      Assert.IsNull(retValue);
      instance2Test.Value = "RandomValue";
      retValue = instance2Test.XmlElement;
      Assert.IsNotNull(retValue);
      Assert.AreEqual<string>("String", retValue.LocalName);
      Assert.AreEqual<string>("http://opcfoundation.org/UA/2008/02/Types.xsd", retValue.NamespaceURI);
      Assert.AreEqual<string>("uax", retValue.Prefix);
    }
  }
}