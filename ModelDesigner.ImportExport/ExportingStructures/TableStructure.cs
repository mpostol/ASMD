//<summary>
//  Title   : class TableStructure
//  System  : Microsoft Visual C# .NET 2012
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2014, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>
      
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.ImportExport.ExportingStructures
{
  /// <summary>
  /// Class TableStructure.
  /// </summary>
  public class TableStructure
  {
    private string title;
    List<string> headerRow;
    List<Dictionary<string,string>> tableRows;

    #region SettersAndGetters
    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>The title.</value>
    public string Title
    {
      get { return title; }
      set { title = value; }
    }

    /// <summary>
    /// Gets or sets the header row.
    /// </summary>
    /// <value>The header row.</value>
    public List<string> HeaderRow
    {
      get { return headerRow; }
      set { headerRow = value; }
    }

    /// <summary>
    /// Gets the table rows.
    /// </summary>
    /// <value>The table rows.</value>
    public List<List<string>> TableRows
    {
      get 
      {
        List<List<string>> list = new List<List<string>>();
       // if (tableRows != null)
        foreach ( var row in tableRows )
        {
          List<string> stringlist = new List<string>();
          foreach ( string header in headerRow )
          {
            if ( row.ContainsKey( header ) )
              stringlist.Add( row[ header ] );
            else
              stringlist.Add( string.Empty );
          }
          list.Add( stringlist );
        }
        return list;
      }
    }
    #endregion

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="TableStructure"/> class.
    /// </summary>
    public TableStructure() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="TableStructure" /> class.
    /// </summary>
    /// <param name="title">The title.</param>
    /// <param name="headerRow">The header row.</param>
    public TableStructure( string title, List<string> headerRow )
    {
      this.Title = title;
      this.HeaderRow = headerRow;
      this.tableRows = new List<Dictionary<string, string>>();
    }
    /// <summary>
    /// Adds the row.
    /// </summary>
    /// <param name="row">The row.</param>
    public void AddRow( Dictionary<string, string> row )
    {
      tableRows.Add( row );
    }
    #endregion

  }
}
