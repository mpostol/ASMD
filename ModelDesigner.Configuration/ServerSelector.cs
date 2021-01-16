﻿//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.Properties;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.Lib.CodeProtect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UAOOI.Configuration.Core;
using UAOOI.Windows.Forms.CodeProtectControls;

namespace CAS.CommServer.UA.ModelDesigner.Configuration
{
  /// <summary>
  /// PropertyGrid wrapper to select a server plug-in.
  /// </summary>
  public class ServerSelector
  {
    #region brows-able properties

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
    DescriptionAttribute("It displays a dialog to select a plug-in assembly that provides the configuration editor. This assembly is to be used to configure the UA server and all data sources available.")
    ]
    public ServerWrapper SelectedAssembly
    {
      get => m_Server;
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

    #endregion brows-able properties

    #region constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="ServerSelector"/> class.
    /// </summary>
    public ServerSelector(IGraphicalUserInterface graphicalUserInterface, ISolutionDirectoryPathManagement solutionPath, string codebase, string configuration)
    {
      GraphicalUserInterface = graphicalUserInterface ?? throw new ArgumentNullException(nameof(graphicalUserInterface));
      SolutionPath = solutionPath ?? throw new ArgumentNullException(nameof(solutionPath));
      OpenPlugIn(solutionPath, codebase, configuration);
      LicenseProtection.CheckConstrain();
    }

    #endregion constructor

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
    /// The information on localization of the server and configuration file.
    /// </value>
    [Browsable(false)]
    public ServerDescriptor ServerConfiguration
    {
      get
      {
        if (this.SelectedAssembly == null)
          return null;
        ServerDescriptor _ret = new ServerDescriptor() { Configuration = string.Empty, Codebase = SelectedAssembly.PluginDescription.CodeBase };
        if (SelectedAssembly.Configuration == null || SelectedAssembly.Configuration.ConfigurationFile == null)
          return _ret;
        _ret.Configuration = SelectedAssembly.Configuration.ConfigurationFile.FullName;
        return _ret;
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
    public IConfiguration IServerConfiguration => SelectedAssembly?.GetServerConfiguration;

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
    public void Save(ISolutionDirectoryPathManagement solutionPath)
    {
      if (SelectedAssembly == null)
        return;
      SelectedAssembly.Save(solutionPath.DefaultDirectory);
    }

    #endregion public

    #region LicenseProvider

    //TODO Remove limitation related to CAS licensing programs #53
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

      #endregion public

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

      #endregion private
    }

    #endregion LicenseProvider

    #region private

    private static class PluginHelper
    {
      internal static Tuple<Assembly, IConfiguration> OpenPlugInAssembly(Action<IFileDialog> setupGUI, IGraphicalUserInterface gui)
      {
        Tuple<Assembly, IConfiguration> _ret = null;
        string _newAssemblyFile;
        do
        {
          using (IFileDialog _ofg = gui.OpenFileDialogFunc())
          {
            setupGUI(_ofg);
            if (!_ofg.ShowDialog())
              return null;
            _newAssemblyFile = _ofg.FileName;
          }
          try
          {
            if (!File.Exists(_newAssemblyFile))
            {
              gui.MessageBoxShowWarning(Resources.OpenPluginWarningNotExist, Resources.OpenPluginTitle);
              continue;
            }
            GetIServerConfiguration(_newAssemblyFile, out Assembly _pluginAssembly, out IConfiguration _serverConfiguration);
            if (_serverConfiguration == null)
            {
              gui.MessageBoxShowWarning(Resources.InterfaceNotImplemented, Resources.OpenPluginTitle);
              continue;
            }
            //_ret = new ServerWrapper(_serverConfiguration, new DataProviderDescription(_pluginAssembly), gui, solutionPath);
            _ret = new Tuple<Assembly, IConfiguration>(_pluginAssembly, _serverConfiguration);
          }
          catch (Exception ex)
          {
            gui.MessageBoxShowWarning(ex.Message, Resources.OpenPluginTitle);
          }
        } while (false);
        return _ret;
      }

      internal static void GetIServerConfiguration(string assemblyFile, out Assembly pluginAssembly, out IConfiguration serverConfiguration)
      {
        string iName = typeof(IConfiguration).ToString();
        pluginAssembly = Assembly.LoadFrom(assemblyFile);
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
              throw new ApplicationException($"The server configuration plug-in {assemblyFile} cannot be loaded. Contact the vendor to get current version of this component", _ex);
            }
      }
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
        ServerWrapper _currentPlugin = value as ServerWrapper;
        if (_currentPlugin == null)
          return null;
        Tuple<Assembly, IConfiguration> _assemblyDesription = PluginHelper.OpenPlugInAssembly(x => SetupGUI(x, _currentPlugin), new GraphicalUserInterface());
        if (_assemblyDesription != null)
          return new ServerWrapper(_assemblyDesription.Item2, new DataProviderDescription(_assemblyDesription.Item1), _currentPlugin);
        else
          return _currentPlugin;
      }

      #endregion UITypeEditor override

      private void SetupGUI(IFileDialog openFileDialog, ServerWrapper currentPlugin)
      {
        openFileDialog.InitialDirectory = Path.GetFullPath(currentPlugin.PluginDescription.FullName);
        openFileDialog.FileName = Path.GetFileName(currentPlugin.PluginDescription.FullName);
        openFileDialog.Title = Properties.Resources.OpenPluginTitle;
        openFileDialog.Filter = Properties.Resources.OpenPluginFilter;
      }
    }

