using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAS.UA.Model.Designer.Wrappers
{
  [TestClass]
  public class DataTypeDesignUnitTest
  {
    [TestMethod]
    public void ConstructorTest()
    {
      DataTypeDesign _instance = new DataTypeDesign();
      Assert.AreEqual<int>(4, _instance.Count);
      Assert.ThrowsException<System.NullReferenceException>( () => _instance.AvailiableNamespaces);
    }
  }
}
