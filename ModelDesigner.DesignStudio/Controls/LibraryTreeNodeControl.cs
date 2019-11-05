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
    //TODO Refactoring application architecture - remove recursion #6
    protected override void AddChildren(LibraryTreeNode parent)
    {
      throw new System.NotImplementedException();
    }
  }
}
