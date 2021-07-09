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
      Mock<ISolutionModelView> _SolutionTreeNodeMock = new Mock<ISolutionModelView>();
      _SolutionTreeNodeMock.Setup<string>(x => x.HomeDirectory.DefaultDirectory).Returns(nameof(ISolutionModelView.HomeDirectory));
      _SolutionTreeNodeMock.Setup<string>(x => x.Text).Returns(nameof(ISolutionModelView.Text));
      _SolutionTreeNodeMock.Setup<string>(x => x.ToolTipText).Returns(nameof(ISolutionModelView.ToolTipText));
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(_SolutionTreeNodeMock.Object);
      //Assert
      Assert.AreEqual<string>(nameof(ISolutionModelView.Text), _newSolution.Name);
      Assert.AreEqual<string>(nameof(ISolutionModelView.HomeDirectory), _newSolution.HomeDirectory);
      Assert.IsNull(_newSolution.Server);
    }
  }
}
