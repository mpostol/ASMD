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

  internal partial class Parameter : WrapperBase<Wrappers4ProperyGrid.Parameter, OpcUaModelCompiler.Parameter>
  {

    #region creators
    public Parameter() : base(new Wrappers4ProperyGrid.Parameter(new OpcUaModelCompiler.Parameter())) { }
    public Parameter(OpcUaModelCompiler.Parameter parameter) : base(new Wrappers4ProperyGrid.Parameter(parameter)) { }
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
    #endregion //protected

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_Parameter;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.Variable;
    public override NodeTypeEnum NodeType => NodeTypeEnum.ParameterNode;
    #endregion
  }

}
