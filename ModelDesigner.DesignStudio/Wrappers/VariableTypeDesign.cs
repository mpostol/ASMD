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
  internal partial class VariableTypeDesign : TypeDesign<Wrappers4ProperyGrid.VariableTypeDesign, OpcUaModelCompiler.VariableTypeDesign>
  {

    #region creators
    public VariableTypeDesign()
      : base(new Wrappers4ProperyGrid.VariableTypeDesign(new OpcUaModelCompiler.VariableTypeDesign())) { }
    public VariableTypeDesign(OpcUaModelCompiler.VariableTypeDesign node)
      : base(new Wrappers4ProperyGrid.VariableTypeDesign(node), node) { }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Types_VariableType;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.VariableType;
    #endregion

  }

}

