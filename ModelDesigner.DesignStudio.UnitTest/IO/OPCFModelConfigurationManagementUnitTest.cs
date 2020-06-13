//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
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
    public void CreateNewTest()
    {
      Mock<ISolutionConfigurationManagement> _solutionMock = new Mock<ISolutionConfigurationManagement>();
      _solutionMock.SetupGet(x => x.SolutionDirectoryPathManagement).Returns(new SolutionDirectoryPathManagementBaseFixture());
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupGet(x => x.FileName).Throws<ApplicationException>();
      _IFileDialogMock.SetupGet(x => x.InitialDirectory).Throws<ApplicationException>();
      IOPCFModelConfigurationManagement _newItem = OPCFModelConfigurationManagement.CreateNew(_solutionMock.Object, new GraphicalUserInterface(_IFileDialogMock.Object), "projectName");
      Assert.IsNotNull(_newItem.ModelDesign);
      Assert.AreEqual<string>("projectName", _newItem.Name);
      Assert.IsNotNull(_newItem.UAModelDesignerProject);
      Assert.AreEqual<string>(@"C:\a\b\c\projectName", _newItem.UAModelDesignerProject.BuildOutputDirectoryName);
      Assert.AreEqual<string>("projectName.xml", _newItem.UAModelDesignerProject.FileName);
      Assert.AreEqual<string>("projectName", _newItem.UAModelDesignerProject.Name);
      //_IFileDialogMock
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Never);
      _IFileDialogMock.Verify(x => x.FileName, Times.Never);
      _IFileDialogMock.Verify(x => x.Filter, Times.Never);
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Never);
      _IFileDialogMock.Verify(x => x.Title, Times.Never);
    }

    //TODO Changing of the solution location doesn't recalculate the projects paths #134
    //[TestMethod]
    //public void ChangeSolutionBaseDirectioryTest()
    //{
    //  Mock<ISolutionConfigurationManagement> _solutionMock = new Mock<ISolutionConfigurationManagement>();
    //  _solutionMock.SetupGet(x => x.SolutionDirectoryPathManagement).Returns(new SolutionDirectoryPathManagementBaseFixture());
    //  Mock<IGraphicalUserInterface> _graphicalUIMock = new Mock<IGraphicalUserInterface>();
    //  //SolutionDirectoryPathManagement _pathManagement = new SolutionDirectoryPathManagement(_solutionMock);
    //  //_pathManagement.SetNewPath(@"C:\a\c\d");
    //  IOPCFModelConfigurationManagement _projectTreeNode = OPCFModelConfigurationManagement.CreateNew(_solutionMock.Object, _graphicalUIMock.Object, @"C:\VS.git\UAOOI\OPC-UA-OOI");
    //  //_pathManagement.SetNewPath(@"C:\a\c");
    //  Assert.IsTrue(_projectTreeNode.UAModelDesignerProject.FileName.StartsWith(@"..\d\Model_"), _projectTreeNode.UAModelDesignerProject.FileName);
    //}

    [TestMethod]
    public void OpenExistingModelTest()
    {
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.BaseDirectory).Returns(Directory.GetCurrentDirectory());
      UAModelDesignerProject _projectDescriptor = new UAModelDesignerProject()
      {
        BuildOutputDirectoryName = string.Empty,
        CSVFileName = "CSVFileName",
        FileName = "15064369 - 0B00 - 4CA8 - BB0A - AB486AFCCA38",
        Name = "TestProjectDescription",
        ProjectIdentifier = Guid.NewGuid().ToString()
      };
      Mock<ISolutionConfigurationManagement> _solutionMock = new Mock<ISolutionConfigurationManagement>();
      _solutionMock.SetupGet(x => x.SolutionDirectoryPathManagement).Returns(new SolutionDirectoryPathManagementBaseFixture());
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupGet(x => x.FileName).Throws<ApplicationException>();
      _IFileDialogMock.SetupGet(x => x.InitialDirectory).Throws<ApplicationException>();
      IOPCFModelConfigurationManagement _newItem;
      Assert.ThrowsException<ArgumentNullException>(() => _newItem = OPCFModelConfigurationManagement.ImportModelDesign(null, new GraphicalUserInterface(_IFileDialogMock.Object), _projectDescriptor));
      Assert.ThrowsException<ArgumentNullException>(() => _newItem = OPCFModelConfigurationManagement.ImportModelDesign(_solutionMock.Object, null, _projectDescriptor));
      Assert.ThrowsException<ArgumentNullException>(() => _newItem = OPCFModelConfigurationManagement.ImportModelDesign(_solutionMock.Object, new GraphicalUserInterface(_IFileDialogMock.Object), null));
      Assert.ThrowsException<FileNotFoundException>(() => _newItem = OPCFModelConfigurationManagement.ImportModelDesign(_solutionMock.Object, new GraphicalUserInterface(_IFileDialogMock.Object), _projectDescriptor));
    }

    private class SolutionDirectoryPathManagementBaseFixture : CAS.CommServer.UA.ModelDesigner.Configuration.IO.SolutionDirectoryPathManagementBase
    {
      public SolutionDirectoryPathManagementBaseFixture() : base(@"C:\a\b\c")
      {
      }
    }

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