//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections;
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
      Assert.AreEqual<int>(1, _instance.Nodes.Count);
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
      BaseTreeNodeControlTest _instance = new BaseTreeNodeControlTest(_model);
      Assert.AreEqual<int>(1, _instance.Nodes.Count);
      Assert.IsInstanceOfType(_instance.Nodes[0], typeof(DictionaryTreeNodeFixture));
    }

    #endregion test methods

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

      public BaseTreeNodeControlTest(BaseTreeNodeTest model) : base(model)
      {
        m_Model = model;
      }

      private readonly BaseTreeNodeTest m_Model = null;
    }

    private class BaseTreeNodeTest : IBaseModel
    {
      internal int SubtreeChangedCount = 0;
      internal int TextChangedCount = 0;
      private List<IBaseModel> collection = new List<IBaseModel>();

      public BaseTreeNodeTest()
      {
        Mock<IBaseModel> mock = new Mock<IBaseModel>();
        collection.Add(mock.Object);
      }

      #region IBaseModelView

      public string Text { get; set; } = nameof(BaseTreeNodeTest);
      public string ToolTipText { get; set; } = "ToolTipText";
      public IBaseModel Parent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

      public string[] AvailiableNamespaces => throw new NotImplementedException();

      public event EventHandler<ProjectEventArgs> SubtreeChanged
      {
        add { SubtreeChangedCount++; }
        remove
        {
          throw new InvalidOperationException();
        }
      }

      public event EventHandler<TextEventArgs> TextChanged
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

      private IEnumerator<IBaseModel> GetEnumerator()
      {
        return collection.GetEnumerator();
      }

      public bool Remove(IBaseModel item)
      {
        throw new NotImplementedException();
      }

      IEnumerator<IBaseModel> IEnumerable<IBaseModel>.GetEnumerator()
      {
        return collection.GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return collection.GetEnumerator();
      }

      #endregion IBaseModelView
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
        return new DictionaryTreeNodeFixture();
      }
    }

    #endregion testing instrumentation
  }
}