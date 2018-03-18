//_______________________________________________________________
//  Title   : ViewModelFactory
//  System  : Microsoft VisualStudio 2015 / C#
//  $LastChangedDate:  $
//  $Rev: $
//  $LastChangedBy: $
//  $URL: $
//  $Id:  $
//
//  Copyright (C) 2017, CAS LODZ POLAND.
//  TEL: +48 608 61 98 99 
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

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
