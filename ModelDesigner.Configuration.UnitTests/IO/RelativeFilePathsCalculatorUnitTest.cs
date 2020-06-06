//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

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
      Assert.IsTrue(RelativeFilePathsCalculator.TestIfPathIsAbsolute(Path.Combine(m_Relative3, m_AbsolutePath)));
      Assert.IsTrue(RelativeFilePathsCalculator.TestIfPathIsAbsolute(Path.Combine(m_AbsolutePath, m_Relative3)));
    }

    [TestMethod]
    public void TryComputeRelativePathTest()
    {
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.TryComputeRelativePath(m_Relative1, m_Relative3));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.TryComputeRelativePath(m_AbsolutePath, m_AbsolutePath));
      Assert.AreEqual<string>(m_FileName, RelativeFilePathsCalculator.TryComputeRelativePath(m_AbsolutePath, Path.Combine(m_AbsolutePath, m_FileName)));
      Assert.AreEqual<string>(m_Relative3, RelativeFilePathsCalculator.TryComputeRelativePath(m_AbsolutePath, m_Relative3));
      Assert.AreEqual<string>(m_Relative3, RelativeFilePathsCalculator.TryComputeRelativePath(m_AbsolutePath, Path.Combine(m_AbsolutePath, m_Relative3)));
      Assert.AreEqual<string>(@"..\x\FileName.txt", RelativeFilePathsCalculator.TryComputeRelativePath(m_AbsolutePath, m_AbsoluteFilePath));
      Assert.AreEqual<string>(@"..\..\..\a\b\x\FileName.txt", RelativeFilePathsCalculator.TryComputeRelativePath(@"C:\c\b\a\", m_AbsoluteFilePath));
      Assert.AreEqual<string>(@"C:\a\b\x\FileName.txt", RelativeFilePathsCalculator.TryComputeRelativePath(@"D:\c\b\a\", m_AbsoluteFilePath));
    }

    private const string m_AbsolutePath = @"C:\a\b\c\";
    private const string m_AbsoluteFilePath = @"C:\a\b\x\FileName.txt";
    private const string m_Relative1 = "C:Documents";
    private const string m_Relative2 = "/Documents";
    private const string m_Relative3 = @"d\e\f";
    private const string m_FileName = "FileName.txt";
  }
}