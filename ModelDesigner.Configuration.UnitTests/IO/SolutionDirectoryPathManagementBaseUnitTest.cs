//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests.IO
{
  [TestClass]
  public class SolutionDirectoryPathManagementBaseUnitTest
  {
    [TestMethod]
    public void SetNewPathTest()
    {
      SolutionDirectoryPathManagementBaseFixture _newInstance = new SolutionDirectoryPathManagementBaseFixture();
      Assert.IsTrue(String.IsNullOrEmpty(_newInstance.BaseDirectory));
      _newInstance.SetNewPath("NewPath");
      Assert.AreEqual<int>(1, _newInstance.UpdateCounter);
      Assert.AreEqual<string>(String.Empty, _newInstance.oldPath);
      Assert.AreEqual<string>("NewPath", _newInstance.newPath);
    }

    private class SolutionDirectoryPathManagementBaseFixture : SolutionDirectoryPathManagementBase
    {
      internal void SetNewPath(string path)
      {
        base.BaseDirectory = path;
      }

      internal int UpdateCounter = 0;
      internal string oldPath = String.Empty;
      internal string newPath = String.Empty;

      public SolutionDirectoryPathManagementBaseFixture()
      {
        base.BaseDirectoryPathChanged += (x, y) =>
          {
            Assert.AreSame(this, x);
            UpdateCounter++;
            oldPath = y.OldDirectoryPath;
            newPath = y.NewDirectoryPath;
          };
      }
    }
  }
}