//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal interface IDictionaryTreeNodeCreateCopy
  {
    DictionaryTreeNode CreateCopy();
  }

  internal abstract class ValidableTreeNodeControl<T> : WrapperTreeNodeControl<T>, IValidate, IDictionaryTreeNodeCreateCopy
      where T : ValidableTreeNode
  {
    #region creator
    public ValidableTreeNodeControl(T parent) : base(parent) { }

    #region IDictionaryTreeNodeCreateCopy
    public abstract DictionaryTreeNode CreateCopy();
    #endregion

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
