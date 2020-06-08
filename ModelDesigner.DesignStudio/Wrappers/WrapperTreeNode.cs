//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.IServerConfiguration;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.ToForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UAOOI.Windows.Forms;

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
      string clipboard = string.Empty;
      try
      {
        clipboard = System.Windows.Forms.Clipboard.GetText();
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

    #endregion public

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
        XmlTextReader xmlTextReader = new XmlTextReader(stringReader)
        {
          WhitespaceHandling = WhitespaceHandling.None
        };
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

    internal void AddMenuItemPaste_Click(object sender, EventArgs e)
    {
      MenuItemPaste_Action();
    }

    internal void AddMenuItemCopy_Click(object sender, EventArgs e)
    {
      MenuItemCopy_Action();
    }

    internal void AddMenuItemCut_Click(object sender, EventArgs e)
    {
      MenuItemCut_Action();
    }

    internal void AddMenuItemDelete_Click(object sender, EventArgs e)
    {
      string msg = string.Format(WrapperResources.DeleteObjectWarning, this.Text, this.ToolTipText);
      if (MessageBoxHandling.Show
        (
          msg,
          WrapperResources.DeleteObjectCaption,
          MessageBoxButtons.OKCancel,
          MessageBoxIcon.Question
        ) != DialogResult.OK)
        return;
      this.Parent.Remove(this);
    }

    //TODO Removed dependency of the CAS.UA.Model.Designer.Wrappers on using System.Windows.Forms #38
    internal void AddMenuItemAdd_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.ToolStripMenuItem mi = (System.Windows.Forms.ToolStripMenuItem)sender;
      INodeFactory factory = (INodeFactory)mi.Tag;
      ValidableTreeNode node = factory.Node;
      this.Add(node);
      using (AddObject<object> form = new AddObject<object>(node.Wrapper))
      {
        form.Size = new Size(600, 500);
        if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK)
        {
          this.Remove(node);
          return;
        }
      }
      node.Validate();
    }

    #endregion private menu handlers

    #endregion private

    #region constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="WrapperTreeNode"/> class.
    /// </summary>
    /// <param name="wrapper">The instance that will be used as a wrapper to provide user interface.</param>
    public WrapperTreeNode(object wrapper) : this(wrapper, string.Empty) { }

    internal WrapperTreeNode(object wrapper, string nodeName) : base(nodeName)
    {
      Wrapper = wrapper;
      ErrorList = new List<Diagnostics>();
    }

    #endregion constructor

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
      MessageBoxHandling.Show(Resources.WrapperTreeNode_menu_paste_cannot_be_done);
    }

    public virtual Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> GetFolders()
    {
      return new Dictionary<FolderType, IEnumerable<IModelNodeAdvance>>();
    }

    public abstract NodeTypeEnum NodeType { get; }

    #endregion IModelNodeAdvanced

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
    public string Name => Text;

    /// <summary>
    /// Gets the error list.
    /// </summary>
    /// <value>The error list.</value>
    public IList<Diagnostics> ErrorList { get; private set; }

    /// <summary>
    /// Gets an editor that wraps the node in the property grid user interface.
    /// </summary>
    /// <value>The wrapper.</value>
    public object Wrapper4PropertyGrid => Wrapper;

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
    public bool IsReadOnly => TestIfReadOnlyAndRetrunTrueIfReadOnly();

    /// <summary>
    /// Gets the symbolic name.
    /// </summary>
    /// <value>The symbolic name.</value>
    public virtual XmlQualifiedName SymbolicName => new XmlQualifiedName();

    /// <summary>
    /// Gets or sets the message box handling.
    /// </summary>
    /// <value>The message box handling.</value>
    protected internal IMessageBoxHandling MessageBoxHandling { protected get; set; }

    #endregion IModelNode Members

    #region public

    /// <summary>
    /// Retries za instance of the interface <see cref="INodeDescriptor"/> that provides the description of the node to be
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

    #endregion public

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

      IModelNodeAdvance IEnumerator<IModelNodeAdvance>.Current => myIEnumerator.Current as IModelNodeAdvance;

      #endregion IEnumerator<IModelNodeAdvance> Members

      #region IDisposable Members

      void IDisposable.Dispose()
      {
        ;
      }

      #endregion IDisposable Members

      #region IEnumerator Members

      object System.Collections.IEnumerator.Current => myIEnumerator.Current;

      bool System.Collections.IEnumerator.MoveNext()
      {
        return myIEnumerator.MoveNext();
      }

      void System.Collections.IEnumerator.Reset()
      {
        myIEnumerator.Reset();
      }

      #endregion IEnumerator Members
    }

    #endregion IEnumerable<IModelNodeAdvance> Members

    #region IEnumerable Members

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    #endregion IEnumerable Members

    #region Diagnostics

    [System.Diagnostics.Conditional("DEBUG")]
    internal void GetMessageBoxHandling(Action<IMessageBoxHandling> messageBoxHandlingGetter)
    {
      messageBoxHandlingGetter(MessageBoxHandling);
    }

    #endregion Diagnostics
  }
}