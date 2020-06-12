//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.IO
{

  [TestClass]
  public class OPCFModelConfigurationManagementUnitTest
  {

    [TestMethod]
    public void ConstructorTest()
    {
      Mock<ISolutionConfigurationManagement> _solutionMock = new Mock<ISolutionConfigurationManagement>();
      string _defPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UAModelDesignerSolution");
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      Mock<UAModelDesignerProject> _solutionDescriptotMock = new Mock<UAModelDesignerProject>();
      _IFileDialogMock.SetupProperty(x => x.FileName);
      _IFileDialogMock.Setup(x => x.InitialDirectory).Returns("RandomText");
      OPCFModelConfigurationManagement _newItem = new OPCFModelConfigurationManagement(_solutionMock.Object,  new GraphicalUserInterface(_IFileDialogMock.Object), _solutionDescriptotMock.Object);
      _IFileDialogMock.VerifySet(x => x.FileName = It.IsAny<string>(), Times.Never);
      Assert.IsFalse(_newItem.ChangesArePresent);
      Assert.AreEqual<string>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), _newItem.DefaultDirectory);
      Assert.AreEqual<string>(_defPath, _newItem.DefaultFileName);
      Assert.IsFalse(String.IsNullOrEmpty(Path.GetPathRoot(_newItem.DefaultDirectory)));
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Never);
    }

    [TestMethod]
    public void ChangeSolutionBaseDirectioryTest1()
    {
      Mock<ISolutionConfigurationManagement> _solutionMock = new Mock<ISolutionConfigurationManagement>();
      Mock<IGraphicalUserInterface> _graphicalUIMock = new Mock<IGraphicalUserInterface>();
      //SolutionDirectoryPathManagement _pathManagement = new SolutionDirectoryPathManagement(_solutionMock);
      //_pathManagement.SetNewPath(@"C:\a\c\d");
      IOPCFModelConfigurationManagement _projectTreeNode = OPCFModelConfigurationManagement.CreateNew(_solutionMock.Object, _graphicalUIMock.Object, "A4DDBDBA - 4946 - 4A2D - 9ADD - AA22953EF6A6");
      //_pathManagement.SetNewPath(@"C:\a\c");
      Assert.IsTrue(_projectTreeNode.UAModelDesignerProject.FileName.StartsWith(@"..\d\Model_"), _projectTreeNode.UAModelDesignerProject.FileName);
    }

    //[TestMethod]
    //public void OpenExistingModelTest()
    //{
    //  Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
    //  _directory.SetupGet(x => x.BaseDirectory).Returns(Directory.GetCurrentDirectory());
    //  UAModelDesignerProject _projectDescriptor = new UAModelDesignerProject()
    //  {
    //    BuildOutputDirectoryName = string.Empty,
    //    CSVFileName = "CSVFileName",
    //    FileName = m_DemoConfigurationFilePath,
    //    Name = "TestProjectDescription",
    //    ProjectIdentifier = Guid.NewGuid().ToString()
    //  };
    //  ProjectTreeNode _openProject = ProjectTreeNode.(_directory.Object, _projectDescriptor);
    //}

    private class GraphicalUserInterface : IGraphicalUserInterface
    {

      private readonly IFileDialog m_Mock;
      public GraphicalUserInterface(IFileDialog @object)
      {
        this.m_Mock = @object;
      }
      public Action<string, string> MessageBoxShowWarning => throw new NotImplementedException();
      public Action<string, string> MessageBoxShowExclamation => throw new NotImplementedException();
      public Action<string, string> MessageBoxShowError => throw new NotImplementedException();
      public Func<IFileDialog> OpenFileDialogFunc => () => m_Mock;
      public Func<IFileDialog> SaveFileDialogFuc => () => m_Mock;
      public Func<IFolderBrowserDialog> OpenFolderBrowserDialogFunc => throw new NotImplementedException();
      public Func<string, string, bool> MessageBoxShowWarningAskYN => throw new NotImplementedException();
      public bool UseWaitCursor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
  }
}
