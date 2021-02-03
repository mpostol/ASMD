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
  internal class ReferencesFolder : Folder
  {
    #region creators
    internal ReferencesFolder() : base("References", WrapperResources.ReferencesFolderNodeToolTipText)
    {
      TypesAvailableToBePasted.Add(typeof(OpcUaModelCompiler.Reference));
    }
    internal ReferencesFolder(OpcUaModelCompiler.Reference[] refrences) : this()
    {
      if (refrences == null || refrences.Length == 0)
        return;
      foreach (OpcUaModelCompiler.Reference rf in refrences)
        Add(new Reference(rf));
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the topic in help.
    /// </summary>
    /// <value>The name of the topic in help.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_ReferencesFolder;
    internal OpcUaModelCompiler.Reference[] References
    {
      get
      {
        if (this.Count == 0)
          return null;
        int ii = 0;
        OpcUaModelCompiler.Reference[] array = new OpcUaModelCompiler.Reference[Count];
        foreach (IParent node in this)
          array[ii++] = (OpcUaModelCompiler.Reference)node.ModelDesignerNode;
        return array;
      }
    }
    public override NodeTypeEnum NodeType => NodeTypeEnum.ReferencesFolderNode;
    #endregion

    #region private
    internal INodeFactory[] ListOfNodes
    {
      get
      {
        TypeListItem<Reference>[] m_list = new TypeListItem<Reference>[1];
        m_list[0] = new TypeListItem<Reference>();
        return m_list;
      }
    }
    #endregion

  }
}
