//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.UA.Model.Designer.Wrappers;
using System.ComponentModel;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  /// <summary>
  /// Instance of this class is to be used as a wrapper to expose to the user
  /// </summary>
  [DefaultProperty("Server")]
  internal class UAModelDesignerSolutionWrapper : NameWithEventBase<ISolutionTreeNodeUI>, IViewModel
  {
    #region User Interface

    /// <summary>
    /// Gets the home directory of the solution.
    /// </summary>
    /// <value>The solution home directory.</value>
    [DisplayName("Home Directory")]
    [Category("Input")]
    [Description("Solution home directory.")]
    public string HomeDirectory => ModelEntity.HomeDirectory.DefaultDirectory;

    /// <summary>
    /// Gets or sets information of the plug-in for a server.
    /// </summary>
    /// <value>The server.</value>
    [DisplayName("Configuration assembly")]
    [Category("Configuration plug-in")]
    [Description("Indicates the configuration plug-in of a UA server. This plug-in is used to configure the bindings of instance nodes in the model with the actual real-time process data sources. Configuration of the bindings can be edited using “Process bindings” property available for all instance nodes. ")]
    [TypeConverterAttribute(typeof(ExpandableObjectConverter))]
    [NotifyParentProperty(true)]
    public ServerSelector Server => ModelEntity.Server;

    #endregion User Interface

    #region constructor

    internal UAModelDesignerSolutionWrapper(ISolutionTreeNodeUI node) : base(node)
    {
    }

    #endregion constructor
  }
}