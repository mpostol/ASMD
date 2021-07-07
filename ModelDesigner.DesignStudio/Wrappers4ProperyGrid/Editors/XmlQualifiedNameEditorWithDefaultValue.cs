//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.ComponentModel;
using System.Xml;
using UAOOI.Windows.Forms;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  /// <summary>
  /// Editor of the <see cref="XmlQualifiedName"/> that handles default values.
  /// </summary>
  public class XmlQualifiedNameEditorWithDefaultValue : XmlQualifiedNameEditor
  {
    #region private

    private XmlQualifiedName m_defaultValue;

    #endregion private

    #region public properties

    /// <summary>
    /// Gets the default value.
    /// </summary>
    /// <value>The default value.</value>
    [
    DisplayName("Default value"),
    BrowsableAttribute(true),
    DescriptionAttribute("The default value"),
    NotifyParentPropertyAttribute(true),
    ReadOnlyAttribute(true)
    ]
    public string DefaultValue => m_defaultValue.ToString();

    #endregion public properties

    #region constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="XmlQualifiedNameEditorWithDefaultValue"/> class.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="namespaceProvider">The namespace provider.</param>
    /// <param name="defaultValue">The default value.</param>
    internal XmlQualifiedNameEditorWithDefaultValue(XmlQualifiedName value, IXmlQualifiedNameEditorNamespaceProvider namespaceProvider, XmlQualifiedName defaultValue)
      : base(value, namespaceProvider)
    {
      m_defaultValue = defaultValue;
    }

    #endregion constructors

    #region public

    internal XmlQualifiedName ValueOrDefault
    {
      get
      {
        if (IsEmpty)
          return m_defaultValue;
        else
          return base.XmlQualifiedName;
      }
    }

    #endregion public
  }
}