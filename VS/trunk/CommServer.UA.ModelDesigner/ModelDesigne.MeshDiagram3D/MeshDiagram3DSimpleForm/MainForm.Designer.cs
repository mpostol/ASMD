namespace MeshDiagram3D.SimpleForm
{
  partial class MainForm
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
      this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
      this.panel3DUserControl1 = new MeshDiagram3D.Panel3DUserControl();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.coordinateSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.directoryTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // elementHost1
      // 
      this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.elementHost1.Location = new System.Drawing.Point(12, 27);
      this.elementHost1.Name = "elementHost1";
      this.elementHost1.Size = new System.Drawing.Size(574, 431);
      this.elementHost1.TabIndex = 0;
      this.elementHost1.Text = "elementHost1";
      this.elementHost1.Child = this.panel3DUserControl1;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(598, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordinateSystemToolStripMenuItem,
            this.directoryTreeToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
      this.viewToolStripMenuItem.Text = "View";
      // 
      // coordinateSystemToolStripMenuItem
      // 
      this.coordinateSystemToolStripMenuItem.Name = "coordinateSystemToolStripMenuItem";
      this.coordinateSystemToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.coordinateSystemToolStripMenuItem.Text = "Coordinate system";
      this.coordinateSystemToolStripMenuItem.Click += new System.EventHandler(this.coordinateSystemToolStripMenuItem_Click);
      // 
      // directoryTreeToolStripMenuItem
      // 
      this.directoryTreeToolStripMenuItem.Name = "directoryTreeToolStripMenuItem";
      this.directoryTreeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.directoryTreeToolStripMenuItem.Text = "Directory Tree";
      this.directoryTreeToolStripMenuItem.Click += new System.EventHandler(this.directoryTreeToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(598, 470);
      this.Controls.Add(this.elementHost1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "Panel3D Form";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Integration.ElementHost elementHost1;
    private MeshDiagram3D.Panel3DUserControl panel3DUserControl1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem coordinateSystemToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem directoryTreeToolStripMenuItem;
  }
}

