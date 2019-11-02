//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class ReferencesFolderTreeNodeControl : FolderTreeNodeControl<ReferencesFolder>
  {
    public ReferencesFolderTreeNodeControl(ReferencesFolder parent)
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
