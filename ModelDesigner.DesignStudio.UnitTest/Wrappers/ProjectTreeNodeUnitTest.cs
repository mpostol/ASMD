//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.Common;
using CAS.UA.Model.Designer.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CAS.UA.Model.Designer.Wrappers
{
  [TestClass]
  public class ProjectTreeNodeUnitTest
  {
    [ClassInitializeAttribute]
    public static void ClassInitialize(TestContext context)
    {
      ViewModelFactory.Factory = new ViewModelFactoryTest();
    }

    //TODO Error while using Save operation #129 remove if useless
    //[TestMethod]
    //public void ConstructorNewProjectTest()
    //{
    //  Moq.Mock<IBaseDirectoryProvider> _directory = new Moq.Mock<IBaseDirectoryProvider>();
    //  _directory.Setup(x => x.GetBaseDirectory()).Returns(@"C:\");
    //  ProjectTreeNode _newItem = new ProjectTreeNode(_directory.Object, @"C:\Model_33", new Opc.Ua.ModelCompiler.ModelDesign());
    //  CheckConsistency(_newItem);
    //}
    [TestMethod]
    //TODO Error while using Save operation #129 work on the test
    public void CreateNewModelTest()
    {
      String _currentFolder = Directory.GetCurrentDirectory();
      Moq.Mock<IBaseDirectoryProvider> _directory = new Moq.Mock<IBaseDirectoryProvider>();
      _directory.Setup(x => x.GetBaseDirectory()).Returns(@"C:\");
      CheckConsistency(ProjectTreeNode.CreateNewModel(_directory.Object));
      Assert.AreEqual<string>(_currentFolder, Directory.GetCurrentDirectory());
    }

    #region instrumentation

    private void CheckConsistency(ProjectTreeNode _newItem)
    {
      Assert.IsNotNull(_newItem);
      Assert.ThrowsException<NullReferenceException>(() => _newItem.AvailiableNamespaces);
      Assert.AreEqual<string>("$(ProjectFileName)", _newItem.BuildOutputDirectoryName);
      Assert.IsTrue(_newItem.BuildOutputDirectoryPath.StartsWith(@"C:\Model_"));
      Assert.AreEqual<int>(1, _newItem.Count);
      Assert.AreEqual<string>("$(ProjectFileName).csv", _newItem.CSVFileName);
      Assert.IsTrue(_newItem.CSVFilePath.StartsWith(@"C:\Model_"));
      Assert.AreEqual<string>(@".csv", System.IO.Path.GetExtension(_newItem.CSVFilePath));
      Assert.IsNotNull(_newItem.ErrorList);
      Assert.AreEqual<int>(0, _newItem.ErrorList.Count);
      Assert.IsTrue(_newItem.FileName.StartsWith(@"C:\Model_"), _newItem.FileName);
      Assert.IsTrue(_newItem.FilePath.StartsWith(@"C:\Model_"));
      Assert.AreEqual<string>(@"", _newItem.HelpTopicName);
      Assert.IsNull(_newItem.Parent);
      Assert.IsNotNull(_newItem.SymbolicName);
      Assert.IsTrue(_newItem.Text.StartsWith(@"Model_"), _newItem.Text);
      Assert.IsTrue(String.IsNullOrEmpty(_newItem.ToolTipText));
      CheckConsistency(_newItem.UAModelDesignerProject);
      object _viewModel = _newItem.Wrapper;
      Assert.IsNotNull(_viewModel);
      Assert.AreSame(_viewModel, ViewModel.Instance);
      object _w4pg = _newItem.Wrapper4PropertyGrid;
      Assert.IsNotNull(_w4pg);
      Assert.AreSame(_w4pg, ViewModel.Instance);
    }

    private void CheckConsistency(UAModelDesignerProject uaModelDesignerProject)
    {
      Assert.IsNotNull(uaModelDesignerProject);
      Assert.AreEqual<string>("$(ProjectFileName)", uaModelDesignerProject.BuildOutputDirectoryName);
      Assert.AreEqual<string>("$(ProjectFileName).csv", uaModelDesignerProject.CSVFileName);
      Assert.IsTrue(uaModelDesignerProject.FileName.StartsWith((@"Model_")));
      Assert.IsTrue(uaModelDesignerProject.Name.StartsWith((@"Model_")));
      Guid _projectIdentifier = Guid.Parse(uaModelDesignerProject.ProjectIdentifier);
      Assert.IsFalse(Guid.Empty == _projectIdentifier);
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