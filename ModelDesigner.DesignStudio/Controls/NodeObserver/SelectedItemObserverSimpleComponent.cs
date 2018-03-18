//_______________________________________________________________
//  Title   : SelectedItemObserverSimpleComponent
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
    protected virtual void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e) { }

    #region ISelectedItemObserver
    public void OnSelectedItemIsChangedEventHandler(object sender, SelectedItemEventArgs e)
    {
      if (this != sender)
      {
        OnSelectedItemIsChanged(sender, e);
      }
    }
    #endregion

  }

}
