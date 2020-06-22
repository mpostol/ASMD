//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
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
      _newItem.SetFilePath(@"c:\\folder\file.name");
      Assert.AreEqual<int>(1, OnModificationCounter);
      Assert.IsFalse(String.IsNullOrEmpty(_newItem.DefaultDirectory));
      Assert.IsFalse(_newItem.ChangesArePresent);
      _IFileDialogMock.Verify(x => x.FileName, Times.Never);
      _IFileDialogMock.VerifySet(x => x.FileName = It.IsAny<string>(), Times.Never);
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
      _IFileDialogMock.SetupGet<string>(x => x.FileName).Returns(_defPath);
      _IFileDialogMock.SetupProperty(x => x.DefaultExt);
      _IFileDialogMock.SetupProperty(x => x.Filter);
      _IFileDialogMock.SetupProperty(x => x.Title);
      _IFileDialogMock.Setup(x => x.ShowDialog()).Returns(true);
      _IFileDialogMock.Setup(x => x.Dispose());
      Mock<IGraphicalUserInterface> _guiMock = new Mock<IGraphicalUserInterface>();
      _guiMock.SetupGet(x => x.OpenFileDialogFunc).Returns(() => _IFileDialogMock.Object);
      string _retPath = ConfigurationManagementFixture.ShowOpenDialog(_defPath, _guiMock.Object);
      _IFileDialogMock.VerifySet(x => x.DefaultExt = DefaultExt);
      _IFileDialogMock.VerifySet(x => x.FileName = FileName);
      _IFileDialogMock.VerifySet(x => x.Filter = Filter);
      _IFileDialogMock.VerifySet(x => x.Title = Title);
      _IFileDialogMock.VerifySet(x => x.InitialDirectory = Path.GetDirectoryName(_defPath));
      _IFileDialogMock.Verify(x => x.Dispose(), Times.Once);
      _IFileDialogMock.Verify(x => x.ShowDialog(), Times.Once);
      Assert.AreEqual<string>(_defPath, _retPath);
    }

    [TestMethod]
    public void ShowDialogSaveFileDialogTest()
    {
      const string DefaultExt = "uamdsl";
      const string Filter = "UA Model Designer Solution File (* .uamdsl)|*.uamdsl|UA Model Designer Solution File (* .xml)|*.xml|All files(*.*)|*.*";
      const string Title = "UA Model Designer Solution Open/Save dialog window";
      string _defPath = @"c:\a\b\c\d.e";
      string _altPath = @"c:\a\b\f\d.e";
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupProperty(x => x.FileName);
      _IFileDialogMock.SetupProperty(x => x.DefaultExt);
      _IFileDialogMock.SetupProperty(x => x.Filter);
      _IFileDialogMock.SetupProperty(x => x.Title);
      _IFileDialogMock.Setup(x => x.ShowDialog()).Returns(true);
      _IFileDialogMock.Setup(x => x.Dispose());
      _IFileDialogMock.SetupGet<string>(x => x.FileName).Returns(_altPath);
      ConfigurationManagementFixture _item = new ConfigurationManagementFixture(_IFileDialogMock.Object, _defPath);
      Assert.AreEqual<string>(_defPath, _item.DefaultFileName);
      int _eventCounter = 0;
      string NewDirectoryPath = String.Empty;
      string OldDirectoryPath = String.Empty;
      _item.DefaultFileNameHasChanged += (object sender, NewDirectoryPathEventArgs e) =>
        {
          _eventCounter++;
          Assert.AreSame(_item, sender);
          NewDirectoryPath = e.NewDirectoryPath;
          OldDirectoryPath = e.OldDirectoryPath;
        };
      Assert.AreEqual<string>(_defPath, _item.DefaultFileName);
      _item.SaveFixture();
      Assert.AreEqual<string>(_altPath, _item.DefaultFileName);
      Assert.AreEqual<int>(1, _eventCounter);
      Assert.AreEqual<string>(@"c:\a\b\f", NewDirectoryPath);
      Assert.AreEqual<string>(@"c:\a\b\c", OldDirectoryPath);
      _IFileDialogMock.VerifySet(x => x.DefaultExt = DefaultExt);
      _IFileDialogMock.VerifySet(x => x.Filter = Filter);
      _IFileDialogMock.VerifySet(x => x.Title = Title);
      _IFileDialogMock.VerifySet(x => x.FileName = Path.GetFileNameWithoutExtension(_defPath));
      _IFileDialogMock.VerifySet(x => x.InitialDirectory = Path.GetDirectoryName(_defPath));
      _IFileDialogMock.Verify(x => x.Dispose(), Times.Once);
      _IFileDialogMock.Verify(x => x.ShowDialog(), Times.Once);
    }

    [TestMethod]
    public void ShowDialogSaveFileDialogEmptyDefPathTest()
    {
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ConfigurationManagementFixture(_IFileDialogMock.Object, String.Empty));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ConfigurationManagementFixture(_IFileDialogMock.Object, null));
    }

    #region instrumentation

    private class ConfigurationManagementFixture : ConfigurationManagement
    {
      public ConfigurationManagementFixture(IFileDialog mock, string fileName) : base(fileName, false, new GraphicalUserInterfaceFixture(mock))
      {
      }

      internal void SetFilePath(string filePath)
      {
        DefaultFileName = filePath;
      }

      internal void SignalChanges()
      {
        base.SetChangesArePresent();
      }

      internal static string ShowOpenDialog(string defaultFileName, IGraphicalUserInterface graphicalUserInterface)
      {
        return ConfigurationManagement.ShowDialogOpenFileDialog(defaultFileName, graphicalUserInterface, SetupFileDialog);
      }

      internal void SaveFixture()
      {
        base.ShowDialogSaveFileDialog(SetupFileDialog);
      }
    }

    private static void SetupFileDialog(IFileDialog _dialog)
    {
      _dialog.DefaultExt = "uamdsl";
      _dialog.Filter = "UA Model Designer Solution File (* .uamdsl)|*.uamdsl|UA Model Designer Solution File (* .xml)|*.xml|All files(*.*)|*.*";
      _dialog.Title = "UA Model Designer Solution Open/Save dialog window";
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

    #endregion instrumentation
  }
}