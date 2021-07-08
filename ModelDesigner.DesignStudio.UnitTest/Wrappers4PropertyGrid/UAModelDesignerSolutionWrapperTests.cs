//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
      Mock<ISolutionTreeNodeUI> _SolutionTreeNodeMock = new Mock<ISolutionTreeNodeUI>();
      _SolutionTreeNodeMock.Setup<string>(x => x.HomeDirectory.DefaultDirectory).Returns(nameof(ISolutionTreeNodeUI.HomeDirectory));
      _SolutionTreeNodeMock.Setup<string>(x => x.Text).Returns(nameof(ISolutionTreeNodeUI.Text));
      _SolutionTreeNodeMock.Setup<string>(x => x.ToolTipText).Returns(nameof(ISolutionTreeNodeUI.ToolTipText));
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(_SolutionTreeNodeMock.Object);
      //Assert
      Assert.AreEqual<string>(nameof(ISolutionTreeNodeUI.Text), _newSolution.Name);
      Assert.AreEqual<string>(nameof(ISolutionTreeNodeUI.HomeDirectory), _newSolution.HomeDirectory);
      Assert.IsNull(_newSolution.Server);
    }
  }
}
