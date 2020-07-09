//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.Properties;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.IServerConfiguration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;

namespace CAS.CommServer.UA.ModelDesigner.Configuration
{
  /// <summary>
  /// ConfigurationWrapper class is to be used as user interface in the <see cref="PropertyGrid"/>.
  /// </summary>
  public class ConfigurationWrapper
  {
    #region public properties

    /// <summary>
    /// It provides detailed information on the configuration file.
    /// </summary>
    /// <value>The configuration file <see cref="FileInfo"/>.</value>
    [
    DisplayName("Configuration File"),
    CategoryAttribute("File"),
    DescriptionAttribute("It provides detailed information on the configuration file."),
    EditorAttribute(typeof(ConfigurationFileEditor), typeof(UITypeEditor)),
    ReadOnly(true)
    ]
    public FileInfo ConfigurationFile { get; private set; }

    #endregion public properties

    #region creators

    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigurationWrapper" /> class that is to manage the sever configuration file.
    /// </summary>
    /// <param name="file">The file containing the configuration.</param>
    /// <param name="configurationEditor">The server configuration editor main interface.</param>
    /// <param name="userInterface">The user interface that provides basic functionality to implement user interactivity.</param>
    /// <exception cref="System.ArgumentNullException">
    /// The server configuration editor main interface cannot be null
    /// or
    /// userInterface
    /// </exception>
    public ConfigurationWrapper(FileInfo file, IConfiguration configurationEditor, IGraphicalUserInterface userInterface)
    {
      m_ServerConfiguration = configurationEditor ?? throw new ArgumentNullException("The server configuration editor main interface cannot be null");
      m_userInterface = userInterface ?? throw new ArgumentNullException($"The {nameof(userInterface)} cannot be null");
      if (file != null)
        ConfigurationFile = file;
      else
        ConfigurationFile = FindConfigurationFile();
      if (ConfigurationFile != null)
      {
        file = ConfigurationFile;
        Read(file);
      }
      else
      {
        m_userInterface.MessageBoxShowExclamation(Resources.ConfigurationWrapper_NoConfigurationFileSelectedInfo, Resources.ConfigurationWrapper_NoConfigurationFileSelectedHeader);
        string selectedPath = String.Empty;
        using (IFolderBrowserDialog _fbd = m_userInterface.OpenFolderBrowserDialogFunc())
        {
          if (_fbd.ShowDialog())
            selectedPath = _fbd.SelectedPath;
        }
        if (string.IsNullOrEmpty(selectedPath))
        {
          m_userInterface.MessageBoxShowExclamation(Resources.ConfigurationWrapperNoFolderSelectedInfo, Resources.ConfigurationWrapperNoFolderSelectedHeader);
          selectedPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
        configurationEditor.CreateDefaultConfiguration();
        try
        {
          file = new FileInfo(Path.Combine(selectedPath, configurationEditor.DefaultFileName));
        }
        catch (Exception exception)
        {
          m_userInterface.MessageBoxShowError(Resources.ConfigurationWrapperProblemWithOpeningOfTheFileInfo + exception.Message, Resources.ConfigurationWrapperProblemWithOpeningOfTheFileHeader);
        }
        configurationEditor.SaveConfiguration(String.Empty, file);
        Read(file);
      }
    }

    #endregion creators

    #region public

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that describes role of this object as a configuration file editor.
    /// </returns>
    public override string ToString()
    {
      return "(Configuration file selection)";
    }

    /// <summary>
    /// Gets the instance configuration.
    /// </summary>
    /// <param name="nodeUniqueIdentifier">The node unique identifier.</param>
    /// <returns>
    /// An object providing access to the instance node configuration editor.
    /// </returns>
    internal IInstanceConfiguration GetInstanceConfiguration(INodeDescriptor nodeUniqueIdentifier)
    {
      return m_ServerConfiguration.GetInstanceConfiguration(nodeUniqueIdentifier);
    }

    /// <summary>
    /// Saves the configuration and use the specified solution path to create relative paths if needed.
    /// </summary>
    /// <param name="solutionPath">The solution path.</param>
    internal void Save(string solutionPath)
    {
      m_SolutionPath = solutionPath;
      Save(false);
    }

    internal void Read()
    {
      FileInfo newFile = FindConfigurationFile();
      if (newFile == null)
        return;
      Read(newFile);
    }

    internal void SetHomeDirectory(string newHomeDirectory)
    {
      m_SolutionPath = newHomeDirectory;
    }

    /// <summary>
    /// Adds a set of the <see cref="ToolStripMenuItem"/> to the plugin menu items.
    /// </summary>
    /// <param name="menu">The menu to be expanded.</param>
    internal void GetPluginMenuItems(ICollection<ToolStripItem> menu)
    {
      ToolStripMenuItem configuration = new ToolStripMenuItem()
      {
        Text = Resources.MenuConfigurationText,
        ToolTipText = Resources.MenuConfigurationToolTip
      };
      menu.Add(configuration);
      ToolStripMenuItem create = new ToolStripMenuItem()
      {
        Text = Resources.MenuNewText,
        ToolTipText = Resources.MenuNewToolTip, 
      };
      create.Click += new EventHandler(create_Click);
      configuration.DropDownItems.Add(create);
      ToolStripMenuItem open = new ToolStripMenuItem()
      {
        Text = Resources.MenuOpenText,
        ToolTipText = Resources.MenuOpenToolTip,
      };
      open.Click += new EventHandler(open_Click);
      configuration.DropDownItems.Add(open);
      ToolStripMenuItem save = new ToolStripMenuItem()
      {
        Text = Resources.MenuSaveText,
        ToolTipText = Resources.MenuSaveToolTip,
        Enabled = this.ConfigurationFile != null
      };
      save.Click += new EventHandler(save_Click);
      configuration.DropDownItems.Add(save);
      ToolStripMenuItem saveAs = new ToolStripMenuItem()
      {
        Text = Resources.MenuSaveAsText,
        ToolTipText = Resources.MenuSaveAsToolTip,
      };
      saveAs.Click += new EventHandler(saveAs_Click);
      configuration.DropDownItems.Add(saveAs);
      ToolStripMenuItem edit = new ToolStripMenuItem()
      {
        Text = Resources.MenuEditText,
        ToolTipText = Resources.MenuOpenToolTip,
        Enabled = this.ConfigurationFile != null
      };
      edit.Click += new EventHandler(edit_Click);
      configuration.DropDownItems.Add(edit);
    }

    #endregion public

    #region private

    private IConfiguration m_ServerConfiguration { set; get; }

    private class ConfigurationFileEditor : UITypeEditor
    {
      #region UITypeEditor override

      /// <summary>
      /// Edits the specified object's value using the editor style indicated by the <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle"/> method.
      /// </summary>
      /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
      /// <param name="provider">An <see cref="T:System.IServiceProvider"/> that this editor can use to obtain services.</param>
      /// <param name="value">The object to edit.</param>
      /// <returns>
      /// The new value of the object. If the value of the object has not changed, this should return the same object it was passed.
      /// </returns>
      public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
      {
        ConfigurationWrapper ptr = context.Instance as ConfigurationWrapper;
        if (ptr == null)
          return value;
        ptr.m_ServerConfiguration.EditConfiguration();
        return value;
      }

      /// <summary>
      /// Gets the editor style used by the <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)"/> method.
      /// </summary>
      /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that can be used to gain additional context information.</param>
      /// <returns>
      /// A <see cref="T:System.Drawing.Design.UITypeEditorEditStyle"/> value that indicates the style of editor used by the <see cref="M:System.Drawing.Design.UITypeEditor.EditValue(System.IServiceProvider,System.Object)"/> method. If the <see cref="T:System.Drawing.Design.UITypeEditor"/> does not support this method, then <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle"/> will return <see cref="F:System.Drawing.Design.UITypeEditorEditStyle.None"/>.
      /// </returns>
      public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
      {
        return UITypeEditorEditStyle.Modal;
      }

      #endregion UITypeEditor override
    }

    private string m_SolutionPath;
    private IGraphicalUserInterface m_userInterface;

    private void Read(FileInfo newFile)
    {
      try
      {
        //TODO UANetworkingConfiguration[T].ReadConfiguration shows popup if file has errors #73
        m_ServerConfiguration.ReadConfiguration(newFile);
        ConfigurationFile = newFile;
      }
      catch (Exception ex)
      {
        MessageBox.Show
          (
          String.Format(Resources.CASConfiguration_MessageBox_configuration_file_exception, ex.Message),
          Resources.UAServerConfigurationTitle,
          MessageBoxButtons.OK,
          MessageBoxIcon.Warning
          );
        ConfigurationFile = null;
        m_ServerConfiguration.CreateDefaultConfiguration();
      }
    }

    private void Save(bool prompt)
    {
      if (ConfigurationFile == null || prompt)
      {
        FileInfo newFile = OpenSaveFileDialog();
        if (newFile == null)
          return;
        ConfigurationFile = newFile;
      }
      try
      {
        m_ServerConfiguration.SaveConfiguration(m_SolutionPath, ConfigurationFile);
      }
      catch (Exception ex)
      {
        MessageBox.Show
          (
            String.Format(Resources.CASConfiguration_MessageBox_configuration_file_save_exception, ex.Message),
            Resources.UAServerConfigurationTitle,
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
          );
      }
    }

    private void SetFileDialogDefaults(UserInterface.IFileDialog ofg)
    {
      try
      {
        ofg.DefaultExt = Path.GetExtension(Path.GetExtension(m_ServerConfiguration.DefaultFileName));
        ofg.Filter = String.Format(Settings.Default.UAServerConfigurationFiltr, ofg.DefaultExt);
        ofg.FileName = Path.GetFileNameWithoutExtension(m_ServerConfiguration.DefaultFileName);
      }
      catch (Exception ex)
      {
        m_userInterface.MessageBoxShowError(ex.Message, Resources.UAServerConfigurationTitle);
        ofg.Filter = String.Format(Settings.Default.UAServerConfigurationFiltr, Resources.Main_Default_ConfigurationFileNametExtension);
        ofg.FileName = Resources.Main_Default_ConfigurationFileName;
        ofg.DefaultExt = Resources.Main_Default_ConfigurationFileNametExtension;
      }
      ofg.Title = Resources.UAServerConfigurationTitle;
    }

    private FileInfo FindConfigurationFile()
    {
      FileInfo newFile = null;
      using (IFileDialog _ofg = m_userInterface.OpenFileDialogFunc())
      {
        SetFileDialogDefaults(_ofg);
        //TODO add icon
        if (_ofg.ShowDialog() && !String.IsNullOrEmpty(_ofg.FileName))
          newFile = new FileInfo(_ofg.FileName);
      }
      if (newFile != null && newFile.Exists)
        return newFile;
      return null;
    }

    private FileInfo OpenSaveFileDialog()
    {
      using (IFileDialog sfd = m_userInterface.SaveFileDialogFuc())
      {
        SetFileDialogDefaults(sfd);
        string _currentFileName = sfd.FileName;
        do
        {
          sfd.FileName = _currentFileName;
          if (sfd.ShowDialog())
            //TODO Display warning
            return null;
        } while (String.IsNullOrEmpty(sfd.FileName));
        return new FileInfo(sfd.FileName);
      }
    }

    #region menu event handlers

    private void open_Click(object sender, EventArgs e)
    {
      Read();
    }

    private void create_Click(object sender, EventArgs e)
    {
      m_ServerConfiguration.CreateDefaultConfiguration();
      ConfigurationFile = null;
      Save(true);
    }

    private void edit_Click(object sender, EventArgs e)
    {
      m_ServerConfiguration.EditConfiguration();
    }

    private void save_Click(object sender, EventArgs e)
    {
      Save(false);
    }

    private void saveAs_Click(object sender, EventArgs e)
    {
      Save(true);
    }

    #endregion menu event handlers

    #endregion private
  }
}