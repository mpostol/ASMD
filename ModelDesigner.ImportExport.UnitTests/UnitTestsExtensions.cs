//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  internal static class UnitTestsExtensions
  {
    #region helpers

    internal static void Compare(this OpcUaModelCompiler.LocalizedText expected, OpcUaModelCompiler.LocalizedText actual)
    {
      if (expected == null && actual == null)
        return;
      Assert.IsNotNull(expected);
      Assert.IsNotNull(actual);
      Assert.AreEqual<string>(expected.Key, actual.Key);
      Assert.AreEqual<string>(expected.Value, actual.Value);
    }

    #endregion helpers
  }
}