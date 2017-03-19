//_______________________________________________________________
//  Title   : IGraphicalUserInterface
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
  /// Interface IGraphicalUserInterface - provides basic functionality to implement user interactivity for this component.
  /// </summary>
  public interface IGraphicalUserInterface
  {

    /// <summary>
    /// Gets or sets the warning message box show delegate.
    /// </summary>
    /// <value>The message box show action.</value>
    Action<string, string> MessageBoxShowWarning { get; }
    /// <summary>
    /// Gets or sets the exclamation message box show delegate.
    /// </summary>
    /// <value>The message box show.</value>
    Action<string, string> MessageBoxShowExclamation { get; }
    /// <summary>
    /// Gets or sets the error message box show delegate.
    /// </summary>
    /// <value>The message box show action.</value>
    Action<string, string> MessageBoxShowError { get; }
    /// <summary>
    /// Gets the delegate encapsulating the file open dialog creation functionality.
    /// </summary>
    /// <value>The open file dialog function.</value>
    Func<IFileDialog> OpenFileDialogFunc { get; }
    /// <summary>
    /// Gets the delegate encapsulating the file save dialog creation functionality.
    /// </summary>
    /// <value>The create file save dialog function.</value>
    Func<IFileDialog> SaveFileDialogFuc { get; }
    /// <summary>
    /// Gets the open folder browser dialog function returning an object implementing <see cref="IFolderBrowserDialog"/>.
    /// </summary>
    /// <value>The delegate encapsulating function creating an object implementing <see cref="IFolderBrowserDialog"/>.</value>
    Func<IFolderBrowserDialog> OpenFolderBrowserDialogFunc { get; }

  }
}
