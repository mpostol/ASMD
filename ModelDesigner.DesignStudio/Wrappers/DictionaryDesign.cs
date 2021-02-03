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
  internal partial class DictionaryDesign : InstanceDesign<Wrappers4ProperyGrid.DictionaryDesign, OpcUaModelCompiler.DictionaryDesign>
  {
    #region creators

    public DictionaryDesign() : base(new Wrappers4ProperyGrid.DictionaryDesign(new OpcUaModelCompiler.DictionaryDesign()))
    {
    }

    public DictionaryDesign(OpcUaModelCompiler.DictionaryDesign node) : base(new Wrappers4ProperyGrid.DictionaryDesign(node), node)
    {
    }

    #endregion creators

    #region public

    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.Dictionary;

    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_Dictionary;

    #endregion public
  }
}