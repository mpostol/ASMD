//<summary>
//  Title   : Node (from model) PropertyGrid Observer
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

using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal partial class NodePropertyObserver: PropertyGridObserver
  {
    public NodePropertyObserver()
    {
      InitializeComponent();
    }
    protected override void UpdatePropertyGridSelectedObject( IModelNode imodelNode )
    {
      if ( imodelNode != null )
        this.PropertyGrid.SelectedObject = imodelNode.Wrapper4PropertyGrid;
    }
    protected override void OnSelectedItemIsChanged( object sender, SelectedItemEventArgs e )
    {
      base.OnSelectedItemIsChanged( sender, e );
      if ( e.SelectedIModelNode != null )
        this.PropertyGrid.Enabled = !e.SelectedIModelNode.IsReadOnly;
      if ( !this.PropertyGrid.Enabled )
        PropertyGrid.ExpandAllGridItems();
    }
  }
}
