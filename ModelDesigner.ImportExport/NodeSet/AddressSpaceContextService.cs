//_______________________________________________________________
//  Title   : Name of Application
//  System  : Microsoft VisualStudio 2013 / C#
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2015, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

using CAS.UA.Model.Designer.ImportExport.Properties;
using System;
using System.IO;
using ModelDesign = Opc.Ua.ModelCompiler;
// using OOI = UAOOI.SemanticData.UANodeSetValidation;
//TODO Add anchors to UANodeSetValidation #194

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
    /// Creates new instance of the <see cref="ModelDesign.ModelDesign" />.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <param name="traceEvent">The trace event.</param>
    /// <returns>An object of <see cref="ModelDesign.ModelDesign"/>.</returns>
    /// <exception cref="System.IO.FileNotFoundException">The imported file does not exist</exception>
    public static ModelDesign.ModelDesign CreateInstance(FileInfo filePath, Action<UAOOI.SemanticData.UANodeSetValidation.TraceMessage> traceEvent)
    {
      if (!filePath.Exists)
        throw new FileNotFoundException("The imported file does not exist", filePath.FullName);
      traceEvent(UAOOI.SemanticData.UANodeSetValidation.TraceMessage.DiagnosticTraceMessage("Entering AddressSpaceContextService.CreateInstance"));
      UAOOI.SemanticData.UANodeSetValidation.IAddressSpaceContext _as = new UAOOI.SemanticData.UANodeSetValidation.AddressSpaceContext(traceEvent);
      ModelFactory _factory = new ModelFactory(traceEvent);
      _as.InformationModelFactory = _factory;
      _as.ImportUANodeSet(filePath);
      _as.ValidateAndExportModel();
      return _factory.Export();
    }
    /// <summary>
    /// Creates from NodeSet menu item.
    /// </summary>
    /// <returns>An object of IToolStripMenuItemInfo containing description required by a menu item.</returns>
    public static IToolStripMenuItemInfo ImportFromNodeSetMenuItem
    {
      get { return new ToolStripMenuItemInfo(Resources.ImportFromNodeSetMenuItemName, Resources.ImportFromNodeSetMenuItemText, Resources.ImportFromNodeSetMenuItemToolTip); }
    }
    #endregion

  }

}
