using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal interface ISelectedItemObserver
  {
    void OnSelectedItemIsChangedEventHandler(object sender, SelectedItemEventArgs e);
  }

}
