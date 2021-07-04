//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Xml.Schema;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  /// <summary>
  /// This class is used in DataTypeConverter dropdown list
  /// </summary>
  internal class TypeListConverter : ExpandableObjectConverter
  {
    #region static constructor

    private static SortedList<string, ValueEditor> m_TypeList;

    static TypeListConverter()
    {
      m_TypeList = new SortedList<string, ValueEditor>();
      List<string> m_XmlType = new List<string>(Enum.GetNames(typeof(XmlTypeCode)));
      try
      {
        Assembly assembly = Assembly.GetExecutingAssembly();
        Stream streamToBeRead = null;
        foreach (string resname in assembly.GetManifestResourceNames())
          if (resname.Contains("Opc.Ua.Types.xsd"))
          {
            streamToBeRead = assembly.GetManifestResourceStream(resname);
            break;
          }
        if (streamToBeRead == null)
          return;
        XmlSchema schema = new XmlSchema();
        schema = XmlSchema.Read(streamToBeRead, null);
        NameSpace = schema.TargetNamespace;
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add(schema);
        schemaSet.Compile();
        foreach (XmlSchema sch in schemaSet.Schemas())
          foreach (XmlSchemaElement element in sch.Elements.Values)
          {
            XmlSchemaSimpleType et = element.ElementSchemaType as XmlSchemaSimpleType;
            if (et == null)
              continue;
            if ((m_XmlType.Contains(et.TypeCode.ToString())))
              m_TypeList.Add(element.Name, new XmlStandardValueEditor(element.Name));
          }
        m_TypeList.Add(ValueEditor.RangeValueValueEditor.LocalName, new ValueEditor.RangeValueValueEditor());
        m_TypeList.Add(ValueEditor.XmValueValueEditor.LocalName, new ValueEditor.XmValueValueEditor());
        m_TypeList.Add(ValueEditor.NotSetValueEditor.LocalName, new ValueEditor.NotSetValueEditor());
      }
      catch (Exception ex)
      {
        string fmt = "There is an error while reading the schema from resource: {0}";
        System.Diagnostics.Debug.Assert(false, String.Format(fmt, ex.Message));
      }
    }

    #endregion static constructor

    #region internal

    internal static string NameSpace { get; private set; }

    #endregion internal

    #region ExpandableObjectConverter

    /// <summary>
    /// Gets a value indicating whether this object supports a standard set of values that can be picked from a list.
    /// </summary>
    /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. </param>
    /// <returns>Always returns <b>true</b> - means show a combo-box </returns>
    public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
    {
      //true means show a combo-box
      return true;
    }

    /// <summary>
    /// Gets a value indicating whether the list of standard values returned from the GetStandardValues method is an exclusive list.
    /// </summary>
    /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. </param>
    /// <returns>Always returns <b>true</b> - means it limits to list</returns>
    public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
    {
      //true will limit to list. false will show the list, but allow free-form entry
      return false;
    }

    /// <summary>
    /// Gets a collection of standard values for the data type this validator is designed for.
    /// </summary>
    /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. </param>
    /// <returns>A <see cref="TypeConverter.StandardValuesCollection"/>  that holds a standard set of valid values </returns>
    public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
    {
      List<ValueEditor> lst = new List<ValueEditor>();
      foreach (KeyValuePair<string, ValueEditor> itm in m_TypeList)
        lst.Add(itm.Value);
      return new StandardValuesCollection(lst);
    }

    /// <summary>
    /// Returns whether this converter can convert the object to the specified type, using the specified context.
    /// </summary>
    /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
    /// <param name="destinationType">A <see cref="T:System.Type"/> that represents the type you want to convert to.</param>
    /// <returns>
    /// true if this converter can perform the conversion; otherwise, false.
    /// </returns>
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      if (destinationType == typeof(string))
        return true;
      return base.CanConvertTo(context, destinationType);
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
    public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
    {
      if (destinationType != typeof(string))
        return base.ConvertTo(context, culture, value, destinationType);
      return ((ValueEditor)value).TypeName;
    }

    /// <summary>
    /// Returns whether this converter can convert an object of the given type to the type of this converter, using the specified context.
    /// </summary>
    /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
    /// <param name="sourceType">A <see cref="T:System.Type"/> that represents the type you want to convert from.</param>
    /// <returns>
    /// true if this converter can perform the conversion; otherwise, false.
    /// </returns>
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      if (sourceType == typeof(string))
        return true;
      return base.CanConvertFrom(context, sourceType);
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
    public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
    {
      if (!(value is string))
        return base.ConvertFrom(context, culture, value);
      string name = ((string)value).Trim();
      if (m_TypeList.ContainsKey(name))
        return m_TypeList[name].Clone();
      ValueEditor editor = ((VariableValueEditor)context.Instance).Editor;
      if (editor is ValueEditor.NotSetValueEditor)
        return editor;
      ValueEditor newEditor = editor.Clone();
      newEditor.TypeName = name;
      m_TypeList.Add(name, newEditor);
      return newEditor;
    }

    #endregion ExpandableObjectConverter
  }
}