//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.IServerConfiguration;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CAS.UA.Model.Designer.Controls
{
  internal abstract class InstanceDesignTreeNodeControl<T, type, OPCType> : NodeDesignTreeNodeControl<T, type, OPCType>, IInstanceDesignTreeNode
    where type : Wrappers4ProperyGrid.InstanceDesign<OPCType>, IInstanceDesign
    where OPCType : Opc.Ua.ModelCompiler.InstanceDesign, new()
    where T : InstanceDesign<type, OPCType>
  {

    #region constructor
    public InstanceDesignTreeNodeControl(T parent) : base(parent) { }
    #endregion

    #region public
    internal override Dictionary<string, System.Xml.XmlQualifiedName> GetCoupledNodesXmlQualifiedNames()
    {
      Dictionary<string, System.Xml.XmlQualifiedName> list = base.GetCoupledNodesXmlQualifiedNames();
      if (ModelEntity.Wrapper.TypeDefinition.XmlQualifiedName != null && !ModelEntity.Wrapper.TypeDefinition.XmlQualifiedName.IsEmpty)
        list.Add(Resources.WrapperTreeNodeAddMenuItemGoto_TypeDefinition, ModelEntity.Wrapper.TypeDefinition.XmlQualifiedName);
      return list;
    }
    /// <summary>
    /// Gets the unique identifier.
    /// </summary>
    /// <param name="ui">The instance of <see cref="UniqueIdentifier"/> that represents an unique identifier.</param>
    /// <returns>
    /// 	<c>true</c> if it is not top level element; <c>false</c> otherwise if it is top level element
    /// </returns>
    internal override bool GetUniqueIdentifier(UniqueIdentifier ui)
    {
      bool intermediate = base.GetUniqueIdentifier(ui);
      ui.Update(intermediate, ModelEntity.Wrapper.SymbolicName.XmlQualifiedName, false);
      return true;
    }
    #endregion

    #region IInstanceDesign Members
    public void GetServerUAMenu(ToolStripItemCollection items)
    {
      GetInstanceMenuItems(items);
    }
    #endregion

    #region private
    protected override void BeforeMenuStripOpening()
    {
      UniqueIdentifier ui = new UniqueIdentifier();
      GetUniqueIdentifier(ui);
      m_InstanceConfiguration = SolutionTreeNode.SolutionRoot.GetInstanceConfiguration(ModelEntity.Wrapper.GetINodeDescriptor(ui, ModelEntity.NodeClass));
      AddMenuItemGoTo(Resources.WrapperTreeNodeAddMenuItemGoto
        + Resources.WrapperTreeNodeAddMenuItemGoto_TypeDefinition,
        Resources.WrapperTreeNodeAddMenuItemGoto_TypeDefinition_tooltip,
        new EventHandler(AddMenuItemGoTo_Click));
      GetInstanceMenuItems(this.ContextMenuStrip.Items);
      base.BeforeMenuStripOpening();
    }
    private void GetInstanceMenuItems(ToolStripItemCollection menu)
    {
      bool enabled = m_InstanceConfiguration != null;
      if (menu.Count > 0)
        menu.Add(new ToolStripSeparator());
      ToolStripMenuItem item = new ToolStripMenuItem()
      {
        Text = string.Format(Resources.ConfigurationWrapper_Configuration_Text, this.Text),
        ToolTipText = Resources.ConfigurationWrapper_Configuration_ToolTip
      };
      menu.Add(item);
      ToolStripMenuItem subItem = new ToolStripMenuItem()
      {
        Text = Resources.ConfigurationWrapper_Configuration_Edit_Text,
        ToolTipText = Resources.ConfigurationWrapper_Configuration_Edit_ToolTip,
        Enabled = enabled
      };
      item.DropDown.Items.Add(subItem);
      subItem.Click += new EventHandler(edit_Click);
      subItem = new ToolStripMenuItem()
      {
        Text = Resources.ConfigurationWrapper_Configuration_New_Text,
        ToolTipText = Resources.ConfigurationWrapper_Configuration_New_ToolTip,
        Enabled = enabled
      };
      item.DropDown.Items.Add(subItem);
      subItem.Click += new EventHandler(new_Click);
    }
    private void AddMenuItemGoTo_Click(object sender, System.EventArgs e)
    {
      TreeView.GoToNode(ModelEntity.Wrapper.TypeDefinition.XmlQualifiedName);
    }
    private IInstanceConfiguration m_InstanceConfiguration;

    #region Menu handlers
    private void new_Click(object sender, EventArgs e)
    {
      if (m_InstanceConfiguration == null)
        return;
      //TODO Display worming
      m_InstanceConfiguration.ClearConfiguration();
    }
    private void edit_Click(object sender, EventArgs e)
    {
      if (m_InstanceConfiguration == null)
        return;
      m_InstanceConfiguration.Edit();
    }
    #endregion

    #endregion

  }
}
