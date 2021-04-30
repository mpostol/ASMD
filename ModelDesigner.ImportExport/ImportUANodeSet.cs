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

namespace CAS.UA.Model.Designer.ImportExport
{
  /// <summary>
  /// Class AddressSpaceContextService - Entry point to create Information Model using the <see name="AddressSpaceContextService.CreateInstance"/> to populate it.
  /// </summary>
  /// <remarks>It may be used to export selected target namespace .</remarks>
  public static class ImportUANodeSet
  {
    #region public static

    /// <summary>
    /// Creates new instance of the <see cref="OPCFModelDesign" />.
    /// </summary>
    /// <param name="filePath">The path of the UANodeSet file.</param>
    /// <param name="trace">A delegate to trace the import progress.</param>
    /// <returns>An object of <see cref="OPCFModelDesign"/>.</returns>
    /// <exception cref="FileNotFoundException">The imported file does not exist</exception>
    public static OPCFModelDesign Import(FileInfo filePath, Action<TraceMessage> trace)
    {
      if (!filePath.Exists)
        throw new FileNotFoundException("The imported file does not exist", filePath.FullName);
      IAddressSpaceContext _as = AddressSpaceFactory.AddressSpace;
      ModelDesignExport _exporter = new ModelDesignExport();
      _as.InformationModelFactory = _exporter.GetFactory(trace);
      _as.ImportUANodeSet(filePath);
      //TODO AddressSpacePrototyping - IMNamespace must be required in case of export #584 
      _as.ValidateAndExportModel();
      return _exporter.ExportToObject();
    }

    #endregion public static
  }
}