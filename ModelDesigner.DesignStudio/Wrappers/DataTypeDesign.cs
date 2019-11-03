//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________


using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.Properties;
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal partial class DataTypeDesign: TypeDesign<Wrappers4ProperyGrid.DataTypeDesign, Opc.Ua.ModelCompiler.DataTypeDesign>
  {

    #region private
    private ParametersFolder m_Fields = null;
    private EncodingsFolder m_Encodings = null;
    private void AddEncodings( Opc.Ua.ModelCompiler.EncodingDesign[] fields )
    {
      m_Encodings = new EncodingsFolder( fields, "Encodings", "Encodings collection" );
      Add( m_Encodings );
    }
    private void AddFilds( Opc.Ua.ModelCompiler.Parameter[] parameters )
    {
      m_Fields = new ParametersFolder
        ( parameters, WrapperResources.DataTypeParametersNodeText, WrapperResources.DataTypeParametersNodeTipText );
      Add( m_Fields );
    }
    /// <summary>
    /// Add this node to the address space <see cref="IAddressSpaceCreator"/>.
    /// </summary>
    /// <param name="space">The address space.</param>
    protected override void AddNode2AddressSpace( IAddressSpaceCreator space )
    {
      base.AddNode2AddressSpace( space );
      foreach ( var item in m_Fields )
      {
        //TODO add field to AddressSpace
      }
    }
    //private class DataTypeDesignTreeNodeControl : TypeDesignTreeNodeControl<DataTypeDesign, Wrappers4ProperyGrid.DataTypeDesign, Opc.Ua.ModelCompiler.DataTypeDesign>
    //{
    //  #region creator
    //  public DataTypeDesignTreeNodeControl( DataTypeDesign parent )
    //    : base( parent )
    //  { }
    //  #endregion
    //}
    #endregion private

    #region creators
    public DataTypeDesign()
      : base( new CAS.UA.Model.Designer.Wrappers4ProperyGrid.DataTypeDesign( new Opc.Ua.ModelCompiler.DataTypeDesign() ) )
    {
      AddFilds( null );
      AddEncodings( null );
    }
    public DataTypeDesign( Opc.Ua.ModelCompiler.DataTypeDesign node )
      : base( new Wrappers4ProperyGrid.DataTypeDesign( node ), node )
    {
      AddFilds( node.Fields );
      AddEncodings( node.Encodings );
    }
    #endregion

    #region public
    public override Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> GetFolders()
    {
      Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> tobereturned = base.GetFolders();
      tobereturned.Add( FolderType.Fields, Fields );
      return tobereturned;
    }
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.NodeClasses_Types_DataType; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.DataType; }
    }
    /// <summary>
    /// Gets the parameter folder with fields.
    /// </summary>
    /// <value>The fields.</value>
    public ParametersFolder Fields { get { return m_Fields; } }
    /// <summary>
    /// Gets the model designer node.
    /// </summary>
    /// <value>The model designer node.</value>
    public override object ModelDesignerNode
    {
      get
      {
        Opc.Ua.ModelCompiler.DataTypeDesign node = (Opc.Ua.ModelCompiler.DataTypeDesign)base.ModelDesignerNode;
        node.Fields = m_Fields.CreateParameters();
        node.Encodings = m_Encodings.CreateParameters();
        return node;
      }
    }
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      return new DataTypeDesignTreeNodeControl( this );
    }
    #endregion

  }
}
