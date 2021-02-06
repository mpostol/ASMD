using System.Windows.Forms;
using UAOOI.Windows.Forms;

namespace CAS.UA.Model.Designer
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
      System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
      this.statusStrip_WindowBottomStrip = new System.Windows.Forms.StatusStrip();
      this.tabControl_Main = new System.Windows.Forms.TabControl();
      this.tabPage_main = new System.Windows.Forms.TabPage();
      this.m_MainContol = new CAS.UA.Model.Designer.Main();
      this.tabPage_help = new System.Windows.Forms.TabPage();
      this.helpUserControl = new CAS.UA.Model.Designer.Controls.NodeObserver.HelpUserControlObserver();
      this.splitter_main = new System.Windows.Forms.Splitter();
      this.debugDockPanelUserControl1 = new UAOOI.Windows.Forms.DebugDockPanelUserControl();
      this.menuStrip_MainMenu = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ImportTSMI = new System.Windows.Forms.ToolStripMenuItem();
      this.m_FromUANodeSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_FromXMLSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_FromUMLDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_FromEnterpriceArchitectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_FromVisioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_FileImportFromTSMI = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ToWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ToMAMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ToGraphicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ToXMLSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ToUMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ToEnterpriceArchitectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_ToVisioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.recentSolutionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
      this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
      this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.allReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.findUnusedNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
      this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toggleBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.disableEnableAllBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.disableEnableBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.previousBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nextBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clearAllBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
      this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.objectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.childrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.visualisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolbarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
      this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nodeClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nAmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.allReferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sortTheTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.alphabeticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nodeClassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
      this.coupledNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.synchronizeTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.collapsAllNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
      this.navigateBackwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.navigateForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_MenuServerUA = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buildVerifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buildProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
      this.verifySolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.verifyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.customEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stateMachineEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.oPCViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.automaticHelpSynchonisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sendUsCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.technicalSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutUaModelDesignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutOpcUaModelCompilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.logsContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.tabControl_Main.SuspendLayout();
      this.tabPage_main.SuspendLayout();
      this.tabPage_help.SuspendLayout();
      this.menuStrip_MainMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
      // 
      // toolStripSeparator5
      // 
      toolStripSeparator5.Name = "toolStripSeparator5";
      toolStripSeparator5.Size = new System.Drawing.Size(191, 6);
      // 
      // toolStripContainer1
      // 
      // 
      // toolStripContainer1.BottomToolStripPanel
      // 
      this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip_WindowBottomStrip);
      // 
      // toolStripContainer1.ContentPanel
      // 
      this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl_Main);
      this.toolStripContainer1.ContentPanel.Controls.Add(this.splitter_main);
      this.toolStripContainer1.ContentPanel.Controls.Add(this.debugDockPanelUserControl1);
      this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(984, 468);
      this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.Size = new System.Drawing.Size(984, 514);
      this.toolStripContainer1.TabIndex = 3;
      this.toolStripContainer1.Text = "toolStripContainer1";
      // 
      // toolStripContainer1.TopToolStripPanel
      // 
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip_MainMenu);
      // 
      // statusStrip_WindowBottomStrip
      // 
      this.statusStrip_WindowBottomStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.statusStrip_WindowBottomStrip.Location = new System.Drawing.Point(0, 0);
      this.statusStrip_WindowBottomStrip.Name = "statusStrip_WindowBottomStrip";
      this.statusStrip_WindowBottomStrip.Size = new System.Drawing.Size(984, 22);
      this.statusStrip_WindowBottomStrip.TabIndex = 1;
      this.statusStrip_WindowBottomStrip.Text = "Status";
      // 
      // tabControl_Main
      // 
      this.tabControl_Main.Controls.Add(this.tabPage_main);
      this.tabControl_Main.Controls.Add(this.tabPage_help);
      this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
      this.tabControl_Main.Name = "tabControl_Main";
      this.tabControl_Main.SelectedIndex = 0;
      this.tabControl_Main.Size = new System.Drawing.Size(984, 363);
      this.tabControl_Main.TabIndex = 2;
      // 
      // tabPage_main
      // 
      this.tabPage_main.Controls.Add(this.m_MainContol);
      this.tabPage_main.Location = new System.Drawing.Point(4, 22);
      this.tabPage_main.Name = "tabPage_main";
      this.tabPage_main.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage_main.Size = new System.Drawing.Size(976, 337);
      this.tabPage_main.TabIndex = 0;
      this.tabPage_main.Text = "Main";
      this.tabPage_main.ToolTipText = "Main window of the Address Space Model Designer";
      this.tabPage_main.UseVisualStyleBackColor = true;
      // 
      // m_MainContol
      // 
      this.m_MainContol.Cursor = System.Windows.Forms.Cursors.Default;
      this.m_MainContol.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_MainContol.Location = new System.Drawing.Point(3, 3);
      this.m_MainContol.Name = "m_MainContol";
      this.m_MainContol.Size = new System.Drawing.Size(970, 331);
      this.m_MainContol.TabIndex = 0;
      // 
      // tabPage_help
      // 
      this.tabPage_help.Controls.Add(this.helpUserControl);
      this.tabPage_help.Location = new System.Drawing.Point(4, 22);
      this.tabPage_help.Name = "tabPage_help";
      this.tabPage_help.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage_help.Size = new System.Drawing.Size(732, 337);
      this.tabPage_help.TabIndex = 1;
      this.tabPage_help.Text = "Help";
      this.tabPage_help.ToolTipText = "OPC Unified Architecture e-book and Address Space Model Designer help";
      this.tabPage_help.UseVisualStyleBackColor = true;
      // 
      // helpUserControl
      // 
      this.helpUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.helpUserControl.Location = new System.Drawing.Point(3, 3);
      this.helpUserControl.Name = "helpUserControl";
      this.helpUserControl.Size = new System.Drawing.Size(726, 331);
      this.helpUserControl.TabIndex = 0;
      // 
      // splitter_main
      // 
      this.splitter_main.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter_main.Location = new System.Drawing.Point(0, 363);
      this.splitter_main.Name = "splitter_main";
      this.splitter_main.Size = new System.Drawing.Size(984, 10);
      this.splitter_main.TabIndex = 4;
      this.splitter_main.TabStop = false;
      // 
      // debugDockPanelUserControl1
      // 
      this.debugDockPanelUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.debugDockPanelUserControl1.Label = "Output Window";
      this.debugDockPanelUserControl1.Location = new System.Drawing.Point(0, 373);
      this.debugDockPanelUserControl1.Name = "debugDockPanelUserControl1";
      this.debugDockPanelUserControl1.Size = new System.Drawing.Size(984, 95);
      this.debugDockPanelUserControl1.TabIndex = 3;
      this.debugDockPanelUserControl1.TraceListenerName = "CAS.Model.Designer.OutputWindow.Listener";
      // 
      // menuStrip_MainMenu
      // 
      this.menuStrip_MainMenu.Dock = System.Windows.Forms.DockStyle.None;
      this.menuStrip_MainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
      this.menuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.m_EditToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.m_MenuServerUA,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
      this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
      this.menuStrip_MainMenu.Size = new System.Drawing.Size(984, 24);
      this.menuStrip_MainMenu.TabIndex = 0;
      this.menuStrip_MainMenu.Text = "Main Menu";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.m_SaveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            toolStripSeparator1,
            this.m_ImportTSMI,
            this.m_ExportToolStripMenuItem,
            this.toolStripSeparator6,
            this.pageSetupToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator7,
            this.recentSolutionsToolStripMenuItem,
            this.toolStripSeparator8,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.ToolTipText = "Clears current solution";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.MHNewToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.openToolStripMenuItem.Text = "Open ...";
      this.openToolStripMenuItem.ToolTipText = resources.GetString("openToolStripMenuItem.ToolTipText");
      this.openToolStripMenuItem.Click += new System.EventHandler(this.MHOpenToolStripMenuItem_Click);
      // 
      // m_SaveToolStripMenuItem
      // 
      this.m_SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("m_SaveToolStripMenuItem.Image")));
      this.m_SaveToolStripMenuItem.Name = "m_SaveToolStripMenuItem";
      this.m_SaveToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.m_SaveToolStripMenuItem.Text = "Save";
      this.m_SaveToolStripMenuItem.ToolTipText = resources.GetString("m_SaveToolStripMenuItem.ToolTipText");
      this.m_SaveToolStripMenuItem.Click += new System.EventHandler(this.MHSaveToolStripMenuItem_Click);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.saveAsToolStripMenuItem.Text = "Save As ...";
      this.saveAsToolStripMenuItem.ToolTipText = resources.GetString("saveAsToolStripMenuItem.ToolTipText");
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.MHSaveAsToolStripMenuItem_Click);
      // 
      // m_ImportTSMI
      // 
      this.m_ImportTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_FromUANodeSetToolStripMenuItem,
            this.m_FromXMLSchemaToolStripMenuItem,
            this.m_FromUMLDiagramToolStripMenuItem,
            this.m_FromEnterpriceArchitectToolStripMenuItem,
            this.m_FromVisioToolStripMenuItem,
            this.m_FileImportFromTSMI});
      this.m_ImportTSMI.Image = ((System.Drawing.Image)(resources.GetObject("m_ImportTSMI.Image")));
      this.m_ImportTSMI.Name = "m_ImportTSMI";
      this.m_ImportTSMI.Size = new System.Drawing.Size(162, 22);
      this.m_ImportTSMI.Text = "Import";
      this.m_ImportTSMI.ToolTipText = "It imports models from external formats.";
      this.m_ImportTSMI.DropDownOpening += new System.EventHandler(this.MHFileImport_DropDownOpening);
      // 
      // m_FromUANodeSetToolStripMenuItem
      // 
      this.m_FromUANodeSetToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_FromUANodeSetToolStripMenuItem.Name = "m_FromUANodeSetToolStripMenuItem";
      this.m_FromUANodeSetToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
      this.m_FromUANodeSetToolStripMenuItem.Text = "From UANodeSet";
      this.m_FromUANodeSetToolStripMenuItem.ToolTipText = "It imports XML documents compliant with the UANodeSet schema available at: \r\nhttp" +
    "://www.opcfoundation.org/UA/schemas/1.02/UANodeSet.xsd";
      this.m_FromUANodeSetToolStripMenuItem.Click += new System.EventHandler(this.m_FromUANodeSetToolStripMenuItem_Click);
      // 
      // m_FromXMLSchemaToolStripMenuItem
      // 
      this.m_FromXMLSchemaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_FromXMLSchemaToolStripMenuItem.Name = "m_FromXMLSchemaToolStripMenuItem";
      this.m_FromXMLSchemaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
      this.m_FromXMLSchemaToolStripMenuItem.Text = "From XML schema";
      this.m_FromXMLSchemaToolStripMenuItem.Click += new System.EventHandler(this.MHFromXMLSchemaToolStripMenuItem_Click);
      // 
      // m_FromUMLDiagramToolStripMenuItem
      // 
      this.m_FromUMLDiagramToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_FromUMLDiagramToolStripMenuItem.Name = "m_FromUMLDiagramToolStripMenuItem";
      this.m_FromUMLDiagramToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
      this.m_FromUMLDiagramToolStripMenuItem.Text = "From UML diagram";
      this.m_FromUMLDiagramToolStripMenuItem.Click += new System.EventHandler(this.MHFromUMLDiagramToolStripMenuItem_Click);
      // 
      // m_FromEnterpriceArchitectToolStripMenuItem
      // 
      this.m_FromEnterpriceArchitectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_FromEnterpriceArchitectToolStripMenuItem.Name = "m_FromEnterpriceArchitectToolStripMenuItem";
      this.m_FromEnterpriceArchitectToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
      this.m_FromEnterpriceArchitectToolStripMenuItem.Text = "From Enterprice Architect";
      this.m_FromEnterpriceArchitectToolStripMenuItem.Click += new System.EventHandler(this.MHFromEnterpriceArchitectToolStripMenuItem_Click);
      // 
      // m_FromVisioToolStripMenuItem
      // 
      this.m_FromVisioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_FromVisioToolStripMenuItem.Name = "m_FromVisioToolStripMenuItem";
      this.m_FromVisioToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
      this.m_FromVisioToolStripMenuItem.Text = "From Visio";
      this.m_FromVisioToolStripMenuItem.Click += new System.EventHandler(this.MHFromVisioToolStripMenuItem_Click);
      // 
      // m_FileImportFromTSMI
      // 
      this.m_FileImportFromTSMI.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_FileImportFromTSMI.Name = "m_FileImportFromTSMI";
      this.m_FileImportFromTSMI.Size = new System.Drawing.Size(209, 22);
      this.m_FileImportFromTSMI.Text = "From ...";
      this.m_FileImportFromTSMI.ToolTipText = "Send us email with information about source format you need.";
      this.m_FileImportFromTSMI.Click += new System.EventHandler(this.MHFromFileImportTSMI_Click);
      // 
      // m_ExportToolStripMenuItem
      // 
      this.m_ExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ToWordToolStripMenuItem,
            this.m_ToMAMLToolStripMenuItem,
            toolStripSeparator5,
            this.m_ToExcelToolStripMenuItem,
            this.m_ToGraphicToolStripMenuItem,
            this.m_ToXMLSchemaToolStripMenuItem,
            this.m_ToUMLToolStripMenuItem,
            this.m_ToEnterpriceArchitectToolStripMenuItem,
            this.m_ToVisioToolStripMenuItem,
            this.toToolStripMenuItem});
      this.m_ExportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("m_ExportToolStripMenuItem.Image")));
      this.m_ExportToolStripMenuItem.Name = "m_ExportToolStripMenuItem";
      this.m_ExportToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.m_ExportToolStripMenuItem.Text = "Export";
      this.m_ExportToolStripMenuItem.ToolTipText = "It exports models t external formats";
      // 
      // m_ToWordToolStripMenuItem
      // 
      this.m_ToWordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
      this.m_ToWordToolStripMenuItem.Name = "m_ToWordToolStripMenuItem";
      this.m_ToWordToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.m_ToWordToolStripMenuItem.Text = "To Word";
      this.m_ToWordToolStripMenuItem.ToolTipText = "Exports (generates a report) the solution to Word 2007 document ";
      this.m_ToWordToolStripMenuItem.Click += new System.EventHandler(this.MHExport2Word_Click);
      // 
      // m_ToMAMLToolStripMenuItem
      // 
      this.m_ToMAMLToolStripMenuItem.Name = "m_ToMAMLToolStripMenuItem";
      this.m_ToMAMLToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.m_ToMAMLToolStripMenuItem.Text = "To MAML";
      this.m_ToMAMLToolStripMenuItem.ToolTipText = "Exports (generates a report) the solution to MAML document ";
      this.m_ToMAMLToolStripMenuItem.Click += new System.EventHandler(this.MHExport2MAML_Click);
      // 
      // m_ToExcelToolStripMenuItem
      // 
      this.m_ToExcelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_ToExcelToolStripMenuItem.Name = "m_ToExcelToolStripMenuItem";
      this.m_ToExcelToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.m_ToExcelToolStripMenuItem.Text = "To Excel ";
      this.m_ToExcelToolStripMenuItem.ToolTipText = "Exports (generates a report) the solution to Excel 2007 document ";
      this.m_ToExcelToolStripMenuItem.Click += new System.EventHandler(this.MHExport2Excel_Click);
      // 
      // m_ToGraphicToolStripMenuItem
      // 
      this.m_ToGraphicToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_ToGraphicToolStripMenuItem.Name = "m_ToGraphicToolStripMenuItem";
      this.m_ToGraphicToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.m_ToGraphicToolStripMenuItem.Text = "To Graphics";
      this.m_ToGraphicToolStripMenuItem.ToolTipText = "Exports  the solution as graphical diagram";
      this.m_ToGraphicToolStripMenuItem.Click += new System.EventHandler(this.MHExport2Graphic_Click);
      // 
      // m_ToXMLSchemaToolStripMenuItem
      // 
      this.m_ToXMLSchemaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_ToXMLSchemaToolStripMenuItem.Name = "m_ToXMLSchemaToolStripMenuItem";
      this.m_ToXMLSchemaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.m_ToXMLSchemaToolStripMenuItem.Text = "To XML Schema";
      this.m_ToXMLSchemaToolStripMenuItem.Click += new System.EventHandler(this.MHExport2XMLSchema_Click);
      // 
      // m_ToUMLToolStripMenuItem
      // 
      this.m_ToUMLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_ToUMLToolStripMenuItem.Name = "m_ToUMLToolStripMenuItem";
      this.m_ToUMLToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.m_ToUMLToolStripMenuItem.Text = "To UML";
      this.m_ToUMLToolStripMenuItem.Click += new System.EventHandler(this.MHExport2UML_Click);
      // 
      // m_ToEnterpriceArchitectToolStripMenuItem
      // 
      this.m_ToEnterpriceArchitectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_ToEnterpriceArchitectToolStripMenuItem.Name = "m_ToEnterpriceArchitectToolStripMenuItem";
      this.m_ToEnterpriceArchitectToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.m_ToEnterpriceArchitectToolStripMenuItem.Text = "To Enterprice Architect";
      this.m_ToEnterpriceArchitectToolStripMenuItem.Click += new System.EventHandler(this.MHExport2EnterpriceArchitect_Click);
      // 
      // m_ToVisioToolStripMenuItem
      // 
      this.m_ToVisioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.m_ToVisioToolStripMenuItem.Name = "m_ToVisioToolStripMenuItem";
      this.m_ToVisioToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.m_ToVisioToolStripMenuItem.Text = "To Visio";
      this.m_ToVisioToolStripMenuItem.Click += new System.EventHandler(this.MHExport2Visio_Click);
      // 
      // toToolStripMenuItem
      // 
      this.toToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.toToolStripMenuItem.Name = "toToolStripMenuItem";
      this.toToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.toToolStripMenuItem.Text = "To ...";
      this.toToolStripMenuItem.ToolTipText = "Exports  the solution to custom format";
      this.toToolStripMenuItem.Click += new System.EventHandler(this.MHExport2Eny_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(159, 6);
      // 
      // pageSetupToolStripMenuItem
      // 
      this.pageSetupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
      this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.pageSetupToolStripMenuItem.Text = "Page Setup ...";
      this.pageSetupToolStripMenuItem.ToolTipText = "Sets up the printing report page.";
      this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
      // 
      // printToolStripMenuItem
      // 
      this.printToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.printToolStripMenuItem.Text = "Print ...";
      this.printToolStripMenuItem.ToolTipText = "Prints the report based on the solution.";
      this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(159, 6);
      // 
      // recentSolutionsToolStripMenuItem
      // 
      this.recentSolutionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.recentSolutionsToolStripMenuItem.Name = "recentSolutionsToolStripMenuItem";
      this.recentSolutionsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.recentSolutionsToolStripMenuItem.Text = "Recent Solutions";
      this.recentSolutionsToolStripMenuItem.ToolTipText = "Easy access to recent opened solutions.";
      this.recentSolutionsToolStripMenuItem.Click += new System.EventHandler(this.recentSolutionsToolStripMenuItem_Click);
      // 
      // toolStripSeparator8
      // 
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new System.Drawing.Size(159, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.ToolTipText = "Exits the application.";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.MHExitToolStripMenuItem_Click);
      // 
      // m_EditToolStripMenuItem
      // 
      this.m_EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator9,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator10,
            this.findAndReplaceToolStripMenuItem,
            this.goToToolStripMenuItem,
            this.toolStripSeparator11,
            this.notesToolStripMenuItem,
            this.bookmarksToolStripMenuItem,
            this.toolStripSeparator12,
            this.createToolStripMenuItem});
      this.m_EditToolStripMenuItem.Name = "m_EditToolStripMenuItem";
      this.m_EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.m_EditToolStripMenuItem.Text = "Edit";
      // 
      // undoToolStripMenuItem
      // 
      this.undoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
      this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.undoToolStripMenuItem.Text = "Undo";
      this.undoToolStripMenuItem.ToolTipText = "Undoes the last change ";
      this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.redoToolStripMenuItem.Text = "Redo";
      this.redoToolStripMenuItem.ToolTipText = "Re-does the last change ";
      this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
      // 
      // toolStripSeparator9
      // 
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      this.toolStripSeparator9.Size = new System.Drawing.Size(161, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.cutToolStripMenuItem.Text = "Cut";
      this.cutToolStripMenuItem.ToolTipText = "Cuts the node from the model to the system clipboard";
      this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copyToolStripMenuItem.Text = "Copy";
      this.copyToolStripMenuItem.ToolTipText = "Makes oa copy of the node in the system clipboard";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.pasteToolStripMenuItem.Text = "Paste";
      this.pasteToolStripMenuItem.ToolTipText = "Pastes the node into a chosen location";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator10
      // 
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      this.toolStripSeparator10.Size = new System.Drawing.Size(161, 6);
      // 
      // findAndReplaceToolStripMenuItem
      // 
      this.findAndReplaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.allReferencesToolStripMenuItem,
            this.findUnusedNodesToolStripMenuItem});
      this.findAndReplaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findAndReplaceToolStripMenuItem.Image")));
      this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
      this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.findAndReplaceToolStripMenuItem.Text = "Find and Replace";
      // 
      // findToolStripMenuItem
      // 
      this.findToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.findToolStripMenuItem.Name = "findToolStripMenuItem";
      this.findToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.findToolStripMenuItem.Text = "Find";
      this.findToolStripMenuItem.ToolTipText = "Searches through the solution and libraries to find a node that matches the reque" +
    "st.";
      this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
      // 
      // replaceToolStripMenuItem
      // 
      this.replaceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
      this.replaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.replaceToolStripMenuItem.Text = "Replace";
      this.replaceToolStripMenuItem.ToolTipText = "Searches through the solution  to find a node that matches the request and allows" +
    " to specify what will be inserted in the place of the matched string or expressi" +
    "on.";
      this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
      // 
      // allReferencesToolStripMenuItem
      // 
      this.allReferencesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.allReferencesToolStripMenuItem.Name = "allReferencesToolStripMenuItem";
      this.allReferencesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.allReferencesToolStripMenuItem.Text = "All References";
      this.allReferencesToolStripMenuItem.ToolTipText = "Searches through the solution and libraries to find a node referenced by selected" +
    " node.";
      this.allReferencesToolStripMenuItem.Click += new System.EventHandler(this.allReferencesToolStripMenuItem_Click);
      // 
      // findUnusedNodesToolStripMenuItem
      // 
      this.findUnusedNodesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.findUnusedNodesToolStripMenuItem.Name = "findUnusedNodesToolStripMenuItem";
      this.findUnusedNodesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.findUnusedNodesToolStripMenuItem.Text = "Find  Unused Nodes";
      this.findUnusedNodesToolStripMenuItem.ToolTipText = "Searches through the solution  to find a nodes not referenced by any other node.";
      this.findUnusedNodesToolStripMenuItem.Click += new System.EventHandler(this.findUnusedNodesToolStripMenuItem_Click);
      // 
      // goToToolStripMenuItem
      // 
      this.goToToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("goToToolStripMenuItem.Image")));
      this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
      this.goToToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.goToToolStripMenuItem.Text = "Go To ...";
      // 
      // toolStripSeparator11
      // 
      this.toolStripSeparator11.Name = "toolStripSeparator11";
      this.toolStripSeparator11.Size = new System.Drawing.Size(161, 6);
      // 
      // notesToolStripMenuItem
      // 
      this.notesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
      this.notesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notesToolStripMenuItem.Image")));
      this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
      this.notesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.notesToolStripMenuItem.Text = "Notes:";
      // 
      // addToolStripMenuItem
      // 
      this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.addToolStripMenuItem.Name = "addToolStripMenuItem";
      this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.addToolStripMenuItem.Text = "Add";
      this.addToolStripMenuItem.ToolTipText = "Add a note (custom comment) to selected node.";
      this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
      // 
      // removeToolStripMenuItem
      // 
      this.removeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
      this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
      this.removeToolStripMenuItem.Text = "Remove";
      this.removeToolStripMenuItem.ToolTipText = "Removes a note (custom comment) from selected node.";
      this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
      // 
      // bookmarksToolStripMenuItem
      // 
      this.bookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleBookmarkToolStripMenuItem,
            this.disableEnableAllBookmarksToolStripMenuItem,
            this.disableEnableBookmarkToolStripMenuItem,
            this.previousBookmarkToolStripMenuItem,
            this.nextBookmarkToolStripMenuItem,
            this.clearAllBookmarksToolStripMenuItem});
      this.bookmarksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookmarksToolStripMenuItem.Image")));
      this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
      this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.bookmarksToolStripMenuItem.Text = "Bookmarks";
      // 
      // toggleBookmarkToolStripMenuItem
      // 
      this.toggleBookmarkToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.toggleBookmarkToolStripMenuItem.Name = "toggleBookmarkToolStripMenuItem";
      this.toggleBookmarkToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.toggleBookmarkToolStripMenuItem.Text = "Toggle Bookmark";
      this.toggleBookmarkToolStripMenuItem.ToolTipText = "Adds or removes a bookmark on the selected node.";
      this.toggleBookmarkToolStripMenuItem.Click += new System.EventHandler(this.toggleBookmarkToolStripMenuItem_Click);
      // 
      // disableEnableAllBookmarksToolStripMenuItem
      // 
      this.disableEnableAllBookmarksToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.disableEnableAllBookmarksToolStripMenuItem.Name = "disableEnableAllBookmarksToolStripMenuItem";
      this.disableEnableAllBookmarksToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.disableEnableAllBookmarksToolStripMenuItem.Text = "Disable/Enable All Bookmarks";
      this.disableEnableAllBookmarksToolStripMenuItem.ToolTipText = "Disables or enables the check boxes for all bookmarks in the Bookmarks window. Do" +
    "es not remove bookmarks, or alter the lines of code that they mark. ";
      this.disableEnableAllBookmarksToolStripMenuItem.Click += new System.EventHandler(this.disableEnableAllBookmarksToolStripMenuItem_Click);
      // 
      // disableEnableBookmarkToolStripMenuItem
      // 
      this.disableEnableBookmarkToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.disableEnableBookmarkToolStripMenuItem.Name = "disableEnableBookmarkToolStripMenuItem";
      this.disableEnableBookmarkToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.disableEnableBookmarkToolStripMenuItem.Text = "Disable/Enable Bookmark";
      this.disableEnableBookmarkToolStripMenuItem.ToolTipText = "Disables or enables current bookmarks in the Bookmarks window. Does not remove bo" +
    "okmarks, or alter the lines of code that they mark. ";
      this.disableEnableBookmarkToolStripMenuItem.Click += new System.EventHandler(this.disableEnableBookmarkToolStripMenuItem_Click);
      // 
      // previousBookmarkToolStripMenuItem
      // 
      this.previousBookmarkToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.previousBookmarkToolStripMenuItem.Name = "previousBookmarkToolStripMenuItem";
      this.previousBookmarkToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.previousBookmarkToolStripMenuItem.Text = "Previous Bookmark";
      this.previousBookmarkToolStripMenuItem.ToolTipText = "\"Selects the previous bookmark that is enabled in the Bookmarks window. \nWhen the" +
    " first bookmark is reached, jumps ahead to the last one. \"";
      this.previousBookmarkToolStripMenuItem.Click += new System.EventHandler(this.previousBookmarkToolStripMenuItem_Click);
      // 
      // nextBookmarkToolStripMenuItem
      // 
      this.nextBookmarkToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.nextBookmarkToolStripMenuItem.Name = "nextBookmarkToolStripMenuItem";
      this.nextBookmarkToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.nextBookmarkToolStripMenuItem.Text = "Next Bookmark";
      this.nextBookmarkToolStripMenuItem.ToolTipText = "\"Selects the next bookmark that is enabled in the Bookmarks window. \nWhen the las" +
    "t bookmark is reached, jumps back to the first one. \"";
      this.nextBookmarkToolStripMenuItem.Click += new System.EventHandler(this.nextBookmarkToolStripMenuItem_Click);
      // 
      // clearAllBookmarksToolStripMenuItem
      // 
      this.clearAllBookmarksToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.clearAllBookmarksToolStripMenuItem.Name = "clearAllBookmarksToolStripMenuItem";
      this.clearAllBookmarksToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
      this.clearAllBookmarksToolStripMenuItem.Text = "Clear All Bookmarks";
      this.clearAllBookmarksToolStripMenuItem.ToolTipText = "Removes all bookmarks.";
      this.clearAllBookmarksToolStripMenuItem.Click += new System.EventHandler(this.clearAllBookmarksToolStripMenuItem_Click);
      // 
      // toolStripSeparator12
      // 
      this.toolStripSeparator12.Name = "toolStripSeparator12";
      this.toolStripSeparator12.Size = new System.Drawing.Size(161, 6);
      // 
      // createToolStripMenuItem
      // 
      this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectToolStripMenuItem,
            this.childrenToolStripMenuItem,
            this.referenceToolStripMenuItem});
      this.createToolStripMenuItem.Name = "createToolStripMenuItem";
      this.createToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.createToolStripMenuItem.Text = "Create";
      // 
      // objectToolStripMenuItem
      // 
      this.objectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.objectToolStripMenuItem.Name = "objectToolStripMenuItem";
      this.objectToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.objectToolStripMenuItem.Text = "Object";
      this.objectToolStripMenuItem.ToolTipText = "Creates an object based on selected type definition";
      this.objectToolStripMenuItem.Click += new System.EventHandler(this.objectToolStripMenuItem_Click);
      // 
      // childrenToolStripMenuItem
      // 
      this.childrenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.childrenToolStripMenuItem.Name = "childrenToolStripMenuItem";
      this.childrenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.childrenToolStripMenuItem.Text = "Children";
      this.childrenToolStripMenuItem.ToolTipText = "Creates a child element";
      this.childrenToolStripMenuItem.Click += new System.EventHandler(this.childrenToolStripMenuItem_Click);
      // 
      // referenceToolStripMenuItem
      // 
      this.referenceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
      this.referenceToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
      this.referenceToolStripMenuItem.Text = "Reference";
      this.referenceToolStripMenuItem.ToolTipText = "Creates a reference";
      this.referenceToolStripMenuItem.Click += new System.EventHandler(this.referenceToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualisationToolStripMenuItem,
            this.toolbarsToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.toolStripSeparator13,
            this.filtersToolStripMenuItem,
            this.sortTheTreeToolStripMenuItem,
            this.toolStripSeparator14,
            this.coupledNodesToolStripMenuItem,
            this.synchronizeTreeToolStripMenuItem,
            this.collapsAllNodesToolStripMenuItem,
            this.toolStripSeparator15,
            this.navigateBackwardToolStripMenuItem,
            this.navigateForwardToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "View";
      // 
      // visualisationToolStripMenuItem
      // 
      this.visualisationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualisationToolStripMenuItem.Image")));
      this.visualisationToolStripMenuItem.Name = "visualisationToolStripMenuItem";
      this.visualisationToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.visualisationToolStripMenuItem.Text = "Visualisation";
      this.visualisationToolStripMenuItem.DropDownOpening += new System.EventHandler(this.visualisationToolStripMenuItem_DropDownOpening);
      // 
      // toolbarsToolStripMenuItem
      // 
      this.toolbarsToolStripMenuItem.Name = "toolbarsToolStripMenuItem";
      this.toolbarsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.toolbarsToolStripMenuItem.Text = "Toolbars";
      // 
      // windowsToolStripMenuItem
      // 
      this.windowsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("windowsToolStripMenuItem.Image")));
      this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
      this.windowsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.windowsToolStripMenuItem.Text = "Windows";
      // 
      // toolStripSeparator13
      // 
      this.toolStripSeparator13.Name = "toolStripSeparator13";
      this.toolStripSeparator13.Size = new System.Drawing.Size(172, 6);
      // 
      // filtersToolStripMenuItem
      // 
      this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nodeClassToolStripMenuItem,
            this.nAmeToolStripMenuItem,
            this.allReferencesToolStripMenuItem1,
            this.othersToolStripMenuItem});
      this.filtersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filtersToolStripMenuItem.Image")));
      this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
      this.filtersToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.filtersToolStripMenuItem.Text = "Filters";
      // 
      // nodeClassToolStripMenuItem
      // 
      this.nodeClassToolStripMenuItem.Name = "nodeClassToolStripMenuItem";
      this.nodeClassToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
      this.nodeClassToolStripMenuItem.Text = "Node Class";
      this.nodeClassToolStripMenuItem.ToolTipText = "Filters the current view to display only nodes from particular node class.";
      this.nodeClassToolStripMenuItem.Click += new System.EventHandler(this.nodeClassToolStripMenuItem_Click);
      // 
      // nAmeToolStripMenuItem
      // 
      this.nAmeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.nAmeToolStripMenuItem.Name = "nAmeToolStripMenuItem";
      this.nAmeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
      this.nAmeToolStripMenuItem.Text = "Name";
      this.nAmeToolStripMenuItem.ToolTipText = "Filters the current view to display only nodes which name matches the name patter" +
    "n";
      this.nAmeToolStripMenuItem.Click += new System.EventHandler(this.nAmeToolStripMenuItem_Click);
      // 
      // allReferencesToolStripMenuItem1
      // 
      this.allReferencesToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
      this.allReferencesToolStripMenuItem1.Name = "allReferencesToolStripMenuItem1";
      this.allReferencesToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
      this.allReferencesToolStripMenuItem1.Text = "All References";
      this.allReferencesToolStripMenuItem1.ToolTipText = "Filters the current view to display only nodes which are referenced to current no" +
    "de";
      this.allReferencesToolStripMenuItem1.Click += new System.EventHandler(this.allReferencesToolStripMenuItem1_Click);
      // 
      // othersToolStripMenuItem
      // 
      this.othersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
      this.othersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
      this.othersToolStripMenuItem.Text = "Others ...";
      this.othersToolStripMenuItem.ToolTipText = "Other filtering possibilities";
      this.othersToolStripMenuItem.Click += new System.EventHandler(this.othersToolStripMenuItem_Click);
      // 
      // sortTheTreeToolStripMenuItem
      // 
      this.sortTheTreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alphabeticallyToolStripMenuItem,
            this.nodeClassToolStripMenuItem1});
      this.sortTheTreeToolStripMenuItem.Name = "sortTheTreeToolStripMenuItem";
      this.sortTheTreeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.sortTheTreeToolStripMenuItem.Text = "Sort The Tree";
      // 
      // alphabeticallyToolStripMenuItem
      // 
      this.alphabeticallyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.alphabeticallyToolStripMenuItem.Name = "alphabeticallyToolStripMenuItem";
      this.alphabeticallyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.alphabeticallyToolStripMenuItem.Text = "Alphabetically";
      this.alphabeticallyToolStripMenuItem.ToolTipText = "Sorts the current tree view alphabetically.";
      this.alphabeticallyToolStripMenuItem.Click += new System.EventHandler(this.alphabeticallyToolStripMenuItem_Click);
      // 
      // nodeClassToolStripMenuItem1
      // 
      this.nodeClassToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
      this.nodeClassToolStripMenuItem1.Name = "nodeClassToolStripMenuItem1";
      this.nodeClassToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
      this.nodeClassToolStripMenuItem1.Text = "Node Class";
      this.nodeClassToolStripMenuItem1.ToolTipText = "Sorts the current tree view based on node class type.";
      this.nodeClassToolStripMenuItem1.Click += new System.EventHandler(this.nodeClassToolStripMenuItem1_Click);
      // 
      // toolStripSeparator14
      // 
      this.toolStripSeparator14.Name = "toolStripSeparator14";
      this.toolStripSeparator14.Size = new System.Drawing.Size(172, 6);
      // 
      // coupledNodesToolStripMenuItem
      // 
      this.coupledNodesToolStripMenuItem.Checked = true;
      this.coupledNodesToolStripMenuItem.CheckOnClick = true;
      this.coupledNodesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.coupledNodesToolStripMenuItem.Name = "coupledNodesToolStripMenuItem";
      this.coupledNodesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.coupledNodesToolStripMenuItem.Text = "Coupled Nodes";
      this.coupledNodesToolStripMenuItem.ToolTipText = "Turns on/off coupled nodes on the tree";
      this.coupledNodesToolStripMenuItem.Click += new System.EventHandler(this.coupledNodesToolStripMenuItem_Click);
      // 
      // synchronizeTreeToolStripMenuItem
      // 
      this.synchronizeTreeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.synchronizeTreeToolStripMenuItem.Name = "synchronizeTreeToolStripMenuItem";
      this.synchronizeTreeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.synchronizeTreeToolStripMenuItem.Text = "Synchronize Tree";
      this.synchronizeTreeToolStripMenuItem.ToolTipText = "Synchronizes the tree view with the property grid";
      this.synchronizeTreeToolStripMenuItem.Click += new System.EventHandler(this.synchronizeTreeToolStripMenuItem_Click);
      // 
      // collapsAllNodesToolStripMenuItem
      // 
      this.collapsAllNodesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.collapsAllNodesToolStripMenuItem.Name = "collapsAllNodesToolStripMenuItem";
      this.collapsAllNodesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.collapsAllNodesToolStripMenuItem.Text = "Collaps All Nodes";
      this.collapsAllNodesToolStripMenuItem.ToolTipText = "Collapses all nodes on the tree";
      this.collapsAllNodesToolStripMenuItem.Click += new System.EventHandler(this.collapsAllNodesToolStripMenuItem_Click);
      // 
      // toolStripSeparator15
      // 
      this.toolStripSeparator15.Name = "toolStripSeparator15";
      this.toolStripSeparator15.Size = new System.Drawing.Size(172, 6);
      // 
      // navigateBackwardToolStripMenuItem
      // 
      this.navigateBackwardToolStripMenuItem.Image = global::CAS.UA.Model.Designer.Properties.Resources.ArrowLeft32;
      this.navigateBackwardToolStripMenuItem.Name = "navigateBackwardToolStripMenuItem";
      this.navigateBackwardToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.navigateBackwardToolStripMenuItem.Text = "Navigate Backward";
      this.navigateBackwardToolStripMenuItem.ToolTipText = "Navigate to previous selected node.";
      this.navigateBackwardToolStripMenuItem.Click += new System.EventHandler(this.navigateBackwardToolStripMenuItem_Click);
      // 
      // navigateForwardToolStripMenuItem
      // 
      this.navigateForwardToolStripMenuItem.Image = global::CAS.UA.Model.Designer.Properties.Resources.ArrowRight32;
      this.navigateForwardToolStripMenuItem.Name = "navigateForwardToolStripMenuItem";
      this.navigateForwardToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.navigateForwardToolStripMenuItem.Text = "Navigate Forward";
      this.navigateForwardToolStripMenuItem.ToolTipText = "Navigate to next selected node";
      this.navigateForwardToolStripMenuItem.Click += new System.EventHandler(this.navigateForwardToolStripMenuItem_Click);
      // 
      // m_MenuServerUA
      // 
      this.m_MenuServerUA.Name = "m_MenuServerUA";
      this.m_MenuServerUA.Size = new System.Drawing.Size(70, 20);
      this.m_MenuServerUA.Text = "UA Server";
      this.m_MenuServerUA.ToolTipText = global::CAS.UA.Model.Designer.Properties.Resources.Menu_UAServer_ToolTipp;
      this.m_MenuServerUA.DropDownOpening += new System.EventHandler(this.m_MenuServerUA_DropDownOpening);
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildVerifyToolStripMenuItem,
            this.toolStripSeparator2,
            this.customEditorToolStripMenuItem,
            this.oPCViewerToolStripMenuItem,
            this.toolStripSeparator3,
            this.customizeToolStripMenuItem,
            this.configurationToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.toolsToolStripMenuItem.Text = "Tools";
      // 
      // buildVerifyToolStripMenuItem
      // 
      this.buildVerifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem,
            this.buildProjectToolStripMenuItem,
            this.toolStripSeparator16,
            this.verifySolutionToolStripMenuItem,
            this.verifyProjectToolStripMenuItem});
      this.buildVerifyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buildVerifyToolStripMenuItem.Image")));
      this.buildVerifyToolStripMenuItem.Name = "buildVerifyToolStripMenuItem";
      this.buildVerifyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.buildVerifyToolStripMenuItem.Text = "Build / Verify";
      // 
      // buildToolStripMenuItem
      // 
      this.buildToolStripMenuItem.Image = global::CAS.UA.Model.Designer.Properties.Resources.Build;
      this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
      this.buildToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.buildToolStripMenuItem.Text = "Build Solution";
      this.buildToolStripMenuItem.ToolTipText = "Builds the solution";
      this.buildToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click);
      // 
      // buildProjectToolStripMenuItem
      // 
      this.buildProjectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.buildProjectToolStripMenuItem.Name = "buildProjectToolStripMenuItem";
      this.buildProjectToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.buildProjectToolStripMenuItem.Text = "Build Project";
      this.buildProjectToolStripMenuItem.ToolTipText = "Builds the project";
      this.buildProjectToolStripMenuItem.Click += new System.EventHandler(this.buildProjectToolStripMenuItem_Click);
      // 
      // toolStripSeparator16
      // 
      this.toolStripSeparator16.Name = "toolStripSeparator16";
      this.toolStripSeparator16.Size = new System.Drawing.Size(147, 6);
      // 
      // verifySolutionToolStripMenuItem
      // 
      this.verifySolutionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.verifySolutionToolStripMenuItem.Name = "verifySolutionToolStripMenuItem";
      this.verifySolutionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.verifySolutionToolStripMenuItem.Text = "Verify Solution";
      this.verifySolutionToolStripMenuItem.ToolTipText = "Verifies the solution (this is useful pre-build step - it shows errors on the tre" +
    "e";
      this.verifySolutionToolStripMenuItem.Click += new System.EventHandler(this.verifySolutionToolStripMenuItem_Click);
      // 
      // verifyProjectToolStripMenuItem
      // 
      this.verifyProjectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.verifyProjectToolStripMenuItem.Name = "verifyProjectToolStripMenuItem";
      this.verifyProjectToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.verifyProjectToolStripMenuItem.Text = "Verify Project";
      this.verifyProjectToolStripMenuItem.ToolTipText = "Verifies the model (this is useful pre-build step - it shows errors on the tree";
      this.verifyProjectToolStripMenuItem.Click += new System.EventHandler(this.verifyProjectToolStripMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
      // 
      // customEditorToolStripMenuItem
      // 
      this.customEditorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stateMachineEditorToolStripMenuItem});
      this.customEditorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customEditorToolStripMenuItem.Image")));
      this.customEditorToolStripMenuItem.Name = "customEditorToolStripMenuItem";
      this.customEditorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.customEditorToolStripMenuItem.Text = "Custom Editor";
      // 
      // stateMachineEditorToolStripMenuItem
      // 
      this.stateMachineEditorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stateMachineEditorToolStripMenuItem.Image")));
      this.stateMachineEditorToolStripMenuItem.Name = "stateMachineEditorToolStripMenuItem";
      this.stateMachineEditorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
      this.stateMachineEditorToolStripMenuItem.Text = "State Machine editor";
      this.stateMachineEditorToolStripMenuItem.ToolTipText = "The editor for state machine types";
      this.stateMachineEditorToolStripMenuItem.Click += new System.EventHandler(this.stateMachineEditorToolStripMenuItem_Click);
      // 
      // oPCViewerToolStripMenuItem
      // 
      this.oPCViewerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oPCViewerToolStripMenuItem.Image")));
      this.oPCViewerToolStripMenuItem.Name = "oPCViewerToolStripMenuItem";
      this.oPCViewerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.oPCViewerToolStripMenuItem.Text = "OPC Viewer";
      this.oPCViewerToolStripMenuItem.ToolTipText = "Starts OPC Viewer";
      this.oPCViewerToolStripMenuItem.Click += new System.EventHandler(this.oPCViewerToolStripMenuItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
      // 
      // customizeToolStripMenuItem
      // 
      this.customizeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
      this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
      this.customizeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.customizeToolStripMenuItem.Text = "Customize";
      this.customizeToolStripMenuItem.ToolTipText = "Customizes the user interface";
      this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
      // 
      // configurationToolStripMenuItem
      // 
      this.configurationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configurationToolStripMenuItem.Image")));
      this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
      this.configurationToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.configurationToolStripMenuItem.Text = "Options";
      this.configurationToolStripMenuItem.ToolTipText = "Application configuration";
      this.configurationToolStripMenuItem.Click += new System.EventHandler(this.HelpConfigurationToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.readmeToolStripMenuItem,
            this.automaticHelpSynchonisationToolStripMenuItem,
            this.sendUsCommentToolStripMenuItem,
            this.technicalSupportToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutUaModelDesignerToolStripMenuItem,
            this.aboutOpcUaModelCompilerToolStripMenuItem,
            this.logsContainingFolderToolStripMenuItem });
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // contentsToolStripMenuItem
      // 
      this.contentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contentsToolStripMenuItem.Image")));
      this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
      this.contentsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.contentsToolStripMenuItem.Text = "Help contents ...";
      this.contentsToolStripMenuItem.ToolTipText = "Shows the main documentation page";
      this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
      // 
      // readmeToolStripMenuItem
      // 
      this.readmeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("readmeToolStripMenuItem.Image")));
      this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
      this.readmeToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.readmeToolStripMenuItem.Text = "ReadMe ...";
      this.readmeToolStripMenuItem.ToolTipText = "Shows ReadMe and release notes page in the configuration";
      this.readmeToolStripMenuItem.Click += new System.EventHandler(this.HelpReadmeToolStripMenuItem_Click);
      // 
      // automaticHelpSynchonisationToolStripMenuItem
      // 
      this.automaticHelpSynchonisationToolStripMenuItem.Checked = true;
      this.automaticHelpSynchonisationToolStripMenuItem.CheckOnClick = true;
      this.automaticHelpSynchonisationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.automaticHelpSynchonisationToolStripMenuItem.Name = "automaticHelpSynchonisationToolStripMenuItem";
      this.automaticHelpSynchonisationToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.automaticHelpSynchonisationToolStripMenuItem.Text = "Help Synchronization";
      this.automaticHelpSynchonisationToolStripMenuItem.ToolTipText = "Turns on/off the intelligent book feature";
      this.automaticHelpSynchonisationToolStripMenuItem.Click += new System.EventHandler(this.automaticHelpSynchronisationToolStripMenuItem_Click);
      // 
      // sendUsCommentToolStripMenuItem
      // 
      this.sendUsCommentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendUsCommentToolStripMenuItem.Image")));
      this.sendUsCommentToolStripMenuItem.Name = "sendUsCommentToolStripMenuItem";
      this.sendUsCommentToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.sendUsCommentToolStripMenuItem.Text = "Send us comment ...";
      this.sendUsCommentToolStripMenuItem.ToolTipText = "Start the email client to send the comments";
      this.sendUsCommentToolStripMenuItem.Click += new System.EventHandler(this.HelpSendUsCommentToolStripMenuItem_Click);
      // 
      // technicalSupportToolStripMenuItem
      // 
      this.technicalSupportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("technicalSupportToolStripMenuItem.Image")));
      this.technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
      this.technicalSupportToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.technicalSupportToolStripMenuItem.Text = "Technical Support";
      this.technicalSupportToolStripMenuItem.ToolTipText = "Opens the technical support web site.";
      this.technicalSupportToolStripMenuItem.Click += new System.EventHandler(this.technicalSupportToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(236, 6);
      // 
      // aboutUaModelDesignerToolStripMenuItem
      // 
      this.aboutUaModelDesignerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutUaModelDesignerToolStripMenuItem.Image")));
      this.aboutUaModelDesignerToolStripMenuItem.Name = "aboutUaModelDesignerToolStripMenuItem";
      this.aboutUaModelDesignerToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.aboutUaModelDesignerToolStripMenuItem.Text = "About UA Model Designer";
      this.aboutUaModelDesignerToolStripMenuItem.ToolTipText = "Shows the about UA Model Designer window";
      this.aboutUaModelDesignerToolStripMenuItem.Click += new System.EventHandler(this.HelpAboutUaModelDesignerToolStripMenuItem_Click);
      // 
      // aboutOpcUaModelCompilerToolStripMenuItem
      // 
      this.aboutOpcUaModelCompilerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutOpcUaModelCompilerToolStripMenuItem.Image")));
      this.aboutOpcUaModelCompilerToolStripMenuItem.Name = "aboutOpcUaModelCompilerToolStripMenuItem";
      this.aboutOpcUaModelCompilerToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.aboutOpcUaModelCompilerToolStripMenuItem.Text = "About OPC UA ModelCompiler";
      this.aboutOpcUaModelCompilerToolStripMenuItem.ToolTipText = "Shows aboutOPC UA ModelCompiler window";
      this.aboutOpcUaModelCompilerToolStripMenuItem.Click += new System.EventHandler(this.HelpAboutOpcUaModelCompilerToolStripMenuItem_Click);
      // 
      // logsContainingFolderToolStripMenuItem
      // 
      this.logsContainingFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logsContainingFolderToolStripMenuItem.Image")));
      this.logsContainingFolderToolStripMenuItem.Name = "logsContainingFolderToolStripMenuItem";
      this.logsContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.logsContainingFolderToolStripMenuItem.Text = "Open logs containing folder";
      this.logsContainingFolderToolStripMenuItem.Click += new System.EventHandler(this.m_LogsContainingFolderToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(984, 514);
      this.Controls.Add(this.toolStripContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip_MainMenu;
      this.MinimumSize = new System.Drawing.Size(1000, 0);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "UA Model Designer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.tabControl_Main.ResumeLayout(false);
      this.tabPage_main.ResumeLayout(false);
      this.tabPage_help.ResumeLayout(false);
      this.menuStrip_MainMenu.ResumeLayout(false);
      this.menuStrip_MainMenu.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip_MainMenu;
    private System.Windows.Forms.StatusStrip statusStrip_WindowBottomStrip;
    private System.Windows.Forms.TabControl tabControl_Main;
    private System.Windows.Forms.TabPage tabPage_main;
    private System.Windows.Forms.TabPage tabPage_help;
    private Main m_MainContol;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutUaModelDesignerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private CAS.UA.Model.Designer.Controls.NodeObserver.HelpUserControlObserver helpUserControl;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem m_SaveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem coupledNodesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem stateMachineEditorToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem automaticHelpSynchonisationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem m_ImportTSMI;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripMenuItem m_ExportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem m_ToWordToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem m_ToExcelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem m_ToMAMLToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem m_ToGraphicToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripMenuItem recentSolutionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripMenuItem m_EditToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem allReferencesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem findUnusedNodesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
    private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toggleBookmarkToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem disableEnableAllBookmarksToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem disableEnableBookmarkToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem previousBookmarkToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nextBookmarkToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clearAllBookmarksToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
    private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem objectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem childrenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem visualisationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolbarsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
    private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nodeClassToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nAmeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem allReferencesToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sortTheTreeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem alphabeticallyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nodeClassToolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
    private System.Windows.Forms.ToolStripMenuItem synchronizeTreeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem collapsAllNodesToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
    private System.Windows.Forms.ToolStripMenuItem navigateBackwardToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem navigateForwardToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buildVerifyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem verifySolutionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem verifyProjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buildProjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem customEditorToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
    private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sendUsCommentToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem technicalSupportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
    private DebugDockPanelUserControl debugDockPanelUserControl1;
    private System.Windows.Forms.Splitter splitter_main;
    private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem oPCViewerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem m_MenuServerUA;
    private System.Windows.Forms.ToolStripMenuItem m_FileImportFromTSMI;
    private ToolStripMenuItem aboutOpcUaModelCompilerToolStripMenuItem;
    private ToolStripMenuItem logsContainingFolderToolStripMenuItem;
    private ToolStripMenuItem m_FromXMLSchemaToolStripMenuItem;
    private ToolStripMenuItem m_FromUMLDiagramToolStripMenuItem;
    private ToolStripMenuItem m_FromEnterpriceArchitectToolStripMenuItem;
    private ToolStripMenuItem m_ToXMLSchemaToolStripMenuItem;
    private ToolStripMenuItem m_ToEnterpriceArchitectToolStripMenuItem;
    private ToolStripMenuItem m_ToUMLToolStripMenuItem;
    private ToolStripMenuItem m_FromVisioToolStripMenuItem;
    private ToolStripMenuItem m_ToVisioToolStripMenuItem;
    private ToolStripMenuItem m_FromUANodeSetToolStripMenuItem;
  }
}