//__________________________________________________________________________________________________
//
//  Copyright (C) Year of Copyright, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CAS.UA.Model.Designer.Wrappers
{
  [TestClass]
  public class BaseModelUnitTest
  {
    [TestMethod]
    public void ConstructorTest()
    {
      BaseTreeNodeFixture instance2Test = new BaseTreeNodeFixture(RandomTekst);
      Assert.AreEqual<int>(0, instance2Test.Count);
      Assert.AreEqual<string>(RandomTekst, instance2Test.Text);
      Assert.IsNull(instance2Test.ToolTipText);
      Assert.IsNull(instance2Test.Parent);
      Assert.ThrowsException<System.NullReferenceException>(() => instance2Test.AvailiableNamespaces);
    }

    [TestMethod]
    public void TextTest()
    {
      BaseTreeNodeFixture instance2Test = new BaseTreeNodeFixture(RandomTekst);
      Assert.AreEqual<string>(RandomTekst, instance2Test.Text);
      int textChangedCounter = 0;
      instance2Test.TextChanged += (x, y) => textChangedCounter++;
      instance2Test.Text = "newText";
      Assert.AreEqual<int>(1, textChangedCounter);
      instance2Test.Text = "newText";
      Assert.AreEqual<int>(1, textChangedCounter);
    }

    [TestMethod]
    public void ToolTipTextTest()
    {
      BaseTreeNodeFixture instance2Test = new BaseTreeNodeFixture(RandomTekst);
      int textChangedCounter = 0;
      instance2Test.TextChanged += (x, y) => textChangedCounter++;
      instance2Test.ToolTipText = "newText";
      Assert.AreEqual<int>(1, textChangedCounter);
      instance2Test.ToolTipText = "newText";
      Assert.AreEqual<int>(1, textChangedCounter);
    }

    [TestMethod]
    public void AddTest()
    {
      BaseTreeNodeFixture instance2Test = new BaseTreeNodeFixture(RandomTekst);
      Mock<IBaseModel> mock = new Mock<IBaseModel>();
      instance2Test.Add(mock.Object);
      mock.VerifySet(x => x.Parent = It.IsAny<IBaseModel>(), Times.Once);
    }

    [TestMethod]
    public void GetTargetNamespaceTest()
    {
      BaseTreeNodeFixture instance2Test = new BaseTreeNodeFixture(RandomTekst);
      Mock<IBaseModel> mock = new Mock<IBaseModel>();
      instance2Test.Parent = mock.Object;
      _ = instance2Test.GetTargetNamespace();
      instance2Test.CreateInstanceConfigurations(null, false, out bool cancel);
      _ = instance2Test.AvailiableNamespaces;

      mock.Verify(x => x.GetTargetNamespace(), Times.Once);
      mock.Verify(x => x.CreateInstanceConfigurations(null, false, out cancel), Times.Once);
      mock.VerifyGet(x => x.AvailiableNamespaces, Times.Once);
    }

    [TestMethod]
    public void MyTestMethod()
    {
      BaseTreeNodeFixture instance2Test = new BaseTreeNodeFixture(RandomTekst);
      Assert.ThrowsException<NotImplementedException>(() => instance2Test.GetNodeDescriptors());
    }
    #region instrumentation

    private readonly string RandomTekst = "j87aC5eN4SXqddrxA0cayuPvtM1grfswSqGtB98nTZ2YgNf1L";

    private class BaseTreeNodeFixture : BaseModel
    {
      public BaseTreeNodeFixture(string text) : base(text)
      {
      }
    }

    #endregion instrumentation
  }
}