
using CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests.Instrumentation;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.IServerConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests
{

  [TestClass]
  public class ServerWrapper_UAOOI_UnitTest
  {
    //<package id = "UAOOI.Configuration.DataBindings" version="2.0.0-Alpha" targetFramework="net461" />
    [TestMethod]
    [DeploymentItem(@"TestData\", @"TestData\")]
    public void EnvironmentTest()
    {
      FileInfo _configurationFile = new FileInfo(_ConfigurationBaseFileName);
      Assert.IsTrue(_configurationFile.Exists);
      Instrumentation.ConfigurationBaseImplementation _serverConfiguration = new Instrumentation.ConfigurationBaseImplementation();
      Assert.IsNull(_serverConfiguration.CurrentConfiguration);
      Assert.AreEqual<string>("DefaultFileName.xxl", _serverConfiguration.DefaultFileName);
      bool _configurationChanged = false;
      _serverConfiguration.OnModified += (x, y) => _configurationChanged = y.ConfigurationFileChanged;
      _serverConfiguration.ReadConfiguration(_configurationFile);
      Assert.AreEqual<int>(1, _serverConfiguration.CurrentConfiguration.DataSets.Length);
    }
    [TestMethod]
    [DeploymentItem(@"TestData\", @"TestData\")]
    public void UAOOIDataBindingsTestMethod()
    {
      Assembly _pluginAssembly = Assembly.GetExecutingAssembly();
      IConfiguration _serverConfiguration = AssemblyHelpers.CreateInstance(_pluginAssembly);
      Assert.IsNotNull(_serverConfiguration);
      Assert.AreEqual<string>("DefaultFileName.xxl", _serverConfiguration.DefaultFileName);
      bool _configurationChanged = false;
      _serverConfiguration.OnModified += (x, y) => _configurationChanged = y.ConfigurationFileChanged;
      _serverConfiguration.CreateDefaultConfiguration();
      Assert.IsTrue(_configurationChanged);
      _configurationChanged = false;
      ServerWrapper _sw = new ServerWrapper(_serverConfiguration, _pluginAssembly, new GraphicalUserInterface(), _ConfigurationBaseFileName);
      Assert.IsNotNull(_sw);
      Assert.IsTrue(_configurationChanged);
    }
    private const string _ConfigurationBaseFileName = @"TestData\ConfigurationDataConsumer.xml";
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
    public object AssemblyHelper { get; private set; }
  }
}
