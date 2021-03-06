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
  internal partial class EncodingDesign : WrapperBase<Wrappers4ProperyGrid.EncodingDesign, OpcUaModelCompiler.EncodingDesign>
  {
    #region creators

    public EncodingDesign() : base(new Wrappers4ProperyGrid.EncodingDesign(new OpcUaModelCompiler.EncodingDesign()))
    {
    }

    public EncodingDesign(OpcUaModelCompiler.EncodingDesign parameter) : base(new Wrappers4ProperyGrid.EncodingDesign(parameter))
    {
    }

    #endregion creators

    #region private

    protected override string NodeName()
    {
      return Wrapper.SymbolicName.Name;
    }

    protected override string NodeTip()
    {
      return Wrapper.Description.ToString();
    }

    #endregion private

    #region public

    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_Encoding;

    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.Encoding;

    public override NodeTypeEnum NodeType => NodeTypeEnum.OpcUaNode;

    #endregion public
  }
}