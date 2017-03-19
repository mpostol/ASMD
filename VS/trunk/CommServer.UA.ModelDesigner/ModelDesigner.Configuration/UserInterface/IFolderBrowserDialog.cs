//_______________________________________________________________
//  Title   : IFolderBrowserDialog
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

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface
{

  /// <summary>
  /// Interface IFolderBrowserDialog - represents functionality related prompting the user to select a folder.
  /// </summary>
  /// <seealso cref="ICommonDialog" />
  public interface IFolderBrowserDialog : ICommonDialog
  {
    /// <summary>
    /// Gets or sets the path selected by the user.
    /// </summary>
    /// <value>The selected path. The default is an empty string ("").</value>
    string SelectedPath { get; set; }

  }
}