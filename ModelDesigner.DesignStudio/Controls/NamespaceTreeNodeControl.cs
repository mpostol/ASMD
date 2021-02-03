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
  internal class NamespaceTreeNodeControl : WrapperBaseTreeNodeControl<Namespace, Wrappers4ProperyGrid.Namespace, OpcUaModelCompiler.Namespace>
  {
    public NamespaceTreeNodeControl(Namespace parent) : base(parent)
    {
    }

    public override DictionaryTreeNode CreateCopy()
    {
      return new NamespaceTreeNodeControl(ModelEntity);
    }
  }
}