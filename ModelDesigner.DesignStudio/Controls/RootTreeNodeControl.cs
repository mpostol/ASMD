//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class RootTreeNodeControl<T> : BaseTreeNodeControl<T, T>
    where T : RootTreeNode
  {

    #region creator
    public RootTreeNodeControl(T parent)
      : base(parent)
    { }
    #endregion

  }
}
