//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.Controls
{
  internal class ReferenceTreeNodeControl : WrapperBaseTreeNodeControl<Reference, Wrappers4ProperyGrid.Reference, Opc.Ua.ModelCompiler.Reference>
  {
    public ReferenceTreeNodeControl(Reference parent) : base(parent) { }
    internal override Dictionary<string, System.Xml.XmlQualifiedName> GetCoupledNodesXmlQualifiedNames()
    {
      Dictionary<string, System.Xml.XmlQualifiedName> list = base.GetCoupledNodesXmlQualifiedNames();
      if (ModelEntity.Wrapper.ReferenceType.XmlQualifiedName != null && !ModelEntity.Wrapper.ReferenceType.XmlQualifiedName.IsEmpty)
        list.Add(Resources.WrapperTreeNodeAddMenuItemGoto_ReferenceType,
          ModelEntity.Wrapper.ReferenceType.XmlQualifiedName);
      if (ModelEntity.Wrapper.TargetId.XmlQualifiedName != null && !ModelEntity.Wrapper.TargetId.XmlQualifiedName.IsEmpty)
        list.Add(Resources.WrapperTreeNodeAddMenuItemGoto_Target,
          ModelEntity.Wrapper.TargetId.XmlQualifiedName);
      return list;
    }
    public override DictionaryTreeNode CreateCopy()
    {
      return new ReferenceTreeNodeControl(this.ModelEntity);
    }
  }
}
