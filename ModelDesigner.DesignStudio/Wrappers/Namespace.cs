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
  internal partial class Namespace : WrapperBase<Wrappers4ProperyGrid.Namespace, OpcUaModelCompiler.Namespace>
  {
    #region constructor

    public Namespace() : this(new OpcUaModelCompiler.Namespace())
    {
    }

    public Namespace(OpcUaModelCompiler.Namespace child) : base(new Wrappers4ProperyGrid.Namespace(child))
    {
    }

    #endregion constructor

    #region public

    public override NodeTypeEnum NodeType => NodeTypeEnum.NamespaceNode;

    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Namespace;

    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.None;

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString()
    {
      string format = "{0}.{1}/{2}[{3}]";
      return string.Format(format, Wrapper.Prefix, this.Text, Wrapper.Value, Wrapper.XmlNamespace);
    }

    internal string NamespaceValue => Wrapper.Value;

    #endregion public

    #region private

    protected override string NodeName()
    {
      return Wrapper.Name;
    }

    protected override string NodeTip()
    {
      return ToString();
    }

    #endregion private
  }
}