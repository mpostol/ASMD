//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ConfigurationEditor.ModelsContainer;
using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests
{
  [TestClass]
  public class ServerSelectorUnitTest
  {
    [ClassInitialize]
    public static void ConfigTest(TestContext context)
    {
      Console.WriteLine(Directory.GetCurrentDirectory());
      if (Directory.Exists(m_ExamplePath))
        Directory.Delete(m_ExamplePath, true);
      ContainerResources.ExampleSolutionInstallation(m_ExamplePath, (x, y) => Console.WriteLine(x));
    }

    [TestMethod]
    public void TestEnvironment()
    {
      Assert.IsTrue(File.Exists(m_PluginFullPath));
      Assert.IsTrue(File.Exists($@"{m_ExamplePath}\DemoConfiguration\DefaultConfig.xml"));
      Assert.IsTrue(File.Exists($@"{m_ExamplePath}\DemoConfiguration\BoilerExample.oses"));
      Assert.IsTrue(File.Exists($@"{m_ExamplePath}\DemoConfiguration\BoilerExample.uasconfig"));
      Assert.IsTrue(File.Exists($@"{m_ExamplePath}\CAS.CommServer.UA.ConfigurationEditor.ServerConfiguration.dll"));
    }

    [TestMethod]
    public void ConstructorWrongAssemblyTest()
    {
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.DefaultDirectory).Returns(Directory.GetCurrentDirectory());
      TestGraphicalUserInterface _tgi = new TestGraphicalUserInterface();
      ServerSelector _nss = new ServerSelector(_tgi, _directory.Object, "wrong.codebase", "wrong.configuration");
      //_nss
      Assert.IsNull(_nss.IServerConfiguration);
      Assert.IsNull(_nss.SelectedAssembly);
      Assert.IsNull(_nss.ServerConfiguration);
      //_tgi
      Assert.IsTrue(_tgi.WarningCalled);
      Assert.IsTrue(_tgi.WarningMessage.Contains("wrong.codebase"));
      Assert.AreEqual<string>("Open configuration editor", _tgi.WarningCaption);
    }

    [TestMethod]
    public void PluginOkWrongConfigurationTest()
    {
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.DefaultDirectory).Returns(Directory.GetCurrentDirectory());
      TestGraphicalUserInterface _tgi = new TestGraphicalUserInterface();
      ServerSelector _underTestItem = new ServerSelector(_tgi, _directory.Object, m_PluginFullPath, "");
      //_underTestItem
      int _configurationChanged = 0;
      bool _configuration = false; ;
      _underTestItem.OnConfigurationChanged += (x, y) => { _configurationChanged++; _configuration = y.ConfigurationFileChanged; };
      Assert.IsNotNull(_underTestItem.IServerConfiguration);
      Assert.IsFalse(String.IsNullOrEmpty(_underTestItem.IServerConfiguration.DefaultFileName));
      Assert.AreEqual<string>("CAS.UAServer.Configuration.uasconfig", _underTestItem.IServerConfiguration.DefaultFileName);
      Assert.IsNotNull(_underTestItem.SelectedAssembly);
      Assert.IsNotNull(_underTestItem.SelectedAssembly.Configuration);
      Assert.IsNotNull(_underTestItem.ServerConfiguration);
      Assert.AreEqual<string>(m_PluginFullPath, _underTestItem.ServerConfiguration.Codebase);
      Assert.AreEqual<string>(Path.Combine(Directory.GetCurrentDirectory(), _underTestItem.IServerConfiguration.DefaultFileName), _underTestItem.ServerConfiguration.Configuration);
      Assert.AreEqual<int>(0, _configurationChanged);
      Assert.IsFalse(_configuration);
      _underTestItem.IServerConfiguration.CreateDefaultConfiguration();
      Assert.AreEqual<int>(2, _configurationChanged);
      Assert.IsTrue(_configuration);
      _underTestItem.IServerConfiguration.CreateDefaultConfiguration();
      Assert.AreEqual<int>(4, _configurationChanged);
      Assert.IsTrue(_configuration);

      //_tgi
      Assert.AreEqual<int>(2, _tgi.ExclamationCallCount);
      Assert.AreEqual<int>(0, _tgi.ErrorCallCount);
      Assert.AreEqual<int>(0, _tgi.OpenFileDialog4UnitTestAssertErrors);
      CollectionAssert.AreEqual(new string[] { }, _tgi.ErrorCaption);
      CollectionAssert.AreEqual(new string[] { }, _tgi.ErrorMessage);
      CollectionAssert.AreEqual(new string[] { "No configuration file has been selected!", "No folder is selected" }, _tgi.ExclamationCaption);
      CollectionAssert.AreEqual(new string[] { "You did not choose the configuration file. Please select a location of the default configuration file.",
                                               "Folder is not selected, configuration will be created in the default location." }, _tgi.ExclamationMessage);
    }

    [TestMethod]
    public void GetPluginRelativePathNamesXTest()
    {
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.DefaultDirectory).Returns(Directory.GetCurrentDirectory());
      Mock<IGraphicalUserInterface> _gui = new Mock<IGraphicalUserInterface>();
      Mock<IFileDialog> _openFileDialogMock = new Mock<IFileDialog>();
      Mock<IFolderBrowserDialog> _IFolderBrowserDialog = new Mock<IFolderBrowserDialog>();
      string _message = String.Empty;
      string _caption = String.Empty;
      _gui.Setup(x => x.MessageBoxShowWarning);
      _gui.Setup(x => x.MessageBoxShowError);
      _gui.SetupGet(x => x.MessageBoxShowExclamation).Returns(() => (message, caption) => { _message = message; _caption = caption; });
      _gui.SetupGet(x => x.OpenFileDialogFunc).Returns(() => () => _openFileDialogMock.Object);
      _gui.SetupGet(x => x.OpenFolderBrowserDialogFunc).Returns(() => () => _IFolderBrowserDialog.Object);
      ServerSelector _underTestItem = new ServerSelector(_gui.Object, _directory.Object, m_PluginFullPath, "");
      ServerSelector.ServerDescriptor _pluginPaths = _underTestItem.ServerConfiguration;
      //test behavior
      _gui.Verify(x => x.MessageBoxShowError, Times.Never);
      _gui.Verify(x => x.MessageBoxShowWarning, Times.Never);
      _gui.Verify(x => x.MessageBoxShowExclamation, Times.Exactly(2));
      _gui.Verify(x => x.OpenFileDialogFunc, Times.Once);
      _gui.Verify(x => x.OpenFolderBrowserDialogFunc, Times.Once);
      //test result
      Assert.IsNotNull(_pluginPaths);
      Assert.AreEqual<string>(m_ConfigurationDefaultFileName, _pluginPaths.Configuration);
      Assert.AreEqual<string>(m_PluginFullPath, _pluginPaths.Codebase);
    }

    #region Instrumentation

    private const string m_PlaginCodeBaseRelativePath = @"CAS.CommServer.UA.ConfigurationEditor.ServerConfiguration.dll";
    private static readonly string m_ConfigurationDefaultFileName = Path.Combine((Directory.GetCurrentDirectory()), "CAS.UAServer.Configuration.uasconfig");
    private static readonly string m_ExamplePath = Path.Combine((Directory.GetCurrentDirectory()), "Plugin");
    private static readonly string m_PluginFullPath = Path.Combine(m_ExamplePath, m_PlaginCodeBaseRelativePath);

    private class OpenFileDialog4UnitTest : IFileDialog
    {
      private string m_DefaultExt;
      private readonly Action m_ReportAssertError;

      public OpenFileDialog4UnitTest(Action reportAssertError)
      {
        if (reportAssertError == null)
          throw new NullReferenceException(nameof(reportAssertError));
        m_ReportAssertError = reportAssertError;
      }

      /// <summary>
      /// Gets or sets the default file name extension.
      /// </summary>
      /// <value>The default file name extension. The returned string does not include the period. The default value is an empty string ("")</value>
      public string DefaultExt
      {
        get => m_DefaultExt;
        set
        {
          m_DefaultExt = value.Replace(".", "");
          if (string.Compare("uasconfig", m_DefaultExt) != 0)
            m_ReportAssertError();
        }
      }

      public string FileName
      {
        get => throw new NotImplementedException();
        set
        {
          if (string.Compare("CAS.UAServer.Configuration", value) != 0)
            m_ReportAssertError();
        }
      }

      public string Filter
      {
        get => throw new NotImplementedException();
        set
        {
          if (string.Compare(@"Configuration (* .uasconfig)|*.uasconfig|(* .xml)|*.xml|All files (*.*)|*.*", value) != 0)
            m_ReportAssertError();
        }
      }

      public string InitialDirectory
      {
        get => throw new NotImplementedException();

        set => throw new NotImplementedException();
      }

      public string Title
      {
        get => throw new NotImplementedException();
        set
        {
          if (string.Compare("UA Server configuration file", value) != 0)
            m_ReportAssertError();
        }
      }

      public void Dispose()
      {
      }

      public bool ShowDialog()
      {
        return false;
      }
    }

    private class FolderBrowserDialog : IFolderBrowserDialog
    {
      public string SelectedPath
      {
        get => Environment.CurrentDirectory;
        set => throw new NotImplementedException();
      }

      public void Dispose()
      {
      }

      public bool ShowDialog()
      {
        return false;
      }
    }

    private class TestGraphicalUserInterface : IGraphicalUserInterface
    {
      internal List<string> ErrorCaption = new List<string>();
      internal List<string> ErrorMessage = new List<string>();
      internal List<string> ExclamationCaption = new List<string>();
      internal List<string> ExclamationMessage = new List<string>();
      internal string WarningMessage;
      internal string WarningCaption;
      internal int ErrorCallCount = 0;
      internal int ExclamationCallCount = 0;
      internal bool WarningCalled;
      internal int OpenFileDialog4UnitTestAssertErrors = 0;

      public TestGraphicalUserInterface()
      {
        MessageBoxShowWarning = MessageBoxShowMethod;
        OpenFileDialogFunc = () => new OpenFileDialog4UnitTest(() => OpenFileDialog4UnitTestAssertErrors++);
      }

      public Action<string, string> MessageBoxShowWarning
      {
        get; set;
      }

      public Func<IFileDialog> OpenFileDialogFunc
      {
        get;
        private set;
      }

      public Action<string, string> MessageBoxShowExclamation => (x, y) => { ExclamationCaption.Add(y); ExclamationMessage.Add(x); ExclamationCallCount++; };
      public Action<string, string> MessageBoxShowError => (x, y) => { ErrorCaption.Add(y); ErrorMessage.Add(x); ErrorCallCount++; };
      public Func<IFileDialog> SaveFileDialogFuc => throw new NotImplementedException();
      public Func<IFolderBrowserDialog> OpenFolderBrowserDialogFunc => () => new FolderBrowserDialog();
      public Func<string, string, bool> MessageBoxShowWarningAskYN => throw new NotImplementedException();
      public bool UseWaitCursor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

      private void MessageBoxShowMethod(string text, string caption)
      {
        WarningCalled = true;
        WarningMessage = text;
        WarningCaption = caption;
      }
    }

    #endregion Instrumentation
  }
}