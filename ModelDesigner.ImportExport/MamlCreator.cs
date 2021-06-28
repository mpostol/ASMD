//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.ImportExport.ExportingStructures;
using CAS.UA.Model.Designer.ImportExport.Properties;
using System;
using System.Collections.Generic;
using System.IO;

namespace CAS.UA.Model.Designer.ImportExport
{
  /// <summary>
  /// Class MamlCreator.
  /// </summary>
  public sealed class MamlCreator : IASMDExporter
  {
    #region Private

    /// <summary>
    /// Creates the maml.
    /// </summary>
    /// <param name="listOfAllTerms">The list of all terms.</param>
    /// <param name="FileName">Name of the file.</param>
    /// <param name="success">if set to <c>true</c> [success].</param>
    /// <returns>True if the serialization succeeded</returns>
    private static string CreateMaml(List<TermWithDefinitionStructure> listOfAllTerms, string FileName, out bool success)
    {
      success = false;
      //preparation of empty Topic - Glossary type
      topic tpc = GetEmptyGlosaryTopic(listOfAllTerms.Count);
      //walk through all terms and fill the glossary topic
      for (int termCounter = 0; termCounter < listOfAllTerms.Count; termCounter++)
        FillTheTermAndDefinitions(listOfAllTerms[termCounter], tpc, termCounter);
      //writing topic to the file
      try
      {
        if (!string.IsNullOrEmpty(FileName))
        {
          FileInfo fi = new FileInfo(FileName);
          if (WriteToXML(fi, tpc))
          {
            success = true;
            return Resources.ExportTool_ExportSucceded;
          }
          else
            return Resources.ExportTool_ExportSerializationProblem;
        }
        else
          return Resources.ExportTool_FileWasNotSaved;
      }
      catch (Exception ex)
      {
        return string.Format(Resources.ExportTool_ExportGeneralError_with_details, ex.Message);
      }
    }

    private static topic GetEmptyGlosaryTopic(int listOfAllTermsCount)
    {
      topic tpc = new topic
      {
        id = "id1",
        developerGlossaryDocument = new glossary[1]
      };
      tpc.developerGlossaryDocument[0] = new glossary
      {
        title = new glossaryTitle[1]
      };
      tpc.developerGlossaryDocument[0].title[0] = new glossaryTitle
      {
        Value = Resources.ExportTool_DocumentTitle
      };
      tpc.developerGlossaryDocument[0].glossaryDiv = new glossaryDiv[1];
      tpc.developerGlossaryDocument[0].glossaryDiv[0] = new glossaryDiv
      {
        title = "Documentation",
        glossaryEntry = new glossaryEntry[listOfAllTermsCount]
      };
      return tpc;
    }

    /// <summary>
    /// Fills the document.
    /// </summary>
    /// <param name="termWithDefinition">The term with definition.</param>
    /// <param name="tpc">The topic.</param>
    /// <param name="termCounter">The term counter.</param>
    private static void FillTheTermAndDefinitions(TermWithDefinitionStructure termWithDefinition, topic tpc, int termCounter)
    {
      tpc.developerGlossaryDocument[0].glossaryDiv[0].glossaryEntry[termCounter] = new glossaryEntry
      {
        terms = new term[1]
      };
      tpc.developerGlossaryDocument[0].glossaryDiv[0].glossaryEntry[termCounter].terms[0] = new term
      {
        termClass = "term",
        Value = termWithDefinition.TermTypeName
      };
      tpc.developerGlossaryDocument[0].glossaryDiv[0].glossaryEntry[termCounter].definition = new definition[1];
      tpc.developerGlossaryDocument[0].glossaryDiv[0].glossaryEntry[termCounter].definition[0] = new definition
      {
        paraOrTable = new ParaOrTable[(2 * termWithDefinition.ListOfAllTablesInTheDefinition.Count) + 2]
      };
      definitionPara isAbstractPara = new definitionPara
      {
        Value = string.Format("{0}: {1}", Resources.ExportTool_IsAbstract, termWithDefinition.IsAbstract)
      };
      tpc.developerGlossaryDocument[0].glossaryDiv[0].glossaryEntry[termCounter].definition[0].paraOrTable[1] = isAbstractPara;
      int counter = 2;
      foreach (TableStructure tab in termWithDefinition.ListOfAllTablesInTheDefinition)
      {
        definitionPara titlePara = new definitionPara
        {
          Value = " - " + tab.Title
        };
        tpc.developerGlossaryDocument[0].glossaryDiv[0].glossaryEntry[termCounter].definition[0].paraOrTable[counter] = titlePara;
        counter++;
        tpc.developerGlossaryDocument[0].glossaryDiv[0].glossaryEntry[termCounter].definition[0].paraOrTable[counter] = MamlCreator.CreateTable(tab);
        counter++;
      }
      return;
    }

