//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.Properties;
using System;
using System.IO;

namespace CAS.UA.Model.Designer.IO
{
  internal enum ConfigurationType
  {
    Project, Solution
  }

  /// <summary>
  /// Class to save and restore data to/from external file.
  /// This is base class and now it provides only common menu and file dialogs.
  /// </summary>
  internal abstract class ConfigurationManagement
  {
    #region constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigurationManagement"/> class.
    /// </summary>
    public ConfigurationManagement(string fileName)
    {
      GraphicalUserInterface = null;
      DefaultFileName = fileName;
    }

    #endregion constructors

    #region public

    public string DefaultDirectory => Path.GetDirectoryName(DefaultFileName);

    /// <summary>
    /// Gets or sets the default name of the file.
    /// </summary>
    /// <value>The default name of the file.</value>
    public string DefaultFileName
    {
      set
      {
        if (m_FileName == value)
          return;
        m_FileName = value;
        RaiseDefaultFileNameHasChanged();
      }
      get => m_FileName;
    }

    /// <summary>
    /// Occurs when default file name has been changed.
    /// </summary>
    public event EventHandler DefaultFileNameHasChanged;

    /// <summary>
    /// Create a new configuration.
    /// </summary>
    public abstract void New();

    /// <summary>
    /// Read the configuration from an external dictionary file.
    /// </summary>
    /// <returns></returns>
    public abstract bool Open();

    /// <summary>
    /// Gets or sets a value indicating whether [changes are present].
    /// </summary>
    /// <value><c>true</c> if [changes are present]; otherwise, <c>false</c>.</value>
    public bool ChangesArePresent
    {
      get => m_ChangesArePresent;
      protected set
      {
        if (m_ChangesArePresent != value)
        {
          m_ChangesArePresent = value;
          RaiseChangesArePresentHasChanged();
        }
      }
    }

    /// <summary>
    /// Occurs when ChangesArePresent has changed.
    /// </summary>
    public event EventHandler ChangesArePresentHasChanged;

    /// <summary>
    /// Sets the changes are present.
    /// </summary>
    public void SetChangesArePresent()
    {
      ChangesArePresent = true;
    }

    /// <summary>
    /// Tests if changes are present display window and return true if should be continued.
    /// </summary>
    /// <returns></returns>
    public bool TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued()
    {
      if (ChangesArePresent)
        return GraphicalUserInterface.MessageBoxShowWarningAskYN(
          Resources.ConfigurationManagementQuestionAboutContinuationIfChangesArePresent,
          Resources.ConfigurationManagementQuestionAboutContinuationIfChangesArePresentTitle);
      else
        return true;
    }

    /// <summary>
    /// Gets or sets the graphical user interface.
    /// </summary>
    /// <remarks>It is be injected by upper layer or dependency injection framework</remarks>
    /// <value>The graphical user interface.</value>
    public IGraphicalUserInterface GraphicalUserInterface { get; set; }

    #endregion public

    #region private

    private bool m_ChangesArePresent = false;
    private string m_FileName;

    /// <summary>
    /// Gets the type of the configuration.
    /// </summary>
    /// <value>The type of the configuration defined in <see cref="ConfigurationType"/>.</value>
    protected abstract ConfigurationType Configuration { get; }

    private void RaiseChangesArePresentHasChanged()
    {
      ChangesArePresentHasChanged?.Invoke(this, EventArgs.Empty);
    }

    private void RaiseDefaultFileNameHasChanged()
    {
      DefaultFileNameHasChanged?.Invoke(this, EventArgs.Empty);
    }

    protected bool ShowDialogOpenFileDialog()
    {
      using (IFileDialog _dialog = GraphicalUserInterface.OpenFileDialogFunc())
      {
        SetupFileDialog(_dialog, this.DefaultFileName, Configuration);
        bool _ret = _dialog.ShowDialog();
        if (_ret)
          DefaultFileName = _dialog.FileName;
        return _ret;
      }
    }

    protected bool ShowDialogSaveFileDialog()
    {
      using (IFileDialog _dialog = GraphicalUserInterface.SaveFileDialogFuc())
      {
        SetupFileDialog(_dialog, this.DefaultFileName, Configuration);
        bool _ret = _dialog.ShowDialog();
        if (_ret)
          DefaultFileName = _dialog.FileName;
        return _ret;
      }
    }

    private static void SetupFileDialog(IFileDialog _dialog, string DefaultFileName, ConfigurationType Configuration)
    {
      _dialog.FileName = DefaultFileName;
      switch (Configuration)
      {
        case ConfigurationType.Project:
          _dialog.DefaultExt = Resources.Project_FileDialogDefaultExt;
          _dialog.Filter = Resources.Project_FileDialogFilter;
          _dialog.Title = Resources.Project_FileDialogTitle;
          break;

        case ConfigurationType.Solution:
          _dialog.DefaultExt = Resources.Solution_FileDialogDefaultExt;
          _dialog.Filter = Resources.Solution_FileDialogFilter;
          _dialog.Title = Resources.Solution_FileDialogTitle;
          break;

        default:
          break;
      }
    }

    #endregion private
  }
}