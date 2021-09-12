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
    public void CreateValueEditorTest1()
    {
      XmlDocument document = new XmlDocument();
      XmlElement elemnt = document.CreateElement("name", "namespaceUri");
      elemnt.InnerText = "InnerText";
      ValueEditor toTestItem = ValueEditor.CreateValueEditor(elemnt);
      Assert.IsNotNull(toTestItem);
      XmlStandardValueEditor toTestEditor = toTestItem as XmlStandardValueEditor;
      Assert.IsNotNull(toTestEditor);
    }
    [TestMethod]
    public void CreateValueEditorTest2()
    {
      //TODO DefaultValue - implement editor for VariableType #9
      XmlDocument document = new XmlDocument();
      XmlElement elemnt = document.CreateElement(CAS.UA.Common.Types.ExtensionObject.LocalName, "namespaceUri");
      elemnt.InnerText = "InnerText";
      Assert.Inconclusive("ExtensionObject must be created compliant with the specification");
      ValueEditor toTestItem = ValueEditor.CreateValueEditor(elemnt);
      Assert.IsNotNull(toTestItem);
      XmlStandardValueEditor toTestEditor = toTestItem as XmlStandardValueEditor;
      Assert.IsNotNull(toTestEditor);
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