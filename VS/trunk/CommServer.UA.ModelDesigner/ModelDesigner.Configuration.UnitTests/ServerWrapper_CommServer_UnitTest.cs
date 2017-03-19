﻿//<summary>
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
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.IServerConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests
{

  /// <summary>
  ///This is a test class for ServerWrapperTest and is intended to contain all ServerWrapperTest Unit Tests
  ///</summary>
  [TestClass()]
  public class ServerWrapper_CommServer_UnitTest
  {

    [TestMethod]
    [ClassInitialize]
    public static void ConfigTest(TestContext context)
    {
      if (Directory.Exists(_dataPath))
        Directory.Delete(_dataPath);
      ContainerResources.ExampleSolutionInstallation(Path.Combine((Directory.GetCurrentDirectory()), _dataPath), (x, y) => Console.WriteLine(x));
    }
    [TestMethod]
    [DeploymentItem(@"CAS.CommServer.UA.ConfigurationEditor.ServerConfiguration.dll")]
    public void ServerWrapperConstructorTest()
    {
      Console.WriteLine(Directory.GetCurrentDirectory());
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
      ServerWrapper _sw = new ServerWrapper(_serverConfiguration, _pluginAssembly, new GraphicalUserInterface(), @"Plugin\DemoConfiguration\BoilerExample.uasconfig");
      Assert.IsNotNull(_sw);
      Assert.IsTrue(_configurationChanged);
    }
    //private instrumentation
    private class GraphicalUserInterface : IGraphicalUserInterface
    {
      public Action<string, string> MessageBoxShowError
      {
        get
        {
          throw new NotImplementedException();
        }
      }
      public Action<string, string> MessageBoxShowExclamation
      {
        get
        {
          throw new NotImplementedException();
        }
      }
      public Action<string, string> MessageBoxShowWarning
      {
        get
        {
          throw new NotImplementedException();
        }
      }
      public Func<IFileDialog> OpenFileDialogFunc
      {
        get
        {
          throw new NotImplementedException();
        }
      }
      public Func<IFolderBrowserDialog> OpenFolderBrowserDialogFunc
      {
        get
        {
          throw new NotImplementedException();
        }
      }
      public Func<IFileDialog> SaveFileDialogFuc
      {
        get
        {
          throw new NotImplementedException();
        }
      }
    }
    private const string _dataPath = "Plugin";
  }
}
