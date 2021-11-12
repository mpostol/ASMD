//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System;
using System.ComponentModel;
using System.Xml;
using UAOOIOPCUACommon = UAOOI.OPCUA.Common;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
    /// <summary>
    /// The dedicated <see cref="ValueEditor"/> to be used to edit an object of type <see cref="CAS.UA.Model.Designer.Types.Range"/>.
    /// </summary>
    internal class RangeValueValueEditor : ValueEditor
    {
        #region creators

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueValueEditor"/> class.
        /// </summary>
        /// <param name="xmlElement">The XML element containing the value.</param>
        internal RangeValueValueEditor(XmlElement xmlElement)
          : base(xmlElement.Name)
        {
            m_Value = UAOOIOPCUACommon.Types.Range.CreateRange(xmlElement);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueValueEditor"/> class with a <see cref="CAS.UA.Model.Designer.Types.Range"/> entity initiated to default values.
        /// </summary>
        internal RangeValueValueEditor()
          : base(LocalName)
        {
            m_Value = new UAOOIOPCUACommon.Types.Range();
        }

        #endregion creators

        #region public properties

        /// <summary>
        /// Gets or sets the low value of the <see cref="CAS.UA.Model.Designer.Types.Range"/>.
        /// </summary>
        /// <value>The low.</value>
        [
          DisplayName("Low"),
          BrowsableAttribute(true),
          DescriptionAttribute("Low value of the Range. Property type is double."),
          NotifyParentPropertyAttribute(true)
        ]
        public double Low
        {
            get => this.m_Value.Low;
            set => this.m_Value.Low = value;
        }

        /// <summary>
        /// Gets or sets the high value of the <see cref="CAS.UA.Model.Designer.Types.Range"/>.
        /// </summary>
        /// <value>The high.</value>
        [
          DisplayName("High"),
          BrowsableAttribute(true),
          DescriptionAttribute("High value of the Range. Property type is double."),
          NotifyParentPropertyAttribute(true)
        ]
        public double High
        {
            get => this.m_Value.High;
            set => this.m_Value.High = value;
        }

        #endregion public properties

        #region public

        /// <summary>
        /// Name of the XML element representing an item of this type.
        /// </summary>
        internal static readonly string LocalName = typeof(UAOOIOPCUACommon.Types.Range).Name;

        /// <summary>
        /// Gets the XML element representing the current value.
        /// </summary>
        /// <value>The XML element.</value>
        internal override XmlElement XmlElement => m_Value.XmlElement;

        #endregion public

        #region private

        private const string m_Format = "<Low={0}, High={1}>";

        protected override string GetValueAsString()
        {
            return String.Format(m_Format, m_Value.Low, m_Value.High);
        }

        private UAOOIOPCUACommon.Types.Range m_Value;

        #endregion private
    }
}