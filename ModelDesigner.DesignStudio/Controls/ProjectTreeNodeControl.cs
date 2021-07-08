//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls
{
  /// <summary>
  /// Class ProjectTreeNodeControl.
  /// </summary>
  /// <seealso cref="CAS.UA.Model.Designer.Controls.FileMenuProviderControl{CAS.UA.Model.Designer.Wrappers.IProjectModel, CAS.UA.Model.Designer.Wrappers.IBaseModel}" />
  internal class ProjectTreeNodeControl : FileMenuProviderControl<IProjectModelView>
  {
    #region constructor

    public ProjectTreeNodeControl(IProjectModelView model) : base(model)
    {
    }

    #endregion constructor

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

    #endregion FileMenuProviderControl

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
      if (MessageBox.Show(string.Format(Resources.ProjectTreeNode_AreYouSureToRemove_text, name), Resources.ProjectTreeNode_AreYouSureToRemove_caption, System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
        ModelEntity.Remove();
    }

    #endregion private
  }
}