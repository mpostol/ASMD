//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class ValidableTreeNodeControl<T> : WrapperTreeNodeControl<T>, IValidate
      where T : ValidableTreeNode
  {
    #region creator
    public ValidableTreeNodeControl(T parent)
      : base(parent)
    { }
    #endregion

    #region IValidate Members
    public void Validate()
    {
      ModelEntity.Validate();
      if (this.TreeView != null)
        this.TreeView.RebuildDictionary();
    }
    #endregion
  }
}
