﻿//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class ReferenceTypeDesign : TypeDesign<Wrappers4ProperyGrid.ReferenceTypeDesign, OpcUaModelCompiler.ReferenceTypeDesign>
  {
    #region constructor

    public ReferenceTypeDesign() : base(new Wrappers4ProperyGrid.ReferenceTypeDesign(new OpcUaModelCompiler.ReferenceTypeDesign()))
    {
    }

    public ReferenceTypeDesign(OpcUaModelCompiler.ReferenceTypeDesign node) : base(new Wrappers4ProperyGrid.ReferenceTypeDesign(node), node)
    {
    }

    #endregion constructor

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

    #endregion public
  }
}