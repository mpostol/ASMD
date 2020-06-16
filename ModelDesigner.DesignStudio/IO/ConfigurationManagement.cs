//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.Properties;
using System;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Interface IConfigurationManagement - definitions related to the configuration management
  /// </summary>
  internal interface IConfigurationManagement
  {
    /// <summary>
    /// Gets or sets a value indicating whether [changes are present].
    /// </summary>
    /// <value><c>true</c> if [changes are present]; otherwise, <c>false</c>.</value>
    bool ChangesArePresent { get; }

    /// <summary>
    /// Occurs when changes are present.
    /// </summary>
    event EventHandler ChangesArePresentHasChanged;

    /// <summary>
    /// Tests if changes are present, next display window and return true if they may be lost.
    /// </summary>
    /// <returns><c>true</c> if changes may be neglected and next operation may be executed, <c>false</c> otherwise.</returns>
    bool TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued();

    /// <summary>
    /// Sets that the changes are present.
    /// </summary>
    void SetChangesArePresent();
  }

  /// <summary>
  /// Class to save and restore data to/from external file.
  /// This is base class and now it provides only common menu and file dialogs.
  /// </summary>
  internal abstract class ConfigurationManagement : SolutionDirectoryPathManagementBase
  {
    #region constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigurationManagement"/> class.
    /// </summary>
    public ConfigurationManagement(string fileName, IGraphicalUserInterface gui) : base(fileName)
    {
      GraphicalUserInterface = gui;
    }

    #endregion constructors

    #region public

    internal enum ConfigurationType
    {
      Project, Solution
    }

    /// <summary>
    /// Occurs when ChangesArePresent has changed.
    /// </summary>
    public event EventHandler ChangesArePresentHasChanged;

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
    public IGraphicalUserInterface GraphicalUserInterface { get; private set; }

    #endregion public

    #region private

    private bool m_ChangesArePresent = false;

    /// <summary>
    /// Gets the type of the configuration.
    /// </summary>
    /// <value>The type of the configuration defined in <see cref="ConfigurationType"/>.</value>
    protected abstract ConfigurationType Configuration { get; }

    private void RaiseChangesArePresentHasChanged()
    {
      ChangesArePresentHasChanged?.Invoke(this, EventArgs.Empty);
    }

    //private void RaiseDefaultFileNameHasChanged(NewDirectoryPathEventArgs newDirectoryPath)
    //{
    //  DefaultFileNameHasChanged?.Invoke(this, newDirectoryPath);
    //}

    protected static string ShowDialogOpenFileDialog(string DefaultFileName, IGraphicalUserInterface GraphicalUserInterface, ConfigurationType Configuration)
    {
      using (IFileDialog _dialog = GraphicalUserInterface.OpenFileDialogFunc())
      {
        SetupFileDialog(_dialog, DefaultFileName, Configuration);
        bool _ret = _dialog.ShowDialog();
        if (_ret)
          return _dialog.FileName;
        else
          return null;
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

    private static void SetupFileDialog(IFileDialog _dialog, string defaultFileName, ConfigurationType Configuration)
    {
      if (!String.IsNullOrEmpty(defaultFileName))
        _dialog.FileName = defaultFileName;
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