
using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Controls
{
  [TestClass]
  public class FileMenuProviderControlUnitTest
  {

    #region TestMethod
    [TestMethod]
    public void ConstructorTest()
    {
      FileMenuProviderTest _newInstance = FileMenuProviderTest.CreteInstance();
      Assert.AreEqual<int>(0, _newInstance.ContextMenuStrip.Items.Count);
      Assert.AreEqual<string>(nameof(BaseTreeNodeTest), _newInstance.Name);
      Assert.AreEqual(1, _newInstance.AddChildrenCalled);
    }
    [TestMethod]
    public void AddItemsToMenuTest()
    {
      FileMenuProviderTest _newInstance = FileMenuProviderTest.CreteInstance();
      using (ContextMenuStrip _strip = new ContextMenuStrip())
      {
        _newInstance.AddItemsToMenu(_strip);
        Assert.AreEqual<int>(4, _strip.Items.Count);
        _strip.Items.Clear();
        _newInstance.AddItemsToMenu(_strip);
        Assert.AreEqual<int>(4, _strip.Items.Count);
      }
    }
    [TestMethod]
    public void AddItemsToMenuContentTest()
    {
      FileMenuProviderTest _newInstance = FileMenuProviderTest.CreteInstance();
      using (ContextMenuStrip _strip = new ContextMenuStrip())
      {
        _newInstance.AddItemsToMenu(_strip);
        Assert.AreEqual<int>(4, _strip.Items.Count);
        Assert.AreEqual<string>("&New", _strip.Items[0].Text);
        Assert.AreEqual<string>("&Open...", _strip.Items[1].Text);
        Assert.AreEqual<string>("&Save", _strip.Items[2].Text);
        //Assert.IsTrue(_strip.Items[2].Enabled); //It depends on license installation. After removing license must be true always
        Assert.AreEqual<string>("Save &As...", _strip.Items[3].Text);
        //Assert.IsTrue(_strip.Items[3].Enabled);//It depends on license installation. After removing license must be true always
      }
    }
    #endregion

    #region test instrunmentation
    private class FileMenuProviderTest : FileMenuProviderControl<BaseTreeNodeTest>
    {
      internal static FileMenuProviderTest CreteInstance()
      {
        return new FileMenuProviderTest(BaseTreeNodeTest.CreateInstance());
      }
      public FileMenuProviderTest(BaseTreeNodeTest parent) : base(parent)
      { }
      protected override void New()
      {
        throw new NotImplementedException();
      }
      protected override void Open()
      {
        throw new NotImplementedException();
      }
      protected override void Save()
      {
        throw new NotImplementedException();
      }
      protected override void SaveAs()
      {
        throw new NotImplementedException();
      }
      protected override void AddChildren(BaseTreeNodeTest parent)
      {
        Assert.IsNotNull(parent);
        AddChildrenCalled++; 
      }
      internal int AddChildrenCalled = 0; 
    }
    private class BaseTreeNodeTest : BaseTreeNode
    {
      internal static BaseTreeNodeTest CreateInstance()
      {
        return new BaseTreeNodeTest(nameof(BaseTreeNodeTest));
      }
      public BaseTreeNodeTest(string text) : base(text)
      {
      }
    }
    #endregion

  }
}
