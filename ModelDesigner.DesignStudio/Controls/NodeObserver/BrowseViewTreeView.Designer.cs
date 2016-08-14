using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  partial class BrowseViewTreeView
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
      this.m_ImagesForNodes = new CAS.UA.Model.Designer.ImagesForNodes( this.components );
      this.SuspendLayout();
      // 
      // BrowseViewTreeView
      // 
      this.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler( this.BrowseViewTreeView_BeforeExpand );
      this.ResumeLayout( false );

    }

    #endregion

    private ImagesForNodes m_ImagesForNodes;
  }
}
