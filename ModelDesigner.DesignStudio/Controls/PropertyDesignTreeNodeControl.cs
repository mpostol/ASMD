//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.Controls
{
  internal class PropertyDesignTreeNodeControl : InstanceDesignTreeNodeControl<PropertyDesign, Wrappers4ProperyGrid.PropertyDesign, Opc.Ua.ModelCompiler.PropertyDesign>
  {
    public PropertyDesignTreeNodeControl(PropertyDesign parent)
      : base(parent)
    { }
    protected override void BeforeMenuStripOpening()
    {
      AddMenuItemGoTo(Resources.WrapperTreeNodeAddMenuItemGoto
        + Resources.WrapperTreeNodeAddMenuItemGoto_DataType,
        Resources.WrapperTreeNodeAddMenuItemGoto_DataType_tooltip,
        new EventHandler(AddMenuItemGoTo_Click));
      base.BeforeMenuStripOpening();
    }
    private void AddMenuItemGoTo_Click(object sender, System.EventArgs e)
    {
      TreeView.GoToNode(ModelEntity.Wrapper.DataType.XmlQualifiedName);
    }
    internal override Dictionary<string, System.Xml.XmlQualifiedName> GetCoupledNodesXmlQualifiedNames()
    {
      var list = base.GetCoupledNodesXmlQualifiedNames();
      if (ModelEntity.Wrapper.DataType.XmlQualifiedName != null && !ModelEntity.Wrapper.DataType.XmlQualifiedName.IsEmpty)
        list.Add(Resources.WrapperTreeNodeAddMenuItemGoto_DataType,
          ModelEntity.Wrapper.DataType.XmlQualifiedName);
      return list;
    }
  }
}
