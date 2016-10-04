//<summary>
//  Title   : PropertyGrid wrapper to select a server plug-in.
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.CommServer.UA.Common;
using CAS.CommServer.UA.ModelDesigner.Configuration.Properties;
using CAS.Lib.RTLib.Utils;
using CAS.UA.IServerConfiguration;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CAS.CommServer.UA.ModelDesigner.Configuration
{
  /// <summary>
  /// PropertyGrid wrapper to select a server plug-in.
  /// </summary>
  public class ServerSelector
  {
    #region public properties
    /// <summary>
    /// Gets or sets the selected server assembly wrapper.
    /// </summary>
    /// <value>The selected assembly wrapper.</value>
    [
    EditorAttribute(typeof(ServerSelectorEditor), typeof(UITypeEditor)),
    TypeConverterAttribute(typeof(ExpandableObjectConverter)),
    NotifyParentProperty(true),
    DisplayName("Editor Assembly"),
    BrowsableAttribute(true),
    CategoryAttribute("Configuration editor"),
    DescriptionAttribute("It displays a dialog to select a plug-in assembly that provides the configuration editor. This assembly is to be used to configure" +
   "the UA server and all data sources available.")
    ]
    public ServerWrapper SelectedAssembly
    {
      get { return m_Server; }
      set
      {
        if (m_Server == value)
          return;
        m_Server = value;
        RaiseOnConfigurationChanged(true);
        if (m_Server == null)
          return;
        m_Server.OnConfigurationChanged += new EventHandler<UAServerConfigurationEventArgs>(m_Server_OnConfigurationChanged);
      }
    }
    #endregion

    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="ServerSelector"/> class.
    /// </summary>
    public ServerSelector() { LicenseProtection.CheckConstrain(); }
    #endregion

    #region public
    /// <summary>
    /// Configuration plug-in descriptor containing configuration and plug-in codebase file path. 
    /// </summary>
    public class ServerDescriptor
    {
      /// <summary>
      /// Codebase file path
      /// </summary>
      [XmlAttribute()]
      public string codebase;
      /// <summary>
      /// Server configuration file path.
      /// </summary>
      [XmlAttribute()]
      public string configuration;
      /// <summary>
      /// Returns a <see cref="T:System.String"/> that represents the current instance.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.String"/> that represents the current instance.
      /// </returns>
      public override string ToString()
      {
        return codebase + " : " + configuration;
      }
    }
    /// <summary>
    /// Occurs when the configuration has been changed.
    /// </summary>
    public event EventHandler<UAServerConfigurationEventArgs> OnConfigurationChanged;
    /// <summary>
    /// Gets or sets the server configuration - detailed information on localization of the plug-in and configuration file
    /// </summary>
    /// <value>
    /// The information on localization of the server and configuration file..
    /// </value>
    /// <remarks>Is to be used by <see cref="XmlSerializer"/> XmlSerializer</remarks>
    [Browsable(false)]
    public ServerDescriptor ServerConfiguration
    {
      get
      {
        ServerDescriptor ret = null;
        if (this.SelectedAssembly == null)
          return ret;
        ret = new ServerDescriptor() { configuration = null };
        ret.codebase = SelectedAssembly.PluginDescription.CodeBase;
        if (SelectedAssembly.Configuration == null || SelectedAssembly.Configuration.ConfigurationFile == null)
          return ret;
        ret.configuration = SelectedAssembly.Configuration.ConfigurationFile.FullName;
        return ret;
      }
      set
      {
        if (value == null)
          return;
        FileInfo info = null;
        //ModelDesigner is trying to open plugin DLL from Solution directory or application binaries directory or current directory
        if (!String.IsNullOrEmpty(value.codebase))
          if (!RelativeFilePathsCalculator.TestIfPathIsAbsolute(value.codebase))
          {
            string _baseDirectory = BaseDirectoryHelper.Instance.GetBaseDirectory();
            info = new FileInfo(Path.Combine(_baseDirectory, value.codebase));
            if (!info.Exists && !string.IsNullOrEmpty(Assembly.GetExecutingAssembly().Location))
            {
              _baseDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
              info = new FileInfo(Path.Combine(_baseDirectory, value.codebase));
            }
            if (!info.Exists)
              info = null;
          }
          else
          {
            info = new FileInfo(value.codebase);
          }
        if (info == null)
          info = new FileInfo(value.codebase);
        if (!info.Exists)
        {
          TraceEvent.Tracer.TraceWarning(155, "ServerSelector", string.Format(Resources.CASConfiguration_MessageBox_plugin_file_exception, value.codebase));
          return;
        }
        Assembly assembly;
        IConfiguration svrInterface;
        try
        {
          GetIServerConfiguration(info, out assembly, out svrInterface);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, Resources.OpenPluginTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
          TraceEvent.Tracer.TraceWarning(167, "ServerSelector", string.Format("{0} {1}", Resources.OpenPluginTitle, ex.Message));
          return;
        }
        if (assembly == null || svrInterface == null)
        {
          MessageBox.Show(Resources.AssemblyLoadErropr, Resources.OpenPluginTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
          TraceEvent.Tracer.TraceWarning(173, "ServerSelector", string.Format("{0} {1}", Resources.OpenPluginTitle, Resources.AssemblyLoadErropr));
          return;
        }
        ServerWrapper newSelectedAssembly = new ServerWrapper(svrInterface, assembly, value.configuration);
        //It must be last statement because ir raises an event using all properties. 
        SelectedAssembly = newSelectedAssembly;
      }
    }
    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </returns>
    public override string ToString()
    {
      return SelectedAssembly == null ? " Not selected; Expand this row and select the plug-in" : SelectedAssembly.ToPlaginDescription();
    }
    /// <summary>
    /// Gets the instance configuration.
    /// </summary>
    /// <returns></returns>
    public IInstanceConfiguration GetInstanceConfiguration(INodeDescriptor nodeUniqueIdentifier)
    {
      return SelectedAssembly == null ? null : SelectedAssembly.GetInstanceConfiguration(nodeUniqueIdentifier);
    }
    /// <summary>
    /// Gets the server configuration.
    /// </summary>
    /// <returns>An instance providing implementation of the <see cref="IConfiguration"/></returns>
    public IConfiguration GetIServerConfiguration()
    {
      return SelectedAssembly == null ? null : SelectedAssembly.GetServerConfiguration();
    }
    /// <summary>
    /// Gets the plugin menu items.
    /// </summary>
    /// <param name="menu">The menu.</param>
    public void GetPluginMenuItems(ToolStripItemCollection menu)
    {
      if (menu.Count > 0)
        menu.Add(new ToolStripSeparator());
      ToolStripMenuItem open = new ToolStripMenuItem()
      {
        Text = Resources.MenuUAServerSelectText,
        ToolTipText = LicenseProtection.IsLicensed ? Resources.MenuUAServerSelectToolTip : Resources.LicenseFeatureUnavailable,
        Enabled = LicenseProtection.IsLicensed
      };
      menu.Add(open);
      open.Click += new EventHandler(PluginMenuItemsOpen_Click);
      ToolStripMenuItem clear = new ToolStripMenuItem()
      {
        Text = Resources.MenuUAServerRemovetText,
        ToolTipText = Resources.MenuUAServerRemovetToolTip,
        Enabled = this.SelectedAssembly != null
      };
      menu.Add(clear);
      clear.Click += new EventHandler(PluginMenuItemsClear_Click);
      if (SelectedAssembly != null)
        SelectedAssembly.GetPluginMenuItems(menu);
    }
    /// <summary>
    /// Saves the configuration and use the specified solution path to create relative paths if needed..
    /// </summary>
    /// <param name="solutionPath">The solution path.</param>
    public void Save(string solutionPath)
    {
      if (SelectedAssembly == null)
        return;
      SelectedAssembly.Save(solutionPath);
    }
    /// <summary>
    /// Sets the home directory to create relative paths of other files.
    /// </summary>
    /// <param name="newHomeDirectory">The new home directory.</param>
    public void SetHomeDirectory(string newHomeDirectory)
    {
      if (SelectedAssembly == null)
        return;
      SelectedAssembly.SetHomeDirectory(newHomeDirectory);
    }
    #endregion

    #region private
    private void OnChangeHandler(object s, EventArgs arg)
    {
      RaiseOnConfigurationChanged(false);
    }
    [LicenseProvider(typeof(CAS.Lib.CodeProtect.CodeProtectLP))]
    [System.Runtime.InteropServices.GuidAttribute("9F0B0964-93B8-4775-9106-95C0DCBFEAD5")]
    private sealed class LicenseProtection : CAS.Lib.CodeProtect.Controls.SplashScreen.LogedIsLicensed<LicenseProtection>
    {
      #region public
      internal static bool IsLicensed { get; private set; }
      internal static void CheckConstrain()
      {
        if (m_Checked)
          return;
        LicenseProtection sc = new LicenseProtection();
        IsLicensed = sc.Licensed;
        m_Checked = true;
      }
      #endregion

      #region private
      private LicenseProtection()
      {
        IsLicensed = this.Licensed;
      }
      static LicenseProtection()
      {
        CheckConstrain();
      }
      private static bool m_Checked = false;
      #endregion
    }
    private class ServerSelectorEditor : UITypeEditor
    {
      #region UITypeEditor override
      public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
      {
        return UITypeEditorEditStyle.Modal;
      }
      public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
      {
        return OpenPlugInAssembly(value as ServerWrapper);
      }
      #endregion
    }
    private static ServerWrapper OpenPlugInAssembly(ServerWrapper server)
    {
      FileInfo info;
      do
      {
        using (OpenFileDialog ofg = new OpenFileDialog())
        {
          string BaseDirectory = BaseDirectoryHelper.Instance.GetBaseDirectory();
          if (!string.IsNullOrEmpty(BaseDirectory))
            ofg.InitialDirectory = BaseDirectory;
          if (server != null && server.PluginDescription != null)
            ofg.FileName = server.PluginDescription.CodeBase;
          ofg.Title = Properties.Resources.OpenPluginTitle;
          ofg.Filter = Properties.Resources.OpenPluginFilter;
          if (ofg.ShowDialog() != DialogResult.OK)
            return server;
          info = new FileInfo(ofg.FileName);
        }
        try
        {
          if (!info.Exists)
          {
            MessageBox.Show
              (Resources.OpenPluginWarningNotExist, Resources.OpenPluginTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            continue;
          }
          Assembly pluginAssembly;
          IConfiguration _serverConfiguration;
          GetIServerConfiguration(info, out pluginAssembly, out _serverConfiguration);
          if (_serverConfiguration == null)
          {
            MessageBox.Show(Resources.InterfaceNotImplemented, Resources.OpenPluginTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            continue;
          }
          server = new ServerWrapper(_serverConfiguration, pluginAssembly);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, Resources.OpenPluginTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      } while (false);
      return server;
    }
    private static void GetIServerConfiguration(FileInfo info, out Assembly pluginAssembly, out IConfiguration serverConfiguration)
    {
      string iName = typeof(IConfiguration).ToString();
      pluginAssembly = Assembly.LoadFrom(info.FullName);
      serverConfiguration = null;
      foreach (Type pluginType in pluginAssembly.GetExportedTypes())
        //Only look at public types
        if (pluginType.IsPublic && !pluginType.IsAbstract && pluginType.GetInterface(iName) != null)
          try
          {
            serverConfiguration = (IConfiguration)Activator.CreateInstance(pluginType);
          }
          catch (TargetInvocationException _ex)
          {
            throw new ApplicationException(String.Format("The server configuration plug-in {0}/{1} cannot be loaded. Contact the vendor to get current version of this component", pluginType.FullName, info.Name), _ex);
          }
    }
    private ServerWrapper m_Server = null;
    private void RaiseOnConfigurationChanged(bool serverChanged)
    {
      if (OnConfigurationChanged == null)
        return;
      OnConfigurationChanged(this, new UAServerConfigurationEventArgs(serverChanged));
    }
    private void m_Server_OnConfigurationChanged(object sender, UAServerConfigurationEventArgs e)
    {
      RaiseOnConfigurationChanged(e.ConfigurationFileChanged);
    }
    #region event handlers
    private void PluginMenuItemsClear_Click(object sender, EventArgs e)
    {
      this.SelectedAssembly = null;
    }
    private void PluginMenuItemsOpen_Click(object sender, EventArgs e)
    {
      SelectedAssembly = OpenPlugInAssembly(SelectedAssembly);
    }
    #endregion
    #endregion

  }
}
