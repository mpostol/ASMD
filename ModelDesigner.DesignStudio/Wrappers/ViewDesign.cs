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
  internal partial class ViewDesign : NodeDesign<Wrappers4ProperyGrid.ViewDesign, OpcUaModelCompiler.ViewDesign>
  {
    #region constructors
    public ViewDesign() : base(new Designer.Wrappers4ProperyGrid.ViewDesign(new OpcUaModelCompiler.ViewDesign())) { }
    public ViewDesign(OpcUaModelCompiler.ViewDesign node) : base(new Wrappers4ProperyGrid.ViewDesign(node), node) { }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_View;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.View;
    #endregion
  }
}
