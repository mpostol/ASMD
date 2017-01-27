//<summary>
//  Title   : ServerWrapperTest
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.CommServer.UA.ConfigurationEditor.ModelsContainer;
using CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests.Instrumentation;
using CAS.UA.IServerConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests
{

  /// <summary>
  ///This is a test class for ServerWrapperTest and is intended
  ///to contain all ServerWrapperTest Unit Tests
  ///</summary>
  [TestClass()]
  public class ServerWrapper_CommServer_UnitTest
  {

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitialize]
    public static void ConfigTest(TestContext context)
    {
      if (Directory.Exists(_dataPath))
        Directory.Delete(_dataPath);
      ContainerResources.ExampleSolutionInstallation(Path.Combine((Directory.GetCurrentDirectory()), _dataPath), (x, y) => Console.WriteLine(x));
    }

    //<package id="CAS.CommServer.UA.Server.ServerConfiguration" version="3.20.1-Delta" targetFramework="net461" />
    [TestMethod]
    [DeploymentItem(@"CAS.CommServer.UA.ConfigurationEditor.ServerConfiguration.dll")]
    public void ServerWrapperConstructorTest()
    {
      Console.WriteLine(Directory.GetCurrentDirectory().ToString());
      FileInfo _defaultConfig = new FileInfo(@"Plugin\DemoConfiguration\DefaultConfig.xml");
      Assert.IsTrue(_defaultConfig.Exists);
      FileInfo _oses = new FileInfo(@"Plugin\DemoConfiguration\BoilerExample.oses");
      Assert.IsTrue(_oses.Exists);
      FileInfo _uasconfig = new FileInfo(@"Plugin\DemoConfiguration\BoilerExample.uasconfig");
      Assert.IsTrue(_uasconfig.Exists);
      Assembly _pluginAssembly;
      IConfiguration _serverConfiguration;
      AssemblyHelpers.CreateInstance(@"CAS.CommServer.UA.ConfigurationEditor.ServerConfiguration.dll", out _pluginAssembly, out _serverConfiguration);
      Assert.AreEqual<string>("CAS.UAServer.Configuration.uasconfig", _serverConfiguration.DefaultFileName);
      bool _configurationChanged = false;
      _serverConfiguration.OnModified += (x, y) => _configurationChanged = y.ConfigurationFileChanged;
      _serverConfiguration.CreateDefaultConfiguration();
      Assert.IsTrue(_configurationChanged);
      _configurationChanged = false;
      ServerWrapper _sw = new ServerWrapper(_serverConfiguration, _pluginAssembly, @"Plugin\DemoConfiguration\BoilerExample.uasconfig");
      Assert.IsNotNull(_sw);
      Assert.IsTrue(_configurationChanged);
    }


    private const string _dataPath = "Plugin";
  }
}
