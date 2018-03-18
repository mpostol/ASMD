﻿
using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UAOOI.SemanticData.UANodeSetValidation;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Controls
{
  [TestClass]
  public class SolutionTreeNodeControlUnitTest
  {
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
      SolutionTreeNodeTest _model = new SolutionTreeNodeTest();
      _model.Add(new BaseModelTest());
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
      Assert.AreEqual<int>(2, _model.TextChangedCount);
    }
    [TestMethod]
    public void AddProjectTest()
    {
      SolutionTreeNodeTest _model = new SolutionTreeNodeTest();
      SolutionTreeNodeControlTest _instance = new SolutionTreeNodeControlTest(_model);
      Assert.AreEqual<int>(0, _instance.Nodes.Count);
      _model.AddProject(false);
      Assert.AreEqual<int>(1, _instance.Nodes.Count);
      Assert.IsInstanceOfType(_instance.Nodes[0], typeof(ProjectTreeNodeControl));
    }

    #region testing instrumentation
    private class SolutionTreeNodeControlTest : SolutionTreeNodeControl
    {
      public SolutionTreeNodeControlTest(ISolutionModel model) : base(model) { }
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
      public void ImportNodeSetHandler(Func<string, Action<TraceMessage>, Tuple<Opc.Ua.ModelCompiler.ModelDesign, string>> imprtNodeset)
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
      public void Open()
      {
        throw new NotImplementedException();
      }
      public void OnNew()
      {
        throw new NotImplementedException();
      }
      public void AddProject(bool existing)
      {
        if (existing)
          throw new NotImplementedException();
        else
        {
          Add(new BaseModelTest());
          m_SubtreeChanged?.Invoke(this, new BaseTreeNode.ProjectEventArgs());
        }
      }
      #endregion

    }
    private class BaseModelTest : List<IBaseModel>, IBaseModel, IProjectModel
    {
      #region IProjectModel
      public string Name
      {
        get
        {
          throw new NotImplementedException();
        }
      }
      public void Remove()
      {
        throw new NotImplementedException();
      }
      #endregion

      #region IBaseModel
      public string Text
      {
        get
        {
          return "Text";
        }

        set
        {
          throw new NotImplementedException();
        }
      }
      public string ToolTipText
      {
        get
        {
          return "ToolTipText";
        }
        set
        {
          throw new NotImplementedException();
        }
      }
      public event EventHandler<BaseTreeNode.ProjectEventArgs> SubtreeChanged;
      public event EventHandler<BaseTreeNode.TextEventArgs> TextChanged;
      public BaseDictionaryTreeNode GetTreeNode()
      {
        return new DictionaryTreeNodeTest();
      }
      #endregion

    }
    private class DictionaryTreeNodeTest : DictionaryTreeView.DictionaryTreeNode
    {
      protected override void Unregister()
      {
        throw new NotImplementedException();
      }
      internal override BaseDictionaryTreeNode CreateCopy()
      {
        throw new NotImplementedException();
      }

    }
    #endregion
  }
}
