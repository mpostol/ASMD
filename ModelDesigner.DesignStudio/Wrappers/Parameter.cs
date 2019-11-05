//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{

  internal partial class Parameter : WrapperBase<Wrappers4ProperyGrid.Parameter, Opc.Ua.ModelCompiler.Parameter>
  {

    #region creators
    public Parameter() : base(new Wrappers4ProperyGrid.Parameter(new Opc.Ua.ModelCompiler.Parameter())) { }
    public Parameter(Opc.Ua.ModelCompiler.Parameter parameter) : base(new Wrappers4ProperyGrid.Parameter(parameter)) { }
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
