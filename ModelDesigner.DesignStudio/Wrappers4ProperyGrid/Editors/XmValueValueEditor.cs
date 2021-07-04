//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  internal class XmValueValueEditor : ValueEditor
  {
    #region creator

    /// <summary>
    /// Initializes a new instance of the <see cref="XmValueValueEditor"/> class.
    /// </summary>
    /// <param name="body">The body of element of type any.</param>
    /// <param name="expandedNodeId">The expanded NodeId.</param>
    public XmValueValueEditor(XmlElement body, CAS.UA.Common.Types.ExpandedNodeId expandedNodeId)
      : base(body.Name)
    {
      XmlText = body.OuterXml;
      NodeId = expandedNodeId.Identifier;
    }

    #endregion creator

    #region Properties

    /// <summary>
    /// Initializes a new empty instance of the <see cref="XmValueValueEditor"/> class.
    /// </summary>
    internal XmValueValueEditor()
      : base(LocalName)
    { }

    [
      DisplayName("Xml Content"),
      BrowsableAttribute(true),
      DescriptionAttribute("Content of the XML element to encapsulated by the ExtensionObject"),
      NotifyParentPropertyAttribute(true)
    ]
    [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
    public string XmlText { get; set; }

    [
      DisplayName("NodeId"),
      BrowsableAttribute(true),
      DescriptionAttribute("Stores an identifier for a node in a server's address space. Please refer to OPC UA Specifications: Address Space Model"),
      NotifyParentPropertyAttribute(true)
    ]
    public string NodeId { get; set; }

    #endregion Properties

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
        if (xmldoc == null)
          return null;
        return CAS.UA.Common.Types.ExtensionObject.GetXmlElement(NodeId, xmldoc.DocumentElement);
      }
    }

    #endregion public

    #region private

    private XmlDocument CreateXml()
    {
      if (IsEmpty)
        return null;
      XmlDocument xmldoc = new XmlDocument();
      try
      {
        xmldoc.LoadXml(XmlText);
      }
      catch (Exception ex)
      {
        XmlElement ee = xmldoc.CreateElement("Error");
        xmldoc.AppendChild(ee);
        XmlElement eex = xmldoc.CreateElement("XmlContent");
        eex.InnerText = XmlText;
        ee.AppendChild(eex);
        XmlNode xc = xmldoc.CreateComment(ex.Message);
        ee.AppendChild(xc);
      }
      return xmldoc;
    }

    private bool IsEmpty => String.IsNullOrEmpty(XmlText);

    /// <summary>
    /// Gets the value as string.
    /// </summary>
    protected override string GetValueAsString()
    {
      return IsEmpty ? "<null>" : CreateXml().InnerText;
    }

    #endregion private
  }
}