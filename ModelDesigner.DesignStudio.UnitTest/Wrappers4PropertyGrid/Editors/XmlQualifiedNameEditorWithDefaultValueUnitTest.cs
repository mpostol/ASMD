//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Xml;
using UAOOI.Windows.Forms;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid.Editors
{
  [TestClass]
  public class XmlQualifiedNameEditorWithDefaultValueUnitTest
  {
    [TestMethod]
    public void ConstructorTest1()
    {
      Mock<IXmlQualifiedNameEditorNamespaceProvider> mock = new Mock<IXmlQualifiedNameEditorNamespaceProvider>();
      XmlQualifiedNameEditorWithDefaultValue toTest = new XmlQualifiedNameEditorWithDefaultValue(new XmlQualifiedName("name", "namespace"), mock.Object, new XmlQualifiedName("defaultName", "defaultNamespace"));
      Assert.IsNotNull(toTest.DefaultValue);
      Assert.IsFalse(toTest.IsEmpty);
      Assert.IsFalse(toTest.IsNull);
      Assert.AreEqual<string>("name", toTest.Name);
      Assert.IsFalse(toTest.NameIsBasedOnDefault);
      Assert.AreEqual<string>("namespace", toTest.NameSpace);
      XmlQualifiedName qNmame = toTest.XmlQualifiedName;
      Assert.IsNotNull(qNmame);
      Assert.AreEqual<string>("name", qNmame.Name);
      Assert.AreEqual<string>("namespace", qNmame.Namespace);
      qNmame = toTest.ValueOrDefault;
      Assert.IsNotNull(qNmame);
      Assert.AreEqual<string>("name", qNmame.Name);
      Assert.AreEqual<string>("namespace", qNmame.Namespace);
      mock.Verify(x => x.GetAvailiableNamespaces(), Times.Never);
      mock.Verify(x => x.GetTargetNamespace(), Times.Never);
    }

    [TestMethod]
    public void ConstructorTest2()
    {
      Mock<IXmlQualifiedNameEditorNamespaceProvider> mock = new Mock<IXmlQualifiedNameEditorNamespaceProvider>();
      XmlQualifiedNameEditorWithDefaultValue toTest = new XmlQualifiedNameEditorWithDefaultValue(null, mock.Object, new XmlQualifiedName("defaultName", "defaultNamespace"));
      Assert.IsNotNull(toTest.DefaultValue);
      Assert.IsTrue(toTest.IsEmpty);
      Assert.IsTrue(toTest.IsNull);
      Assert.AreEqual<string>("", toTest.Name);
      Assert.IsFalse(toTest.NameIsBasedOnDefault);
      Assert.AreEqual<string>("", toTest.NameSpace);
      Assert.IsNull(toTest.XmlQualifiedName);
      XmlQualifiedName qNmame = toTest.ValueOrDefault;
      Assert.IsNotNull(qNmame);
      Assert.AreEqual<string>("defaultName", qNmame.Name);
      Assert.AreEqual<string>("defaultNamespace", qNmame.Namespace);
      mock.Verify(x => x.GetAvailiableNamespaces(), Times.Never);
      mock.Verify(x => x.GetTargetNamespace(), Times.Never);
    }

    [TestMethod]
    public void XmlQualifiedNameHasChangedTest()
    {
      Mock<IXmlQualifiedNameEditorNamespaceProvider> mock = new Mock<IXmlQualifiedNameEditorNamespaceProvider>();
      XmlQualifiedNameEditorWithDefaultValue toTest = new XmlQualifiedNameEditorWithDefaultValue(new XmlQualifiedName("name", "namespace"), mock.Object, new XmlQualifiedName("defaultName", "defaultNamespace"));
      int callCounter = 0;
      toTest.XmlQualifiedNameHasChanged += (src, ea) => callCounter++;
      toTest.Name = "NewName";
      Assert.AreEqual<string>("NewName", toTest.Name);
      Assert.AreEqual<string>("namespace", toTest.NameSpace);
      Assert.AreEqual<int>(1, callCounter);
      mock.Verify(x => x.GetAvailiableNamespaces(), Times.Never);
      mock.Verify(x => x.GetTargetNamespace(), Times.Never);
    }
  }
}