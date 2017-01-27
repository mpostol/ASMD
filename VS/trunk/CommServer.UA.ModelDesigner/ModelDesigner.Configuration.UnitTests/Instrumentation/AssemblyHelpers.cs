
using CAS.UA.IServerConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests.Instrumentation
{
  internal static class AssemblyHelpers
  {

    internal static void CreateInstance(string assemblyFile, out Assembly _pluginAssembly, out IConfiguration _serverConfiguration)
    {
      FileInfo _pluginFileName = new FileInfo(assemblyFile);
      Assert.IsTrue(_pluginFileName.Exists);
      _pluginAssembly = Assembly.LoadFrom(_pluginFileName.FullName);
      _serverConfiguration = CreateInstance(_pluginAssembly);
    }
    internal static IConfiguration CreateInstance(Assembly _pluginAssembly)
    {
      IConfiguration _serverConfiguration;
      string iName = typeof(IConfiguration).ToString();
      _serverConfiguration = null;
      Assert.IsNotNull(_pluginAssembly);
      foreach (Type pluginType in _pluginAssembly.GetExportedTypes())
        //Only look at public types
        if (pluginType.IsPublic && !pluginType.IsAbstract && pluginType.GetInterface(iName) != null)
        {
          _serverConfiguration = (IConfiguration)Activator.CreateInstance(pluginType);
          break;
        }
      Assert.IsNotNull(_serverConfiguration);
      return _serverConfiguration;
    }
  }
}
