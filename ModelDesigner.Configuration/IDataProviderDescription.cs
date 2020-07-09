//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using System.Reflection;

namespace CAS.CommServer.UA.ModelDesigner.Configuration
{
  /// <summary>
  /// Allows to get by the client all information identifying the plug-in component.
  /// </summary>
  public interface IDataProviderDescription
  {
    /// <summary>
    /// Gets the title custom attribute for the plug-in assembly manifest.
    /// </summary>
    /// <value>A string containing the assembly title..</value>
    string Title { get; }
    /// <summary>
    /// Gets the full name of the assembly, also known as the display name from the <see cref="AssemblyName"/>.
    /// </summary>
    /// <value>A string that is the full name of the assembly, also known as the display name.</value>
    string FullName { get; }
    /// <summary>
    /// Gets a company name custom attribute for the plug-in assembly manifest.
    /// </summary>
    /// <value>A string containing the company name.</value>
    string Company { get; }
    /// <summary>
    /// Provides a text description for an assembly.
    /// </summary>
    /// <value>A string containing the assembly description.</value>
    string Description { get; }
    /// <summary>
    /// Gets the major, minor, build, and revision numbers of the assembly from the <see cref="AssemblyName"/> 
    /// </summary>
    /// <value>A <see cref="AssemblyName"/> object representing the major, minor, build, and revision numbers of the assembly.</value>
    Version Version { get; }
    /// <summary>
    /// Data of last modification or release of the component.
    /// </summary>
    /// <value>A <see cref="DateTime"/> of the last modification or release of the component..</value>
    DateTime Date { get; }
    /// <summary>
    /// An unique identifier assigned to the plug-in assembly.
    /// </summary>
    /// <value>The <see cref="Guid"/> assigned to the plug-in assembly..</value>
    Guid Identifier { get; }
    /// <summary>
    /// Copyright custom attribute for the plug-in assembly manifest.
    /// </summary>
    /// <value>The copyright.</value>
    string Copyright { get; }
    /// <summary>
    /// Gets a trademark custom attribute for the plug-in assembly manifest.
    /// </summary>
    /// <value>The trademark.</value>
    string Trademark { get; }
    /// <summary>
    /// Gets the code base.
    /// </summary>
    /// <value>The code base.</value>
    string CodeBase { get; }
  }
}
