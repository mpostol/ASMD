//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using OPCFModelDesign = UAOOI.SemanticData.UAModelDesignExport.XML.ModelDesign;

namespace CAS.UA.Model.Designer.Wrappers
{
  [TestClass]
  [DeploymentItem(@"TestData\", @"TestData")]
  public class ProjectTreeNodeUnitTest
  {
    [ClassInitializeAttribute]
    public static void ClassInitialize(TestContext context)
    {
      ViewModelFactory.Factory = new ViewModelFactoryTest();
      string m_DemoConfigurationAbsoluteFilePath = Path.Combine(context.TestRunDirectory, m_DemoConfigurationFilePath);
      Assert.IsTrue(File.Exists(m_DemoConfigurationFilePath));
    }

    [TestMethod]
    public void CreateNewModelTest()
    {
      //preparation
      Mock<IProjectConfigurationManagement> _projectConfigurationMock = new Mock<IProjectConfigurationManagement>();
      Mock<OPCFModelDesign> _OPCFModelDesignMock = new Mock<OPCFModelDesign>();
      _projectConfigurationMock.SetupGet<OPCFModelDesign>(x => x.ModelDesign).Returns(_OPCFModelDesignMock.Object);
      _projectConfigurationMock.SetupGet<string>(x => x.Name).Returns("EFFF0C05 - 8406 - 4AD9 - 8725 - F00FC8295327");
      Mock<BaseModel> _parentMock = new Mock<BaseModel>("ParentBaseNode");
      _parentMock.SetupGet<string[]>(x => x.AvailiableNamespaces).Returns(new List<string>() { "ns1", "ns2" }.ToArray());
      _parentMock.Setup<string>(x => x.GetTargetNamespace()).Returns("GetTargetNamespace");
      //create object under test
      ProjectTreeNode _newItem = new ProjectTreeNode(_projectConfigurationMock.Object) { Parent = _parentMock.Object };
      //test consistency
      Assert.IsNotNull(_newItem.Parent);
      Assert.AreEqual<int>(2, _newItem.AvailiableNamespaces.Length);
      Assert.AreEqual<int>(1, _newItem.Count);
      Assert.IsNotNull(_newItem.ErrorList);
      Assert.AreEqual<int>(0, _newItem.ErrorList.Count);
      Assert.AreEqual<string>(@"", _newItem.HelpTopicName);
      Assert.AreEqual<string>("GetTargetNamespace", _newItem.GetTargetNamespace());
      Assert.IsNotNull(_newItem.SymbolicName);
      Assert.AreEqual<string>(@"EFFF0C05 - 8406 - 4AD9 - 8725 - F00FC8295327", _newItem.Text);
      Assert.IsTrue(String.IsNullOrEmpty(_newItem.ToolTipText));
      object _viewModel = _newItem.Wrapper;
      Assert.IsNotNull(_viewModel);
      Assert.AreSame(_viewModel, ViewModel.Instance);
      object _w4pg = _newItem.Wrapper4PropertyGrid;
      Assert.IsNotNull(_w4pg);
      Assert.AreSame(_w4pg, ViewModel.Instance);
      //test behavior
      _projectConfigurationMock.VerifyGet(x => x.ModelDesign, Times.Once);
      _projectConfigurationMock.VerifyGet(x => x.Name, Times.Once);
    }

    [TestMethod]
    public void FindTest()
    {
      Mock<IProjectConfigurationManagement> _projectConfigurationMock = new Mock<IProjectConfigurationManagement>();
      Mock<OPCFModelDesign> _OPCFModelDesignMock = new Mock<OPCFModelDesign>();
      _projectConfigurationMock.SetupGet<OPCFModelDesign>(x => x.ModelDesign).Returns(_OPCFModelDesignMock.Object);
      _projectConfigurationMock.SetupGet<string>(x => x.Name).Returns("EFFF0C05 - 8406 - 4AD9 - 8725 - F00FC8295327");
      Mock<IBaseModel> _parentMock = new Mock<IBaseModel>();
      _parentMock.SetupGet<string[]>(x => x.AvailiableNamespaces).Returns(new List<string>() { "ns1", "ns2" }.ToArray());
      ProjectTreeNode _newItem = new ProjectTreeNode(_projectConfigurationMock.Object) { Parent = _parentMock.Object };

      XmlQualifiedName _toFind = new XmlQualifiedName("Name", "Namespace");
      ITypeDesign _findReturn = _newItem.Find(_toFind);
      Assert.IsNull(_findReturn);
    }

    [TestMethod]
    public void BuildTest()
    {
      Mock<IProjectConfigurationManagement> _projectConfigurationMock = new Mock<IProjectConfigurationManagement>();
      Mock<OPCFModelDesign> _OPCFModelDesignMock = new Mock<OPCFModelDesign>();
      _projectConfigurationMock.SetupGet<OPCFModelDesign>(x => x.ModelDesign).Returns(_OPCFModelDesignMock.Object);
      _projectConfigurationMock.SetupGet<string>(x => x.Name).Returns("EFFF0C05 - 8406 - 4AD9 - 8725 - F00FC8295327");

      //_projectConfigurationMock.Setup(x => x.Build( z => { } ));
      Mock<BaseModel> _parentMock = new Mock<BaseModel>("ParentBaseNode");

      ProjectTreeNode _newItem = new ProjectTreeNode(_projectConfigurationMock.Object) { Parent = _parentMock.Object };
      List<string> trace = new List<string>();
      Action<string> tracer = x => trace.Add(x);
      _newItem.Build(tracer);
      _projectConfigurationMock.Verify(x => x.Build(tracer), Times.Once);
      Assert.AreEqual<int>(4, trace.Count);
      Assert.AreEqual<string>("------ Building project: EFFF0C05 - 8406 - 4AD9 - 8725 - F00FC8295327. ------", trace[0]);
      Assert.IsTrue(trace[1].StartsWith("Build started at:"));
      Assert.IsTrue(trace[2].StartsWith("Build ended at:"));
      Assert.AreEqual<string>("", trace[3]);
      foreach (string msg in trace)
        System.Diagnostics.Debug.WriteLine(msg);
    }

    [TestMethod]
    public void SaveTest()
    {
      //preparation
      Mock<IProjectConfigurationManagement> _projectConfigurationMock = new Mock<IProjectConfigurationManagement>();
      Mock<OPCFModelDesign> _OPCFModelDesignMock = new Mock<OPCFModelDesign>();
      _projectConfigurationMock.SetupGet<OPCFModelDesign>(x => x.ModelDesign).Returns(_OPCFModelDesignMock.Object);
      _projectConfigurationMock.SetupGet<string>(x => x.Name).Returns("EFFF0C05 - 8406 - 4AD9 - 8725 - F00FC8295327");
      Mock<BaseModel> _parentMock = new Mock<BaseModel>("ParentBaseNode");
      _parentMock.SetupGet<string[]>(x => x.AvailiableNamespaces).Returns(new List<string>() { "ns1", "ns2" }.ToArray());
      _parentMock.Setup(x => x.GetTargetNamespace()).Returns("GetTargetNamespace");
      //create object under test
      ProjectTreeNode _newItem = new ProjectTreeNode(_projectConfigurationMock.Object) { Parent = _parentMock.Object };

      _newItem.Save();

      _projectConfigurationMock.Verify(x => x.Save(It.IsAny<OPCFModelDesign>()), Times.Once);
    }

    #region instrumentation

    private const string m_DemoConfigurationFilePath = @"TestData\DemoConfiguration\BoilerType.xml";

    private class ViewModelFactoryTest : IViewModelFactory
    {
      public IViewModel Create(IProjectModelView modelEntity)
      {
        return ViewModel.Instance;
      }

      public IViewModel Create(ISolutionModelView modelEntity)
      {
        throw new NotImplementedException();
      }
    }

    private class ViewModel : IViewModel
    {
      private static ViewModel m_Instance;

      internal static ViewModel Instance
      {
        get
        {
          if (m_Instance == null)
            m_Instance = new ViewModel();
          return m_Instance;
        }
      }
    }

    #endregion instrumentation
  }
}