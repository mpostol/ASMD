using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAS.UA.Model.Designer.ImportExport.NodeSet;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  [TestClass]
  public class UAModelContextUnitTest
  {
    [TestMethod]
    public void CreateUAModelContextTestMethod()
    {
      UANodeSet _tm = TestData.CreateNodeSetModel();
      UAModelContext _mc = new NodeSet.UAModelContext(_tm.Aliases, _tm.NamespaceUris, null);
      Assert.IsNotNull(_mc);
      Assert.IsNull(_mc.AddressSpaceContext);
    }
  }
}
