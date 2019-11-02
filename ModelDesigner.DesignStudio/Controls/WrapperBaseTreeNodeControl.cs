//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class WrapperBaseTreeNodeControl<T, type, OPCType> : ValidableTreeNodeControl<T>
    where T : WrapperBase<type, OPCType>
    where type : Wrappers4ProperyGrid.Design<OPCType>
    where OPCType : class, new()

  {
    public WrapperBaseTreeNodeControl(T parent)
      : base(parent)
    { }
    protected override void BeforeMenuStripOpening()
    {
      AddMenuItemDelete();
      AddMenuItemCopyPasteCut();
      base.BeforeMenuStripOpening();
    }
    /// <summary>
    /// Checks the type filter.
    /// </summary>
    /// <param name="AllTypes">if set to <c>true</c> display all nodes.</param>
    /// <param name="types">The types to display.</param>
    /// <returns></returns>
    protected override bool CheckTypeFilter(bool AllTypes, IEnumerable<NodeClassesEnum> types)
    {
      if (AllTypes)
        return true;
      if (this.ModelEntity.NodeClass == NodeClassesEnum.None)
        return true;
      else
        foreach (NodeClassesEnum type in types)
          if (this.ModelEntity.NodeClass == type)
            return true;
      return false;
    }
  }//TreeNode

}
