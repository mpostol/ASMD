//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  internal class ViewModelFactory : IViewModelFactory
  {
    public IViewModel Create(IProjectModelView modelEntity)
    {
      return new ProjectWrapper(modelEntity);
    }

    public IViewModel Create(ISolutionTreeNodeUI modelEntity)
    {
      return new UAModelDesignerSolutionWrapper(modelEntity);
    }
  }
}