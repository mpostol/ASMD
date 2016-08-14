namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  partial class PropertyGridObserver
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
      this.m_propertyGrid = new System.Windows.Forms.PropertyGrid();
      this.m_propertyGridExpandAllExpander = new CAS.Lib.ControlLibrary.PropertyGridExpandAllExpander( this.components );
      this.SuspendLayout();
      // 
      // m_propertyGrid
      // 
      this.m_propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_propertyGrid.Location = new System.Drawing.Point( 0, 0 );
      this.m_propertyGrid.Name = "m_propertyGrid";
      this.m_propertyGrid.Size = new System.Drawing.Size( 150, 150 );
      this.m_propertyGrid.TabIndex = 0;
      // 
      // m_propertyGridExpandAllExpander
      // 
      this.m_propertyGridExpandAllExpander.MyPropertyGrid = null;
      // 
      // PropertyGridObserver
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add( this.m_propertyGrid );
      this.Name = "PropertyGridObserver";
      this.ResumeLayout( false );

    }

    #endregion

    private System.Windows.Forms.PropertyGrid m_propertyGrid;
    private CAS.Lib.ControlLibrary.PropertyGridExpandAllExpander m_propertyGridExpandAllExpander;
  }
}
