//<summary>
//  Title   : SelectedItemEventArgs - arguments for event when item is selected
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

using System;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// SelectedItemEventArgs - arguments for event when item is selected
  /// This event passes SelectedItemEventArgs as argument. 
  /// This argument contains information about: IModelNode, UniqueIdentifier and IsOnlyModification. 
  /// IModelNode contains selected node. 
  /// UniqueIdentifier contains unique identifier of node on the tree 
  /// (this is used for DataBindings)
  /// (the client of the event calls IModelNode.GetWrapper4DataBindingsPropertyGrid 
  /// to get the data binding editor for property grid) . 
  /// IsOnlyModification is set to true if selected item has not change but it was modified 
  /// (e.g. by the property grid)
  /// </summary>
  internal class SelectedItemEventArgs: EventArgs
  {
    internal IModelNode SelectedIModelNode { get; private set; }
    internal bool IsOnlyModification { get; private set; }
    internal SelectedItemEventArgs( IModelNode SelectedIModelNode, bool IsOnlyModification )
    {
      this.SelectedIModelNode = SelectedIModelNode;
      this.IsOnlyModification = IsOnlyModification;
    }
  }
}
