﻿//_______________________________________________________________
//  Title   : ProjectTreeNodeControl
//  System  : Microsoft VisualStudio 2015 / C#
//  $LastChangedDate:  $
//  $Rev: $
//  $LastChangedBy: $
//  $URL: $
//  $Id:  $
//
//  Copyright (C) 2017, CAS LODZ POLAND.
//  TEL: +48 608 61 98 99 
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls
{
  /// <summary>
  /// Class ProjectTreeNodeControl.
  /// </summary>
  /// <seealso cref="CAS.UA.Model.Designer.Controls.FileMenuProviderControl{CAS.UA.Model.Designer.Wrappers.IProjectModel, CAS.UA.Model.Designer.Wrappers.IBaseModel}" />
  internal class ProjectTreeNodeControl : FileMenuProviderControl<IProjectModel, IBaseModel>
  {

    #region constructor
    public ProjectTreeNodeControl(IProjectModel model) : base(model) { }
    #endregion

    #region FileMenuProviderControl
    protected override void New()
    {
      throw new NotImplementedException();
    }
    protected override void Open()
    {
      throw new NotImplementedException();
    }

    protected override void Save()
    {
      throw new NotImplementedException();
    }

    protected override void SaveAs()
    {
      throw new NotImplementedException();
    }
    #endregion

    #region private
    protected override void BeforeMenuStripOpening()
    {
      ToolStripMenuItem m_TSMI_remove = new ToolStripMenuItem("Remove project", Resources.delete);
      m_TSMI_remove.Click += RemoveClickHandler;
      //this.ContextMenuStrip = new ContextMenuStrip();
      this.ContextMenuStrip.Items.Add(m_TSMI_remove);
      base.BeforeMenuStripOpening();
    }
    private void RemoveClickHandler(object sender, EventArgs e)
    {
      string name = ModelEntity.Name;
      if (MessageBox.Show(string.Format(Resources.ProjectTreeNode_AreYouSureToRemove_text, name), Resources.ProjectTreeNode_AreYouSureToRemove_caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
        ModelEntity.Remove();
    }
    protected override BaseDictionaryTreeNode GetChildTreeNodeControl(IBaseModel node)
    {
      return node.GetTreeNode();
    }
    #endregion

  }
}
