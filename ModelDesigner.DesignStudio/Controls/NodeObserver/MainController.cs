//<summary>
//  Title   : Main controller of node observers
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  /// <summary>
  /// Class MainController - observer of the 
  /// </summary>
  internal class MainController
  {

    #region Singleton
    internal static MainController Instance { get; private set; }
    private MainController() { }
    static MainController()
    {
      Instance = new MainController();
    }
    #endregion Singleton

    #region private
    private EventHandler<SelectedItemEventArgs> SelectedItemIsChanged;
    private List<ISelectedItemObserver> m_SelectedItemObserverList = new List<ISelectedItemObserver>();
    #endregion

    #region API
    internal void RegisterSelectedItemObserver(ISelectedItemObserver observer)
    {
      m_SelectedItemObserverList.Add(observer);
      this.SelectedItemIsChanged += observer.OnSelectedItemIsChangedEventHandler;
    }
    internal void RaiseSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
      //set changes are present on default solution instance
      if (e.IsOnlyModification)
        OPCFSolutionConfigurationManagement.DefaultInstance.SetChangesArePresent();
      //raise event on every observer
      SelectedItemIsChanged?.Invoke(sender, e);
    }
    #endregion

  }
}
