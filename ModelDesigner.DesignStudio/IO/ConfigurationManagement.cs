//<summary>
//  Title   : Class to save and restore  data  to/from external file.
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Properties;
using System;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Class to save and restore data to/from external  file. 
  /// This is base class and now it provides only common menu and file dialogs.
  /// </summary>
  internal abstract partial class ConfigurationManagement//: Component
  {

    #region constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigurationManagement"/> class.
    /// </summary>
    public ConfigurationManagement()
    {
      InitializeComponent();
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigurationManagement"/> class.
    /// </summary>
    /// <param name="container">The container.</param>
    //public ConfigurationManagement( IContainer container )
    //  : this()
    //{
    //  container.Add( this );
    //}
    #endregion

    #region public
    public string DefaultDirectory
    {
      set
      {
        m_OpenFileDialog.InitialDirectory = value;
        m_SaveFileDialog.InitialDirectory = value;
      }
      get { return m_OpenFileDialog.InitialDirectory; }
    }
    /// <summary>
    /// Gets or sets the default name of the file.
    /// </summary>
    /// <value>The default name of the file.</value>
    public string DefaultFileName
    {
      set
      {
        m_OpenFileDialog.FileName = value;
        m_SaveFileDialog.FileName = value;
        RaiseDefaultFileNameHasChanged();
      }
      get { return m_OpenFileDialog.FileName; }
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
      get { return m_ChangesArePresent; }
      protected set
      {
        if ( m_ChangesArePresent != value )
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
      if ( ChangesArePresent )
        return ( MessageBox.Show( Resources.ConfigurationManagementQuestionAboutContinuationIfChangesArePresent,
          Resources.ConfigurationManagementQuestionAboutContinuationIfChangesArePresentTitle,
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes );
      else
        return true;
    }
    #endregion

    #region private
    //protected IContainer Components { get { return components; } }
    private void RaiseChangesArePresentHasChanged()
    {
      ChangesArePresentHasChanged?.Invoke(this, EventArgs.Empty);
    }
    private bool m_ChangesArePresent = false;
    protected bool m_Empty = true;
    private void RaiseDefaultFileNameHasChanged()
    {
      DefaultFileNameHasChanged?.Invoke(this, EventArgs.Empty);
    }
    protected void UpdateSettingsOpenFileDialog( string FileDialogDefaultExt, string FileDialogDefaultFilename, string FileDialogFilter, string FileDialogTitle )
    {
      this.m_OpenFileDialog.DefaultExt = FileDialogDefaultExt;
      this.m_OpenFileDialog.FileName = FileDialogDefaultFilename;
      this.m_OpenFileDialog.Filter = FileDialogFilter;
      this.m_OpenFileDialog.Title = FileDialogTitle;
    }
    protected void UpdateSettingsSaveFileDialog( string FileDialogDefaultExt, string FileDialogDefaultFilename, string FileDialogFilter, string FileDialogTitle )
    {
      this.m_SaveFileDialog.DefaultExt = FileDialogDefaultExt;
      this.m_SaveFileDialog.FileName = FileDialogDefaultFilename;
      this.m_SaveFileDialog.Filter = FileDialogFilter;
      this.m_SaveFileDialog.Title = FileDialogTitle;
    }
    protected DialogResult ShowDialogOpenFileDialog()
    {
      DialogResult ret = m_OpenFileDialog.ShowDialog();
      if ( ret == DialogResult.OK )
      {
        DefaultFileName = m_OpenFileDialog.FileName;
      }
      return ret;
    }
    protected DialogResult ShowDialogSaveFileDialog()
    {
      DialogResult ret = m_SaveFileDialog.ShowDialog();
      if ( ret == DialogResult.OK )
      {
        DefaultFileName = m_SaveFileDialog.FileName;
      }
      return ret;
    }
    #region private menu handlers
    internal void OnNew( )
    {
      if ( TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued() )
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
    private void OnOpen_Click( object sender, EventArgs e )
    {
      if ( TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued() )
        Open();
    }
    #endregion
    #endregion
  }
}
