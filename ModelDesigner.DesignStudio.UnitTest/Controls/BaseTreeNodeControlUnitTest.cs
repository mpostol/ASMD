//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

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
      BaseTreeNodeControlTest _instance = BaseTreeNodeControlTest.CreateInstance();
      Assert.AreEqual<int>(0, _instance.ContextMenuStrip.Items.Count);
      Assert.AreEqual<int>(0, _instance.Nodes.Count);
      Assert.AreEqual<int>(0, _instance.ImageIndex);
      Assert.AreEqual<string>("BaseTreeNodeTest", _instance.Name);
      Assert.AreEqual<string>("BaseTreeNodeTest", _instance.Text);
      Assert.AreEqual<string>("ToolTipText", _instance.ToolTipText);
      _instance.CheckModelEntity();
    }
    [TestMethod]
    public void EventsTest()
    {
      BaseTreeNodeTest _model = new BaseTreeNodeTest();
      BaseTreeNodeControlTest _instance = new BaseTreeNodeControlTest(_model);
      Assert.AreEqual<int>(1, _model.SubtreeChangedCount);
      Assert.AreEqual<int>(1, _model.TextChangedCount);
    }
    #endregion

    #region testing instrunebtation
    private class BaseTreeNodeControlTest : BaseTreeNodeControl<BaseTreeNodeTest>
    {
      public void CheckModelEntity()
      {
        Assert.AreSame(ModelEntity, m_Model);
      }
      internal static BaseTreeNodeControlTest CreateInstance()
      {
        return new BaseTreeNodeControlTest(new BaseTreeNodeTest());
      }
      protected override void AddChildren(BaseTreeNodeTest parent)
      {
        Assert.IsNotNull(parent);
        Assert.IsInstanceOfType(parent, typeof(BaseTreeNodeTest));
        Assert.AreEqual<int>(0, parent.Count);
      }
      public BaseTreeNodeControlTest(BaseTreeNodeTest model) : base(model) { m_Model = model; }
      private readonly BaseTreeNodeTest m_Model = null;
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
      #endregion

    }
    #endregion

  }
}
