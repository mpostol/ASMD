//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using System.IO;
using UAOOI.Configuration.DataBindings;
using UAOOI.Configuration.Networking.Serialization;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UnitTests.Instrumentation
{

  /// <summary>
  /// Class ConfigurationBaseImplementation.
  /// </summary>
  public class ConfigurationBaseImplementation : ConfigurationBase<ConfigurationData>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigurationBaseImplementation"/> class.
    /// </summary>
    public ConfigurationBaseImplementation() { }
    /// <summary>
    /// Gets the default name of the file.
    /// </summary>
    /// <value>The default name of the file.</value>
    public override string DefaultFileName
    {
      get
      {
        return "DefaultFileName.xxl";
      }
    }
    /// <summary>
    /// Creates the default configuration.
    /// </summary>
    public override void CreateDefaultConfiguration()
    {
      CurrentConfiguration = new ConfigurationData();
    }
    /// <summary>
    /// Creates the instance configurations.
    /// </summary>
    /// <param name="descriptors">The descriptors.</param>
    /// <param name="SkipOpeningConfigurationFile">if set to <c>true</c> [skip opening configuration file].</param>
    /// <param name="CancelWasPressed">if set to <c>true</c> [cancel was pressed].</param>
    /// <exception cref="NotImplementedException"></exception>
    public override void CreateInstanceConfigurations(UAOOI.Configuration.Core.INodeDescriptor[] descriptors, bool SkipOpeningConfigurationFile, out bool CancelWasPressed)
    {
      throw new NotImplementedException();
    }
    /// <summary>
    /// Gets the configuration editor - user interface to edit the plug-in configuration file.
    /// </summary>
    /// <returns>Represents a window or dialog box that makes up an application's user interface to be used to edit configuration file.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public override void EditConfiguration()
    {
      throw new NotImplementedException();
    }
    public override UAOOI.Configuration.Core.IInstanceConfiguration GetInstanceConfiguration(UAOOI.Configuration.Core.INodeDescriptor descriptor)
    {
      throw new NotImplementedException();
    }
    /// <summary>
    /// Saves the configuration file to a specified location.
    /// </summary>
    /// <param name="solutionFilePath">The solution file path.</param>
    /// <param name="configurationFile">The configuration file.</param>
    /// <exception cref="NotImplementedException"></exception>
    /// <remarks><paramref name="solutionFilePath" /> is to be used to create relative file path to configuration files used by the plug-in.</remarks>
    public override void SaveConfiguration(string solutionFilePath, FileInfo configurationFile)
    {
      throw new NotImplementedException();
    }

  }
}
