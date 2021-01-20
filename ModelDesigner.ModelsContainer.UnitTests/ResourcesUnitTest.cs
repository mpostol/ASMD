//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CAS.CommServer.UA.ConfigurationEditor.ModelsContainer.UnitTests
{
  [TestClass]
  public class ResourcesUnitTest
  {
    [TestMethod]
    public void ResourcesTestMethod()
    {
      DirectoryInfo _targetDirectory = null;
      try
      {
        string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), m_TestPath);
        _targetDirectory = new DirectoryInfo(_path);
        int _installedFiles = 0;
        Assert.IsFalse(_targetDirectory.Exists, "The test directory already exist before test starting");
        ContainerResources.ExampleSolutionInstallation(m_TestPath, (x, y) => { Console.WriteLine($"{y}: {x}"); _installedFiles++; });
        Assert.AreEqual<int>(22, _installedFiles);
        _targetDirectory.Refresh();
        Assert.IsTrue(_targetDirectory.Exists);
        Assert.AreEqual<int>(5, _targetDirectory.GetFiles().Length, "Expected 2 solutions and plug-in");
        Assert.AreEqual<int>(2, _targetDirectory.GetDirectories().Length, "Expected only 2 solutions folders");
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        _targetDirectory.Delete(true);
        _targetDirectory.Refresh();
        Assert.IsFalse(_targetDirectory.Exists);
      }
    }
    private const string m_TestPath = "TestingFolder2Delete";
  }
}
