//<summary>
//  Title   : Property Design wrapper
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System;
using System.Collections.Generic;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Controls;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class PropertyDesign: VariableDesignGeneric<Wrappers4ProperyGrid.PropertyDesign, Opc.Ua.ModelCompiler.PropertyDesign>
  {
    public PropertyDesign()
      : base( new Wrappers4ProperyGrid.PropertyDesign( new Opc.Ua.ModelCompiler.PropertyDesign() ) )
    {
      RemoveChldrenFolderFromSubTree();
    }
    public PropertyDesign( Opc.Ua.ModelCompiler.PropertyDesign node )
      : base( new Wrappers4ProperyGrid.PropertyDesign( node ), node )
    {
      RemoveChldrenFolderFromSubTree();
    }

    #region private
    private class TreeNode: VariableDesignGeneric<Wrappers4ProperyGrid.PropertyDesign, Opc.Ua.ModelCompiler.PropertyDesign>.TreeNode<PropertyDesign>
    {
      public TreeNode( PropertyDesign parent )
        : base( parent )
      { }
      protected override void BeforeMenuStripOpening()
      {
        AddMenuItemGoTo( Resources.WrapperTreeNodeAddMenuItemGoto
          + Resources.WrapperTreeNodeAddMenuItemGoto_DataType,
          Resources.WrapperTreeNodeAddMenuItemGoto_DataType_tooltip,
          new EventHandler( AddMenuItemGoTo_Click ) );
        base.BeforeMenuStripOpening();
      }
      private void AddMenuItemGoTo_Click( object sender, System.EventArgs e )
      {
        TreeView.GoToNode( Creator.Wrapper.DataType.XmlQualifiedName );
      }
      internal override Dictionary<string, System.Xml.XmlQualifiedName> GetCoupledNodesXmlQualifiedNames()
      {
        var list = base.GetCoupledNodesXmlQualifiedNames();
        if ( Creator.Wrapper.DataType.XmlQualifiedName != null && !Creator.Wrapper.DataType.XmlQualifiedName.IsEmpty )
          list.Add( Resources.WrapperTreeNodeAddMenuItemGoto_DataType,
            Creator.Wrapper.DataType.XmlQualifiedName );
        return list;
      }
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Objects_Property; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.Property; }
    }
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    internal override DictionaryTreeView.DictionaryTreeNode GetTreeNode()
    {
      return new TreeNode( this );
    }
    #endregion
  }
}
