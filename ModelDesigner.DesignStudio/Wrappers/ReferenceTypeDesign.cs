//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class ReferenceTypeDesign : TypeDesign<Wrappers4ProperyGrid.ReferenceTypeDesign, Opc.Ua.ModelCompiler.ReferenceTypeDesign>
  {
    #region creatores
    public ReferenceTypeDesign() : base(new Wrappers4ProperyGrid.ReferenceTypeDesign(new Opc.Ua.ModelCompiler.ReferenceTypeDesign())) { }
    public ReferenceTypeDesign(Opc.Ua.ModelCompiler.ReferenceTypeDesign node) : base(new Wrappers4ProperyGrid.ReferenceTypeDesign(node), node) { }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Types_ReferenceType;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.ReferenceType;
    #endregion

  }
}
