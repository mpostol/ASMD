//<summary>
//  Title   : Exporting tool common interface
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System;
using System.Collections.Generic;
using CAS.UA.Model.Designer.ImportExport.ExportingStructures;

namespace CAS.UA.Model.Designer.ImportExport
{
  /// <summary>
  /// Exporting tool common interface
  /// </summary>
  public interface IASMDExporter
  {
    /// <summary>
    /// Gets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    Guid Id { get; }
    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    string Name { get; }
    /// <summary>
    /// Gets the file default ext.
    /// </summary>
    /// <value>The file default ext.</value>
    string FileDefaultExt { get; }
    /// <summary>
    /// Gets the file filter.
    /// </summary>
    /// <value>The file filter.</value>
    string FileFilter { get; }
    /// <summary>
    /// Creates the document.
    /// </summary>
    /// <param name="FileName">Name of the file.</param>
    /// <param name="listOfAllTerms">The list of all terms.</param>
    /// <param name="message">The message.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    bool CreateDocument( string FileName, List<TermWithDefinitionStructure> listOfAllTerms, out string message );
  }
}
