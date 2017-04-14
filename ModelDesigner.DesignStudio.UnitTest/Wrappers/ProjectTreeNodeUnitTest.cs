using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAS.UA.Model.Designer.Wrappers;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Wrappers
{
  [TestClass]
  public class ProjectTreeNodeUnitTest
  {
    [TestMethod]
    public void ConstructorTest()
    {
      ProjectTreeNode _newItem = new ProjectTreeNode(null, "NodeName");

    }
  }
}
