//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class Parameter: WrapperBase<Wrappers4ProperyGrid.Parameter, Opc.Ua.ModelCompiler.Parameter>
  {

    #region creators
    public Parameter() :
      base( new Wrappers4ProperyGrid.Parameter( new Opc.Ua.ModelCompiler.Parameter() ) )
    { }
    public Parameter( Opc.Ua.ModelCompiler.Parameter parameter )
      : base( new Wrappers4ProperyGrid.Parameter( parameter ) )
    { }
    #endregion

    #region protected
    protected override string NodeName()
    {
      return Wrapper.Name;
    }
    protected override string NodeTip()
    {
      return Wrapper.Description.ToString();
    }
    //private class ParameterTreeNodeControl : WrapperBaseTreeNodeControl<Parameter, Wrappers4ProperyGrid.Parameter, Opc.Ua.ModelCompiler.Parameter>
    //{
    //  public ParameterTreeNodeControl( Parameter parent )
    //    : base( parent )
    //  { }
    //}//TreeNode
    #endregion //protected

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Objects_Parameter; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.Variable; }
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
      get { return NodeTypeEnum.ParameterNode; }
    }
    #endregion
  }
}
