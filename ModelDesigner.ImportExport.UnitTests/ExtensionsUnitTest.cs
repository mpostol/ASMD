using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAS.UA.Model.Designer.ImportExport.NodeSet;
using Opc.Ua.ModelCompiler;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  [TestClass]
  public class ExtensionsUnitTest
  {
    [TestMethod]
    public void AddLocalizedTextTestMethod()
    {
      int _counter = 0;
      Extensions.AddLocalizedText("localeField1", "valueField1", ref m_Description, x => _counter++);
      Assert.AreEqual<int>(0, _counter);
      Assert.IsNotNull(m_Description);
      LocalizedText _description = m_Description;
      Extensions.AddLocalizedText("localeField1", "valueField1", ref m_Description, x => _counter++);
      Assert.AreEqual<int>(1, _counter);
      Assert.IsNotNull(m_Description);
      Assert.AreSame(_description, m_Description);
    }

    private LocalizedText m_Description = null;

  }
}
