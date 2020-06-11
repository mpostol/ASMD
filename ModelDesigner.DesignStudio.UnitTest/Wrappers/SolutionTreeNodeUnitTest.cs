//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Solution;
using CAS.UA.Model.Designer.ToForms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;

namespace CAS.UA.Model.Designer.Wrappers
{
  [TestClass]
  public class SolutionTreeNodeUnitTest
  {
    [ClassInitializeAttribute]
    public static void ClassInitializeMethod(TestContext context)
    {
      ViewModelFactory.Factory = new Wrappers4ProperyGrid.ViewModelFactory();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void ConstructorSolutionIsNullTest()
    {
      Mock<IMessageBoxHandling> _IMessageBoxHandlingMock = new Mock<IMessageBoxHandling>();
      int _librariesCallCounter = 0;
      SolutionTreeNode _stn = new SolutionTreeNode(_IMessageBoxHandlingMock.Object, null, String.Empty, (x, y) => { Assert.Fail(); }, z => _librariesCallCounter++);
    }
    [TestMethod]
    public void ConstructorTest()
    {
      Mock<IMessageBoxHandling> _IMessageBoxHandlingMock = new Mock<IMessageBoxHandling>();
      Mock<ISolutionDirectoryPathManagement> _solutionDirectory = new Mock<ISolutionDirectoryPathManagement>();
      _solutionDirectory.SetupGet<string>(x => x.BaseDirectory).Returns(Directory.GetCurrentDirectory());
      Mock<ISolutionConfigurationManagement> _solutionData = new Mock<ISolutionConfigurationManagement>();
      _solutionData.SetupGet<string>(x => x.Name).Returns("Name");
      _solutionData.SetupGet<UAModelDesignerSolutionServerDetails>(x => x.ServerDetails).Returns(UAModelDesignerSolutionServerDetails.CreateEmptyInstance);
      _solutionData.SetupGet<ISolutionDirectoryPathManagement>(x => x.SolutionDirectoryPathManagement).Returns(_solutionDirectory.Object);

      int _librariesCallCounter = 0;
      SolutionTreeNode _stn = new SolutionTreeNode(_IMessageBoxHandlingMock.Object, _solutionData.Object, String.Empty, (x, y) => { Assert.Fail(); }, z => _librariesCallCounter++);
      //_IMessageBoxHandlingMock
      IMessageBoxHandling _assignedIMessageBoxHandling = null;
      _stn.GetMessageBoxHandling(x => _assignedIMessageBoxHandling = x);
      Assert.IsNotNull(_assignedIMessageBoxHandling);
      Assert.AreSame(_IMessageBoxHandlingMock.Object, _assignedIMessageBoxHandling);
      Assert.AreEqual<int>(0, _IMessageBoxHandlingMock.Invocations.Count);
      //State
      Assert.ThrowsException<NullReferenceException>(() => _stn.AvailiableNamespaces);
      Assert.AreEqual<int>(0, _stn.Count);
      Assert.IsNotNull(_stn.ErrorList);
      Assert.AreEqual<int>(0, _stn.ErrorList.Count);
      Assert.AreEqual<string>("", _stn.HelpTopicName);
      Assert.AreEqual<string>(Directory.GetCurrentDirectory(), _stn.HomeDirectory.BaseDirectory);
      Assert.IsFalse(_stn.IsReadOnly);
      Assert.AreEqual<string>(_solutionData.Object.Name, _stn.Name);
      Assert.AreEqual<NodeClassesEnum>(NodeClassesEnum.None, _stn.NodeClass);
      Assert.AreEqual<NodeTypeEnum>(NodeTypeEnum.SolutionNode, _stn.NodeType);
      Assert.IsNull(_stn.Parent);
      Assert.IsNotNull(_stn.Server);
      Assert.IsNotNull(_stn.SymbolicName);
      Assert.AreEqual<string>(_solutionData.Object.Name, _stn.Text);
      Assert.IsNull(_stn.ToolTipText);
      Assert.IsNotNull(_stn.Wrapper);
      Assert.IsInstanceOfType(_stn.Wrapper, typeof(Wrappers4ProperyGrid.UAModelDesignerSolutionWrapper));
      Assert.IsNotNull(_stn.Wrapper4PropertyGrid);
      Assert.IsInstanceOfType(_stn.Wrapper4PropertyGrid, typeof(Wrappers4ProperyGrid.UAModelDesignerSolutionWrapper));
      Libraries _libraries = null;
      _stn.GetLibraries(x => _libraries = x);
      Assert.IsNotNull(_libraries);
      Assert.AreEqual<int>(1, _libraries.Count);
      Assert.AreEqual<int>(1, _librariesCallCounter);
    }
  }
}