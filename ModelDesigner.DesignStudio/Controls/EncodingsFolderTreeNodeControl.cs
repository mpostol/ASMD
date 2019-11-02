//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class EncodingsFolderTreeNodeControl : FolderTreeNodeControl<EncodingsFolder>
  {
    public EncodingsFolderTreeNodeControl(EncodingsFolder parent)
      : base(parent)
    { }
    protected override void BeforeMenuStripOpening()
    {
      AddMenuItemAdd(ModelEntity.ListOfNodes);
      base.BeforeMenuStripOpening();
    }
  }
}
