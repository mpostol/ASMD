using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests
{
  [TestClass]
  public class ServerSelectorUnitTest
  {
    [TestMethod]
    public void ServerSelectorCreatorTestMethod()
    {
      ServerSelector _nss = new ServerSelector();
      Assert.IsNotNull(_nss);
    }
  }
}