    private ServerWrapper m_Server = null;
    private IGraphicalUserInterface GraphicalUserInterface;
    private ISolutionDirectoryPathManagement SolutionPath { get; }

    //methods
    private void RaiseOnConfigurationChanged(bool serverChanged)
    {
      OnConfigurationChanged?.Invoke(this, new UAServerConfigurationEventArgs(serverChanged));
    }

    /// <summary>
    /// Opens the plug in. It  tries to open the DLL in the <paramref name="solutionPath"/> or from the application binaries or current directories
    /// </summary>
    /// <param name="solutionPath">The solution path.</param>
    /// <param name="codebase">The code-base path.</param>
    /// <param name="configuration">The configuration.</param>
    private void OpenPlugIn(ISolutionDirectoryPathManagement solutionPath, string codebase, string configuration)
    {
      if (string.IsNullOrEmpty(codebase))
        return;
      string _pluginFullName = IO.RelativeFilePathsCalculator.CalculateAbsoluteFileName(solutionPath.DefaultDirectory, codebase);
      if (!File.Exists(_pluginFullName))
      {
        _pluginFullName = codebase;
        if (!File.Exists(_pluginFullName))
        {
          _pluginFullName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), codebase);
          if (!File.Exists(_pluginFullName))
          {
            string _mss = string.Format(Resources.CASConfiguration_MessageBox_plugin_file_exception, codebase);
            GraphicalUserInterface.MessageBoxShowWarning(_mss, Resources.OpenPluginTitle);
            TraceEvent.Tracer.TraceEvent(TraceEventType.Warning, 983071265, nameof(ServerSelector.OpenPlugIn), _mss);
            return;
          }
        }
      }
      Assembly _assembly;
      IConfiguration _svrInterface;
      try
      {
        PluginHelper.GetIServerConfiguration(_pluginFullName, out _assembly, out _svrInterface);
      }
      catch (Exception ex)
      {
        GraphicalUserInterface.MessageBoxShowWarning(ex.Message, Resources.OpenPluginTitle);
        TraceEvent.Tracer.TraceEvent(TraceEventType.Warning, 983071266, "ServerSelector", string.Format("{0} {1}", Resources.OpenPluginTitle, ex.Message));
        return;
      }
      if (_assembly == null || _svrInterface == null)
      {
        GraphicalUserInterface.MessageBoxShowWarning(Resources.AssemblyLoadErropr, Resources.OpenPluginTitle);
        TraceEvent.Tracer.TraceEvent(TraceEventType.Warning, 983071267, "ServerSelector", string.Format("{0} {1}", Resources.OpenPluginTitle, Resources.AssemblyLoadErropr));
        return;
      }
      string _path = IO.RelativeFilePathsCalculator.CalculateAbsoluteFileName(solutionPath.DefaultDirectory, configuration);
      ServerWrapper newSelectedAssembly = new ServerWrapper(_svrInterface, new DataProviderDescription(_assembly), GraphicalUserInterface, _path);
      //It must be the last statement because it raises an event using all properties.
      SelectedAssembly = newSelectedAssembly;
    }

    private void SetupGUI(IFileDialog openFileDialog)
    {
      openFileDialog.InitialDirectory = this.SelectedAssembly == null ? SolutionPath.DefaultDirectory : Path.GetDirectoryName(SelectedAssembly.PluginDescription.CodeBase);
      openFileDialog.FileName = this.SelectedAssembly == null ? String.Empty : Path.GetDirectoryName(SelectedAssembly.PluginDescription.CodeBase);
      openFileDialog.Title = Properties.Resources.OpenPluginTitle;
      openFileDialog.Filter = Properties.Resources.OpenPluginFilter;
    }

    #region event handlers

    private void m_Server_OnConfigurationChanged(object sender, UAServerConfigurationEventArgs e)
    {
      RaiseOnConfigurationChanged(e.ConfigurationFileChanged);
    }

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
      Tuple<Assembly, IConfiguration> _assemblyDesription = PluginHelper.OpenPlugInAssembly(SetupGUI, GraphicalUserInterface);
      if (_assemblyDesription == null)
        return;
      SelectedAssembly = new ServerWrapper(_assemblyDesription.Item2, new DataProviderDescription(_assemblyDesription.Item1), GraphicalUserInterface);
    }

    #endregion event handlers

    #endregion private
  }
}