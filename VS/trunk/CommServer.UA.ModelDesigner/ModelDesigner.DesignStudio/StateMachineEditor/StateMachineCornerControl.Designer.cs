using System.Drawing;
namespace CAS.UA.Model.Designer.StateMachineEditor
{
  partial class StateMachineCornerControl
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
      this.labelCornerControlTo = new System.Windows.Forms.Label();
      this.labelCornerControlFrom = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelCornerControlTo
      // 
      this.labelCornerControlTo.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.labelCornerControlTo.Location = new System.Drawing.Point( 60, 0 );
      this.labelCornerControlTo.Margin = new System.Windows.Forms.Padding( 0 );
      this.labelCornerControlTo.Name = "labelCornerControlTo";
      this.labelCornerControlTo.Padding = new System.Windows.Forms.Padding( 0, 3, 0, 0 );
      this.labelCornerControlTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.labelCornerControlTo.Size = new System.Drawing.Size( 46, 16 );
      this.labelCornerControlTo.TabIndex = 1;
      this.labelCornerControlTo.Text = "To state";
      // 
      // labelCornerControlFrom
      // 
      this.labelCornerControlFrom.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.labelCornerControlFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.labelCornerControlFrom.Location = new System.Drawing.Point( -3, 42 );
      this.labelCornerControlFrom.Margin = new System.Windows.Forms.Padding( 0 );
      this.labelCornerControlFrom.Name = "labelCornerControlFrom";
      this.labelCornerControlFrom.Padding = new System.Windows.Forms.Padding( 3, 0, 0, 0 );
      this.labelCornerControlFrom.Size = new System.Drawing.Size( 65, 13 );
      this.labelCornerControlFrom.TabIndex = 0;
      this.labelCornerControlFrom.Text = "From state";
      // 
      // StateMachineCornerControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.Controls.Add( this.labelCornerControlTo );
      this.Controls.Add( this.labelCornerControlFrom );
      this.Name = "StateMachineCornerControl";
      this.Size = new System.Drawing.Size( 106, 55 );
      this.ResumeLayout( false );

    }

    #endregion

    private System.Windows.Forms.Label labelCornerControlTo;
    private System.Windows.Forms.Label labelCornerControlFrom;
  }
}
