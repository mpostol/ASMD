using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opc.Ua.ModelCompiler;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  internal static class UnitTestsExtensions
  {
    #region helpers
    internal static void Compare(this LocalizedText expected, LocalizedText actual)
    {
      if (expected == null && actual == null)
        return;
      Assert.IsNotNull(expected);
      Assert.IsNotNull(actual);
      Assert.AreEqual<string>(expected.Key, actual.Key);
      Assert.AreEqual<string>(expected.Value, actual.Value);
    }
    #endregion

  }
}
