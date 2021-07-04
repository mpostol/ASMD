//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  /// <summary>
  /// The class represents null value
  /// </summary>
  internal class NotSetValueEditor : ValueEditor
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="NotSetValueEditor"/> class.
    /// </summary>
    public NotSetValueEditor()
      : base(LocalName)
    { }

    /// <summary>
    /// Label to be used in the drop down list.
    /// </summary>
    internal const string LocalName = "<Not set>";

    /// <summary>
    /// Gets the XML element representing the current value.
    /// </summary>
    /// <value>The XML element.</value>
    internal override XmlElement XmlElement => null;

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
}