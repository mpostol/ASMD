//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using System.Collections.Generic;
using UAOOI.Configuration.Core;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// <see cref="VariableDesignTreeNodeControl"/> representing <see cref="OpcUaModelCompiler.VariableDesign"/> in the model structure
  /// </summary>
  internal partial class VariableDesign : InstanceDesign<Wrappers4ProperyGrid.VariableDesign<OpcUaModelCompiler.VariableDesign>, OpcUaModelCompiler.VariableDesign>
  {
    #region creators

    public VariableDesign() : base(new Wrappers4ProperyGrid.VariableDesign<OpcUaModelCompiler.VariableDesign>(new OpcUaModelCompiler.VariableDesign()))
    {
    }

    public VariableDesign(OpcUaModelCompiler.VariableDesign node) : base(new Wrappers4ProperyGrid.VariableDesign<OpcUaModelCompiler.VariableDesign>(node), node)
    {
    }

    #endregion creators

    #region private

    protected override void AddNodeDescriptors(List<INodeDescriptor> dsptrs, UniqueIdentifier ui)
    {
      ui.Update(false, Wrapper.SymbolicName.XmlQualifiedName, false);
      dsptrs.Add(Wrapper.GetINodeDescriptor(ui, this.NodeClass));
      base.AddNodeDescriptors(dsptrs, ui);
    }

    #endregion private

    #region public

    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_Variable;

    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.Variable;

    #endregion public
  }
}