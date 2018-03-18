
using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Wrappers4PropertyGrid
{
  [TestClass]
  [DeploymentItem(@"TestData\", @"TestData")]
  public class UAModelDesignerSolutionUnitTest
  {
    [TestMethod]
    public void ConfigurationFileExistsTest()
    {
      Assert.IsTrue(Directory.Exists("TestData"), $"{Directory.GetCurrentDirectory()}");
      Assert.IsTrue(File.Exists(@"TestData\BoilerExampleSolution.uamdsl"));
    }
    [TestMethod]
    public void ReadConfigurationTest()
    {
      UAModelDesignerSolution _configuration = XmlFile.ReadXmlFile<UAModelDesignerSolution>(m_Path);
      Assert.IsNotNull(_configuration);
      Assert.AreEqual<string>("Boiler Example Solution", _configuration.Name);
      Assert.AreEqual<int>(2, _configuration.Projects.Length);
      Assert.IsNotNull(_configuration.ServerDetails);
      Assert.AreEqual<string>(@"CAS.CommServer.UA.ConfigurationEditor.ServerConfiguration.dll", _configuration.ServerDetails.codebase);
      Assert.AreEqual<string>(@"DemoConfiguration\BoilerExample.uasconfig", _configuration.ServerDetails.configuration);
    }
    [TestMethod]
    public void SaveConfigurationTest()
    {
      XmlFile.WriteXmlFile<UAModelDesignerSolution>(_referenceModel, m_ReferenceModelPath, FileMode.Create, "SolutionConfiguration.xslt");
      FileInfo _referenceFile = new FileInfo(m_ReferenceModelPath);
      Assert.IsTrue(_referenceFile.Exists);
      Assert.AreEqual<long>(1178L, _referenceFile.Length);
    }
    private static string m_Path = @"TestData\BoilerExampleSolution.uamdsl";
    private static string m_ReferenceModelPath = @"TestData\ReferenceSolution.uamdsl";
    private static UAModelDesignerSolution _referenceModel = new UAModelDesignerSolution()
    {
      Name = "Boiler Example Solution",
      Projects = new UAModelDesignerProject[]
       {
         new UAModelDesignerProject()
         {
            Name = "BoilerType",  ProjectIdentifier = "16e3ddd9-3e85-476c-a552-6ac1ad9094b6", CSVFileName = "$(ProjectFileName).csv", BuildOutputDirectoryName = "$(ProjectFileName)",  FileName = @"DemoConfiguration\BoilerType.xml"
         },
         new UAModelDesignerProject()
         {
            Name = "BoilersSet",  ProjectIdentifier = "61e9f146-a415-437b-be6f-373e2c81ec55", CSVFileName = "$(ProjectFileName).csv", BuildOutputDirectoryName = "$(ProjectFileName)",  FileName = @"DemoConfiguration\BoilersSet.xml"
         },
       },
      ServerDetails = new UAModelDesignerSolutionServerDetails() { codebase = "CAS.CommServer.UA.ConfigurationEditor.ServerConfiguration.dll", configuration = @"DemoConfiguration\BoilerExample.uasconfig" }
    };
  }
}
