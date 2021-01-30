//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Controls
{
  [TestClass]
  public class LibraryTreeNodeControlUnitTest
  {
    [TestMethod]
    public void ConstructorTestMethod()
    {
      Mock<LibraryTreeNode> _ltn = new Mock<LibraryTreeNode>(new object[] { new OpcUaModelCompiler.ModelDesign(), "LibraryTreeNode NodeName" });
      LibraryTreeNodeControl _newItem = new LibraryTreeNodeControl(_ltn.Object);
      Assert.IsNull(_newItem.ContextMenu);
      Assert.IsNotNull(_newItem.FirstNode);
      Assert.AreEqual<int>(0, _newItem.ImageIndex);
      Assert.IsFalse(_newItem.IsExpanded);
      Assert.IsFalse(_newItem.IsVisible);
      Assert.AreEqual<string>("LibraryTreeNode NodeName", _newItem.Name);
      Assert.AreEqual<int>(1, _newItem.Nodes.Count);
      Assert.IsInstanceOfType(_newItem.Nodes[0], typeof(ModelDesignTreeNodeControl));
      Assert.AreEqual<int>(1, ((ModelDesignTreeNodeControl)_newItem.Nodes[0]).Nodes.Count);
      Assert.IsNull(_newItem.Tag);
      Assert.IsTrue(string.IsNullOrEmpty(_newItem.ToolTipText));
      Assert.AreEqual<string>("LibraryTreeNode NodeName", _newItem.Text);
    }
  }
}