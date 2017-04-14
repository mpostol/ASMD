//<summary>
//  Title   : Class that represents the UA Model Designer session
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

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.Lib.RTLib.Utils;
using CAS.UA.IServerConfiguration;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{

  /// <summary>
  /// Instance of this class is to be used as a wrapper by the <see cref="PropertyGrid"/> to expose to the user and  
  /// by the <see cref="XmlSerializer"/> to save information on the solution.
  /// </summary>
  [DefaultProperty("Server")]
  public class UAModelDesignerSolutionWrapper : NameWithEventBase
  {
    #region browsable properties
    /// <summary>
    /// Gets the home directory of the solution.
    /// </summary>
    /// <value>The solution home directory.</value>
    #region Attributes
    [DisplayName("Home Directory")]
    [Category("Input")]
    [Description("Solution home directory.")]
    #endregion
    public string HomeDirectory { get { return m_HomeDirectory; } }
    /// <summary>
    /// Gets or sets information of the plug-in for a server.
    /// </summary>
    /// <value>The server.</value>
    #region Attributes
    [DisplayName("Configuration assembly")]
    [Category("Configuration plug-in")]
    [Description("Indicates the configuration plug-in of a UA server. This plug-in is used to configure the bindings of instance nodes in the model with the actual real-time process data sources.  Configuration of the bindings can be edited using “Process bindings” property available for all instance nodes. ")]
    [TypeConverterAttribute(typeof(ExpandableObjectConverter))]
    [NotifyParentProperty(true)]
    #endregion
    public ServerSelector Server { get; set; }
    #endregion

    #region not browsable properties
    /// <summary>
    /// Gets or sets the projects wrappers.
    /// </summary>
    /// <value>The projects.</value>
    [Browsable(false)]
    public ProjectWrapper[] Projects { get; set; }
    /// <summary>
    /// Gets or sets detailed information on localization of the plug-in and configuration file.
    /// </summary>
    /// <value>The server descriptor.</value>
    [Browsable(false)]
    public ServerSelector.ServerDescriptor ServerDetails
    {
      set { Server.ServerConfiguration = value; }
      get
      {
        ServerSelector.ServerDescriptor _descriptor = Server.ServerConfiguration;
        if (_descriptor == null)
          return null;
        if (!String.IsNullOrEmpty(_descriptor.codebase))
          _descriptor.codebase = RelativeFilePathsCalculator.TryComputeRelativePath(this.m_HomeDirectory, _descriptor.codebase); //TODO must refer to the plugin directory.
        if (!String.IsNullOrEmpty(_descriptor.configuration))
          _descriptor.configuration = RelativeFilePathsCalculator.TryComputeRelativePath(this.m_HomeDirectory, _descriptor.configuration);
        return _descriptor;
      }
    }
    #endregion

    #region constructor
    internal UAModelDesignerSolutionWrapper(UAModelDesignerSolution configuration)
    {
      Initialize();
      Name = configuration.Name;
      ServerDetails = configuration.ServerDetails != null ? new ServerSelector.ServerDescriptor() { codebase = configuration.ServerDetails.codebase, configuration = configuration.ServerDetails.configuration } : null;
      Projects = configuration.Projects != null ? configuration.Projects.Select(x => new ProjectWrapper(x)).ToArray<ProjectWrapper>() : null;
    }
    public UAModelDesignerSolutionWrapper(string defaultFileName, string defaultSolutionName)
    {
      Initialize();
      this.m_HomeDirectory = Path.GetDirectoryName(Path.GetFullPath(defaultFileName));
      Name = defaultSolutionName;
    }
    #endregion

    #region Internal
    /// <summary>
    /// Sets the home directory to create relative paths of other files.
    /// </summary>
    /// <param name="newHomeDirectory">The new home directory.</param>
    internal void SetHomeDirectory(string newHomeDirectory)
    {
      this.m_HomeDirectory = newHomeDirectory;
      Server.SetHomeDirectory(newHomeDirectory);
    }
    internal SolutionTreeNode NodeCouple { private get; set; }
    internal UAModelDesignerSolution UAModelDesignerSolutionConfiguration
    {
      get
      {
        return new UAModelDesignerSolution()
        {
          Name = this.Name,
          Projects = this.Projects == null ? null : this.Projects.Select<ProjectWrapper, UAModelDesignerProject>(x => x.UAModelDesignerProjectConfiguration).ToArray<UAModelDesignerProject>(),
          ServerDetails = this.ServerDetails == null ? null : new UAModelDesignerSolutionServerDetails() { codebase = ServerDetails.codebase, configuration = ServerDetails.configuration }
        };
      }
    }
    internal void Save(string solutionPath)
    {
      this.m_HomeDirectory = solutionPath;
      Server.Save(solutionPath);
    }
    internal void GetPluginMenuItems(ToolStripItemCollection menu)
    {
      ICollection<ToolStripItem> _items = new List<ToolStripItem>();
      Server.GetPluginMenuItems(_items);
      menu.AddRange(_items.ToArray<ToolStripItem>());
    }
    #endregion Internal

    #region private
    private string m_HomeDirectory;
    private void Initialize()
    {
      Server = new ServerSelector();
      Server.OnConfigurationChanged += new EventHandler<UAServerConfigurationEventArgs>(Server_OnConfigurationChanged);
    }
    private void Server_OnConfigurationChanged(object sender, UAServerConfigurationEventArgs e)
    {
      if (NodeCouple == null)
        return;
      if (e.ConfigurationFileChanged)
        NodeCouple.RegenerateSubTree();
    }
    #endregion private

  }

}
