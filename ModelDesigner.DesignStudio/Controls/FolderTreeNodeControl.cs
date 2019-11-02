//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class FolderTreeNodeControl<T> : WrapperTreeNodeControl<T>
    where T : Folder
  {
    public FolderTreeNodeControl(T parent)
      : base(parent)
    { }
  }

}
