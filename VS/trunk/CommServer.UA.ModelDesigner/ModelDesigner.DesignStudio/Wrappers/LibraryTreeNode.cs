//<summary>
//  Title   : A node representing a non editable library on the tree.
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

using CAS.UA.Model.Designer.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using OPCFModelDesign = Opc.Ua.ModelCompiler.ModelDesign;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// A node representing a non editable library on the tree.
  /// </summary>
  internal class LibraryTreeNode : RootTreeNode
  {
    #region private
    private class LocalTreeNode : RootTreeNode.TreeNode<LibraryTreeNode>
    {
      public LocalTreeNode(LibraryTreeNode parent)
        : base(parent)
      { }
    }
    #endregion

    #region creator
    internal LibraryTreeNode(OPCFModelDesign config, string nodeName, IContainer Container)
      : base(nodeName)
    {
      List<Opc.Ua.ModelCompiler.NodeDesign> _nodes = new List<Opc.Ua.ModelCompiler.NodeDesign>();
      _nodes.AddRange(config.Items);
      _nodes.Sort((x, y) =>
      {
        int _ret = x.GetType().Name.CompareTo(y.GetType().Name);
        if (_ret == 0)
          _ret = x.SymbolicName.Name.CompareTo(y.SymbolicName.Name);
        return _ret;
      });
      config.Items = _nodes.ToArray();
      ModelDesign m_ModelDesignTypes = new ModelDesign(config, true);
      Add(m_ModelDesignTypes);
    }
    #endregion

    #region internal
    internal override bool TestIfReadOnlyAndRetrunTrueIfReadOnly()
    {
      return true;
    }
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    internal override DictionaryTreeView.DictionaryTreeNode GetTreeNode()
    {
      return new LocalTreeNode(this);
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
    #endregion
  }
}
