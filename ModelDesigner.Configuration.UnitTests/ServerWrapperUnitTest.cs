//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using System.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.IServerConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests
{
  [TestClass]
  public class ServerWrapperUnitTest
  {
    [TestMethod]
    public void ConstructorTest()
    {
      Mock<IConfiguration> m_IConfigurationMock = new Mock<IConfiguration>();
      Mock<IDataProviderDescription> _IDataProviderDescriptionMock = new Mock<IDataProviderDescription>();
      Mock<IGraphicalUserInterface> _guiMock = new Mock<IGraphicalUserInterface>();
      Mock<ISolutionDirectoryPathManagement> _directoryMock = new Mock<ISolutionDirectoryPathManagement>();
      _directoryMock.SetupGet<string>(x => x.DefaultDirectory).Returns(@"C:\x\c\v");
      ServerWrapper _instanceUnderTest = new ServerWrapper(m_IConfigurationMock.Object, _IDataProviderDescriptionMock.Object, _guiMock.Object, _directoryMock.Object, "configuratioRelativePat.extension");
      _directoryMock.VerifyGet(x => x.DefaultDirectory, Times.Once);
      Assert.IsNotNull(_instanceUnderTest.Configuration.ConfigurationFile);
      Assert.AreEqual<string>(@"C:\x\c\v\configuratioRelativePat.extension", _instanceUnderTest.Configuration.ConfigurationFile.FullName);
      Assert.IsNotNull(_instanceUnderTest.Configuration);
      Assert.AreSame(_IDataProviderDescriptionMock.Object, _instanceUnderTest.PluginDescription);
      Assert.AreSame(_directoryMock.Object, _instanceUnderTest.SolutionPath);

    }
  }
}
