//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CAS.UA.Model.Designer.IO
{
  [TestClass]
  public class ConfigurationManagementUnitTest
  {
    [TestMethod]
    public void ConstructorTest()
    {
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.Setup(x => x.FileName).Returns("UAAddressSpaceModel");
      using (ConfigurationManagementFixture _newItem = new ConfigurationManagementFixture(_IFileDialogMock.Object))
      {
        Assert.IsFalse(_newItem.ChangesArePresent);
        Assert.IsTrue(String.IsNullOrEmpty(_newItem.DefaultDirectory));
        Assert.AreEqual<string>("UAAddressSpaceModel", _newItem.DefaultFileName);
      }
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Once);
      _IFileDialogMock.Verify(x => x.Dispose(), Times.Exactly(2));
    }
    [TestMethod]
    public void ChangesArePresentEventTest()
    {
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      using (ConfigurationManagementFixture _newItem = new ConfigurationManagementFixture(_IFileDialogMock.Object))
      {
        int OnModificationCounter = 0;
        _newItem.ChangesArePresentHasChanged += (x, y) => OnModificationCounter++;
        _newItem.SignalChanges();
        Assert.AreEqual<int>(1, OnModificationCounter);
        Assert.IsTrue(_newItem.ChangesArePresent);
      }
    }
    [TestMethod]
    public void DefaultFileNameTest()
    {
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      using (ConfigurationManagementFixture _newItem = new ConfigurationManagementFixture(_IFileDialogMock.Object))
      {
        int OnModificationCounter = 0;
        _newItem.DefaultFileNameHasChanged += (x, y) => OnModificationCounter++;
        _newItem.DefaultFileName = @"c:\\folder\file.name";
        Assert.AreEqual<int>(1, OnModificationCounter);
        Assert.IsTrue(String.IsNullOrEmpty(_newItem.DefaultDirectory));
        Assert.IsFalse(_newItem.ChangesArePresent);
      }
    }
    private class ConfigurationManagementFixture : ConfigurationManagement
    {
      public ConfigurationManagementFixture(IFileDialog mock) : base(new GraphicalUserInterfaceFixture(mock)) { }
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

    }
  }
}

