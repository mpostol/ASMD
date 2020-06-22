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
using System.IO;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Class to save and restore data to/from external file.
  /// This is base class and now it provides only common menu and file dialogs.
  /// </summary>
  internal abstract class ConfigurationManagement : SolutionDirectoryPathManagementBase, IConfigurationManagement
  {
    #region constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigurationManagement"/> class.
    /// </summary>
    public ConfigurationManagement(string fileName, bool changesArePresent, IGraphicalUserInterface gui) : base(fileName)
    {
      GraphicalUserInterface = gui;
      m_ChangesArePresent = changesArePresent;
    }

    #endregion constructors

    #region public

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

    private void RaiseChangesArePresentHasChanged()
    {
      ChangesArePresentHasChanged?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// Selects the save path.
    /// </summary>
    /// <param name="prompt">if set to <c>true</c> [prompt].</param>
    /// <param name="setupFileDialog">The setup file dialog.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    protected bool SelectSavePath(bool prompt, Action<IFileDialog> setupFileDialog)
    {
      bool _Empty = !File.Exists(DefaultFileName);
      prompt = _Empty || prompt;
      if (prompt && !ShowDialogSaveFileDialog(setupFileDialog))
        return false;
      return true;
    }

    protected bool ShowDialogSaveFileDialog(Action<IFileDialog> SetupFileDialog)
    {
      using (IFileDialog _dialog = GraphicalUserInterface.SaveFileDialogFuc())
      {
        SetupFileDialog(_dialog);
        _dialog.InitialDirectory = Path.GetDirectoryName(DefaultFileName);
        _dialog.FileName = Path.GetFileNameWithoutExtension(DefaultFileName);
        bool _ret = _dialog.ShowDialog();
        if (_ret)
          DefaultFileName = _dialog.FileName;
        return _ret;
      }
    }

    protected static string ShowDialogOpenFileDialog(IGraphicalUserInterface gui, Action<IFileDialog> setupFileDialog)
    {
      return ShowDialogOpenFileDialog(null, gui, setupFileDialog);
    }

    protected static string ShowDialogOpenFileDialog(string defaultFileName, IGraphicalUserInterface gui, Action<IFileDialog> setupFileDialog)
    {
      using (IFileDialog _dialog = gui.OpenFileDialogFunc())
      {
        setupFileDialog(_dialog);
        if (!String.IsNullOrEmpty(defaultFileName))
        {
          _dialog.InitialDirectory = Path.GetDirectoryName(defaultFileName);
          _dialog.FileName = Path.GetFileNameWithoutExtension(defaultFileName);
        }
        bool _ret = _dialog.ShowDialog();
        if (_ret)
          return _dialog.FileName;
        else
          return null;
      }
    }

    #endregion private
  }
}