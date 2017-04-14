namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  partial class ModelObserver
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ModelObserver ) );
      this.components = new System.ComponentModel.Container();
      this.m_TreeView = new DictionaryTreeView();
      this.m_ImagesForNodes = new CAS.UA.Model.Designer.ImagesForNodes( this.components );
      this.m_toolStripContainer = new System.Windows.Forms.ToolStripContainer();
      this.m_BackForwardTreViewToolStrip = new CAS.Lib.ControlLibrary.BackForwardTreViewToolStrip();
      this.m_SearchTreeViewToolStrip = new CAS.Lib.ControlLibrary.SearchTreeViewToolStrip();
      this.m_ToolStripOtherTools = new System.Windows.Forms.ToolStrip();
      this.toolStripButton_filter = new System.Windows.Forms.ToolStripButton();
      this.m_toolStripContainer.ContentPanel.SuspendLayout();
      this.m_toolStripContainer.TopToolStripPanel.SuspendLayout();
      this.m_toolStripContainer.SuspendLayout();
      this.m_ToolStripOtherTools.SuspendLayout();
      this.SuspendLayout();
      // 
      // m_TreeView
      // 
      this.m_TreeView.CoupledNodesAreEnabled = true;
      this.m_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_TreeView.Location = new System.Drawing.Point( 0, 0 );
      this.m_TreeView.Name = "m_TreeView";
      this.m_TreeView.SelectedNode = null;
      this.m_TreeView.ShowNodeToolTips = true;
      this.m_TreeView.Size = new System.Drawing.Size( 326, 271 );
      this.m_TreeView.TabIndex = 0;
      this.m_TreeView.RefreshNeeded += new System.EventHandler<DictionaryTreeView.RefreshScopeEventArgs>( this.m_TreeView_RefreshNeeded );
      this.m_TreeView.AfterSelect += new DictionaryTreeView.DictionaryTreeViewEventHandler( this.m_TreeView_AfterSelect );
      // 
      // m_toolStripContainer
      // 
      // 
      // m_toolStripContainer.ContentPanel
      // 
      this.m_toolStripContainer.ContentPanel.Controls.Add( this.m_TreeView );
      this.m_toolStripContainer.ContentPanel.Size = new System.Drawing.Size( 326, 271 );
      this.m_toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_toolStripContainer.Location = new System.Drawing.Point( 0, 0 );
      this.m_toolStripContainer.Name = "m_toolStripContainer";
      this.m_toolStripContainer.Size = new System.Drawing.Size( 326, 321 );
      this.m_toolStripContainer.TabIndex = 1;
      this.m_toolStripContainer.Text = "toolStripContainer1";
      // 
      // m_toolStripContainer.TopToolStripPanel
      // 
      this.m_toolStripContainer.TopToolStripPanel.Controls.Add( this.m_BackForwardTreViewToolStrip );
      this.m_toolStripContainer.TopToolStripPanel.Controls.Add( this.m_ToolStripOtherTools );
      this.m_toolStripContainer.TopToolStripPanel.Controls.Add( this.m_SearchTreeViewToolStrip );
      // 
      // m_BackForwardTreViewToolStrip
      // 
      this.m_BackForwardTreViewToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.m_BackForwardTreViewToolStrip.Location = new System.Drawing.Point( 69, 0 );
      this.m_BackForwardTreViewToolStrip.Name = "m_BackForwardTreViewToolStrip";
      this.m_BackForwardTreViewToolStrip.NumberOfPreviousNodesInTheTooltip = 5;
      this.m_BackForwardTreViewToolStrip.Size = new System.Drawing.Size( 120, 25 );
      this.m_BackForwardTreViewToolStrip.TabIndex = 0;
      this.m_BackForwardTreViewToolStrip.Text = "Navigate: ";
      this.m_BackForwardTreViewToolStrip.ToolStripBackwardImage = null;
      this.m_BackForwardTreViewToolStrip.ToolStripForwardImage = null;
      this.m_BackForwardTreViewToolStrip.TreeView = null;
      // 
      // m_SearchTreeViewToolStrip
      // 
      this.m_SearchTreeViewToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.m_SearchTreeViewToolStrip.InformationCannotBeFound = "Searched element cannot be found";
      this.m_SearchTreeViewToolStrip.InformationEndIsPassed = "End of the tree is passed";
      this.m_SearchTreeViewToolStrip.InformationStartIsPassed = "Start of the tree is passed";
      this.m_SearchTreeViewToolStrip.Location = new System.Drawing.Point( 3, 25 );
      this.m_SearchTreeViewToolStrip.Name = "m_SearchTreeViewToolStrip";
      this.m_SearchTreeViewToolStrip.Size = new System.Drawing.Size( 323, 25 );
      this.m_SearchTreeViewToolStrip.TabIndex = 1;
      this.m_SearchTreeViewToolStrip.Text = "Search:";
      this.m_SearchTreeViewToolStrip.ToolStripBackwardImage = null;
      this.m_SearchTreeViewToolStrip.ToolStripForwardImage = null;
      this.m_SearchTreeViewToolStrip.TreeView = null;
      // 
      // m_ToolStripOtherTools
      // 
      this.m_ToolStripOtherTools.Dock = System.Windows.Forms.DockStyle.None;
      this.m_ToolStripOtherTools.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_filter} );
      this.m_ToolStripOtherTools.Location = new System.Drawing.Point( 3, 0 );
      this.m_ToolStripOtherTools.Name = "m_ToolStripOtherTools";
      this.m_ToolStripOtherTools.Size = new System.Drawing.Size( 66, 25 );
      this.m_ToolStripOtherTools.TabIndex = 2;
      // 
      // toolStripButton_filter
      // 
      this.toolStripButton_filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton_filter.Image = global::CAS.UA.Model.Designer.Properties.Resources.FilterHS;
      this.toolStripButton_filter.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton_filter.Name = "toolStripButton_filter";
      this.toolStripButton_filter.Size = new System.Drawing.Size( 23, 22 );
      this.toolStripButton_filter.Text = "toolStripButton1";
      this.toolStripButton_filter.Click += new System.EventHandler( this.toolStripButton_filter_Click );
      // 
      // ModelObserver
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add( this.m_toolStripContainer );
      this.Name = "ModelObserver";
      this.Size = new System.Drawing.Size( 326, 321 );
      this.m_toolStripContainer.ContentPanel.ResumeLayout( false );
      this.m_toolStripContainer.TopToolStripPanel.ResumeLayout( false );
      this.m_toolStripContainer.TopToolStripPanel.PerformLayout();
      this.m_toolStripContainer.ResumeLayout( false );
      this.m_toolStripContainer.PerformLayout();
      this.m_ToolStripOtherTools.ResumeLayout( false );
      this.m_ToolStripOtherTools.PerformLayout();
      this.ResumeLayout( false );

    }

    #endregion

    private DictionaryTreeView m_TreeView;
    private ImagesForNodes m_ImagesForNodes;
    private System.Windows.Forms.ToolStripContainer m_toolStripContainer;
    private CAS.Lib.ControlLibrary.BackForwardTreViewToolStrip m_BackForwardTreViewToolStrip;
    private CAS.Lib.ControlLibrary.SearchTreeViewToolStrip m_SearchTreeViewToolStrip;
    private System.Windows.Forms.ToolStrip m_ToolStripOtherTools;
    private System.Windows.Forms.ToolStripButton toolStripButton_filter;
  }
}
