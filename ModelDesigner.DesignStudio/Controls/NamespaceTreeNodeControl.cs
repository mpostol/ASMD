//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class NamespaceTreeNodeControl : WrapperBaseTreeNodeControl<Namespace, Wrappers4ProperyGrid.Namespace, Opc.Ua.ModelCompiler.Namespace>
  {
    public NamespaceTreeNodeControl(Namespace parent)
      : base(parent)
    { }
  }
}
