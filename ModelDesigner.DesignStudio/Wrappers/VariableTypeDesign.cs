//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class VariableTypeDesign: TypeDesign<Wrappers4ProperyGrid.VariableTypeDesign, Opc.Ua.ModelCompiler.VariableTypeDesign>
  {

    #region creators
    public VariableTypeDesign()
      : base( new Wrappers4ProperyGrid.VariableTypeDesign( new Opc.Ua.ModelCompiler.VariableTypeDesign() ) )
    { }
    public VariableTypeDesign( Opc.Ua.ModelCompiler.VariableTypeDesign node )
      : base( new Wrappers4ProperyGrid.VariableTypeDesign( node ), node )
    { }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Types_VariableType; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.VariableType; }
    }
    #endregion

  }

}

