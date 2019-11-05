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

    public DataTypeDesignTreeNodeControl(DataTypeDesign parent) : base(parent) { }
    public override DictionaryTreeNode CreateCopy()
    {
      return new DataTypeDesignTreeNodeControl(ModelEntity);
    }

  }
}
