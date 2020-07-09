//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.IServerConfiguration;
using System;
using System.IO;
using System.Reflection;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests.Instrumentation
{
  internal static class AssemblyHelpers
  {

    internal static IConfiguration CreateInstance(Assembly pluginAssembly)
    {
      if (pluginAssembly == null)
        throw new NullReferenceException(nameof(pluginAssembly));
      IConfiguration _serverConfiguration = null;
      string _iName = typeof(IConfiguration).ToString();
      foreach (Type pluginType in pluginAssembly.GetExportedTypes())
        //Only look at public types
        if (pluginType.IsPublic && !pluginType.IsAbstract && pluginType.GetInterface(_iName) != null)
        {
          _serverConfiguration = (IConfiguration)Activator.CreateInstance(pluginType);
          break;
        }
      if (_serverConfiguration == null)
        throw new NullReferenceException(nameof(_serverConfiguration));
      return _serverConfiguration;
    }
  }
}