namespace CAS.UA.Model.Designer.StateMachineEditor
{
  partial class StateMachineCrossTable
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( StateMachineCrossTable ) );
      this.panelStateMachine = new System.Windows.Forms.Panel();
      this.tableLayoutPanelCrossTable = new System.Windows.Forms.TableLayoutPanel();
      this.panelStateMachine.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelStateMachine
      // 
      this.panelStateMachine.AutoScroll = true;
      this.panelStateMachine.AutoSize = true;
      this.panelStateMachine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panelStateMachine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panelStateMachine.Controls.Add( this.tableLayoutPanelCrossTable );
      this.panelStateMachine.Location = new System.Drawing.Point( 1, -1 );
      this.panelStateMachine.Name = "panelStateMachine";
      this.panelStateMachine.Size = new System.Drawing.Size( 19, 19 );
      this.panelStateMachine.TabIndex = 1;
      // 
      // tableLayoutPanelCrossTable
      // 
      this.tableLayoutPanelCrossTable.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                  | System.Windows.Forms.AnchorStyles.Left )
                  | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.tableLayoutPanelCrossTable.AutoScroll = true;
      this.tableLayoutPanelCrossTable.AutoSize = true;
      this.tableLayoutPanelCrossTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanelCrossTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
      this.tableLayoutPanelCrossTable.ColumnCount = 2;
      this.tableLayoutPanelCrossTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
      this.tableLayoutPanelCrossTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
      this.tableLayoutPanelCrossTable.Location = new System.Drawing.Point( 3, 3 );
      this.tableLayoutPanelCrossTable.Name = "tableLayoutPanelCrossTable";
      this.tableLayoutPanelCrossTable.RowCount = 2;
      this.tableLayoutPanelCrossTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
      this.tableLayoutPanelCrossTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
      this.tableLayoutPanelCrossTable.Size = new System.Drawing.Size( 9, 9 );
      this.tableLayoutPanelCrossTable.TabIndex = 1;
      // 
      // windowStateMachineCrossTable
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size( 410, 366 );
      this.Controls.Add( this.panelStateMachine );
      this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
      this.KeyPreview = true;
      this.Name = "windowStateMachineCrossTable";
      this.Text = "State machine cross-table";
      this.panelStateMachine.ResumeLayout( false );
      this.panelStateMachine.PerformLayout();
      this.ResumeLayout( false );
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panelStateMachine;
    public System.Windows.Forms.TableLayoutPanel tableLayoutPanelCrossTable;

  }
}