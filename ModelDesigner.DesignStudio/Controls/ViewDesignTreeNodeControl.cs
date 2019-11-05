//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class ViewDesignTreeNodeControl : CAS.UA.Model.Designer.Controls.NodeDesignTreeNodeControl<ViewDesign, Wrappers4ProperyGrid.ViewDesign, Opc.Ua.ModelCompiler.ViewDesign>
  {
    public ViewDesignTreeNodeControl(ViewDesign parent) : base(parent) { }
    public override DictionaryTreeNode CreateCopy()
    {
      return new ViewDesignTreeNodeControl(this.ModelEntity);
    }
  }
}
