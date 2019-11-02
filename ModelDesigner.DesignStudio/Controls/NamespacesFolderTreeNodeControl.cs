//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class NamespacesFolderTreeNodeControl : FolderTreeNodeControl<NamespacesFolder>
  {
    public NamespacesFolderTreeNodeControl(NamespacesFolder parent)
      : base(parent)
    { }
    protected override void BeforeMenuStripOpening()
    {
      AddMenuItemPaste();
      AddMenuItemAdd(ModelEntity.ListOfNodes);
      base.BeforeMenuStripOpening();
    }
  }
}
