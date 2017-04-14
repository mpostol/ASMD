//<summary>
//  Title   : Encodings Folder tree node
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
using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class EncodingsFolder: Folder
  {
    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="EncodingsFolder"/> class.
    /// </summary>
    /// <param name="parameters">The parameters to be added to the tree.</param>
    /// <param name="text">The node text.</param>
    /// <param name="toolStripTip">The tool strip tip text.</param>
    public EncodingsFolder( Opc.Ua.ModelCompiler.EncodingDesign[] parameters, string text, string toolStripTip )
      : base( text, toolStripTip )
    {
      if ( parameters == null || parameters.Length == 0 )
        return;
      foreach ( Opc.Ua.ModelCompiler.EncodingDesign rf in parameters )
        Add( new EncodingDesign( rf ) );
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Objects_EncodingsFolder; }
    }
    internal Opc.Ua.ModelCompiler.EncodingDesign[] CreateParameters()
    {
      if ( Count == 0 )
        return null;
      int ii = 0;
      Opc.Ua.ModelCompiler.EncodingDesign[] array = new Opc.Ua.ModelCompiler.EncodingDesign[ Count ];
      foreach ( EncodingDesign node in this )
        array[ ii++ ] = (Opc.Ua.ModelCompiler.EncodingDesign)node.ModelDesignerNode;
      return array;
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
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.EncodinsForlderNode; }
    }
    #endregion

    #region private
    private INodeFactory[] ListOfNodes
    {
      get
      {
        TypeListItem<EncodingDesign>[] m_list = new TypeListItem<EncodingDesign>[ 1 ];
        m_list[ 0 ] = new TypeListItem<EncodingDesign>();
        return m_list;
      }
    }
    private class TreeNode: Folder.TreeNode<EncodingsFolder>
    {
      public TreeNode( EncodingsFolder parent )
        : base( parent )
      { }
      protected override void BeforeMenuStripOpening()
      {
        AddMenuItemAdd( Creator.ListOfNodes );
        base.BeforeMenuStripOpening();
      }
    }
    #endregion

  }
}
