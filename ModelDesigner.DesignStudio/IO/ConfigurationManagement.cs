//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
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
    public ConfigurationManagement(IGraphicalUserInterface graphicalUserInterface, string fileName)
    {
      GraphicalUserInterface = graphicalUserInterface;
      InitializeComponent();
      DefaultFileName = fileName;
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the type of the configuration.
    /// </summary>
    /// <value>The type of the configuration defined in <see cref="ConfigurationType"/>.</value>
    protected abstract ConfigurationType Configuration { get; }
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
    ///// <summary>
    ///// Save the configuration in an external dictionary file. 
    ///// </summary>
    ///// <param name="prompt">If set to <c>true</c> show prompt to enter a file name.</param>
    ///// <returns></returns>
    //public abstract bool Save( bool prompt );
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
    #endregion

    #region private
    //var
    protected IGraphicalUserInterface GraphicalUserInterface { get; private set; }
    private void RaiseChangesArePresentHasChanged()
    {
      ChangesArePresentHasChanged?.Invoke(this, EventArgs.Empty);
    }
    private bool m_ChangesArePresent = false;
    private string m_FileName;
    private void RaiseDefaultFileNameHasChanged()
    {
      DefaultFileNameHasChanged?.Invoke(this, EventArgs.Empty);
    }
    protected bool ShowDialogOpenFileDialog()
    {
      using (IFileDialog _dialog = GraphicalUserInterface.OpenFileDialogFunc())
      {
        SetupFileDialog(_dialog);
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
        SetupFileDialog(_dialog);
        bool _ret = _dialog.ShowDialog();
        if (_ret)
          DefaultFileName = _dialog.FileName;
        return _ret;
      }
    }
    private void SetupFileDialog(IFileDialog _dialog)
    {
      _dialog.FileName = this.DefaultFileName;
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

    #region menu handlers
    internal void OnNew()
    {
      if (TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued())
        New();
    }
    ///// <summary>
    ///// Called when SaveAs was clicked.
    ///// </summary>
    ///// <param name="sender">The sender.</param>
    ///// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    //private void OnSaveAs_Click( object sender, EventArgs e )
    //{
    //  Save( true );
    //}
    ///// <summary>
    ///// Called when Save was clicked.
    ///// </summary>
    ///// <param name="sender">The sender.</param>
    ///// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    //private void OnSave_Click( object sender, EventArgs e )
    //{
    //  Save( false );
    //}
    /// <summary>
    /// Called when Open was clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void OnOpen_Click(object sender, EventArgs e)
    {
      if (TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued())
        Open();
    }
    #endregion

    #region Component Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      //  this.components = new System.ComponentModel.Container();
      //  this.m_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      //  this.m_TSMI_New = new System.Windows.Forms.ToolStripMenuItem();
      //  this.m_TSMI_Open = new System.Windows.Forms.ToolStripMenuItem();
      //  this.m_TSMI_Save = new System.Windows.Forms.ToolStripMenuItem();
      //  this.m_TSMI_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
      //  this.m_ContextMenuStrip.SuspendLayout();
      //  // 
      //  // m_ContextMenuStrip
      //  // 
      //  this.m_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
      //        this.m_TSMI_New,
      //        this.m_TSMI_Open,
      //        this.m_TSMI_Save,
      //        this.m_TSMI_SaveAs});
      //  this.m_ContextMenuStrip.Name = "ContextMenuStrip";
      //  this.m_ContextMenuStrip.Size = new System.Drawing.Size(176, 92);
      //  this.m_ContextMenuStrip.Text = "Session";
      //  // 
      //  // m_TSMI_New
      //  // 
      //  this.m_TSMI_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      //  this.m_TSMI_New.Name = "m_TSMI_New";
      //  this.m_TSMI_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      //  this.m_TSMI_New.Size = new System.Drawing.Size(175, 22);
      //  this.m_TSMI_New.Text = "&New";
      //  this.m_TSMI_New.ToolTipText = "Clear and create new session configuration";
      //  // 
      //  // m_TSMI_Open
      //  // 
      //  this.m_TSMI_Open.Image = global::CAS.UA.Model.Designer.Properties.Resources.Open;
      //  this.m_TSMI_Open.Name = "m_TSMI_Open";
      //  this.m_TSMI_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      //  this.m_TSMI_Open.Size = new System.Drawing.Size(175, 22);
      //  this.m_TSMI_Open.Text = "&Open...";
      //  this.m_TSMI_Open.ToolTipText = "Read session configuration from an XML.";
      //  // 
      //  // m_TSMI_Save
      //  // 
      //  this.m_TSMI_Save.Image = global::CAS.UA.Model.Designer.Properties.Resources.FloppyDisk;
      //  this.m_TSMI_Save.Name = "m_TSMI_Save";
      //  this.m_TSMI_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      //  this.m_TSMI_Save.Size = new System.Drawing.Size(175, 22);
      //  this.m_TSMI_Save.Text = "&Save";
      //  this.m_TSMI_Save.ToolTipText = "Save session configuration to an XML file.";
      //  // 
      //  // m_TSMI_SaveAs
      //  // 
      //  this.m_TSMI_SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      //  this.m_TSMI_SaveAs.Name = "m_TSMI_SaveAs";
      //  this.m_TSMI_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      //  this.m_TSMI_SaveAs.Size = new System.Drawing.Size(175, 22);
      //  this.m_TSMI_SaveAs.Text = "Save &As...";
      //  this.m_TSMI_SaveAs.ToolTipText = "Open a prompt file name dialog and save session configuration to an XML in a spec" +
      //      "ified location and specified file name.";
      //  this.m_ContextMenuStrip.ResumeLayout(false);

    }
    #endregion

    #endregion

  }
}
