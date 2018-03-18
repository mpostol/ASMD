
using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Controls
{
  [TestClass]
  public class BaseTreeNodeControlUnitTest
  {
    
    #region test methods
    [TestMethod]
    public void ConstructorTest()
    {
      BaseTreeNodeControTest _instance = BaseTreeNodeControTest.CreateInstance();
      Assert.AreEqual<int>(0, _instance.ContextMenuStrip.Items.Count);
    }
    [TestMethod]
    [ExpectedException(typeof(NotImplementedException))]
    public void CreateCopyTest()
    {
      BaseTreeNodeControTest _instance = BaseTreeNodeControTest.CreateInstance();
      _instance.CreateCopy();
    }
    [TestMethod]
    public void EventsTest()
    {
      BaseTreeNodeTest _model = new BaseTreeNodeTest();
      BaseTreeNodeControTest _instance = new BaseTreeNodeControTest(_model);
      Assert.AreEqual<int>(1, _model.SubtreeChangedCount);
      Assert.AreEqual<int>(2, _model.TextChangedCount);
    }
    #endregion

    #region testing instrunebtation
    private class BaseTreeNodeControTest : BaseTreeNodeControl<BaseTreeNodeTest, IBaseModel>
    {
      internal static BaseTreeNodeControTest CreateInstance()
      {
        return new BaseTreeNodeControTest(new BaseTreeNodeTest());
      }
      protected override BaseDictionaryTreeNode GetChildTreeNodeControl(IBaseModel node)
      {
        throw new NotImplementedException();
      }
      public BaseTreeNodeControTest(BaseTreeNodeTest model) : base(model) { }
    }
    private class BaseTreeNodeTest : List<IBaseModel>, IBaseModel
    {

      internal int SubtreeChangedCount = 0;
      internal int TextChangedCount = 0;

      #region IBaseModel
      public string Text { get; set; } = nameof(BaseTreeNodeTest);
      public string ToolTipText { get; set; } = "ToolTipText";
      public event EventHandler<BaseTreeNode.ProjectEventArgs> SubtreeChanged
      {
        add { SubtreeChangedCount++; }
        remove
        {
          throw new InvalidOperationException();
        }
      }
      public event EventHandler<BaseTreeNode.TextEventArgs> TextChanged
      {
        add
        {
          TextChangedCount++;
        }
        remove
        {
          throw new InvalidOperationException();
        }
      }

      public BaseDictionaryTreeNode GetTreeNode()
      {
        throw new NotImplementedException();
      }
      #endregion

    }
    #endregion

  }
}
