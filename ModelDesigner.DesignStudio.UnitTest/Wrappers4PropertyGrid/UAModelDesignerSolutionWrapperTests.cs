//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
      Mock<WrappersModel.ISolutionTreeNodeUI> _SolutionTreeNodeMock = new Mock<WrappersModel.ISolutionTreeNodeUI>();
      _SolutionTreeNodeMock.Setup<string>(x => x.HomeDirectory.BaseDirectory).Returns(nameof(WrappersModel.ISolutionTreeNodeUI.HomeDirectory));
      _SolutionTreeNodeMock.Setup<string>(x => x.Text).Returns(nameof(WrappersModel.ISolutionTreeNodeUI.Text));
      _SolutionTreeNodeMock.Setup<string>(x => x.ToolTipText).Returns(nameof(WrappersModel.ISolutionTreeNodeUI.ToolTipText));
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(_SolutionTreeNodeMock.Object);
      //Assert
      Assert.AreEqual<string>(nameof(WrappersModel.ISolutionTreeNodeUI.Text), _newSolution.Name);
      Assert.AreEqual<string>(nameof(WrappersModel.ISolutionTreeNodeUI.HomeDirectory), _newSolution.HomeDirectory);
      Assert.IsNull(_newSolution.Server);
    }
  }
}