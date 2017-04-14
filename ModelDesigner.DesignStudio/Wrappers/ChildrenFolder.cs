//<summary>
//  Title   : ChildrenFolder 
//  System  : Microsoft VisualStudio 2013 / C#
//  $LastChangedDate:$
//  $Rev:$
//  $LastChangedBy:$
//  $URL:$
//  $Id:$
//
//  Copyright (C) 2014, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Properties;
using System.Collections.Generic;
using OpcUaModelCompiler = Opc.Ua.ModelCompiler;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Class ChildrenFolder - a folder collecting nodes with HasComponent and HasProperty references.
  /// </summary>
  internal class ChildrenFolder : Folder
  {
    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="ChildrenFolder"/> class.
    /// </summary>
    public ChildrenFolder()
      : base(WrapperResources.ChildrenFolderText, WrapperResources.ChildrenFolderToolTip)
    {
      TypesAvailableToBePasted.Add(typeof(OpcUaModelCompiler.InstanceDesign));
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="ChildrenFolder"/> class.
    /// </summary>
    /// <param name="child">The collection of children - nodes referenced by HasComponent and HasProperty.</param>
    public ChildrenFolder(Opc.Ua.ModelCompiler.ListOfChildren child)
      : this()
    {
      if (child == null || child.Items == null || child.Items.Length == 0)
        return;
      foreach (Opc.Ua.ModelCompiler.InstanceDesign item in child.Items)
        this.Add(NodeFactory.Create(item));
    }
    #endregion

    #region public
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_ChildrenFolder; }
    }
    internal OpcUaModelCompiler.ListOfChildren CreateNodes
    {
      get
      {
        if (Count == 0)
          return null;
        var list = new OpcUaModelCompiler.ListOfChildren { };
        list.Items = new OpcUaModelCompiler.InstanceDesign[Count];
        int ii = 0;
        foreach (IParent node in this)
          list.Items[ii++] = (Opc.Ua.ModelCompiler.InstanceDesign)node.ModelDesignerNode;
        return list;
      }
    }
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    internal override DictionaryTreeView.DictionaryTreeNode GetTreeNode()
    {
      return new TreeNode(this);
    }
    /// <summary>
    /// Calculates a relative name of the reference.
    /// </summary>
    /// <param name="targetIdName">Name of the target identifier.</param>
    /// <returns>System.String.</returns>
    internal string CalculateReferenceRelativeName(string targetIdName)
    {
      return ((INodeDesign)this.Parent).CalculateReferenceRelativeName(targetIdName);
    }
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.ChildrenFolderNode; }
    }
    #endregion

    #region private
    protected virtual INodeFactory[] ListOfNodes
    {
      get
      {
        List<INodeFactory> m_list = new List<INodeFactory>();
        m_list.Add(new TypeListItem<MethodDesign>());
        m_list.Add(new TypeListItem<ObjectDesign>());
        m_list.Add(new TypeListItem<PropertyDesign>());
        m_list.Add(new TypeListItem<VariableDesign>());
        return m_list.ToArray();
      }
    }
    private class TreeNode : Folder.TreeNode<ChildrenFolder>
    {
      public TreeNode(ChildrenFolder parent)
        : base(parent)
      { }
      protected override void BeforeMenuStripOpening()
      {
        AddMenuItemPaste();
        AddMenuItemAdd(Creator.ListOfNodes);
        base.BeforeMenuStripOpening();
      }
    }
    #endregion
  }
}
