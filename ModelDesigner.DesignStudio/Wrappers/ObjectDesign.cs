//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Represents all object node instances in the Information Model
  /// </summary>
  internal partial class ObjectDesign : InstanceDesign<Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>, Opc.Ua.ModelCompiler.ObjectDesign>
  {
    #region constructors
    public ObjectDesign() : base(new Designer.Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>(new Opc.Ua.ModelCompiler.ObjectDesign())) { }
    public ObjectDesign(Opc.Ua.ModelCompiler.ObjectDesign node) : base(new Wrappers4ProperyGrid.ObjectDesign<Opc.Ua.ModelCompiler.ObjectDesign>(node), node) { }
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
    #endregion
  }
}
