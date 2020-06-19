//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using System;
using System.IO;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Type independent configuration management
  /// </summary>
  /// <typeparam name="Type4Serialization">The type of the associated node configuration to be serialized.</typeparam>
  /// <seealso cref="ConfigurationManagement" />
  internal abstract class TypeGenericConfigurationManagement<Type4Serialization> : ConfigurationManagement
    where Type4Serialization : class, new()
  {
    #region private

    private static string ReadErrorGenericStringFormat => Resources.TypeGenericConfigurationManagement_ReadError;
    private static string ReadErrorInvalidOperationStringFormat => Resources.TypeGenericConfigurationManagement_ReadError;

    protected event EventHandler<StringEventArgs> BeforeWrite;

    protected virtual void RaiseConfigurationChanged(Type4Serialization model)
    {
      ChangesArePresent = true;
    }

    #endregion private

    #region constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="TypeGenericConfigurationManagement{Type4Serialization}" /> class.
    /// </summary>
    /// <param name="gui">The graphical user interface.</param>
    /// <param name="fileName">Name of the file.</param>
    public TypeGenericConfigurationManagement(string fileName, IGraphicalUserInterface gui) : base(fileName, gui)
    {
    }

    #endregion constructors

    #region public API

    /// <summary>
    /// Saves the specified data <paramref name="dataToSerialize"/>.
    /// </summary>
    /// <param name="dataToSerialize">Data to be serialized.</param>
    /// <exception cref="System.InvalidOperationException">An error occurred during serialization. The original exception is available using the System.Exception.InnerException property.</exception>
    /// <exception cref="System.UnauthorizedAccessException:">Access is denied.</exception>
    /// <exception cref="System.ArgumentException">path is an empty string(""). -or- path contains the name of a system device (com1, com2, and so on)</exception>
    /// <exception cref="System.ArgumentNullException">path is null.</exception>
    /// <exception cref="System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
    /// <exception cref="System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.
    /// For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.
    /// </exception>
    /// <exception cref="System.IO.IOException">path includes an incorrect or invalid syntax for file name, directory name, or volume label syntax.</exception>
    /// <exception cref="System.Security.SecurityException">The caller does not have the required permission.</exception>
    protected void Save(XmlFile.DataToSerialize<Type4Serialization> dataToSerialize)
    {
      BeforeWrite?.Invoke(this, new StringEventArgs(DefaultFileName));
      XmlFile.WriteXmlFile<Type4Serialization>(dataToSerialize.Data, DefaultFileName, FileMode.Create, dataToSerialize.StylesheetName, dataToSerialize.XmlNamespaces);
      ChangesArePresent = false;
    }

    /// <summary>
    /// Save the data in an file. Shows the save file dialog is the file doesn't exist.
    /// </summary>
    /// <param name="prompt">If set to <c>true</c> show prompt to enter a file name.</param>
    /// <returns><c>true</c> if operation accomplished successfully.</returns>
    protected bool Save(bool prompt, XmlFile.DataToSerialize<Type4Serialization> dataToSerialize, Action<IFileDialog> setupFileDialog)
    {
      bool _Empty = !File.Exists(DefaultFileName);
      prompt = _Empty || prompt;
      if (prompt && !ShowDialogSaveFileDialog(setupFileDialog))
        return false;
      bool res = false;
      try
      {
        GraphicalUserInterface.UseWaitCursor = true;
        Save(dataToSerialize);
        res = true;
      }
      catch (Exception ex)
      {
        GraphicalUserInterface.MessageBoxShowExclamation(ex.Message, Properties.Resources.SolutionFileSaveError);
      }
      finally
      {
        GraphicalUserInterface.UseWaitCursor = false;
      }
      return res;
    }

    internal class StringEventArgs : EventArgs
    {
      /// <summary>
      /// Gets or sets the string.
      /// </summary>
      /// <value>The string.</value>
      public string String { get; private set; }

      /// <summary>
      /// Initializes a new instance of the <see cref="ConfigurationEventArg"/> class.
      /// </summary>
      /// <param name="config">The configuration.</param>
      public StringEventArgs(string str)
      {
        this.String = str;
      }
    }

    /// <summary>
    /// Specialized Event Argument <see cref="EventArgs"/>sent as parameter to events
    /// </summary>
    internal class ConfigurationEventArg : EventArgs
    {
      /// <summary>
      /// Gets or sets the configuration.
      /// </summary>
      /// <value>The configuration.</value>
      public Type4Serialization Configuration { get; set; }

      /// <summary>
      /// Initializes a new instance of the <see cref="ConfigurationEventArg"/> class.
      /// </summary>
      /// <param name="config">The configuration.</param>
      public ConfigurationEventArg(Type4Serialization config)
      {
        Configuration = config;
      }
    }

    /// <summary>
    /// Reads the configuration.
    /// </summary>
    /// <param name="fileName">The fully qualified name of the file, or the relative file name.</param>
    /// <exception cref="FileNotFoundException">The exception that is thrown when an attempt to access a file
    /// that does not exist on disk fails.
    /// </exception>
    /// <exception cref="System.InvalidOperationException">An error occurred during deserialization. The original exception is available
    /// using the System.Exception.InnerException property.
    /// </exception>
    internal static Tuple<Type4Serialization, string> ReadConfiguration(string fileName, IGraphicalUserInterface gui)
    {
      FileInfo info = new FileInfo(fileName);
      if (!info.Exists)
        throw new FileNotFoundException(fileName);
      try
      {
        gui.UseWaitCursor = true;
        Type4Serialization _return = XmlFile.ReadXmlFile<Type4Serialization>(fileName);
        return new Tuple<Type4Serialization, string>(_return, fileName);
      }
      catch (InvalidOperationException _ioe)
      {
        gui.MessageBoxShowExclamation(string.Format(ReadErrorInvalidOperationStringFormat, _ioe.GetMessageFromException()), Resources.SolutionFileOpenError);
        return null;
      }
      catch (Exception _ex)
      {
        gui.MessageBoxShowExclamation(string.Format(ReadErrorGenericStringFormat, _ex.GetMessageFromException()), Resources.SolutionFileOpenError);
        return null;
      }
      finally
      {
        gui.UseWaitCursor = false;
      }
    }

    /// <summary>
    /// Open dialog box to select the file and deserialize an instance of <typeparamref name="Type4Serialization"/>.
    /// </summary>
    /// <returns>The configuration retrieved from a file and the rooted absolute file path. </returns>
    internal static Tuple<Type4Serialization, string> ReadConfiguration(IGraphicalUserInterface gui, Action<IFileDialog> setupFileDialog)
    {
      string fileNmae = ShowDialogOpenFileDialog(gui, setupFileDialog);
      if (String.IsNullOrEmpty(fileNmae))
        return null;
      return ReadConfiguration(fileNmae, gui);
    }

    #endregion public API
  }
}