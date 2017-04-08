using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Wrappers4PropertyGrid
{
  [TestClass()]
  public class ProjectWrapperTests
  {
    [TestMethod()]
    public void Constructor1Test()
    {
      ProjectWrapper _wrapper = new ProjectWrapper(m_Configuration);
      Assert.AreEqual<string>(@"$(ProjectFileName).BuildOutputDirectoryName", _wrapper.BuildOutputDirectoryName);
      Assert.AreEqual<string>($"path.FileName.BuildOutputDirectoryName", _wrapper.BuildOutputDirectoryPath);
      Assert.AreEqual<string>("$(ProjectFileName).CSVFileName", _wrapper.CSVFileName);
      Assert.AreEqual<string>($"path.FileName.CSVFileName", _wrapper.CSVFilePath);
      Assert.AreEqual<string>("path.FileName.xml", _wrapper.FileName);
      Assert.AreEqual<string>("path.FileName.xml", _wrapper.FilePath);
      Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _wrapper.Name);
      Assert.AreEqual<string>(m_Configuration.ProjectIdentifier, _wrapper.ProjectIdentifier.ToString());
      Assert.AreEqual<string>("Project:Name (path.FileName.xml)", _wrapper.ToString());
    }
    [TestMethod()]
    public void SetNewSolutionHomeDirectoryTest()
    {
      ProjectWrapper _wrapper = new ProjectWrapper(m_Configuration);
      _wrapper.SetNewSolutionHomeDirectory(@"c:\");
      Assert.AreEqual<string>(@"$(ProjectFileName).BuildOutputDirectoryName", _wrapper.BuildOutputDirectoryName);
      Assert.AreEqual<string>(@"c:\path.FileName.BuildOutputDirectoryName", _wrapper.BuildOutputDirectoryPath);
      Assert.AreEqual<string>("$(ProjectFileName).CSVFileName", _wrapper.CSVFileName);
      Assert.AreEqual<string>(@"c:\path.FileName.CSVFileName", _wrapper.CSVFilePath);
      Assert.AreEqual<string>("path.FileName.xml", _wrapper.FileName);
      Assert.AreEqual<string>(@"c:\path.FileName.xml", _wrapper.FilePath);
      Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _wrapper.Name);
      Assert.AreEqual<string>(m_Configuration.ProjectIdentifier, _wrapper.ProjectIdentifier.ToString());
      Assert.AreEqual<string>("Project:Name (path.FileName.xml)", _wrapper.ToString());
    }
    [TestMethod()]
    public void ConstructorTest()
    {
      ProjectWrapper _wrapper = new ProjectWrapper(m_Configuration);
      UAModelDesignerProject _configuration = _wrapper.UAModelDesignerProjectConfiguration;
      Assert.AreEqual<string>("$(ProjectFileName).BuildOutputDirectoryName", _configuration.BuildOutputDirectoryName);
      Assert.AreEqual<string>("$(ProjectFileName).CSVFileName", _configuration.CSVFileName);
      Assert.AreEqual<string>("path.FileName.xml", _configuration.FileName);
      Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _configuration.Name);
      Assert.AreEqual<string>(m_Configuration.ProjectIdentifier, _configuration.ProjectIdentifier.ToString());
      Assert.AreNotSame(_wrapper, m_Configuration);
    }
    [TestMethod()]
    public void ChangeNameTest()
    {
      ProjectWrapper _wrapper = new ProjectWrapper(m_Configuration);
      int _OnNameChangedCount = 0;
      _wrapper.OnNameChanged += (x, y) => _OnNameChangedCount++;
      UAModelDesignerProject _configuration = _wrapper.UAModelDesignerProjectConfiguration;
      Assert.AreEqual<string>(nameof(UAModelDesignerProject.Name), _configuration.Name);
      Assert.AreEqual<int>(0, _OnNameChangedCount);
      _wrapper.Name = new Guid().ToString();
      Assert.AreEqual<int>(1, _OnNameChangedCount);
      Assert.AreNotEqual<string>(_wrapper.Name, _configuration.Name);
      _configuration = _wrapper.UAModelDesignerProjectConfiguration;
      Assert.AreEqual<string>(_wrapper.Name, _configuration.Name);
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
  }
}
