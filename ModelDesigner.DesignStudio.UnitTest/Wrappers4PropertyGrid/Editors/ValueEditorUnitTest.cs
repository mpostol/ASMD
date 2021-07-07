//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid.Editors
{
  [TestClass]
  public class ValueEditorUnitTest
  {
    [TestMethod]
    public void ConstructorTest()
    {
      ValueEditorFixture toTestItem = ValueEditorFixture.GetValueEditorFixture("RandomTexte");
      Assert.AreEqual<string>("RandomTexte", toTestItem.TypeName);
    }
    [TestMethod]
    public void XmlStandardValueEditorTest()
    {
      XmlDocument document = new XmlDocument();
      XmlElement elemnt = document.CreateElement("name", "namespaceUri");
      ValueEditor toTestItem = ValueEditor.CreateValueEditor(elemnt);
      Assert.IsNotNull(toTestItem);
      XmlStandardValueEditor toTestEditor = toTestItem as XmlStandardValueEditor;
      Assert.IsNotNull(toTestEditor);
      Assert.AreEqual<string>("name", toTestEditor.TypeName);
      Assert.AreEqual<string>("", toTestEditor.Value);
      Assert.IsNull(toTestEditor.XmlElement);
      toTestEditor.Value = "RandomText";
      Assert.IsNotNull(toTestEditor.XmlElement);
      Assert.IsTrue(toTestEditor.XmlElement.HasChildNodes);
      Assert.AreEqual<string>("RandomText", toTestEditor.XmlElement.InnerText);
      Assert.Inconclusive("NamespaceURI must not be null.");
      Assert.AreEqual<string>("", toTestEditor.XmlElement.NamespaceURI);
      Assert.AreEqual<string>("name", toTestEditor.XmlElement.Name);
    }
    private class ValueEditorFixture : ValueEditor
    {
      internal static ValueEditorFixture GetValueEditorFixture(string typeName)
      {
        return new ValueEditorFixture(typeName);
      }

      internal override XmlElement XmlElement => throw new NotImplementedException();

      protected override string GetValueAsString()
      {
        throw new NotImplementedException();
      }

      private ValueEditorFixture(string typeName) : base(typeName)
      {
      }
    }
  }
}