//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.IServerConfiguration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CAS.CommServer.UA.ModelDesigner.Configuration
{
  /// <summary>
  /// Server Wrapper to be used by a <see cref="PropertyGrid"/>
  /// </summary>
  [DefaultProperty("Configuration")]
  public class ServerWrapper
  {
    #region Public browsable properties

    /// <summary>
    /// Gets the simple name of the assembly form the <see cref="AssemblyName"/>. This is usually, but not necessarily,
    /// the file name of the manifest file of the assembly, minus its extension.
    /// </summary>
    /// <value>A <see cref="string"/> that is the simple name of the assembly.
    /// </value>
    [
     DisplayName("Plug-in description"),
     CategoryAttribute("Configuration plug-in"),
     DescriptionAttribute("Information identifying the plug-in component."),
     TypeConverterAttribute(typeof(ExpandableObjectConverter)),
     NotifyParentProperty(true)
    ]
    public IDataProviderDescription PluginDescription { get; private set; }

    /// <summary>
    /// Gets or sets the configuration.
    /// </summary>
    /// <value>The configuration.</value>
    [
    DisplayName("Configuration"),
    Category("Configuration editor"),
    DescriptionAttribute("It displays a dialog to edit the configuration of the UA server and all data sources available to be used by this UA server."),
    EditorAttribute(typeof(ConfigurationWrapperEditor), typeof(UITypeEditor)),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    NotifyParentProperty(true),
    BrowsableAttribute(true)
    ]
    public ConfigurationWrapper Configuration { get; private set; }

    #endregion Public browsable properties

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ServerWrapper"/> class.
    /// </summary>
    /// <param name="plugin">The interface to get access to the plugin.</param>
    /// <param name="assembly">The assembly containing the plug-in.</param>
    /// <param name="currentPlugin">The current plugin.</param>
    public ServerWrapper(IConfiguration plugin, IDataProviderDescription assembly, ServerWrapper currentPlugin) : this(plugin, assembly, currentPlugin.m_GraphicalUserInterfaceField) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ServerWrapper" /> class.
    /// </summary>
    /// <param name="plugin">The interface to get access to the plugin.</param>
    /// <param name="assembly">An assembly containing the plug-in.</param>
    /// <param name="gui">The user interaction interface that provides basic functionality to implement user interactivity.</param>
    /// <param name="solutionPath">The solution path.</param>
    public ServerWrapper(IConfiguration plugin, IDataProviderDescription assembly, IGraphicalUserInterface gui) : this(plugin, assembly, gui, string.Empty) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ServerWrapper" /> class.
    /// </summary>
    /// <param name="plugin">The interface to get access to the plugin.</param>
    /// <param name="assembly">Thn assembly containing the plug-in.</param>
    /// <param name="gui">The user interaction interface that provides basic functionality to implement user interactivity.</param>
    /// <param name="solutionPath">The solution path.</param>
    /// <param name="configuration">The file path containing the configuration.</param>
    public ServerWrapper(IConfiguration plugin, IDataProviderDescription assembly, IGraphicalUserInterface gui, string configuration)
    {
      m_Server = plugin ?? throw new ArgumentNullException(nameof(plugin));
      PluginDescription = assembly ?? throw new ArgumentNullException(nameof(plugin));
      m_GraphicalUserInterfaceField = gui ?? throw new ArgumentNullException(nameof(plugin));
      m_Server.OnModified += new EventHandler<UAServerConfigurationEventArgs>(OnConfigurationDataChangeHandler);
      FileInfo _file = null;
      if (!string.IsNullOrEmpty(configuration))
      {
        if (!Path.IsPathRooted(configuration))
          throw new ArgumentOutOfRangeException(nameof(configuration));
        _file = new FileInfo(configuration);
      }
      Configuration = new ConfigurationWrapper(_file, m_Server, gui);
    }

    #endregion Constructors

    #region object override

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </returns>
    public override string ToString()
    {
      return PluginDescription.ToString();
    }

    #endregion object override

    #region public

    /// <summary>
    /// Occurs when the configuration has been changed.
    /// </summary>
    internal event EventHandler<UAServerConfigurationEventArgs> OnConfigurationChanged;

    /// <summary>
    /// Gets the server configuration.
    /// </summary>
    /// <returns>The <see cref="IConfiguration"/> providing access to the server configuration file editor.</returns>
    internal IConfiguration GetServerConfiguration()
    {
      return m_Server;
    }

    /// <summary>
    /// Gets the instance configuration providing access to the instance node configuration editor.
    /// </summary>
    /// <param name="nodeUniqueIdentifier">The node unique identifier.</param>
    /// <returns>
    /// The instance of the <see cref="IInstanceConfiguration"/> providing access to the instance node configuration editor.
    /// </returns>
    internal IInstanceConfiguration GetInstanceConfiguration(INodeDescriptor nodeUniqueIdentifier)
    {
      return Configuration.GetInstanceConfiguration(nodeUniqueIdentifier);
    }

    /// <summary>
    /// Provides the plugin description.
    /// </summary>
    /// <returns><see cref="string "/> containing the plug-in description.</returns>
    internal string ToPluginDescription()
    {
      return PluginDescription.Company + ": " + PluginDescription.Title;
    }

    internal void GetPluginMenuItems(ICollection<ToolStripItem> menu)
    {
      Configuration.GetPluginMenuItems(menu);
    }

    /// <summary>
    /// Saves the configuration and use the specified solution path to create relative paths if needed.
    /// </summary>
    /// <param name="solutionPath">The solution path.</param>
    internal void Save(string solutionPath)
    {
      Configuration.Save(solutionPath);
    }

    /// <summary>
    /// Sets the home directory to create relative paths of other files.
    /// </summary>
    /// <param name="newHomeDirectory">The new home directory.</param>
    internal void SetHomeDirectory(string newHomeDirectory)
    {
      Configuration.SetHomeDirectory(newHomeDirectory);
    }

    #endregion public

    #region private

    private class ConfigurationWrapperEditor : UITypeEditor
    {
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
        ((ConfigurationWrapper)value).Read();
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
    }

    private IConfiguration m_Server;
    private readonly IGraphicalUserInterface m_GraphicalUserInterfaceField;

    private void RaiseOnConfigurationChanged(bool serverChanged)
    {
      if (OnConfigurationChanged == null)
        return;
      OnConfigurationChanged(this, new UAServerConfigurationEventArgs(serverChanged));
    }

    /// <summary>
    /// Called when configuration data has been changed.
    /// </summary>
    /// <param name="s">The source.</param>
    /// <param name="arg">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void OnConfigurationDataChangeHandler(object s, UAServerConfigurationEventArgs arg)
    {
      RaiseOnConfigurationChanged(arg.ConfigurationFileChanged);
    }

    #endregion private
  }
}