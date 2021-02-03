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
  internal class ObjectTypeDesign : TypeDesign<Wrappers4ProperyGrid.ObjectTypeDesign<OpcUaModelCompiler.ObjectTypeDesign>, OpcUaModelCompiler.ObjectTypeDesign>
  {
    #region private

    protected static ObjectTypeDesign FolderType { get; private set; }

    #endregion private

    #region constructor

    public ObjectTypeDesign() : base(new Wrappers4ProperyGrid.ObjectTypeDesign<OpcUaModelCompiler.ObjectTypeDesign>(new OpcUaModelCompiler.ObjectTypeDesign()))
    {
    }

    public ObjectTypeDesign(OpcUaModelCompiler.ObjectTypeDesign node) : base(new Wrappers4ProperyGrid.ObjectTypeDesign<OpcUaModelCompiler.ObjectTypeDesign>(node), node)
    {
    }

    #endregion constructor

    #region public

    public override string HelpTopicName => Resources.NodeClasses_Types_ObjectType;

    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.ObjectType;

    internal enum StandardTypes { FolderType };

    #endregion public
  }
}