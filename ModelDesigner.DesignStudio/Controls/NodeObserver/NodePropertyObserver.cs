//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal partial class NodePropertyObserver : PropertyGridObserver
  {
    public NodePropertyObserver()
    {
      InitializeComponent();
    }

    protected override void UpdatePropertyGridSelectedObject(IModelNode imodelNode)
    {
      if (imodelNode != null)
        this.PropertyGrid.SelectedObject = imodelNode.Wrapper4PropertyGrid;
    }

    protected override void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
      base.OnSelectedItemIsChanged(sender, e);
      if (e.SelectedIModelNode != null)
        this.PropertyGrid.Enabled = !e.SelectedIModelNode.IsReadOnly();
      if (!this.PropertyGrid.Enabled)
        PropertyGrid.ExpandAllGridItems();
    }
  }
}