//<summary>
//  Title   : Browse Options dialog designer
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>


namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
    partial class BrowseOptionsDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          this.buttons_Panel = new System.Windows.Forms.Panel();
          this.ok_Button = new System.Windows.Forms.Button();
          this.cancel_Button = new System.Windows.Forms.Button();
          this.main_Panel = new System.Windows.Forms.Panel();
          this.referenceType_ComboBox = new System.Windows.Forms.ComboBox();
          this.nodeClassList = new System.Windows.Forms.CheckedListBox();
          this.nodeClassMask_CheckBox = new System.Windows.Forms.CheckBox();
          this.nodeClassMask_Label = new System.Windows.Forms.Label();
          this.includeSubtypes_CheckBox = new System.Windows.Forms.CheckBox();
          this.browseDirection_ComboBox = new System.Windows.Forms.ComboBox();
          this.browseDirection_Label = new System.Windows.Forms.Label();
          this.includeSubtypes_Label = new System.Windows.Forms.Label();
          this.referenceType_Label = new System.Windows.Forms.Label();
          this.buttons_Panel.SuspendLayout();
          this.main_Panel.SuspendLayout();
          this.SuspendLayout();
          // 
          // buttons_Panel
          // 
          this.buttons_Panel.Controls.Add( this.ok_Button );
          this.buttons_Panel.Controls.Add( this.cancel_Button );
          this.buttons_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
          this.buttons_Panel.Location = new System.Drawing.Point( 0, 244 );
          this.buttons_Panel.Name = "buttons_Panel";
          this.buttons_Panel.Size = new System.Drawing.Size( 346, 33 );
          this.buttons_Panel.TabIndex = 1;
          // 
          // ok_Button
          // 
          this.ok_Button.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
          this.ok_Button.Location = new System.Drawing.Point( 4, 6 );
          this.ok_Button.Name = "ok_Button";
          this.ok_Button.Size = new System.Drawing.Size( 75, 23 );
          this.ok_Button.TabIndex = 0;
          this.ok_Button.Text = "OK";
          this.ok_Button.UseVisualStyleBackColor = true;
          this.ok_Button.Click += new System.EventHandler( this.OkBTN_Click );
          // 
          // cancel_Button
          // 
          this.cancel_Button.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
          this.cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this.cancel_Button.Location = new System.Drawing.Point( 267, 6 );
          this.cancel_Button.Name = "cancel_Button";
          this.cancel_Button.Size = new System.Drawing.Size( 75, 23 );
          this.cancel_Button.TabIndex = 1;
          this.cancel_Button.Text = "Cancel";
          this.cancel_Button.UseVisualStyleBackColor = true;
          // 
          // main_Panel
          // 
          this.main_Panel.Controls.Add( this.referenceType_ComboBox );
          this.main_Panel.Controls.Add( this.nodeClassList );
          this.main_Panel.Controls.Add( this.nodeClassMask_CheckBox );
          this.main_Panel.Controls.Add( this.nodeClassMask_Label );
          this.main_Panel.Controls.Add( this.includeSubtypes_CheckBox );
          this.main_Panel.Controls.Add( this.browseDirection_ComboBox );
          this.main_Panel.Controls.Add( this.browseDirection_Label );
          this.main_Panel.Controls.Add( this.includeSubtypes_Label );
          this.main_Panel.Controls.Add( this.referenceType_Label );
          this.main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
          this.main_Panel.Location = new System.Drawing.Point( 0, 0 );
          this.main_Panel.Name = "main_Panel";
          this.main_Panel.Size = new System.Drawing.Size( 346, 244 );
          this.main_Panel.TabIndex = 2;
          // 
          // referenceType_ComboBox
          // 
          this.referenceType_ComboBox.Location = new System.Drawing.Point( 140, 37 );
          this.referenceType_ComboBox.MaximumSize = new System.Drawing.Size( 4096, 0 );
          this.referenceType_ComboBox.MinimumSize = new System.Drawing.Size( 200, 0 );
          this.referenceType_ComboBox.Name = "referenceType_ComboBox";
          this.referenceType_ComboBox.Size = new System.Drawing.Size( 200, 21 );
          this.referenceType_ComboBox.TabIndex = 14;
          // 
          // nodeClassList
          // 
          this.nodeClassList.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                      | System.Windows.Forms.AnchorStyles.Left )
                      | System.Windows.Forms.AnchorStyles.Right ) ) );
          this.nodeClassList.CheckOnClick = true;
          this.nodeClassList.Enabled = false;
          this.nodeClassList.FormattingEnabled = true;
          this.nodeClassList.Items.AddRange( new object[] {
            "Object",
            "ObjectType",
            "Variable",
            "VariableType",
            "ReferenceType",
            "DataType",
            "Method",
            "View"} );
          this.nodeClassList.Location = new System.Drawing.Point( 5, 109 );
          this.nodeClassList.Name = "nodeClassList";
          this.nodeClassList.Size = new System.Drawing.Size( 335, 124 );
          this.nodeClassList.TabIndex = 8;
          // 
          // nodeClassMask_CheckBox
          // 
          this.nodeClassMask_CheckBox.AutoSize = true;
          this.nodeClassMask_CheckBox.Location = new System.Drawing.Point( 140, 89 );
          this.nodeClassMask_CheckBox.Name = "nodeClassMask_CheckBox";
          this.nodeClassMask_CheckBox.Size = new System.Drawing.Size( 15, 14 );
          this.nodeClassMask_CheckBox.TabIndex = 13;
          this.nodeClassMask_CheckBox.UseVisualStyleBackColor = true;
          this.nodeClassMask_CheckBox.CheckedChanged += new System.EventHandler( this.NodeClassMask_CheckedChanged );
          // 
          // nodeClassMask_Label
          // 
          this.nodeClassMask_Label.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                      | System.Windows.Forms.AnchorStyles.Left )
                      | System.Windows.Forms.AnchorStyles.Right ) ) );
          this.nodeClassMask_Label.AutoSize = true;
          this.nodeClassMask_Label.Location = new System.Drawing.Point( 4, 89 );
          this.nodeClassMask_Label.Name = "nodeClassMask_Label";
          this.nodeClassMask_Label.Size = new System.Drawing.Size( 90, 13 );
          this.nodeClassMask_Label.TabIndex = 12;
          this.nodeClassMask_Label.Text = "Node Class Mask";
          this.nodeClassMask_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // includeSubtypes_CheckBox
          // 
          this.includeSubtypes_CheckBox.AutoSize = true;
          this.includeSubtypes_CheckBox.Location = new System.Drawing.Point( 140, 65 );
          this.includeSubtypes_CheckBox.Name = "includeSubtypes_CheckBox";
          this.includeSubtypes_CheckBox.Size = new System.Drawing.Size( 15, 14 );
          this.includeSubtypes_CheckBox.TabIndex = 11;
          this.includeSubtypes_CheckBox.UseVisualStyleBackColor = true;
          // 
          // browseDirection_ComboBox
          // 
          this.browseDirection_ComboBox.FormattingEnabled = true;
          this.browseDirection_ComboBox.Location = new System.Drawing.Point( 140, 13 );
          this.browseDirection_ComboBox.Name = "browseDirection_ComboBox";
          this.browseDirection_ComboBox.Size = new System.Drawing.Size( 130, 21 );
          this.browseDirection_ComboBox.TabIndex = 9;
          // 
          // browseDirection_Label
          // 
          this.browseDirection_Label.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                      | System.Windows.Forms.AnchorStyles.Left )
                      | System.Windows.Forms.AnchorStyles.Right ) ) );
          this.browseDirection_Label.AutoSize = true;
          this.browseDirection_Label.Location = new System.Drawing.Point( 4, 17 );
          this.browseDirection_Label.Name = "browseDirection_Label";
          this.browseDirection_Label.Size = new System.Drawing.Size( 87, 13 );
          this.browseDirection_Label.TabIndex = 6;
          this.browseDirection_Label.Text = "Browse Direction";
          this.browseDirection_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // includeSubtypes_Label
          // 
          this.includeSubtypes_Label.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                      | System.Windows.Forms.AnchorStyles.Left )
                      | System.Windows.Forms.AnchorStyles.Right ) ) );
          this.includeSubtypes_Label.AutoSize = true;
          this.includeSubtypes_Label.Location = new System.Drawing.Point( 4, 65 );
          this.includeSubtypes_Label.Name = "includeSubtypes_Label";
          this.includeSubtypes_Label.Size = new System.Drawing.Size( 96, 13 );
          this.includeSubtypes_Label.TabIndex = 5;
          this.includeSubtypes_Label.Text = "Include Sub Types";
          this.includeSubtypes_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // referenceType_Label
          // 
          this.referenceType_Label.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                      | System.Windows.Forms.AnchorStyles.Left )
                      | System.Windows.Forms.AnchorStyles.Right ) ) );
          this.referenceType_Label.AutoSize = true;
          this.referenceType_Label.Location = new System.Drawing.Point( 4, 41 );
          this.referenceType_Label.Name = "referenceType_Label";
          this.referenceType_Label.Size = new System.Drawing.Size( 84, 13 );
          this.referenceType_Label.TabIndex = 4;
          this.referenceType_Label.Text = "Reference Type";
          this.referenceType_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // BrowseOptionsDlg
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size( 346, 277 );
          this.Controls.Add( this.main_Panel );
          this.Controls.Add( this.buttons_Panel );
          this.Name = "BrowseOptionsDlg";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "Browse Options";
          this.buttons_Panel.ResumeLayout( false );
          this.main_Panel.ResumeLayout( false );
          this.main_Panel.PerformLayout();
          this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Panel buttons_Panel;
        private System.Windows.Forms.Button ok_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.Label browseDirection_Label;
        private System.Windows.Forms.Label includeSubtypes_Label;
        private System.Windows.Forms.Label referenceType_Label;
        private System.Windows.Forms.CheckedListBox nodeClassList;
        private System.Windows.Forms.CheckBox includeSubtypes_CheckBox;
        private System.Windows.Forms.ComboBox browseDirection_ComboBox;
        private System.Windows.Forms.CheckBox nodeClassMask_CheckBox;
        private System.Windows.Forms.Label nodeClassMask_Label;
        private System.Windows.Forms.ComboBox referenceType_ComboBox;
    }
}
