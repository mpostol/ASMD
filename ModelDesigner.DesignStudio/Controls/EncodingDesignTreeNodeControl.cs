//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class EncodingDesignTreeNodeControl : WrapperBaseTreeNodeControl<EncodingDesign, Wrappers4ProperyGrid.EncodingDesign, Opc.Ua.ModelCompiler.EncodingDesign>
  {
    public EncodingDesignTreeNodeControl(EncodingDesign parent)
      : base(parent)
    { }
  }
}
