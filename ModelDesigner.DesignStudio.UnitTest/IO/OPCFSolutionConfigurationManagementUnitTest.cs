//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.IO
{

  [TestClass]
  public class OPCFSolutionConfigurationManagementUnitTest
  {
    [TestMethod]
    public void SingletonTest()
    {
      OPCFSolutionConfigurationManagement _instance = OPCFSolutionConfigurationManagement.DefaultInstance;
      Assert.IsNotNull(_instance);
      Assert.IsFalse(_instance.ChangesArePresent);
      Assert.IsFalse(string.IsNullOrEmpty(_instance.DefaultDirectory));
      Assert.AreEqual<string>(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)), _instance.DefaultDirectory);
      Assert.AreEqual<string>("UAModelDesignerSolution", Path.GetFileName(_instance.DefaultFileName));
    }

  }
}
