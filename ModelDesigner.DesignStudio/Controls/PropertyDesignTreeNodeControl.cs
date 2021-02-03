//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Collections.Generic;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Controls
{
  internal class PropertyDesignTreeNodeControl : InstanceDesignTreeNodeControl<PropertyDesign, Wrappers4ProperyGrid.PropertyDesign, OpcUaModelCompiler.PropertyDesign>
  {
    public PropertyDesignTreeNodeControl(PropertyDesign parent) : base(parent)
    {
    }

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

    public override DictionaryTreeNode CreateCopy()
    {
      return new PropertyDesignTreeNodeControl(ModelEntity);
    }
  }
}