//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.IO
{
  [TestClass]
  [DeploymentItem(@"TestData\", @"TestData")]
  public class SolutionConfigurationManagementtUnitTest
  {
    [TestMethod]
    public void ConfigurationFileExistsTest()
    {
      Assert.IsTrue(Directory.Exists("TestData"), $"{Directory.GetCurrentDirectory()}");
      Assert.IsTrue(File.Exists(@"TestData\EmptySolution.uamdsl"));
    }

    [TestMethod]
    public void NewSoliutionTest()
    {
      Mock<IGraphicalUserInterface> _gui = new Mock<IGraphicalUserInterface>();
      _gui.SetupGet(x => x.MessageBoxShowWarningAskYN).Returns(() => (x, y) => true);
      int _eventCounter = 0;
      ISolutionConfigurationManagement _newSolution = null;
      SolutionConfigurationManagementRoot.DefaultInstance.AfterSolutionChange += (x, y) => { _eventCounter++; _newSolution = y.Solution; Assert.AreSame(x, SolutionConfigurationManagementRoot.DefaultInstance); };
      ISolutionConfigurationManagement _instance = null;
      SolutionConfigurationManagementRoot.DefaultInstance.AfterSolutionChange += (x, y) => _instance = y.Solution;
      SolutionConfigurationManagementRoot.NewSoliution(_gui.Object);
      Assert.IsNotNull(_instance);
      Assert.IsTrue(_instance.ChangesArePresent);
      Assert.IsFalse(string.IsNullOrEmpty(_instance.DefaultDirectory));
      Assert.AreEqual<string>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), _instance.DefaultDirectory);
      Assert.AreEqual<string>("UAModelDesignerSolution", Path.GetFileName(_instance.DefaultFileName));
    }

    [TestMethod]
    public void OpenExistingSkippedTest()
    {
      const string DefaultExt = "uamdsl";
      const string Filter = "UA Model Designer Solution File (* .uamdsl)|*.uamdsl|UA Model Designer Solution File (* .xml)|*.xml|All files(*.*)|*.*";
      const string Title = "UA Model Designer Solution Open/Save dialog window";
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupProperty(x => x.DefaultExt);
      _IFileDialogMock.SetupProperty(x => x.Filter);
      _IFileDialogMock.SetupProperty(x => x.Title);
      _IFileDialogMock.Setup(x => x.ShowDialog()).Returns(false);
      Mock<IGraphicalUserInterface> _guiMock = new Mock<IGraphicalUserInterface>();
      _guiMock.SetupGet(x => x.OpenFileDialogFunc).Returns(() => _IFileDialogMock.Object);
      _guiMock.SetupGet(x => x.MessageBoxShowWarningAskYN).Returns(() => (x, y) => true);
      ISolutionConfigurationManagement _instance = null;
      SolutionConfigurationManagementRoot.DefaultInstance.AfterSolutionChange += (x, y) => _instance = y.Solution;
      SolutionConfigurationManagementRoot.OpenExisting(null, _guiMock.Object);
      _IFileDialogMock.VerifySet(x => x.DefaultExt = DefaultExt, Times.Once);
      _IFileDialogMock.VerifySet(x => x.Filter = Filter, Times.Once);
      _IFileDialogMock.VerifySet(x => x.Title = Title, Times.Once);
      _IFileDialogMock.VerifySet(x => x.FileName = It.IsAny<string>(), Times.Never);
      _IFileDialogMock.VerifySet(x => x.InitialDirectory = It.IsAny<string>(), Times.Never);
      _IFileDialogMock.Verify(x => x.ShowDialog(), Times.Once);
      _IFileDialogMock.Verify(x => x.Dispose(), Times.Once);
    }
    [TestMethod]
    public void OpenExistingFileExistTest()
    {
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.Setup(x => x.ShowDialog()).Returns(false);
      Mock<IGraphicalUserInterface> _guiMock = new Mock<IGraphicalUserInterface>();
      _guiMock.SetupSet(x => x.UseWaitCursor = It.IsAny<bool>());
      _guiMock.SetupGet(x => x.OpenFileDialogFunc).Returns(() => _IFileDialogMock.Object);
      _guiMock.SetupGet(x => x.MessageBoxShowWarningAskYN).Returns(() => (x, y) => true);
      ISolutionConfigurationManagement _instance = null;
      SolutionConfigurationManagementRoot.DefaultInstance.AfterSolutionChange += (x, y) => _instance = y.Solution;
      SolutionConfigurationManagementRoot.OpenExisting(@"TestData\EmptySolution.uamdsl", _guiMock.Object);
      Assert.IsNotNull(_instance);
      Assert.IsFalse(_instance.ChangesArePresent);
      Assert.AreEqual<string>(Path.Combine(Directory.GetCurrentDirectory(), @"TestData\EmptySolution.uamdsl"), _instance.DefaultFileName);
      _IFileDialogMock.Verify(x => x.DefaultExt, Times.Never);
      _IFileDialogMock.Verify(x => x.Filter, Times.Never);
      _IFileDialogMock.Verify(x => x.Title, Times.Never);
      _IFileDialogMock.Verify(x => x.FileName, Times.Never);
      _IFileDialogMock.VerifySet(x => x.InitialDirectory = It.IsAny<string>(), Times.Never);
      _IFileDialogMock.Verify(x => x.ShowDialog(), Times.Never);
      _IFileDialogMock.Verify(x => x.Dispose(), Times.Never);
      _guiMock.Verify(x => x.MessageBoxShowWarningAskYN, Times.Never);
      _guiMock.VerifySet(x => x.UseWaitCursor = It.IsAny<bool>(), Times.Exactly(2));
    }
  }
}