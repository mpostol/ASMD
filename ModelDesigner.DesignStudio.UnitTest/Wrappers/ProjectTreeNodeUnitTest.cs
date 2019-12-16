//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    [TestMethod]
    public void ConstructorNewProjectTest()
    {
      ProjectTreeNode _newItem = new ProjectTreeNode(new BaseDirectoryProvider(), string.Empty, new Opc.Ua.ModelCompiler.ModelDesign());
      object _viewModel = _newItem.Wrapper;
      Assert.IsNotNull(_viewModel);
      Assert.AreSame(_viewModel, ViewModel.Instance);
      Assert.IsTrue(_newItem.Name.StartsWith("Model_")); 
      Assert.AreEqual<string>(@"$(ProjectFileName)", _newItem.BuildOutputDirectoryName);
      Assert.IsFalse(String.IsNullOrEmpty(_newItem.BuildOutputDirectoryPath));
      Assert.AreEqual<string>("$(ProjectFileName).csv", _newItem.CSVFileName);
      Assert.IsFalse(String.IsNullOrEmpty(_newItem.CSVFilePath));
      Assert.IsTrue(_newItem.FileName.StartsWith("Model_"));
      Assert.IsFalse(String.IsNullOrEmpty(_newItem.FilePath));
      Assert.IsNotNull(_newItem.ProjectIdentifier);
    }

    #region instrumentation
    private class BaseDirectoryProvider : IBaseDirectoryProvider
    {
      public string GetBaseDirectory()
      {
        return string.Empty;
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
    #endregion

  }
}
