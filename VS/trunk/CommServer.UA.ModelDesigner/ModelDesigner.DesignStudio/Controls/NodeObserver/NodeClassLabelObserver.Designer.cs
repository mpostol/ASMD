namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  partial class NodeClassLabelObserver
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
      this.m_label = new System.Windows.Forms.Label();
      this.m_toolTip = new System.Windows.Forms.ToolTip( this.components );
      this.SuspendLayout();
      // 
      // m_label
      // 
      this.m_label.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_label.Location = new System.Drawing.Point( 0, 0 );
      this.m_label.Name = "m_label";
      this.m_label.Size = new System.Drawing.Size( 108, 15 );
      this.m_label.TabIndex = 0;
      this.m_label.Text = "OPC UA Node Class";
      this.m_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.m_toolTip.SetToolTip( this.m_label, "OPC UA node class of the selected node" );
      // 
      // NodeClassLabelObserver
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Controls.Add( this.m_label );
      this.Name = "NodeClassLabelObserver";
      this.Size = new System.Drawing.Size( 108, 15 );
      this.ResumeLayout( false );

    }

    #endregion

    private System.Windows.Forms.Label m_label;
    private System.Windows.Forms.ToolTip m_toolTip;
  }
}
