//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using BaseModelType = Opc.Ua.ModelCompiler.ObjectTypeDesign;

namespace CAS.UA.Model.Designer.Controls
{
  internal class ObjectTypeDesignTreeNodeControl : TypeDesignTreeNodeControl<ObjectTypeDesign, Wrappers4ProperyGrid.ObjectTypeDesign<BaseModelType>, BaseModelType>
  {
    public ObjectTypeDesignTreeNodeControl(ObjectTypeDesign parent)
      : base(parent)
    { }
  }
}
