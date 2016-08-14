using CAS.UA.Model.Designer.Wrappers;
namespace CAS.UA.Model.Designer.Controls
{
  partial class AddNode
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
      this.m_listBox = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // m_listBox
      // 
      this.m_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_listBox.FormattingEnabled = true;
      this.m_listBox.Location = new System.Drawing.Point( 0, 0 );
      this.m_listBox.Name = "m_listBox";
      this.m_listBox.Size = new System.Drawing.Size( 184, 147 );
      this.m_listBox.Sorted = true;
      this.m_listBox.TabIndex = 0;
      this.m_listBox.SelectedIndexChanged += new System.EventHandler( this.m_listBox_SelectedIndexChanged );
      // 
      // AddNode
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add( this.m_listBox );
      this.Name = "AddNode";
      this.Size = new System.Drawing.Size( 184, 150 );
      this.ResumeLayout( false );

    }

    #endregion

    private System.Windows.Forms.ListBox m_listBox;

  }
}
