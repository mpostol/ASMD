//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.Common;
using CAS.CommServer.UA.ModelDesigner.Configuration.Properties;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.Lib.CodeProtect;
using CAS.Lib.RTLib.Utils;
using CAS.UA.IServerConfiguration;
using CAS.Windows.Forms.CodeProtectControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CAS.CommServer.UA.ModelDesigner.Configuration
{
  /// <summary>
  /// PropertyGrid wrapper to select a server plug-in.
  /// </summary>
  public class ServerSelector
  {

    #region browsable properties
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
    public ServerSelector(IGraphicalUserInterface _graphicalUserInterface, string solutionPath, string codebase, string configuration)
    {
      GraphicalUserInterface = _graphicalUserInterface ?? throw new ArgumentNullException(nameof(_graphicalUserInterface));
      this.ServerConfiguration = new ServerDescriptor() { Codebase = codebase, Configuration = configuration };
      LicenseProtection.CheckConstrain();
    }
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
      public string Codebase;
      /// <summary>
      /// Server configuration file path.
      /// </summary>
      public string Configuration;
      /// <summary>
      /// Returns a <see cref="T:System.String"/> that represents the current instance.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.String"/> that represents the current instance.
      /// </returns>
      public override string ToString()
      {
        return Codebase + " : " + Configuration;
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
    [Browsable(false)]
    public ServerDescriptor ServerConfiguration
    {
      get
      {
        ServerDescriptor ret = null;
        if (this.SelectedAssembly == null)
          return ret;
        ret = new ServerDescriptor() { Configuration = null };
        ret.Codebase = SelectedAssembly.PluginDescription.CodeBase;
        if (SelectedAssembly.Configuration == null || SelectedAssembly.Configuration.ConfigurationFile == null)
          return ret;
        ret.Configuration = SelectedAssembly.Configuration.ConfigurationFile.FullName;
        return ret;
      }
      set
      {
        //TODO Problem with opening the server configuration editor plug-in #63
        if (value == null || String.IsNullOrEmpty(value.Codebase))
          return;
        FileInfo _info = null;
        //ModelDesigner is trying to open plugin DLL from Solution directory or application binaries directory or current directory
        if (!RelativeFilePathsCalculator.TestIfPathIsAbsolute(value.Codebase))
        {
          string _baseDirectory = BaseDirectoryHelper.Instance.GetBaseDirectory();
          _info = new FileInfo(Path.Combine(_baseDirectory, value.Codebase));
          if (!_info.Exists && !string.IsNullOrEmpty(Assembly.GetExecutingAssembly().Location))
          {
            _baseDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _info = new FileInfo(Path.Combine(_baseDirectory, value.Codebase));
          }
          if (!_info.Exists)
            _info = null;
        }
        else
        {
          _info = new FileInfo(value.Codebase);
        }
        if (_info == null)
          _info = new FileInfo(value.Codebase);
        if (!_info.Exists)
        {
          string _mss = string.Format(Resources.CASConfiguration_MessageBox_plugin_file_exception, value.Codebase);
          GraphicalUserInterface.MessageBoxShowWarning(_mss, Resources.OpenPluginTitle);
          TraceEvent.Tracer.TraceEvent(TraceEventType.Warning, 155, "ServerSelector", _mss);
          return;
        }
        Assembly _assembly;
        IConfiguration _svrInterface;
        try
        {
          GetIServerConfiguration(_info, out _assembly, out _svrInterface);
        }
        catch (Exception ex)
        {
          GraphicalUserInterface.MessageBoxShowWarning(ex.Message, Resources.OpenPluginTitle);
          TraceEvent.Tracer.TraceEvent(TraceEventType.Warning, 167, "ServerSelector", string.Format("{0} {1}", Resources.OpenPluginTitle, ex.Message));
          return;
        }
        if (_assembly == null || _svrInterface == null)
        {
          GraphicalUserInterface.MessageBoxShowWarning(Resources.AssemblyLoadErropr, Resources.OpenPluginTitle);
          TraceEvent.Tracer.TraceEvent(TraceEventType.Warning, 173, "ServerSelector", string.Format("{0} {1}", Resources.OpenPluginTitle, Resources.AssemblyLoadErropr));
          return;
        }
        ServerWrapper newSelectedAssembly = new ServerWrapper(_svrInterface, _assembly, GraphicalUserInterface, value.Configuration);
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
      return SelectedAssembly == null ? " Not selected; Expand this row and select the plug-in" : SelectedAssembly.ToPluginDescription();
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
    public void GetPluginMenuItems(ICollection<ToolStripItem> menu)
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
    [LicenseProvider(typeof(CodeProtectLP))]
    [GuidAttribute("9F0B0964-93B8-4775-9106-95C0DCBFEAD5")]
    private sealed class LicenseProtection : SplashScreen.LogedIsLicensed<LicenseProtection>
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
      /// <summary>
      /// Edits the specified object's value using the editor style indicated by the <see cref="M:System.Drawing.Design.UITypeEditor.GetEditStyle" /> method.
      /// </summary>
      /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that can be used to gain additional context information.</param>
      /// <param name="provider">An <see cref="T:System.IServiceProvider" /> that this editor can use to obtain services.</param>
      /// <param name="value">The object to edit.</param>
      /// <returns>The new value of the object. If the value of the object has not changed, this should return the same object it was passed.</returns>
      public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
      {
        return OpenPlugInAssembly(value as ServerWrapper, m_GraphicalUserInterface);
      }
      #endregion
      private GraphicalUserInterface m_GraphicalUserInterface = new GraphicalUserInterface();
    }
    private static ServerWrapper OpenPlugInAssembly(ServerWrapper server, IGraphicalUserInterface gui)
    {
      FileInfo info;
      do
      {
        using (IFileDialog _ofg = gui.OpenFileDialogFunc())
        {
          string _baseDirectory = BaseDirectoryHelper.Instance.GetBaseDirectory();
          if (!string.IsNullOrEmpty(_baseDirectory))
            _ofg.InitialDirectory = _baseDirectory;
          if (server != null && server.PluginDescription != null)
            _ofg.FileName = server.PluginDescription.CodeBase;
          _ofg.Title = Properties.Resources.OpenPluginTitle;
          _ofg.Filter = Properties.Resources.OpenPluginFilter;
          if (_ofg.ShowDialog())
            return server;
          info = new FileInfo(_ofg.FileName);
        }
        try
        {
          if (!info.Exists)
          {
            gui.MessageBoxShowWarning(Resources.OpenPluginWarningNotExist, Resources.OpenPluginTitle);
            continue;
          }
          Assembly _pluginAssembly;
          IConfiguration _serverConfiguration;
          GetIServerConfiguration(info, out _pluginAssembly, out _serverConfiguration);
          if (_serverConfiguration == null)
          {
            gui.MessageBoxShowWarning(Resources.InterfaceNotImplemented, Resources.OpenPluginTitle);
            continue;
          }
          server = new ServerWrapper(_serverConfiguration, _pluginAssembly, gui);
        }
        catch (Exception ex)
        {
          gui.MessageBoxShowWarning(ex.Message, Resources.OpenPluginTitle);
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
    private IGraphicalUserInterface GraphicalUserInterface { get; set; }

    #region event handlers
    private void OnChangeHandler(object s, EventArgs arg)
    {
      RaiseOnConfigurationChanged(false);
    }
    private void PluginMenuItemsClear_Click(object sender, EventArgs e)
    {
      this.SelectedAssembly = null;
    }
    private void PluginMenuItemsOpen_Click(object sender, EventArgs e)
    {
      SelectedAssembly = OpenPlugInAssembly(SelectedAssembly, GraphicalUserInterface);
    }
    #endregion

    #endregion

  }

}
