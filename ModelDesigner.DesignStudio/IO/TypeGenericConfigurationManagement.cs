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
    private bool m_Empty = true;
    private void Save(XmlFile.DataToSerialize<Type4Serialization> cd)
    {
      BeforeWrite?.Invoke(this, new StringEventArgs(DefaultFileName));
      XmlFile.WriteXmlFile<Type4Serialization>(cd.Data, DefaultFileName, FileMode.Create, cd.StylesheetName, cd.XmlNamespaces);
      ChangesArePresent = false;
    }
    //protected
    protected virtual void RaiseConfigurationChanged(Type4Serialization model)
    {
      ChangesArePresent = true;
      //ConfigurationChanged?.Invoke(this, new ConfigurationEventArg(m_Model));
    }
    /// <summary>
    /// Gets the configuration.
    /// </summary>
    /// <value>If implemented return the opened configuration as the <see cref="DataToSerialize "/>.</value>
    protected abstract XmlFile.DataToSerialize<Type4Serialization> GetConfiguration(Type4Serialization configuration);
    /// <summary>
    /// Saves the specified <see cref="DataToSerialize"/> instance as the xml document.
    /// </summary>
    /// <param name="cd">The <see cref="DataToSerialize"/>.</param>
    /// <exception cref="System.InvalidOperationException">An error occurred during serialization. The original exception is 
    /// available using the System.Exception.InnerException property. 
    /// </exception>
    /// <exception cref="System.UnauthorizedAccessException:">Access is denied.</exception>
    /// <exception cref="System.ArgumentException">path is an empty string(""). -or- path contains the name of a system device 
    /// (com1, com2, and so on)</exception>
    /// <exception cref="System.ArgumentNullException">path is null.</exception>
    /// <exception cref="System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
    /// <exception cref="System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. 
    /// For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.
    /// </exception>
    /// <exception cref="System.IO.IOException">path includes an incorrect or invalid syntax for file name, directory name, or volume label syntax.</exception>
    /// <exception cref="System.Security.SecurityException">The caller does not have the required permission.</exception>
    protected virtual string ReadErrorGenericStringFormat => Resources.TypeGenericConfigurationManagement_ReadError;
    protected virtual string ReadErrorInvalidOperationStringFormat => Resources.TypeGenericConfigurationManagement_ReadError;
    protected event EventHandler<StringEventArgs> BeforeRead;
    protected event EventHandler<StringEventArgs> BeforeWrite;
    /// <summary>
    /// Initializes a new instance of the <see cref="TypeGenericConfigurationManagement{Type4Serialization}" /> class.
    /// </summary>
    /// <param name="graphicalUserInterface">The graphical user interface.</param>
    /// <param name="fileName">Name of the file.</param>
    //protected EventHandler<ConfigurationEventArg> ConfigurationChanged;
    #endregion private

    #region constructors
    public TypeGenericConfigurationManagement(IGraphicalUserInterface graphicalUserInterface, string fileName) : base(graphicalUserInterface, fileName) { }
    #endregion

    #region ConfigurationManagement
    /// <summary>
    /// Create a new configuration.
    /// </summary>
    public override void New()
    {
      m_Empty = true;
      RaiseConfigurationChanged(null);
      ChangesArePresent = false;
    }
    /// <summary>
    /// Read the configuration from an external dictionary file.
    /// </summary>
    /// <returns></returns>
    public override bool Open()
    {
      return this.Open(string.Empty);
    }
    /// <summary>
    /// Save the address space data set in an external dictionary file. 
    /// </summary>
    /// <param name="prompt">If set to <c>true</c> show prompt to enter a file name.</param>
    /// <returns><c>true</c> if operation accomplished successfully.</returns>
    internal bool Save(bool prompt, Type4Serialization configuration)
    {
      prompt = m_Empty || prompt;
      if (prompt)
        if (!ShowDialogSaveFileDialog())
          return false;
      m_Empty = false;
      bool res = false;
      try
      {
        GraphicalUserInterface.UseWaitCursor = true;
        Save(GetConfiguration(configuration));
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
    #endregion

    #region public
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
    /// Opens the specified file name.
    /// </summary>
    /// <param name="FileName">Name of the file.</param>
    /// <returns></returns>
    internal bool Open(string FileName)
    {
      Type4Serialization m_Model = null;
      if (string.IsNullOrEmpty(FileName))
        m_Model = ReadConfiguration();
      else
      {
        try { m_Model = ReadConfiguration(FileName); }
        catch { m_Model = null; }
      }
      if (m_Model == null)
        return false;
      RaiseConfigurationChanged(m_Model);
      ChangesArePresent = false;
      return true;
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
    internal Type4Serialization ReadConfiguration(string fileName)
    {
      FileInfo info = new FileInfo(fileName);
      if (!info.Exists)
        throw new FileNotFoundException(fileName);
      try
      {
        GraphicalUserInterface.UseWaitCursor = true;
        Type4Serialization _return = XmlFile.ReadXmlFile<Type4Serialization>(fileName);
        DefaultFileName = fileName;
        m_Empty = false;
        return _return;
      }
      catch (InvalidOperationException _ioe)
      {
        GraphicalUserInterface.MessageBoxShowExclamation(string.Format(ReadErrorInvalidOperationStringFormat, _ioe.GetMessageFromException()), Resources.SolutionFileOpenError);
        return null;
      }
      catch (Exception _ex)
      {
        GraphicalUserInterface.MessageBoxShowExclamation(string.Format(ReadErrorGenericStringFormat, _ex.GetMessageFromException()), Resources.SolutionFileOpenError);
        return null;
      }
      finally
      {
        GraphicalUserInterface.UseWaitCursor = false;
      }
    }
    /// <summary>
    /// Open dialog box to select the file and deserialize an instance of <typeparamref name="Type4Serialization"/>.
    /// </summary>
    /// <returns>The configuration retrieved from a file.</returns>
    internal Type4Serialization ReadConfiguration()
    {
      if (!ShowDialogOpenFileDialog())
        return null;
      return ReadConfiguration(DefaultFileName);
    }
    #endregion public

  }

}
