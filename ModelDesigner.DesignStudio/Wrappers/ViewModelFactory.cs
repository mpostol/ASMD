//_______________________________________________________________
//  Title   : Name of Application
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


namespace CAS.UA.Model.Designer.Wrappers
{
  internal interface IViewModelFactory
  {
    IViewModel Create(ProjectTreeNode modelEntity);
    IViewModel Create(SolutionTreeNode modelEntity);
  }

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