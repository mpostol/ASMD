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
  /// Editor for Default Value inside Variable and Property wrapper
  /// </summary>
  public class VariableValueEditor
  {
    #region constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="VariableValueEditor"/> class.
    /// </summary>
    /// <param name="xmlElement">A default value as the XML element.</param>
    public VariableValueEditor(XmlElement xmlElement)
    {
      if (xmlElement != null)
        this.Editor = ValueEditor.CreateValueEditor(xmlElement);
      else
        this.Editor = new NotSetValueEditor();
    }

    #endregion constructor

    #region public properties

    /// <summary>
    /// Gets or sets the value. For dialog user it is exposed as drop-down list with all available types.
    /// </summary>
    /// <value>The current value.</value>
    [
    DisplayName("Selected type"),
    TypeConverter(typeof(TypeListConverter)),
    BrowsableAttribute(true),
    DescriptionAttribute("Select the type of the value from the drop-down list and edit the current value. After selecting new type the value is cleared."),
    NotifyParentPropertyAttribute(true)
    ]
    public ValueEditor Editor { get; set; }

    #endregion public properties

    #region public

    /// <summary>
    /// Gets the <see cref="XmlElement"/> as the value edited by this editor.
    /// </summary>
    /// <value>The <see cref="XmlElement"/> or null if the value is empty</value>
    internal XmlElement XmlElement => Editor.XmlElement;

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
      return Editor is NotSetValueEditor;
    }

    /// <summary>
    /// Updates the value stored in the editor based on other variable from other value editor.
    /// </summary>
    /// <param name="value">The value.</param>
    public void UpdateValueBasedOnOtherVariableValueEditor(VariableValueEditor value)
    {
      this.Editor = value.Editor.Clone();
    }

    #endregion public

    #region private

    private static uint m_Counter = 0;

    private static uint GetCounter()
    {
      return m_Counter++;
    }

    #endregion private
  }
}