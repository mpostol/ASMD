//_______________________________________________________________
//  Title   : IOpenFileDialog
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
  /// Displays a standard dialog box that prompts the user to open a file.
  /// </summary>
  /// <seealso cref="System.IDisposable" />
  public interface IFileDialog : ICommonDialog
  {
    /// <summary>
    /// Gets or sets the default file name extension.
    /// </summary>
    /// <value>The default file name extension. The returned string does not include the period. The default value is an empty string ("")</value>
    string DefaultExt { get; set; }

    /// <summary>
    /// Gets or sets a string containing the file name selected in the file dialog box.
    /// </summary>
    /// <value>The file name selected in the file dialog box. The default value is an empty string ("")</value>
    string FileName { get; set; }
    /// <summary>
    /// Gets or sets the current file name filter string, which determines the choices that appear in the "Save as file type" or "Files of type" box in the dialog box.
    /// </summary>
    /// <value>The file filtering options available in the dialog box.</value>
    string Filter { get; set; }
    /// <summary>
    /// Gets or sets the initial directory displayed by the file dialog box..
    /// </summary>
    /// <value>The initial directory displayed by the file dialog box. The default is an empty string ("").
    /// </value>
    string InitialDirectory { get; set; }
    /// <summary>
    /// Gets or sets the file dialog box title.
    /// </summary>
    /// <value>The file dialog box title. The default value is an empty string ("").</value>
    string Title { get; set; }

  }
}