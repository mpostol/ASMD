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
  public class OPCFSolutionConfigurationManagementUnitTest
  {
    [TestMethod]
    public void NewSoliutionTest()
    {
      Mock<IGraphicalUserInterface> _gui = new Mock<IGraphicalUserInterface>();
      ISolutionConfigurationManagement _instance = SolutionConfigurationManagement.NewSoliution(_gui.Object);
      Assert.IsNotNull(_instance);
      Assert.IsFalse(_instance.ChangesArePresent);
      Assert.IsFalse(string.IsNullOrEmpty(_instance.DefaultDirectory));
      Assert.AreEqual<string>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), _instance.DefaultDirectory);
      Assert.AreEqual<string>("UAModelDesignerSolution", Path.GetFileName(_instance.DefaultFileName));
    }

    [TestMethod]
    public void CreateNewTest()
    {
      const string DefaultExt = "uamdsl";
      const string FileName = "UAModelDesignerSolution";
      const string Filter = "UA Model Designer Solution File (* .uamdsl)|*.uamdsl|UA Model Designer Solution File (* .xml)|*.xml|All files(*.*)|*.*";
      const string Title = "UA Model Designer Solution Open/Save dialog window";
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupProperty(x => x.FileName);
      _IFileDialogMock.SetupProperty(x => x.DefaultExt);
      _IFileDialogMock.SetupProperty(x => x.Filter);
      _IFileDialogMock.SetupProperty(x => x.Title);
      _IFileDialogMock.Setup(x => x.ShowDialog()).Returns(true);
      Mock<IGraphicalUserInterface> _guiMock = new Mock<IGraphicalUserInterface>();
      _guiMock.SetupGet(x => x.OpenFileDialogFunc).Returns(() => _IFileDialogMock.Object);
      ISolutionConfigurationManagement _instance = SolutionConfigurationManagement.OpenExisting(_guiMock.Object);
      _IFileDialogMock.VerifySet(x => x.DefaultExt = DefaultExt);
      _IFileDialogMock.VerifySet(x => x.Filter = Filter);
      _IFileDialogMock.VerifySet(x => x.Title = Title);
      _IFileDialogMock.VerifySet(x => x.FileName = FileName, Times.Never);
      _IFileDialogMock.Verify(x => x.ShowDialog(), Times.Once);
      Assert.IsNull(_instance);
    }
  }
}