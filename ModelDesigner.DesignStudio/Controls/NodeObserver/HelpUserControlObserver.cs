//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.HelpContent;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal partial class HelpUserControlObserver : SelectedItemObserver
  {
    #region internal / public

    public HelpUserControlObserver()
    {
      InitializeComponent();
      SetUrl(Properties.Settings.Default.HelpDocumentationOpcUaEbookURL);
    }

    internal void SetUrl(string Url)
    {
      this.textBox_selectedobject.Text = "";
      this.textBox_url.Text = Url;
    }

    protected override void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
      if (Settings.Default.HelpSynchronizationIsEnabled && e.SelectedIModelNode != null)
        NavigateHelpContentToName(e.SelectedIModelNode.Name, e.SelectedIModelNode.HelpTopicName);
    }

    protected override void AfterSolutionChange(object sender, OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs e)
    {
    }

    #endregion internal / public

    #region private

    private void NavigateHelpContentToName(string PrimaryHelpContentName, string SecondaryHelpContentName)
    {
      string newhelp_url = HelpContentHelper.GetHelpUrl(PrimaryHelpContentName, SecondaryHelpContentName, out HelpContentHelper.SelectedTopicName selected);
      if (newhelp_url != Settings.Default.HelpDocumentationOpcUaEbookURL)
      {
        switch (selected)
        {
          case HelpContentHelper.SelectedTopicName.Primary:
            this.textBox_selectedobject.Text = PrimaryHelpContentName;
            break;

          case HelpContentHelper.SelectedTopicName.Secondary:
            this.textBox_selectedobject.Text = SecondaryHelpContentName;
            break;

          default:
            this.textBox_selectedobject.Text = "";
            break;
        }
        this.textBox_url.Text = newhelp_url;
      }
    }

    private void HelpUserControl_VisibleChanged(object sender, EventArgs e)
    {
      if (this.Visible)
      {
        try
        {
          Uri newUri = new Uri(this.textBox_url.Text);
          if (this.webBrowserHelpContent != null &&
            (this.webBrowserHelpContent.Url == null || !this.webBrowserHelpContent.Url.Equals(newUri)))
          {
            this.webBrowserHelpContent.Url = newUri;
          }
        }
        catch (System.Runtime.InteropServices.COMException)
        {
        }
      }
    }

    #endregion private
  }
}