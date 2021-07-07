//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.ToForms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

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
    public void ConstructorTest()
    {
      Mock<IGraphicalUserInterface> _IGraphicalUserInterface = new Mock<IGraphicalUserInterface>();
      Mock<ISolutionConfigurationManagement> _solutionManagement = new Mock<ISolutionConfigurationManagement>();
      _solutionManagement.SetupGet<string>(x => x.Name).Returns("Name");
      ServerSelector _serverSelector = new ServerSelector(_IGraphicalUserInterface.Object, _solutionManagement.Object, "", "");
      _solutionManagement.SetupGet<ServerSelector>(x => x.ServerSelector).Returns(_serverSelector);
      Mock<IMessageBoxHandling> _IMessageBoxHandlingMock = new Mock<IMessageBoxHandling>();
      int _librariesCallCounter = 0;
      Assert.ThrowsException<ArgumentNullException>(() => new SolutionTreeNode(null, _solutionManagement.Object, (x, y) => { Assert.Fail(); }, z => _librariesCallCounter++));
      Assert.ThrowsException<ArgumentNullException>(() => new SolutionTreeNode(_IMessageBoxHandlingMock.Object, null,  (x, y) => { Assert.Fail(); }, z => _librariesCallCounter++));
      SolutionTreeNode _instanceUnderTest = new SolutionTreeNode(_IMessageBoxHandlingMock.Object, _solutionManagement.Object, (x, y) => { Assert.Fail(); }, z => _librariesCallCounter++);
      //_IMessageBoxHandlingMock
      IMessageBoxHandling _assignedIMessageBoxHandling = null;
      _instanceUnderTest.GetMessageBoxHandling(x => _assignedIMessageBoxHandling = x);
      Assert.IsNotNull(_assignedIMessageBoxHandling);
      Assert.AreSame(_IMessageBoxHandlingMock.Object, _assignedIMessageBoxHandling);
      Assert.AreEqual<int>(0, _IMessageBoxHandlingMock.Invocations.Count);
      //State
      Assert.ThrowsException<NullReferenceException>(() => _instanceUnderTest.AvailiableNamespaces);
      Assert.AreEqual<int>(0, _instanceUnderTest.Count);
      Assert.IsNotNull(_instanceUnderTest.ErrorList);
      Assert.AreEqual<int>(0, _instanceUnderTest.ErrorList.Count);
      Assert.AreEqual<string>("", _instanceUnderTest.HelpTopicName);
      Assert.AreSame(_solutionManagement.Object, _instanceUnderTest.HomeDirectory);
      Assert.IsFalse(_instanceUnderTest.IsReadOnly());
      Assert.AreEqual<string>(_solutionManagement.Object.Name, _instanceUnderTest.Name);
      Assert.AreEqual<NodeClassesEnum>(NodeClassesEnum.None, _instanceUnderTest.NodeClass);
      Assert.AreEqual<NodeTypeEnum>(NodeTypeEnum.SolutionNode, _instanceUnderTest.NodeType);
      Assert.IsNull(_instanceUnderTest.Parent);
      Assert.IsNotNull(_instanceUnderTest.Server);
      Assert.AreSame(_serverSelector, _instanceUnderTest.Server);
      Assert.IsNotNull(_instanceUnderTest.SymbolicName);
      Assert.AreEqual<string>(_solutionManagement.Object.Name, _instanceUnderTest.Text);
      Assert.IsNull(_instanceUnderTest.ToolTipText);
      Assert.IsNotNull(_instanceUnderTest.Wrapper);
      Assert.IsInstanceOfType(_instanceUnderTest.Wrapper, typeof(Wrappers4ProperyGrid.UAModelDesignerSolutionWrapper));
      Assert.IsNotNull(_instanceUnderTest.Wrapper4PropertyGrid);
      Assert.IsInstanceOfType(_instanceUnderTest.Wrapper4PropertyGrid, typeof(Wrappers4ProperyGrid.UAModelDesignerSolutionWrapper));
      Libraries _libraries = null;
      _instanceUnderTest.GetLibraries(x => _libraries = x);
      Assert.IsNotNull(_libraries);
      Assert.AreEqual<int>(1, _libraries.Count);
      Assert.AreEqual<int>(1, _librariesCallCounter);
    }
  }
}