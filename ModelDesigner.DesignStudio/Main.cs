//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using UAOOI.Windows.Forms;

namespace CAS.UA.Model.Designer
{
  /// <summary>
  /// Control responsible for managing and visualization of the model.
  /// </summary>
  public partial class Main : UserControl, INotifyPropertyChanged
  {
    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    private void RaisePropertyChangedEventHandler(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion INotifyPropertyChanged

    #region constructor

    public Main()
    {
      InitializeComponent();
      SolutionConfigurationManagementRoot.DefaultInstance.AfterSolutionChange += DefaultInstance_AfterSolutionChange;
    }

    private void DefaultInstance_AfterSolutionChange(object sender, SolutionConfigurationManagementRoot.AfterSolutionChangeEventArgs e)
    {
      RaisePropertyChangedEventHandler(nameof(SolutionDisplayName));
    }

    #endregion constructor

    #region internal

    internal void PerformNodeClassFiltering()
    {
      if (m_ModelObserver.ModelTreeViewIsFocused)
        m_ModelObserver.PerformNodeClassFiltering();
      else
        MessageBox.Show(Resources.MianWindow_FunctionalityAvailiableOnlyInModelView);
    }

    internal void NavigateViewForward()
    {
      if (m_ModelObserver.ModelTreeViewIsFocused)
        m_ModelObserver.NavigateModelTreeViewForward();
      else
        MessageBox.Show(Resources.MianWindow_FunctionalityAvailiableOnlyInModelView);
    }

    internal void NavigateViewBackward()
    {
      if (m_ModelObserver.ModelTreeViewIsFocused)
        m_ModelObserver.NavigateModelTreeViewBackward();
      else
        MessageBox.Show(Resources.MianWindow_FunctionalityAvailiableOnlyInModelView);
    }

    internal List<ToolStripMenuItem> GoToMenuItemList => m_ModelObserver.GoToMenuItemList;

    internal bool ModelCoupledNodesAreEnabled
    {
      get => m_ModelObserver.CoupledNodesAreEnabled;
      set => m_ModelObserver.CoupledNodesAreEnabled = value;
    }

    internal bool ModelTreeViewIsFocused => m_ModelObserver.ModelTreeViewIsFocused;
    internal IModelNodeAdvance SelectedIModelNodeAdvanced => this.m_selectedItemObserverComponent.IModelNodeAdvance;

    internal void GetServerUAMenu(ToolStripItemCollection toolStripItemCollection)
    {
      m_ModelObserver.GetServerUAMenu(toolStripItemCollection);
    }

    internal void GetImportMenu(ToolStripItemCollection items)
    {
      this.m_ModelObserver.GetImportMenu(items);
    }

    internal TabControlManager TabControlManager => this.m_ViewTabControlManager;

    internal bool TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued()
    {
      return SolutionConfigurationManagementRoot.DefaultInstance.CurrentConfiguration.TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued();
    }

    public string SolutionDisplayName
    {
      get
      {
        string _changesArePresent = SolutionConfigurationManagementRoot.DefaultInstance.CurrentConfiguration.ChangesArePresent ? Resources.MainForm_Title_ChangesArePresent : String.Empty;
        return $" {_changesArePresent} {Path.GetFileName(SolutionConfigurationManagementRoot.DefaultInstance.CurrentConfiguration.DefaultFileName) }";
      }
    }

    internal void Save(bool v)
    {
      m_ModelObserver.Save(v);
    }

    internal void ImportNodeSet()
    {
      m_ModelObserver.ImportNodeSet();
    }

    internal void Build(TextWriter textWriterStream)
    {
      m_ModelObserver.Build(textWriterStream);
    }

    internal void OpenSolution(string solutionFileName)
    {
      m_ModelObserver.OpenSolution(solutionFileName);
    }

    internal void NewSolution()
    {
      m_ModelObserver.NewSolution();
    }

    #endregion internal

  }
}