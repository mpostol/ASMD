//<summary>
//  Title   : Server Wrapper to be used by a <see cref="PropertyGrid"/>
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

using CAS.CommServer.UA.Common;
using CAS.Lib.RTLib.Utils;
using CAS.UA.IServerConfiguration;
using System;
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
    /// <value>A <see cref="String"/> that is the simple name of the assembly.
    /// </value>
    #region Attributes
    [
     DisplayName("Plug-in description"),
     CategoryAttribute("Configuration plug-in"),
     DescriptionAttribute("Information identifying the plug-in component."),
     TypeConverterAttribute(typeof(ExpandableObjectConverter)),
     NotifyParentProperty(true)
    ]
    #endregion
    public IDataProviderDescription PluginDescription { get { return m_PluginDescription; } }
    /// <summary>
    /// Gets or sets the configuration.
    /// </summary>
    /// <value>The configuration.</value>
    [
    DisplayName("Configuration"),
    Category("Configuration editor"),
    DescriptionAttribute("It displays a dialog to edit the configuration of the UA server and all data sources available" +
      "to be used by this UA server."),
    EditorAttribute(typeof(ConfigurationWrapperEditor), typeof(UITypeEditor)),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    NotifyParentProperty(true),
    BrowsableAttribute(true)
    ]
    public ConfigurationWrapper Configuration { get; private set; }
    #endregion

    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="ServerWrapper"/> class.
    /// </summary>
    /// <param name="plugin">The interface to get access to the plugin.</param>
    /// <param name="assembly">An assembly containing the plug-in.</param>
    public ServerWrapper(IConfiguration plugin, Assembly assembly)
    {
      Initialize(plugin, assembly);
      Configuration = new ConfigurationWrapper(m_Server);
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="ServerWrapper"/> class.
    /// </summary>
    /// <param name="plugin">he interface to get access to the plugin.</param>
    /// <param name="assembly">TAn assembly containing the plug-in.</param>
    /// <param name="configuration">The file path containing the configuration.</param>
    public ServerWrapper(IConfiguration plugin, Assembly assembly, string configuration)
    {
      Initialize(plugin, assembly);
      FileInfo file = null;
      if (!String.IsNullOrEmpty(configuration))
        if (!RelativeFilePathsCalculator.TestIfPathIsAbsolute(configuration))
        {
          string _dir = BaseDirectoryHelper.Instance.GetBaseDirectory();
          file = new FileInfo(Path.Combine(_dir, configuration));
        }
        else
          file = new FileInfo(configuration);
      if (file == null)
        Configuration = new ConfigurationWrapper(m_Server);
      else
        Configuration = new ConfigurationWrapper(file, m_Server);
    }
    #endregion

    #region object override
    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </returns>
    public override string ToString()
    {
      return m_PluginDescription.ToString();
    }
    #endregion

    #region public
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
    /// Occurs when the configuration has been changed.
    /// </summary>
    internal event EventHandler<UAServerConfigurationEventArgs> OnConfigurationChanged;
    /// <summary>
    /// Provides the plagin description.
    /// </summary>
    /// <returns><see cref="string "/> containing the plug-in description.</returns>
    internal string ToPlaginDescription()
    {
      return PluginDescription.Company + ": " + PluginDescription.Title;
    }
    internal void GetPluginMenuItems(ToolStripItemCollection menu)
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
    #endregion

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
    private IDataProviderDescription m_PluginDescription;
    private IConfiguration m_Server;
    private void Initialize(IConfiguration plugin, Assembly assembly)
    {
      m_Server = plugin;
      m_Server.OnModified += new EventHandler<UAServerConfigurationEventArgs>(OnConfigurationDataChangeHandler);
      m_PluginDescription = new DataProviderDescription(assembly);
    }
    private void RaiseOnConfigurationChanged(bool serverChanged)
    {
      if (OnConfigurationChanged == null)
        return;
      OnConfigurationChanged(this, new UAServerConfigurationEventArgs(serverChanged));
    }
    /// <summary>
    /// Called when configuration data has benn changed.
    /// </summary>
    /// <param name="s">The source.</param>
    /// <param name="arg">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void OnConfigurationDataChangeHandler(object s, UAServerConfigurationEventArgs arg)
    {
      RaiseOnConfigurationChanged(arg.ConfigurationFileChanged);
    }
    #endregion

  }
}
