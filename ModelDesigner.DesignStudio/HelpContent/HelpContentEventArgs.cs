//<summary>
//  Title   : Help Content argument and delegate
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System;

namespace CAS.UA.Model.Designer.HelpContent
{
  internal partial class HelpContentEventArgs: EventArgs
  {
    /// <summary>
    /// The name of the content
    /// </summary>
    public readonly string Name;
    /// <summary>
    /// Initializes a new instance of the <see cref="HelpContentEventArgs"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    public HelpContentEventArgs( string name )
    {
      Name = name;
    }
  }
  /// <summary>
  /// Handler of the HelpContentShouldBeChanged event.
  /// </summary>
  internal delegate void HelpContentShouldBeChangedHandler( object sender, HelpContentEventArgs HelpContentArguments );
}