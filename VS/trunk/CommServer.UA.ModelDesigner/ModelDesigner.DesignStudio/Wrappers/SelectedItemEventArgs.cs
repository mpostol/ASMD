//_______________________________________________________________
//  Title   : SelectedItemEventArgs - arguments for event when an item is selected.
//  System  : Microsoft VisualStudio 2015 / C#
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2017, CAS LODZ POLAND.
//  TEL: +48 608 61 98 99 
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

using System;

namespace CAS.UA.Model.Designer.Wrappers
{
  //TODO - to be moved to Controls

  /// <summary>
  /// SelectedItemEventArgs - arguments for event when an item is selected.
  /// </summary>
  /// <seealso cref="System.EventArgs" />
  internal class SelectedItemEventArgs: EventArgs
  {
    /// <summary>
    /// Gets the selected <see cref="IModelNode"/> representing a model node.
    /// </summary>
    /// <value>The selected i model node.</value>
    internal IModelNode SelectedIModelNode { get; private set; }
    /// <summary>
    /// Gets a value indicating whether this instance is only modification.
    /// </summary>
    /// <value><c>true</c> if this instance is only modification, i.e it was onmy edited (e.g. by the property grid); otherwise, <c>false</c>.</value>
    internal bool IsOnlyModification { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SelectedItemEventArgs"/> class.
    /// </summary>
    /// <param name="SelectedIModelNode">The selected item of <see cref="IModelNode"/> representing a model node.</param>
    /// <param name="IsOnlyModification">if set to <c>true</c> it is only content modification.</param>
    internal SelectedItemEventArgs( IModelNode SelectedIModelNode, bool IsOnlyModification )
    {
      this.SelectedIModelNode = SelectedIModelNode;
      this.IsOnlyModification = IsOnlyModification;
    }
  }
}
