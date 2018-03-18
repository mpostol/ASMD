//<summary>
//  Title   : Wrapper Tree Node
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.Lib.ControlLibrary;
using CAS.UA.IServerConfiguration;
using CAS.UA.Model.Designer.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Model node that has editable properties associated.
  /// </summary>
  internal abstract class WrapperTreeNode : BaseTreeNode, IModelNode, IModelNodeAdvance, IEnumerable<IModelNodeAdvance>
  {
    #region public
    internal static object GetModelDesignerNodeFromStringRepresentationFromClipboard()
    {
      string clipboard = Clipboard.GetText();
      try
      {
        clipboard = Clipboard.GetText();
      }
      catch
      { return null; }
      return GetModelDesignerNodeFromStringRepresentation(clipboard);
    }
    /// <summary>
    /// Gets or sets the child - the object representing ModelDesign node class.
    /// </summary>
    /// <value>The child.</value>
    public virtual object Wrapper { get; private set; }
    #endregion

    #region private
    protected List<Type> TypesAvailableToBePasted = new List<Type>();
    private bool ShouldPasteMenuBeEnabled(object DeserializedNode)
    {
      if (DeserializedNode == null)
        return false;
      foreach (Type type in TypesAvailableToBePasted)
        if (DeserializedNode.GetType().Equals(type) || DeserializedNode.GetType().IsSubclassOf(type))
          return true;
      return false;
    }
    private static object GetModelDesignerNodeFromStringRepresentation(string modelDesignerNodeStringRepresentation)
    {
      if (string.IsNullOrEmpty(modelDesignerNodeStringRepresentation))
        return null;
      if (modelDesignerNodeStringRepresentation.IndexOf("<?xml") != 0)
        return null;
      try
      {
        StringReader stringReader = new StringReader(modelDesignerNodeStringRepresentation);
        XmlTextReader xmlTextReader = new XmlTextReader(stringReader);
        xmlTextReader.WhitespaceHandling = WhitespaceHandling.None;
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(xmlTextReader);
        if (xmlDocument.DocumentElement == null)
          return null;
        string SerializedTypeAsString = typeof(Opc.Ua.ModelCompiler.NodeDesign).Namespace + "." + xmlDocument.DocumentElement.Name;
        Type SerializedType = Type.GetType(SerializedTypeAsString);
        if (SerializedType == null)
        {
          SerializedTypeAsString += ", Opc.Ua.ModelCompiler"; // we have to try also load to from different assembly
          SerializedType = Type.GetType(SerializedTypeAsString);
        }
        if (SerializedType == null)
          return null;
        XmlSerializer serializer = new XmlSerializer(SerializedType);
        stringReader = new StringReader(modelDesignerNodeStringRepresentation);
        return serializer.Deserialize(stringReader);
      }
      catch
      {
        return null;
      }
    }
    #region private menu handlers
    private void AddMenuItemPaste_Click(object sender, EventArgs e)
    {
      MenuItemPaste_Action();
    }
    private void AddMenuItemCopy_Click(object sender, EventArgs e)
    {
      MenuItemCopy_Action();
    }
    private void AddMenuItemCut_Click(object sender, EventArgs e)
    {
      MenuItemCut_Action();
    }
    private void AddMenuItemDelete_Click(object sender, EventArgs e)
    {
      string msg = String.Format(WrapperResources.DeleteObjectWarning, this.Text, this.ToolTipText);
      if (MessageBox.Show
        (
          msg,
          WrapperResources.DeleteObjectCaption,
          MessageBoxButtons.OKCancel,
          MessageBoxIcon.Question
        ) != DialogResult.OK)
        return;
      this.Parent.Remove(this);
    }
    private void AddMenuItemAdd_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem mi = (ToolStripMenuItem)sender;
      INodeFactory factory = (INodeFactory)mi.Tag;
      ValidableTreeNode node = factory.Node;
      this.Add(node);
      using (AddObject<object> form = new AddObject<object>(node.Wrapper))
      {
        form.Size = new Size(600, 500);
        if (form.ShowDialog() != DialogResult.OK)
        {
          this.Remove(node);
          return;
        }
      }
      node.Validate();
    }
    #endregion
    protected new abstract class TreeNode<T> : BaseTreeNode.TreeNode<T>, IWrapperTreeNode
      where T : WrapperTreeNode, IModelNode, IModelNodeAdvance
    {
      #region creator
      public TreeNode(T parent)
        : base(parent)
      { }
      #endregion

      #region private
      private List<Diagnostics> m_ErrorList = new List<Diagnostics>();
      protected IModelNode MyIModelNode { get { return this.Creator as IModelNode; } }
      /// <summary>
      /// Gets the wrappers to be used in the <see cref="System.Windows.Forms.PropertyGrid"/>.
      /// </summary>
      /// <value>The wrappers,i.e. node configuration wappers.</value>
      protected virtual void AddMenuItemAdd(INodeFactory[] listOfNodes)
      {
        ToolStripMenuItem menu = new ToolStripMenuItem(Properties.Resources.WrapperTreeNode_menu_add_object, Resources.AdddItem)
        {
          Enabled = !Creator.TestIfReadOnlyAndRetrunTrueIfReadOnly()
        };
        ContextMenuStrip.Items.Add(menu);
        foreach (INodeFactory item in listOfNodes)
        {
          string node_name = item.ToString().Replace("Design", "");
          ToolStripMenuItem sm = new ToolStripMenuItem(node_name)
          {
            Tag = item,
            Enabled = !Creator.TestIfReadOnlyAndRetrunTrueIfReadOnly()
          };
          sm.Click += new EventHandler(Creator.AddMenuItemAdd_Click);
          menu.DropDownItems.Add(sm);
        }
      }
      protected void AddMenuItemCopyPasteCut()
      {
        if (ContextMenuStrip.Items.Count > 0)
          ContextMenuStrip.Items.Add(new ToolStripSeparator());
        AddMenuItemCopy();
        AddMenuItemPaste();
        AddMenuItemCut();
      }
      protected void AddMenuItemCut()
      {
        ToolStripMenuItem menu;
        menu = new ToolStripMenuItem(Properties.Resources.WrapperTreeNode_menu_cut, Resources.cut)
        {
          Enabled = !Creator.TestIfReadOnlyAndRetrunTrueIfReadOnly()
        };
        menu.Click += new EventHandler(Creator.AddMenuItemCut_Click);
        ContextMenuStrip.Items.Add(menu);
      }
      protected void AddMenuItemCopy()
      {
        ToolStripMenuItem menu = new ToolStripMenuItem(Properties.Resources.WrapperTreeNode_menu_copy, Resources.copy);
        menu.Click += new EventHandler(Creator.AddMenuItemCopy_Click);
        ContextMenuStrip.Items.Add(menu);
      }
      protected void AddMenuItemPaste()
      {
        ToolStripMenuItem MenuPaste = new ToolStripMenuItem(Properties.Resources.WrapperTreeNode_menu_paste, Resources.paste)
        {
          Enabled = !Creator.TestIfReadOnlyAndRetrunTrueIfReadOnly() && Creator.ShouldPasteMenuBeEnabled()
        };
        MenuPaste.Click += new EventHandler(Creator.AddMenuItemPaste_Click);
        ContextMenuStrip.Items.Add(MenuPaste);
      }
      protected virtual void AddMenuItemDelete()
      {
        ToolStripMenuItem menu = new ToolStripMenuItem(Properties.Resources.WrapperTreeNode_menu_delete, Resources.delete)
        {
          Enabled = !Creator.TestIfReadOnlyAndRetrunTrueIfReadOnly()
        };
        menu.Click += new EventHandler(Creator.AddMenuItemDelete_Click);
        ContextMenuStrip.Items.Add(menu);
      }
      #endregion

      #region IWrapperTreeNode Members
      /// <summary>
      /// Gets the instance of the model node. Model node represents the location of the node in the model hierarchy.
      /// </summary>
      /// <value>
      /// An instance of class inherited from <see cref="IModelNodeAdvance"/>.
      /// </value>
      IModelNodeAdvance IWrapperTreeNode.IModelNodeAdvance { get { return this.Creator as IModelNodeAdvance; } }
      /// <summary>
      /// Gets or sets the name of the tree node.
      /// </summary>
      /// <value></value>
      /// <returns>
      /// A <see cref="T:System.String"/> that represents the name of the tree node.
      /// </returns>
      string IModelNode.Name
      {
        get { return Creator.Name; }
      }
      /// <summary>
      /// Gets the error list.
      /// </summary>
      /// <value>The error list.</value>
      IList<Diagnostics> IModelNode.ErrorList
      {
        get { return m_ErrorList; }
      }
      /// <summary>
      /// Gets the wrapper of the node to be used in the property grid user interface.
      /// </summary>
      /// <value>The wrapper.</value>
      object IModelNode.Wrapper4PropertyGrid
      {
        get { return Creator.Wrapper4PropertyGrid; }
      }
      /// <summary>
      /// Gets the wrapper for property grid of data bindings.
      /// </summary>
      /// <returns></returns>
      /// <return>The wrapper data bindings property grid.</return>
      INodeDescriptor IModelNode.GetINodeDescriptor()
      {
        UniqueIdentifier ui = new UniqueIdentifier();
        if (!GetUniqueIdentifier(ui))
          return null;
        return Creator.GetINodeDescriptor(ui);
      }
      /// <summary>
      /// Gets the name of the node class.
      /// </summary>
      /// <value>The name of the node class.</value>
      NodeClassesEnum IModelNode.NodeClass
      {
        get { return Creator.NodeClass; }
      }
      /// <summary>
      /// Gets the name of the help topic.
      /// </summary>
      /// <value>
      /// Unique identifier to be used as the key to select the help topic.
      /// </value>
      string IModelNode.HelpTopicName
      {
        get { return Creator.HelpTopicName; }
      }
      /// <summary>
      /// Gets a value indicating whether this instance is read only.
      /// </summary>
      /// <value>
      /// 	<c>true</c> if this instance is read only; otherwise, <c>false</c>.
      /// </value>
      bool IModelNode.IsReadOnly
      {
        get { return Creator.IsReadOnly; }
      }
      /// <summary>
      /// Gets the symbolic name.
      /// </summary>
      /// <value>The symbolic name.</value>
      public virtual XmlQualifiedName SymbolicName
      {
        get
        {
          return new XmlQualifiedName();
        }
      }
      #endregion
    }
    #endregion

    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="WrapperTreeNode"/> class.
    /// </summary>
    /// <param name="wrapper">The instance that will be used as a wrapper to provide user interface.</param>
    public WrapperTreeNode(object wrapper)
      : this(wrapper, String.Empty)
    { }
    internal WrapperTreeNode(object wrapper, string nodeName) : base(nodeName)
    {
      Wrapper = wrapper;
      ErrorList = new List<Diagnostics>();
    }
    #endregion creators

    #region IModelNodeAdvanced
    public virtual void MenuItemCopy_Action()
    { }
    public virtual void MenuItemCut_Action()
    {
      MenuItemCopy_Action();
      this.Parent.Remove(this);
    }
    public virtual bool ShouldPasteMenuBeEnabled()
    {
      object DeserializedNode = GetModelDesignerNodeFromStringRepresentationFromClipboard();
      return ShouldPasteMenuBeEnabled(DeserializedNode);
    }
    public virtual void MenuItemPaste_Action()
    {
      object DeserializedNode = GetModelDesignerNodeFromStringRepresentationFromClipboard();
      if (ShouldPasteMenuBeEnabled(DeserializedNode))
      {
        this.Add(NodeFactory.Create(DeserializedNode));
        return;
      }
      MessageBox.Show(Resources.WrapperTreeNode_menu_paste_cannot_be_done);
    }
    public virtual Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> GetFolders()
    {
      return new Dictionary<FolderType, IEnumerable<IModelNodeAdvance>>();
    }
    public abstract NodeTypeEnum NodeType { get; }
    #endregion

    #region IModelNode Members
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>
    /// Unique identifier to be used as the key to select the help topic.
    /// </value>
    public abstract string HelpTopicName { get; }
    /// <summary>
    /// Gets the name of the node class.
    /// </summary>
    /// <value>The name of the node class.</value>
    public abstract NodeClassesEnum NodeClass { get; }
    /// <summary>
    /// Gets the name of the node.
    /// </summary>
    /// <value>
    /// The name represented as an instance of the <see cref="string"/>.
    /// </value>
    public string Name { get { return Text; } }
    /// <summary>
    /// Gets the error list.
    /// </summary>
    /// <value>The error list.</value>
    public IList<Diagnostics> ErrorList { get; private set; }
    /// <summary>
    /// Gets an editot that wrapps the node in the property grid user interface.
    /// </summary>
    /// <value>The wrapper.</value>
    public object Wrapper4PropertyGrid
    {
      get { return Wrapper; }
    }
    /// <summary>
    /// An instance of the interface <see cref="INodeDescriptor"/> that provides the description of the node to be
    /// bind with an external data source.
    /// </summary>
    /// <returns></returns>
    /// <return>An instance of the interface <see cref="INodeDescriptor"/> to be bound with external data source.</return>
    public virtual INodeDescriptor GetINodeDescriptor()
    {
      return null;
    }
    /// <summary>
    /// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
    /// </summary>
    /// <value></value>
    /// <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only; otherwise, false.
    /// </returns>
    public bool IsReadOnly
    {
      get
      {
        return TestIfReadOnlyAndRetrunTrueIfReadOnly();
      }
    }
    /// <summary>
    /// Gets the symbolic name.
    /// </summary>
    /// <value>The symbolic name.</value>
    public virtual XmlQualifiedName SymbolicName
    {
      get
      {
        return new XmlQualifiedName();
      }
    }
    #endregion

    #region public
    /// <summary>
    /// Retrives za instance of the interface <see cref="INodeDescriptor"/> that provides the description of the node to be
    /// bind with an external data source.
    /// </summary>
    /// <param name="UniqueIdentifierOfRequestedWrapper">The unique identifier of requested node descriptor.</param>
    /// <returns>
    /// An instance of the interface <see cref="INodeDescriptor"/> to be bound with external data source.
    /// </returns>
    internal virtual INodeDescriptor GetINodeDescriptor(UniqueIdentifier UniqueIdentifierOfRequestedWrapper)
    {
      return null;
    }
    #endregion

    #region IEnumerable<IModelNodeAdvance> Members
    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
    /// </returns>
    IEnumerator<IModelNodeAdvance> IEnumerable<IModelNodeAdvance>.GetEnumerator()
    {
      return new WrapperTreeNodeImodelNodeEnumerator(this);
    }

    /// <summary>
    /// Private enumerator for WrapperTreeNode
    /// </summary>
    private class WrapperTreeNodeImodelNodeEnumerator : IEnumerator<IModelNodeAdvance>
    {
      private System.Collections.IEnumerator myIEnumerator;
      internal WrapperTreeNodeImodelNodeEnumerator(WrapperTreeNode selectedWrapperTreeNode)
      {
        myIEnumerator = selectedWrapperTreeNode.GetEnumerator();
      }
      #region IEnumerator<IModelNodeAdvance> Members

      IModelNodeAdvance IEnumerator<IModelNodeAdvance>.Current
      {
        get { return myIEnumerator.Current as IModelNodeAdvance; }
      }

      #endregion

      #region IDisposable Members

      void IDisposable.Dispose()
      {
        ;
      }

      #endregion

      #region IEnumerator Members

      object System.Collections.IEnumerator.Current
      {
        get { return myIEnumerator.Current; }
      }

      bool System.Collections.IEnumerator.MoveNext()
      {
        return myIEnumerator.MoveNext();
      }

      void System.Collections.IEnumerator.Reset()
      {
        myIEnumerator.Reset();
      }

      #endregion
    }
    #endregion

    #region IEnumerable Members
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
    #endregion
  }
}
