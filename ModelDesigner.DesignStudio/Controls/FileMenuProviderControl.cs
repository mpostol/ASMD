//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class FileMenuProviderControl<TModel> : BaseTreeNodeControl<TModel>
    where TModel : IBaseModel
  {
    public FileMenuProviderControl(TModel model) : base(model) { }
    /// <summary>
    /// Adds the items to menu.
    /// </summary>
    /// <param name="contextMenuStrip">The context menu strip.</param>
    internal virtual void AddItemsToMenu(ContextMenuStrip contextMenuStrip)
    {
      //TODO UA Server menu is empty #67
      ToolStripMenuItem _New = new ToolStripMenuItem();
      ToolStripMenuItem _Open = new ToolStripMenuItem();
      ToolStripMenuItem _Save = new ToolStripMenuItem();
      ToolStripMenuItem _SaveAs = new ToolStripMenuItem();
      // _New
      _New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      _New.Name = "Configuration New";
      _New.ShortcutKeys = Keys.Control | Keys.N;
      _New.Size = new System.Drawing.Size(175, 22);
      _New.Text = "&New";
      _New.ToolTipText = "Clear and create new configuration";
      _New.Click += OnNew_Click;
      // _Open
      _Open.Image = global::CAS.UA.Model.Designer.Properties.Resources.Open;
      _Open.Name = "Configuration Open";
      _Open.ShortcutKeys = Keys.Control | Keys.O;
      _Open.Size = new System.Drawing.Size(175, 22);
      _Open.Text = "&Open...";
      _Open.ToolTipText = "Read configuration from an XML.";
      _Open.Click += OnOpen_Click;
      // _Save
      _Save.Image = global::CAS.UA.Model.Designer.Properties.Resources.FloppyDisk;
      _Save.Name = "Configuration Save";
      _Save.ShortcutKeys = Keys.Control | Keys.S;
      _Save.Size = new Size(175, 22);
      _Save.Text = "&Save";
      _Save.ToolTipText = "Save configuration to an XML file.";
      if (SaveConstrain.IsLicensed)
        _Save.Click += OnSave_Click;
      else
      {
        _Save.ToolTipText = $"{_Save.ToolTipText} - {Resources.LicenseFeatureUnavailable}";
        _Save.Enabled = false;
      }
      // _SaveAs
      _SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      _SaveAs.Name = "Configuration Save As";
      _SaveAs.ShortcutKeys = Keys.Control | Keys.A;
      _SaveAs.Size = new System.Drawing.Size(175, 22);
      _SaveAs.Text = "Save &As...";
      _SaveAs.ToolTipText = "Open a prompt file name dialog and save the configuration to an XML in a specified location and specified file name.";
      if (SaveConstrain.IsLicensed)
        _SaveAs.Click += OnSaveAs_Click;
      else
      {
        _SaveAs.ToolTipText = $"{_SaveAs.ToolTipText} - {Resources.LicenseFeatureUnavailable}";
        _SaveAs.Enabled = false;
      }
      ToolStripItem[] m_MenuItems = new ToolStripItem[] { _New, _Open, _Save, _SaveAs };
      contextMenuStrip.Items.AddRange(m_MenuItems);
    }
    protected abstract void Open();
    protected abstract void New();
    protected abstract void Save();
    protected abstract void SaveAs();
    private void OnSaveAs_Click(object sender, EventArgs e)
    {
      SaveAs();
    }
    private void OnSave_Click(object sender, EventArgs e)
    {
      Save();
    }
    private void OnOpen_Click(object sender, EventArgs e)
    {
      Open();
    }
    private void OnNew_Click(object sender, EventArgs e)
    {
      New();
    }

  }
}
