//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Root of the model tree.
  /// </summary>
  internal partial class ModelDesign : WrapperBase<Wrappers4ProperyGrid.ModelDesign, OpcUaModelCompiler.ModelDesign>
  {
    #region creators

    //internal ModelDesign()
    //  : this
    //  (
    //    new OpcUaModelCompiler.ModelDesign()
    //    {
    //      TargetNamespace = Settings.Default.TargetNamespace,
    //      Namespaces = new OpcUaModelCompiler.Namespace[]
    //        { new  OpcUaModelCompiler.Namespace()
    //           { Value = Settings.Default.TargetNamespace,
    //             XmlPrefix = Settings.Default.TargetNamespaceXmlPrefix,
    //             Name = Settings.Default.TargetNamespaceXmlPrefix
    //           },
    //         new OpcUaModelCompiler.Namespace()
    //           { Value = OPCUATargetNamespace,
    //             XmlPrefix = Settings.Default.XmlUATypesPrefix,
    //             Name = Settings.Default.XmlUATypesPrefix
    //           }
    //        }
    //    },
    //    false
    //  )
    //{ }

    internal ModelDesign(OpcUaModelCompiler.ModelDesign node, bool library) : base(new Wrappers4ProperyGrid.ModelDesign(node))
    {
      TypesAvailableToBePasted.Add(typeof(OpcUaModelCompiler.NodeDesign));
      TypesAvailableToBePasted.Add(typeof(OpcUaModelCompiler.Namespace));
      m_Namespaces = new NamespacesFolder(node);
      Add(m_Namespaces);
      OpcUaModelCompiler.NodeDesign[] list = node.Items;
      if (list == null || list.Length == 0)
        return;
      foreach (OpcUaModelCompiler.NodeDesign item in list)
        Add(NodeFactory.Create(item));
      if (library)
        OPCUATargetNamespace = Wrapper.TargetNamespace;
    }

    //internal static ModelDesign CreateRootOfOPCUAInfromationModel(string filePath)
    //{
    //  FileInfo info = new FileInfo(filePath);
    //  if (!info.Exists)
    //    throw new FileNotFoundException($"Cannot find the file at { filePath}");
    //  OPCFModelDesign _ModelDesign = XmlFile.ReadXmlFile<OPCFModelDesign>(filePath);
    //  return new ModelDesign(_ModelDesign, false);
    //}

    #endregion creators

    #region private

    internal INodeFactory[] ListOfNodes
    {
      get
      {
        List<INodeFactory> m_list = new List<INodeFactory>
        {
          new TypeListItem<DataTypeDesign>(),
          new TypeListItem<DictionaryDesign>(),
          new TypeListItem<MethodDesign>(),
          new TypeListItem<ObjectDesign>(),
          new TypeListItem<ObjectTypeDesign>(),
          new TypeListItem<ReferenceTypeDesign>(),
          new TypeListItem<VariableTypeDesign>(),
          new TypeListItem<VariableDesign>(),
          new TypeListItem<PropertyDesign>(),
          new TypeListItem<ViewDesign>()
        };
        return m_list.ToArray();
      }
    }

    internal void GetImportMenu(System.Windows.Forms.ToolStripItemCollection items)
    {
      if (this.TestIfReadOnlyAndRetrunTrueIfReadOnly())
        return;
      ImportOPCDAAddressSpace.CreateImportMenuItems(items, new EventHandler(CreateImportMenuClick));
    }

    protected override string NodeName()
    {
      return "Domain";
    }

    protected override string NodeTip()
    {
      string ns;
      if (Wrapper == null || Wrapper.TargetNamespace == null)
        ns = "< empty > \n";
      else
        ns = Wrapper.TargetNamespace;
      return String.Format(WrapperResources.ModelDesignNodeToolTipText, ns);
    }

    private NamespacesFolder m_Namespaces;

    private void CreateImportMenuClick(object sender, EventArgs e)
    {
      OpcUaModelCompiler.NodeDesign[] nodes = ImportOPCDAAddressSpace.OnImportMenuItemClick(GetTargetNamespace());
      if (nodes == null)
        return;
      List<BaseTreeNode> arr = new List<BaseTreeNode>();
      bool CancelWasPressed = false;
      foreach (OpcUaModelCompiler.NodeDesign item in nodes)
      {
        BaseTreeNode newNode = NodeFactory.Create(item);
        arr.Add(newNode);
        if (item is OpcUaModelCompiler.InstanceDesign)
          this.CreateInstanceConfigurations(newNode, CancelWasPressed, out CancelWasPressed);
      }
      this.AddRange(arr.ToArray());
    }

    #endregion private

    #region WrapperBase

    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Model;

    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.None;

    public override NodeTypeEnum NodeType => NodeTypeEnum.ModelNode;

    public override Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> GetFolders()
    {
      Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> tobereturned = base.GetFolders();
      tobereturned.Add(FolderType.ModelNodes, this);
      return tobereturned;
    }

    public override void MenuItemCut_Action()
    {
      MenuItemCopy_Action();
      this.MessageBoxHandling.Show(Resources.WrapperTreeNode_menu_cut_cannot_be_cut);
    }

    public override void MenuItemPaste_Action()
    {
      object DeserializedNode = GetModelDesignerNodeFromStringRepresentationFromClipboard();
      BaseTreeNode baseTreeNode = NodeFactory.Create(DeserializedNode);
      if (DeserializedNode is OpcUaModelCompiler.NodeDesign)
      {
        this.Add(baseTreeNode);
        return;
      }
      else if (DeserializedNode is OpcUaModelCompiler.Namespace)
      {
        this.m_Namespaces.Add(baseTreeNode);
        return;
      }
      this.MessageBoxHandling.Show(Resources.WrapperTreeNode_menu_paste_cannot_be_done);
    }

    public override string[] AvailiableNamespaces => m_Namespaces.GetAvailableNamespaces();

    /// <summary>
    /// Gets the model designer node <see cref="OPCFModelDesign"/>.
    /// </summary>
    /// <value>The model designer node <see cref="OPCFModelDesign"/>.</value>
    public override object ModelDesignerNode
    {
      get
      {
        OpcUaModelCompiler.ModelDesign node = (OpcUaModelCompiler.ModelDesign)base.ModelDesignerNode;
        node.Namespaces = m_Namespaces.Namespaces;
        List<OpcUaModelCompiler.NodeDesign> uaNodes = new List<OpcUaModelCompiler.NodeDesign>();
        foreach (BaseTreeNode item in this)
        {
          IParent tn = item as IParent;
          if (tn == null)
            continue;
          uaNodes.Add((OpcUaModelCompiler.NodeDesign)tn.ModelDesignerNode);
        }
        node.Items = uaNodes.ToArray();
        return node;
      }
    }

    #endregion WrapperBase

    #region internal

    internal OpcUaModelCompiler.ModelDesign GetModel()
    {
      return ModelDesignerNode as OpcUaModelCompiler.ModelDesign;
    }

    /// <summary>
    /// Gets the XML namespaces to be used for serialization process.
    /// </summary>
    /// <value>The XML namespaces <see cref="XmlSerializerNamespaces"/>.</value>
    internal XmlSerializerNamespaces XmlNamespaces => m_Namespaces.XmlNamespaces;

    internal static string OPCUATargetNamespace { get; private set; }

    /// <summary>
    /// Gets the target namespace of the current project.
    /// </summary>
    /// <returns>The target namespace.</returns>
    public override string GetTargetNamespace()
    {
      return Wrapper.TargetNamespace;
    }

    /// <summary>
    /// All items in this collection of <see cref="INodeDesign"/> is added to the <paramref name="space"/>
    /// </summary>
    /// <param name="space">The address space.</param>
    internal void AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      foreach (IBaseModel item in this)
      {
        INodeDesign modelItem = item as INodeDesign;
        if (modelItem != null)
          modelItem.AddNode2AddressSpace(space);
      }
    }

    internal ITypeDesign FindType(XmlQualifiedName myType)
    {
      ITypeDesign ret = null;
      foreach (IBaseModel item in this)
      {
        INodeDesign node = item as INodeDesign;
        if ((node != null) && (node.SymbolicName == myType))
        {
          ret = node as ITypeDesign;
          if (ret != null)
            break;
        }
      }
      return ret;
    }

    #endregion internal
  }
}