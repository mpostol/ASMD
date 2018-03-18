using CAS.UA.Model.Designer.Solution;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Model = CAS.UA.Model.Designer.Wrappers;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Wrappers4PropertyGrid
{
  [TestClass()]
  public class UAModelDesignerSolutionWrapperTests
  {
    [ClassInitializeAttribute]
    public static void ClassInitializeMethod(TestContext context)
    {
      Model.ViewModelFactory.Factory = new ViewModelFactory();
    }
    [TestMethod()]
    public void ConstructorDefaultTest()
    {
      UAModelDesignerSolution _solution = UAModelDesignerSolution.CreateEmptyModel();
      Model.SolutionTreeNode _stn = new Model.SolutionTreeNode(_solution, String.Empty, (x, y) => { });
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(_stn);
      Assert.IsTrue(String.IsNullOrEmpty(_newSolution.HomeDirectory));
      Assert.AreEqual<string>(_solution.Name, _newSolution.Name);
      Assert.IsNotNull(_newSolution.Server);
      Assert.IsNull(_newSolution.Server.SelectedAssembly);
      Assert.IsNull(_newSolution.Server.ServerConfiguration);
    }

  }
}