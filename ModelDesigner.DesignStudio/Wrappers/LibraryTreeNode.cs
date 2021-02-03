//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System.Collections.Generic;
using System.Xml;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// A node representing a non editable library on the tree.
  /// </summary>
  internal class LibraryTreeNode : RootTreeNode
  {
    #region constructor

    internal LibraryTreeNode(OpcUaModelCompiler.ModelDesign config, string nodeName)
      : base(nodeName)
    {
      List<OpcUaModelCompiler.NodeDesign> _nodes = new List<OpcUaModelCompiler.NodeDesign>();
      if (config.Items != null)
      {
        _nodes.AddRange(config.Items);
        _nodes.Sort((x, y) =>
        {
          int _ret = x.GetType().Name.CompareTo(y.GetType().Name);
          if (_ret == 0)
            _ret = x.SymbolicName.Name.CompareTo(y.SymbolicName.Name);
          return _ret;
        });
        config.Items = _nodes.ToArray();
      }
      ModelDesign m_ModelDesignTypes = new ModelDesign(config, true);
      Add(m_ModelDesignTypes);
    }

    #endregion creator

    #region internal

    internal override bool TestIfReadOnlyAndRetrunTrueIfReadOnly()
    {
      return true;
    }

    /// <summary>
    /// Adds to dictionary - each item of <see cref="ModelDesign{WrapperType, ModelType}"/> from this collection is added to <paramref name="space"/>.
    /// </summary>
    /// <param name="space">The address space.</param>
    internal void AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      foreach (ModelDesign item in this)
        item.AddNode2AddressSpace(space);
    }

    internal ITypeDesign FindType(XmlQualifiedName myType)
    {
      foreach (ModelDesign node in this)
      {
        ITypeDesign ret = node.FindType(myType);
        if (ret != null)
          return ret;
      }
      return null;
    }

    #endregion internal
  }
}