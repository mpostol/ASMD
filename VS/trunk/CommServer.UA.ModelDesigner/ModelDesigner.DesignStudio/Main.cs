//<summary>
//  Title   : Model designer User Interface
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System.Collections.Generic;
using System.Windows.Forms;
using CAS.Lib.ControlLibrary;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer
{
  /// <summary>
  /// Control responsible for managing and visualization of the model.
  /// </summary>
  public partial class Main: UserControl
  {
    #region creator
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
      OPCFSolutionConfigurationManagement.DefaultInstance.GetServerUAMenu( toolStripItemCollection );
      this.m_ModelObserver.GetServerUAMenu( toolStripItemCollection );
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
