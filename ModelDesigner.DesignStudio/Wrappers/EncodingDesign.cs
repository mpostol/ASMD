//<summary>
//  Title   : Parameter Wrapper
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  20081107: mzbrzezny: created
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class EncodingDesign: WrapperBase<Wrappers4ProperyGrid.EncodingDesign, Opc.Ua.ModelCompiler.EncodingDesign>
  {
    #region creators
    public EncodingDesign() :
      base( new Wrappers4ProperyGrid.EncodingDesign( new Opc.Ua.ModelCompiler.EncodingDesign() ) )
    { }
    public EncodingDesign( Opc.Ua.ModelCompiler.EncodingDesign parameter )
      : base( new Wrappers4ProperyGrid.EncodingDesign( parameter ) )
    { }
    #endregion

    #region private
    protected override string NodeName()
    {
      return Wrapper.SymbolicName.Name;
    }
    protected override string NodeTip()
    {
      return Wrapper.Description.ToString();
    }
    private class TreeNode: WrapperBase<Wrappers4ProperyGrid.EncodingDesign, Opc.Ua.ModelCompiler.EncodingDesign>.TreeNode<EncodingDesign>
    {
      public TreeNode( EncodingDesign parent )
        : base( parent )
      { }
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Objects_Encoding; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.Encoding; }
    }
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.OpcUaNode; }
    }
    #endregion

    #region internal
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
