//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class VariableTypeDesignTreeNodeControl : TypeDesignTreeNodeControl<VariableTypeDesign, Wrappers4ProperyGrid.VariableTypeDesign, Opc.Ua.ModelCompiler.VariableTypeDesign>
  {
    public VariableTypeDesignTreeNodeControl(VariableTypeDesign parent)
      : base(parent)
    { }
  }
}
