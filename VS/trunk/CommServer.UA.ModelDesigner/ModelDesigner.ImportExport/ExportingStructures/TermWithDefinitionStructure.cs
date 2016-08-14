//<summary>
//  Title   : Terms with definition structure
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

using System.Collections.Generic;

namespace CAS.UA.Model.Designer.ImportExport.ExportingStructures
{
  /// <summary>
  /// Class TermWithDefinitionStructure.
  /// </summary>
  public class TermWithDefinitionStructure
  {

    #region Private
    private List<TableStructure> listOfAllTablesInTheDefinition;
    private string termTypeName;
    private string isAbstract;
    #endregion

    #region SettersAndGetters
    /// <summary>
    /// Gets or sets the list of all tables in the definition.
    /// </summary>
    /// <value>The list of all tables in the definition.</value>
    public List<TableStructure> ListOfAllTablesInTheDefinition
    {
      get { return listOfAllTablesInTheDefinition; }
      set { listOfAllTablesInTheDefinition = value; }
    }

    /// <summary>
    /// Gets or sets the name of the term type.
    /// </summary>
    /// <value>The name of the term type.</value>
    public string TermTypeName
    {
      get { return termTypeName; }
      set { termTypeName = value; }
    }

    /// <summary>
    /// Gets or sets the is abstract.
    /// </summary>
    /// <value>The is abstract.</value>
    public string IsAbstract
    {
      get { return isAbstract; }
      set { isAbstract = value; }
    }
    #endregion

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="TermWithDefinitionStructure" /> class.
    /// </summary>
    /// <param name="listOfAllTablesInTheDefinition">The list of all tables in the definition.</param>
    /// <param name="termTypeName">Name of the term type.</param>
    /// <param name="isAbstract">The is abstract.</param>
    public TermWithDefinitionStructure(List<TableStructure> listOfAllTablesInTheDefinition, string termTypeName, string isAbstract )
    {
      this.ListOfAllTablesInTheDefinition = listOfAllTablesInTheDefinition;
      this.TermTypeName = termTypeName;
      this.IsAbstract = isAbstract;
    }
    #endregion
  }
}
