//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.IO
{
  [TestClass]
  [DeploymentItem(@"TestData\", @"TestData")]
  [DeploymentItem(@"exe\", @"exe")]
  public class ProjectConfigurationManagementUnitTest
  {
    [TestMethod]
    public void ConfigurationFileExistsTest()
    {
      Assert.IsTrue(Directory.Exists(m_TestSolutionPath), $"{Directory.GetCurrentDirectory()}");
      Assert.IsTrue(File.Exists(m_TestProjectPath));
      string _compilerPath = Path.Combine(Directory.GetCurrentDirectory(), @"exe\CAS.CommServer.UA.ModelCompiler.Command.exe");
      Assert.IsTrue(File.Exists(_compilerPath));
    }

    [TestMethod]
    public void CreateNewTest()
    {
      Mock<ISolutionConfigurationManagement> _solutionMock = new Mock<ISolutionConfigurationManagement>();
      _solutionMock.SetupGet(x => x.DefaultDirectory).Returns(@"C:\a\b\c\");
      _solutionMock.Setup(x => x.DefaultFileName);
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupGet(x => x.FileName).Throws<ApplicationException>();
      _IFileDialogMock.SetupGet(x => x.InitialDirectory).Throws<ApplicationException>();
      _IFileDialogMock.Setup(x => x.Dispose());
      _IFileDialogMock.Setup(x => x.ShowDialog());
      IProjectConfigurationManagement _newItem = ProjectConfigurationManagement.CreateNew(_solutionMock.Object, new GraphicalUserInterface(_IFileDialogMock.Object), "projectName");
      Assert.IsTrue(((ProjectConfigurationManagement)_newItem).ChangesArePresent);
      Assert.IsNotNull(_newItem.ModelDesign);
      Assert.AreEqual<string>("projectName", _newItem.Name);
      Assert.AreEqual<string>(@"C:\a\b\c", _newItem.DefaultDirectory);
      Assert.AreEqual<string>(@"C:\a\b\c\projectName.xml", _newItem.DefaultFileName);
      CheckConsistency(_newItem.UAModelDesignerProject);
      //_solutionMock
      _solutionMock.Verify(x => x.DefaultDirectory, Times.AtLeastOnce);
      _solutionMock.Verify(x => x.DefaultFileName, Times.Never);
      //_IFileDialogMock
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Never);
      _IFileDialogMock.Verify(x => x.FileName, Times.Never);
      _IFileDialogMock.Verify(x => x.Filter, Times.Never);
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Never);
      _IFileDialogMock.Verify(x => x.Title, Times.Never);
      _IFileDialogMock.Verify(x => x.ShowDialog(), Times.Never);
      _IFileDialogMock.Verify(x => x.Dispose(), Times.Never);
    }

    [TestMethod]
    public void SaveNewTest()
    {
      //TODO Creating new project the existing one should not be overridden #174
      string _solutionPath = Path.Combine(Directory.GetCurrentDirectory(), "TestData");
      Mock<ISolutionConfigurationManagement> _solutionMock = new Mock<ISolutionConfigurationManagement>();
      _solutionMock.SetupGet(x => x.DefaultDirectory).Returns(_solutionPath);
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      Mock<IGraphicalUserInterface> _guiMock = new Mock<IGraphicalUserInterface>();
      _guiMock.SetupGet(z => z.OpenFileDialogFunc).Returns(() => _IFileDialogMock.Object);
      _guiMock.SetupSet(z => z.UseWaitCursor = It.IsAny<bool>());
      IProjectConfigurationManagement _newItem = ProjectConfigurationManagement.CreateNew(_solutionMock.Object, _guiMock.Object, "projectName");
      Assert.IsTrue(((ProjectConfigurationManagement)_newItem).ChangesArePresent);
      Assert.IsNotNull(_newItem.ModelDesign);
      Assert.AreEqual<string>("projectName", _newItem.Name);
      Assert.IsNotNull(_newItem.UAModelDesignerProject);
      _solutionMock.Verify(x => x.DefaultDirectory, Times.AtLeastOnce);
      _solutionMock.Verify(x => x.DefaultFileName, Times.Never);
      ModelDesign _modelDesign = new ModelDesign
      {
        Namespaces = new Namespace[] { new Namespace() { Name = "Namespace" } }
      };
      //test save
      _newItem.Save(_modelDesign);
      _solutionMock.Verify(x => x.DefaultDirectory, Times.AtLeastOnce);
      _solutionMock.Verify(x => x.DefaultFileName, Times.Never);
      _guiMock.VerifySet(x => x.UseWaitCursor = true, Times.Once);
      _guiMock.VerifySet(x => x.UseWaitCursor = false, Times.Once);
      Assert.IsTrue(File.Exists(Path.Combine(_solutionPath, "projectName.xml")));
      //_IFileDialogMock
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Never);
      _IFileDialogMock.Verify(x => x.FileName, Times.Never);
      _IFileDialogMock.Verify(x => x.Filter, Times.Never);
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Never);
      _IFileDialogMock.Verify(x => x.Title, Times.Never);
      _IFileDialogMock.Verify(x => x.ShowDialog(), Times.Never);
      _IFileDialogMock.Verify(x => x.Dispose(), Times.Never);
    }

    [TestMethod]
    public void OpenExistingModelFailedTest()
    {
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.DefaultDirectory).Returns(Directory.GetCurrentDirectory());
      UAModelDesignerProject _projectDescriptor = new UAModelDesignerProject()
      {
        BuildOutputDirectoryName = string.Empty,
        CSVFileName = "CSVFileName",
        FileName = "15064369 - 0B00 - 4CA8 - BB0A - AB486AFCCA38",
        Name = "TestProjectDescription",
        ProjectIdentifier = Guid.NewGuid().ToString()
      };
      Mock<ISolutionConfigurationManagement> _solutionMock = new Mock<ISolutionConfigurationManagement>();
      _solutionMock.SetupGet(x => x.DefaultDirectory).Returns(@"C:\a\b\c\");
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupGet(x => x.FileName).Throws<ApplicationException>();
      _IFileDialogMock.SetupGet(x => x.InitialDirectory).Throws<ApplicationException>();
      IProjectConfigurationManagement _newItem;
      Assert.ThrowsException<ArgumentNullException>(() => _newItem = ProjectConfigurationManagement.ImportModelDesign(null, new GraphicalUserInterface(_IFileDialogMock.Object), _projectDescriptor));
      Assert.ThrowsException<ArgumentNullException>(() => _newItem = ProjectConfigurationManagement.ImportModelDesign(_solutionMock.Object, null, _projectDescriptor));
      Assert.ThrowsException<ArgumentNullException>(() => _newItem = ProjectConfigurationManagement.ImportModelDesign(_solutionMock.Object, new GraphicalUserInterface(_IFileDialogMock.Object), null));
      Assert.ThrowsException<FileNotFoundException>(() => _newItem = ProjectConfigurationManagement.ImportModelDesign(_solutionMock.Object, new GraphicalUserInterface(_IFileDialogMock.Object), _projectDescriptor));
    }

    [TestMethod]
    public void OpenExistingModel()
    {
      Mock<ISolutionConfigurationManagement> _solutionMock = new Mock<ISolutionConfigurationManagement>();
      _solutionMock.SetupGet(x => x.DefaultDirectory).Returns(m_TestSolutionPath);
      Mock<IGraphicalUserInterface> _guiuMocck = new Mock<IGraphicalUserInterface>();
      UAModelDesignerProject _projectDescriptor = new UAModelDesignerProject()
      {
        BuildOutputDirectoryName = "15064369 - 0B00 - 4CA8 - BB0A - AB486AFCCA38",
        CSVFileName = "CSVFileName",
        FileName = @"DemoConfiguration\BoilerType.xml",
        Name = "TestProjectDescription",
        ProjectIdentifier = Guid.NewGuid().ToString()
      };
      IProjectConfigurationManagement _newItemUnderTest = ProjectConfigurationManagement.ImportModelDesign(_solutionMock.Object, _guiuMocck.Object, _projectDescriptor);
      Assert.IsNotNull(_newItemUnderTest);
      Assert.AreEqual<string>(Path.Combine(Path.Combine(m_TestSolutionPath, "DemoConfiguration")), _newItemUnderTest.DefaultDirectory);
      Assert.AreEqual<string>(m_TestProjectPath, _newItemUnderTest.DefaultFileName);
      Assert.IsNotNull(_newItemUnderTest.ModelDesign);
      Assert.AreEqual<string>(@"http://tempuri.org/UA/Examples/BoilerType", _newItemUnderTest.ModelDesign.TargetNamespace);
      Assert.AreEqual<string>("TestProjectDescription", _newItemUnderTest.Name);
      Assert.IsNotNull(_newItemUnderTest.UAModelDesignerProject);
      Assert.AreEqual<string>(@"DemoConfiguration\BoilerType.xml", _newItemUnderTest.UAModelDesignerProject.FileName);
    }

    [TestMethod]
    public void BuildTest()
    {
      Mock<ISolutionConfigurationManagement> _solutionMock = new Mock<ISolutionConfigurationManagement>();
      _solutionMock.SetupGet(x => x.DefaultDirectory).Returns(m_TestSolutionPath);
      Mock<IGraphicalUserInterface> _guiuMocck = new Mock<IGraphicalUserInterface>();
      _guiuMocck.SetupGet(x => x.MessageBoxShowWarningAskYN).Returns(() => (t, c) => true);
      UAModelDesignerProject _projectDescriptor = _projectDescriptor = UAModelDesignerProject.CreateEmpty("BoilerType");
      _projectDescriptor.FileName = @"DemoConfiguration\BoilerType.xml";
      IProjectConfigurationManagement _newItemUnderTest = ProjectConfigurationManagement.ImportModelDesign(_solutionMock.Object, _guiuMocck.Object, _projectDescriptor);
      List<string> _log = new List<string>();
      _newItemUnderTest.Build(x => _log.Add(x));
      Assert.AreEqual<int>(4, _log.Count);
      Assert.IsTrue(Directory.Exists(Path.Combine(m_TestSolutionPath, @"DemoConfiguration\BoilerType")));
      Assert.AreEqual(7, Directory.GetFiles(Path.Combine(m_TestSolutionPath, @"DemoConfiguration\BoilerType")).Length);
    }

    #region instrumentation

    private static readonly string m_TestSolutionPath = Path.Combine(Directory.GetCurrentDirectory(), "TestData");
    private static readonly string m_TestProjectPath = Path.Combine(m_TestSolutionPath, @"DemoConfiguration\BoilerType.xml");

    private void CheckConsistency(UAModelDesignerProject uaModelDesignerProject)
    {
      Assert.IsNotNull(uaModelDesignerProject);
      Assert.AreEqual<string>(@"$(ProjectFileName)", uaModelDesignerProject.BuildOutputDirectoryName);
      Assert.AreEqual<string>("$(ProjectFileName).csv", uaModelDesignerProject.CSVFileName);
      Assert.AreEqual<string>(@"$(ProjectFileName).xml", uaModelDesignerProject.FileName);
      Assert.AreEqual<string>("projectName", uaModelDesignerProject.Name);
      Guid _projectIdentifier = Guid.Parse(uaModelDesignerProject.ProjectIdentifier);
      Assert.IsFalse(Guid.Empty == _projectIdentifier);
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

    #endregion instrumentation
  }
}