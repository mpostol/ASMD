//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

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
    //private class EncodingDesignTreeNodeControl : WrapperBaseTreeNodeControl<EncodingDesign, Wrappers4ProperyGrid.EncodingDesign, Opc.Ua.ModelCompiler.EncodingDesign>
    //{
    //  public EncodingDesignTreeNodeControl( EncodingDesign parent )
    //    : base( parent )
    //  { }
    //}
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
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      return new TreeNode( this );
    }
    #endregion
  }
}
