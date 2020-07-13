//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.IServerConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests
{
  [TestClass]
  [DeploymentItem(@"TestData\", @"TestData")]
  public class ConfigurationWrapperUnitTest
  {
    [TestMethod]
    public void DeploymentTest()
    {
      Assert.IsTrue(File.Exists(ConfigurationPath));
    }

    [TestMethod]
    public void ConstructorTest()
    {
      FileInfo _configurationFileInfor = new FileInfo(ConfigurationPath);
      Mock<IConfiguration> _iConfigurationMock = new Mock<IConfiguration>();
      Mock<IGraphicalUserInterface> _iGraphicalUserInterface = new Mock<IGraphicalUserInterface>();
      ConfigurationWrapper _underTestItem = new ConfigurationWrapper(_configurationFileInfor, _iConfigurationMock.Object, _iGraphicalUserInterface.Object);
      Assert.AreSame(_configurationFileInfor, _underTestItem.ConfigurationFile);
      Assert.AreEqual<string>(ConfigurationPath, _underTestItem.ConfigurationFile.FullName);
    }

    [TestMethod]
    public void SaveTest()
    {
      FileInfo _fileInforFixture = new FileInfo(ConfigurationPath);
      Mock<IConfiguration> _iConfigurationMock = new Mock<IConfiguration>();
      _iConfigurationMock.Setup(x => x.SaveConfiguration(It.IsAny<string>(), _fileInforFixture));
      Mock<IGraphicalUserInterface> _iGraphicalUserInterface = new Mock<IGraphicalUserInterface>();
      ConfigurationWrapper _underTestItem = new ConfigurationWrapper(_fileInforFixture, _iConfigurationMock.Object, _iGraphicalUserInterface.Object);
      Assert.AreEqual<string>(ConfigurationPath, _underTestItem.ConfigurationFile.FullName);
      _underTestItem.Save("wrong_path");
      _iConfigurationMock.Verify(x => x.SaveConfiguration("wrong_path", _fileInforFixture), Times.Once);
      Assert.AreEqual<string>(ConfigurationPath, _underTestItem.ConfigurationFile.FullName);
    }

    [TestMethod]
    public void GetPluginMenuItemsTest()
    {
      FileInfo _fileInforFixture = new FileInfo(ConfigurationPath);
      Mock<IConfiguration> _iConfigurationMock = new Mock<IConfiguration>();
      _iConfigurationMock.Setup(x => x.SaveConfiguration(It.IsAny<string>(), _fileInforFixture));
      Mock<IGraphicalUserInterface> _iGraphicalUserInterface = new Mock<IGraphicalUserInterface>();
      ConfigurationWrapper _underTestItem = new ConfigurationWrapper(_fileInforFixture, _iConfigurationMock.Object, _iGraphicalUserInterface.Object);
      List<ToolStripItem> _menuItems = new List<ToolStripItem>();
      _underTestItem.GetPluginMenuItems(_menuItems);
      Assert.AreEqual<int>(1, _menuItems.Count);
      Assert.AreEqual<int>(5, ((ToolStripMenuItem)_menuItems[0]).DropDownItems.Count);
      Assert.AreEqual<string>("Save", ((ToolStripMenuItem)_menuItems[0]).DropDownItems[2].Text);
      ((ToolStripMenuItem)_menuItems[0]).DropDownItems[2].PerformClick();
      _underTestItem.SetHomeDirectory(@"C:\x\y\z");
      ((ToolStripMenuItem)_menuItems[0]).DropDownItems[2].PerformClick();
      _iConfigurationMock.Verify(x => x.SaveConfiguration(null, _fileInforFixture), Times.Once);
      _iConfigurationMock.Verify(x => x.SaveConfiguration(@"C:\x\y\z", _fileInforFixture), Times.Once);
    }

    private readonly string ConfigurationPath = Path.Combine(Directory.GetCurrentDirectory(), @"TestData\BoilerExample.uasconfig");
  }
}