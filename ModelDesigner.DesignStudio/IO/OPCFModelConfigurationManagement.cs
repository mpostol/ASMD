//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.ImportExport;
using System;
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
    /// Gets the type of the configuration.
    /// </summary>
    /// <value>The type of the configuration defined in <see cref="ConfigurationType" />.</value>
    protected override ConfigurationType Configuration => ConfigurationType.Project;
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

    #region constructor
    public OPCFModelConfigurationManagement(IGraphicalUserInterface graphicalUserInterface, string fileName) : base(graphicalUserInterface, fileName) { }
    #endregion

    internal static Tuple<OPCFModelDesign, string> ReadModelDesign(string filePath, Action<TraceMessage> tracer)
    {
      OPCFModelConfigurationManagement _manager = new OPCFModelConfigurationManagement(new GraphicalUserInterface(), filePath);
      OPCFModelDesign _model = _manager.ReadConfiguration();
      return new Tuple<OPCFModelDesign, string>(_model, _manager.DefaultFileName);
    }

  }
}
