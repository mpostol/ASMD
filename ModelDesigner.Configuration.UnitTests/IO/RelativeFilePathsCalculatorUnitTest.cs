//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
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

    [TestMethod]
    public void TryComputeRelativePathTest()
    {
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.TryComputeRelativePath(m_Relative1, m_Relative3));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.TryComputeRelativePath(m_AbsolutePath, m_AbsolutePath));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.TryComputeRelativePath(m_AbsolutePath, @"s\d\f\"));
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
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_AbsolutePath, m_AbsolutePath));
      Assert.AreEqual<string>(@"C:\VS.git\UAOOI\ASMD210\ModelDesigner.ModelsContainer\bin\Model_0.xml", 
        RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_AbsolutePath, @"C:\VS.git\UAOOI\ASMD210\ModelDesigner.ModelsContainer\bin\Release\..\Model_0.xml"));
      Assert.AreEqual<string>(m_AbsoluteFilePath, RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_AbsolutePath, m_AbsoluteFilePath));
      Assert.AreEqual<string>(Path.Combine(Directory.GetCurrentDirectory(), @"Documents"), RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_AbsolutePath, m_Relative1));
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_AbsolutePath, m_Relative2));
      Assert.AreEqual<string>(Path.Combine(m_AbsolutePath, m_FileName), RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_AbsolutePath, m_FileName));
      Assert.AreEqual<string>(@"C:\VS.git\UAOOI\ASMD210\ModelDesigner.ModelsContainer\bin\Model_0.xml",
                              RelativeFilePathsCalculator.CalculateAbsoluteFileName(@"C:\VS.git\UAOOI\ASMD210\ModelDesigner.ModelsContainer\bin\Release\", @"..\Model_0.xml"));
      Assert.AreEqual<string>(String.Empty, RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_AbsolutePath, String.Empty));
      Assert.AreEqual<string>(String.Empty, RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_AbsolutePath, null));
    }

    private const string m_AbsolutePath = @"C:\a\b\c\";
    private const string m_AbsoluteFilePath = @"C:\a\b\x\FileName.txt";
    private const string m_Relative1 = "C:Documents";
    private const string m_Relative2 = @"/Documents\";
    private const string m_Relative3 = @"d\e\f";
    private const string m_FileName = "FileName.txt";
  }
}