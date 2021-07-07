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

    [TestInitialize]
    public void MyTestInitialize()
    {
      TreeNodesFactory.Factory = new FactoryFixture();
    }
    [TestCleanup]
    public void MyTestCleanup()
    {
      TreeNodesFactory.ResetSingleton();
    }
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
    [TestMethod]
    public void AddChildrenTest()
    {
      BaseTreeNodeTest _model = new BaseTreeNodeTest();
      _model.Add(new BaseTreeNodeTest());
      BaseTreeNodeControlTest _instance = new BaseTreeNodeControlTest(_model);
      Assert.AreEqual<int>(1, _instance.Nodes.Count);
      Assert.IsInstanceOfType(_instance.Nodes[0], typeof(DictionaryTreeNodeFixture));
    }
    #endregion

    #region testing instrumentation
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
      public IBaseModel Parent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

      public string[] AvailiableNamespaces => throw new NotImplementedException();

      public event EventHandler<BaseModel.ProjectEventArgs> SubtreeChanged
      {
        add { SubtreeChangedCount++; }
        remove
        {
          throw new InvalidOperationException();
        }
      }
      public event EventHandler<BaseModel.TextEventArgs> TextChanged
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

      public void CreateInstanceConfigurations(IBaseModel node, bool SkipOpeningConfigurationFile, out bool CancelWasPressed)
      {
        throw new NotImplementedException();
      }

      public string GetTargetNamespace()
      {
        throw new NotImplementedException();
      }

      public void RaiseOnChangeHandler()
      {
        throw new NotImplementedException();
      }

      public bool IsReadOnly()
      {
        throw new NotImplementedException();
      }
      #endregion

    }
    private class DictionaryTreeNodeFixture : DictionaryTreeNode
    {
      protected override void Unregister()
      {
        throw new NotImplementedException();
      }
    }
    private class FactoryFixture : ITreeNodesFactory
    {
      public DictionaryTreeNode GetTreeNode(IBaseModel wrapper)
      {
        Assert.IsInstanceOfType(wrapper, typeof(BaseTreeNodeTest));
        return new DictionaryTreeNodeFixture();
      }
    }
    #endregion

  }
}
