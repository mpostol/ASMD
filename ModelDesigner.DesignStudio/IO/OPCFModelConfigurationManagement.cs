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

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using System;
using System.IO;
using UAOOI.SemanticData.UANodeSetValidation;
using OPCFModelDesign = Opc.Ua.ModelCompiler.ModelDesign;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Class to save and restore UA Information Model to/from external file.
  /// </summary>
  internal class OPCFModelConfigurationManagement : TypeGenericConfigurationManagement<OPCFModelDesign>
  {
    #region private
    /// <summary>
    /// Gets the configuration.
    /// </summary>
    /// <value>The configuration .</value>
    /// <remarks>Not implemented in this class</remarks>
    protected override XmlFile.DataToSerialize<OPCFModelDesign> GetConfiguration(OPCFModelDesign configuration)
    {
      throw new NotImplementedException();
    }
    #endregion

    #region initialization
    private void CommonInitialization()
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
    public OPCFModelConfigurationManagement(IGraphicalUserInterface graphicalUserInterface) : base(graphicalUserInterface)
    {
      CommonInitialization();
    }
    #endregion
    internal static Tuple<Opc.Ua.ModelCompiler.ModelDesign, string> ReadModelDesign(string filePath, Action<TraceMessage> tracer)
    {
      using (OPCFModelConfigurationManagement _manager = new OPCFModelConfigurationManagement(new GraphicalUserInterface())
      {
        DefaultDirectory = Path.GetDirectoryName(filePath),
        DefaultFileName = Path.GetFileName(filePath)
      })
      {
        Opc.Ua.ModelCompiler.ModelDesign _model = _manager.ReadConfiguration();
        return new Tuple<Opc.Ua.ModelCompiler.ModelDesign, string>(_model, _manager.DefaultFileName);
      }
    }

  }
}
