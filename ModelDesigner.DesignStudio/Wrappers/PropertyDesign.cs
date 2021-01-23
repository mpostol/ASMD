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
  internal partial class PropertyDesign : InstanceDesign<Wrappers4ProperyGrid.PropertyDesign, OpcUaModelCompiler.PropertyDesign>
  {
    #region constructors
    public PropertyDesign() : base(new Wrappers4ProperyGrid.PropertyDesign(new OpcUaModelCompiler.PropertyDesign()))
    {
      RemoveChildrenFolderFromSubTree();
    }
    public PropertyDesign(OpcUaModelCompiler.PropertyDesign node) : base(new Wrappers4ProperyGrid.PropertyDesign(node), node)
    {
      RemoveChildrenFolderFromSubTree();
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
