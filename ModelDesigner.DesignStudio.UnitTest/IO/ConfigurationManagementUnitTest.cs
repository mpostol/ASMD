//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;

namespace CAS.UA.Model.Designer.IO
{
  [TestClass]
  public class ConfigurationManagementUnitTest
  {
    [TestMethod]
    public void ConstructorTest()
    {
      string _defPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UAModelDesignerSolution.uax");
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupProperty<string>(x => x.FileName);
      ConfigurationManagementFixture _newItem = new ConfigurationManagementFixture(_IFileDialogMock.Object, _defPath);
      Assert.IsFalse(_newItem.ChangesArePresent);
      Assert.IsFalse(String.IsNullOrEmpty(_newItem.DefaultDirectory));
      Assert.AreEqual<string>("UAModelDesignerSolution.uax", Path.GetFileName(_newItem.DefaultFileName));
      Assert.IsFalse(String.IsNullOrEmpty(Path.GetPathRoot(_newItem.DefaultFileName)));
      _IFileDialogMock.Verify(x => x.FileName, Times.Never);
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Never);
      _IFileDialogMock.Verify(x => x.Dispose(), Times.Never);
    }
    [TestMethod]
    public void ChangesArePresentEventTest()
    {
      string _defPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UAModelDesignerSolution");
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      ConfigurationManagementFixture _newItem = new ConfigurationManagementFixture(_IFileDialogMock.Object, _defPath);
      int OnModificationCounter = 0;
      _newItem.ChangesArePresentHasChanged += (x, y) => OnModificationCounter++;
      Assert.IsFalse(_newItem.ChangesArePresent);
      _newItem.SignalChanges();
      Assert.AreEqual<int>(1, OnModificationCounter);
      Assert.IsTrue(_newItem.ChangesArePresent);
    }
    [TestMethod]
    public void DefaultFileNameTest()
    {
      string _defPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UAModelDesignerSolution");
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupProperty(x => x.FileName);
      ConfigurationManagementFixture _newItem = new ConfigurationManagementFixture(_IFileDialogMock.Object, _defPath);
      int OnModificationCounter = 0;
      _newItem.DefaultFileNameHasChanged += (x, y) => OnModificationCounter++;
      _newItem.DefaultFileName = @"c:\\folder\file.name";
      Assert.AreEqual<int>(1, OnModificationCounter);
      Assert.IsFalse(String.IsNullOrEmpty(_newItem.DefaultDirectory));
      Assert.IsFalse(_newItem.ChangesArePresent);
      _IFileDialogMock.Verify(x => x.FileName, Times.Never);
      _IFileDialogMock.VerifySet(x => x.FileName =It.IsAny<string>(), Times.Never);
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Never);
    }
    [TestMethod]
    public void ShowOpenDialogTestMethod()
    {
      const string DefaultExt = "uamdsl";
      const string FileName = "UAModelDesignerSolution";
      const string Filter = "UA Model Designer Solution File (* .uamdsl)|*.uamdsl|UA Model Designer Solution File (* .xml)|*.xml|All files(*.*)|*.*";
      const string Title = "UA Model Designer Solution Open/Save dialog window";
      string _defPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), FileName);
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupProperty(x => x.FileName);
      _IFileDialogMock.SetupProperty(x => x.DefaultExt);
      _IFileDialogMock.SetupProperty(x => x.Filter);
      _IFileDialogMock.SetupProperty(x => x.Title);
      _IFileDialogMock.Setup(x => x.ShowDialog()).Returns(true);
      ConfigurationManagementFixture _newItem = new ConfigurationManagementFixture(_IFileDialogMock.Object, _defPath);
      _newItem.ShowOpenDialog();
      _IFileDialogMock.VerifySet(x => x.DefaultExt = DefaultExt);
      _IFileDialogMock.VerifySet(x => x.Filter = Filter);
      _IFileDialogMock.VerifySet(x => x.Title = Title);
      Assert.AreEqual<string>(FileName, Path.GetFileName(_IFileDialogMock.Object.FileName));
    }

    #region instrumentation
    private class ConfigurationManagementFixture : ConfigurationManagement
    {
      protected override ConfigurationType Configuration => ConfigurationType.Solution;
      public ConfigurationManagementFixture(IFileDialog mock, string fileName) : base(new GraphicalUserInterfaceFixture(mock), fileName) { }
      internal void SignalChanges()
      {
        this.SetChangesArePresent();
      }
      public override void New()
      {
        throw new NotImplementedException();
      }
      public override bool Open()
      {
        throw new NotImplementedException();
      }
      internal void ShowOpenDialog()
      {
        this.ShowDialogOpenFileDialog();
      }
    }
    private class GraphicalUserInterfaceFixture : IGraphicalUserInterface
    {

      private readonly IFileDialog mock;
      public GraphicalUserInterfaceFixture(IFileDialog mock)
      {
        this.mock = mock;
      }
      public Action<string, string> MessageBoxShowWarning => throw new NotImplementedException();
      public Action<string, string> MessageBoxShowExclamation => throw new NotImplementedException();
      public Action<string, string> MessageBoxShowError => throw new NotImplementedException();
      public Func<IFileDialog> OpenFileDialogFunc => () => mock;
      public Func<IFileDialog> SaveFileDialogFuc => () => mock;
      public Func<IFolderBrowserDialog> OpenFolderBrowserDialogFunc => throw new NotImplementedException();
      public Func<string, string, bool> MessageBoxShowWarningAskYN => throw new NotImplementedException();
      public bool UseWaitCursor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
    #endregion

  }
}

