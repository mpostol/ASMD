//<summary>
//  Title   : Editor for Default Value inside Variable and Property wrapper
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  20090331: mzbrzezny - created
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  /// <summary>
  /// Editor for Default Value inside Variable and Property wrapper
  /// </summary>
  public class VariableValueEditor
  {

    #region creator
    /// <summary>
    /// Initializes a new instance of the <see cref="VariableValueEditor"/> class.
    /// </summary>
    /// <param name="xmlElement">A default value as the XML element.</param>
    public VariableValueEditor( XmlElement xmlElement )
    {
      if ( xmlElement != null )
        this.Editor = ValueEditor.CreateValueEditor( xmlElement );
      else
        this.Editor = new ValueEditor.NotSetEditor();
    }
    #endregion

    #region public properties
    /// <summary>
    /// Gets or sets the value. For dialog user it is exposed as drop-down list with all available types.
    /// </summary>
    /// <value>The current value.</value>
    [
    DisplayName( "Selected type" ),
    TypeConverter( typeof( TypeListConverter ) ),
    BrowsableAttribute( true ),
    DescriptionAttribute( "Select the type of the value from the drop-down list and edit the current value. After selecting new type the value is cleared." ),
    NotifyParentPropertyAttribute( true )
    ]
    public ValueEditor Editor { get; set; }

    #endregion

    #region public
    /// <summary>
    /// Gets the <see cref="XmlElement"/> as the value edited by this editor.
    /// </summary>
    /// <value>The <see cref="XmlElement"/> or null if the value is empty</value>
    internal XmlElement XmlElement { get { return Editor.XmlElement; } }

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </returns>
    public override string ToString()
    {
      return Editor.ToString();
    }
    /// <summary>
    /// Determines whether this instance is empty (no value is stored).
    /// </summary>
    /// <returns>
    /// 	<c>true</c> if this instance is empty; otherwise, <c>false</c>.
    /// </returns>
    public bool IsEmpty()
    {
      return Editor is ValueEditor.NotSetEditor;
    }
    /// <summary>
    /// Updates the value stored in the editor based on other variable from other value editor.
    /// </summary>
    /// <param name="value">The value.</param>
    public void UpdateValueBasedOnOtherVariableValueEditor( VariableValueEditor value )
    {
      this.Editor = value.Editor.Clone();
    }
    #endregion

    #region editors
    public abstract class ValueEditor
    {
      #region creator
      /// <summary>
      /// Initializes a new instance of the <see cref="ValueEditor"/> class.
      /// </summary>
      /// <param name="typeName">Name of the type - one of the types defined in the <see cref="CAS.UA.Model.Designer.Types"/> nanespace.</param>
      internal ValueEditor( string typeName )
      {
        TypeName = typeName;
      }
      #endregion

      #region public
      /// <summary>
      /// Creates the value editor from an <see cref="XmlElement"/>.
      /// </summary>
      /// <param name="xmlElement">The <paramref name="xmlElement"/> containing the value to be edited.</param>
      /// <returns>Return <see cref="ValueEditor"/> containing the value to be edited.< </returns>
      internal static ValueEditor CreateValueEditor( XmlElement xmlElement )
      {
        if ( xmlElement.LocalName.Trim().Equals( CAS.UA.Common.Types.ExtensionObject.LocalName ) )
        {
          CAS.UA.Common.Types.ExtensionObject eo = CAS.UA.Common.Types.ExtensionObject.GetExtensionObject( xmlElement );
          if ( eo.Body == null )
            return new XmlEditor();
          if ( eo.Body.LocalName.Trim().Equals( RangeValueEditor.LocalName ) )
            return new RangeValueEditor( eo.Body );
          else
            return new XmlEditor( eo.Body, eo.TypeId );
        }
        else
          return new XmlStandardValueEditor( xmlElement );
      }
      /// <summary>
      /// Gets or sets the name of the ttype.
      /// </summary>
      /// <value>The name of the ttype.</value>
      internal string TypeName { get; set; }
      /// <summary>
      /// Gets the XML element representing the current value.
      /// </summary>
      /// <value>The XML element.</value>
      internal abstract XmlElement XmlElement { get; }
      /// <summary>
      /// Creates a shallow copy of the current System.Object.
      /// </summary>
      /// <returns>A shallow copy of the current System.Object.</returns>
      internal ValueEditor Clone()
      {
        return (ValueEditor)this.MemberwiseClone();
      }
      /// <summary>
      /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
      /// </returns>
      public override string ToString()
      {
        return TypeName + " : " + GetValueAsString();
      }
      #endregion

      #region Editors
      /// <summary>
      /// <see cref="ValueEditor"/> that is to be used to provide and edit values of standard XML types.
      /// </summary>
      internal class XmlStandardValueEditor: ValueEditor
      {
        #region creator
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlStandardValueEditor"/> class.
        /// </summary>
        /// <param name="type">The type of the new value.</param>
        public XmlStandardValueEditor( string type )
          : base( type )
        { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlStandardValueEditor"/> class.
        /// </summary>
        /// <param name="xmlElement">The XML element that contains a value to be edited.</param>
        public XmlStandardValueEditor( XmlElement xmlElement )
          : base( xmlElement.LocalName )
        {
          Value = xmlElement.InnerText;
        }
        #endregion

        #region properties
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value contained by the editor.</value>
        [DisplayName( "Value" )]
        [BrowsableAttribute( true )]
        [DescriptionAttribute( "The value" )]
        [NotifyParentPropertyAttribute( true )]
        public string Value { get; set; }

        #endregion

        #region public
        /// <summary>
        /// Gets the XML element representing the current value.
        /// </summary>
        /// <value>The XML element representing current value.</value>
        internal override XmlElement XmlElement
        {
          get
          {
            if ( IsEmpty )
              return null;
            XmlDocument xmldoc = new XmlDocument();
            XmlElement elem = xmldoc.CreateElement( TypeName, TypeListConverter.NameSpace );
            elem.InnerText = Value;
            return elem;
          }
        }
        #endregion

        #region Private
        private bool IsEmpty { get { return String.IsNullOrEmpty( Value ); } }
        protected override string GetValueAsString()
        {
          return IsEmpty ? "<null>" : Value;
        }
        #endregion
      }//XmlStandardValueEditor
      /// <summary>
      /// The dedicated <see cref="ValueEditor"/> to be used to edit an object of type <see cref="CAS.UA.Model.Designer.Types.Range"/>.
      /// </summary>
      internal class RangeValueEditor: ValueEditor
      {
        #region creators
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueEditor"/> class.
        /// </summary>
        /// <param name="xmlElement">The XML element containing the value.</param>
        internal RangeValueEditor( XmlElement xmlElement )
          : base( xmlElement.Name )
        {
          m_Value = CAS.UA.Common.Types.Range.CreateRange( xmlElement );
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueEditor"/> class with a <see cref="CAS.UA.Model.Designer.Types.Range"/> entity initiated to default values.
        /// </summary>
        internal RangeValueEditor()
          : base( LocalName )
        {
          m_Value = new CAS.UA.Common.Types.Range();
        }
        #endregion

        #region public properties
        /// <summary>
        /// Gets or sets the low value of the <see cref="CAS.UA.Model.Designer.Types.Range"/>.
        /// </summary>
        /// <value>The low.</value>
        [
          DisplayName( "Low" ),
          BrowsableAttribute( true ),
          DescriptionAttribute( "Low value of the Range. Property type is double." ),
          NotifyParentPropertyAttribute( true )
        ]
        public double Low
        {
          get { return this.m_Value.Low; }
          set { this.m_Value.Low = value; }
        }
        /// <summary>
        /// Gets or sets the high value of the <see cref="CAS.UA.Model.Designer.Types.Range"/>.
        /// </summary>
        /// <value>The high.</value>
        [
          DisplayName( "High" ),
          BrowsableAttribute( true ),
          DescriptionAttribute( "High value of the Range. Property type is double." ),
          NotifyParentPropertyAttribute( true )
        ]
        public double High
        {
          get { return this.m_Value.High; }
          set { this.m_Value.High = value; }
        }
        #endregion

        #region public
        /// <summary>
        /// Name of the XML element representing an item of this type.
        /// </summary>
        internal static readonly string LocalName = typeof( CAS.UA.Common.Types.Range ).Name;

        /// <summary>
        /// Gets the XML element representing the current value.
        /// </summary>
        /// <value>The XML element.</value>
        internal override XmlElement XmlElement { get { return m_Value.XmlElement; } }
        #endregion

        #region private
        private const string m_Format = "<Low={0}, High={1}>";
        protected override string GetValueAsString()
        {
          return String.Format( m_Format, m_Value.Low, m_Value.High );
        }
        private CAS.UA.Common.Types.Range m_Value;
        #endregion

      } //RangeValueEditor
      internal class XmlEditor: ValueEditor
      {
        #region creator
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlEditor"/> class.
        /// </summary>
        /// <param name="body">The body of element of type any.</param>
        /// <param name="expandedNodeId">The expanded NodeId.</param>
        public XmlEditor(XmlElement body, CAS.UA.Common.Types.ExpandedNodeId expandedNodeId)
          : base( body.Name )
        {
          XmlText = body.OuterXml;
          NodeId = expandedNodeId.Identifier;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Initializes a new empty instance of the <see cref="XmlEditor"/> class.
        /// </summary>
        internal XmlEditor()
          : base( LocalName )
        { }
        [
          DisplayName( "Xml Content" ),
          BrowsableAttribute( true ),
          DescriptionAttribute( "Content of the XML element to encapsulated by the ExtensionObject" ),
          NotifyParentPropertyAttribute( true )
        ]
        [Editor( typeof( System.ComponentModel.Design.MultilineStringEditor ), typeof( System.Drawing.Design.UITypeEditor ) )]
        public string XmlText { get; set; }
        [
          DisplayName( "NodeId" ),
          BrowsableAttribute( true ),
          DescriptionAttribute( "Stores an identifier for a node in a server's address space. Please refer to OPC UA Specifications: Address Space Model" ),
          NotifyParentPropertyAttribute( true )
        ]
        public string NodeId { get; set; }
        #endregion

        #region public
        /// <summary>
        /// Label to be used in the drop down list.
        /// </summary>
        internal const string LocalName = "<New complex type>";
        /// <summary>
        /// Gets the XML element representing the current value.
        /// </summary>
        /// <value>The XML element.</value>
        internal override XmlElement XmlElement
        {
          get
          {
            XmlDocument xmldoc = CreateXml();
            if ( xmldoc == null )
              return null;
            return CAS.UA.Common.Types.ExtensionObject.GetXmlElement( NodeId, xmldoc.DocumentElement );
          }
        }
        #endregion

        #region private
        private XmlDocument CreateXml()
        {
          if ( IsEmpty )
            return null;
          XmlDocument xmldoc = new XmlDocument();
          try
          {
            xmldoc.LoadXml( XmlText );
          }
          catch ( Exception ex )
          {
            XmlElement ee = xmldoc.CreateElement( "Error" );
            xmldoc.AppendChild( ee );
            XmlElement eex = xmldoc.CreateElement( "XmlContent" );
            eex.InnerText = XmlText;
            ee.AppendChild( eex );
            XmlNode xc = xmldoc.CreateComment( ex.Message );
            ee.AppendChild( xc );
          }
          return xmldoc;
        }
        private bool IsEmpty { get { return String.IsNullOrEmpty( XmlText ); } }
        /// <summary>
        /// Gets the value as string.
        /// </summary>
        /// <returns></returns>
        protected override string GetValueAsString()
        {
          return IsEmpty ? "<null>" : CreateXml().InnerText;
        }
        #endregion

      }//XmlEditor
      /// <summary>
      /// The class represents null value
      /// </summary>
      internal class NotSetEditor: ValueEditor
      {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotSetEditor"/> class.
        /// </summary>
        public NotSetEditor()
          : base( LocalName )
        { }

        /// <summary>
        /// Label to be used in the drop down list.
        /// </summary>
        internal const string LocalName = "<Not set>";

        /// <summary>
        /// Gets the XML element representing the current value.
        /// </summary>
        /// <value>The XML element.</value>
        internal override XmlElement XmlElement
        {
          get { return null; }
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
          return this.TypeName;
        }
        protected override string GetValueAsString()
        {
          return "";
        }
      }
      #endregion

      #region private
      protected abstract string GetValueAsString();
      #endregion

    } //ValueEditor 
    #endregion

    #region private
    private static uint m_Counter = 0;
    private static uint GetCounter()
    {
      return m_Counter++;
    }
    #region TypeConverter class
    /// <summary>
    /// This class is used in DataTypeConverter dropdown list 
    /// </summary>
    private class TypeListConverter: ExpandableObjectConverter
    {
      #region static constructor
      private static SortedList<string, ValueEditor> m_TypeList;
      static TypeListConverter()
      {
        m_TypeList = new SortedList<string, ValueEditor>();
        List<string> m_XmlType = new List<string>( Enum.GetNames( typeof( XmlTypeCode ) ) );
        try
        {
          Assembly assembly = Assembly.GetExecutingAssembly();
          Stream streamToBeRead = null;
          foreach ( string resname in assembly.GetManifestResourceNames() )
            if ( resname.Contains( "Opc.Ua.Types.xsd" ) )
            {
              streamToBeRead = assembly.GetManifestResourceStream( resname );
              break;
            }
          if ( streamToBeRead == null )
            return;
          XmlSchema schema = new XmlSchema();
          schema = XmlSchema.Read( streamToBeRead, null );
          NameSpace = schema.TargetNamespace;
          XmlSchemaSet schemaSet = new XmlSchemaSet();
          schemaSet.Add( schema );
          schemaSet.Compile();
          foreach ( XmlSchema sch in schemaSet.Schemas() )
            foreach ( XmlSchemaElement element in sch.Elements.Values )
            {
              XmlSchemaSimpleType et = element.ElementSchemaType as XmlSchemaSimpleType;
              if ( et == null )
                continue;
              if ( ( m_XmlType.Contains( et.TypeCode.ToString() ) ) )
                m_TypeList.Add( element.Name, new ValueEditor.XmlStandardValueEditor( element.Name ) );
            }
          m_TypeList.Add( ValueEditor.RangeValueEditor.LocalName, new ValueEditor.RangeValueEditor() );
          m_TypeList.Add( ValueEditor.XmlEditor.LocalName, new ValueEditor.XmlEditor() );
          m_TypeList.Add( ValueEditor.NotSetEditor.LocalName, new ValueEditor.NotSetEditor() );
        }
        catch ( Exception ex )
        {
          string fmt = "There is an error while reading the schema from resource: {0}";
          System.Diagnostics.Debug.Assert( false, String.Format( fmt, ex.Message ) );
        }
      }
      #endregion

      #region intearnal
      internal static string NameSpace { get; private set; }
      #endregion

      #region ExpandableObjectConverter
      /// <summary>
      /// Gets a value indicating whether this object supports a standard set of values that can be picked from a list. 
      /// </summary>
      /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. </param>
      /// <returns>Always returns <b>true</b> - means show a combobox </returns>
      public override bool GetStandardValuesSupported( ITypeDescriptorContext context )
      {
        //true means show a combobox
        return true;
      }
      /// <summary>
      /// Gets a value indicating whether the list of standard values returned from the GetStandardValues method is an exclusive list. 
      /// </summary>
      /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. </param>
      /// <returns>Always returns <b>true</b> - means it limits to list</returns>
      public override bool GetStandardValuesExclusive( ITypeDescriptorContext context )
      {
        //true will limit to list. false will show the list, but allow free-form entry
        return false;
      }
      /// <summary>
      /// Gets a collection of standard values for the data type this validator is designed for. 
      /// </summary>
      /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. </param>
      /// <returns>A <see cref="TypeConverter.StandardValuesCollection"/>  that holds a standard set of valid values </returns>
      public override StandardValuesCollection GetStandardValues( ITypeDescriptorContext context )
      {
        List<ValueEditor> lst = new List<ValueEditor>();
        foreach ( var itm in m_TypeList )
          lst.Add( itm.Value );
        return new StandardValuesCollection( lst );
      }
      /// <summary>
      /// Returns whether this converter can convert the object to the specified type, using the specified context.
      /// </summary>
      /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
      /// <param name="destinationType">A <see cref="T:System.Type"/> that represents the type you want to convert to.</param>
      /// <returns>
      /// true if this converter can perform the conversion; otherwise, false.
      /// </returns>
      public override bool CanConvertTo( ITypeDescriptorContext context, Type destinationType )
      {
        if ( destinationType == typeof( string ) )
          return true;
        return base.CanConvertTo( context, destinationType );
      }
      /// <summary>
      /// Converts the given value object to the specified type, using the specified context and culture information.
      /// </summary>
      /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
      /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo"/>. If null is passed, the current culture is assumed.</param>
      /// <param name="value">The <see cref="T:System.Object"/> to convert.</param>
      /// <param name="destinationType">The <see cref="T:System.Type"/> to convert the <paramref name="value"/> parameter to.</param>
      /// <returns>
      /// An <see cref="T:System.Object"/> that represents the converted value.
      /// </returns>
      /// <exception cref="T:System.ArgumentNullException">
      /// The <paramref name="destinationType"/> parameter is null.
      /// </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// The conversion cannot be performed.
      /// </exception>
      public override object ConvertTo( ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType )
      {
        if ( destinationType != typeof( string ) )
          return base.ConvertTo( context, culture, value, destinationType );
        return ( (ValueEditor)value ).TypeName;
      }
      /// <summary>
      /// Returns whether this converter can convert an object of the given type to the type of this converter, using the specified context.
      /// </summary>
      /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
      /// <param name="sourceType">A <see cref="T:System.Type"/> that represents the type you want to convert from.</param>
      /// <returns>
      /// true if this converter can perform the conversion; otherwise, false.
      /// </returns>
      public override bool CanConvertFrom( ITypeDescriptorContext context, Type sourceType )
      {
        if ( sourceType == typeof( string ) )
          return true;
        return base.CanConvertFrom( context, sourceType );
      }
      /// <summary>
      /// Converts the given object to the type of this converter, using the specified context and culture information.
      /// </summary>
      /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
      /// <param name="culture">The <see cref="T:System.Globalization.CultureInfo"/> to use as the current culture.</param>
      /// <param name="value">The <see cref="T:System.Object"/> to convert.</param>
      /// <returns>
      /// An <see cref="T:System.Object"/> that represents the converted value.
      /// </returns>
      /// <exception cref="T:System.NotSupportedException">
      /// The conversion cannot be performed.
      /// </exception>
      public override object ConvertFrom( ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value )
      {

        if ( !( value is string ) )
          return base.ConvertFrom( context, culture, value );
        string name = ( (string)value ).Trim();
        if ( m_TypeList.ContainsKey( name ) )
          return m_TypeList[ name ].Clone();
        ValueEditor editor = ( (VariableValueEditor)context.Instance ).Editor;
        if ( editor is ValueEditor.NotSetEditor )
          return editor;
        ValueEditor newEditor = editor.Clone();
        newEditor.TypeName = name;
        m_TypeList.Add( name, newEditor );
        return newEditor;
      }
      #endregion
    }
    #endregion

    #endregion

  }
}
