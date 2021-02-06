//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using System.IO;
using UAOOI.SemanticData.BuildingErrorsHandling;
using UAOOI.SemanticData.UAModelDesignExport;
using UAOOI.SemanticData.UANodeSetValidation;
using OPCFModelDesign = UAOOI.SemanticData.UAModelDesignExport.XML.ModelDesign;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{
  /// <summary>
  /// Class AddressSpaceContextService - Entry point to create Information Model using the <see name="AddressSpaceContextService.CreateInstance"/> to populate it.
  /// </summary>
  /// <remarks>It may be used to export selected target namespace .</remarks>
  public static class AddressSpaceContextService
  {
    #region public static

    /// <summary>
    /// Creates new instance of the <see cref="OPCFModelDesign" />.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <param name="traceEvent">The trace event.</param>
    /// <returns>An object of <see cref="OPCFModelDesign"/>.</returns>
    /// <exception cref="FileNotFoundException">The imported file does not exist</exception>
    public static OPCFModelDesign CreateInstance(FileInfo filePath, Action<TraceMessage> traceEvent)
    {
      if (!filePath.Exists)
        throw new FileNotFoundException("The imported file does not exist", filePath.FullName);
      IAddressSpaceContext _as = AddressSpaceFactory.AddressSpace;
      ModelDesignExport _exporter = new ModelDesignExport();
      _as.InformationModelFactory = _exporter.GetFactory(traceEvent);
      _as.ImportUANodeSet(filePath);
      _as.ValidateAndExportModel();
      return _exporter.ExportToObject();
    }

    #endregion public static
  }
}