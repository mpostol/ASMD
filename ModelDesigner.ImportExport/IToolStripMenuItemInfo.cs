//_______________________________________________________________
//  Title   : IToolStripMenuItemInfo
//  System  : Microsoft VisualStudio 2013 / C#
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2015, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

namespace CAS.UA.Model.Designer.ImportExport
{
  /// <summary>
  /// Menu Item Info provider
  /// </summary>
  public interface IToolStripMenuItemInfo
  {

    /// <summary>
    /// Gets the name of the item. The Name property can be used as a key into a Collection.
    /// </summary>
    /// <value><see cref="string" /> representing the name. The default value is null.</value>
    string Name { get; }
    /// <summary>
    /// Gets the text that is to be displayed on the item.
    /// </summary>
    /// <value>
    /// A string representing the item's text. The default value is the empty string ("").
    /// </value>
    string Text { get; }
    /// <summary>
    /// Gets or sets the text that appears as a ToolTip for a control.
    /// </summary>
    /// <value>
    /// A string representing the ToolTip text.
    /// </value>
    string ToolTipText { get; }

  }
}
