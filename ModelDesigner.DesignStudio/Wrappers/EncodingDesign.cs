//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class EncodingDesign : WrapperBase<Wrappers4ProperyGrid.EncodingDesign, Opc.Ua.ModelCompiler.EncodingDesign>
  {

    #region creators
    public EncodingDesign() : base(new Wrappers4ProperyGrid.EncodingDesign(new Opc.Ua.ModelCompiler.EncodingDesign())) { }
    public EncodingDesign(Opc.Ua.ModelCompiler.EncodingDesign parameter) : base(new Wrappers4ProperyGrid.EncodingDesign(parameter)) { }
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
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_Encoding;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.Encoding;
    public override NodeTypeEnum NodeType => NodeTypeEnum.OpcUaNode;
    #endregion

  }
}
