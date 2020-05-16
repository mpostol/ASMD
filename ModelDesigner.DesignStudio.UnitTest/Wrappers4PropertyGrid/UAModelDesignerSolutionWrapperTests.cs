//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.ToForms;
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
      //TODO System.NullReferenceException in SolutionTreeNode #117
      //Mock
      //UAModelDesignerSolution _solution = UAModelDesignerSolution.CreateEmptyModel();
      //WrappersModel.SolutionTreeNode _stn = new WrappersModel.SolutionTreeNode(_solution, String.Empty, (x, y) => { });
      //UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(_stn);
      //Assert.IsTrue(String.IsNullOrEmpty(_newSolution.HomeDirectory));
      //Assert.AreEqual<string>(_solution.Name, _newSolution.Name);
      //Assert.IsNotNull(_newSolution.Server);
      //Assert.IsNull(_newSolution.Server.SelectedAssembly);
      //Assert.IsNull(_newSolution.Server.ServerConfiguration);
    }

    //private class MessageBoxHandlingFixture : IMessageBoxHandling
    //{
    //  internal static IMessageBoxHandling New()


    //  public void Show(string wrapperTreeNode_menu_paste_cannot_be_done)
    //  {
    //    throw new NotImplementedException();
    //  }

    //  public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    //  {
    //    throw new NotImplementedException();
    //  }
    //}
  }
}