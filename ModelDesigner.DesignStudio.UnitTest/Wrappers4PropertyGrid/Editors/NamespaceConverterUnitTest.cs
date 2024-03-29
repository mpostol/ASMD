﻿//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.ComponentModel;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid.Editors
{
  [TestClass]
  public class NamespaceConverterUnitTest
  {
    [TestMethod]
    public void NamespaceConverterTest()
    {
      NamespaceConverter instance2Test = new NamespaceConverter();
      //TypeConverter
      Assert.IsTrue(instance2Test.CanConvertFrom(typeof(string)));
      Assert.IsFalse(instance2Test.CanConvertFrom(typeof(int)));
      Assert.AreEqual<string>("7wgpaYi0L3GJeiaWCPOj44A3340DGl6iWSNmOq71q25uCMErk", (string)instance2Test.ConvertFrom("7wgpaYi0L3GJeiaWCPOj44A3340DGl6iWSNmOq71q25uCMErk"));

      Assert.IsTrue(instance2Test.CanConvertTo(typeof(string)));
      Assert.IsFalse(instance2Test.CanConvertTo(typeof(int)));
      Assert.AreEqual<string>("7wgpaYi0L3GJeiaWCPOj44A3340DGl6iWSNmOq71q25uCMErk", (string)instance2Test.ConvertTo("7wgpaYi0L3GJeiaWCPOj44A3340DGl6iWSNmOq71q25uCMErk", typeof(string)));
      Assert.IsTrue(instance2Test.IsValid("7wgpaYi0L3GJeiaWCPOj44A3340DGl6iWSNmOq71q25uCMErk"));
      //NamespaceConverter
      Assert.IsTrue(instance2Test.GetStandardValuesSupported());
      Assert.IsFalse(instance2Test.GetStandardValuesExclusive());
      Assert.ThrowsException<ArgumentNullException>(() => instance2Test.GetStandardValues(null));
    }

    [TestMethod]
    public void GetStandardValuesNullEditor()
    {
      NamespaceConverter instance2Test = new NamespaceConverter();
      Mock<ITypeDescriptorContext> typeDescriptor = new Mock<ITypeDescriptorContext>();
      TypeConverter.StandardValuesCollection standardValues = instance2Test.GetStandardValues(typeDescriptor.Object);
      Assert.IsNotNull(standardValues);
      Assert.AreEqual<int>(0, standardValues.Count);
    }

    [TestMethod]
    public void GetStandardValueContextInstanceTest()
    {
      NamespaceConverter instance2Test = new NamespaceConverter();
      Mock<IXmlQualifiedNameEditorNamespaceProvider> namespacesProviderMock = new Mock<IXmlQualifiedNameEditorNamespaceProvider>();
      namespacesProviderMock.Setup(x => x.GetAvailiableNamespaces()).Returns(new string[] { "Namespace1", "Namespace2" });
      Mock<ITypeDescriptorContext> contextMock = new Mock<ITypeDescriptorContext>();
      contextMock.SetupGet(x => x.Instance).Returns(new XmlQualifiedNameEditor(new XmlQualifiedName("name", "ns"), namespacesProviderMock.Object));
      TypeConverter.StandardValuesCollection standardValues = instance2Test.GetStandardValues(contextMock.Object);
      Assert.IsNotNull(standardValues);
      Assert.AreEqual<int>(2, standardValues.Count);
      Assert.AreEqual<string>("Namespace1", (string)standardValues[0]);
      Assert.AreEqual<string>("Namespace2", (string)standardValues[1]);
    }
  }
}