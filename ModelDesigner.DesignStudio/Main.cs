//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________


using CAS.Lib.ControlLibrary;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer
{
  /// <summary>
  /// Control responsible for managing and visualization of the model.
  /// </summary>
  public partial class Main: UserControl
  {

    #region constructor
    public Main()
    {
      InitializeComponent();
    }
    #endregion

    #region internal
    internal void PerformNodeClassFiltering()
    {
      if ( m_ModelObserver.ModelTreeViewIsFocused )
        m_ModelObserver.PerformNodeClassFiltering();
      else
        MessageBox.Show( Resources.MianWindow_FunctionalityAvailiableOnlyInModelView );
    }
    internal void NavigateViewForward()
    {
      if ( m_ModelObserver.ModelTreeViewIsFocused )
        m_ModelObserver.NavigateModelTreeViewForward();
      else
        MessageBox.Show( Resources.MianWindow_FunctionalityAvailiableOnlyInModelView );
    }
    internal void NavigateViewBackward()
    {
      if ( m_ModelObserver.ModelTreeViewIsFocused )
        m_ModelObserver.NavigateModelTreeViewBackward();
      else
        MessageBox.Show( Resources.MianWindow_FunctionalityAvailiableOnlyInModelView );
    }
    internal List<ToolStripMenuItem> GoToMenuItemList
    {
      get
      {
        return m_ModelObserver.GoToMenuItemList;
      }
    }
    internal bool ModelCoupledNodesAreEnabled
    {
      get { return m_ModelObserver.CoupledNodesAreEnabled; }
      set { m_ModelObserver.CoupledNodesAreEnabled = value; }
    }
    internal bool ModelTreeViewIsFocused
    {
      get
      {
        return m_ModelObserver.ModelTreeViewIsFocused;
      }
    }
    internal IModelNodeAdvance SelectedIModelNodeAdvanced
    {
      get
      {
        return this.m_selectedItemObserverComponent.IModelNodeAdvance;
      }
    }
    internal void GetServerUAMenu( ToolStripItemCollection toolStripItemCollection )
    {
      //TODO UA Server menu is empty #67
      m_ModelObserver.GetServerUAMenu( toolStripItemCollection );
    }
    internal void GetImportMenu( ToolStripItemCollection items )
    {
      this.m_ModelObserver.GetImportMenu( items );
    }
    internal TabControlManager TabControlManager
    {
      get { return this.m_ViewTabControlManager; }
    }
    #endregion
  }
}
