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
  /// Class NewBaseFolderEventArgs encapsulates information about the base folder change
  /// Implements the <see cref="System.EventArgs" />
  /// </summary>
  /// <seealso cref="System.EventArgs" />
  public class NewDirectoryPathEventArgs : EventArgs
  {
    /// <summary>
    /// Gets the old directory path.
    /// </summary>
    /// <value>The old directory path.</value>
    public string OldDirectoryPath { get; private set; }

    /// <summary>
    /// Creates new directory path.
    /// </summary>
    /// <value>The new directory path.</value>
    public string NewDirectoryPath { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NewDirectoryPathEventArgs"/> class.
    /// </summary>
    /// <param name="oldDirectoryPath">The old directory path.</param>
    /// <param name="newDirectoryPath">The new directory path.</param>
    /// <exception cref="ArgumentNullException">
    /// newDirectoryPath - While creating new instance of NewBaseFolderEventArgs the parameter cannot be null
    /// or
    /// oldDirectoryPath - While creating new instance of NewBaseFolderEventArgs the parameter cannot be null
    /// </exception>
    public NewDirectoryPathEventArgs(string oldDirectoryPath, string newDirectoryPath)
    {
      NewDirectoryPath = newDirectoryPath ?? throw new ArgumentNullException(nameof(newDirectoryPath), $"While creating new instance of {nameof(NewDirectoryPathEventArgs)} the parameter cannot be null");
      OldDirectoryPath = oldDirectoryPath ?? throw new ArgumentNullException(nameof(oldDirectoryPath), $"While creating new instance of {nameof(NewDirectoryPathEventArgs)} the parameter cannot be null");
    }
  }
}