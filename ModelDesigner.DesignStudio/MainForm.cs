//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.ExportingTools;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.StateMachineEditor;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UAOOI.Windows.Forms;
using UAOOI.Windows.Forms.CodeProtectControls;
using UAOOI.Windows.Forms.ControlExtenders;

namespace CAS.UA.Model.Designer
{

  public partial class MainForm : Form
  {

    #region constructors
    public MainForm(string SolutionFileName)
      : this(false)
    {
      m_StartupFileName = SolutionFileName;
    }
    public MainForm(bool setAfterInstallationFlag)
    {
      SetAfterInstallationFlag = setAfterInstallationFlag;
      m_SplashScreenObj.Show();
      InitializeComponent();
      ProcessInitialization();
    }
    #endregion

    #region public
    private bool SetAfterInstallationFlag { set; get; }
    #endregion

    #region private

    #region private members and helper functions
    //types
    [LicenseProvider(typeof(CAS.Lib.CodeProtect.CodeProtectLP))]
    [GuidAttribute("0D675C59-39B8-4522-9FA6-074AF8A3EA9D")]
    private sealed class ImportConstrain : StartUpSplashScreen.LogedIsLicensed<ImportConstrain> { }
    [LicenseProvider(typeof(CAS.Lib.CodeProtect.CodeProtectLP))]
    [GuidAttribute("4DF37528-E9CB-4fb7-AE1A-5AD9639EC04E")]
    private sealed class BuildSolutionConstrain : StartUpSplashScreen.LogedIsLicensed<BuildSolutionConstrain> { }
    //vars
    private StartUpSplashScreen m_SplashScreenObj = new StartUpSplashScreen();
    private void ProcessInitialization()
    {
      if (m_MainContol != null)
      {
        OPCFSolutionConfigurationManagement.DefaultInstance.DefaultFileNameHasChanged += new EventHandler(OPCFModelConfigurationManagement_DefaultFileNameOrChangesArePresentHasChanged);
        OPCFSolutionConfigurationManagement.DefaultInstance.ChangesArePresentHasChanged += new EventHandler(OPCFModelConfigurationManagement_DefaultFileNameOrChangesArePresentHasChanged);
      }
      if (Settings.Default.FontSize < 6)
      {
        Settings.Default.FontSize = 6;
        this.Font = new Font(Form.DefaultFont.FontFamily, 6);
      }
      else if (Settings.Default.FontSize > 18)
      {
        Settings.Default.FontSize = 18;
        this.Font = new Font(Form.DefaultFont.FontFamily, 18);
      }
      else
        this.Font = new Font(Form.DefaultFont.FontFamily, Settings.Default.FontSize);
      #region docking and debug panel
      // declare dockExtender as a member of the form
      DockExtender dockExtender;
      dockExtender = new DockExtender(toolStripContainer1); // 'this' is Form1
      // on for the 'dockHost'
      this.debugDockPanelUserControl1.AttachToDockExtender(dockExtender, splitter_main);
      this.debugDockPanelUserControl1.Floaty.Docking += new EventHandler(Floaty_Docking);
      this.windowsToolStripMenuItem.DropDownItems.AddRange(dockExtender.GetListOfToolStripMenuItem());
      foreach (ToolStripMenuItem _menuItem in this.windowsToolStripMenuItem.DropDownItems)
        _menuItem.ToolTipText = "Show/hide " + _menuItem.Text;
      #endregion docking and debug panel
      #region toolstrip (toolbars) show/hide context menus
      // Show and hide toolstrip menus
      this.toolStripContainerHelper = new ToolStripContainerHelper(toolStripContainer1);
      this.toolbarsToolStripMenuItem.DropDownItems.AddRange(toolStripContainerHelper.GetListOfToolStripMenuItem());
      foreach (ToolStripMenuItem tsmi in this.toolbarsToolStripMenuItem.DropDownItems)
        tsmi.ToolTipText = "Show/hide " + tsmi.Text + " toolbar";
      if (toolStripContainer1.TopToolStripPanel.ContextMenuStrip == null)
        toolStripContainer1.TopToolStripPanel.ContextMenuStrip = new ContextMenuStrip();
      toolStripContainer1.TopToolStripPanel.ContextMenuStrip.Items.AddRange(toolStripContainerHelper.GetListOfToolStripMenuItem());
      if (toolStripContainer1.BottomToolStripPanel.ContextMenuStrip == null)
        toolStripContainer1.BottomToolStripPanel.ContextMenuStrip = new ContextMenuStrip();
      toolStripContainer1.BottomToolStripPanel.ContextMenuStrip.Items.AddRange(toolStripContainerHelper.GetListOfToolStripMenuItem());
      if (toolStripContainer1.LeftToolStripPanel.ContextMenuStrip == null)
        toolStripContainer1.LeftToolStripPanel.ContextMenuStrip = new ContextMenuStrip();
      toolStripContainer1.LeftToolStripPanel.ContextMenuStrip.Items.AddRange(toolStripContainerHelper.GetListOfToolStripMenuItem());
      if (toolStripContainer1.RightToolStripPanel.ContextMenuStrip == null)
        toolStripContainer1.RightToolStripPanel.ContextMenuStrip = new ContextMenuStrip();
      toolStripContainer1.RightToolStripPanel.ContextMenuStrip.Items.AddRange(toolStripContainerHelper.GetListOfToolStripMenuItem());
      #endregion toolstrip (toolbars) show/hide context menus
      goToToolStripMenuItem.DropDownOpening += new EventHandler(goToToolStripMenuItem_DropDownOpening);
      m_EditToolStripMenuItem.DropDownOpening += new EventHandler(editToolStripMenuItem_DropDownOpening);
      CheckSaveConstrain(m_SplashScreenObj);
      if (SetAfterInstallationFlag)
      {
        helpUserControl.SetUrl(Resources.MainForm_ReadmePage_mainframe);
        tabControl_Main.SelectedIndex = tabControl_Main.Controls.IndexOf(tabPage_help);
        debugDockPanelUserControl1.Hide();
        this.WindowState = FormWindowState.Maximized;
      }
    }
    private void CheckSaveConstrain(StartUpSplashScreen ss)
    {
      if (!new ImportConstrain().Licensed)
      {
        m_ImportTSMI.Enabled = false;
        m_ImportTSMI.ToolTipText = Resources.LicenseFeatureUnavailable;
      }
      if (!ExportConstrain.IsLicensed)
      {
        m_ExportToolStripMenuItem.Enabled = false;
        m_ExportToolStripMenuItem.ToolTipText = Resources.LicenseFeatureUnavailable;
      }
      if (!CustomEditors.IsLicensed)
      {
        customEditorToolStripMenuItem.Enabled = false;
        customEditorToolStripMenuItem.ToolTipText = Resources.LicenseFeatureUnavailable;
      }
      if (!new BuildSolutionConstrain().Licensed)
      {
        buildProjectToolStripMenuItem.Enabled = false;
        buildProjectToolStripMenuItem.ToolTipText = Resources.LicenseFeatureUnavailable;
      }
      if (SaveConstrain.IsLicensed)
        return;
      saveAsToolStripMenuItem.Enabled = false;
      saveAsToolStripMenuItem.ToolTipText = Resources.LicenseFeatureUnavailable;
      m_SaveToolStripMenuItem.Enabled = false;
      m_SaveToolStripMenuItem.ToolTipText = Resources.LicenseFeatureUnavailable;
      ss.AppendText(string.Format(Resources.SplashScreenLicenseDemoPeriodExpired, Assembly.GetEntryAssembly().GetName().Name), true);
      ss.ActivateBuyNow();
    }
    private ToolStripContainerHelper toolStripContainerHelper;
    private MessageBoxSentEmail messageBoxSentEmail = new MessageBoxSentEmail(Resources.FeatureRequest_EmailAddress,
      Resources.FeatureRequest_Email_Subject, Resources.FeatureRequest_MessageBox_Caption);
    private PropertyGrid myGrid;
    //methods
    private void FeatureRequest(ToolStripMenuItem menuItem)
    {
      string featureName = "not set";
      string featureDescription = "unavailable";
      if (menuItem != null)
      {
        featureName = menuItem.Text;
        ToolStripItem owneritem = menuItem.OwnerItem;
        while (owneritem != null)
        {
          featureName = owneritem.Text + "\\" + featureName;
          owneritem = owneritem.OwnerItem;
        }
        featureDescription = menuItem.ToolTipText;
      }
      messageBoxSentEmail.ShowMessageAndSendEmailIfOK(string.Format(Resources.FeatureRequest_MessageBox_Body, featureName, featureDescription),
        string.Format(Resources.FeatureRequest_Email_Body, featureName));
    }
    private void UpdateWindowTitle()
    {
      this.Text = Resources.MainWindowName;
      string separator = ": ";
      if (OPCFSolutionConfigurationManagement.DefaultInstance.ChangesArePresent)
        separator += Resources.MainForm_Title_ChangesArePresent;
      this.Text += separator + System.IO.Path.GetFileName(OPCFSolutionConfigurationManagement.DefaultInstance.DefaultFileName);
    }
    private bool TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued()
    {
      if (m_MainContol == null)
        return true;
      return OPCFSolutionConfigurationManagement.DefaultInstance.TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued();
    }
    #endregion

