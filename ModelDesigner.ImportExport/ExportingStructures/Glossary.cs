using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CAS.UA.Model.Designer.ImportExport.ExportingStructures
{

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( AnonymousType = true )]

  public partial class row
  {

    private rowEntry[] entryField;

    /// <uwagi/>
    [XmlElementAttribute( "entry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified )]
    public rowEntry[] entry
    {
      get
      {
        return this.entryField;
      }
      set
      {
        this.entryField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", AnonymousType = true )]
  public partial class rowEntry
  {

    private string paraField;

    /// <uwagi/>
    [XmlElementAttribute( Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", Form = XmlSchemaForm.Qualified )]
    public string para
    {
      get
      {
        return this.paraField;
      }
      set
      {
        this.paraField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( AnonymousType = true )]
  [XmlRootAttribute( Namespace = "", IsNullable = false )]
  public partial class topic
  {

    private glossary[] developerGlossaryDocumentField;

    private string idField;

    private string revisionNumberField;

    /// <uwagi/>
    [XmlArrayAttribute( Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", Form = XmlSchemaForm.Qualified )]
    [XmlArrayItemAttribute( "glossary", typeof( glossary ), Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", Form = XmlSchemaForm.Qualified, IsNullable = false )]
    public glossary[] developerGlossaryDocument
    {
      get
      {
        return this.developerGlossaryDocumentField;
      }
      set
      {
        this.developerGlossaryDocumentField = value;
      }
    }

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string revisionNumber
    {
      get
      {
        return this.revisionNumberField;
      }
      set
      {
        this.revisionNumberField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( AnonymousType = true )]
  public partial class glossary
  {

    private glossaryTitle[] titleField;

    private glossaryDiv[] glossaryDivField;

    private string addressField;

    private string contentTypeField;

    /// <uwagi/>
    [XmlElementAttribute( "title", Form = XmlSchemaForm.Qualified, Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", IsNullable = true )]
    public glossaryTitle[] title
    {
      get
      {
        return this.titleField;
      }
      set
      {
        this.titleField = value;
      }
    }

    /// <uwagi/>
    [XmlElementAttribute( "glossaryDiv", Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", Form = XmlSchemaForm.Qualified )]
    public glossaryDiv[] glossaryDiv
    {
      get
      {
        return this.glossaryDivField;
      }
      set
      {
        this.glossaryDivField = value;
      }
    }

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string address
    {
      get
      {
        return this.addressField;
      }
      set
      {
        this.addressField = value;
      }
    }

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string contentType
    {
      get
      {
        return this.contentTypeField;
      }
      set
      {
        this.contentTypeField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( AnonymousType = true )]
  public partial class glossaryTitle
  {

    private string addressField;

    private string valueField;

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string address
    {
      get
      {
        return this.addressField;
      }
      set
      {
        this.addressField = value;
      }
    }

    /// <uwagi/>
    [XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( AnonymousType = true )]
  public partial class glossaryDiv
  {

    private string titleField;

    private glossaryEntry[] glossaryEntryField;

    private string addressField;

    /// <uwagi/>
    [XmlElementAttribute( Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", Form = XmlSchemaForm.Qualified )]
    public string title
    {
      get
      {
        return this.titleField;
      }
      set
      {
        this.titleField = value;
      }
    }

    /// <uwagi/>
    [XmlElementAttribute( "glossaryEntry", Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", Form = XmlSchemaForm.Qualified )]
    public glossaryEntry[] glossaryEntry
    {
      get
      {
        return this.glossaryEntryField;
      }
      set
      {
        this.glossaryEntryField = value;
      }
    }

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string address
    {
      get
      {
        return this.addressField;
      }
      set
      {
        this.addressField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( AnonymousType = true )]
  public partial class glossaryEntry
  {

    private term[] termsField;

    private definition[] definitionField;

    private relatedEntry[] relatedEntryField;

    private string addressField;

    /// <uwagi/>
    [XmlArrayItemAttribute( "term", typeof( term ), Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", Form = XmlSchemaForm.Qualified )]
    public term[] terms
    {
      get
      {
        return this.termsField;
      }
      set
      {
        this.termsField = value;
      }
    }

    /// <uwagi/>
    [XmlElementAttribute( "definition", Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", Form = XmlSchemaForm.Qualified )]
    public definition[] definition
    {
      get
      {
        return this.definitionField;
      }
      set
      {
        this.definitionField = value;
      }
    }

    /// <uwagi/>
    [XmlElementAttribute( "relatedEntry", Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", Form = XmlSchemaForm.Qualified )]
    public relatedEntry[] relatedEntry
    {
      get
      {
        return this.relatedEntryField;
      }
      set
      {
        this.relatedEntryField = value;
      }
    }

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string address
    {
      get
      {
        return this.addressField;
      }
      set
      {
        this.addressField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( AnonymousType = true )]
  public partial class term
  {

    private string termClassField;

    private string valueField;

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string termClass
    {
      get
      {
        return this.termClassField;
      }
      set
      {
        this.termClassField = value;
      }
    }

    /// <uwagi/>
    [XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( AnonymousType = true )]
  [XmlInclude( typeof( definitionTable[] ) )]
  [XmlInclude( typeof( definitionPara[] ) )]
  public partial class definition
  {

    [System.Xml.Serialization.XmlElementAttribute( Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", Form = XmlSchemaForm.Qualified, IsNullable = true )]
    private ParaOrTable[] paraOrTableField;

    private string addressField;


    /// <uwagi/>
    /// 
    [XmlElementAttribute( "para", typeof( definitionPara ) )]
    [XmlElementAttribute( "table", typeof( definitionTable ) )]
    public ParaOrTable[] paraOrTable
    {
      get
      {
        return this.paraOrTableField;
      }
      set
      {
        this.paraOrTableField = value;
      }
    }

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string address
    {
      get
      {
        return this.addressField;
      }
      set
      {
        this.addressField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", AnonymousType = true )]
  public partial class definitionPara: ParaOrTable
  {

    private string valueField;

    /// <uwagi/>
    [XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( Namespace = "http://ddue.schemas.microsoft.com/authoring/2003/5", AnonymousType = true )]
  public partial class definitionTable: ParaOrTable
  {

    private TableRowOrTableHeader[] headerOrRowField;

    /// <uwagi/>
    [XmlElement( "row", typeof( TableRow ) )]
    [XmlElement( "tableHeader", typeof( TableHeader ) )]
    public TableRowOrTableHeader[] headerOrRow
    {
      get
      {
        return this.headerOrRowField;
      }
      set
      {
        this.headerOrRowField = value;
      }
    }

  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( AnonymousType = true )]
  public partial class relatedEntry
  {

    private string relationTypeField;

    private string termIdField;

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string relationType
    {
      get
      {
        return this.relationTypeField;
      }
      set
      {
        this.relationTypeField = value;
      }
    }

    /// <uwagi/>
    [XmlAttributeAttribute()]
    public string termId
    {
      get
      {
        return this.termIdField;
      }
      set
      {
        this.termIdField = value;
      }
    }
  }

  /// <uwagi/>
  [GeneratedCodeAttribute( "xsd", "2.0.50727.42" )]
  [SerializableAttribute()]
  [DebuggerStepThroughAttribute()]
  [DesignerCategoryAttribute( "code" )]
  [XmlTypeAttribute( AnonymousType = true )]
  public partial class NewDataSet
  {

    private object[] itemsField;

    /// <uwagi/>
    [XmlElementAttribute( "row", typeof( row ) )]
    [XmlElementAttribute( "topic", typeof( topic ) )]

    public object[] Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }
  }


  /// <summary>
  /// Class ParaOrTable.
  /// </summary>
  public class ParaOrTable
  {
  }
  /// <summary>
  /// Class TableRowOrTableHeader.
  /// </summary>
  public class TableRowOrTableHeader
  {
  }



  /// <summary>
  /// Class TableRow.
  /// </summary>
  public class TableRow: TableRowOrTableHeader
  {
    private rowEntry[] rowEntryField;
    /// <summary>
    /// Gets or sets the row entry field.
    /// </summary>
    /// <value>The row entry field.</value>
    [XmlElement( "entry", typeof( rowEntry ) )]
    public rowEntry[] RowEntryField
    {
      get
      {
        return this.rowEntryField;
      }
      set
      {
        this.rowEntryField = value;
      }
    }

  }

  /// <summary>
  /// Class TableHeader.
  /// </summary>
  public class TableHeader: TableRowOrTableHeader
  {
    TableRow m_row;
    /// <summary>
    /// Gets or sets the row.
    /// </summary>
    /// <value>The row.</value>
    public TableRow row
    {
      get 
      { 
        return m_row; 
      }
      set 
      { 
        m_row = value; 
      }
    }
  }
}