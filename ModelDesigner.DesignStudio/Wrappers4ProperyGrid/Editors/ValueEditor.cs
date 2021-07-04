//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  public abstract class ValueEditor
  {
    #region constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="ValueEditor"/> class.
    /// </summary>
    /// <param name="typeName">Name of the type - one of the types defined in the <see cref="CAS.UA.Model.Designer.Types"/> namespace.</param>
    internal ValueEditor(string typeName)
    {
      TypeName = typeName;
    }

    #endregion constructor

    #region public

    /// <summary>
    /// Creates the value editor from an <see cref="XmlElement"/>.
    /// </summary>
    /// <param name="xmlElement">The <paramref name="xmlElement"/> containing the value to be edited.</param>
    /// <returns>Return <see cref="ValueEditor"/> containing the value to be edited.< </returns>
    internal static ValueEditor CreateValueEditor(XmlElement xmlElement)
    {
      if (xmlElement.LocalName.Trim().Equals(CAS.UA.Common.Types.ExtensionObject.LocalName))
      {
        CAS.UA.Common.Types.ExtensionObject eo = CAS.UA.Common.Types.ExtensionObject.GetExtensionObject(xmlElement);
        if (eo.Body == null)
          return new XmValueValueEditor();
        if (eo.Body.LocalName.Trim().Equals(RangeValueValueEditor.LocalName))
          return new RangeValueValueEditor(eo.Body);
        else
          return new XmValueValueEditor(eo.Body, eo.TypeId);
      }
      else
        return new XmlStandardValueEditor(xmlElement);
    }

    /// <summary>
    /// Gets or sets the name of the type.
    /// </summary>
    /// <value>The name of the type.</value>
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

    #endregion public

    #region private

    protected abstract string GetValueAsString();

    #endregion private
  }
}