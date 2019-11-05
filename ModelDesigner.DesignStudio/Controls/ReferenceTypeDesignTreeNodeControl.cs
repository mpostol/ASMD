//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class ReferenceTypeDesignTreeNodeControl : TypeDesignTreeNodeControl<ReferenceTypeDesign, Wrappers4ProperyGrid.ReferenceTypeDesign, Opc.Ua.ModelCompiler.ReferenceTypeDesign>
  {
    public ReferenceTypeDesignTreeNodeControl(ReferenceTypeDesign parent) : base(parent) { }
    public override DictionaryTreeNode CreateCopy()
    {
      return new ReferenceTypeDesignTreeNodeControl (ModelEntity);
    }
  }
}