    #region private event handlers
    private void Floaty_Docking(object sender, EventArgs e)
    {
      this.tabControl_Main.BringToFront();
      this.debugDockPanelUserControl1.SendToBack();
      this.BringToFront();
    }
    private void OPCFModelConfigurationManagement_DefaultFileNameOrChangesArePresentHasChanged(object sender, EventArgs e)
    {
      UpdateWindowTitle();
    }
    private void OpenSolution(string solutionFileName)
    {
      if (string.IsNullOrEmpty(solutionFileName))
        return;
      try
      {
        if (solutionFileName.StartsWith("file://"))
        {
          solutionFileName = (new System.Uri(solutionFileName)).AbsolutePath;
          solutionFileName = solutionFileName.Replace("%20", " ");
          solutionFileName = solutionFileName.Replace("/", "\\");
        }
        debugDockPanelUserControl1.TextWriterStream.WriteLine("Opening: " + solutionFileName);
        OPCFSolutionConfigurationManagement.DefaultInstance.Open(solutionFileName);
        debugDockPanelUserControl1.TextWriterStream.WriteLine("Opened");
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format(Resources.MainForm_StartupExceptionMessage, ex.Message), "Command line error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
      }
    }

    #region Menu

    #region File
    private void MHExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void MHNewToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued())
        OPCFSolutionConfigurationManagement.DefaultInstance.New();
    }
    private void MHOpenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued())
        OPCFSolutionConfigurationManagement.DefaultInstance.Open();
    }
    private void MHSaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_MainContol.Save(false);
    }
    private void MHSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_MainContol.Save(true);
    }

    #region import
    private void MHFileImport_DropDownOpening(object sender, EventArgs e)
    {
      ToolStripMenuItem _mm = sender as ToolStripMenuItem;
      _mm.DropDownItems.Clear();
      m_MainContol.GetImportMenu(_mm.DropDownItems);
      if (_mm.DropDownItems.Count > 0)
        _mm.DropDownItems.Add(new ToolStripSeparator());
      _mm.DropDownItems.Add(MenuFactory.ImportNodeSetMenuItem((x, y) => m_MainContol.ImportNodeSet()));
      _mm.DropDownItems.Add(m_FromUMLDiagramToolStripMenuItem);
      _mm.DropDownItems.Add(m_FromXMLSchemaToolStripMenuItem);
      _mm.DropDownItems.Add(m_FromVisioToolStripMenuItem);
      _mm.DropDownItems.Add(m_FromEnterpriceArchitectToolStripMenuItem);
      _mm.DropDownItems.Add(m_FileImportFromTSMI);
    }
    private void MHFromFileImportTSMI_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void MHFromVisioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void MHFromEnterpriceArchitectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void MHFromUMLDiagramToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void MHFromXMLSchemaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void m_FromUANodeSetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    #endregion

    #region export
    private void MHExport2Word_Click(object sender, EventArgs e)
    {
      ExportTool.ExportToDocument(m_MainContol.SelectedIModelNodeAdvanced, ExportTool.TypeOfTheDocument.Docx);
    }
    private void MHExport2Excel_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void MHExport2MAML_Click(object sender, EventArgs e)
    {
      ExportTool.ExportToDocument(m_MainContol.SelectedIModelNodeAdvanced, ExportTool.TypeOfTheDocument.Maml);
    }
    private void MHExport2Graphic_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void MHExport2Eny_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void MHExport2XMLSchema_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void MHExport2UML_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void MHExport2EnterpriceArchitect_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void MHExport2Visio_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    #endregion

    #endregion

    #region Edit
    private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
      cutToolStripMenuItem.Enabled = false;
      copyToolStripMenuItem.Enabled = false;
      pasteToolStripMenuItem.Enabled = false;
      if (m_MainContol.ModelTreeViewIsFocused && m_MainContol.SelectedIModelNodeAdvanced != null)
      {
        pasteToolStripMenuItem.Enabled = m_MainContol.SelectedIModelNodeAdvanced.ShouldPasteMenuBeEnabled();
        cutToolStripMenuItem.Enabled = true;
        copyToolStripMenuItem.Enabled = true;
      }
    }
    private void goToToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
      goToToolStripMenuItem.DropDownItems.Clear();
      System.Collections.Generic.List<ToolStripMenuItem> menulist = m_MainContol.GoToMenuItemList;
      if (m_MainContol.ModelTreeViewIsFocused && menulist != null)
      {
        goToToolStripMenuItem.DropDownItems.AddRange(menulist.ToArray());
      }
    }
    #endregion

    private void HelpAboutUaModelDesignerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (AboutForm dial = new AboutForm
                   (null, null, Assembly.GetEntryAssembly()))
      {
        dial.ShowDialog(this);
      }
    }
    private void HelpAboutOpcUaModelCompilerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new AboutOpcUaModelCompilerWindow().ShowDialog(this);
    }
    private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(Resources.AsmdHelp);
      }
      catch (Win32Exception ex)
      {
        MessageBox.Show(string.Format(Resources.MainForm_DefaultAppMissing, Resources.AsmdHelp, ex.Message));
      }
    }
    private void HelpConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      myGrid = new PropertyGrid
      {
        SelectedObject = Properties.Settings.Default
      };
      myGrid.SelectedGridItemChanged += new SelectedGridItemChangedEventHandler(myGrid_SelectedGridItemChanged);
      myGrid.SizeChanged += new EventHandler(myGrid_SizeChanged);
      myGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      int windowHight;
      int windowWidth;
      OKCancelForm myConfigurationForm = new OKCancelForm(Resources.ConfigurationFormName);
      using (myConfigurationForm)
      {
        myConfigurationForm.AddButton("Reset", System.Windows.Forms.DialogResult.Ignore);
        UserControl myControl = new UserControl();
        myControl.Controls.Add(myGrid);
        myConfigurationForm.SetUserControl = myControl;
        myConfigurationForm.CanBeAccepted(true);
        myConfigurationForm.AutoSize = false;
        myConfigurationForm.Height = 580;
        myConfigurationForm.Width = 620;
        System.Windows.Forms.DialogResult dr = myConfigurationForm.ShowDialog(this);
        while (dr == System.Windows.Forms.DialogResult.Ignore)
        {
          windowHight = myConfigurationForm.Height;
          windowWidth = myConfigurationForm.Width;
          myConfigurationForm.StartPosition = FormStartPosition.Manual;
          myGrid.SelectedObject = Properties.Settings.Default;
          myControl.Controls.Clear();
          myControl.Controls.Add(myGrid);
          myConfigurationForm.SetUserControl = myControl;
          myConfigurationForm.Controls[0].Refresh();
          myConfigurationForm.Height = windowHight;
          myConfigurationForm.Width = windowWidth;
          OnReset();
          dr = myConfigurationForm.ShowDialog(this);
          if (dr == System.Windows.Forms.DialogResult.OK)
            OnOk();
          else if (dr == System.Windows.Forms.DialogResult.Cancel)
            OnCancel();
        }
      }
    }

    private void myGrid_SizeChanged(object sender, EventArgs e)
    {
      ChangeDescription(((PropertyGrid)sender).SelectedGridItem.Label);
    }

    private void myGrid_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
    {
      ChangeDescription(e.NewSelection.Label);
    }

    /// <summary>
    /// Changes the description of the item in Property Grid.
    /// </summary>
    /// <param name="propertyGridItemLabel">The property grid item label.</param>
    private void ChangeDescription(string propertyGridItemLabel)
    {
      try
      {
        object oDocComment = myGrid.GetType().InvokeMember("doccomment", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance, null, myGrid, null);
        Label oDocCommentDescription = (Label)oDocComment.GetType().InvokeMember("m_labelDesc", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance, null, oDocComment, null);
        oDocCommentDescription.Text = (string)Resources.ResourceManager.GetString("OptionDescription_" + propertyGridItemLabel);
      }
      catch (Exception ex)
      {
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Warning, 379, Resources.ProblemWithDescriptionForOption + ex.Message);
      }
    }
    private void OnCancel()
    {
      Properties.Settings.Default.Reload();
    }
    private void OnReset()
    {
      Properties.Settings.Default.TargetNamespace = @"http://cas.eu/UA/CommServer/";
      Properties.Settings.Default.TargetXmlNamespace = @"http://cas.eu/UA/CommServer/";
      Properties.Settings.Default.DefaultSolutionFileName = "UAModelDesignerSolution";
      Properties.Settings.Default.FontSize = 8;
      Properties.Settings.Default.CoupledNodesAreEnabled = true;
      Properties.Settings.Default.HelpSynchronizationIsEnabled = true;
      Properties.Settings.Default.XmlUATypesNamespace = @"http://opcfoundation.org/UA/2008/02/Types.xsd";
      Properties.Settings.Default.XmlUATypesPrefix = "ua";
      Properties.Settings.Default.Build_ProjectCompilationString = "-d2 \"{0}\"  -cg \"{1}\" -o \"{2}\" -console";
      Properties.Settings.Default.ProjectCompilationExecutable = @"exe\CAS.CommServer.UA.ModelCompiler.Command.exe";
      Properties.Settings.Default.TargetNamespaceXmlPrefix = "cas";
      Properties.Settings.Default.XmlOPCTypesNamespace = @"http://opcfoundation.org/UA/2008/02/Types.xsd";
      Properties.Settings.Default.XmlOPCTypesPrefix = "uax";
      Properties.Settings.Default.XmlSchemaNamespace = @"http://www.w3.org/2001/XMLSchema";
      Properties.Settings.Default.XmlSchemaPrefix = "xsd";
      Properties.Settings.Default.XmlSchemaInstanceNamespace = @"http://www.w3.org/2001/XMLSchema-instance";
      Properties.Settings.Default.XmlSchemaInstancePrefix = "xsi";
    }
    private void OnOk()
    {
      Properties.Settings.Default.Save();
      MessageBox.Show(Resources.ConfigurationForm_MessageAfterChange);
    }
    private void buildToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_MainContol.Build(debugDockPanelUserControl1.TextWriterStream);
    }
    private void stateMachineEditorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      IModelNodeAdvance imna = m_MainContol.SelectedIModelNodeAdvanced;
      if ((imna != null) && (imna.NodeClass == NodeClassesEnum.ObjectType))
      {
        StateMachineEditorMain.AnalizeStateMachine(imna);
        return;
      }
      MessageBox.Show(Resources.ProblemWithStateMachine_Header, Resources.ProblemWithStateMachine_Info, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
    }
    private void coupledNodesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_MainContol.ModelCoupledNodesAreEnabled = coupledNodesToolStripMenuItem.Checked;
      Settings.Default.CoupledNodesAreEnabled = coupledNodesToolStripMenuItem.Checked;
    }
    private void automaticHelpSynchronisationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Settings.Default.HelpSynchronizationIsEnabled = automaticHelpSynchonisationToolStripMenuItem.Checked;
    }
    private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void printToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void recentSolutionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void undoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void redoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void findToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void allReferencesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void findUnusedNodesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void removeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void toggleBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void disableEnableAllBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void disableEnableBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void previousBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void nextBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void clearAllBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void objectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void childrenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void nodeClassToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.m_MainContol.PerformNodeClassFiltering();
    }
    private void nAmeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void allReferencesToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void othersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void synchronizeTreeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void collapsAllNodesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void buildProjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void verifySolutionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void verifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start(Resources.MainForm_TechnicalSupportPage);
    }
    private void HelpSendUsCommentToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBoxSentEmail.OpenEmailClient(Resources.FeatureRequest_EmailAddress,
        Resources.FeatureRequest_Email_Subject_Comments, Resources.FeatureRequest_Email_Body_Comments);
    }
    private void HelpReadmeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start(Resources.MainForm_ReadmePage);
    }
    private void navigateForwardToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_MainContol.NavigateViewForward();
    }
    private void navigateBackwardToolStripMenuItem_Click(object sender, EventArgs e)
    {
      m_MainContol.NavigateViewBackward();
    }
    private void nodeClassToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void alphabeticallyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FeatureRequest(sender as ToolStripMenuItem);
    }
    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (m_MainContol.ModelTreeViewIsFocused)
      {
        if (m_MainContol.SelectedIModelNodeAdvanced != null)
        {
          m_MainContol.SelectedIModelNodeAdvanced.MenuItemCut_Action();
        }
      }
      else
        MessageBox.Show(Resources.MianWindow_FunctionalityAvailiableOnlyInModelView);
    }
    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (m_MainContol.ModelTreeViewIsFocused)
      {
        if (m_MainContol.SelectedIModelNodeAdvanced != null)
        {
          m_MainContol.SelectedIModelNodeAdvanced.MenuItemCopy_Action();
        }
      }
      else
        MessageBox.Show(Resources.MianWindow_FunctionalityAvailiableOnlyInModelView);
    }
    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (m_MainContol.ModelTreeViewIsFocused)
      {
        if (m_MainContol.SelectedIModelNodeAdvanced != null)
        {
          m_MainContol.SelectedIModelNodeAdvanced.MenuItemPaste_Action();
        }
      }
      else
        MessageBox.Show(Resources.MianWindow_FunctionalityAvailiableOnlyInModelView);
    }
    private void oPCViewerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        Lib.OPCClientControlsLib.MainFormV2008 _mainForm = new Lib.OPCClientControlsLib.MainFormV2008();
        _mainForm.Show();
      }
      catch (Exception ex)
      {
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Warning, 700, $"OPC Viewer has thrown the exception {ex.Message}");
      }
    }
    private void visualisationToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
      visualisationToolStripMenuItem.DropDownItems.Clear();
      visualisationToolStripMenuItem.DropDownItems.AddRange(m_MainContol.TabControlManager.GetToolStripItemCollection());
    }

    #region Server UA
    private void m_MenuServerUA_DropDownOpening(object sender, EventArgs e)
    {
      ToolStripMenuItem _sender = sender as ToolStripMenuItem;
      _sender.DropDownItems.Clear();
      m_MainContol.GetServerUAMenu(_sender.DropDownItems);
    }
    #endregion

    #endregion Menu

    private void m_LicenseInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (LicenseForm dial = new LicenseForm(null, null, Assembly.GetEntryAssembly()))
      {
        Licenses cLicDial = new Licenses();
        dial.SetAdditionalControl = cLicDial;
        dial.LicenceRequestMessageProvider = new LicenseForm.LicenceRequestMessageProviderDelegate(delegate () { return cLicDial.GetLicenseMessageRequest(); });
        dial.ShowDialog(this);
      }
    }
    private void m_LogsContainingFolderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string path = CAS.Lib.CodeProtect.InstallContextNames.ApplicationDataPath + "\\log";
      try
      {
        using (Process process = Process.Start(@path)) { }
      }
      catch (Win32Exception)
      {
        MessageBox.Show("No Log folder exists under this link: " + path + " You can create this folder yourself.", "No Log folder !", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        return;
      }
      catch (Exception)
      {
        MessageBox.Show("An error during opening a log folder occurs and the log folder cannot be open", "Problem with log folder !", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        return;
      }
    }
    private void m_EnterTheUnlockCodeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (UnlockKeyDialog dialog = new UnlockKeyDialog())
      {
        dialog.ShowDialog();
      }
    }

    #region Main
    private string m_StartupFileName = string.Empty;
    private void MainForm_Load(object sender, EventArgs e)
    {
      OpenSolution(m_StartupFileName);
      m_SplashScreenObj.CloseSplashScreen();
      m_SplashScreenObj.Dispose();
      m_SplashScreenObj = null;
    }
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued())
        e.Cancel = true;
    }
    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 763, "Application is closing");
      AssemblyTraceEvent.Tracer.Flush();
      AssemblyTraceEvent.Tracer.Close();
    }
    #endregion

    #endregion private event handlers

    #endregion private

  }

}
