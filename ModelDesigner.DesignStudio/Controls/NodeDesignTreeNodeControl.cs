//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using System.Xml;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class NodeDesignTreeNodeControl<T, type, OPCType> : WrapperBaseTreeNodeControl<T, type, OPCType>
    where T : NodeDesign<type, OPCType>
    where type : Wrappers4ProperyGrid.NodeDesign<OPCType>
    where OPCType : OpcUaModelCompiler.NodeDesign, new()

  {
    public NodeDesignTreeNodeControl(T parent)
      : base(parent)
    { }

    internal override void AddNodeToDictionary()
    {
      this.AddToDictionary(ModelEntity.Wrapper.SymbolicName.XmlQualifiedName, this);
      base.AddNodeToDictionary();
    }

    public override XmlQualifiedName SymbolicName => ModelEntity.SymbolicName;
  }
}