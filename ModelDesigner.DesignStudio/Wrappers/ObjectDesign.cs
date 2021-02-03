//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Represents all object node instances in the Information Model
  /// </summary>
  internal partial class ObjectDesign : InstanceDesign<Wrappers4ProperyGrid.ObjectDesign<OpcUaModelCompiler.ObjectDesign>, OpcUaModelCompiler.ObjectDesign>
  {
    #region constructors
    public ObjectDesign() : base(new Designer.Wrappers4ProperyGrid.ObjectDesign<OpcUaModelCompiler.ObjectDesign>(new OpcUaModelCompiler.ObjectDesign())) { }
    public ObjectDesign(OpcUaModelCompiler.ObjectDesign node) : base(new Wrappers4ProperyGrid.ObjectDesign<OpcUaModelCompiler.ObjectDesign>(node), node) { }
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
