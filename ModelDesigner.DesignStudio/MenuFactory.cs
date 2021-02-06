//___________________________________________________________________________________
//
//  Copyright (C) 2921, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________


using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer
{
  internal static class MenuFactory
  {
    internal static ToolStripMenuItem AddProject(EventHandler newProjectHandler, EventHandler existingProjectHandler)
    {
      ToolStripMenuItem _New = new ToolStripMenuItem("New");
      ToolStripMenuItem _Existing = new ToolStripMenuItem("Existing ...");
      if (newProjectHandler == null)
        _New.Enabled = false;
      else
        _New.Click += new EventHandler(newProjectHandler);
      if (existingProjectHandler == null)
        _Existing.Enabled = false;
      else
        _Existing.Click += new EventHandler(existingProjectHandler);
      return new ToolStripMenuItem("Add Project", null, new ToolStripMenuItem[] { _New, _Existing });
    }

    internal static ToolStripMenuItem ImportSubmenu(this IEnumerable<ToolStripMenuItem> items)
    {
      ToolStripMenuItem _importEntry = ImportExport.ImportMenuFactory.CreateImportMenuItem.CreateToolStripMenuItem();
      foreach (ToolStripMenuItem _menuItem in items)
        _importEntry.DropDownItems.Add(_menuItem);
      return _importEntry;
    }

    internal static ToolStripMenuItem ImportNodeSetMenuItem(EventHandler importHandler)
    {
      if (importHandler == null)
        throw new ArgumentNullException($"{nameof(importHandler)}");
      ToolStripMenuItem _menuItem = new ToolStripMenuItem()
      {
        Name = "ImportFromNodeSetMenuItemName",
        Text = Resources.ImportFromNodeSetMenuItemText,
        ToolTipText = Resources.ImportFromNodeSetMenuItemToolTip
      };
      _menuItem.Click += importHandler;
      return _menuItem;
    }

    internal static ToolStripMenuItem CreateToolStripMenuItem(this IToolStripMenuItemInfo toolStripMenuItemInfo)
    {
      return new ToolStripMenuItem() { Name = toolStripMenuItemInfo.Name, Text = toolStripMenuItemInfo.Text, ToolTipText = toolStripMenuItemInfo.ToolTipText };
    }
  }
}