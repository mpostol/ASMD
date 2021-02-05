//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal partial class BrowseViewObserver : SelectedItemObserver
  {
    #region creator

    public BrowseViewObserver()
      : base()
    {
      InitializeComponent();
      this.m_BrowseViewTreeView.AfterSelect += new BrowseViewTreeView.BrowseViewTreeViewEventHandler(this.BrowseViewTreeView_AfterSelect);
    }

    #endregion creator

    #region private

    private bool mBuildIsRequired = true;

    private void SetPleaseWaitTextStep1()
    {
      m_LabelPleaseWait.Text = Resources.BrowseViewObserver_pleasewait_step1;
    }

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
      IElement[] _asInstance = AddressSpaceService.CreateInstance(SolutionTreeNode.SolutionRoot.ResetAndAddToAddressSpace, x => worker.ReportProgress(1, x));
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
        MessageBox.Show(_msg, "Compilation error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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

    protected override void AfterSolutionChange(object sender, SolutionConfigurationManagementRoot.AfterSolutionChangeEventArgs e)
    {
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

    #endregion protected
  }
}