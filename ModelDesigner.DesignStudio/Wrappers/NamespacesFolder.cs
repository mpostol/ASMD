//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________


using CAS.UA.Model.Designer.Properties;
using System.Xml.Serialization;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class NamespacesFolder : Folder
  {
    #region cretors
    internal NamespacesFolder(Opc.Ua.ModelCompiler.ModelDesign child) : base("Namespaces", WrapperResources.NamespaceFolderToolTipText)
    {
      TypesAvailableToBePasted.Add(typeof(Opc.Ua.ModelCompiler.Namespace));
      if (child.Namespaces == null || child.Namespaces.Length == 0)
        return;
      foreach (Opc.Ua.ModelCompiler.Namespace ns in child.Namespaces)
        this.Add(new Namespace(ns));
    }
    #endregion

    #region public
    public override NodeTypeEnum NodeType => NodeTypeEnum.NamespaceFolderNode;
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.NodeClasses_NamespaceFolder;
    internal Opc.Ua.ModelCompiler.Namespace[] Namespaces
    {
      get
      {
        Opc.Ua.ModelCompiler.Namespace[] array = new Opc.Ua.ModelCompiler.Namespace[this.Count];
        int ii = 0;
        foreach (Namespace node in this)
          array[ii++] = (Opc.Ua.ModelCompiler.Namespace)node.ModelDesignerNode;
        return array;
      }
    }
    /// <summary>
    /// Gets the XML namespaces <see cref="XmlSerializerNamespaces"/> to be used while serializing the model.
    /// </summary>
    /// <value><see cref="XmlSerializerNamespaces"/> the XML namespaces.</value>
    internal XmlSerializerNamespaces XmlNamespaces
    {
      get
      {
        XmlSerializerNamespaces col = new XmlSerializerNamespaces();
        col.Add(PrepareNamespacePrefix(Properties.Settings.Default.XmlSchemaInstancePrefix), Properties.Settings.Default.XmlSchemaInstanceNamespace);
        col.Add(PrepareNamespacePrefix(Properties.Settings.Default.XmlSchemaPrefix), Properties.Settings.Default.XmlSchemaNamespace);
        col.Add(PrepareNamespacePrefix(Properties.Settings.Default.XmlOPCTypesPrefix), Properties.Settings.Default.XmlOPCTypesNamespace);
        foreach (Namespace node in this)
          col.Add(PrepareNamespacePrefix(node.Wrapper.XmlPrefix), node.Wrapper.Value);
        return col;
      }
    }
    internal string[] GetAvailableNamespaces()
    {
      string[] AvailableNamespaces = new string[Count];
      int idx = 0;
      foreach (Namespace node in this)
      {
        AvailableNamespaces[idx++] = node.NamespaceValue;
      }
      return AvailableNamespaces;
    }
    #endregion

    #region private
    private static int count = 0;
    private string PrepareNamespacePrefix(string namespacePrefix)
    {
      if (string.IsNullOrEmpty(namespacePrefix))
        return string.Format("ns{0}", count++);
      string ret = namespacePrefix;
      foreach (char chr in Resources.NamespaceFolderCharacterToBeRemovedFromNamespacePrefix.ToCharArray())
        ret = ret.Replace(chr.ToString(), "");
      if (ret.IndexOf("xml") == 0)
        ret = Resources.NamespaceFolderCharacterNamespacePrefix_XMLatTheBeginningReplacement + ret;
      return ret;
    }
    internal INodeFactory[] ListOfNodes => new TypeListItem<Namespace>[] { new TypeListItem<Namespace>() };
    #endregion

  }
}
