//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Controls
{
  internal class ViewDesignTreeNodeControl : CAS.UA.Model.Designer.Controls.NodeDesignTreeNodeControl<ViewDesign, Wrappers4ProperyGrid.ViewDesign, OpcUaModelCompiler.ViewDesign>
  {
    public ViewDesignTreeNodeControl(ViewDesign parent) : base(parent)
    {
    }

    public override DictionaryTreeNode CreateCopy()
    {
      return new ViewDesignTreeNodeControl(this.ModelEntity);
    }
  }
}