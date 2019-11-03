//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class DictionaryDesignTreeNodeControl : InstanceDesignTreeNodeControl<DictionaryDesign, Wrappers4ProperyGrid.DictionaryDesign, Opc.Ua.ModelCompiler.DictionaryDesign>
  {
    public DictionaryDesignTreeNodeControl(DictionaryDesign parent)
      : base(parent)
    { }
  }

}
