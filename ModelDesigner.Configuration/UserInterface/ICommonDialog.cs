//_______________________________________________________________
//  Title   : ICommonDialog
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

using System;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface
{
  /// <summary>
  /// Interface ICommonDialog - defines a base functionality of the user dialog.
  /// </summary>
  public interface ICommonDialog: IDisposable
  {

    /// <summary>
    /// Runs a common dialog box.
    /// </summary>
    /// <returns><c>true</c> if the user clicks OK in the dialog box, <c>false</c> otherwise.</returns>
    bool ShowDialog();

  }
}
