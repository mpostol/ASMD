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
  /// The class encapsulates a basic implementation of the <see cref="ISolutionDirectoryPathManagement"/>
  /// Implements the <see cref="CAS.CommServer.UA.ModelDesigner.Configuration.IO.ISolutionDirectoryPathManagement" />
  /// </summary>
  /// <seealso cref="ISolutionDirectoryPathManagement" />
  public class SolutionDirectoryPathManagementBase : ISolutionDirectoryPathManagement
  {
    private string m_BaseDirectory;

    /// <summary>
    /// Gets or sets the base directory.
    /// </summary>
    /// <value>The base directory.</value>
    public string BaseDirectory
    {
      get => m_BaseDirectory;
      protected set
      {
        if (value == m_BaseDirectory)
          return;
        string _oldBaseDirectory = m_BaseDirectory;
        m_BaseDirectory = value;
        BaseDirectoryPathChanged?.Invoke(this, new NewDirectoryPathEventArgs(_oldBaseDirectory, value));
      }
    }

    /// <summary>
    /// Occurs when changes occur that affect the base directory .
    /// </summary>
    public event EventHandler<NewDirectoryPathEventArgs> BaseDirectoryPathChanged;
  }
}