//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using UAOOI.Configuration.Core;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// A collection <see cref="List{BaseTreeNode}"/> of <see cref="IBaseModel"/> - a base class to create in-memory representation of the UA Information Model.
  /// </summary>
  internal abstract class BaseModel : IBaseModel
  {
    #region constructor

    internal BaseModel(string text)
    {
      m_Text = text;
    }

    #endregion constructor

    #region public API

    internal int Count => m_Children.Count;

    /// <summary>
    /// Gets the node descriptors.
    /// </summary>
    /// <returns>Instance of <see cref="INodeDescriptor"/> containing node descriptor.</returns>
    internal virtual INodeDescriptor[] GetNodeDescriptors()
    {
      throw new NotImplementedException();
    }

    #endregion public API

    #region IBaseModel

    public event EventHandler<TextEventArgs> TextChanged;

    public event EventHandler<ProjectEventArgs> SubtreeChanged;

    public string ToolTipText
    {
      get => m_ToolTipText;
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
      get => m_Text;
      set
      {
        if (!string.IsNullOrEmpty(m_Text) && m_Text.CompareTo(value) == 0)
          return;
        m_Text = value;
        RaiseTextChanged();
      }
    }

    /// <summary>
    /// Gets or sets the parent node in the model.
    /// </summary>
    /// <value>The parent node.</value>
    public virtual IBaseModel Parent { get; set; }

    /// <summary>
    /// Gets the available namespaces.
    /// </summary>
    /// <value>The available namespaces.</value>
    public virtual string[] AvailiableNamespaces => Parent.AvailiableNamespaces;

    /// <summary>
    /// Raises the on change handler.
    /// </summary>
    public virtual void RaiseOnChangeHandler()
    {
      if (Parent != null)
        Parent.RaiseOnChangeHandler();
    }

    /// <summary>
    /// Tests if read only and return true if read only.
    /// </summary>
    /// <returns>true if read only</returns>
    public virtual bool IsReadOnly()
    {
      return Parent.IsReadOnly();
    }

    void IBaseModel.CreateInstanceConfigurations(IBaseModel node, bool SkipOpeningConfigurationFile, out bool CancelWasPressed)
    {
      throw new NotImplementedException();
    }

    public virtual void CreateInstanceConfigurations(BaseModel node, bool SkipOpeningConfigurationFile, out bool CancelWasPressed)
    {
      Parent.CreateInstanceConfigurations(node, SkipOpeningConfigurationFile, out CancelWasPressed);
    }

    /// <summary>
    /// Gets the target namespace.
    /// </summary>
    /// <returns>The target namespace.</returns>
    public virtual string GetTargetNamespace() { return Parent.GetTargetNamespace(); }

    /// <summary>
    /// Removes the first occurrence of a specific object from the collection.
    /// </summary>
    /// <param name="item">The object to remove from the collection.</param>
    /// <returns><c>true</c> if <paramref name="item" /> was successfully removed from the embedded collection&gt;;
    /// otherwise, <c>false</c>. This method also returns false if <paramref name="item" /> is not found in the collection.</returns>
    public bool Remove(IBaseModel item)
    {
      bool ret = m_Children.Remove(item);
      item.Parent = null;
      RaiseSubtreeChanged();
      return ret;
    }

    public IEnumerator<IBaseModel> GetEnumerator()
    {
      return m_Children.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return m_Children.GetEnumerator();
    }

    #endregion IBaseModel

    #region ICollection<BaseTreeNode> Members

    /// <summary>
    /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"/>.
    /// </summary>
    /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
    /// <exception cref="T:System.NotSupportedException">
    /// The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
    /// </exception>
    public void Add(IBaseModel item)
    {
      item.Parent = this;
      m_Children.Add(item);
      RaiseSubtreeChanged();
    }

    /// <summary>
    /// Adds the elements of the specified collection to the end of the <see cref="T:System.Collections.Generic.List`1"/>.
    /// </summary>
    /// <param name="collection">The collection whose elements should be added to the end of the <see cref="T:System.Collections.Generic.List`1"/>. The collection itself cannot be null, but it can contain elements that are null, if type <paramref name="T"/> is a reference type.</param>
    /// <exception cref="T:System.ArgumentNullException">
    /// 	<paramref name="collection"/> is null.
    /// </exception>
    public void AddRange(IEnumerable<BaseModel> collection)
    {
      foreach (BaseModel item in collection)
        item.Parent = this;
      m_Children.AddRange(collection);
      RaiseSubtreeChanged();
    }

    /// <summary>
    /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
    /// </summary>
    /// <exception cref="T:System.NotSupportedException">
    /// The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
    /// </exception>
    public void Clear()
    {
      m_Children.Clear();
      RaiseSubtreeChanged();
    }

    #endregion ICollection<BaseTreeNode> Members

    #region private

    private List<IBaseModel> m_Children = new List<IBaseModel>();
    private string m_Text;
    private string m_ToolTipText;

    protected void RaiseSubtreeChanged()
    {
      RaiseOnChangeHandler();
      SubtreeChanged?.Invoke(this, new ProjectEventArgs());
    }

    /// <summary>
    /// If implemented in the derived class adds the node descriptors.
    /// </summary>
    /// <param name="dsptrs">The node descriptor.</param>
    /// <param name="ui">The unique identifier.</param>
    protected virtual void AddNodeDescriptors(List<INodeDescriptor> dsptrs, UniqueIdentifier ui)
    {
      foreach (BaseModel item in m_Children)
        item.AddNodeDescriptors(dsptrs, ui.MemberwiseClone());
    }

    private void RaiseTextChanged()
    {
      TextChanged?.Invoke(this, new TextEventArgs(this));
    }

    #endregion private
  }
}