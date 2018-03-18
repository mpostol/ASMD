using CAS.CommServer.UA.Common;
using CAS.UA.Model.Designer.Solution;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Model = CAS.UA.Model.Designer.Wrappers;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Wrappers4PropertyGrid
{
  [TestClass()]
  public class ProjectWrapperTests
  {
    [ClassInitializeAttribute]
    public static void ClassInitializeMethod(TestContext context)
    {
      Model.ViewModelFactory.Factory = new ViewModelFactory();
    }
    [TestMethod()]
    public void Constructor1Test()
    {
      Model.ProjectTreeNode _projectWrapper = new Model.ProjectTreeNode(new BaseDirectoryProvider(), string.Empty, new Opc.Ua.ModelCompiler.ModelDesign());
      ProjectWrapper _wrapper = new ProjectWrapper(_projectWrapper);
      Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _wrapper.Name);

      Assert.AreEqual<string>(@"$(ProjectFileName)", _wrapper.BuildOutputDirectoryName);
      Assert.AreEqual<string>($@"{Environment.CurrentDirectory}\Model_0", _wrapper.BuildOutputDirectoryPath);
      Assert.AreEqual<string>("$(ProjectFileName).csv", _wrapper.CSVFileName);
      Assert.AreEqual<string>($@"{Environment.CurrentDirectory}\Model_0.csv", _wrapper.CSVFilePath);
      //Assert.AreEqual<string>("path.FileName.xml", _wrapper.FileName);
      Assert.AreEqual<string>($@"{ Environment.CurrentDirectory}\Model_0", _wrapper.FilePath);
      //Assert.AreEqual<string>(m_Configuration.ProjectIdentifier, _wrapper.ProjectIdentifier.ToString());
      Assert.AreEqual<string>("Project:Name (path.FileName.xml)", _wrapper.ToString());
    }
    [TestMethod()]
    public void SetNewSolutionHomeDirectoryTest()
    {
      Model.ProjectTreeNode _projectWrapper = new Model.ProjectTreeNode(new BaseDirectoryProvider(), m_Configuration);
      ProjectWrapper _wrapper = new ProjectWrapper(_projectWrapper);
      //_wrapper.SetNewSolutionHomeDirectory(@"c:\");
      Assert.AreEqual<string>(@"$(ProjectFileName).BuildOutputDirectoryName", _wrapper.BuildOutputDirectoryName);
      Assert.AreEqual<string>(@"c:\path.FileName.BuildOutputDirectoryName", _wrapper.BuildOutputDirectoryPath);
      Assert.AreEqual<string>("$(ProjectFileName).CSVFileName", _wrapper.CSVFileName);
      Assert.AreEqual<string>(@"c:\path.FileName.CSVFileName", _wrapper.CSVFilePath);
      //Assert.AreEqual<string>("path.FileName.xml", _wrapper.FileName);
      Assert.AreEqual<string>(@"c:\path.FileName.xml", _wrapper.FilePath);
      Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _wrapper.Name);
      //Assert.AreEqual<string>(m_Configuration.ProjectIdentifier, _wrapper.ProjectIdentifier.ToString());
      Assert.AreEqual<string>("Project:Name (path.FileName.xml)", _wrapper.ToString());
    }
    [TestMethod()]
    public void ConstructorTest()
    {
      //TODO Move this test to ProjectTreeNode UT
      Model.ProjectTreeNode _projectWrapper = new Model.ProjectTreeNode(new BaseDirectoryProvider(), m_Configuration);
      ProjectWrapper _wrapper = new ProjectWrapper(_projectWrapper);
      //UAModelDesignerProject _configuration = _wrapper.UAModelDesignerProjectConfiguration;
      //Assert.AreEqual<string>("$(ProjectFileName).BuildOutputDirectoryName", _configuration.BuildOutputDirectoryName);
      //Assert.AreEqual<string>("$(ProjectFileName).CSVFileName", _configuration.CSVFileName);
      //Assert.AreEqual<string>("path.FileName.xml", _configuration.FileName);
      //Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _configuration.Name);
      //Assert.AreEqual<string>(m_Configuration.ProjectIdentifier, _configuration.ProjectIdentifier.ToString());
      //Assert.AreNotSame(_wrapper, m_Configuration);
    }
    [TestMethod()]
    public void ChangeNameTest()
    {
      Model.ProjectTreeNode _projectWrapper = new Model.ProjectTreeNode(new BaseDirectoryProvider(), m_Configuration);
      ProjectWrapper _wrapper = new ProjectWrapper(_projectWrapper);
      int _OnNameChangedCount = 0;
      _wrapper.OnNameChanged += (x, y) => _OnNameChangedCount++;
      //UAModelDesignerProject _configuration = _wrapper.UAModelDesignerProjectConfiguration;
      //Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _configuration.Name);
      Assert.AreEqual<int>(0, _OnNameChangedCount);
      _wrapper.Name = new Guid().ToString();
      Assert.AreEqual<int>(1, _OnNameChangedCount);
      //Assert.AreNotEqual<string>(_wrapper.Name, _configuration.Name);
      //_configuration = _wrapper.UAModelDesignerProjectConfiguration;
      //Assert.AreEqual<string>(_wrapper.Name, _configuration.Name);
      Assert.AreNotSame(_wrapper, m_Configuration);
    }
    private UAModelDesignerProject m_Configuration = new UAModelDesignerProject()
    {
      BuildOutputDirectoryName = "$(ProjectFileName).BuildOutputDirectoryName",
      CSVFileName = "$(ProjectFileName).CSVFileName",
      FileName = "path.FileName.xml",
      Name = "Name",
      ProjectIdentifier = new Guid().ToString()
    };
    private class BaseDirectoryProvider : IBaseDirectoryProvider
    {
      public string GetBaseDirectory()
      {
        return Path.Combine( Environment.CurrentDirectory, "Model_0");
      }
    }

  }
}
