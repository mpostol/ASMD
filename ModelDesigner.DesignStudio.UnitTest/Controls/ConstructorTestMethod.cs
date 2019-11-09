//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CAS.UA.Model.Designer.Controls
{
  [TestClass]
  public class LibraryTreeNodeControlUnitTest
  {

    [TestMethod]
    public void ConstructorTestMethod()
    {
      Mock<LibraryTreeNode> _ltn = new Mock<LibraryTreeNode>(new object[]{ new Opc.Ua.ModelCompiler.ModelDesign(), "NodeName" });
      LibraryTreeNodeControl _newItem = new LibraryTreeNodeControl(_ltn.Object);
    }

  }
}
