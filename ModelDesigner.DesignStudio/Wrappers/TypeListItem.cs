//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class TypeListItem<wrapper>: INodeFactory
    where wrapper: ValidableTreeNode, new()
  {

    #region  INodeFactory
    public ValidableTreeNode Node
    {
      get { return new wrapper(); }
    }
    #endregion

    #region public
    public override string ToString()
    {
      return typeof( wrapper ).Name;
    }
    #endregion

  }
}
