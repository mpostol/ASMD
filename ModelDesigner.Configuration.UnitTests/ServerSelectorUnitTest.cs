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
using System.Collections.Generic;
using System.IO;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests
{
  [TestClass]
  public class ServerSelectorUnitTest
  {
    [TestMethod]
    public void ServerSelectorCreatorTest()
    {
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.DefaultDirectory).Returns(@"C:\");
      Mock<IGraphicalUserInterface> _guiMock = new Mock<IGraphicalUserInterface>();
      ServerSelector _nss = new ServerSelector(_guiMock.Object, _directory.Object, "", "");
      Assert.IsNull(_nss.SelectedAssembly);
      Assert.IsNull(_nss.ServerConfiguration);
      Assert.IsNull(_nss.IServerConfiguration);
    }

    [TestMethod]
    public void ServerConfigurationNullTest()
    {
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.DefaultDirectory).Returns(@"C:\");
      TestGraphicalUserInterface _testGUI = new TestGraphicalUserInterface();
      ServerSelector _nss = new ServerSelector(_testGUI, _directory.Object, "", "");
      Assert.IsFalse(_testGUI.WarningCalled);
    }

    [TestMethod]
    public void ServerConfigurationWrongAssemblyTest()
    {
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.DefaultDirectory).Returns(@"wrong_path");
      TestGraphicalUserInterface _tgi = new TestGraphicalUserInterface();
      ServerSelector _nss = new ServerSelector(_tgi, _directory.Object, "wrong.codebase", "wrong.configuration");
      Assert.IsTrue(_tgi.WarningCalled);
      Assert.IsTrue(_tgi.WarningMessage.Contains("wrong.codebase"));
      Assert.AreEqual<string>("Open configuration editor", _tgi.WarningCaption);
    }

    [TestMethod]
    public void ServerConfigurationWTest()
    {
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.DefaultDirectory).Returns(@"wrong_path");
      TestGraphicalUserInterface _ui = new TestGraphicalUserInterface();
      ServerSelector _nss = new ServerSelector(_ui, _directory.Object, "CAS.CommServer.UA.ConfigurationEditor.ServerConfiguration.dll", "");
      Assert.AreEqual<int>(2, _ui.ExclamationCallCount);
      Assert.AreEqual<int>(0, _ui.ErrorCallCount);
      Assert.AreEqual<int>(0, _ui.OpenFileDialog4UnitTestAssertErrors);
      CollectionAssert.AreEqual(new string[] { }, _ui.ErrorCaption);
      CollectionAssert.AreEqual(new string[] { }, _ui.ErrorMessage);
      CollectionAssert.AreEqual(new string[] { "No configuration file has been selected!", "No folder is selected" }, _ui.ExclamationCaption);
      CollectionAssert.AreEqual(new string[] { "You did not choose the configuration file. Please select a location of the default configuration file.",
                                               "Folder is not selected, configuration will be created in the default location." }, _ui.ExclamationMessage);
    }

    [TestMethod]
    public void ServerLoadTest()
    {
      string PluginPath = @"lib\net461\";
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.DefaultDirectory).Returns(Path.Combine(Directory.GetCurrentDirectory(), PluginPath));
      TestGraphicalUserInterface _ui = new TestGraphicalUserInterface();
      ServerSelector _nss = new ServerSelector(_ui, _directory.Object, "CAS.CommServer.UA.ConfigurationEditor.ServerConfiguration.dll", "");

      Assert.IsNotNull(_nss.IServerConfiguration);
      Assert.IsFalse(String.IsNullOrEmpty(_nss.IServerConfiguration.DefaultFileName));
      Assert.AreEqual<string>("CAS.UAServer.Configuration.uasconfig", _nss.IServerConfiguration.DefaultFileName);
      Assert.IsNotNull(_nss.SelectedAssembly);
      Assert.IsNotNull(_nss.ServerConfiguration);

    }

    [TestMethod]
    public void EmptyServerDescriptorTest()
    {
      Mock<ISolutionDirectoryPathManagement> _directory = new Mock<ISolutionDirectoryPathManagement>();
      _directory.SetupGet(x => x.DefaultDirectory).Returns(string.Empty);
      TestGraphicalUserInterface _ui = new TestGraphicalUserInterface();
      ServerSelector _nss = new ServerSelector(_ui, _directory.Object, string.Empty, string.Empty);
      Assert.IsFalse(_ui.WarningCalled);
    }

    #region Instrumentation

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