//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class DictionaryDesign : InstanceDesign<Wrappers4ProperyGrid.DictionaryDesign, Opc.Ua.ModelCompiler.DictionaryDesign>
  {

    #region creators
    public DictionaryDesign() : base(new Wrappers4ProperyGrid.DictionaryDesign(new Opc.Ua.ModelCompiler.DictionaryDesign())) { }
    public DictionaryDesign(Opc.Ua.ModelCompiler.DictionaryDesign node) : base(new Wrappers4ProperyGrid.DictionaryDesign(node), node) { }
    #endregion

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
    #endregion

  }
}
