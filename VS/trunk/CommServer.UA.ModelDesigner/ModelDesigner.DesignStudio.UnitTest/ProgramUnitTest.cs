﻿
using CAS.UA.Model.Designer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CASCAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest
{
  [TestClass]
  [DeploymentItem(@"CAS.CommonResources.dll")]
  public class ProgramUnitTest
  {
    [TestMethod]
    public void AssemblyLoadTestMethod()
    {
      Type _ProgramType = typeof(Program);
      Assembly _opcViewer = _ProgramType.Assembly;
      Assert.IsNotNull(_opcViewer);
    }
    [TestMethod]
    public void DoInstallLicenseLocalTestMethod()
    {
      FileInfo _resourcesFile = new FileInfo(@"CAS.CommonResources.dll");
      Assert.IsTrue(_resourcesFile.Exists, $"The file doesn't exist in the folder {Directory.GetCurrentDirectory()}");
      string _lastMessage = null;
      Program.MessageBoxShow = x => { _lastMessage = x; return DialogResult.OK; };
      Program.DoInstallLicense(true);
      Assert.IsNull(_lastMessage, _lastMessage);
    }
    [TestMethod]
    public void DoApplicationRunTestMethod()
    {
      bool _isCalled = false;
      Program.DoApplicationRun(x => { _isCalled = true; Assert.IsNull(x); });
      Assert.IsTrue(_isCalled);
    }
  }
}
