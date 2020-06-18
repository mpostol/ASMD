//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using System.IO;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.IO
{
  /// <summary>
  /// The class encapsulates a basic implementation of the <see cref="ISolutionDirectoryPathManagement"/>
  /// Implements the <see cref="CAS.CommServer.UA.ModelDesigner.Configuration.IO.ISolutionDirectoryPathManagement" />
  /// </summary>
  /// <seealso cref="ISolutionDirectoryPathManagement" />
  public abstract class SolutionDirectoryPathManagementBase : ISolutionDirectoryPathManagement
  {
    private string m_BaseDirectory = string.Empty;

    /// <summary>
    /// Initializes a new instance of the <see cref="SolutionDirectoryPathManagementBase"/> class encapsulating information about the a solution base directory location .
    /// </summary>
    /// <param name="baseDirectory">An initial value for the <see cref="SolutionDirectoryPathManagementBase.DefaultDirectory"/>.</param>
    protected SolutionDirectoryPathManagementBase(string baseDirectory)
    {
      if (String.IsNullOrEmpty(baseDirectory))
        throw new ArgumentOutOfRangeException(baseDirectory, "The initial value of the file path cannot be null.");
      m_BaseDirectory = baseDirectory;
    }
    /// <summary>
    /// Gets or sets the base directory.
    /// </summary>
    /// <value>The base directory.</value>
    public string DefaultDirectory => Path.GetDirectoryName(DefaultFileName);
    //{
    //  get => m_BaseDirectory;
    //  protected set
    //  {
    //    if (value == m_BaseDirectory)
    //      return;
    //    string _oldBaseDirectory = m_BaseDirectory;
    //    m_BaseDirectory = value;
    //    DefaultFileNameHasChanged?.Invoke(this, new NewDirectoryPathEventArgs(_oldBaseDirectory, value));
    //  }
    //}

    /// <summary>
    /// Gets or sets the default name of the file.
    /// </summary>
    /// <value>The default name of the file.</value>
    public string DefaultFileName
    {
      get => m_BaseDirectory;
      protected set
      {
        if (value == m_BaseDirectory)
          return;
        string _oldBaseDirectory = DefaultDirectory;
        m_BaseDirectory = value;
        DefaultFileNameHasChanged?.Invoke(this, new NewDirectoryPathEventArgs(_oldBaseDirectory, DefaultDirectory));
      }
    }

    /// <summary>
    /// Occurs when changes occur that affect the base directory .
    /// </summary>
    public event EventHandler<NewDirectoryPathEventArgs> DefaultFileNameHasChanged;
  }
}