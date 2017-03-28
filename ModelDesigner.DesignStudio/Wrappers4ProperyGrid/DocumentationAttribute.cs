//<summary>
//  Title   : Documentation attribute for exporting tool
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

using CAS.Lib.ControlLibrary;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using Opc.Ua.ModelCompiler;
using System;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  public interface IConverterToDocumentationString
  {
    string ConvertToString(object o, string DefaultValue);
  }
  /// <summary>
  /// This attribute is used by ExportingTool to get from nodes information, that should be placed in exported documentation.
  /// </summary>
  public class DocumentationAttribute : Attribute
  {
    public string Name;
    public IConverterToDocumentationString ConverterToDocumentationString;
    public string DefaultValue;

    public DocumentationAttribute(string name)
    {
      this.Name = name;
      this.ConverterToDocumentationString = new StringGetter();
    }
    public DocumentationAttribute(string name, Type ConverterToDocumentationString) : this(name, ConverterToDocumentationString, string.Empty)
    { }
    public DocumentationAttribute(string name, Type ConverterToDocumentationString, string defaultValue)
    {
      this.Name = name;
      //TODO Check if ConverterToDocumentationString is an interface, if it is not - take StringGetter type
      this.ConverterToDocumentationString = (IConverterToDocumentationString)Activator.CreateInstance(ConverterToDocumentationString);
      this.DefaultValue = defaultValue;
    }
  }

  public class GetterOfNameAsString : IConverterToDocumentationString
  {
    #region IConverterToDocumentationString Members
    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <param name="o">The object which might be a XmlQualifiedNameEditorWithDefaultValue, XmlQualifiedNameEditor or XmlQualifiedName</param>
    /// <param name="DefaultValue">The default value.</param>
    /// <returns></returns>
    string IConverterToDocumentationString.ConvertToString(object o, string DefaultValue)
    {
      if (o is LocalizedText)
        return ((LocalizedText)o).Value;
      else if (o is ValueRank)
        return ((ValueRank)o).ToString();
      else if (o is XmlQualifiedNameEditorWithDefaultValue)
        return ((XmlQualifiedNameEditorWithDefaultValue)o).ValueOrDefault.Name;
      else if (o is XmlQualifiedNameEditor)
        return ((XmlQualifiedNameEditor)o).Name;
      else if (o is XmlQualifiedName)
        return ((XmlQualifiedName)o).Name;
      return DefaultValue;
    }
    #endregion
  }
  internal class DateTimeGetter : IConverterToDocumentationString
  {
    #region IConverterToDocumentationString Members
    /// <summary>
    /// Converts to string .
    /// </summary>
    /// <param name="o">The object.</param>
    /// <param name="DefaultValue">The default value.</param>
    /// <returns></returns>
    string IConverterToDocumentationString.ConvertToString(object o, string DefaultValue)
    {
      DateTime? _value = o as DateTime?;
      if (_value != null || _value.HasValue)
        return _value.Value.Date.ToString();
      return DefaultValue;
    }
    #endregion
  }
  internal class StringGetter : IConverterToDocumentationString
  {
    #region IConverterToDocumentationString Members
    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <param name="o">The object.</param>
    /// <param name="DefaultValue">The default value.</param>
    /// <returns></returns>
    string IConverterToDocumentationString.ConvertToString(object o, string DefaultValue)
    {
      if (o != null)
        return o.ToString();
      return DefaultValue;
    }
    #endregion
  }

}
