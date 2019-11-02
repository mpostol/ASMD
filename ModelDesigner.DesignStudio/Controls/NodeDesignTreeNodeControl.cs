//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using System.Xml;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class NodeDesignTreeNodeControl<T, type, OPCType> : WrapperBaseTreeNodeControl<T, type, OPCType>
    where T : NodeDesign<type, OPCType>
    where type : Wrappers4ProperyGrid.NodeDesign<OPCType>
    where OPCType : Opc.Ua.ModelCompiler.NodeDesign, new()

  {
    public NodeDesignTreeNodeControl(T parent)
      : base(parent)
    { }
    internal override void AddNodeToDictionary()
    {
      this.AddToDictionary(ModelEntity.Wrapper.SymbolicName.XmlQualifiedName, this);
      base.AddNodeToDictionary();
    }
    public override XmlQualifiedName SymbolicName
    {
      get { return ModelEntity.SymbolicName; }
    }
  }
}
