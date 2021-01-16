//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using UAOOI.Configuration.Core;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests
{
  [TestClass]
  public class ServerWrapperUnitTest
  {
    [TestMethod]
    public void ConstructorParametersTest()
    {
      Mock<IDataProviderDescription> _IDataProviderDescriptionMock = new Mock<IDataProviderDescription>();
      Mock<IGraphicalUserInterface> _guiMock = new Mock<IGraphicalUserInterface>();
      Mock<IConfiguration> _IConfigurationMock = new Mock<IConfiguration>();
      Assert.ThrowsException<ArgumentNullException>(() => new ServerWrapper(null, _IDataProviderDescriptionMock.Object, _guiMock.Object, "configuratioRelativePat.extension"));
      Assert.ThrowsException<ArgumentNullException>(() => new ServerWrapper(_IConfigurationMock.Object, null, _guiMock.Object, "configuratioRelativePat.extension"));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ServerWrapper(_IConfigurationMock.Object, _IDataProviderDescriptionMock.Object, _guiMock.Object, "configuratioRelativePat.extension"));
    }

    [TestMethod]
    public void ConstructorTest()
    {
      const string _defaultConfigurationFileName = "DefaultFileName.tst";
      Mock<IConfiguration> _IConfigurationMock = new Mock<IConfiguration>();
      _IConfigurationMock.SetupGet<string>(x => x.DefaultFileName).Returns(_defaultConfigurationFileName);
      _IConfigurationMock.Setup(x => x.SaveConfiguration(It.IsAny<string>(), It.IsAny<FileInfo>()));
      Mock<IDataProviderDescription> _IDataProviderDescriptionMock = new Mock<IDataProviderDescription>();
      Mock<IGraphicalUserInterface> _guiMock = new Mock<IGraphicalUserInterface>();

      Mock<IFileDialog> _openFileDialogMock = new Mock<IFileDialog>();
      Mock<IFolderBrowserDialog> _IFolderBrowserDialog = new Mock<IFolderBrowserDialog>();
      List<string> _message = new List<string>();
      List<string> _caption = new List<string>();
      _guiMock.Setup(x => x.MessageBoxShowWarning);
      _guiMock.SetupGet(x => x.MessageBoxShowExclamation).Returns(() => (message, caption) => { _message.Add(message); _caption.Add(caption); });
      _guiMock.SetupGet(x => x.OpenFileDialogFunc).Returns(() => () => _openFileDialogMock.Object);
      _guiMock.SetupGet(x => x.OpenFolderBrowserDialogFunc).Returns(() => () => _IFolderBrowserDialog.Object);
      _guiMock.SetupGet(x => x.MessageBoxShowError).Returns(() => (message, caption) => { _message.Add(message); _caption.Add(caption); });

      ServerWrapper _instanceUnderTest = new ServerWrapper(_IConfigurationMock.Object, _IDataProviderDescriptionMock.Object, _guiMock.Object);

      _IConfigurationMock.Verify(x => x.SaveConfiguration("", It.IsAny<FileInfo>()), Times.Once);
      _guiMock.VerifyGet(x => x.MessageBoxShowError, Times.Never);
      Assert.AreEqual<int>(2, _message.Count);
      CollectionAssert.AreEqual(
        new string[] { "You did not choose the configuration file. Please select a location of the default configuration file.", "Folder is not selected, configuration will be created in the default location." },
        _message.ToArray());

      //Configuration
      Assert.IsNotNull(_instanceUnderTest.Configuration);
      Assert.IsNotNull(_instanceUnderTest.Configuration.ConfigurationFile);
      Assert.AreEqual<string>(Path.Combine(Directory.GetCurrentDirectory(), _defaultConfigurationFileName), _instanceUnderTest.Configuration.ConfigurationFile.FullName);
      //PluginDescription
      Assert.IsNotNull(_instanceUnderTest.PluginDescription);
      Assert.AreSame(_IDataProviderDescriptionMock.Object, _instanceUnderTest.PluginDescription);
      IConfiguration _configurationEditor = _instanceUnderTest.GetServerConfiguration;
      Assert.IsNotNull(_configurationEditor);
      Assert.AreEqual(_IConfigurationMock.Object, _configurationEditor);
    }
  }
}