﻿//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Solution;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using WrappersModel = global::CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid
{
  [TestClass()]
  //TODO Use moc to test CAS.UA.Model.Designer.Wrappers4PropertyGrid #40
  public class ProjectWrapperTests
  {
    [ClassInitializeAttribute]
    public static void ClassInitializeMethod(TestContext context)
    {
      WrappersModel.ViewModelFactory.Factory = new ViewModelFactory();
    }

    [TestMethod()]
    public void Constructor1Test()
    {
      Mock<IProjectModelView> _projectObjectModel = new Mock<IProjectModelView>();
      ProjectWrapper _projectWrapper = new ProjectWrapper(_projectObjectModel.Object);
      Assert.Inconclusive("Use moc to test CAS.UA.Model.Designer.Wrappers4PropertyGrid #40");
      // Assert.Inconclusive("_projectWrapper.Text is generated dynamically so it cannot be reproduced");
      // Assert.AreEqual<string>("Model_0", _projectWrapper.Text);
      // Assert.AreEqual<string>("Model_0", _wrapper.Name);
      Assert.AreEqual<string>(@"$(ProjectFileName)", _projectWrapper.BuildOutputDirectoryName);
      // Assert.Inconclusive(); //Result Message:	Assert.AreEqual failed. Expected:< C:\VS.git\ASMD\ModelDesigner.DesignStudio.UnitTest\bin\Debug\Model_0 >.Actual:< C:\VS.git\ASMD\ModelDesigner.DesignStudio.UnitTest\bin\Debug\TestData\Model_0 >.
      // Assert.AreEqual<string>($@"{Environment.CurrentDirectory}\Model_0", _wrapper.BuildOutputDirectoryPath);
      Assert.AreEqual<string>("$(ProjectFileName).csv", _projectWrapper.CSVFileName);
      // Assert.AreEqual<string>($@"{Environment.CurrentDirectory}\Model_0.csv", _wrapper.CSVFilePath);
      //Assert.AreEqual<string>("path.FileName.xml", _wrapper.FileName);
      // Assert.AreEqual<string>($@"{ Environment.CurrentDirectory}\Model_0", _wrapper.FilePath);
      //Assert.AreEqual<string>(m_Configuration.ProjectIdentifier, _wrapper.ProjectIdentifier.ToString());
      // Assert.AreEqual<string>("Project:Name (path.FileName.xml)", _wrapper.ToString());
    }

    [TestMethod()]
    public void SetNewSolutionHomeDirectoryTest()
    {
      //Assert.Inconclusive(@"System.IO.DirectoryNotFoundException: C:\VS.git\ASMD\ModelDesigner.DesignStudio.UnitTest\bin\Debug\TestData\TestData");
      //WrappersModel.ProjectTreeNode _projectWrapper = new WrappersModel.ProjectTreeNode(new BaseDirectoryProvider(), m_Configuration);
      //ProjectWrapper _wrapper = new ProjectWrapper(_projectWrapper);
      ////_wrapper.SetNewSolutionHomeDirectory(@"c:\");
      //Assert.AreEqual<string>(@"$(ProjectFileName).BuildOutputDirectoryName", _wrapper.BuildOutputDirectoryName);
      //Assert.AreEqual<string>(@"c:\path.FileName.BuildOutputDirectoryName", _wrapper.BuildOutputDirectoryPath);
      //Assert.AreEqual<string>("$(ProjectFileName).CSVFileName", _wrapper.CSVFileName);
      //Assert.AreEqual<string>(@"c:\path.FileName.CSVFileName", _wrapper.CSVFilePath);
      ////Assert.AreEqual<string>("path.FileName.xml", _wrapper.FileName);
      //Assert.AreEqual<string>(@"c:\path.FileName.xml", _wrapper.FilePath);
      //Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _wrapper.Name);
      ////Assert.AreEqual<string>(m_Configuration.ProjectIdentifier, _wrapper.ProjectIdentifier.ToString());
      //Assert.AreEqual<string>("Project:Name (path.FileName.xml)", _wrapper.ToString());
    }

    [TestMethod()]
    public void ConstructorTest()
    {
      //Assert.Inconclusive(@"System.IO.DirectoryNotFoundException: C:\VS.git\ASMD\ModelDesigner.DesignStudio.UnitTest\bin\Debug\TestData\TestData");
      //WrappersModel.ProjectTreeNode _projectWrapper = new WrappersModel.ProjectTreeNode(new BaseDirectoryProvider(), m_Configuration);
      //ProjectWrapper _wrapper = new ProjectWrapper(_projectWrapper);
      ////UAModelDesignerProject _configuration = _wrapper.UAModelDesignerProjectConfiguration;
      ////Assert.AreEqual<string>("$(ProjectFileName).BuildOutputDirectoryName", _configuration.BuildOutputDirectoryName);
      ////Assert.AreEqual<string>("$(ProjectFileName).CSVFileName", _configuration.CSVFileName);
      ////Assert.AreEqual<string>("path.FileName.xml", _configuration.FileName);
      ////Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _configuration.Name);
      ////Assert.AreEqual<string>(m_Configuration.ProjectIdentifier, _configuration.ProjectIdentifier.ToString());
      ////Assert.AreNotSame(_wrapper, m_Configuration);
    }

    [TestMethod()]
    public void ChangeNameTest()
    {
      //Assert.Inconclusive(@"System.IO.DirectoryNotFoundException: C:\VS.git\ASMD\ModelDesigner.DesignStudio.UnitTest\bin\Debug\TestData\TestData");
      //WrappersModel.ProjectTreeNode _projectWrapper = new WrappersModel.ProjectTreeNode(new BaseDirectoryProvider(), m_Configuration);
      //ProjectWrapper _wrapper = new ProjectWrapper(_projectWrapper);
      //int _OnNameChangedCount = 0;
      //_wrapper.OnNameChanged += (x, y) => _OnNameChangedCount++;
      ////UAModelDesignerProject _configuration = _wrapper.UAModelDesignerProjectConfiguration;
      ////Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _configuration.Name);
      //Assert.AreEqual<int>(0, _OnNameChangedCount);
      //_wrapper.Name = new Guid().ToString();
      //Assert.AreEqual<int>(1, _OnNameChangedCount);
      ////Assert.AreNotEqual<string>(_wrapper.Name, _configuration.Name);
      ////_configuration = _wrapper.UAModelDesignerProjectConfiguration;
      ////Assert.AreEqual<string>(_wrapper.Name, _configuration.Name);
      //Assert.AreNotSame(_wrapper, m_Configuration);
    }

    private readonly UAModelDesignerProject m_Configuration = new UAModelDesignerProject()
    {
      BuildOutputDirectoryName = "$(ProjectFileName).BuildOutputDirectoryName",
      CSVFileName = "$(ProjectFileName).CSVFileName",
      FileName = "path.FileName.xml",
      Name = "Name",
      ProjectIdentifier = new Guid().ToString()
    };
  }
}