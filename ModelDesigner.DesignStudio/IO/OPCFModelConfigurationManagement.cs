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

using System.ComponentModel;
using CAS.UA.Model.Designer.Properties;
using OPCFModelDesign = Opc.Ua.ModelCompiler.ModelDesign;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Class to save and restore UA Information Model to/from external file.
  /// </summary>
  internal class OPCFModelConfigurationManagement: TypeGenericConfigurationManagement<OPCFModelDesign>
  {
    #region private
    //private UAModelDesignerProject m_ProjectSettings;
    protected OPCFModelDesign EmptyModel
    {
      get
      {
        return new OPCFModelDesign()
        {
          TargetNamespace = Settings.Default.TargetNamespace,
          TargetXmlNamespace = Settings.Default.TargetXmlNamespace
        };
      }
    }
    /// <summary>
    /// Gets the configuration.
    /// </summary>
    /// <value>The configuration .</value>
    /// <remarks>Not implemented in this class</remarks>
    protected override TypeGenericConfigurationManagement<OPCFModelDesign>.Configuration GetConfiguration
    {
      get { throw new System.NotImplementedException(); }
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
      //m_ProjectSettings = MyProjectSettings;
      CommonInitialisation();
    }
    public OPCFModelConfigurationManagement( IContainer container )
      : base( container )
    {
      //m_ProjectSettings = MyProjectSettings;
      CommonInitialisation();
    }
    #endregion


  }
}
