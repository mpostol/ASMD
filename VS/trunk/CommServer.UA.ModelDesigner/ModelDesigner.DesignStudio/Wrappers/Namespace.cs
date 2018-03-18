//<summary>
//  Title   : Namespace Wrapper
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
  internal partial class Namespace: WrapperBase<Wrappers4ProperyGrid.Namespace, Opc.Ua.ModelCompiler.Namespace>
  {
    #region creators
    public Namespace()
      : this( new Opc.Ua.ModelCompiler.Namespace() )
    { }
    public Namespace( Opc.Ua.ModelCompiler.Namespace child )
      : base( new Wrappers4ProperyGrid.Namespace( child ) )
    { }
    #endregion

    #region public
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.NamespaceNode; }
    }
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Namespace; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.None; }// this is not UA node class
    }
    public override string ToString()
    {
      string format = "{0}.{1}/{2}[{3}]";
      return string.Format( format, Wrapper.Prefix, this.Text, Wrapper.Value, Wrapper.XmlNamespace );
    }
    internal string NamespaceValue
    {
      get
      {
        return Wrapper.Value;
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
    #endregion

    #region private
    protected override string NodeName()
    {
      return Wrapper.Name;
    }
    protected override string NodeTip()
    {
      return ToString();
    }
    private class TreeNode: WrapperBase<Wrappers4ProperyGrid.Namespace, Opc.Ua.ModelCompiler.Namespace>.TreeNode<Namespace>
    {
      public TreeNode( Namespace parent )
        : base( parent )
      { }
    }
    #endregion
  }
}
