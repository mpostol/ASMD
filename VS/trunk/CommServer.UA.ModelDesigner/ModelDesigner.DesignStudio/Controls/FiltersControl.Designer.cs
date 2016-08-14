using System.Windows.Forms;
namespace CAS.UA.Model.Designer.Controls
{
  partial class FiltersControl
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
      this.main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.button_remove_all_filters = new System.Windows.Forms.Button();
      this.checkBox_customfilter = new System.Windows.Forms.CheckBox();
      this.checkBox_AllDataTypes = new System.Windows.Forms.CheckBox();
      this.checkedListBox_datatypes = new System.Windows.Forms.CheckedListBox();
      this.toolTip_button_remove_all_filters = new System.Windows.Forms.ToolTip( this.components );
      this.toolTip_checkBox_customfilter = new System.Windows.Forms.ToolTip( this.components );
      this.toolTip_checkBox_AllDataTypes = new System.Windows.Forms.ToolTip( this.components );
      this.main_tableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // main_tableLayoutPanel
      // 
      this.main_tableLayoutPanel.ColumnCount = 2;
      this.main_tableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
      this.main_tableLayoutPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
      this.main_tableLayoutPanel.Controls.Add( this.button_remove_all_filters, 0, 2 );
      this.main_tableLayoutPanel.Controls.Add( this.checkBox_customfilter, 1, 0 );
      this.main_tableLayoutPanel.Controls.Add( this.checkBox_AllDataTypes, 0, 0 );
      this.main_tableLayoutPanel.Controls.Add( this.checkedListBox_datatypes, 0, 1 );
      this.main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.main_tableLayoutPanel.Location = new System.Drawing.Point( 0, 0 );
      this.main_tableLayoutPanel.Name = "main_tableLayoutPanel";
      this.main_tableLayoutPanel.RowCount = 3;
      this.main_tableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 16.05839F ) );
      this.main_tableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 83.9416F ) );
      this.main_tableLayoutPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 33F ) );
      this.main_tableLayoutPanel.Size = new System.Drawing.Size( 330, 177 );
      this.main_tableLayoutPanel.TabIndex = 0;
      // 
      // button_remove_all_filters
      // 
      this.main_tableLayoutPanel.SetColumnSpan( this.button_remove_all_filters, 2 );
      this.button_remove_all_filters.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button_remove_all_filters.Location = new System.Drawing.Point( 3, 146 );
      this.button_remove_all_filters.Name = "button_remove_all_filters";
      this.button_remove_all_filters.Size = new System.Drawing.Size( 324, 28 );
      this.button_remove_all_filters.TabIndex = 0;
      this.button_remove_all_filters.Text = "Remove All Filters";
      this.toolTip_button_remove_all_filters.SetToolTip( this.button_remove_all_filters, "Removes all filters, so all model elements are shown" );
      this.button_remove_all_filters.UseVisualStyleBackColor = true;
      this.button_remove_all_filters.Click += new System.EventHandler( this.button_remove_all_filters_Click );
      // 
      // checkBox_customfilter
      // 
      this.checkBox_customfilter.AutoSize = true;
      this.checkBox_customfilter.Enabled = false;
      this.checkBox_customfilter.Location = new System.Drawing.Point( 168, 3 );
      this.checkBox_customfilter.Name = "checkBox_customfilter";
      this.checkBox_customfilter.Size = new System.Drawing.Size( 86, 17 );
      this.checkBox_customfilter.TabIndex = 2;
      this.checkBox_customfilter.Text = "Custom Filter";
      this.toolTip_checkBox_customfilter.SetToolTip( this.checkBox_customfilter, "Select custom filter" );
      this.checkBox_customfilter.UseVisualStyleBackColor = true;
      this.checkBox_customfilter.CheckedChanged += new System.EventHandler( this.checkBox_customfilter_CheckedChanged );
      // 
      // checkBox_AllDataTypes
      // 
      this.checkBox_AllDataTypes.AutoSize = true;
      this.checkBox_AllDataTypes.Checked = true;
      this.checkBox_AllDataTypes.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_AllDataTypes.Location = new System.Drawing.Point( 3, 3 );
      this.checkBox_AllDataTypes.Name = "checkBox_AllDataTypes";
      this.checkBox_AllDataTypes.Size = new System.Drawing.Size( 105, 17 );
      this.checkBox_AllDataTypes.TabIndex = 2;
      this.checkBox_AllDataTypes.Text = "All Node Classes";
      this.toolTip_checkBox_AllDataTypes.SetToolTip( this.checkBox_AllDataTypes, "If this box is slected, all model elements are shown" );
      this.checkBox_AllDataTypes.UseVisualStyleBackColor = true;
      this.checkBox_AllDataTypes.CheckedChanged += new System.EventHandler( this.checkBox_AllDataTypes_CheckedChanged );
      // 
      // checkedListBox_datatypes
      // 
      this.main_tableLayoutPanel.SetColumnSpan( this.checkedListBox_datatypes, 2 );
      this.checkedListBox_datatypes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.checkedListBox_datatypes.Enabled = false;
      this.checkedListBox_datatypes.FormattingEnabled = true;
      this.checkedListBox_datatypes.Location = new System.Drawing.Point( 3, 26 );
      this.checkedListBox_datatypes.MultiColumn = true;
      this.checkedListBox_datatypes.Name = "checkedListBox_datatypes";
      this.checkedListBox_datatypes.Size = new System.Drawing.Size( 324, 109 );
      this.checkedListBox_datatypes.TabIndex = 3;
      // 
      // toolTip_button_remove_all_filters
      // 
      this.toolTip_button_remove_all_filters.AutoPopDelay = 3000;
      this.toolTip_button_remove_all_filters.InitialDelay = 500;
      this.toolTip_button_remove_all_filters.ReshowDelay = 500;
      this.toolTip_button_remove_all_filters.ShowAlways = true;
      // 
      // toolTip_checkBox_customfilter
      // 
      this.toolTip_checkBox_customfilter.AutoPopDelay = 3000;
      this.toolTip_checkBox_customfilter.InitialDelay = 500;
      this.toolTip_checkBox_customfilter.ReshowDelay = 500;
      this.toolTip_checkBox_customfilter.ShowAlways = true;
      // 
      // toolTip_checkBox_AllDataTypes
      // 
      this.toolTip_checkBox_AllDataTypes.AutoPopDelay = 3000;
      this.toolTip_checkBox_AllDataTypes.InitialDelay = 500;
      this.toolTip_checkBox_AllDataTypes.ReshowDelay = 500;
      this.toolTip_checkBox_AllDataTypes.ShowAlways = true;
      // 
      // FiltersControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add( this.main_tableLayoutPanel );
      this.Name = "FiltersControl";
      this.Size = new System.Drawing.Size( 330, 177 );
      this.main_tableLayoutPanel.ResumeLayout( false );
      this.main_tableLayoutPanel.PerformLayout();
      this.ResumeLayout( false );

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel main_tableLayoutPanel;
    private System.Windows.Forms.Button button_remove_all_filters;
    private System.Windows.Forms.CheckBox checkBox_customfilter;
    private System.Windows.Forms.CheckBox checkBox_AllDataTypes;
    private System.Windows.Forms.CheckedListBox checkedListBox_datatypes;
    private ToolTip toolTip_button_remove_all_filters;
    private ToolTip toolTip_checkBox_customfilter;
    private ToolTip toolTip_checkBox_AllDataTypes;
  }
}
