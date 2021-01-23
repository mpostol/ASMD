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
  internal class EncodingsFolder : Folder
  {
    #region constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="EncodingsFolder"/> class.
    /// </summary>
    /// <param name="parameters">The parameters to be added to the tree.</param>
    /// <param name="text">The node text.</param>
    /// <param name="toolStripTip">The tool strip tip text.</param>
    public EncodingsFolder(OpcUaModelCompiler.EncodingDesign[] parameters, string text, string toolStripTip) : base(text, toolStripTip)
    {
      if (parameters == null || parameters.Length == 0)
        return;
      foreach (OpcUaModelCompiler.EncodingDesign rf in parameters)
        Add(new EncodingDesign(rf));
    }

    #endregion constructor

    #region public

    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_EncodingsFolder;

    internal OpcUaModelCompiler.EncodingDesign[] CreateParameters()
    {
      if (Count == 0)
        return null;
      int ii = 0;
      OpcUaModelCompiler.EncodingDesign[] array = new OpcUaModelCompiler.EncodingDesign[Count];
      foreach (EncodingDesign node in this)
        array[ii++] = (OpcUaModelCompiler.EncodingDesign)node.ModelDesignerNode;
      return array;
    }

    public override NodeTypeEnum NodeType => NodeTypeEnum.EncodinsForlderNode;

    #endregion public

    #region private

    internal INodeFactory[] ListOfNodes
    {
      get
      {
        TypeListItem<EncodingDesign>[] m_list = new TypeListItem<EncodingDesign>[1];
        m_list[0] = new TypeListItem<EncodingDesign>();
        return m_list;
      }
    }

    #endregion private
  }
}