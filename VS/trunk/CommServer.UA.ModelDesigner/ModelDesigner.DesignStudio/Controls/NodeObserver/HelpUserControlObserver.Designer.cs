namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  partial class HelpUserControlObserver
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
      this.label_dsc = new System.Windows.Forms.Label();
      this.textBox_selectedobject = new System.Windows.Forms.TextBox();
      this.textBox_url = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.webBrowserHelpContent = new System.Windows.Forms.WebBrowser();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label_dsc
      // 
      this.label_dsc.AutoSize = true;
      this.label_dsc.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label_dsc.Location = new System.Drawing.Point( 3, 0 );
      this.label_dsc.Name = "label_dsc";
      this.label_dsc.Size = new System.Drawing.Size( 84, 26 );
      this.label_dsc.TabIndex = 0;
      this.label_dsc.Text = "Selected object:";
      // 
      // textBox_selectedobject
      // 
      this.textBox_selectedobject.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox_selectedobject.Location = new System.Drawing.Point( 93, 3 );
      this.textBox_selectedobject.Name = "textBox_selectedobject";
      this.textBox_selectedobject.ReadOnly = true;
      this.textBox_selectedobject.Size = new System.Drawing.Size( 119, 20 );
      this.textBox_selectedobject.TabIndex = 1;
      // 
      // textBox_url
      // 
      this.textBox_url.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox_url.Location = new System.Drawing.Point( 218, 3 );
      this.textBox_url.Name = "textBox_url";
      this.textBox_url.ReadOnly = true;
      this.textBox_url.Size = new System.Drawing.Size( 315, 20 );
      this.textBox_url.TabIndex = 2;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
      this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
      this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle() );
      this.tableLayoutPanel1.Controls.Add( this.textBox_selectedobject, 1, 0 );
      this.tableLayoutPanel1.Controls.Add( this.label_dsc, 0, 0 );
      this.tableLayoutPanel1.Controls.Add( this.textBox_url, 2, 0 );
      this.tableLayoutPanel1.Controls.Add( this.webBrowserHelpContent, 1, 1 );
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point( 0, 0 );
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
      this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle() );
      this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
      this.tableLayoutPanel1.Size = new System.Drawing.Size( 536, 460 );
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // webBrowserHelpContent
      // 
      this.tableLayoutPanel1.SetColumnSpan( this.webBrowserHelpContent, 3 );
      this.webBrowserHelpContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webBrowserHelpContent.Location = new System.Drawing.Point( 3, 29 );
      this.webBrowserHelpContent.MinimumSize = new System.Drawing.Size( 20, 20 );
      this.webBrowserHelpContent.Name = "webBrowserHelpContent";
      this.webBrowserHelpContent.Size = new System.Drawing.Size( 530, 428 );
      this.webBrowserHelpContent.TabIndex = 3;
      this.webBrowserHelpContent.Url = new System.Uri( "http://www.commsvr.com/UAModelDesigner/Index.aspx", System.UriKind.Absolute );
      // 
      // HelpUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add( this.tableLayoutPanel1 );
      this.Name = "HelpUserControl";
      this.Size = new System.Drawing.Size( 536, 460 );
      this.VisibleChanged += new System.EventHandler( this.HelpUserControl_VisibleChanged );
      this.tableLayoutPanel1.ResumeLayout( false );
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout( false );

    }

    #endregion

    private System.Windows.Forms.Label label_dsc;
    private System.Windows.Forms.TextBox textBox_selectedobject;
    private System.Windows.Forms.TextBox textBox_url;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.WebBrowser webBrowserHelpContent;
  }
}
