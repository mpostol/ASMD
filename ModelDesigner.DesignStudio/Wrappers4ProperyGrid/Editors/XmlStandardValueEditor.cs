//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.ComponentModel;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  /// <summary>
  /// <see cref="ValueEditor"/> that is to be used to provide and edit values of standard XML types.
  /// </summary>
  internal class XmlStandardValueEditor : ValueEditor
  {
    #region constructor

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
      Element = xmlElement;
      Value = xmlElement.InnerText;
    }

    #endregion constructor

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
        if (string.IsNullOrEmpty(Value))
          return null;
        else if (Element == null)
        {
          XmlDocument xmldoc = new XmlDocument();
          Element = xmldoc.CreateElement("uax", TypeName, "http://opcfoundation.org/UA/2008/02/Types.xsd");
        }
        Element.InnerText = Value;
        return Element;
      }
    }

    #endregion public

    #region Private

    private XmlElement Element = null;

    protected override string GetValueAsString()
    {
      return Element == null ? "<null>" : $"{Element.InnerText}";
    }

    #endregion Private
  }
}