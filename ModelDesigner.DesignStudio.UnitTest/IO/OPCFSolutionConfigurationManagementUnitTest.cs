//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
      Assert.AreEqual<string>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), _instance.DefaultDirectory);
      Assert.AreEqual<string>("UAModelDesignerSolution", Path.GetFileName(_instance.DefaultFileName));
    }
    [TestMethod]
    public void InterfaceTest()
    {
      ISolutionConfigurationManagement _instance = OPCFSolutionConfigurationManagement.DefaultInstance;
      Assert.IsNotNull(_instance);
      Assert.IsNull(_instance.GraphicalUserInterface);
    }

    [TestMethod]
    public void CreateNewTest()
    {
      OPCFSolutionConfigurationManagement _instance = OPCFSolutionConfigurationManagement.DefaultInstance;
      Mock<Configuration.UserInterface.IGraphicalUserInterface> _gui = new Mock<Configuration.UserInterface.IGraphicalUserInterface>();
      _instance.GraphicalUserInterface = _gui.Object;
      int _solutionChangeCouinter = 0;
      ISolutionConfigurationManagement _newSolution = null;
      _instance.AfterSolutionChange += (object sender, OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs e) =>
      {
        _solutionChangeCouinter++;
        Assert.IsInstanceOfType(sender, typeof(ISolutionConfigurationManagement));
        Assert.IsNotNull(e.Solution);
        _newSolution = e.Solution;
      };
      _instance.New();
      Assert.AreEqual<int>(1, _solutionChangeCouinter);
      Assert.AreSame(_instance, _newSolution);
    }

    private void _instance_AfterSolutionChange(object sender, OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}
