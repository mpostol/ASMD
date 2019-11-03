//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Collections.Generic;
using BaseModelType = Opc.Ua.ModelCompiler.VariableDesign;

namespace CAS.UA.Model.Designer.Controls
{
  internal class VariableDesignTreeNodeControl : InstanceDesignTreeNodeControl<VariableDesign, Wrappers4ProperyGrid.VariableDesign<BaseModelType>, BaseModelType>
  {
    public VariableDesignTreeNodeControl(VariableDesign parent)
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
      Dictionary<string, System.Xml.XmlQualifiedName> list = base.GetCoupledNodesXmlQualifiedNames();
      if (ModelEntity.Wrapper.DataType.XmlQualifiedName != null && !ModelEntity.Wrapper.DataType.XmlQualifiedName.IsEmpty)
        list.Add(Resources.WrapperTreeNodeAddMenuItemGoto_DataType,
          ModelEntity.Wrapper.DataType.XmlQualifiedName);
      return list;
    }
  }

}
