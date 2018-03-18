using CAS.UA.Model.Designer.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.IO
{

  [TestClass]
  public class OPCFModelConfigurationManagementUnitTest
  {
    [TestMethod]
    public void CreatorTestMethod()
    {
      using (OPCFModelConfigurationManagement _newItem = new OPCFModelConfigurationManagement())
      {
        Assert.IsFalse(_newItem.ChangesArePresent);
        Assert.AreEqual<string>("", _newItem.DefaultDirectory);
        Assert.AreEqual<string>("UAModelDesignerProject.xml", _newItem.DefaultFileName);
      }
    }
    private class DerivedOPCFModelConfigurationManagement : OPCFModelConfigurationManagement
    {
    }
  }
}
