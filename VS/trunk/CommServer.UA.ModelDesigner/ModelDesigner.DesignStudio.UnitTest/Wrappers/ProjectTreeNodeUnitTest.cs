﻿using CAS.CommServer.UA.Common;
using CAS.UA.Model.Designer.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Wrappers
{
  [TestClass]
  public class ProjectTreeNodeUnitTest
  {
    [ClassInitializeAttribute]
    public static void MyTestMethod(TestContext context)
    {
      ViewModelFactory.Factory = new ViewModelFactoryTest();
    }
    [TestMethod]
    public void ConstructorTest()
    {
      ProjectTreeNode _newItem = new ProjectTreeNode (new BaseDirectoryProvider(), string.Empty, new Opc.Ua.ModelCompiler.ModelDesign());
    }
    [TestMethod]
    public void WrapperProviderTest()
    {
      ProjectTreeNode _newItem = new ProjectTreeNode(new BaseDirectoryProvider(), string.Empty, new Opc.Ua.ModelCompiler.ModelDesign());
      object _viewModel = _newItem.Wrapper;
      Assert.IsNotNull(_viewModel);
      Assert.AreSame(_viewModel, ViewModel.Instance);
    }
    private class BaseDirectoryProvider : IBaseDirectoryProvider
    {
      public string GetBaseDirectory()
      {
        return String.Empty;
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
    private class ViewModel: IViewModel
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

  }
}
