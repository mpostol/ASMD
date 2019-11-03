//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Represents all object node instances in the Information Model
  /// </summary>
  internal partial class ObjectDesign : InstanceDesign<Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>, Opc.Ua.ModelCompiler.ObjectDesign>
  {
    #region constructors
    public ObjectDesign()
      : base(new Designer.Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>(new Opc.Ua.ModelCompiler.ObjectDesign())) { }
    public ObjectDesign(Opc.Ua.ModelCompiler.ObjectDesign node)
      : base(new Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>(node), node) { }
    #endregion

    #region private
    //private class ObjectDesignTreeNodeControl : InstanceDesignTreeNodeControl<ObjectDesign, Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>, Opc.Ua.ModelCompiler.ObjectDesign>
    //{
    //  public ObjectDesignTreeNodeControl(ObjectDesign parent)
    //    : base(parent)
    //  { }
    //}
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_Object;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.Object;
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      return new ObjectDesignTreeNodeControl(this);
    }
    #endregion
  }
}
