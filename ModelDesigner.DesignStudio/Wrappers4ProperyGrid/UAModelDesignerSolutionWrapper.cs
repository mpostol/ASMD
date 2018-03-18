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

using CAS.CommServer.UA.Common;
using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.UA.Model.Designer.Wrappers;
using System.ComponentModel;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{

  /// <summary>
  /// Instance of this class is to be used as a wrapper by the <see cref="PropertyGrid"/> to expose to the user and  
  /// by the <see cref="XmlSerializer"/> to save information on the solution.
  /// </summary>
  [DefaultProperty("Server")]
  internal class UAModelDesignerSolutionWrapper : NameWithEventBase<SolutionTreeNode>, IBaseDirectoryProvider, IViewModel
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
    public string HomeDirectory { get { return ModelEntity.HomeDirectory; } }
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
    public ServerSelector Server
    {
      get { return ModelEntity.Server; }
    }
    #endregion

    #region constructor
    internal UAModelDesignerSolutionWrapper(SolutionTreeNode node) : base(node) { }
    #endregion

    #region IBaseDirectoryProvider
    public string GetBaseDirectory()
    {
      return this.HomeDirectory;
    }
    #endregion    

  }

}
