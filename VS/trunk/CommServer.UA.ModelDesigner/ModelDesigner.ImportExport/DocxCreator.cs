//<summary>
//  Title   : Word Docx exporting tool
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

using CAS.UA.Model.Designer.ImportExport.ExportingStructures;
using CAS.UA.Model.Designer.ImportExport.Properties;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using TableRowOpenXML = DocumentFormat.OpenXml.Wordprocessing.TableRow;

namespace CAS.UA.Model.Designer.ImportExport
{
  /// <summary>
  /// Class DocxCreator - provides export mechanism to docx documents
  /// </summary>
  public sealed class DocxCreator: IASMDExporter
  {
    #region IASMDExporter Members
    Guid IASMDExporter.Id
    {
      get { return new Guid( "{88B674CE-38E1-4a7f-A97F-CA8BBC8792AA}" ); }
    }
    string IASMDExporter.Name
    {
      get { return "MS Word (Docx)"; }
    }
    string IASMDExporter.FileDefaultExt
    {
      get { return "docx"; }
    }
    string IASMDExporter.FileFilter
    {
      get { return "MS Word files (*.docx)|*.docx"; ; }
    }
    bool IASMDExporter.CreateDocument( string FileName, List<TermWithDefinitionStructure> listOfAllTerms, out string message )
    {
      bool success = true;
      try
      {
        // Create a Word processing document. 
        using ( WordprocessingDocument myDoc = WordprocessingDocument.Create( FileName, WordprocessingDocumentType.Document ) )
        {
          // Add a new main document part. 
          MainDocumentPart mainPart = myDoc.AddMainDocumentPart();
          //styles:
          PrepareStyleDefinitionsPart( mainPart );

          //Create Document tree for simple document. 
          mainPart.Document = new Document();
          //Create Body (this element contains other elements that we want to include
          Body body = new Body();
          //title:
          CreateSimpleParagraph( body, Resources.ExportTool_DocumentTitle, styleH1 );
          ////////////////////////////////////////////////////////
          //walk through all terms and fill the glossary topic
          for ( int termCounter = 0; termCounter < listOfAllTerms.Count; termCounter++ )
            FillTheTermAndDefinitions( body, listOfAllTerms[ termCounter ] );
          ////////////////////////////////////////////////////////
          // Adding document body:
          mainPart.Document.Append( body );
          // Save changes to the main document part. 
          mainPart.Document.Save();
        }
        message = Resources.ExportTool_ExportSucceded;
      }
      catch ( Exception ex )
      {
        message = String.Format( Resources.ExportTool_ExportGeneralError_with_details, ex.Message );
        success = false;
      }
      return success;
    }
    #endregion IASMDExporter Members

    #region private
    private void FillTheTermAndDefinitions( Body body, TermWithDefinitionStructure termWithDefinition )
    {

      CreateSimpleParagraph( body, termWithDefinition.TermTypeName, styleH2_term );
      CreateSimpleParagraph( body, String.Format( "{0}: {1}", Resources.ExportTool_IsAbstract, termWithDefinition.IsAbstract ), style_description );
      foreach ( TableStructure tab in termWithDefinition.ListOfAllTablesInTheDefinition )
      {
        //blank line:
        body.Append(new Paragraph( new Run( new Text( "" ) ) ) );
        // add table
        Table table = CreateTable( tab );
        //appending table to body
        body.Append( table );

      }
    }
    private static Table CreateTable( TableStructure tab )
    {
      Table table = new Table();
      ConfigureTableProperties( table );
      TableRowOpenXML tr;
      TableCell tc;
      //first row - title
      tr = new TableRowOpenXML();
      tc = new TableCell( new Paragraph( new Run( new Text( tab.Title ) ) ) );
      TableCellProperties tcp = new TableCellProperties();
      GridSpan gridSpan = new GridSpan();
      gridSpan.Val = tab.HeaderRow.Count;
      tcp.Append( gridSpan );
      tc.Append( tcp );
      tr.Append( tc );
      table.Append( tr );
      //second row 
      tr = new TableRowOpenXML();
      foreach ( string celltab in tab.HeaderRow )
      {
        tr.Append( new TableCell( new Paragraph( new Run( new Text( celltab ) ) ) ) );
      }
      table.Append( tr );
      //rest of the table
      foreach ( var tabrow in tab.TableRows )
      {
        tr = new TableRowOpenXML();
        foreach ( string celltab in tabrow )
          tr.Append( new TableCell( new Paragraph( new Run( new Text( celltab ) ) ) ) );
        table.Append( tr );
      }
      return table;
    }

