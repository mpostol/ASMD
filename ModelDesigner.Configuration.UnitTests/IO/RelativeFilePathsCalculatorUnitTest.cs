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
      Assert.IsTrue(RelativeFilePathsCalculator.TestIfPathIsAbsolute(@"C:\VS.git\UAOOI\ASMD210\ModelDesigner.ModelsContainer\bin\Release\..\Model_0.xml"));
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
      Assert.AreEqual<string>(m_AbsoluteFilePath, Path.GetFullPath(Path.Combine(m_AbsolutePath, @"..\x\FileName.txt")));
      Assert.AreEqual<string>(@"..\..\..\a\b\x\FileName.txt", RelativeFilePathsCalculator.TryComputeRelativePath(@"C:\c\b\a\", @"C:\a\b\x\FileName.txt"));
      Assert.AreEqual<string>(@"..\x\FileName", RelativeFilePathsCalculator.TryComputeRelativePath(@"C:\a\b\a\", @"C:\a\b\x\FileName"));
      Assert.AreEqual<string>(@m_AbsoluteFilePath, RelativeFilePathsCalculator.TryComputeRelativePath(@"D:\c\b\a\", m_AbsoluteFilePath));
    }

    [TestMethod]
    public void CalculateAbsoluteFileNameTest()
    {
      Assert.AreEqual<string>(m_AbsolutePath, RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_AbsolutePath, m_AbsolutePath));
      Assert.AreEqual<string>(m_AbsoluteFilePath, RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_AbsoluteFilePath, m_AbsolutePath));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_Relative1, m_AbsolutePath));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_Relative2, m_AbsolutePath));
      Assert.AreEqual<string>(Path.Combine(m_AbsolutePath, m_FileName), RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_FileName, m_AbsolutePath));
    }

    private const string m_AbsolutePath = @"C:\a\b\c\";
    private const string m_AbsoluteFilePath = @"C:\a\b\x\FileName.txt";
    private const string m_Relative1 = "C:Documents";
    private const string m_Relative2 = "/Documents";
    private const string m_Relative3 = @"d\e\f";
    private const string m_FileName = "FileName.txt";
  }
}