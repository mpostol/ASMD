namespace CAS.UA.Model.Designer.IO
{
  partial class ConfigurationManagement
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.m_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.m_SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.m_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
      this.m_TSMI_New = new System.Windows.Forms.ToolStripMenuItem();
      this.m_TSMI_Open = new System.Windows.Forms.ToolStripMenuItem();
      this.m_TSMI_Save = new System.Windows.Forms.ToolStripMenuItem();
      this.m_TSMI_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ContextMenuStrip.SuspendLayout();
      // 
      // m_OpenFileDialog
      // 
      this.m_OpenFileDialog.DefaultExt = "xml";
      this.m_OpenFileDialog.FileName = "UAAddressSpaceModel";
      this.m_OpenFileDialog.Filter = "XML Configuration File (* .xml)|*.xml|All files(*.*)|*.*";
      this.m_OpenFileDialog.Title = "UA Address Space Model";
      // 
      // m_SaveFileDialog
      // 
      this.m_SaveFileDialog.DefaultExt = "xml";
      this.m_SaveFileDialog.FileName = "UAAddressSpaceModel";
      this.m_SaveFileDialog.Filter = "XML Configuration File (* .xml)|*.xml|All files(*.*)|*.*";
      this.m_SaveFileDialog.SupportMultiDottedExtensions = true;
      this.m_SaveFileDialog.Title = "UA Address Space Model";
      // 
      // m_ContextMenuStrip
      // 
      this.m_ContextMenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.m_TSMI_New,
            this.m_TSMI_Open,
            this.m_TSMI_Save,
            this.m_TSMI_SaveAs} );
      this.m_ContextMenuStrip.Name = "ContextMenuStrip";
      this.m_ContextMenuStrip.Size = new System.Drawing.Size( 176, 92 );
      this.m_ContextMenuStrip.Text = "Session";
      // 
      // m_TSMI_New
      // 
      this.m_TSMI_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.m_TSMI_New.Name = "m_TSMI_New";
      this.m_TSMI_New.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N ) ) );
      this.m_TSMI_New.Size = new System.Drawing.Size( 175, 22 );
      this.m_TSMI_New.Text = "&New";
      this.m_TSMI_New.ToolTipText = "Clear and create new session configuration";
      // 
      // m_TSMI_Open
      // 
      this.m_TSMI_Open.Image = global::CAS.UA.Model.Designer.Properties.Resources.Open;
      this.m_TSMI_Open.Name = "m_TSMI_Open";
      this.m_TSMI_Open.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O ) ) );
      this.m_TSMI_Open.Size = new System.Drawing.Size( 175, 22 );
      this.m_TSMI_Open.Text = "&Open...";
      this.m_TSMI_Open.ToolTipText = "Read session configuration from an XML.";
      // 
      // m_TSMI_Save
      // 
      this.m_TSMI_Save.Image = global::CAS.UA.Model.Designer.Properties.Resources.FloppyDisk;
      this.m_TSMI_Save.Name = "m_TSMI_Save";
      this.m_TSMI_Save.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S ) ) );
      this.m_TSMI_Save.Size = new System.Drawing.Size( 175, 22 );
      this.m_TSMI_Save.Text = "&Save";
      this.m_TSMI_Save.ToolTipText = "Save session configuration to an XML file.";
      // 
      // m_TSMI_SaveAs
      // 
      this.m_TSMI_SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.m_TSMI_SaveAs.Name = "m_TSMI_SaveAs";
      this.m_TSMI_SaveAs.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A ) ) );
      this.m_TSMI_SaveAs.Size = new System.Drawing.Size( 175, 22 );
      this.m_TSMI_SaveAs.Text = "Save &As...";
      this.m_TSMI_SaveAs.ToolTipText = "Open a prompt file name dialog and save session configuration to an XML in a spec" +
          "ified location and specified file name.";
      this.m_ContextMenuStrip.ResumeLayout( false );

    }

    #endregion
    private System.Windows.Forms.OpenFileDialog m_OpenFileDialog;
    private System.Windows.Forms.SaveFileDialog m_SaveFileDialog;
    private System.Windows.Forms.ToolStripMenuItem m_TSMI_Open;
    private System.Windows.Forms.ToolStripMenuItem m_TSMI_Save;
    private System.Windows.Forms.ToolStripMenuItem m_TSMI_SaveAs;
    private System.Windows.Forms.ContextMenuStrip m_ContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem m_TSMI_New;
  }
}
