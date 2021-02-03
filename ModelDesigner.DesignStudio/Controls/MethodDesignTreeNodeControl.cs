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
  internal class MethodDesignTreeNodeControl : InstanceDesignTreeNodeControl<MethodDesign, Wrappers4ProperyGrid.MethodDesign, OpcUaModelCompiler.MethodDesign>
  {
    public MethodDesignTreeNodeControl(MethodDesign parent) : base(parent)
    {
    }

    public override DictionaryTreeNode CreateCopy()
    {
      return new MethodDesignTreeNodeControl(ModelEntity);
    }
  }
}