//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Solution;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WrappersModel = global::CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid
{
  [TestClass()]
  public class UAModelDesignerSolutionWrapperTests
  {
    [ClassInitializeAttribute]
    public static void ClassInitializeMethod(TestContext context)
    {
      WrappersModel.ViewModelFactory.Factory = new ViewModelFactory();
    }
    [TestMethod()]
    public void ConstructorDefaultTest()
    {
      UAModelDesignerSolution _solution = UAModelDesignerSolution.CreateEmptyModel();
      WrappersModel.SolutionTreeNode _stn = new WrappersModel.SolutionTreeNode(_solution, String.Empty, (x, y) => { });
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(_stn);
      Assert.IsTrue(String.IsNullOrEmpty(_newSolution.HomeDirectory));
      Assert.AreEqual<string>(_solution.Name, _newSolution.Name);
      Assert.IsNotNull(_newSolution.Server);
      Assert.IsNull(_newSolution.Server.SelectedAssembly);
      Assert.IsNull(_newSolution.Server.ServerConfiguration);
    }

  }
}