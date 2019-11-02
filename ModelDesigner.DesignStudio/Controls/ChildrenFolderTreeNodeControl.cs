//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class ChildrenFolderTreeNodeControl : FolderTreeNodeControl<ChildrenFolder>
  {

    public ChildrenFolderTreeNodeControl(ChildrenFolder parent)
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
