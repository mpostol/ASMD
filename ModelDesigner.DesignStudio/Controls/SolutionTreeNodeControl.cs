//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls
{
  internal class SolutionTreeNodeControl : FileMenuProviderControl<ISolutionModel>
  {

    #region constructor
    public SolutionTreeNodeControl(ISolutionModel model) : base(model)
    {
      SaveConstrain.CheckConstrain();
    }
    #endregion

    #region private
    /// <summary>
    /// Before the menu strip opening.
    /// </summary>
    protected override void BeforeMenuStripOpening()
    {
      AddItemsToMenu(this.ContextMenuStrip);
      GetPluginMenuItems(this.ContextMenuStrip.Items);
      base.BeforeMenuStripOpening();
    }
    private void GetPluginMenuItems(ToolStripItemCollection items)
    {
      ModelEntity.GetPluginMenuItems(items);
    }
    internal override void AddItemsToMenu(ContextMenuStrip contextMenuStrip)
    {
      base.AddItemsToMenu(contextMenuStrip);
      if (contextMenuStrip.Items.Count > 0)
        contextMenuStrip.Items.Add(new ToolStripSeparator());
      contextMenuStrip.Items.Add(MenuFactory.AddProject(AddNewProjectHandler, AddExistingProjectHandler));
      contextMenuStrip.Items.Add(MenuFactory.ImportSubmenu(new ToolStripMenuItem[] { MenuFactory.ImportNodeSetMenuItem(ImportNodeSetHandler) }));
    }
    private void AddNewProjectHandler(object sender, System.EventArgs e)
    {
      ModelEntity.AddProject(false);
    }
    private void AddExistingProjectHandler(object sender, System.EventArgs e)
    {
      ModelEntity.AddProject(true);
    }
    private void ImportNodeSetHandler(object sender, EventArgs e)
    {
      ModelEntity.ImportNodeSet();
    }
    #endregion

    #region FileMenuProviderControl
    protected override void SaveAs()
    {
      ModelEntity.Save(true);
    }
    protected override void Open()
    {
      ModelEntity.Open();
    }
    protected override void New()
    {
      ModelEntity.OnNew();
    }
    protected override void Save()
    {
      ModelEntity.Save(false);
    }
    //TODO Refactoring application architecture - remove recursion #6
    protected override void AddChildren(ISolutionModel parent)
    {
      throw new NotImplementedException();
    }
    //protected override BaseDictionaryTreeNode GetChildTreeNodeControl(IProjectModel node)
    //{
    //  return new ProjectTreeNodeControl(node);
    //}
    #endregion

  }
}
