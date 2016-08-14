using System.Windows.Forms;
namespace CAS.UA.Model.Designer.StateMachineEditor
{
  partial class StateMachineControl
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
      this.buttonTransition = new CAS.UA.Model.Designer.StateMachineEditor.TransitionButton();
      this.SuspendLayout();
      // 
      // buttonTransition
      // 
      this.buttonTransition.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                  | System.Windows.Forms.AnchorStyles.Left )
                  | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.buttonTransition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.buttonTransition.FlatAppearance.BorderSize = 0;
      this.buttonTransition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonTransition.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 238 ) ) );
      this.buttonTransition.ForeColor = System.Drawing.SystemColors.Control;
      this.buttonTransition.Location = new System.Drawing.Point( -1, -1 );
      this.buttonTransition.Name = "buttonTransition";
      this.buttonTransition.Size = new System.Drawing.Size( 30, 30 );
      this.buttonTransition.TabIndex = 0;
      this.buttonTransition.UseVisualStyleBackColor = true;
      this.buttonTransition.Click += new System.EventHandler( this.buttonTransition_Click );
      ToolTip toolTip_buttonTransition = new ToolTip();
      toolTip_buttonTransition.AutoPopDelay = 3000;
      toolTip_buttonTransition.InitialDelay = 500;
      toolTip_buttonTransition.ReshowDelay = 500;
      toolTip_buttonTransition.ShowAlways = true;
      toolTip_buttonTransition.SetToolTip( this.buttonTransition, "Change transition data" );
      // 
      // StateMachineControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add( this.buttonTransition );
      this.Name = "StateMachineControl";
      this.Size = new System.Drawing.Size( 30, 30 );
      this.ResumeLayout( false );

    }

    #endregion

    internal TransitionButton buttonTransition;


  }
}
