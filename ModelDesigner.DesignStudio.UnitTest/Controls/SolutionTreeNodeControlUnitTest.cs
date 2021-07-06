//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Controls
{
  [TestClass]
  public class SolutionTreeNodeControlUnitTest
  {
    [TestInitialize]
    public void MyTestInitialize()
    {
      TreeNodesFactory.Factory = new FactoryFixture();
    }

    [TestMethod]
    public void ConstructorTest()
    {
      SolutionTreeNodeControlTest _instance = new SolutionTreeNodeControlTest(new SolutionTreeNodeTest());
      Assert.AreEqual<int>(0, _instance.ContextMenuStrip.Items.Count);
      Assert.AreEqual<string>(nameof(SolutionTreeNodeTest), _instance.Name);
      Assert.AreEqual<string>("ToolTipText", _instance.ToolTipText);
      Assert.AreEqual<int>(0, _instance.Nodes.Count);
    }

    [TestMethod]
    public void Constructor4TreeTest()
    {
      SolutionTreeNodeTest _model = new SolutionTreeNodeTest
      {
        new BaseModelTest()
      };
      SolutionTreeNodeControlTest _instance = new SolutionTreeNodeControlTest(_model);
      Assert.AreEqual<int>(1, _instance.Nodes.Count);
    }

    [TestMethod]
    public void BeforeMenuStripOpeningTest()
    {
      SolutionTreeNodeControlTest _instance = new SolutionTreeNodeControlTest(new SolutionTreeNodeTest());
      Assert.AreEqual<int>(0, _instance.ContextMenuStrip.Items.Count);
      _instance.RunBeforeMenuStripOpening();
      Assert.AreEqual<int>(9, _instance.ContextMenuStrip.Items.Count);
      Assert.AreEqual<string>("GetPluginMenuItems", _instance.ContextMenuStrip.Items[8].Text);
    }

    [TestMethod]
    public void EventsTest()
    {
      SolutionTreeNodeTest _model = new SolutionTreeNodeTest();
      SolutionTreeNodeControlTest _instance = new SolutionTreeNodeControlTest(_model);
      Assert.AreEqual<int>(1, _model.SubtreeChangedCount);
      Assert.AreEqual<int>(1, _model.TextChangedCount);
    }

    [TestMethod]
    public void AddProjectTest()
    {
      SolutionTreeNodeTest _model = new SolutionTreeNodeTest();
      SolutionTreeNodeControlTest _instance = new SolutionTreeNodeControlTest(_model);
      Assert.AreEqual<int>(0, _instance.Nodes.Count);
      _model.AddProject(false);
      Assert.AreEqual<int>(1, _instance.Nodes.Count);
      Assert.IsInstanceOfType(_instance.Nodes[0], typeof(DictionaryTreeNodeTest));
    }

    #region testing instrumentation

    private class FactoryFixture : CAS.UA.Model.Designer.Controls.ITreeNodesFactory
    {
      public DictionaryTreeNode GetTreeNode(IBaseModel wrapper)
      {
        Assert.IsNotNull(wrapper);
        Assert.IsInstanceOfType(wrapper, typeof(IProjectModel));
        return new DictionaryTreeNodeTest();
      }
    }

    private class SolutionTreeNodeControlTest : SolutionTreeNodeControl
    {
      public SolutionTreeNodeControlTest(ISolutionModel viewModel) : base(viewModel)
      {
      }

      protected override void BeforeMenuStripOpening()
      {
        base.BeforeMenuStripOpening();
      }

      internal void RunBeforeMenuStripOpening()
      {
        BeforeMenuStripOpening();
      }
    }

    private class SolutionTreeNodeTest : List<IBaseModel>, ISolutionModel
    {
      internal int SubtreeChangedCount = 0;
      internal int TextChangedCount = 0;

      #region ISolutionModel

      public string Text { get; set; } = nameof(SolutionTreeNodeTest);
      public string ToolTipText { get; set; } = "ToolTipText";
      public IBaseModel Parent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

      public string[] AvailiableNamespaces => throw new NotImplementedException();

      public event EventHandler<BaseTreeNode.ProjectEventArgs> SubtreeChanged
      {
        add
        {
          m_SubtreeChanged += value;
          SubtreeChangedCount++;
        }
        remove
        {
          throw new InvalidOperationException();
        }
      }

      private EventHandler<BaseTreeNode.ProjectEventArgs> m_SubtreeChanged;

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

      public void GetPluginMenuItems(ToolStripItemCollection items)
      {
        if (items.Count > 0)
          items.Add(new ToolStripSeparator());
        ToolStripMenuItem _menuItem = new ToolStripMenuItem("GetPluginMenuItems");
        items.Add(_menuItem);
      }

      public BaseDictionaryTreeNode GetTreeNode()
      {
        throw new NotImplementedException();
      }

      public void ImportNodeSet()
      {
        throw new NotImplementedException();
      }

      public void Save(bool v)
      {
        throw new NotImplementedException();
      }

      public void AddProject(bool existing)
      {
        if (existing)
          Assert.Fail();
        else
        {
          Add(new BaseModelTest());
          m_SubtreeChanged?.Invoke(this, new BaseTreeNode.ProjectEventArgs());
        }
      }

      public void Open(IGraphicalUserInterface gui)
      {
        throw new NotImplementedException();
      }

      public void OnNew(IGraphicalUserInterface gui)
      {
        throw new NotImplementedException();
      }

      public void RaiseOnChangeHandler()
      {
        throw new NotImplementedException();
      }

      public bool TestIfReadOnlyAndRetrunTrueIfReadOnly()
      {
        throw new NotImplementedException();
      }

      public string GetTargetNamespace()
      {
        throw new NotImplementedException();
      }

      public void CreateInstanceConfigurations(BaseTreeNode node, bool SkipOpeningConfigurationFile, out bool CancelWasPressed)
      {
        throw new NotImplementedException();
      }

      #endregion ISolutionModel
    }

    private class BaseModelTest : List<IBaseModel>, IBaseModel, IProjectModel
    {
      #region IProjectModel

      public string Name => throw new NotImplementedException();

      public void Remove()
      {
        throw new NotImplementedException();
      }

      #endregion IProjectModel

      #region IBaseModel

      public string Text
      {
        get => "Text";

        set => throw new NotImplementedException();
      }

      public string ToolTipText
      {
        get => "ToolTipText";
        set => throw new NotImplementedException();
      }
      public IBaseModel Parent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

      public string[] AvailiableNamespaces => throw new NotImplementedException();

      public event EventHandler<BaseTreeNode.ProjectEventArgs> SubtreeChanged;

      public event EventHandler<BaseTreeNode.TextEventArgs> TextChanged;

      public BaseDictionaryTreeNode GetTreeNode()
      {
        return new DictionaryTreeNodeTest();
      }

      public void RaiseOnChangeHandler()
      {
        throw new NotImplementedException();
      }

      public bool TestIfReadOnlyAndRetrunTrueIfReadOnly()
      {
        throw new NotImplementedException();
      }

      public string GetTargetNamespace()
      {
        throw new NotImplementedException();
      }

      public void CreateInstanceConfigurations(BaseTreeNode node, bool SkipOpeningConfigurationFile, out bool CancelWasPressed)
      {
        throw new NotImplementedException();
      }

      #endregion IBaseModel
    }

    private class DictionaryTreeNodeTest : DictionaryTreeNode
    {
      protected override void Unregister()
      {
        throw new NotImplementedException();
      }
    }

    #endregion testing instrumentation
  }
}