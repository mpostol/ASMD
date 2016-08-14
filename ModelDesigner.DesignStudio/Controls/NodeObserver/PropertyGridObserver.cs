//<summary>
//  Title   : Common class for all PropertyGrid Observers
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

using System.Windows.Forms;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  /// <summary>
  /// Common class for all PropertyGrid Observers.
  /// </summary>
  internal partial class PropertyGridObserver: MainController.SelectedItemObserver
  {

    #region creator
    public PropertyGridObserver()
    {
      InitializeComponent();
      PropertyGrid.SelectedObjectsChanged += new System.EventHandler( PropertyGrid_SelectedObjectsChanged );
      this.ParentChanged += new System.EventHandler( PropertyGridObserver_ParentChanged );
      this.PropertyGrid.PropertyValueChanged += new PropertyValueChangedEventHandler( PropertyGrid_PropertyValueChanged );
      m_propertyGridExpandAllExpander.MyPropertyGrid = m_propertyGrid;
    }
    #endregion

    #region private
    private void PropertyGrid_PropertyValueChanged( object s, PropertyValueChangedEventArgs e )
    {
      RaiseSelectedItemIsChanged( new SelectedItemEventArgs( SelectedIModelNode, true ) );
    }
    private void PropertyGridObserver_ParentChanged( object sender, System.EventArgs e )
    {
      if ( Parent is TabPage )
      {
        if ( AutoTabAddRemoveIsOn && PropertyGrid.SelectedObject == null )
        {
          this.RemoveMeFromParentTabControl();
        }
      }
    }
    private void PropertyGrid_SelectedObjectsChanged( object sender, System.EventArgs e )
    {
      if ( AutoTabAddRemoveIsOn )
      {
        if ( PropertyGrid.SelectedObject == null )
          this.RemoveMeFromParentTabControl();
        if ( PropertyGrid.SelectedObject != null )
          this.AddMeToParentTabControl();
      }
    }
    #endregion

    #region protected
    protected override void OnSelectedItemIsChanged( object sender, SelectedItemEventArgs e )
    {
      IModelNode imodelNode = e.SelectedIModelNode;
      if ( imodelNode != null )
      {
        this.PropertyGrid.Text = imodelNode.NodeClass.ToString();
        UpdatePropertyGridSelectedObject( imodelNode );
      }
      else
      {
        ClearPropertyGrid();
      }
    }
    protected virtual void UpdatePropertyGridSelectedObject( IModelNode imodelNode ) { }
    protected PropertyGrid PropertyGrid
    {
      get
      {
        return m_propertyGrid;
      }
    }
    protected void ClearPropertyGrid()
    {
      this.PropertyGrid.Text = string.Empty;
      this.PropertyGrid.Enabled = false;
      this.PropertyGrid.SelectedObject = null;
    }
    #endregion protected

  }
}
