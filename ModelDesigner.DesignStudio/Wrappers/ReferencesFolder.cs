//<summary>
//  Title   : Reference Folder
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

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class ReferencesFolder: Folder
  {
    #region creators
    internal ReferencesFolder()
      : base( "References", WrapperResources.ReferencesFolderNodeToolTipText )
    {
      TypesAvailableToBePasted.Add( typeof( Opc.Ua.ModelCompiler.Reference ) );
    }
    internal ReferencesFolder( Opc.Ua.ModelCompiler.Reference[] refrences )
      : this()
    {
      if ( refrences == null || refrences.Length == 0 )
        return;
      foreach ( Opc.Ua.ModelCompiler.Reference rf in refrences )
        Add( new Reference( rf ) );
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the topic in help.
    /// </summary>
    /// <value>The name of the topicin help.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Objects_ReferencesFolder; }
    }
    internal Opc.Ua.ModelCompiler.Reference[] References
    {
      get
      {
        if ( Count == 0 )
          return null;
        int ii = 0;
        Opc.Ua.ModelCompiler.Reference[] array = new Opc.Ua.ModelCompiler.Reference[ Count ];
        foreach ( IParent node in this )
          array[ ii++ ] = (Opc.Ua.ModelCompiler.Reference)node.ModelDesignerNode;
        return array;
      }
    }
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      return new TreeNode( this );
    }
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.ReferencesFolderNode; }
    }
    #endregion

    #region private
    private INodeFactory[] ListOfNodes
    {
      get
      {
        TypeListItem<Reference>[] m_list = new TypeListItem<Reference>[ 1 ];
        m_list[ 0 ] = new TypeListItem<Reference>();
        return m_list;
      }
    }
    private class TreeNode: Folder.TreeNode<ReferencesFolder>
    {
      public TreeNode( ReferencesFolder parent )
        : base( parent )
      {}
      protected override void BeforeMenuStripOpening()
      {
        AddMenuItemPaste();
        AddMenuItemAdd( ModelEntity.ListOfNodes );
        base.BeforeMenuStripOpening();
      }
    }
    #endregion
  }
}
