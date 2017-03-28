//<summary>
//  Title   : Class to save and restore  data  to/from external file.
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Type independent configuration management
  /// </summary>
  /// <typeparam name="TypeForConfiguration">The type stored in the configuration.</typeparam>
  internal abstract class TypeGenericConfigurationManagement<TypeForConfiguration> : ConfigurationManagement
    where TypeForConfiguration : class
  {
    #region private
    private void RaiseConfigurationChanged(TypeForConfiguration m_Model)
    {
      ChangesArePresent = true;
      ConfigurationChanged?.Invoke(this, new ConfigurationEventArg(m_Model));
    }
    /// <summary>
    /// Gets the configuration.
    /// </summary>
    /// <value>If implemented return the opened configuration of as the <see cref="Configuration "/>.</value>
    protected abstract Configuration GetConfiguration { get; }
    /// <summary>
    /// Saves the specified <see cref="Configuration"/>.
    /// </summary>
    /// <param name="cd">The <see cref="Configuration"/>.</param>
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
    /// <exception cref="System.IO.IOException">path includes an incorrect or invalid syntax for file name, directory name, or volume 
    /// label syntax.</exception>
    /// <exception cref="System.Security.SecurityException">The caller does not have the required permission.</exception>
    private void Save(Configuration cd)
    {
      BeforeWrite?.Invoke(this, new StringEventArgs(DefaultFileName));
      using (StreamWriter writer = new StreamWriter(DefaultFileName))
      {
        XmlSerializer serializer = new XmlSerializer(typeof(TypeForConfiguration));
        serializer.Serialize(writer, cd.Data, cd.XmlNamespaces);
      }
      ChangesArePresent = false;
    }
    protected virtual string ReadErrorGenericStringFormat
    {
      get
      {
        return Resources.TypeGenericConfigurationManagement_ReadError;
      }
    }
    protected virtual string ReadErrorInvalidOperationStringFormat
    {
      get
      {
        return Resources.TypeGenericConfigurationManagement_ReadError;
      }
    }
    protected event EventHandler<StringEventArgs> BeforeRead;
    protected event EventHandler<StringEventArgs> BeforeWrite;
    /// <summary>
    /// Occurs when configuration has been changed.
    /// </summary>
    protected event EventHandler<ConfigurationEventArg> ConfigurationChanged;
    #endregion private

    #region constructors
    public TypeGenericConfigurationManagement()
      : base()
    { }
    public TypeGenericConfigurationManagement(IContainer container)
      : base(container)
    { }
    #endregion

    #region public
    /// <summary>
    /// A structure containing configuration
    /// </summary>
    public struct Configuration
    {
      public XmlSerializerNamespaces XmlNamespaces;
      public TypeForConfiguration Data;
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
      public TypeForConfiguration Configuration { get; set; }
      /// <summary>
      /// Initializes a new instance of the <see cref="ConfigurationEventArg"/> class.
      /// </summary>
      /// <param name="config">The configuration.</param>
      public ConfigurationEventArg(TypeForConfiguration config)
      {
        Configuration = config;
      }
    }
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
    /// Opens the specified file name.
    /// </summary>
    /// <param name="FileName">Name of the file.</param>
    /// <returns></returns>
    public bool Open(string FileName)
    {
      TypeForConfiguration m_Model = null;
      if (string.IsNullOrEmpty(FileName))
        m_Model = ReadConfiguration();
      else
      {
        DefaultDirectory = Path.GetDirectoryName(FileName);
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
    public TypeForConfiguration ReadConfiguration(string fileName)
    {
      FileInfo info = new FileInfo(fileName);
      if (!info.Exists)
        throw new FileNotFoundException(fileName);
      DefaultFileName = fileName;
      TypeForConfiguration _return = XmlFile.ReadXmlFile<TypeForConfiguration>(fileName);
      DefaultFileName = fileName;
      m_Empty = false;
      return _return;
    }
    /// <summary>
    /// Reads the configuration.
    /// </summary>
    /// <returns>The configuration retrieved from a file.</returns>
    public TypeForConfiguration ReadConfiguration()
    {
      if (ShowDialogOpenFileDialog() != DialogResult.OK)
        return null;
      try
      {
        Application.UseWaitCursor = true;
        TypeForConfiguration m_Model = ReadConfiguration(DefaultFileName);
        m_Empty = false;
        return m_Model;
      }
      catch (InvalidOperationException _ioe)
      {
        MessageBox.Show(String.Format(ReadErrorInvalidOperationStringFormat, _ioe.GetMessageFromException()), Resources.SolutionFileOpenError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return null;
      }
      catch (Exception _ex)
      {
        MessageBox.Show(String.Format(ReadErrorGenericStringFormat, _ex.GetMessageFromException()), Resources.SolutionFileOpenError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return null;
      }
      finally
      {
        Application.UseWaitCursor = false;
      }
    }
    /// <summary>
    /// Save the address space data set in an external dictionary file. 
    /// </summary>
    /// <param name="prompt">If set to <c>true</c> show prompt to enter a file name.</param>
    /// <returns><c>true</c> if operation accomplished successfully.</returns>
    public override bool Save(bool prompt)
    {
      prompt = m_Empty || prompt;
      if (prompt)
        if (ShowDialogSaveFileDialog() != DialogResult.OK)
          return false;
      m_Empty = false;
      bool res = false;
      try
      {
        Application.UseWaitCursor = true;
        Save(GetConfiguration);
        res = true;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, Properties.Resources.SolutionFileSaveError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      finally
      {
        Application.UseWaitCursor = false;
      }
      return res;
    }
    /// <summary>
    /// Save configuration in an external dictionary file. 
    /// </summary>
    /// <param name="prompt">If set to <c>true</c> show prompt to enter a file name.</param>
    /// <returns><c>true</c> if operation accomplished successfully.</returns>
    public bool Save(bool prompt, Configuration configuration)
    {
      prompt = m_Empty || prompt;
      if (prompt)
        if (ShowDialogSaveFileDialog() != DialogResult.OK)
          return false;
      m_Empty = false;
      bool res = false;
      try
      {
        Application.UseWaitCursor = true;
        Save(configuration);
        res = true;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, Properties.Resources.SolutionFileSaveError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      finally
      {
        Application.UseWaitCursor = false;
      }
      return res;
    }
    #endregion public

  }
}
