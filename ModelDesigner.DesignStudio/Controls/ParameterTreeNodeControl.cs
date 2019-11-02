//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class ParameterTreeNodeControl : WrapperBaseTreeNodeControl<Parameter, Wrappers4ProperyGrid.Parameter, Opc.Ua.ModelCompiler.Parameter>
  {
    public ParameterTreeNodeControl(Parameter parent)
      : base(parent)
    { }
  }//TreeNode
}
