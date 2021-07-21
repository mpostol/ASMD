//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using System.ComponentModel;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  /// <summary>
  /// XmlQualifiedName Editor
  /// </summary>
  public class XmlQualifiedNameEditor
  {
    #region private

    private static uint m_Counter = 0;
    private static string DefaultName => $"NameNotSet{m_Counter++}";
    private string m_Name;
    private string m_NameSpace;

    private string Normalize(string value)
    {
      return XmlConvert.EncodeLocalName(value.Trim()).Replace("_x", "X");
    }

    private void RaiseXmlQualifiedNameHasChanged()
    {
      if (XmlQualifiedNameHasChanged != null)
        XmlQualifiedNameHasChanged(this, EventArgs.Empty);
    }

    #endregion private

    #region public properties

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [
    DisplayName("Name"),
    BrowsableAttribute(true),
    DescriptionAttribute("The name"),
    NotifyParentPropertyAttribute(true)
    ]
    public string Name
    {
      get => m_Name;
      set
      {
        m_Name = Normalize(value);
        NameIsBasedOnDefault = false;
        RaiseXmlQualifiedNameHasChanged();
      }
    }

    /// <summary>
    /// Gets or sets the name space.
    /// </summary>
    /// <value>The name space.</value>
    [
    DisplayName("Namespace"),
    TypeConverter(typeof(NamespaceConverter)),
    BrowsableAttribute(true),
    DescriptionAttribute("The namespace"),
    NotifyParentPropertyAttribute(true)
    ]
    public string NameSpace
    {
      get
      {
        if (!IsEmpty && string.IsNullOrEmpty(m_NameSpace))
          return NamespaceProvider.GetTargetNamespace();
        return m_NameSpace;
      }
      set
      {
        m_NameSpace = value;
        NameIsBasedOnDefault = false;
        RaiseXmlQualifiedNameHasChanged();
      }
    }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is empty.
    /// </summary>
    /// <value><c>true</c> if this instance is empty; otherwise, <c>false</c>.</value>
    [
    DisplayName("Is Empty"),
    BrowsableAttribute(true),
    DescriptionAttribute("The value indicating whether this instance is empty."),
    NotifyParentPropertyAttribute(true)
    ]
    public bool IsEmpty => string.IsNullOrEmpty(m_Name) && string.IsNullOrEmpty(m_NameSpace);

    /// <summary>
    /// Gets or sets a value indicating whether name is based on default name.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if name is based on default name otherwise, <c>false</c>.
    /// </value>
    [BrowsableAttribute(false)]
    public bool NameIsBasedOnDefault { get; private set; }

    #endregion public properties

    #region public

    /// <summary>
    /// Updates the name and namespace based on passed value.
    /// </summary>
    /// <param name="value">The value.</param>
    public void UpdateNameAndNamespaceBasedOn(XmlQualifiedNameEditor value)
    {
      if (value == null)
        throw new ArgumentNullException("value");
      this.Name = value.Name;
      this.NameSpace = value.NameSpace;
    }

    /// <summary>
    /// Updates the name and namespace and namespace provider based on passed value.
    /// </summary>
    /// <param name="value">The value.</param>
    public void UpdateNameAndNamespaceAndNamespaceProviderBasedOn(XmlQualifiedNameEditor value)
    {
      this.UpdateNameAndNamespaceBasedOn(value);
      this.NamespaceProvider = value.NamespaceProvider;
    }

    /// <summary>
    /// Determines whether the name is empty or the name is null.
    /// </summary>
    /// <returns>
    /// 	<c>true</c> if the specified name is null; otherwise <c>false</c>.
    /// </returns>
    [BrowsableAttribute(false)]
    public bool IsNull => IsEmpty || string.IsNullOrEmpty(Name);

    /// <summary>
    /// Occurs when [XML qualified name has changed].
    /// </summary>
    public event EventHandler XmlQualifiedNameHasChanged;

    /// <summary>
    /// Gets the XmlQualifiedName edited by this editor.
    /// </summary>
    /// <value>The XmlQualifiedName or null if XmlQualifiedName is empty</value>
    [BrowsableAttribute(false)]
    public XmlQualifiedName XmlQualifiedName
    {
      get
      {
        if (!IsEmpty)
          return new XmlQualifiedName(Name, NameSpace);
        else
          return null; //XmlQualifiedNameEditor should not return empty XmlQualifiedName - only null is allowed
      }
    }

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
    /// </returns>
    public override string ToString()
    {
      if (!IsEmpty)
        return NameSpace + ":" + Name;
      else
        return "<not set>";
    }

    /// <summary>
    /// Gets or sets the namespace provider.
    /// </summary>
    /// <value>The namespace provider.</value>
    internal IXmlQualifiedNameEditorNamespaceProvider NamespaceProvider { get; private set; }

    /// <summary>
    /// Gets the name or generate if instance is null.
    /// </summary>
    /// <param name="qualifiedName">Name property of the qualified name or autogenerated identyfier.</param>
    /// <returns></returns>
    public static string GetNameOrGenerateIfInstanceIsNull(XmlQualifiedName qualifiedName)
    {
      return qualifiedName == null ? DefaultName : qualifiedName.Name;
    }

    /// <summary>
    /// Gets the namespace or generate if instance is null.
    /// </summary>
    /// <param name="qualifiedName">Namespace of the qualified neame or autogenerated identyfier.</param>
    /// <returns></returns>
    public static string GetNamespaceOrGenerateIfInstanceIsNull(XmlQualifiedName qualifiedName)
    {
      return qualifiedName == null ? DefaultName : qualifiedName.Namespace;
    }

    /// <summary>
    /// Creates the XML qualified name editor.
    /// </summary>
    /// <param name="namespaceProvider">The namespace provider.</param>
    /// <returns></returns>
    public static XmlQualifiedNameEditor CreateXmlQualifiedNameEditor(IXmlQualifiedNameEditorNamespaceProvider namespaceProvider)
    {
      return new XmlQualifiedNameEditor(DefaultName, string.Empty, namespaceProvider);
    }

    #endregion public

    #region creator

    /// <summary>
    /// Initializes a new instance of the <see cref="XmlQualifiedNameEditor"/> class. It does not create default names if <paramref name="xmlQualifiedName"/> is null.
    /// </summary>
    /// <param name="xmlQualifiedName">XmlQualifiedName to be edited.</param>
    /// <param name="namespaceProvider">The namespace provider.</param>
    public XmlQualifiedNameEditor(XmlQualifiedName xmlQualifiedName, IXmlQualifiedNameEditorNamespaceProvider namespaceProvider) :
      this(xmlQualifiedName, namespaceProvider, false)
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="XmlQualifiedNameEditor"/> class.
    /// </summary>
    /// <param name="xmlQualifiedName">XmlQualifiedName to be edited.</param>
    /// <param name="namespaceProvider">The namespace provider.</param>
    /// <param name="createDefault">if set to <c>true</c> assigns a default value for the <see cref="Name"/> parameter.
    /// </param>
    public XmlQualifiedNameEditor(XmlQualifiedName xmlQualifiedName, IXmlQualifiedNameEditorNamespaceProvider namespaceProvider, bool createDefault)
    {
      if (xmlQualifiedName != null)
      {
        Name = xmlQualifiedName.Name;
        m_NameSpace = xmlQualifiedName.Namespace;
      }
      else
      {
        m_Name = createDefault ? DefaultName : string.Empty;
        m_NameSpace = string.Empty;
        NameIsBasedOnDefault = createDefault;
      }
      NamespaceProvider = namespaceProvider;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="XmlQualifiedNameEditor"/> class with
    /// the specified name and namespace..
    /// </summary>
    /// <param name="name">The local name to use as the name of the System.Xml.XmlQualifiedName object.</param>
    /// <param name="ns">The namespace for the System.Xml.XmlQualifiedName object.</param>
    /// <param name="namespaceProvider">The namespace provider.</param>
    public XmlQualifiedNameEditor(string name, string ns, IXmlQualifiedNameEditorNamespaceProvider namespaceProvider)
    {
      Name = name;
      NameSpace = ns;
      NamespaceProvider = namespaceProvider;
    }

    #endregion creator
  }
}