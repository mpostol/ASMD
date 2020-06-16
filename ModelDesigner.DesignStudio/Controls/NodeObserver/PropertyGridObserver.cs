//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Wrappers;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  /// <summary>
  /// Common class for all PropertyGrid Observers.
  /// </summary>
  internal partial class PropertyGridObserver : SelectedItemObserver
  {
    #region creator

    public PropertyGridObserver()
    {
      InitializeComponent();
      PropertyGrid.SelectedObjectsChanged += new System.EventHandler(PropertyGrid_SelectedObjectsChanged);
      this.ParentChanged += new System.EventHandler(PropertyGridObserver_ParentChanged);
      this.PropertyGrid.PropertyValueChanged += new PropertyValueChangedEventHandler(PropertyGrid_PropertyValueChanged);
      m_propertyGridExpandAllExpander.MyPropertyGrid = m_propertyGrid;
    }

    #endregion creator

    #region private

    private void PropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
    {
      RaiseSelectedItemIsChanged(new SelectedItemEventArgs(SelectedIModelNode, true));
    }

    private void PropertyGridObserver_ParentChanged(object sender, System.EventArgs e)
    {
      if (Parent is TabPage)
      {
        if (AutoTabAddRemoveIsOn && PropertyGrid.SelectedObject == null)
        {
          this.RemoveMeFromParentTabControl();
        }
      }
    }

    private void PropertyGrid_SelectedObjectsChanged(object sender, System.EventArgs e)
    {
      if (AutoTabAddRemoveIsOn)
      {
        if (PropertyGrid.SelectedObject == null)
          this.RemoveMeFromParentTabControl();
        if (PropertyGrid.SelectedObject != null)
          this.AddMeToParentTabControl();
      }
    }

    #endregion private

    #region SelectedItemObserver

    protected override void AfterSolutionChange(object sender, OPCFSolutionConfigurationManagement.AfterSolutionChangeEventArgs e)
    {
    }

    protected override void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
      IModelNode imodelNode = e.SelectedIModelNode;
      if (imodelNode != null)
      {
        this.PropertyGrid.Text = imodelNode.NodeClass.ToString();
        UpdatePropertyGridSelectedObject(imodelNode);
      }
      else
      {
        ClearPropertyGrid();
      }
    }

    protected virtual void UpdatePropertyGridSelectedObject(IModelNode imodelNode)
    {
    }

    protected PropertyGrid PropertyGrid => m_propertyGrid;

    protected void ClearPropertyGrid()
    {
      this.PropertyGrid.Text = string.Empty;
      this.PropertyGrid.Enabled = false;
      this.PropertyGrid.SelectedObject = null;
    }

    #endregion SelectedItemObserver
  }
}