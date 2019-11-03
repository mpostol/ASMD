//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class DataTypeDesignTreeNodeControl : TypeDesignTreeNodeControl<DataTypeDesign, Wrappers4ProperyGrid.DataTypeDesign, Opc.Ua.ModelCompiler.DataTypeDesign>
  {
    #region creator
    public DataTypeDesignTreeNodeControl(DataTypeDesign parent)
      : base(parent)
    { }
    #endregion
  }
}
