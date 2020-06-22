//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Wrappers;
using System;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  /// <summary>
  /// Class MainController - observer of the
  /// </summary>
  internal class MainController
  {
    #region Singleton

    internal static MainController Instance { get { if (m_This == null) m_This = new MainController(); return m_This; } }

    private static MainController m_This;

    private MainController()
    {
    }

    #endregion Singleton

    #region private

    private EventHandler<SelectedItemEventArgs> SelectedItemIsChanged;

    private ISolutionConfigurationManagement m_Solution;

    #endregion private

    #region API

    internal void Initialize(ISolutionConfigurationManagement solution)
    {
      m_Solution = solution;
    }

    internal void RegisterSelectedItemObserver(ISelectedItemObserver observer)
    {
      //m_SelectedItemObserverList.Add(observer);
      this.SelectedItemIsChanged += observer.OnSelectedItemIsChangedEventHandler;
    }

    internal void RaiseSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
      //set changes are present on default solution instance
      if (e.IsOnlyModification)
        m_Solution.SetChangesArePresent();
      //raise event on every observer
      SelectedItemIsChanged?.Invoke(sender, e);
    }

    #endregion API
  }
}