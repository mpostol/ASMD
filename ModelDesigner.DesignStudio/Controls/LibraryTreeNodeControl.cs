//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal class LibraryTreeNodeControl : RootTreeNodeControl<LibraryTreeNode>
  {
    public LibraryTreeNodeControl(LibraryTreeNode parent) : base(parent) { }
    //TODO Creation LibraryTreeNode fails #44
    protected override void AddChildren(LibraryTreeNode parent)
    {
      throw new System.NotImplementedException();
    }
  }
}
