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
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{

  /// <summary>
  /// Instance of this class is to be used as a wrapper by the <see cref="System.Windows.Forms.PropertyGrid"/> to expose to the user and  
  /// by the <see cref="XmlSerializer"/> to save information on the solution.
  /// </summary>
  [XmlType("UAModelDesignerSolution")]
  [DefaultProperty("Server")]
  public class UAModelDesignerSolution : NameWithEventBase
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
    [XmlIgnore()]
    #endregion
    public ServerSelector Server { get; set; }
    #endregion

    #region XMLSerialise properties
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
    [XmlElement(IsNullable = true)]
    public ServerSelector.ServerDescriptor ServerDetails
    {
      set { Server.ServerConfiguration = value; }
      get
      {
        ServerSelector.ServerDescriptor descriptor = Server.ServerConfiguration;
        if (descriptor == null)
          return null;
        if (!String.IsNullOrEmpty(descriptor.codebase))
          descriptor.codebase = RelativeFilePathsCalculator.TryComputeRelativePath(this.m_HomeDirectory, descriptor.codebase);
        if (!String.IsNullOrEmpty(descriptor.configuration))
          descriptor.configuration = RelativeFilePathsCalculator.TryComputeRelativePath(this.m_HomeDirectory, descriptor.configuration);
        return descriptor;
      }
    }
    #endregion properties

    #region initialization
    [Obsolete("This constructor should be only used by XML serializer")]
    internal UAModelDesignerSolution()
    {
      Initialize();
    }
    public UAModelDesignerSolution(string defaultFileName, string defaultSolutionName)
    {
      Initialize();
      this.m_HomeDirectory = Path.GetDirectoryName(Path.GetFullPath(defaultFileName));
      Name = defaultSolutionName;
    }
    #endregion initialisation

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
    internal void Save(string solutionPath)
    {
      this.m_HomeDirectory = solutionPath;
      Server.Save(solutionPath);
    }
    internal void GetPluginMenuItems(System.Windows.Forms.ToolStripItemCollection menu)
    {
      Server.GetPluginMenuItems(menu);
    }
    #endregion Internal

    #region private
    private void Initialize()
    {
      Server = new ServerSelector();
      Server.OnConfigurationChanged += new EventHandler<UAServerConfigurationEventArgs>(Server_OnConfigurationChanged);
    }
    private string m_HomeDirectory;
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
