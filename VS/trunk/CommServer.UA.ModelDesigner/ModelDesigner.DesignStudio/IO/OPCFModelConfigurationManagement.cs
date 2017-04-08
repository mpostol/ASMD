//<summary>
//  Title   : Class to save and restore  opc AS UA model  to/from external file.
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

using CAS.UA.Model.Designer.Properties;
using System.ComponentModel;
using OPCFModelDesign = Opc.Ua.ModelCompiler.ModelDesign;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Class to save and restore UA Information Model to/from external file.
  /// </summary>
  internal class OPCFModelConfigurationManagement: TypeGenericConfigurationManagement<OPCFModelDesign, OPCFModelDesign>
  {
    #region private
    /// <summary>
    /// Gets the configuration.
    /// </summary>
    /// <value>The configuration .</value>
    /// <remarks>Not implemented in this class</remarks>
    protected override TypeGenericConfigurationManagement<OPCFModelDesign, OPCFModelDesign>.DataToSerialize GetConfiguration
    {
      get { throw new System.NotImplementedException(); }
    }
    /// <summary>
    /// Creates a configurable tree node.
    /// </summary>
    /// <param name="nodeCopnfiguration">The node copnfiguration.</param>
    /// <returns>An inctance of <see cref="!:TypeForConfiguration" /> represnting the node of the navigation tree.</returns>
    protected override OPCFModelDesign CreateTreeNode(OPCFModelDesign nodeCopnfiguration)
    {
      return nodeCopnfiguration;
    }
    #endregion

    #region initialization
    private void CommonInitialisation()
    {
      // 
      // OpenFileDialog
      // 
      UpdateSettingsOpenFileDialog(
        Resources.Project_FileDialogDefaultExt,
        Resources.Project_FileDialogDefaultFilename,
        Resources.Project_FileDialogFilter,
        Resources.Project_FileDialogTitle
        );
      // 
      // SaveFileDialog
      // 
      UpdateSettingsSaveFileDialog(
        Resources.Project_FileDialogDefaultExt,
        Resources.Project_FileDialogDefaultFilename,
        Resources.Project_FileDialogFilter,
        Resources.Project_FileDialogTitle
        );
    }
    public OPCFModelConfigurationManagement()
      : base()
    {
      CommonInitialisation();
    }
    public OPCFModelConfigurationManagement( IContainer container )
      : base( container )
    {
      CommonInitialisation();
    }
    #endregion

  }
}
