//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using System.Linq;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class ReferencesFolder : Folder
  {
    #region creators
    internal ReferencesFolder() : base("References", WrapperResources.ReferencesFolderNodeToolTipText)
    {
      TypesAvailableToBePasted.Add(typeof(Opc.Ua.ModelCompiler.Reference));
    }
    internal ReferencesFolder(Opc.Ua.ModelCompiler.Reference[] refrences) : this()
    {
      if (refrences == null || refrences.Length == 0)
        return;
      foreach (Opc.Ua.ModelCompiler.Reference rf in refrences)
        Add(new Reference(rf));
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the name of the topic in help.
    /// </summary>
    /// <value>The name of the topic in help.</value>
    public override string HelpTopicName => Resources.NodeClasses_Objects_ReferencesFolder;
    internal Opc.Ua.ModelCompiler.Reference[] References
    {
      get
      {
        if (this.Count == 0)
          return null;
        int ii = 0;
        Opc.Ua.ModelCompiler.Reference[] array = new Opc.Ua.ModelCompiler.Reference[Count];
        foreach (IParent node in this)
          array[ii++] = (Opc.Ua.ModelCompiler.Reference)node.ModelDesignerNode;
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