    /// <summary>
    /// Creates the table.
    /// </summary>
    /// <param name="tableStructure">The table structure.</param>
    /// <returns>Whole table</returns>
    private static definitionTable CreateTable(TableStructure tableStructure)
    {
      definitionTable mamlTable = new definitionTable();
      List<string> headerRow = tableStructure.HeaderRow;
      List<List<string>> listOfRows = tableStructure.TableRows;
      //Add header
      TableRowOrTableHeader[] tableWithHeader = new TableRowOrTableHeader[1];
      TableHeader header = new TableHeader();
      tableWithHeader[0] = header;
      header.row = new TableRow
      {
        RowEntryField = new rowEntry[headerRow.Count]
      };
      for (int counter = 0; counter < headerRow.Count; counter++)
      {
        header.row.RowEntryField[counter] = new rowEntry
        {
          para = headerRow[counter]
        };
      }
      //Add rows
      mamlTable.headerOrRow = new TableRowOrTableHeader[listOfRows.Count + 1];
      mamlTable.headerOrRow[0] = tableWithHeader[0];
      TableRow tableRow;
      List<string> listOfRowFields;
      for (int p = 1; p <= listOfRows.Count; p++)
      {
        listOfRowFields = listOfRows[p - 1];
        tableRow = new TableRow();
        mamlTable.headerOrRow[p] = tableRow;
        tableRow.RowEntryField = new rowEntry[listOfRowFields.Count];
        for (int ix = 0; ix < listOfRowFields.Count; ix++)
        {
          tableRow.RowEntryField[ix] = new rowEntry
          {
            para = listOfRowFields[ix]
          };
        }
      }
      return mamlTable;
    }

    /// <summary>
    /// Writes to XML.
    /// </summary>
    /// <param name="filePathToSave">The file path to save.</param>
    /// <param name="tpc">The topic.</param>
    /// <returns>True if the serialization succeeded</returns>
    private static bool WriteToXML(FileInfo filePathToSave, topic tpc)
    {
      try
      {
        UAOOI.Common.Infrastructure.Serializers.XmlFile.WriteXmlFile<topic>(tpc, filePathToSave.FullName, FileMode.Create, string.Empty);
      }
      catch
      {
        return false;
      }
      return true;
    }

    #endregion Private

    #region IASMDExporter Members

    Guid IASMDExporter.Id => new Guid("{5A731028-5517-4b12-8139-0F7C378A7634}");
    string IASMDExporter.Name => "Maml";
    string IASMDExporter.FileDefaultExt => "aml";

    string IASMDExporter.FileFilter
    {
      get { return "MAML files (*.aml)|*.aml"; ; }
    }

    bool IASMDExporter.CreateDocument(string FileName, List<TermWithDefinitionStructure> listOfAllTerms, out string message)
    {
      message = CreateMaml(listOfAllTerms, FileName, out bool success);
      return success;
    }

    #endregion IASMDExporter Members
  }
}