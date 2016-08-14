//<summary>
//  Title   : Import Menu Factory
//  System  : Microsoft Visual C#
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

using CAS.UA.Model.Designer.ImportExport.Properties;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.ImportExport
{
  /// <summary>
  /// Import Menu Factory
  /// </summary>
  public static class ImportMenuFactory
  {

    /// <summary>
    /// Creates the import menu item.
    /// </summary>
    /// <returns></returns>
    public static IToolStripMenuItemInfo CreateImportMenuItem
    {
      get { return new ToolStripMenuItemInfo(Resources.CreateImportMenuItemName, Resources.CreateImportMenuItemText, Resources.CreateImportMenuItemToolTip); }
    }

  }
}
