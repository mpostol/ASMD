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
  public class VariableValueEditorUnitTest
  {
    [TestMethod]
    public void VariableValueEditorNullTestMethod()
    {
      VariableValueEditor instance2Test = new VariableValueEditor(null);
      Assert.IsInstanceOfType(instance2Test.Editor, typeof(NotSetValueEditor));
      Assert.IsTrue(instance2Test.IsEmpty());
      Assert.IsFalse(string.IsNullOrEmpty(instance2Test.ToString()));
      Assert.AreEqual<string>("<Not set>", instance2Test.ToString());
      Assert.IsNull(instance2Test.XmlElement);
    }
    [TestMethod]
    public void VariableValueEditorNotNullTestMethod()
    {
      XmlDocument valueDocument = new XmlDocument();
      XmlElement value = valueDocument.CreateElement("uax", "String", "http://opcfoundation.org/UA/2008/02/Types.xsd");
      value.InnerText = "TR88.00.02-2015";
      VariableValueEditor instance2Test = new VariableValueEditor(value);
      Assert.IsInstanceOfType(instance2Test.Editor, typeof(XmlStandardValueEditor));
      Assert.IsFalse(instance2Test.IsEmpty());
      Assert.IsFalse(string.IsNullOrEmpty(instance2Test.ToString()));
      Assert.AreEqual<string>("String : TR88.00.02-2015", instance2Test.ToString());
      XmlElement retValue = instance2Test.XmlElement;
      Assert.IsNotNull(retValue);
      Assert.AreEqual<string>("String", retValue.LocalName);
      Assert.AreEqual<string>("http://opcfoundation.org/UA/2008/02/Types.xsd", retValue.NamespaceURI);
      Assert.AreEqual<string>("uax", retValue.Prefix);
    }
  }
}