namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  internal interface IViewModelFactory
  {
    IViewModel Create(IProjectModelView modelEntity);

    IViewModel Create(ISolutionTreeNodeUI modelEntity);
  }
}