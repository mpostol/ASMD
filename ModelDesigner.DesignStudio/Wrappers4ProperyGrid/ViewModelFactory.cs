//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  internal class ViewModelFactory : IViewModelFactory
  {
    public IViewModel Create (ProjectTreeNode modelEntity)
    {
      return new ProjectWrapper(modelEntity);
    }
    public IViewModel Create(SolutionTreeNode modelEntity)
    {
      return new UAModelDesignerSolutionWrapper(modelEntity);
    }
  }
}
