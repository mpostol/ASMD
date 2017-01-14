//<summary>
//  Title   : BrowseView Observer 
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

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal partial class BrowseViewObserver : MainController.SelectedItemObserver
  {
    #region creator
    public BrowseViewObserver()
      : base()
    {
      InitializeComponent();
      if (LicenseManager.CurrentContext.UsageMode == LicenseUsageMode.Designtime)
        return;
      CheckLicense();
    }
    #endregion

    #region private
    [LicenseProvider(typeof(CAS.Lib.CodeProtect.CodeProtectLP))]
    [System.Runtime.InteropServices.GuidAttribute("D3028D63-52A1-4a66-9946-B8048C459AC7")]
    private sealed class LicenseProtection : StartUpSplashScreen.LogedIsLicensed<LicenseProtection> { }
    private bool mBuildIsRequired = true;
    private void CheckLicense()
    {
      if (new LicenseProtection().Licensed)
      {
        this.m_BrowseViewTreeView.AfterSelect +=
          new BrowseViewTreeView.BrowseViewTreeViewEventHandler(this.BrowseViewTreeView_AfterSelect);
      }
      else
        this.RemoveMeFromParentTabControl();
    }
    private void SetPleaseWaitTextStep1() { m_LabelPleaseWait.Text = Resources.BrowseViewObserver_pleasewait_step1; }
    private void HideWaitMessage()
    {
      m_ProgressBarPleaseWait.Value = m_ProgressBarPleaseWait.Maximum;
      m_TimerPleaseWait.Enabled = false;
      m_PanelPleaseWait.Visible = false;
    }

    #region handlers
    private void TimerPleaseWait_Tick(object sender, EventArgs e)
    {
      m_ProgressBarPleaseWait.PerformStep();
      if (m_ProgressBarPleaseWait.Value >= m_ProgressBarPleaseWait.Maximum)
        m_ProgressBarPleaseWait.Value = m_ProgressBarPleaseWait.Minimum;
    }
    private void BrowseViewTreeView_AfterSelect(object sender, BrowseViewTreeView.BrowseViewTreeViewEventArgs e)
    {
      GenerateSelectedItemIsChangeEvent(e.ModelNode);
    }
    private void GenerateSelectedItemIsChangeEvent(IModelNode node)
    {
      SelectedItemEventArgs args = new SelectedItemEventArgs(node, false);
      RaiseSelectedItemIsChanged(args);
    }
    private void BrowseViewTreeView_VisibleChanged(object sender, EventArgs e)
    {
      TestIfBuildIsRequiredAndDoTheBuild(false);
    }
    private void TestIfBuildIsRequiredAndDoTheBuild(bool SolutionHasBeenChanged)
    {
      if (this.BackgroundWorkerAddressspaceIniialiser == null)
        return;
      if (SolutionHasBeenChanged && BackgroundWorkerAddressspaceIniialiser.IsBusy)
      {
        BackgroundWorkerAddressspaceIniialiser.CancelAsync();
      }
      if (this.Visible && !BackgroundWorkerAddressspaceIniialiser.IsBusy && mBuildIsRequired)
      {
        mBuildIsRequired = false;
        //if compilation is necessary display wait message
        m_PanelPleaseWait.Visible = true;
        m_ProgressBarPleaseWait.Value = m_ProgressBarPleaseWait.Minimum;
        m_TimerPleaseWait.Enabled = true;
        this.SetPleaseWaitTextStep1();
        BackgroundWorkerAddressspaceIniialiser.RunWorkerAsync();
      }
      else
      {
        if (this.Visible && this.m_BrowseViewTreeView.SelectedNode != null)
        {
          TreeNode node = this.m_BrowseViewTreeView.SelectedNode;
          this.m_BrowseViewTreeView.SelectedNode = null;
          this.m_BrowseViewTreeView.SelectedNode = node;
        }
      }
    }
    private void BackgroundWorkerAddressspaceIniialiser_DoWork(object sender, DoWorkEventArgs e)
    {
      BackgroundWorker worker = sender as BackgroundWorker;
      IElement[] _asInstance = AddressSpaceService.CreateInstance(Root.ResetAndAddToAddressSpace, x => worker.ReportProgress(1, x));
      e.Result = _asInstance;
    }
    private void BackgroundWorkerAddressspaceIniialiser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.HideWaitMessage();
      m_TimerPleaseWait.Enabled = false;
      if (e.Error != null)
      {
        string _msg = String.Format("Compilation process has been interrupted by the exception: {0} message: {1}.", e.Error.GetType().Name, e.Error.Message);
        AssemblyTraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Error, 121, _msg);
        MessageBox.Show(_msg, "Compilation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      if (e.Cancelled)
        return;
      m_BrowseViewTreeView.Show((IElement[])e.Result, true);
    }
    private void BackgroundWorkerAddressspaceIniialiser_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Information, 132, (String)e.UserState);
    }
    #endregion handlers

    #endregion private

    #region protected
    protected override void AfterSolutionChange(object sender, CAS.UA.Model.Designer.IO.OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs e)
    {
      base.AfterSolutionChange(sender, e);
      mBuildIsRequired = true;
      TestIfBuildIsRequiredAndDoTheBuild(true);
    }
    protected override void AfterSolution_OnDataChanged(object sender, EventArgs e)
    {
      base.AfterSolution_OnDataChanged(sender, e);
      mBuildIsRequired = true;
    }
    protected override void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
      if (e.IsOnlyModification)
        mBuildIsRequired = true;
    }
    #endregion

  }
}
