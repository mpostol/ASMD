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
  internal class ParametersFolder: Folder
  {
    
    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="ParametersFolder"/> class.
    /// </summary>
    /// <param name="parameters">The parameters to be added to the tree.</param>
    /// <param name="text">The node text.</param>
    /// <param name="toolStripTip">The tool strip tip text.</param>
    public ParametersFolder
      (
        OpcUaModelCompiler.Parameter[] parameters,
        string text,
        string toolStripTip
      )
      : base( text, toolStripTip )
    {
      TypesAvailableToBePasted.Add( typeof( OpcUaModelCompiler.Parameter ) );
      if ( parameters == null || parameters.Length == 0 )
        return;
      foreach ( OpcUaModelCompiler.Parameter rf in parameters )
        Add( new Parameter( rf ) );
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Objects_ParametersFolder; }
    }
    internal OpcUaModelCompiler.Parameter[] CreateParameters()
    {
      if ( Count == 0 )
        return null;
      int ii = 0;
      OpcUaModelCompiler.Parameter[] array = new OpcUaModelCompiler.Parameter[ Count ];
      foreach ( Parameter node in this )
        array[ ii++ ] = (OpcUaModelCompiler.Parameter)node.ModelDesignerNode;
      return array;
    }
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.ParametersFolderNode; }
    }
    #endregion

    #region private
    internal INodeFactory[] ListOfNodes
    {
      get
      {
        TypeListItem<Parameter>[] m_list = new TypeListItem<Parameter>[1];
        m_list[0] = new TypeListItem<Parameter>();
        return m_list;
      }
    }
    #endregion

  }
}
