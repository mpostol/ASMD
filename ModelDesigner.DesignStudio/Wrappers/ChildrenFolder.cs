//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using System.Collections.Generic;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

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
    public ChildrenFolder() : base(WrapperResources.ChildrenFolderText, WrapperResources.ChildrenFolderToolTip)
    {
      TypesAvailableToBePasted.Add(typeof(OpcUaModelCompiler.InstanceDesign));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ChildrenFolder"/> class.
    /// </summary>
    /// <param name="child">The collection of children - nodes referenced by HasComponent and HasProperty.</param>
    public ChildrenFolder(OpcUaModelCompiler.ListOfChildren child) : this()
    {
      if (child == null || child.Items == null || child.Items.Length == 0)
        return;
      foreach (OpcUaModelCompiler.InstanceDesign item in child.Items)
        this.Add(NodeFactory.Create(item));
    }

    #endregion creators

    #region public

    public override string HelpTopicName => Resources.NodeClasses_ChildrenFolder;

    internal OpcUaModelCompiler.ListOfChildren CreateNodes
    {
      get
      {
        if (Count == 0)
          return null;
        OpcUaModelCompiler.ListOfChildren list = new OpcUaModelCompiler.ListOfChildren { };
        list.Items = new OpcUaModelCompiler.InstanceDesign[Count];
        int ii = 0;
        foreach (IParent node in this)
          list.Items[ii++] = (OpcUaModelCompiler.InstanceDesign)node.ModelDesignerNode;
        return list;
      }
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

    public override NodeTypeEnum NodeType => NodeTypeEnum.ChildrenFolderNode;

    #endregion public

    #region private

    internal virtual INodeFactory[] ListOfNodes
    {
      get
      {
        List<INodeFactory> m_list = new List<INodeFactory>
        {
          new TypeListItem<MethodDesign>(),
          new TypeListItem<ObjectDesign>(),
          new TypeListItem<PropertyDesign>(),
          new TypeListItem<VariableDesign>()
        };
        return m_list.ToArray();
      }
    }

    #endregion private
  }
}