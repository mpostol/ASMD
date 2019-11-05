//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;

namespace CAS.UA.Model.Designer.Wrappers
{

  /// <summary>
  /// Class Reference. - represents reference in the address space.
  /// </summary>
  internal partial class Reference : WrapperBase<Wrappers4ProperyGrid.Reference, Opc.Ua.ModelCompiler.Reference>
  {

    #region constructor
    public Reference() : this(new Opc.Ua.ModelCompiler.Reference()) { }
    public Reference(Opc.Ua.ModelCompiler.Reference reference) : base(new Wrappers4ProperyGrid.Reference(reference)) { }
    #endregion

    #region private
    protected override string NodeName()
    {
      return Wrapper.ReferenceType.Name;
    }
    protected override string NodeTip()
    {
      return Wrapper.ReferenceType.ToString();
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_Reference;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.ReferenceType;
    public override string ToString()
    {
      return Wrapper.ReferenceType.ToString();
    }
    public override NodeTypeEnum NodeType => NodeTypeEnum.OpcUaNode;
    #endregion

  }
}
