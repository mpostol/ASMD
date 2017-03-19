//_______________________________________________________________
//  Title   : GraphicalUserInterface
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
using System.Windows.Forms;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface
{
  
  /// <summary>
  /// Class GraphicalUserInterface implementing <see cref="IGraphicalUserInterface"/> for local purpose.
  /// </summary>
  /// <seealso cref="CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface.IGraphicalUserInterface" />
  internal class GraphicalUserInterface : IGraphicalUserInterface
  {

    #region constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="GraphicalUserInterface"/> class.
    /// </summary>
    internal GraphicalUserInterface()
    {
      MessageBoxShowWarning = (z, y) => MessageBoxShowDefault(z, y, MessageBoxIcon.Warning);
      MessageBoxShowExclamation = (z, y) => MessageBoxShowDefault(z, y, MessageBoxIcon.Exclamation);
      MessageBoxShowError = (z, y) => MessageBoxShowDefault(z, y, MessageBoxIcon.Error);
      OpenFileDialogFunc = () => new OpenFileDialogWrapper();
      SaveFileDialogFuc = () => new SaveFileDialogWrapper();
      OpenFolderBrowserDialogFunc = () => new FolderBrowserDialogWrapper();
    }
    #endregion

    #region IGraphicalUserInterface
    /// <summary>
    /// Gets or sets the warning message box show delegate.
    /// </summary>
    /// <value>The message box show action.</value>
    public Action<string, string> MessageBoxShowWarning
    {
      get; private set;
    }
    /// <summary>
    /// Gets or sets the exclamation message box show delegate.
    /// </summary>
    /// <value>The message box show.</value>
    public Action<string, string> MessageBoxShowExclamation
    {
      get; private set;
    }
    /// <summary>
    /// Gets or sets the error message box show delegate.
    /// </summary>
    /// <value>The message box show action.</value>
    public Action<string, string> MessageBoxShowError
    {
      get; private set;
    }
    /// <summary>
    /// Gets the delegate encapsulating the file open dialog creation functionality.
    /// </summary>
    /// <value>The open file dialog function.</value>
    public Func<IFileDialog> OpenFileDialogFunc
    {
      get; private set;
    }
    /// <summary>
    /// Gets the delegate encapsulating the file save dialog creation functionality.
    /// </summary>
    /// <value>The create file save dialog function.</value>
    public Func<IFileDialog> SaveFileDialogFuc
    {
      get; private set;
    }
    /// <summary>
    /// Gets the open folder browser dialog function returning an object implementing <see cref="IFolderBrowserDialog" />.
    /// </summary>
    /// <value>The delegate encapsulating function creating an object implementing <see cref="IFolderBrowserDialog" />.</value>
    public Func<IFolderBrowserDialog> OpenFolderBrowserDialogFunc
    {
      get; private set;

    }
    #endregion

    #region private
    private class OpenFileDialogWrapper : FileDialogWrapper
    {
      public OpenFileDialogWrapper()
      {
        m_OpenFileDialog = new OpenFileDialog();
      }
    }
    private class SaveFileDialogWrapper : FileDialogWrapper
    {
      public SaveFileDialogWrapper()
      {
        m_OpenFileDialog = new SaveFileDialog();
      }
    }
    private class FileDialogWrapper : IFileDialog
    {
      #region IFileDialog
      public string FileName
      {
        get
        {
          return m_OpenFileDialog.FileName;
        }
        set
        {
          m_OpenFileDialog.FileName = value;
        }
      }
      public string Filter
      {
        get
        {
          return m_OpenFileDialog.Filter;
        }
        set
        {
          m_OpenFileDialog.Filter = value;
        }
      }
      public string InitialDirectory
      {
        get
        {
          return m_OpenFileDialog.InitialDirectory;
        }
        set
        {
          m_OpenFileDialog.InitialDirectory = value;
        }
      }
      public string Title
      {
        get
        {
          return m_OpenFileDialog.Title;
        }
        set
        {
          m_OpenFileDialog.Title = value;
        }
      }
      public string DefaultExt
      {
        get
        {
          return m_OpenFileDialog.DefaultExt;
        }
        set
        {
          m_OpenFileDialog.DefaultExt = value;
        }
      }
      public void Dispose()
      {
        if (m_OpenFileDialog != null)
          m_OpenFileDialog.Dispose();
      }
      public bool ShowDialog()
      {
        return m_OpenFileDialog.ShowDialog() == DialogResult.OK;
      }
      #endregion
      protected FileDialog m_OpenFileDialog;
    }
    private class FolderBrowserDialogWrapper : IFolderBrowserDialog
    {

      #region IFolderBrowserDialog
      public string SelectedPath
      {
        get
        {
          return m_FolderBrowserDialog.SelectedPath;
        }
        set
        {
          m_FolderBrowserDialog.SelectedPath = value;
        }
      }
      /// <summary>
      /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
      /// </summary>
      public void Dispose()
      {
        m_FolderBrowserDialog.Dispose();
      }
      public bool ShowDialog()
      {
        return m_FolderBrowserDialog.ShowDialog() == DialogResult.OK;
      }
      #endregion

      private FolderBrowserDialog m_FolderBrowserDialog = new FolderBrowserDialog();

    }
    private static void MessageBoxShowDefault(string text, string caption, MessageBoxIcon icon)
    {
      MessageBox.Show(text, caption, MessageBoxButtons.OK, icon);
    }
    #endregion

  }

}
