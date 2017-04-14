//<summary>
//  Title   : Main controller of node observers
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

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal class MainController
  {

    #region Singleton
    internal static MainController Instance { get; private set; }
    private MainController() { }
    static MainController()
    {
      Instance = new MainController();
    }
    #endregion Singleton

    #region classes
    internal interface ISelectedItemObserver
    {
      void OnSelectedItemIsChangedEventHandler(object sender, SelectedItemEventArgs e);
    }
    internal delegate void SelectedItemIsChangedEventHandler(object sender, SelectedItemEventArgs e);
    internal class SelectedItemObserverSimpleComponent : Component, ISelectedItemObserver
    {
      protected void RaiseSelectedItemIsChanged(SelectedItemEventArgs e)
      {
        MainController.Instance.RaiseSelectedItemIsChanged(this, e);
      }
      protected SelectedItemObserverSimpleComponent()
      {
        MainController.Instance.RegisterSelectedItemObserver(this);
      }
      protected virtual void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e) { }

      #region ISelectedItemObserver
      public void OnSelectedItemIsChangedEventHandler(object sender, SelectedItemEventArgs e)
      {
        if (this != sender)
        {
          OnSelectedItemIsChanged(sender, e);
        }
      }
      #endregion

    }
    internal class SelectedItemObserver : UserControl, ISelectedItemObserver
    {
      #region private
      private bool RemoveMeFromParentTabControlWhenIWillBeConnectedToTabControl = false;
      private IModelNode mSelectedIModelNode;
      private TabPage MyTabPage = null;
      private TabControl MyTabControl = null;
      private void SelectedItemObserver_ParentChanged(object sender, System.EventArgs e)
      {
        if (Parent is TabPage)
        {
          MyTabPage = Parent as TabPage;
          MyTabControl = (TabControl)MyTabPage.Parent;
        }
        if (RemoveMeFromParentTabControlWhenIWillBeConnectedToTabControl)
          RemoveMeFromParentTabControl();
      }
      private void SolutionDefaultInstance_AfterSolutionChange(object sender, OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs e)
      {
        e.Solution.OnDataChanged += new EventHandler<EventArgs>(Solution_OnDataChanged);
        AfterSolutionChange(sender, e);
      }
      private void Solution_OnDataChanged(object sender, EventArgs e)
      {
        this.Refresh();
        AfterSolution_OnDataChanged(sender, e);
      }
      #endregion private

      #region protected
      protected virtual void AfterSolutionChange(object sender, OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs e)
      { }
      protected virtual void AfterSolution_OnDataChanged(object sender, EventArgs e)
      { }
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
          if (MyTabPage != null && MyTabControl != null && MyTabControl.TabPages.Contains(MyTabPage))
          {
            MyTabControl.TabPages.Remove(MyTabPage);
            RemoveMeFromParentTabControlWhenIWillBeConnectedToTabControl = false;
          }
          else
            RemoveMeFromParentTabControlWhenIWillBeConnectedToTabControl = true;
        }
      }
      protected void AddMeToParentTabControl()
      {
        if (AutoTabAddRemoveIsOn && MyTabPage != null && MyTabControl != null && !MyTabControl.TabPages.Contains(MyTabPage))
          MyTabControl.TabPages.Add(MyTabPage);
      }
      protected void RaiseSelectedItemIsChanged(SelectedItemEventArgs e)
      {
        MainController.Instance.RaiseSelectedItemIsChanged(this, e);
      }
      protected IModelNode SelectedIModelNode { get { return mSelectedIModelNode; } }
      protected virtual void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
      { }
      #endregion protected

      #region creators
      protected SelectedItemObserver()
      {
        this.AutoTabAddRemoveIsOn = true;
        MainController.Instance.RegisterSelectedItemObserver(this);
        this.ParentChanged += new System.EventHandler(SelectedItemObserver_ParentChanged);
        OPCFSolutionConfigurationManagement.DefaultInstance.AfterSolutionChange += new System.EventHandler<OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs>(SolutionDefaultInstance_AfterSolutionChange);
      }
      #endregion
      #region internal
      internal bool AutoTabAddRemoveIsOn { get; set; }
      internal virtual void Initialise()
      { }
      #endregion internal

      #region ISelectedItemObserver
      public void OnSelectedItemIsChangedEventHandler(object sender, SelectedItemEventArgs e)
      {
        if (this != sender)
        {
          mSelectedIModelNode = e.SelectedIModelNode;
          OnSelectedItemIsChanged(sender, e);
        }
      }
      #endregion

    }
    #endregion

    #region private
    private event SelectedItemIsChangedEventHandler SelectedItemIsChanged;
    private List<ISelectedItemObserver> mSelectedItemObserverList = new List<ISelectedItemObserver>();
    private void RegisterSelectedItemObserver(ISelectedItemObserver observer)
    {
      mSelectedItemObserverList.Add(observer);
      this.SelectedItemIsChanged += new SelectedItemIsChangedEventHandler(observer.OnSelectedItemIsChangedEventHandler);
    }
    private void RaiseSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
      //set changes are present on default solution instance
      if (e.IsOnlyModification)
        OPCFSolutionConfigurationManagement.DefaultInstance.SetChangesArePresent();
      //raise event on every observer
      SelectedItemIsChanged?.Invoke(sender, e);
    }
    #endregion

  }
}
