//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{

  internal class MethodDesignTreeNodeControl : InstanceDesignTreeNodeControl<MethodDesign, Wrappers4ProperyGrid.MethodDesign, Opc.Ua.ModelCompiler.MethodDesign>
  {
    public MethodDesignTreeNodeControl(MethodDesign parent) : base(parent) { }
    public override DictionaryTreeNode CreateCopy()
    {
      return new MethodDesignTreeNodeControl(ModelEntity);
    }
  }

}
