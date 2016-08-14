namespace CAS.UA.Model.Designer
{
  partial class Main
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.SplitContainer splitContainer1;
      System.Windows.Forms.ToolStripContainer m_TreeViewToolStripContainer;
      this.m_TreeViewToolStrip = new System.Windows.Forms.ToolStrip();
      this.m_ToolStripLabelObjectType = new CAS.UA.Model.Designer.Controls.NodeObserver.ToolStripNodeClassLabelOberver();
      this.tabControl_forTrees = new System.Windows.Forms.TabControl();
      this.tabPage_tree_model = new System.Windows.Forms.TabPage();
      this.m_ModelObserver = new CAS.UA.Model.Designer.Controls.NodeObserver.ModelObserver();
      this.tabPage_tree_browseView = new System.Windows.Forms.TabPage();
      this.m_browseViewObserver = new CAS.UA.Model.Designer.Controls.NodeObserver.BrowseViewObserver();
      this.tabPage_View3DModel = new System.Windows.Forms.TabPage();
      this.view3DModelObserver1 = new CAS.UA.Model.Designer.Controls.NodeObserver.View3DModelObserver();
      this.m_tabControl = new System.Windows.Forms.TabControl();
      this.m_TabPageProperties = new System.Windows.Forms.TabPage();
      this.m_NodePropertyObserver = new CAS.UA.Model.Designer.Controls.NodeObserver.NodePropertyObserver();
      this.m_TabPageDataBindings = new System.Windows.Forms.TabPage();
      this.m_BindingsPropertyObserver = new CAS.UA.Model.Designer.Controls.NodeObserver.BindingsPropertyObserver();
      this.m_HelpProvider = new System.Windows.Forms.HelpProvider();
      this.m_ViewTabControlManager = new CAS.Lib.ControlLibrary.TabControlManager( this.components );
      this.m_selectedItemObserverComponent = new CAS.UA.Model.Designer.Controls.NodeObserver.SelectedItemObserverComponent( this.components );
      splitContainer1 = new System.Windows.Forms.SplitContainer();
      m_TreeViewToolStripContainer = new System.Windows.Forms.ToolStripContainer();
      splitContainer1.Panel1.SuspendLayout();
      splitContainer1.Panel2.SuspendLayout();
      splitContainer1.SuspendLayout();
      m_TreeViewToolStripContainer.BottomToolStripPanel.SuspendLayout();
      m_TreeViewToolStripContainer.ContentPanel.SuspendLayout();
      m_TreeViewToolStripContainer.SuspendLayout();
      this.m_TreeViewToolStrip.SuspendLayout();
      this.tabControl_forTrees.SuspendLayout();
      this.tabPage_tree_model.SuspendLayout();
      this.tabPage_tree_browseView.SuspendLayout();
      this.tabPage_View3DModel.SuspendLayout();
      this.m_tabControl.SuspendLayout();
      this.m_TabPageProperties.SuspendLayout();
      this.m_TabPageDataBindings.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      splitContainer1.Location = new System.Drawing.Point( 0, 0 );
      splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      splitContainer1.Panel1.Controls.Add( m_TreeViewToolStripContainer );
      // 
      // splitContainer1.Panel2
      // 
      splitContainer1.Panel2.Controls.Add( this.m_tabControl );
      splitContainer1.Size = new System.Drawing.Size( 674, 521 );
      splitContainer1.SplitterDistance = 200;
      splitContainer1.TabIndex = 0;
      // 
      // m_TreeViewToolStripContainer
      // 
      // 
      // m_TreeViewToolStripContainer.BottomToolStripPanel
      // 
      m_TreeViewToolStripContainer.BottomToolStripPanel.Controls.Add( this.m_TreeViewToolStrip );
      // 
      // m_TreeViewToolStripContainer.ContentPanel
      // 
      m_TreeViewToolStripContainer.ContentPanel.Controls.Add( this.tabControl_forTrees );
      m_TreeViewToolStripContainer.ContentPanel.Size = new System.Drawing.Size( 200, 471 );
      m_TreeViewToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // m_TreeViewToolStripContainer.LeftToolStripPanel
      // 
      m_TreeViewToolStripContainer.LeftToolStripPanel.Enabled = false;
      m_TreeViewToolStripContainer.LeftToolStripPanelVisible = false;
      m_TreeViewToolStripContainer.Location = new System.Drawing.Point( 0, 0 );
      m_TreeViewToolStripContainer.Name = "m_TreeViewToolStripContainer";
      // 
      // m_TreeViewToolStripContainer.RightToolStripPanel
      // 
      m_TreeViewToolStripContainer.RightToolStripPanel.Enabled = false;
      m_TreeViewToolStripContainer.RightToolStripPanelVisible = false;
      m_TreeViewToolStripContainer.Size = new System.Drawing.Size( 200, 521 );
      m_TreeViewToolStripContainer.TabIndex = 1;
      m_TreeViewToolStripContainer.Text = "toolStripContainer2";
      // 
      // m_TreeViewToolStrip
      // 
      this.m_TreeViewToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.m_TreeViewToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.m_ToolStripLabelObjectType} );
      this.m_TreeViewToolStrip.Location = new System.Drawing.Point( 3, 0 );
      this.m_TreeViewToolStrip.Name = "m_TreeViewToolStrip";
      this.m_TreeViewToolStrip.Size = new System.Drawing.Size( 133, 25 );
      this.m_TreeViewToolStrip.TabIndex = 1;
      this.m_TreeViewToolStrip.Text = "ToolStrip";
      // 
      // m_ToolStripLabelObjectType
      // 
      this.m_ToolStripLabelObjectType.AutoSize = false;
      // 
      // m_ToolStripLabelObjectType
      // 
      this.m_ToolStripLabelObjectType.MyNodeClassLabelOberver.AccessibleName = "m_ToolStripLabelObjectType";
      this.m_ToolStripLabelObjectType.MyNodeClassLabelOberver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.m_ToolStripLabelObjectType.MyNodeClassLabelOberver.Location = new System.Drawing.Point( 7, 1 );
      this.m_ToolStripLabelObjectType.MyNodeClassLabelOberver.Name = "NodeClassLabelObserver";
      this.m_ToolStripLabelObjectType.MyNodeClassLabelOberver.Size = new System.Drawing.Size( 100, 22 );
      this.m_ToolStripLabelObjectType.MyNodeClassLabelOberver.TabIndex = 0;
      this.m_ToolStripLabelObjectType.Name = "m_ToolStripLabelObjectType";
      this.m_ToolStripLabelObjectType.Size = new System.Drawing.Size( 100, 22 );
      // 
      // tabControl_forTrees
      // 
      this.tabControl_forTrees.Controls.Add( this.tabPage_tree_model );
      this.tabControl_forTrees.Controls.Add( this.tabPage_tree_browseView );
      this.tabControl_forTrees.Controls.Add( this.tabPage_View3DModel );
      this.tabControl_forTrees.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl_forTrees.Location = new System.Drawing.Point( 0, 0 );
      this.tabControl_forTrees.Name = "tabControl_forTrees";
      this.tabControl_forTrees.SelectedIndex = 0;
      this.tabControl_forTrees.Size = new System.Drawing.Size( 200, 471 );
      this.tabControl_forTrees.TabIndex = 1;
      // 
      // tabPage_tree_model
      // 
      this.tabPage_tree_model.Controls.Add( this.m_ModelObserver );
      this.tabPage_tree_model.Location = new System.Drawing.Point( 4, 22 );
      this.tabPage_tree_model.Name = "tabPage_tree_model";
      this.tabPage_tree_model.Padding = new System.Windows.Forms.Padding( 3 );
      this.tabPage_tree_model.Size = new System.Drawing.Size( 192, 445 );
      this.tabPage_tree_model.TabIndex = 0;
      this.tabPage_tree_model.Text = "Model";
      this.tabPage_tree_model.UseVisualStyleBackColor = true;
      // 
      // m_ModelObserver
      // 
      this.m_ModelObserver.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_ModelObserver.Location = new System.Drawing.Point( 3, 3 );
      this.m_ModelObserver.Name = "m_ModelObserver";
      this.m_ModelObserver.Size = new System.Drawing.Size( 186, 439 );
      this.m_ModelObserver.TabIndex = 0;
      // 
      // tabPage_tree_browseView
      // 
      this.tabPage_tree_browseView.Controls.Add( this.m_browseViewObserver );
      this.tabPage_tree_browseView.Location = new System.Drawing.Point( 4, 22 );
      this.tabPage_tree_browseView.Name = "tabPage_tree_browseView";
      this.tabPage_tree_browseView.Padding = new System.Windows.Forms.Padding( 3 );
      this.tabPage_tree_browseView.Size = new System.Drawing.Size( 192, 445 );
      this.tabPage_tree_browseView.TabIndex = 1;
      this.tabPage_tree_browseView.Text = "Browse View";
      this.tabPage_tree_browseView.UseVisualStyleBackColor = true;
      // 
      // m_browseViewObserver
      // 
      this.m_browseViewObserver.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_browseViewObserver.Location = new System.Drawing.Point( 3, 3 );
      this.m_browseViewObserver.Name = "m_browseViewObserver";
      this.m_browseViewObserver.Size = new System.Drawing.Size( 186, 439 );
      this.m_browseViewObserver.TabIndex = 0;
      // 
      // tabPage_View3DModel
      // 
      this.tabPage_View3DModel.Controls.Add( this.view3DModelObserver1 );
      this.tabPage_View3DModel.Location = new System.Drawing.Point( 4, 22 );
      this.tabPage_View3DModel.Name = "tabPage_View3DModel";
      this.tabPage_View3DModel.Padding = new System.Windows.Forms.Padding( 3 );
      this.tabPage_View3DModel.Size = new System.Drawing.Size( 192, 445 );
      this.tabPage_View3DModel.TabIndex = 2;
      this.tabPage_View3DModel.Text = "Model 3D";
      this.tabPage_View3DModel.UseVisualStyleBackColor = true;
      // 
      // view3DModelObserver1
      // 
      this.view3DModelObserver1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.view3DModelObserver1.Location = new System.Drawing.Point( 3, 3 );
      this.view3DModelObserver1.Name = "view3DModelObserver1";
      this.view3DModelObserver1.Size = new System.Drawing.Size( 186, 439 );
      this.view3DModelObserver1.TabIndex = 0;
      // 
      // m_tabControl
      // 
      this.m_tabControl.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                  | System.Windows.Forms.AnchorStyles.Left )
                  | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.m_tabControl.Controls.Add( this.m_TabPageProperties );
      this.m_tabControl.Controls.Add( this.m_TabPageDataBindings );
      this.m_tabControl.Location = new System.Drawing.Point( 3, 0 );
      this.m_tabControl.Name = "m_tabControl";
      this.m_tabControl.SelectedIndex = 0;
      this.m_tabControl.Size = new System.Drawing.Size( 467, 521 );
      this.m_tabControl.TabIndex = 1;
      // 
      // m_TabPageProperties
      // 
      this.m_TabPageProperties.Controls.Add( this.m_NodePropertyObserver );
      this.m_TabPageProperties.Location = new System.Drawing.Point( 4, 22 );
      this.m_TabPageProperties.Name = "m_TabPageProperties";
      this.m_TabPageProperties.Padding = new System.Windows.Forms.Padding( 3 );
      this.m_TabPageProperties.Size = new System.Drawing.Size( 459, 495 );
      this.m_TabPageProperties.TabIndex = 0;
      this.m_TabPageProperties.Text = "Properties";
      this.m_TabPageProperties.UseVisualStyleBackColor = true;
      // 
      // m_NodePropertyObserver
      // 
      this.m_NodePropertyObserver.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_NodePropertyObserver.Location = new System.Drawing.Point( 3, 3 );
      this.m_NodePropertyObserver.Name = "m_NodePropertyObserver";
      this.m_NodePropertyObserver.Size = new System.Drawing.Size( 453, 489 );
      this.m_NodePropertyObserver.TabIndex = 0;
      // 
      // m_TabPageDataBindings
      // 
      this.m_TabPageDataBindings.Controls.Add( this.m_BindingsPropertyObserver );
      this.m_TabPageDataBindings.Location = new System.Drawing.Point( 4, 22 );
      this.m_TabPageDataBindings.Name = "m_TabPageDataBindings";
      this.m_TabPageDataBindings.Padding = new System.Windows.Forms.Padding( 3 );
      this.m_TabPageDataBindings.Size = new System.Drawing.Size( 459, 495 );
      this.m_TabPageDataBindings.TabIndex = 1;
      this.m_TabPageDataBindings.Text = "Data Bindings";
      this.m_TabPageDataBindings.UseVisualStyleBackColor = true;
      // 
      // m_BindingsPropertyObserver
      // 
      this.m_BindingsPropertyObserver.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_BindingsPropertyObserver.Location = new System.Drawing.Point( 3, 3 );
      this.m_BindingsPropertyObserver.Name = "m_BindingsPropertyObserver";
      this.m_BindingsPropertyObserver.Size = new System.Drawing.Size( 453, 489 );
      this.m_BindingsPropertyObserver.TabIndex = 0;
      // 
      // m_ViewTabControlManager
      // 
      this.m_ViewTabControlManager.TabControl = this.tabControl_forTrees;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add( splitContainer1 );
      this.Name = "Main";
      this.Size = new System.Drawing.Size( 674, 521 );
      splitContainer1.Panel1.ResumeLayout( false );
      splitContainer1.Panel2.ResumeLayout( false );
      splitContainer1.ResumeLayout( false );
      m_TreeViewToolStripContainer.BottomToolStripPanel.ResumeLayout( false );
      m_TreeViewToolStripContainer.BottomToolStripPanel.PerformLayout();
      m_TreeViewToolStripContainer.ContentPanel.ResumeLayout( false );
      m_TreeViewToolStripContainer.ResumeLayout( false );
      m_TreeViewToolStripContainer.PerformLayout();
      this.m_TreeViewToolStrip.ResumeLayout( false );
      this.m_TreeViewToolStrip.PerformLayout();
      this.tabControl_forTrees.ResumeLayout( false );
      this.tabPage_tree_model.ResumeLayout( false );
      this.tabPage_tree_browseView.ResumeLayout( false );
      this.tabPage_View3DModel.ResumeLayout( false );
      this.m_tabControl.ResumeLayout( false );
      this.m_TabPageProperties.ResumeLayout( false );
      this.m_TabPageDataBindings.ResumeLayout( false );
      this.ResumeLayout( false );
      this.PerformLayout();

    }

    #endregion

    private CAS.UA.Model.Designer.Controls.NodeObserver.ModelObserver m_ModelObserver;
    private CAS.UA.Model.Designer.Controls.NodeObserver.BindingsPropertyObserver m_BindingsPropertyObserver;
    private CAS.UA.Model.Designer.Controls.NodeObserver.NodePropertyObserver m_NodePropertyObserver;
    private System.Windows.Forms.ToolStrip m_TreeViewToolStrip;
    private CAS.UA.Model.Designer.Controls.NodeObserver.ToolStripNodeClassLabelOberver m_ToolStripLabelObjectType;
    private System.Windows.Forms.HelpProvider m_HelpProvider;
    private System.Windows.Forms.TabControl m_tabControl;
    private System.Windows.Forms.TabPage m_TabPageProperties;
    private System.Windows.Forms.TabPage m_TabPageDataBindings;
    private System.Windows.Forms.TabControl tabControl_forTrees;
    private System.Windows.Forms.TabPage tabPage_tree_model;
    private System.Windows.Forms.TabPage tabPage_tree_browseView;
    private CAS.UA.Model.Designer.Controls.NodeObserver.BrowseViewObserver m_browseViewObserver;
    private CAS.Lib.ControlLibrary.TabControlManager m_ViewTabControlManager;
    private System.Windows.Forms.TabPage tabPage_View3DModel;
    private CAS.UA.Model.Designer.Controls.NodeObserver.View3DModelObserver view3DModelObserver1;
    private CAS.UA.Model.Designer.Controls.NodeObserver.SelectedItemObserverComponent m_selectedItemObserverComponent;

  }
}