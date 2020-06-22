//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using System.ComponentModel;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal class SelectedItemObserverSimpleComponent : Component, ISelectedItemObserver
  {
    protected void RaiseSelectedItemIsChanged(SelectedItemEventArgs e)
    {
      MainController.Instance.RaiseSelectedItemIsChanged(this, e);
    }

    protected SelectedItemObserverSimpleComponent()
    {
      MainController.Instance.RegisterSelectedItemObserver(this);
    }

    protected virtual void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
    }

    #region ISelectedItemObserver

    public void OnSelectedItemIsChangedEventHandler(object sender, SelectedItemEventArgs e)
    {
      if (this != sender)
      {
        OnSelectedItemIsChanged(sender, e);
      }
    }

    #endregion ISelectedItemObserver
  }
}