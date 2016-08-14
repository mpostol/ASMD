namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  partial class BrowseViewObserver
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
      this.m_ProgressBarPleaseWait = new System.Windows.Forms.ProgressBar();
      this.m_LabelPleaseWait = new System.Windows.Forms.Label();
      this.m_PanelPleaseWait = new System.Windows.Forms.Panel();
      this.m_TimerPleaseWait = new System.Windows.Forms.Timer(this.components);
      this.BackgroundWorkerAddressspaceIniialiser = new System.ComponentModel.BackgroundWorker();
      this.m_BrowseViewTreeView = new CAS.UA.Model.Designer.Controls.NodeObserver.BrowseViewTreeView();
      this.m_PanelPleaseWait.SuspendLayout();
      this.SuspendLayout();
      // 
      // m_ProgressBarPleaseWait
      // 
      this.m_ProgressBarPleaseWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.m_ProgressBarPleaseWait.Location = new System.Drawing.Point(3, 172);
      this.m_ProgressBarPleaseWait.Name = "m_ProgressBarPleaseWait";
      this.m_ProgressBarPleaseWait.Size = new System.Drawing.Size(182, 23);
      this.m_ProgressBarPleaseWait.Step = 5;
      this.m_ProgressBarPleaseWait.TabIndex = 1;
      // 
      // m_LabelPleaseWait
      // 
      this.m_LabelPleaseWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.m_LabelPleaseWait.AutoSize = true;
      this.m_LabelPleaseWait.Location = new System.Drawing.Point(3, 156);
      this.m_LabelPleaseWait.Name = "m_LabelPleaseWait";
      this.m_LabelPleaseWait.Size = new System.Drawing.Size(73, 13);
      this.m_LabelPleaseWait.TabIndex = 2;
      this.m_LabelPleaseWait.Text = "Please wait ...";
      // 
      // m_PanelPleaseWait
      // 
      this.m_PanelPleaseWait.Controls.Add(this.m_ProgressBarPleaseWait);
      this.m_PanelPleaseWait.Controls.Add(this.m_LabelPleaseWait);
      this.m_PanelPleaseWait.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_PanelPleaseWait.Location = new System.Drawing.Point(0, 0);
      this.m_PanelPleaseWait.Name = "m_PanelPleaseWait";
      this.m_PanelPleaseWait.Size = new System.Drawing.Size(188, 371);
      this.m_PanelPleaseWait.TabIndex = 3;
      // 
      // m_TimerPleaseWait
      // 
      this.m_TimerPleaseWait.Interval = 500;
      this.m_TimerPleaseWait.Tick += new System.EventHandler(this.TimerPleaseWait_Tick);
      // 
      // BackgroundWorkerAddressspaceIniialiser
      // 
      this.BackgroundWorkerAddressspaceIniialiser.WorkerReportsProgress = true;
      this.BackgroundWorkerAddressspaceIniialiser.WorkerSupportsCancellation = true;
      this.BackgroundWorkerAddressspaceIniialiser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerAddressspaceIniialiser_DoWork);
      this.BackgroundWorkerAddressspaceIniialiser.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerAddressspaceIniialiser_ProgressChanged);
      this.BackgroundWorkerAddressspaceIniialiser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerAddressspaceIniialiser_RunWorkerCompleted);
      // 
      // m_BrowseViewTreeView
      // 
      this.m_BrowseViewTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_BrowseViewTreeView.ImageIndex = 0;
      this.m_BrowseViewTreeView.Location = new System.Drawing.Point(0, 0);
      this.m_BrowseViewTreeView.Name = "m_BrowseViewTreeView";
      this.m_BrowseViewTreeView.SelectedImageIndex = 0;
      this.m_BrowseViewTreeView.Size = new System.Drawing.Size(188, 371);
      this.m_BrowseViewTreeView.TabIndex = 0;
      this.m_BrowseViewTreeView.VisibleChanged += new System.EventHandler(this.BrowseViewTreeView_VisibleChanged);
      // 
      // BrowseViewObserver
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.m_PanelPleaseWait);
      this.Controls.Add(this.m_BrowseViewTreeView);
      this.Name = "BrowseViewObserver";
      this.Size = new System.Drawing.Size(188, 371);
      this.m_PanelPleaseWait.ResumeLayout(false);
      this.m_PanelPleaseWait.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private BrowseViewTreeView m_BrowseViewTreeView;
    private System.Windows.Forms.Label m_LabelPleaseWait;
    private System.Windows.Forms.Panel m_PanelPleaseWait;
    private System.Windows.Forms.Timer m_TimerPleaseWait;
    private System.ComponentModel.BackgroundWorker BackgroundWorkerAddressspaceIniialiser;
    private System.Windows.Forms.ProgressBar m_ProgressBarPleaseWait;
  }
}
