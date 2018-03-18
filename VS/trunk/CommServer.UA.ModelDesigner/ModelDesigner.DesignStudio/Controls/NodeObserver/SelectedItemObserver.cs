﻿
/**///_______________________________________________________________
//  Title   : SelectedItemObserver
//  System  : Microsoft VisualStudio 2015 / C#
//  $LastChangedDate:  $
//  $Rev: $
//  $LastChangedBy: $
//  $URL: $
//  $Id:  $
//
//  Copyright (C) 2017, CAS LODZ POLAND.
//  TEL: +48 608 61 98 99 
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal class SelectedItemObserver : UserControl, ISelectedItemObserver
  {

    #region private
    private bool m_RemoveMeFromParentTab = false;
    private IModelNode m_SelectedIModelNode;
    private TabPage m_TabPage = null;
    private TabControl m_TabControl = null;
    private void SelectedItemObserver_ParentChanged(object sender, System.EventArgs e)
    {
      if (Parent is TabPage)
      {
        m_TabPage = Parent as TabPage;
        m_TabControl = (TabControl)m_TabPage.Parent;
      }
      if (m_RemoveMeFromParentTab)
        RemoveMeFromParentTabControl();
    }
    #endregion private

    #region protected
    protected virtual void AfterSolutionChange(object sender, OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs e) { }
    protected virtual void AfterSolution_OnDataChanged(object sender, EventArgs e) { }
    protected void ShowMessage(string message)
    {
      Label infolabel = new Label();
      infolabel.Size = this.Size;
      infolabel.Text = message;
      this.Controls.Add(infolabel);
    }
    protected void RemoveMeFromParentTabControl()
    {
      if (AutoTabAddRemoveIsOn)
      {
        if (m_TabPage != null && m_TabControl != null && m_TabControl.TabPages.Contains(m_TabPage))
        {
          m_TabControl.TabPages.Remove(m_TabPage);
          m_RemoveMeFromParentTab = false;
        }
        else
          m_RemoveMeFromParentTab = true;
      }
    }
    protected void AddMeToParentTabControl()
    {
      if (AutoTabAddRemoveIsOn && m_TabPage != null && m_TabControl != null && !m_TabControl.TabPages.Contains(m_TabPage))
        m_TabControl.TabPages.Add(m_TabPage);
    }
    protected void RaiseSelectedItemIsChanged(SelectedItemEventArgs e)
    {
      MainController.Instance.RaiseSelectedItemIsChanged(this, e);
    }
    protected IModelNode SelectedIModelNode { get { return m_SelectedIModelNode; } }
    protected virtual void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e) { }
    #endregion protected

    #region constructor
    protected SelectedItemObserver()
    {
      MainController.Instance.RegisterSelectedItemObserver(this);
      this.ParentChanged += new EventHandler(SelectedItemObserver_ParentChanged);
      OPCFSolutionConfigurationManagement.DefaultInstance.AfterSolutionChange += new EventHandler<OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs>(AfterSolutionChange);
    }
    #endregion

    #region internal API
    internal bool AutoTabAddRemoveIsOn { get; set; } = true;
    internal virtual void Initialise() { }
    #endregion internal

    #region ISelectedItemObserver
    public void OnSelectedItemIsChangedEventHandler(object sender, SelectedItemEventArgs e)
    {
      if (this != sender)
      {
        m_SelectedIModelNode = e.SelectedIModelNode;
        OnSelectedItemIsChanged(sender, e);
      }
    }
    #endregion

  }

}
