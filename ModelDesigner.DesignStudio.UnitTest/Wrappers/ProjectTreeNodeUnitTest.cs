//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using OPCFModelDesign = Opc.Ua.ModelCompiler.ModelDesign;

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
      String _currentFolder = Directory.GetCurrentDirectory();
      Mock<IProjectConfigurationManagement> _project = new Mock<IProjectConfigurationManagement>();
      Mock<OPCFModelDesign> _OPCFModelDesignMock = new Mock<OPCFModelDesign>();
      _project.SetupGet<OPCFModelDesign>(x => x.ModelDesign).Returns(_OPCFModelDesignMock.Object);
      _project.SetupGet<string>(x => x.Name).Returns("EFFF0C05 - 8406 - 4AD9 - 8725 - F00FC8295327");
      Mock<BaseTreeNode> _parentMock = new Mock<BaseTreeNode>("ParentBaseNode");
      _parentMock.SetupGet<string[]>(x => x.AvailiableNamespaces).Returns(new List<string>(){ "ns1", "ns2"}.ToArray());
      _parentMock.Setup(x => x.GetTargetNamespace()).Returns("GetTargetNamespace");
      CheckConsistency(new ProjectTreeNode(_project.Object) { Parent = _parentMock.Object });
      Assert.AreEqual<string>(_currentFolder, Directory.GetCurrentDirectory());
    }

    //TODO Test application functionality using User Interface (UI) #144
    //[TestMethod]
    //public void CreateTest()
    //{
    //  Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
    //  _directory.SetupGet(x => x.BaseDirectory).Returns(@"C:\");
    //  ProjectTreeNode _emptyModel = ProjectTreeNode.CreateNewModel(_directory.Object);
    //  IViewModel _viewModel = _emptyModel.Create();
    //  Assert.IsNotNull(_viewModel);
    //}

    //[TestMethod]
    //public void FindTest()
    //{
    //  Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
    //  _directory.SetupGet(x => x.BaseDirectory).Returns(@"C:\");
    //  ProjectTreeNode _emptyModel = ProjectTreeNode.CreateNewModel(_directory.Object);
    //  XmlQualifiedName _toFind = new XmlQualifiedName("Name", "Namespace");
    //  ITypeDesign _findReturn = _emptyModel.Find(_toFind);
    //  Assert.IsNull(_findReturn);
    //}

    //[TestMethod]
    //public void GetTargetNamespaceTest()
    //{
    //  Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
    //  string _solutionDir = Path.Combine(Directory.GetCurrentDirectory(), "Temp");
    //  Directory.CreateDirectory(_solutionDir);
    //  _directory.SetupGet(x => x.BaseDirectory).Returns(_solutionDir);
    //  ProjectTreeNode _emptyModel = ProjectTreeNode.CreateNewModel(_directory.Object);
    //  _emptyModel.Save();
    //  string _expectedModelFileName = Path.Combine(_solutionDir, _emptyModel.FileName);
    //  Assert.IsTrue(File.Exists(_expectedModelFileName), _expectedModelFileName);
    //}

    #region instrumentation

    private const string m_DemoConfigurationFilePath = @"TestData\DemoConfiguration\BoilerType.xml";

    private void CheckConsistency(ProjectTreeNode _newItem)
    {
      Assert.IsNotNull(_newItem.Parent);
      Assert.AreEqual<int>(2, _newItem.AvailiableNamespaces.Length);
      Assert.AreEqual<int>(1, _newItem.Count);
      Assert.IsNotNull(_newItem.ErrorList);
      Assert.AreEqual<int>(0, _newItem.ErrorList.Count);
      Assert.AreEqual<string>(@"", _newItem.HelpTopicName);
      Assert.AreEqual<string>("GetTargetNamespace",  _newItem.GetTargetNamespace());
      Assert.IsNotNull(_newItem.SymbolicName);
      Assert.AreEqual<string>(@"EFFF0C05 - 8406 - 4AD9 - 8725 - F00FC8295327", _newItem.Text);
      Assert.IsTrue(String.IsNullOrEmpty(_newItem.ToolTipText));
      object _viewModel = _newItem.Wrapper;
      Assert.IsNotNull(_viewModel);
      Assert.AreSame(_viewModel, ViewModel.Instance);
      object _w4pg = _newItem.Wrapper4PropertyGrid;
      Assert.IsNotNull(_w4pg);
      Assert.AreSame(_w4pg, ViewModel.Instance);
    }

    private class SolutionDirectoryPathManagement : SolutionDirectoryPathManagementBase
    {
      internal void SetNewPath(string path)
      {
        base.DefaultFileName = path;
      }

      public SolutionDirectoryPathManagement(string baseDirectory) : base(baseDirectory)
      {
      }
    }

    private class ViewModelFactoryTest : IViewModelFactory
    {
      public IViewModel Create(SolutionTreeNode modelEntity)
      {
        throw new NotImplementedException();
      }

      public IViewModel Create(ProjectTreeNode modelEntity)
      {
        return ViewModel.Instance;
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