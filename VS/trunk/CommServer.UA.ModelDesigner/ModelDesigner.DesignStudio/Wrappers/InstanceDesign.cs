//<summary>
//  Title   : Instance Design Wrapper
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.IServerConfiguration;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Types;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal abstract class InstanceDesign<type, OPCType> : NodeDesign<type, OPCType>, IInstanceNode
    where type : Wrappers4ProperyGrid.InstanceDesign<OPCType>, IInstanceDesign
    where OPCType : Opc.Ua.ModelCompiler.InstanceDesign, new()
  {
    #region creators
    protected InstanceDesign(type child)
      : base(child)
    { }
    protected InstanceDesign(type child, OPCType node)
      : base(child, node)
    { }
    #endregion

    #region private
    protected new abstract class TreeNode<T> : NodeDesign<type, OPCType>.TreeNode<T>, IInstanceDesignTreeNode
      where T : InstanceDesign<type, OPCType>
    {
      #region creator
      public TreeNode(T parent)
        : base(parent)
      { }
      #endregion

      #region public
      internal override Dictionary<string, System.Xml.XmlQualifiedName> GetCoupledNodesXmlQualifiedNames()
      {
        var list = base.GetCoupledNodesXmlQualifiedNames();
        if (Creator.Wrapper.TypeDefinition.XmlQualifiedName != null && !Creator.Wrapper.TypeDefinition.XmlQualifiedName.IsEmpty)
          list.Add(Resources.WrapperTreeNodeAddMenuItemGoto_TypeDefinition,
             Creator.Wrapper.TypeDefinition.XmlQualifiedName);
        return list;
      }
      /// <summary>
      /// Gets the unique identifier.
      /// </summary>
      /// <param name="ui">The instance of <see cref="UniqueIdentifier"/> that represents an unique identifier.</param>
      /// <returns>
      /// 	<c>true</c> if it is not top level element; <c>false</c> othervise if it is top level element
      /// </returns>
      internal override bool GetUniqueIdentifier(UniqueIdentifier ui)
      {
        bool intermediate = base.GetUniqueIdentifier(ui);
        ui.Update(intermediate, Creator.Wrapper.SymbolicName.XmlQualifiedName, false);
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
        m_InstanceConfiguration = Root.GetInstanceConfiguration(Creator.Wrapper.GetINodeDescriptor(ui, Creator.NodeClass));
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
          Text = String.Format(Resources.ConfigurationWrapper_Configuration_Text, this.Text),
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
        TreeView.GoToNode(Creator.Wrapper.TypeDefinition.XmlQualifiedName);
      }
      private IInstanceConfiguration m_InstanceConfiguration;
      #region Menu handlers
      private void new_Click(object sender, EventArgs e)
      {
        if (m_InstanceConfiguration == null)
          return;
        //TODO Display worning
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

    }//TreeNode
    protected override void AddNodeDescriptors(List<INodeDescriptor> dsptrs, UniqueIdentifier ui)
    {
      ui.Update(false, Wrapper.SymbolicName.XmlQualifiedName, false);
      base.AddNodeDescriptors(dsptrs, ui);
    }
    /// <summary>
    /// Adds to address space.
    /// </summary>
    /// <param name="children">The children.</param>
    /// <returns></returns>
    protected void InstanceDeclarations(IInstanceNodesCollection children, IInstanceNodeContext thisInstance)
    {
      //Methods do not have equivalent of type definition reference.
      if (this.NodeClass == NodeClassesEnum.Method)
        return;
      ITypeDesign type = Root.FindType(thisInstance.TypeDefinition);
      if ( type == null)
      {
        thisInstance.Assert(false, "Cannot find TypeDefinition for the instance.");
        return;
      }
      type.InstanceDeclarations(children, thisInstance);
    }
    /// <summary>
    /// Adds this instance to the address space.
    /// </summary>
    /// <param name="space">The space.</param>
    /// <returns></returns>
    protected override void AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      space.AddNode2AddressSpace(this);
    }
    #endregion

    #region public
    public override string CalculateReferenceRelativeName(string targetIdName)
    {
      if (Parent == null)
        return targetIdName;
      ChildrenFolder parent = this.Parent as ChildrenFolder;
      if (parent == null)
        return targetIdName;
      return (parent.CalculateReferenceRelativeName(targetIdName));
    }
    /// <summary>
    /// Gets the node descriptors.
    /// </summary>
    /// <returns>
    /// Instance of <see cref="INodeDescriptor"/> containing node descriptor.
    /// </returns>
    internal override INodeDescriptor[] GetNodeDescriptors()
    {
      List<INodeDescriptor> dsptrs = new List<INodeDescriptor>();
      UniqueIdentifier ui = new UniqueIdentifier();
      AddNodeDescriptors(dsptrs, ui);
      return dsptrs.ToArray();
    }
    /// <summary>
    /// Retrieves aa instance of the interface <see cref="INodeDescriptor"/> that provides the description of the node to be
    /// bind with an external data source.
    /// </summary>
    /// <param name="UniqueIdentifierOfRequestedWrapper">The unique identifier of requested node descriptor.</param>
    /// <returns>
    /// An instance of the interface <see cref="INodeDescriptor"/> to be bound with external data source.
    /// </returns>
    internal override INodeDescriptor GetINodeDescriptor(UniqueIdentifier UniqueIdentifierOfRequestedWrapper)
    {
      return Wrapper.GetINodeDescriptor(UniqueIdentifierOfRequestedWrapper, NodeClass);
    }
    #endregion

    #region IInstanceNode Members
    /// <summary>
    /// Adds all references for an instance declaration recursively.
    /// </summary>
    /// <param name="references">The references collection already collected traversing the inheritance chain.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    void IInstanceNode.AddAllReferences4InstanceDeclaration(IInstanceReferencesCollection references, XmlQualifiedName typeParentID)
    {
      foreach (Reference item in References)
        references.AddReference(item, this, typeParentID);
    }
    IInstanceDesign IInstanceNode.DerivePropertyValuesFrom(IInstanceDesign source)
    {
      return this.Wrapper.DerivePropertyValuesFrom(source);
    }
    /// <summary>
    /// Processes the node.
    /// </summary>
    /// <param name="space">The address space.</param>
    /// <param name="nodeContext">The parent.</param>
    /// <param name="modelParent">The model parent.</param>
    /// <param name="isInstanceDeclaration">if set to <c>true</c> it is instance declaration.</param>
    void IInstanceNode.CompileNode(IAddressSpaceCreator space, IInstanceNodeContext nodeContext, bool isInstanceDeclaration)
    {
      IInstanceNodesCollection children = AddChildren(space, nodeContext.NodeID, nodeContext.AddressSpaceIndex, isInstanceDeclaration);
      InstanceDeclarations(children, nodeContext);
      children.RegisterChildrenInAddressSpace();
      foreach (Reference item in this.References)
        space.AddReference(nodeContext.AddressSpaceIndex, item.Wrapper.ReferenceType.XmlQualifiedName, item.Wrapper.IsInverse, item.Wrapper.TargetId.XmlQualifiedName);
      space.AddReference(nodeContext.AddressSpaceIndex, BuildInXmlQualifiedNames.HasTypeDefinition, false, nodeContext.TypeDefinition);
      nodeContext.AddModelingRule();
    }
    /// <summary>
    /// Determines whether this instance is mandatory.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance has associated mandatory modeling rule; otherwise, <c>false</c>.
    /// </value>
    bool IInstanceNode.IsMandatory { get { return this.Wrapper.IsMandatory; } }
    #endregion
  }
  /// <summary>
  /// Dedicated InstanceDesign interface to be used to represent this TreeNode in the user interface
  /// </summary>
  internal interface IInstanceDesignTreeNode
  {
    /// <summary>
    /// Gets the server UA menu.
    /// </summary>
    /// <param name="items">The items collection to expand.</param>
    void GetServerUAMenu(ToolStripItemCollection items);
  }
}

