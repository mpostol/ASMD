//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests.IO
{
  [TestClass]
  public class RelativeFilePathsCalculatorUnitTest
  {
    //TODO Update the relative path calculator using current .NET functionality #132
    [TestMethod]
    public void TestIfPathIsAbsoluteTest()
    {
      Assert.IsTrue(RelativeFilePathsCalculator.TestIfPathIsAbsolute(m_AbsolutePath));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.TestIfPathIsAbsolute(m_Relative1));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.TestIfPathIsAbsolute(m_Relative2));
      Assert.IsFalse(RelativeFilePathsCalculator.TestIfPathIsAbsolute(m_Relative3));
      Assert.IsTrue(RelativeFilePathsCalculator.TestIfPathIsAbsolute(System.IO.Path.Combine( m_Relative3, m_AbsolutePath)));
      Assert.IsTrue(RelativeFilePathsCalculator.TestIfPathIsAbsolute(System.IO.Path.Combine(m_AbsolutePath, m_Relative3)));
    }

    private const string m_AbsolutePath = @"C:\a\b\c";
    private const string m_Relative1 = "C:Documents";
    private const string m_Relative2 = "/Documents";
    private const string m_Relative3 = @"d\e\f";
  }
}