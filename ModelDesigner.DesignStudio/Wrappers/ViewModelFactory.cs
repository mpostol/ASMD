//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer.Wrappers
{

  internal static class ViewModelFactory
  {
    internal static IViewModel Create(this SolutionTreeNode modelEntity)
    {
      return Factory.Create(modelEntity);
    }

    internal static IViewModel Create(this ProjectTreeNode modelEntity)
    {
      return Factory.Create(modelEntity);
    }

    internal static IViewModelFactory Factory { set; private get; } = null;
  }
}