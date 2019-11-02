//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________


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
      //TODO Refactoring application architecture - remove recursion #6
      throw new System.NotImplementedException("TrrNode factory must be implemented");
      //return new TreeNode( this );
    }
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.ReferencesFolderNode; }
    }
    #endregion

    #region private
    internal INodeFactory[] ListOfNodes
    {
      get
      {
        TypeListItem<Reference>[] m_list = new TypeListItem<Reference>[ 1 ];
        m_list[ 0 ] = new TypeListItem<Reference>();
        return m_list;
      }
    }
    //TODO Refactoring application architecture - remove recursion #6
    //private class ReferencesFolderTreeNodeControl : FolderTreeNodeControl<ReferencesFolder>
    //{
    //  public ReferencesFolderTreeNodeControl( ReferencesFolder parent )
    //    : base( parent )
    //  {}
    //  protected override void BeforeMenuStripOpening()
    //  {
    //    AddMenuItemPaste();
    //    AddMenuItemAdd( ModelEntity.ListOfNodes );
    //    base.BeforeMenuStripOpening();
    //  }
    //}
    #endregion
  }
}
