//<summary>
//  Title   : Namespaces Folder
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
using System.Xml.Serialization;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class NamespacesFolder: Folder
  {
    #region cretors
    internal NamespacesFolder( Opc.Ua.ModelCompiler.ModelDesign child )
      : base( "Namespaces", WrapperResources.NamespaceFolderToolTipText )
    {
      TypesAvailableToBePasted.Add( typeof( Opc.Ua.ModelCompiler.Namespace ) );
      if ( child.Namespaces == null || child.Namespaces.Length == 0 )
        return;
      foreach ( Opc.Ua.ModelCompiler.Namespace ns in child.Namespaces )
        this.Add( new Namespace( ns ) );
    }
    #endregion

    #region public
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.NamespaceFolderNode; }
    }
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_NamespaceFolder; }
    }
    internal Opc.Ua.ModelCompiler.Namespace[] Namespaces
    {
      get
      {
        Opc.Ua.ModelCompiler.Namespace[] array = new Opc.Ua.ModelCompiler.Namespace[ this.Count ];
        int ii = 0;
        foreach ( Namespace node in this )
          array[ ii++ ] = (Opc.Ua.ModelCompiler.Namespace)node.ModelDesignerNode;
        return array;
      }
    }
    /// <summary>
    /// Gets the XML namespaces <see cref="XmlSerializerNamespaces"/> to be used while serializing the model.
    /// </summary>
    /// <value><see cref="XmlSerializerNamespaces"/> the XML namespaces.</value>
    internal XmlSerializerNamespaces XmlNamespaces
    {
      get
      {
        XmlSerializerNamespaces col = new XmlSerializerNamespaces();
        col.Add( PrepareNamespacePrefix( Properties.Settings.Default.XmlSchemaInstancePrefix ), Properties.Settings.Default.XmlSchemaInstanceNamespace );
        col.Add( PrepareNamespacePrefix( Properties.Settings.Default.XmlSchemaPrefix ), Properties.Settings.Default.XmlSchemaNamespace );
        col.Add( PrepareNamespacePrefix( Properties.Settings.Default.XmlOPCTypesPrefix ), Properties.Settings.Default.XmlOPCTypesNamespace );
        foreach ( Namespace node in this )
          col.Add( PrepareNamespacePrefix( node.Wrapper.XmlPrefix ), node.Wrapper.Value );
        return col;
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
    internal string[] GetAvailiableNamespaces()
    {
      string[] AvailiableNamespaces = new string[ Count ];
      int idx = 0;
      foreach ( Namespace node in this )
      {
        AvailiableNamespaces[ idx++ ] = node.NamespaceValue;
      }
      return AvailiableNamespaces;
    }
    #endregion

    #region private
    private static int count = 0;
    private string PrepareNamespacePrefix( string namespaceprefix )
    {
      if ( string.IsNullOrEmpty( namespaceprefix ) )
        return string.Format( "ns{0}", count++ );
      string ret = namespaceprefix;
      foreach ( char chr in Resources.NamespaceFolderCharacterToBeRemovedFromNamespacePrefix.ToCharArray() )
        ret = ret.Replace( chr.ToString(), "" );
      if ( ret.IndexOf( "xml" ) == 0 )
        ret = Resources.NamespaceFolderCharacterNamespacePrefix_XMLatTheBeginningReplacement + ret;
      return ret;
    }
    private INodeFactory[] ListOfNodes
    {
      get { return new TypeListItem<Namespace>[] { new TypeListItem<Namespace>() }; }
    }
    private class TreeNode: Folder.TreeNode<NamespacesFolder>
    {
      public TreeNode( NamespacesFolder parent )
        : base( parent )
      { }
      protected override void BeforeMenuStripOpening()
      {
        AddMenuItemPaste();
        AddMenuItemAdd(ModelEntity.ListOfNodes );
        base.BeforeMenuStripOpening();
      }
    }
    #endregion

  }
}
