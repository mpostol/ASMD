//<summary>
//  Title   : Browse options
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Common.Types;
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.Wrappers
{
  public class BrowseOptions
  {
    /// <summary>
    /// Gets or sets the browse direction.
    /// </summary>
    /// <value>The browse direction.</value>
    BrowseDirection BrowseDirection { get; set; }

    /// <summary>
    /// Gets or sets the reference type design.
    /// </summary>
    /// <value>The reference type.</value>
    ReferenceTypeDesign ReferenceTypeDesign { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the subtypes are included.
    /// </summary>
    /// <value><c>true</c> if subtypes are included; otherwise, <c>false</c>.</value>
    bool IncludeSubtypes { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether node class mask is set.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if the node class mask is set; otherwise, <c>false</c>.
    /// </value>
    bool NodeClassMask { get; set; }

    /// <summary>
    /// Gets or sets the selected node class list.
    /// </summary>
    /// <value>The selected node class list.</value>
    List<string> SelectedNodeClassList{ get; set; }
    }
  }

