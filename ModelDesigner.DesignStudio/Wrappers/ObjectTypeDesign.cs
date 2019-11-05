//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________


using CAS.UA.Model.Designer.Properties;
using BaseModelType = Opc.Ua.ModelCompiler.ObjectTypeDesign;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class ObjectTypeDesign : TypeDesign<Wrappers4ProperyGrid.ObjectTypeDesign<BaseModelType>, BaseModelType>
  {

    #region private
    protected static ObjectTypeDesign FolderType { get; private set; }
    #endregion

    #region constructor
    public ObjectTypeDesign() : base(new Wrappers4ProperyGrid.ObjectTypeDesign<BaseModelType>(new BaseModelType())) { }
    public ObjectTypeDesign(BaseModelType node) : base(new Wrappers4ProperyGrid.ObjectTypeDesign<BaseModelType>(node), node) { }
    #endregion

    #region public
    public override string HelpTopicName => Resources.NodeClasses_Types_ObjectType;
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.ObjectType;
    internal enum StandardTypes { FolderType };
    #endregion

  }
}
