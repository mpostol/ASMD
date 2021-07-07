//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System;
using System.ComponentModel;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  /// <summary>
  /// <see cref="ValueEditor"/> that is to be used to provide and edit values of standard XML types.
  /// </summary>
  internal class XmlStandardValueEditor : ValueEditor
  {
    #region creator

    /// <summary>
    /// Initializes a new instance of the <see cref="XmlStandardValueEditor"/> class.
    /// </summary>
    /// <param name="type">The type of the new value.</param>
    public XmlStandardValueEditor(string type)
      : base(type)
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="XmlStandardValueEditor"/> class.
    /// </summary>
    /// <param name="xmlElement">The XML element that contains a value to be edited.</param>
    public XmlStandardValueEditor(XmlElement xmlElement)
      : base(xmlElement.LocalName)
    {
      Value = xmlElement.InnerText;
    }

    #endregion creator

    #region properties

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    /// <value>The value contained by the editor.</value>
    [DisplayName("Value")]
    [BrowsableAttribute(true)]
    [DescriptionAttribute("The value")]
    [NotifyParentPropertyAttribute(true)]
    public string Value { get; set; }

    #endregion properties

    #region public

    /// <summary>
    /// Gets the XML element representing the current value.
    /// </summary>
    /// <value>The XML element representing current value.</value>
    internal override XmlElement XmlElement
    {
      get
      {
        if (IsEmpty)
          return null;
        XmlDocument xmldoc = new XmlDocument();
        XmlElement elem = xmldoc.CreateElement(TypeName, TypeListConverter.NameSpace);
        elem.InnerText = Value;
        return elem;
      }
    }

    #endregion public

    #region Private

    private bool IsEmpty => String.IsNullOrEmpty(Value);

    protected override string GetValueAsString()
    {
      return IsEmpty ? "<null>" : Value;
    }

    #endregion Private
  }
}