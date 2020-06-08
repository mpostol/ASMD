//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.IO
{
  /// <summary>
  /// Interface used to provide path to base directory used as a root of the configuration files.
  /// </summary>
  public interface ISolutionDirectoryPathManagement
  {
    /// <summary>
    /// Gets the base directory path.
    /// </summary>
    /// <returns> <see cref="string"/> with the base directory path</returns>
    string BaseDirectory { get; }

    /// <summary>
    /// Occurs when changes occur that affect the base directory path.
    /// </summary>
    event EventHandler<NewDirectoryPathEventArgs> BaseDirectoryPathChanged;
  }
}