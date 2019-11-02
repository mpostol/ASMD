//<summary>
//  Title   : Wrapper of the NodeDesin class - is to be used as object for PropertyGrid
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

using CAS.UA.Model.Designer.Properties;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{

  /// <summary>
  /// Used to represent an instance of the <see cref="NodeDesign<type, OPCType>"/> while casting
  /// </summary>
  internal interface INodeDesign
  {

    /// <summary>
    /// Adds the node to the address space <see cref="IAddressSpaceCreator"/>.
    /// </summary>
    /// <param name="space">The space.</param>
    void AddNode2AddressSpace(IAddressSpaceCreator space);
    /// <summary>
    /// Gets the symbolic name of the node.
    /// </summary>
    /// <value>The name of the symbolic.</value>
    XmlQualifiedName SymbolicName { get; }
    /// <summary>
    /// Calculates a relative name of the hierarchical reference -it is the symbolic name defined as the BrowseName, or, when it is part of another node, the BrowseName of the parent node, a "_", and the BrowseName of itself. 
    /// In this case "part of" means that the whole has a HasProperty or HasComponent reference to its part. Since all nodes not being part of another node have a unique name, the symbolic name is unique. 
    /// </summary>
    /// <param name="targetIdName">Symbolic name - an identifier calculated as the dash separated unique browse path of the target.</param>
    /// <returns>System.String.</returns>
    string CalculateReferenceRelativeName(string targetIdName);

  }

  /// <summary>
  /// Represents all nodes in the Information Model
  /// </summary>
  /// <typeparam name="type">The type of the ype.</typeparam>
  /// <typeparam name="OPCType">The type of the PC type.</typeparam>
  internal abstract class NodeDesign<type, OPCType> : WrapperBase<type, OPCType>, INodeDesign
    where type : Wrappers4ProperyGrid.NodeDesign<OPCType>
    where OPCType : Opc.Ua.ModelCompiler.NodeDesign, new()
  {

    #region public
    public override Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> GetFolders()
    {
      Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> tobereturned = base.GetFolders();
      tobereturned.Add(FolderType.Children, Children);
      tobereturned.Add(FolderType.References, References);
      return tobereturned;
    }
    public override string HelpTopicName
    {
      get
      {
        if (this.IsReadOnly)
          return base.Wrapper.SymbolicName.Name;
        return string.Empty;
      }
    }
    /// <summary>
    /// Gets the model designer node and initialize it with the data from the tree.
    /// </summary>
    /// <value>
    /// The model designer node derived from <see cref="Opc.Ua.ModelCompiler.NodeDesign"/>.
    /// </value>
    public override object ModelDesignerNode
    {
      get
      {
        OPCType node = (OPCType)base.ModelDesignerNode;
        node.References = m_References.References;
        node.Children = m_Children.CreateNodes;
        return node;
      }
    }
    internal ChildrenFolder Children
    {
      get
      {
        return m_Children;
      }
    }
    internal ReferencesFolder References
    {
      get
      {
        return m_References;
      }
    }
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.OpcUaNode; }
    }
    #endregion public

    #region creators
    public NodeDesign(type child)
      : base(child)
    {
      m_Children = new ChildrenFolder();
      m_References = new ReferencesFolder();
      InitializeObject();
    }
    protected NodeDesign(type child, OPCType node)
      : base(child)
    {
      m_Children = new ChildrenFolder(node.Children);
      m_References = new ReferencesFolder(node.References);
      InitializeObject();
    }
    #endregion

    #region private
    private void InitializeObject()
    {
      Add(m_Children);
      Add(m_References);
      TypesAvailableToBePasted.Add(typeof(Opc.Ua.ModelCompiler.InstanceDesign));
      TypesAvailableToBePasted.Add(typeof(Opc.Ua.ModelCompiler.Reference));
    }
    private ReferencesFolder m_References;
    private ChildrenFolder m_Children;
    protected void RemoveChldrenFolderFromSubTree()
    {
      Remove(m_Children);
    }
    protected void RemoveReferencesFolderFromSubTree()
    {
      Remove(m_References);
    }
    protected override string NodeName()
    {
      //TODO:
      //this name should also check if DisplayName is set 
      //if DisplayName is not set then another properties should be used
      //this should be verified with the OPC UA spec.
      //
      //The DisplayName attribute contains the localized name of the node. 
      //Clients should use this attribute if they want to display the name of the node to the user. 
      //They should not use the BrowseName attribute for this purpose. 
      //The server may maintain one or more localized representations for each DisplayName. 
      //Clients negotiate the locale to be returned when they open a session with the server. 
      //Refer to section Services for a description of session establishment and locales. 
      // Note: 
      //The string part of the DisplayName is restricted to 512 characters. 
      //
      //see also:[UA-2174] ASMD: check the NodeName implementation, decide what should be done with DisplayName
      //http://itrserver/Bugs/BugDetail.aspx?bid=2174
      //
      if (!string.IsNullOrEmpty(Wrapper.DisplayName.Value))
        return Wrapper.DisplayName.Value;
      if (!string.IsNullOrEmpty(Wrapper.BrowseName))
        return Wrapper.BrowseName;
      return Wrapper.SymbolicName.Name;
    }
    protected override string NodeTip()
    {
      return Wrapper.ToString();
    }
    public override void MenuItemPaste_Action()
    {
      object DeserializedNode = GetModelDesignerNodeFromStringRepresentationFromClipboard();
      BaseTreeNode baseTreeNode = NodeFactory.Create(DeserializedNode);
      if (DeserializedNode is Opc.Ua.ModelCompiler.InstanceDesign)
      {
        this.m_Children.Add(baseTreeNode);
        return;
      }
      else if (DeserializedNode is Opc.Ua.ModelCompiler.Reference)
      {
        this.m_References.Add(baseTreeNode);
        return;
      }
      MessageBox.Show(Resources.WrapperTreeNode_menu_paste_cannot_be_done);
    }
    protected new abstract class TreeNode<T> : WrapperBase<type, OPCType>.TreeNode<T>
      where T : NodeDesign<type, OPCType>
    {
      public TreeNode(T parent)
        : base(parent)
      { }
      internal override void AddNodeToDictionary()
      {
        this.AddToDictionary(ModelEntity.Wrapper.SymbolicName.XmlQualifiedName, this);
        base.AddNodeToDictionary();
      }
      public override XmlQualifiedName SymbolicName
      {
        get { return ModelEntity.SymbolicName; }
      }
    }
    /// <summary>
    /// Adds the node to the address space <see cref="IAddressSpaceCreator"/>.
    /// </summary>
    /// <param name="space">The address space as a tree of nodes.</param>
    protected virtual void AddNode2AddressSpace(IAddressSpaceCreator space) { }
    protected IInstanceNodesCollection AddChildren(IAddressSpaceCreator space, XmlQualifiedName parentNodeID, int parentAddressSpaceIndex, bool isInstanceDeclaration)
    {
      IInstanceNodesCollection _children = space.CreateNodesCollection();
      foreach (IInstanceNode item in this.Children)
        _children.Add(item, parentNodeID, parentAddressSpaceIndex, isInstanceDeclaration);
      return _children;
    }
    private void UpdateReferenceTargetName(ref XmlQualifiedName target, XmlQualifiedName symbolicName, bool instanceDeclaration)
    {
      return;
    }
    #endregion

    #region INodeDesign Members
    public override XmlQualifiedName SymbolicName
    {
      get { return Wrapper.SymbolicName.XmlQualifiedName; }
    }
    public virtual string CalculateReferenceRelativeName(string targetIdName)
    {
      return targetIdName;
    }
    /// <summary>
    /// Adds the node to the address space <see cref="IAddressSpaceCreator" /> - starting point of recursion of processing inheritance and type definition.
    /// </summary>
    /// <param name="space">The address space compiler.</param>
    void INodeDesign.AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      AddNode2AddressSpace(space);
    }
    #endregion
  }

}
