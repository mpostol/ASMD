using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest
{
  [TestClass]
  [DeploymentItem(@"exe\", "exe")]
  public class ModelCompilerExistWUnitTest
  {
    [TestMethod]
    public void TestMethod1()
    {
      string _fileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), CAS.UA.Model.Designer.Properties.Settings.Default.ProjectCompilationExecutable);
      Assembly _mc = Assembly.LoadFrom(_fileName);
      Assert.IsNotNull(_mc);
      Version _softVersion = _mc.GetName().Version;
      Assert.AreEqual<Version>(new Version(1, 2, 272, _softVersion.Revision), _softVersion);
      Dictionary<string, Attribute> _ats = _mc.GetCustomAttributes(false).Cast<Attribute>().ToDictionary<Attribute, string>(x => x.GetType().Name);
      Assert.AreEqual<int>(14, _ats.Values.Count);
      Assert.AreEqual<string>("CAS CommServer Family:CAS distribution of OPC UA Model Compiler", ((AssemblyDescriptionAttribute)_ats[typeof(AssemblyDescriptionAttribute).Name]).Description);

    }
  }
}
