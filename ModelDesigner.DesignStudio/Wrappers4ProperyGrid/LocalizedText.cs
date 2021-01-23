//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using System.ComponentModel;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  /// <summary>
  /// Localized Text
  /// </summary>
  public class LocalizedText: OpcUaModelCompiler.LocalizedText
  {
    /// <summary>
    /// Determines whether this instance is empty (if any key or value is specified).
    /// </summary>
    /// <returns>
    /// 	<c>true</c> if this instance is empty; otherwise, <c>false</c>.
    /// </returns>
    public bool IsEmpty()
    {
      return string.IsNullOrEmpty( this.Key ) && string.IsNullOrEmpty( this.Value );
    }
    /// <summary>
    /// Updates this base on other localized text.
    /// </summary>
    /// <param name="value">The value.</param>
    public void UpdateBaseOnOtherLocalizedText( LocalizedText value )
    {
      if ( value == null )
        throw new ArgumentNullException( "value" );
      this.Value = value.Value;
      this.Key = value.Key;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="LocalizedText"/> class on the base of <see cref="OpcUaModelCompiler.LocalizedText"/>.
    /// </summary>
    /// <param name="source">The source.</param>
    public LocalizedText( OpcUaModelCompiler.LocalizedText source )
    {
      if ( source == null )
        return;
      this.Key = source.Key;
      this.Value = source.Value;
    }
    [
    NotifyParentPropertyAttribute( true ),
    DisplayName( "Key" ),
    BrowsableAttribute( true ),
    DescriptionAttribute( "The Key" )
    ]
    public new string Key
    {
      get { return base.Key; }
      set { base.Key = value; }
    }
    [
    NotifyParentPropertyAttribute( true ),
    DisplayName( "Value" ),
    BrowsableAttribute( true ),
    DescriptionAttribute( "The Value" )
    ]
    public new string Value
    {
      get { return base.Value; }
      set { base.Value = value; }
    }
    public override string ToString()
    {
      if ( this.Key != "" || this.Value != "" )
        return this.Key + ":" + this.Value;
      else
        return "(not set)";
    }
    /// <summary>
    /// Gets the source <see cref="OpcUaModelCompiler.LocalizedText"/> or null if empty.
    /// </summary>
    /// <value>The source.</value>
    [Browsable( false )]
    public OpcUaModelCompiler.LocalizedText Source
    {
      get
      {
        return ( String.IsNullOrEmpty( Key ) && String.IsNullOrEmpty( Value ) ) ? null : CreateSource();
      }
    }
    private OpcUaModelCompiler.LocalizedText CreateSource()
    {
      OpcUaModelCompiler.LocalizedText source = new OpcUaModelCompiler.LocalizedText();
      source.Key = Key;
      source.Value = Value;
      return source;
    }
  }
}
