//_______________________________________________________________
//  Title   : ToolStripMenuItemInfo
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
  internal class ToolStripMenuItemInfo : IToolStripMenuItemInfo
  {
    public ToolStripMenuItemInfo(string name, string text, string toolTipText)
    {
      Name = name;
      Text = text;
      ToolTipText = toolTipText;
    }
    public string Name
    {
      get;
      private set;
    }
    public string Text
    {
      get;
      private set;
    }
    public string ToolTipText
    {
      get;
      private set;
    }
  }
}
