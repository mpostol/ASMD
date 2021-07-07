//__________________________________________________________________________________________________
//
//  Copyright (C) Year of Copyright, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAS.UA.Model.Designer.Wrappers
{
  [TestClass]
  public class BaseTreeNodeTestUnitTest
  {
    [TestMethod]
    public void ConstructorTest()
    {
      BaseTreeNodeFixture instance = new BaseTreeNodeFixture(nameof(BaseTreeNodeFixture));
      Assert.AreEqual<string>(nameof(BaseTreeNodeFixture), instance.Text);
      Assert.IsNull(instance.ToolTipText);
      Assert.IsNull(instance.Parent);
      Assert.ThrowsException<System.NullReferenceException>(() => instance.AvailiableNamespaces);
    }

    private class BaseTreeNodeFixture : BaseModel
    {
      public BaseTreeNodeFixture(string text) : base(text)
      {
      }
    }
  }
}