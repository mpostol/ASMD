//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAS.UA.Model.Designer.Wrappers
{
  [TestClass]
  public class BaseTreeNodeTestUnitTest
  {

    [TestMethod]
    public void ConstructorTest()
    {
      BaseTreeNodeFixture _instance = new BaseTreeNodeFixture(nameof(BaseTreeNodeFixture));
      Assert.AreEqual<string>(nameof(BaseTreeNodeFixture), _instance.Text);
    }
    private class BaseTreeNodeFixture : BaseTreeNode
    {
      public BaseTreeNodeFixture(string text) : base(text) { }
    }

  }
}
