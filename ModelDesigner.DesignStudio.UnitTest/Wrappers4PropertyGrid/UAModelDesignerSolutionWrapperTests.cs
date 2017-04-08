
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Wrappers4PropertyGrid
{
  [TestClass()]
  public class UAModelDesignerSolutionWrapperTests
  {
    [TestMethod()]
    public void ConstructorDefaultTest()
    {
      UAModelDesignerSolution _solution = new UAModelDesignerSolution() { Name = "Name" };
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(_solution);
      Assert.IsTrue(String.IsNullOrEmpty(_newSolution.HomeDirectory));
      Assert.AreEqual<string>(_solution.Name, _newSolution.Name);
      Assert.IsNotNull(_newSolution.Server);
      Assert.IsNull(_newSolution.Server.SelectedAssembly);
      Assert.IsNull(_newSolution.Server.ServerConfiguration);
      Assert.IsNull(_newSolution.Projects);
      Assert.IsNull(_newSolution.ServerDetails);
    }
    [TestMethod]
    public void SetHomeDirectoryTest()
    {
      UAModelDesignerSolution _solution = new UAModelDesignerSolution() { Name = "Name" };
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(_solution);
      Assert.IsNull(_newSolution.ServerDetails);
      string _directory = Environment.CurrentDirectory;
      _newSolution.SetHomeDirectory(_directory);
      Assert.AreEqual<string>(_directory, _newSolution.HomeDirectory);
      Assert.AreEqual<string>(_solution.Name, _newSolution.Name);
      Assert.IsNull(_newSolution.ServerDetails);
    }
    [TestMethod]
    public void ConstructorTest()
    {
      string _directory = Environment.CurrentDirectory;
      string _UAModelDesignerSolution = "UAModelDesignerSolution";
      string _defaultSolutionName = "defaultSolutionName";
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(Path.Combine(_directory, _UAModelDesignerSolution), _defaultSolutionName);
      Assert.IsNull(_newSolution.ServerDetails);
      Assert.AreEqual<string>(_defaultSolutionName, _newSolution.Name);
      Assert.AreEqual<string>(_directory, _newSolution.HomeDirectory);
    }
    [TestMethod]
    public void ConstructorRelativePathTest()
    {
      string _directory = Environment.CurrentDirectory;
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper("UAModelDesignerSolution", "defaultSolutionName");
      Assert.AreEqual<string>(_directory, _newSolution.HomeDirectory);
    }
    [TestMethod]
    public void UAModelDesignerSolutionConfigurationTestMethod()
    {
      UAModelDesignerSolution _solution = new UAModelDesignerSolution() { Name = "Name" };
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(_solution);
      UAModelDesignerSolution _recoveredSolution = _newSolution.UAModelDesignerSolutionConfiguration;
      Assert.AreEqual<string>("Name", _recoveredSolution.Name);
      Assert.IsNull(_recoveredSolution.Projects);
      Assert.IsNull(_recoveredSolution.ServerDetails);
    }
    [TestMethod]
    public void UAModelDesignerSolutionConfiguration2TestMethod()
    {
      UAModelDesignerSolution _solution = new UAModelDesignerSolution()
      {
        Name = "Name",
        Projects = new UAModelDesignerProject[]
        {
          new UAModelDesignerProject()
          {
             BuildOutputDirectoryName = "BuildOutputDirectoryName",
             CSVFileName = "CSVFileName",
             FileName = "FileName",
             Name = "Name",
             ProjectIdentifier = "ProjectIdentifier"
          }
        },
        ServerDetails = new UAModelDesignerSolutionServerDetails() { codebase = "codebase", configuration = "configuration" }
      };
      Assert.Inconclusive("It calls MessageBox - dependency injection must be applied.");
      UAModelDesignerSolutionWrapper _newSolution = new UAModelDesignerSolutionWrapper(_solution);
      UAModelDesignerSolution _recoveredSolution = _newSolution.UAModelDesignerSolutionConfiguration;
      Assert.AreEqual<string>("Name", _recoveredSolution.Name);
      Assert.IsNotNull(_recoveredSolution.Projects);
      Assert.IsNotNull(_recoveredSolution.ServerDetails);
    }
  }
}