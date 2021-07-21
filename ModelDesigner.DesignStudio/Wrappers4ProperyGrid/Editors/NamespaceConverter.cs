//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System;
using System.ComponentModel;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors
{
  /// <summary>
  /// This class is used in DataTypeConverter drop-down list
  /// </summary>
  internal class NamespaceConverter : StringConverter
  {
    #region TypeConverter

    /// <summary>
    /// Gets a value indicating whether this object supports a standard set of values that can be picked from a list.
    /// </summary>
    /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. </param>
    /// <returns>Always returns <b>true</b> - means show a combo-box </returns>
    public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
    {
      //true means show a combo-box
      return true;
    }

    /// <summary>
    /// Gets a value indicating whether the list of standard values returned from the GetStandardValues method is an exclusive list.
    /// </summary>
    /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. </param>
    /// <returns>Always returns <b>true</b> - means it limits to list</returns>
    public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
    {
      //true will limit to list. false will show the list, but allow free-form entry
      return false;
    }

    /// <summary>
    /// Gets a collection of standard values for the data type this validator is designed for.
    /// </summary>
    /// <param name="context">An <see cref="ITypeDescriptorContext"/> that provides a format context. </param>
    /// <returns>A <see cref="TypeConverter.StandardValuesCollection"/>  that holds a standard set of valid values </returns>
    public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
    {
      if (context == null)
        throw new ArgumentNullException(nameof(context));
      XmlQualifiedNameEditor editor = context.Instance as XmlQualifiedNameEditor;
      if (editor != null && editor.NamespaceProvider != null)
        return new StandardValuesCollection(editor.NamespaceProvider.GetAvailiableNamespaces());
      return new StandardValuesCollection(new string[0]);
    }

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      if (destinationType == typeof(string))
        return true;
      return base.CanConvertTo(context, destinationType);
    }

    public override bool IsValid(ITypeDescriptorContext context, object value)
    {
      return base.IsValid(context, value);
    }

    #endregion TypeConverter
  }
}