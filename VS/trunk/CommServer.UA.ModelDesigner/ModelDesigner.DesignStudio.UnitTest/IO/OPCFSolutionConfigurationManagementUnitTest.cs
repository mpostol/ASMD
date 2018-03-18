
using CAS.UA.Model.Designer.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
      Assert.IsTrue( string.IsNullOrEmpty( _instance.DefaultDirectory));
      Assert.AreEqual("UAModelDesignerSolution", _instance.DefaultFileName);
    }
  }
}
