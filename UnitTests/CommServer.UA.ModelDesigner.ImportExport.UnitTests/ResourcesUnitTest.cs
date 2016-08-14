using CAS.UA.Model.Designer.ImportExport.NodeSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  [TestClass]
  public class ResourcesUnitTest
  {
    [TestMethod]
    public void OpcUaNodeSet2TestMethod()
    {
      UANodeSet _standard = Extensions.LoadResource<UANodeSet>(Extensions.UADefinedTypesName);
      Assert.IsNotNull(_standard);
      Assert.IsNull(_standard.NamespaceUris);
    }
  }
}
