//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
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
    public void ConstructorTest()
    {
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => new SolutionDirectoryPathManagementBaseFixture(String.Empty));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => new SolutionDirectoryPathManagementBaseFixture(null));
    }
    [TestMethod]
    public void SetNewPathTest()
    {
      SolutionDirectoryPathManagementBaseFixture _newInstance = new SolutionDirectoryPathManagementBaseFixture(@"C:\a\c\d\name.ext");
      Assert.AreEqual<string>(@"C:\a\c\d", _newInstance.DefaultDirectory);
      Assert.AreEqual<int>(0, _newInstance.UpdateCounter);
      _newInstance.SetNewPath(@"C:\a\x\y\name.ext");
      Assert.AreEqual<int>(1, _newInstance.UpdateCounter);
      Assert.AreEqual<string>(@"C:\a\c\d", _newInstance.oldPath);
      Assert.AreEqual<string>(@"C:\a\x\y", _newInstance.newPath);
    }
    private class SolutionDirectoryPathManagementBaseFixture : SolutionDirectoryPathManagementBase
    {
      internal void SetNewPath(string path)
      {
        base.DefaultFileName = path;
      }

      internal int UpdateCounter = 0;
      internal string oldPath = String.Empty;
      internal string newPath = String.Empty;

      public SolutionDirectoryPathManagementBaseFixture(string path) : base(path)
      {
        base.DefaultFileNameHasChanged += (x, y) =>
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