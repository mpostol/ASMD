//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
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
    where Type4Serialization : class, UAOOI.Common.Infrastructure.Serializers.INamespaces, new()
  {
    #region constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="TypeGenericConfigurationManagement{Type4Serialization}" /> class.
    /// </summary>
    /// <param name="gui">The graphical user interface.</param>
    /// <param name="fileName">Absolute path of the file.</param>
    protected TypeGenericConfigurationManagement(string fileName, bool changesArePresent, IGraphicalUserInterface gui) : base(fileName, changesArePresent, gui)
    {
    }

    #endregion constructors

    #region private

    protected class StringEventArgs : EventArgs
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

    protected event EventHandler<StringEventArgs> BeforeWrite;

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
    protected void Save(Type4Serialization modelDesign)
    {
      try
      {
        string stylesheetName = PrepareDataToSerialize();
        GraphicalUserInterface.UseWaitCursor = true;
        BeforeWrite?.Invoke(this, new StringEventArgs(DefaultFileName));
        UAOOI.Common.Infrastructure.Serializers.XmlFile.WriteXmlFile<Type4Serialization>(modelDesign, DefaultFileName, FileMode.Create, stylesheetName);
        ChangesArePresent = false;
      }
      catch (Exception ex)
      {
        GraphicalUserInterface.MessageBoxShowExclamation(ex.Message, Properties.Resources.SolutionFileSaveError);
      }
      finally
      {
        GraphicalUserInterface.UseWaitCursor = false;
      }
    }
    //TODO Use Common XML serializer to manage xml documents #228
    protected abstract string PrepareDataToSerialize();

    /// <summary>
    /// Reads the configuration.
    /// </summary>
    /// <param name="fileName">The fully qualified name of the file, or the relative file name.</param>
    /// <exception cref="FileNotFoundException">The exception that is thrown when an attempt to access a file that does not exist on disk fails.</exception>
    /// <exception cref="InvalidOperationException">An error occurred during deserialization. The original exception is available using the System.Exception.InnerException property.</exception>
    internal static Type4Serialization ReadConfiguration(string fileName, IGraphicalUserInterface gui)
    {
      if (!File.Exists(fileName))
        throw new FileNotFoundException(fileName);
      try
      {
        gui.UseWaitCursor = true;
        Type4Serialization _graph = XmlFile.ReadXmlFile<Type4Serialization>(fileName);
        return _graph;
      }
      catch (InvalidOperationException _ioe)
      {
        gui.MessageBoxShowExclamation(string.Format(Resources.TypeGenericConfigurationManagement_ReadError, _ioe.GetMessageFromException()), Resources.SolutionFileOpenError);
        return null;
      }
      catch (Exception _ex)
      {
        gui.MessageBoxShowExclamation(string.Format(Resources.TypeGenericConfigurationManagement_ReadError, _ex.GetMessageFromException()), Resources.SolutionFileOpenError);
        return null;
      }
      finally
      {
        gui.UseWaitCursor = false;
      }
    }

    /// <summary>
    /// Open dialog box to select the file to deserialize as the instance of <typeparamref name="Type4Serialization"/>.
    /// </summary>
    /// <returns>The configuration <typeparamref name="Type4Serialization"/> retrieved from a file and the rooted absolute file path or <c>null</c> if the file selection is skipped. </returns>
    internal static Tuple<Type4Serialization, string> ReadConfiguration(IGraphicalUserInterface gui, Action<IFileDialog> setupFileDialog)
    {
      string fileName = ShowDialogOpenFileDialog(gui, setupFileDialog);
      if (String.IsNullOrEmpty(fileName))
        return null;
      Type4Serialization _graph = ReadConfiguration(fileName, gui);
      return new Tuple<Type4Serialization, string>(_graph, fileName);
    }

    #endregion private
  }
}