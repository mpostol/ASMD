//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class PropertyDesign : InstanceDesign<Wrappers4ProperyGrid.PropertyDesign, Opc.Ua.ModelCompiler.PropertyDesign>
  {

    #region constructors
    public PropertyDesign() : base(new Wrappers4ProperyGrid.PropertyDesign(new Opc.Ua.ModelCompiler.PropertyDesign()))
    {
      RemoveChldrenFolderFromSubTree();
    }
    public PropertyDesign(Opc.Ua.ModelCompiler.PropertyDesign node) : base(new Wrappers4ProperyGrid.PropertyDesign(node), node)
    {
      RemoveChldrenFolderFromSubTree();
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_Property;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.Property;
    #endregion
  }
}
