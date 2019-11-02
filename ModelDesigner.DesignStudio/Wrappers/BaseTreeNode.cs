//<summary>
//  Title   : Base class to create in-memory representation of the UA address space model
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

using CAS.UA.IServerConfiguration;
using CAS.UA.Model.Designer.Controls; //Bootstrapper exception - casting problem #37 - must be removed
using System;
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.Wrappers
{

  internal interface IBaseModel : IEnumerable<IBaseModel>
  {
    event EventHandler<BaseTreeNode.TextEventArgs> TextChanged;
    event EventHandler<BaseTreeNode.ProjectEventArgs> SubtreeChanged;
    string ToolTipText { get; set; }
    string Text { get; set; }
    BaseDictionaryTreeNode GetTreeNode();
  }

  /// <summary>
  /// A collection <see cref="List{BaseTreeNode}"/> of <see cref="IBaseModel"/> - a base class to create in-memory representation of the UA Information Model.
  /// </summary>
  internal abstract class BaseTreeNode : List<IBaseModel>, IBaseModel
  {
    #region private
    private string m_Text;
    private string m_ToolTipText;
    //TextChanged
    internal class TextEventArgs : EventArgs
    {
      public readonly BaseTreeNode Node;
      public TextEventArgs(BaseTreeNode node) { Node = node; }
    }
    private void RaiseTextChanged()
    {
      TextChanged?.Invoke(this, new TextEventArgs(this));
    }
    //ProjectChanged
    internal class ProjectEventArgs : EventArgs { }
    protected void RaiseSubtreeChanged()
    {
      RaiseOnChangeHandler();
      SubtreeChanged?.Invoke(this, new ProjectEventArgs());
    }
    //protected abstract class TreeNode<T> : BaseTreeNodeControl<T, T>
    //  where T : BaseTreeNode
    //{
      //  #region private
      //  /// <summary>
      //  /// Gets or sets the creator. 
      //  /// This is the Wrapper object (from CAS.UA.Model.Designer.Wrappers), 
      //  /// so this is a link to a mesh that store the model
      //  /// </summary>
      //  /// <value>The creator.</value>
      //  protected T Creator { get; private set; }
      //  private void OnTextChanged(object sender, TextEventArgs e)
      //  {
      //    Text = e.Node.Text;
      //    ToolTipText = e.Node.ToolTipText;
      //    //TODO Tree view could be null while adding Variable - fixed but impact must be analized.
      //    //Completed: At revision: 9178  
      //    if (TreeView != null)
      //      TreeView.RebuildDictionary();
      //  }
      //  private void OnSubtreeChanged(object sender, ProjectEventArgs e)
      //  {
      //    if (this.TreeView != null)
      //      this.TreeView.SuspendLayout();
      //    RecreateSubtree();
      //    if (this.TreeView != null)
      //    {
      //      this.TreeView.SelectedNode = this;
      //      TreeView.RebuildDictionary();
      //      this.TreeView.ResumeLayout();
      //    }
      //  }
      //  protected void RecreateSubtree()
      //  {
      //    ClearChildren();
      //    AddChildren(Creator);
      //  }
      //  protected override void Unregister()
      //  {
      //    ClearChildren();
      //    Creator.TextChanged -= new EventHandler<TextEventArgs>(OnTextChanged);
      //    Creator.SubtreeChanged -= new EventHandler<ProjectEventArgs>(OnSubtreeChanged);
      //  }
      //  protected void AddChildren(T parent)
      //  {
      //    foreach (BaseTreeNode node in parent)
      //      Nodes.Add(node.GetTreeNode());
      //  }
      //  #endregion

      //  #region creator
      //public TreeNode(T parent)
      //  : base(parent)
      //{
        //CommonOperationsForTheNodeCreation(parent);
        //parent.TextChanged += new EventHandler<TextEventArgs>(OnTextChanged);
        //parent.SubtreeChanged += new EventHandler<ProjectEventArgs>(OnSubtreeChanged);
        //AddChildren(parent);
      //}

      //  private void CommonOperationsForTheNodeCreation(T parent)
      //  {
      //    Creator = parent;
      //    Text = parent.m_Text;
      //    ToolTipText = parent.ToolTipText;
      //    this.ImageIndex = ImagesForNodes.SetIconIndexForNodeAndSelectedNode(Creator.GetType().Name, false);
      //    this.SelectedImageIndex = ImagesForNodes.SetIconIndexForNodeAndSelectedNode(Creator.GetType().Name, true);
      //  }
      //  #endregion

      //  #region public
      //  internal override BaseDictionaryTreeNode CreateCopy()
      //  {
      //    return Creator.GetTreeNode();
      //  }
      //  #endregion
    //}
    protected virtual void CreateInstanceConfigurations(BaseTreeNode node, bool SkipOpeningConfigurationFile, out bool CancelWasPressed)
    {
      Parent.CreateInstanceConfigurations(node, SkipOpeningConfigurationFile, out CancelWasPressed);
    }
    /// <summary>
    /// If implemented in the derived class adds the node descriptors.
    /// </summary>
    /// <param name="dsptrs">The node descriptor.</param>
    /// <param name="ui">The unique identifier.</param>
    protected virtual void AddNodeDescriptors(List<INodeDescriptor> dsptrs, UniqueIdentifier ui)
    {
      foreach (BaseTreeNode item in this)
        item.AddNodeDescriptors(dsptrs, ui.MemberwiseClone());
    }
    #endregion

    #region creator
    public BaseTreeNode(string text)
    {
      m_Text = text;
    }
    #endregion

    #region public API
    /// <summary>
    /// Gets the node descriptors.
    /// </summary>
    /// <returns>Instance of <see cref="INodeDescriptor"/> containing node descriptor.</returns>
    internal virtual INodeDescriptor[] GetNodeDescriptors()
    {
      throw new NotImplementedException();
    }
    /// <summary>
    /// Tests if read only and return true if read only.
    /// </summary>
    /// <returns>true if read only</returns>
    internal virtual bool TestIfReadOnlyAndRetrunTrueIfReadOnly()
    {
      return Parent.TestIfReadOnlyAndRetrunTrueIfReadOnly();
    }
    /// <summary>
    /// Gets or sets the parent node in the model.
    /// </summary>
    /// <value>The parent node.</value>
    internal virtual BaseTreeNode Parent { get; set; }
    /// <summary>
    /// Raises the on change handler.
    /// </summary>
    internal protected virtual void RaiseOnChangeHandler()
    {
      if (Parent != null)
        Parent.RaiseOnChangeHandler();
    }
    #endregion

    #region IBaseModel
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.</returns>
    [Obsolete]
    public abstract BaseDictionaryTreeNode GetTreeNode();
    public event EventHandler<TextEventArgs> TextChanged;
    public event EventHandler<ProjectEventArgs> SubtreeChanged;
    public string ToolTipText
    {
      get { return m_ToolTipText; }
      set
      {
        if (!string.IsNullOrEmpty(m_ToolTipText) && m_ToolTipText.CompareTo(value) == 0)
          return;
        m_ToolTipText = value;
        RaiseTextChanged();
      }
    }
    public string Text
    {
      get { return m_Text; }
      set
      {
        if (!string.IsNullOrEmpty(m_Text) && m_Text.CompareTo(value) == 0)
          return;
        m_Text = value;
        RaiseTextChanged();
      }
    }
    #endregion

    #region ICollection<BaseTreeNode> Members
    /// <summary>
    /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"/>.
    /// </summary>
    /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
    /// <exception cref="T:System.NotSupportedException">
    /// The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
    /// </exception>
    public void Add(BaseTreeNode item)
    {
      item.Parent = this;
      base.Add(item);
      RaiseSubtreeChanged();
    }
    /// <summary>
    /// Adds the elements of the specified collection to the end of the <see cref="T:System.Collections.Generic.List`1"/>.
    /// </summary>
    /// <param name="collection">The collection whose elements should be added to the end of the <see cref="T:System.Collections.Generic.List`1"/>. The collection itself cannot be null, but it can contain elements that are null, if type <paramref name="T"/> is a reference type.</param>
    /// <exception cref="T:System.ArgumentNullException">
    /// 	<paramref name="collection"/> is null.
    /// </exception>
    public void AddRange(IEnumerable<BaseTreeNode> collection)
    {
      foreach (BaseTreeNode item in collection)
        item.Parent = this;
      base.AddRange(collection);
      RaiseSubtreeChanged();
    }
    /// <summary>
    /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
    /// </summary>
    /// <exception cref="T:System.NotSupportedException">
    /// The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
    /// </exception>
    public new void Clear()
    {
      base.Clear();
      RaiseSubtreeChanged();
    }
    /// <summary>
    /// Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
    /// </summary>
    /// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
    /// <returns>
    /// true if <paramref name="item"/> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1"/>; 
    /// otherwise, false. This method also returns false if <paramref name="item"/> is not found in the 
    /// original <see cref="T:System.Collections.Generic.ICollection`1"/>.
    /// </returns>
    /// <exception cref="T:System.NotSupportedException">
    /// The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
    /// </exception>
    public bool Remove(BaseTreeNode item)
    {
      bool ret = base.Remove(item);
      item.Parent = null;
      RaiseSubtreeChanged();
      return ret;
    }
    #endregion

    #region IParent Members
    /// <summary>
    /// Gets the availiable namespaces.
    /// </summary>
    /// <value>The availiable namespaces.</value>
    public virtual string[] AvailiableNamespaces { get { return Parent.AvailiableNamespaces; } }
    /// <summary>
    /// Gets the target namespace.
    /// </summary>
    /// <returns>The target namespace.</returns>
    public virtual string GetTargetNamespace() { return Parent.GetTargetNamespace(); }
    #endregion

  }
}
