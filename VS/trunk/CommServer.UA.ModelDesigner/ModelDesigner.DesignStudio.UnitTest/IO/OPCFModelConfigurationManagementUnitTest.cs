
using CAS.UA.Model.Designer.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.IO
{

  [TestClass]
  public class OPCFModelConfigurationManagementUnitTest
  {
    [TestMethod]
    public void CreatorTestMethod()
    {
      bool _dispozedCalled = false;
      using (OPCFModelConfigurationManagement _newItem = new OPCFModelConfigurationManagement())
      {
        _newItem.Disposed += (x, y) => _dispozedCalled = true;
        Assert.IsFalse(_newItem.ChangesArePresent);
        Assert.AreEqual<string>("", _newItem.DefaultDirectory);
        Assert.AreEqual<string>("UAModelDesignerProject.xml", _newItem.DefaultFileName);
      }
      Assert.IsTrue(_dispozedCalled);
    }
    [TestMethod]
    [ExpectedException(typeof(NotImplementedException))]
    public void GetConfigurationTestMethod()
    {
      using (DerivedOPCFModelConfigurationManagement _newItem = new DerivedOPCFModelConfigurationManagement())
        _newItem.GetConfigurationTest();
    }
    private class DerivedOPCFModelConfigurationManagement : OPCFModelConfigurationManagement
    {
      protected override DataToSerialize GetConfiguration
      {
        get
        {
          return base.GetConfiguration;
        }
      }
      public DataToSerialize GetConfigurationTest()
      {
        return GetConfiguration;
      }
    }
  }
}