    private static void ConfigureTableProperties( Table table )
    {
      TableProperties tblPr = new TableProperties();
      TableBorders tblBorders = new TableBorders();
      tblBorders.TopBorder = new TopBorder();
      tblBorders.TopBorder.Val = new EnumValue<BorderValues>( BorderValues.Single );
      tblBorders.BottomBorder = new BottomBorder();
      tblBorders.BottomBorder.Val = new EnumValue<BorderValues>( BorderValues.Single );
      tblBorders.LeftBorder = new LeftBorder();
      tblBorders.LeftBorder.Val = new EnumValue<BorderValues>( BorderValues.Single );
      tblBorders.RightBorder = new RightBorder();
      tblBorders.RightBorder.Val = new EnumValue<BorderValues>( BorderValues.Single );
      tblBorders.InsideHorizontalBorder = new InsideHorizontalBorder();
      tblBorders.InsideHorizontalBorder.Val = BorderValues.Single;
      tblBorders.InsideVerticalBorder = new InsideVerticalBorder();
      tblBorders.InsideVerticalBorder.Val = BorderValues.Single;
      tblPr.Append( tblBorders );
      table.Append( tblPr );
    }

    private static void CreateSimpleParagraph( Body body, string TextInPragraph, Style style )
    {
      //Create paragraph
      Paragraph paragraph = new Paragraph();
      Run run_paragraph = new Run();
      // we want to put that text into the output document
      Text text_paragraph = new Text( TextInPragraph );
      if ( style != null )
      {
        //style
        ParagraphProperties paragraph_pPr = new ParagraphProperties();
        paragraph_pPr.ParagraphStyleId = new ParagraphStyleId() { Val = style.StyleId }; // we set the style
        paragraph.Append( paragraph_pPr );
      }
      //Append elements appropriately.
      run_paragraph.Append( text_paragraph );
      paragraph.Append( run_paragraph );
      body.Append( paragraph );
    }

    private Style styleH1;
    private Style styleH2_term;
    private Style style_description;
    private static Style CreateStyle( string fontcolor, string styleid, string stylename,
      string stylebasedon, string stylenextpara, string fontname, int fontsize, JustificationValues just, bool isBold, int spacing )
    {
      // we have to set the properties
      RunProperties rPr = new RunProperties();
      Color color = new Color() { Val = fontcolor }; // the color
      RunFonts rFont = new RunFonts();
      rFont.Ascii = fontname; // the font 
      rPr.Append( color );
      rPr.Append( rFont );
      if ( isBold )
        rPr.Append( new Bold() );
      rPr.Append( new FontSize() { Val = fontsize.ToString() } ); //font size (in 1/72  of an inch) 
      ParagraphProperties pPr = new ParagraphProperties();
      if ( spacing > 0 )
        pPr.Append( new SpacingBetweenLines() { 
          Line = spacing.ToString(), 
          LineRule = LineSpacingRuleValues.Auto, 
          BeforeAutoSpacing = OnOffValue.FromBoolean(true) } );
      //creation of a style
      Style style = new Style();
      style.StyleId = styleid; //this is the ID of the style
      style.Append( new Name() { Val = stylename } ); //this is name
      style.Append( new BasedOn() { Val = stylebasedon } ); // our style based on ... style
      style.Append( new NextParagraphStyle() { Val = stylenextpara } ); // the next paragraph is ... type
      style.Append( pPr );//we are adding properties previously defined
      style.Append( rPr );//we are adding properties previously defined
      //lets make it centered)
      style.Append( new ParagraphProperties(
           new Justification() { Val = just } ) );
      return style;
    }
    private void PrepareStyleDefinitionsPart( MainDocumentPart mainPart )
    {
      //Add new style part 
      StyleDefinitionsPart stylePart = mainPart.AddNewPart<StyleDefinitionsPart>();
      styleH1 = CreateStyle( "0000AA", "MyHeading1", "My Heading 1", "Heading1", "Normal", "Arial", 32, JustificationValues.Center, true,480 );
      styleH2_term = CreateStyle( "000077", "MyHeading2", "My Heading 2", "Heading2", "Normal", "Arial", 28, JustificationValues.Left, true, 480 );
      style_description = CreateStyle( "000000", "Description", "Description", "Normal", "Description", "Arial", 24, JustificationValues.Left, false, 480 );
      // we have to add style that we have created to the StylePart
      stylePart.Styles = new Styles();
      stylePart.Styles.Append( styleH1 );
      stylePart.Styles.Append( styleH2_term );
      stylePart.Styles.Append( style_description );
      stylePart.Styles.Save(); // we save the style part
    }
    #endregion private

  }
}
