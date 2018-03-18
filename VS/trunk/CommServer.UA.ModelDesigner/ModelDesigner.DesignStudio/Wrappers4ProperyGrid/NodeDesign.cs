﻿//<summary>
//  Title   : ModelDesign : Nodes - functionality
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
using CAS.UA.Model.Designer.Types;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using System;
using System.Text;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  #region class Design
  /// <summary>
  /// Base class implementing the <see cref="IValidate" interface/>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  internal abstract partial class Design<T> : IValidate, IXmlQualifiedNameEditorNamespaceProvider
  where T : class, new()
  {
    public override string ToString()
    {
      string ret = this.GetType().Name;
      if (ret.Contains("`"))
        ret = ret.Substring(0, ret.IndexOf("`"));
      return ret;
    }
    //private void Initialize( T child );
    protected abstract void UpdateModelNode(T modelNode);
    internal T Update()
    {
      T modelNode = new T();
      UpdateModelNode(modelNode);
      return modelNode;
    }
    internal virtual IParent Parent { get; set; }
    #region IValidate Members
    /// <summary>
    /// Validates this instance.
    /// </summary>
    public virtual void Validate()
    {
      Parent.Validate();
    }
    #endregion

    #region IXmlQualifiedNameEditorNamespaceProvider Members
    string[] IXmlQualifiedNameEditorNamespaceProvider.GetAvailiableNamespaces()
    {
      return this.Parent.AvailiableNamespaces;
    }
    public string GetTargetNamespace()
    {
      return Parent == null ? "not set" : Parent.GetTargetNamespace();
    }
    #endregion
  }
  #endregion
  #region class NodeDesign
  internal abstract partial class NodeDesign<T> : Design<T>
  where T : Opc.Ua.ModelCompiler.NodeDesign, new()
  {
    #region creators
    public NodeDesign(T child)
    {
      this.BrowseName = child.BrowseName;
      this.Description = new LocalizedText(child.Description);
      this.DisplayName = new LocalizedText(child.DisplayName);
      this.IsDeclaration = child.IsDeclaration;
      this.NumericId = child.NumericId;
      this.NumericIdSpecified = child.NumericIdSpecified;
      this.StringId = child.StringId;
      this.SymbolicId = new XmlQualifiedNameEditor(child.SymbolicId, this);
      this.SymbolicName = new XmlQualifiedNameEditor(child.SymbolicName, this, true);
      this.WriteAccess = child.WriteAccess;
      this.PartNo = child.PartNo;
      //Import( null );
    }
    #endregion
    #region private
    /// <summary>
    /// Derives the properties values from the <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The source to get values from if not defined.</param>
    /// <exception cref="System.ArgumentNullException">source</exception>
    protected virtual void CopyPropertyValuesFrom(IInstanceDesign source)
    {
      if (source == null)
        throw new ArgumentNullException("source");
      if (string.IsNullOrEmpty(this.BrowseName))
        this.BrowseName = source.BrowseName;
      if (this.DisplayName.IsEmpty())
        this.DisplayName.UpdateBaseOnOtherLocalizedText(source.DisplayName);
      if (this.Description.IsEmpty())
        this.Description.UpdateBaseOnOtherLocalizedText(source.Description);
      if (this.SymbolicName.IsNull || this.SymbolicName.NameIsBasedOnDefault)
        this.SymbolicName.UpdateNameAndNamespaceBasedOn(source.SymbolicName);
      if (this.SymbolicId.IsNull || this.SymbolicName.NameIsBasedOnDefault)
        this.SymbolicId.UpdateNameAndNamespaceBasedOn(source.SymbolicId);
      if (!this.IsDeclaration) // by default this is false;
        this.IsDeclaration = source.IsDeclaration;
      if (string.IsNullOrEmpty(this.StringId))
        this.StringId = source.StringId;
      if (WriteAccess == 0) // by default this is 0;
        this.WriteAccess = source.WriteAccess;
      if (!NumericIdSpecified)
      {
        this.NumericId = source.NumericId;
        this.NumericIdSpecified = source.NumericIdSpecified;
      }
    }
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(T node)
    {
      node.BrowseName = this.BrowseName;
      node.Description = this.Description.Source;
      node.DisplayName = this.DisplayName.Source;
      node.IsDeclaration = this.IsDeclaration;
      node.NumericId = this.NumericId;
      node.NumericIdSpecified = this.NumericIdSpecified;
      node.StringId = this.StringId;
      node.SymbolicId = this.SymbolicId.XmlQualifiedName;
      node.SymbolicName = this.SymbolicName.XmlQualifiedName;
      node.WriteAccess = this.WriteAccess;
      node.PartNo = this.PartNo;
    }
    /// <summary>
    /// Imports this object.
    /// </summary>
    /// <param name="parent">The SymbolicId of the parent.</param>
    private void Import(XmlQualifiedNameEditor parent)
    {
      // check for missing name.
      if (SymbolicId.IsNull && SymbolicName.IsNull && String.IsNullOrEmpty(BrowseName))
        BrowseName = "BrowseName" + System.Guid.NewGuid().ToString();
      // use the browse name to assign a name.
      if (SymbolicName.IsNull)
      {
        // remove any non-symbol characters.
        StringBuilder name = new StringBuilder();
        for (int ii = 0; ii < BrowseName.Length; ii++)
        {
          if (Char.IsWhiteSpace(BrowseName[ii]))
          {
            name.Append('_');
            continue;
          }
          if (Char.IsLetterOrDigit(BrowseName[ii]) || BrowseName[ii] == '_')
            name.Append(BrowseName[ii]);
        }
        // create the symbolic name.
        SymbolicName = new XmlQualifiedNameEditor(name.ToString(), SymbolicId.NameSpace, this);
      }
      // use the name to assign a symbolic id.
      if (SymbolicId.IsNull)
      {
        string id = SymbolicName.Name;
        if (parent != null)
          id = String.Format("{0}_{1}", parent.Name, id);
        SymbolicId = new XmlQualifiedNameEditor(id, SymbolicName.NameSpace, this);
      }
    }
    #endregion
  }
  #endregion
  #region class ModelDesign
  internal partial class ModelDesign : Design<Opc.Ua.ModelCompiler.ModelDesign>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ModelDesign"/> class.
    /// </summary>
    /// <param name="child">The child.</param>
    public ModelDesign(Opc.Ua.ModelCompiler.ModelDesign child)
    {
      this.AnyAttr = child.AnyAttr;
      this.DefaultLocale = child.DefaultLocale;
      this.TargetNamespace = child.TargetNamespace;
      this.TargetPublicationDate = child.TargetPublicationDateSpecified ? child.TargetPublicationDate : new Nullable<DateTime>();
      this.TargetVersion = child.TargetVersion;
      this.TargetXmlNamespace = child.TargetXmlNamespace;
    }
    /// <summary>
    /// Updates the model node.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.ModelDesign node)
    {
      node.AnyAttr = this.AnyAttr;
      node.DefaultLocale = this.DefaultLocale;
      node.TargetNamespace = this.TargetNamespace;
      node.TargetPublicationDate = this.TargetPublicationDate.GetValueOrDefault();
      node.TargetPublicationDateSpecified = this.TargetPublicationDate.HasValue;
      node.TargetVersion = this.TargetVersion;
      node.TargetXmlNamespace = this.TargetXmlNamespace;
    }
  }
  #endregion
  #region class Namespace
  internal partial class Namespace : Design<Opc.Ua.ModelCompiler.Namespace>
  {
    public Namespace(Opc.Ua.ModelCompiler.Namespace child)
    {
      this.InternalPrefix = child.InternalPrefix;
      this.Name = child.Name;
      this.Prefix = child.Prefix;
      this.Value = child.Value;
      this.XmlNamespace = child.XmlNamespace;
      this.FilePath = child.FilePath;
      this.XmlPrefix = child.XmlPrefix;
    }
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.Namespace node)
    {
      node.InternalPrefix = this.InternalPrefix;
      node.Name = this.Name;
      node.Prefix = this.Prefix;
      node.Value = this.Value;
      node.XmlNamespace = this.XmlNamespace;
      node.FilePath = this.FilePath;
      node.XmlPrefix = this.XmlPrefix;
    }
  }
  #endregion
  #region class Reference
  /// <summary>
  /// Defines a reference between two nodes.
  /// </summary>
  internal partial class Reference : Design<Opc.Ua.ModelCompiler.Reference>
  {
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.Reference node)
    {
      node.ReferenceType = this.ReferenceType.XmlQualifiedName;
      node.TargetId = this.TargetId.XmlQualifiedName;
      node.IsInverse = this.IsInverse;
      node.IsOneWay = this.IsOneWay;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="Reference"/> class.
    /// </summary>
    /// <param name="child">The child.</param>
    public Reference(Opc.Ua.ModelCompiler.Reference child)
    {
      this.ReferenceType = new XmlQualifiedNameEditorWithDefaultValue(child.ReferenceType, this, BuildInXmlQualifiedNames.BaseReferenceType);
      this.TargetId = new XmlQualifiedNameEditor(child.TargetId, this);
      this.IsInverse = child.IsInverse;
      this.IsOneWay = child.IsOneWay;
    }
  }
  #endregion
  #region class Parameter
  /// <summary>
  /// Defines a Field in a DataType or Argument of a Method.
  /// </summary>
  internal partial class Parameter : Design<Opc.Ua.ModelCompiler.Parameter>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Parameter"/> class.
    /// </summary>
    /// <param name="child">The child.</param>
    public Parameter(Opc.Ua.ModelCompiler.Parameter child)
    {
      this.ArrayDimensions = child.ArrayDimensions;
      this.DataType = new XmlQualifiedNameEditor(child.DataType, this);
      this.ValueRank = child.ValueRank;
      if (child.IdentifierSpecified)
        this.Identifier = child.Identifier;
      this.Name = child.Name;
      this.Description = new LocalizedText(child.Description);
    }
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.Parameter node)
    {
      node.ArrayDimensions = this.ArrayDimensions;
      node.DataType = this.DataType.XmlQualifiedName;
      node.ValueRank = this.ValueRank;
      node.IdentifierSpecified = this.Identifier.HasValue;
      node.Identifier = this.Identifier.GetValueOrDefault();
      node.Name = this.Name;
      node.Description = this.Description.Source;
    }
  }
  #endregion
  #region class InstanceDesign
  /// <summary>
  /// A base type for all Instance Nodes (Object, Variable, and Method).
  /// </summary>
  /// <typeparam name="T"></typeparam>
  internal abstract partial class InstanceDesign<T> : NodeDesign<T>
    where T : Opc.Ua.ModelCompiler.InstanceDesign, new()
  {
    #region creator
    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceDesign"/> class.
    /// </summary>
    /// <param name="node">The node.</param>
    public InstanceDesign(T node)
      : base(node)
    {
      if (node.ModellingRuleSpecified)
        this.ModellingRule = node.ModellingRule;
      this.MinCardinality = node.MinCardinality;
      this.MaxCardinality = node.MaxCardinality;
      this.PreserveDefaultAttributes = node.PreserveDefaultAttributes;
      this.Declaration = new XmlQualifiedNameEditor(node.Declaration, this);
      this.TypeDefinition = new XmlQualifiedNameEditorWithDefaultValue(node.TypeDefinition, this, GetDefaultTypeDefinition);
      if (this.TypeDefinition.ValueOrDefault.Name == BuildInXmlQualifiedNames.PropertyType.Name)
        this.ReferenceType = new XmlQualifiedNameEditorWithDefaultValue(node.ReferenceType, this, BuildInXmlQualifiedNames.HasProperty);
      else
        this.ReferenceType = new XmlQualifiedNameEditorWithDefaultValue(node.ReferenceType, this, BuildInXmlQualifiedNames.HasComponent);
    }
    #endregion

    #region public
    /// <summary>
    /// Creates a new instance and derive property values from current object and the source <paramref name="source" />.
    /// </summary>
    /// <param name="source">The source model node - from which we want to derive values.</param>
    /// <returns>created new instance node of the model that derived data from this instance node and node passed as the source <paramref name="source" /></returns>
    public IInstanceDesign DerivePropertyValuesFrom(IInstanceDesign source)
    {
      InstanceDesign<T> ret = CreateNewInstance();
      ret.CopyPropertyValuesFrom(this);
      if (source != null)
        ret.CopyPropertyValuesFrom(source);
      return ret;
    }
    /// <summary>
    /// Derives the properties values from the <paramref name="source" />.
    /// </summary>
    /// <param name="source">The source to get values from if not defined.</param>
    protected override void CopyPropertyValuesFrom(IInstanceDesign source)
    {
      base.CopyPropertyValuesFrom(source);
      if (this.ReferenceType.IsNull || this.ReferenceType.NameIsBasedOnDefault)
        this.ReferenceType.UpdateNameAndNamespaceBasedOn(source.ReferenceType);
      if (this.Declaration.IsNull || this.Declaration.NameIsBasedOnDefault)
        this.Declaration.UpdateNameAndNamespaceBasedOn(source.Declaration);
      if (this.TypeDefinition.IsNull || this.TypeDefinition.NameIsBasedOnDefault)
        this.TypeDefinition.UpdateNameAndNamespaceBasedOn(source.TypeDefinition);
      if (this.ModellingRule == null)
        this.ModellingRule = source.ModellingRule;
      if (this.MinCardinality == 0) //by default it is 0
        this.MinCardinality = source.MinCardinality;
      if (this.MaxCardinality == 0) //by default it is 0
        this.MaxCardinality = source.MaxCardinality;
      if (!this.PreserveDefaultAttributes) //by default it is false
        this.PreserveDefaultAttributes = source.PreserveDefaultAttributes;
    }
    internal override IParent Parent
    {
      get { return base.Parent; }
      set { base.Parent = value; }
    }
    public INodeDescriptor GetINodeDescriptor(InstanceIdentifier uniqueNodeIdentifier, NodeClassesEnum nodeClasses)
    {
      return new NodeDescriptor(nodeClasses, uniqueNodeIdentifier.InstanceDeclaration)
      {
        NodeIdentifier = uniqueNodeIdentifier.InstanceQualifiedName,
        DataType = GetDataType,
        BindingDescription = this.Description.Value
      };
    }
    internal bool IsMandatory
    {
      get { return !ModellingRule.HasValue || (ModellingRule.Value == Opc.Ua.ModelCompiler.ModellingRule.Mandatory); }
    }
    #endregion

    #region private
    protected abstract XmlQualifiedName GetDefaultTypeDefinition { get; }
    protected abstract InstanceDesign<T> CreateNewInstance();
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(T node)
    {
      base.UpdateModelNode(node);
      node.ModellingRuleSpecified = this.ModellingRule.HasValue;
      node.ModellingRule = this.ModellingRule.GetValueOrDefault();
      node.MinCardinality = this.MinCardinality;
      node.MaxCardinality = this.MaxCardinality;
      node.PreserveDefaultAttributes = this.PreserveDefaultAttributes;
      node.ReferenceType = this.ReferenceType.XmlQualifiedName;
      node.Declaration = this.Declaration.XmlQualifiedName;
      node.TypeDefinition = this.TypeDefinition.XmlQualifiedName;
    }
    /// <summary>
    /// Gets the data type of the node if applicable, otherwise null.
    /// </summary>
    /// <returns>Data type of the variable, null for other node classes</returns>
    protected virtual XmlQualifiedName GetDataType { get { return null; } }
    /// <summary>
    /// Base implementation of the INodeDescriptor
    /// </summary>
    private class NodeDescriptor : INodeDescriptor
    {

      #region creator
      public NodeDescriptor(NodeClassesEnum nodeClasses, bool instanceDeclaration)
      {
        switch (nodeClasses)
        {
          case NodeClassesEnum.Object:
            this.NodeClass = InstanceNodeClassesEnum.Object;
            break;
          case NodeClassesEnum.Variable:
            this.NodeClass = InstanceNodeClassesEnum.Variable;
            break;
          case NodeClassesEnum.Method:
            this.NodeClass = InstanceNodeClassesEnum.Method;
            break;
          case NodeClassesEnum.View:
            this.NodeClass = InstanceNodeClassesEnum.View;
            break;
          default:
            break;
        }
        InstanceDeclaration = instanceDeclaration;
      }
      #endregion

      #region INodeDescriptor Members
      /// <summary>
      /// Gets the node unique identifier.
      /// </summary>
      /// <value>The node identifier.</value>
      public XmlQualifiedName NodeIdentifier { get; internal set; }

      /// <summary>
      /// Gets the type of the node of the <see cref="CAS.UA.Model.Designer.Common.NodeClassesEnum.Variable"/> NodeClass
      /// </summary>
      /// <value>The type of the data.</value>
      public XmlQualifiedName DataType { get; internal set; }

      /// <summary>
      /// Gets the node class.
      /// </summary>
      /// <value>The node class.</value>
      public InstanceNodeClassesEnum NodeClass { get; private set; }

      /// <summary>
      /// Gets a value indicating whether it is instance declaration - may have meny instance in the created address space.
      /// </summary>
      /// <value>
      /// 	<c>true</c> if the node is instance declaration; otherwise, <c>false</c>.
      /// </value>
      public bool InstanceDeclaration { get; private set; }

      /// <summary>
      /// Gets the binding description that allows the editor to create automatically bindings.
      /// </summary>
      /// <value>The binding description - .</value>
      public string BindingDescription { get; internal set; }

      #endregion
    }
    #endregion
  }
  #endregion
  #region class MethodDesign
  /// <summary>
  /// Defines the a Method in the information model.
  /// </summary>
  internal partial class MethodDesign : InstanceDesign<Opc.Ua.ModelCompiler.MethodDesign>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="MethodDesign"/> class.
    /// </summary>
    /// <param name="child">The child.</param>
    public MethodDesign(Opc.Ua.ModelCompiler.MethodDesign node)
      : base(node)
    {
      if (node.NonExecutableSpecified)
        this.NonExecutable = node.NonExecutable;
    }
    protected override InstanceDesign<Opc.Ua.ModelCompiler.MethodDesign> CreateNewInstance()
    {
      return new MethodDesign(new Opc.Ua.ModelCompiler.MethodDesign());
    }
    /// <summary>
    /// Derives the properties values from the <paramref name="source" />.
    /// </summary>
    /// <param name="source">The source to get values from if not defined.</param>
    protected override void CopyPropertyValuesFrom(IInstanceDesign source)
    {
      base.CopyPropertyValuesFrom(source);
      IMethodDesign ISource = (IMethodDesign)source;
      if (this.NonExecutable == null)
        this.NonExecutable = ISource.NonExecutable;
    }
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.MethodDesign node)
    {
      base.UpdateModelNode(node);
      node.NonExecutableSpecified = this.NonExecutable.HasValue;
      node.NonExecutable = this.NonExecutable.GetValueOrDefault();
    }
    /// <summary>
    /// Gets the default type definition.
    /// </summary>
    /// <returns></returns>
    protected override XmlQualifiedName GetDefaultTypeDefinition
    {
      get { return new XmlQualifiedName(); }
    }
  }
  #endregion
  #region class TypeDesign
  /// <summary>
  /// A base type for all Type Nodes (ObjectType, VariableType, DataType and ReferenceType).
  /// </summary>
  /// <typeparam name="T">Type of the node from the Opc.Ua.ModelCompiler namespace, 
  /// must inherit <see cref="Opc.Ua.ModelCompiler.TypeDesign"/></typeparam>
  internal abstract partial class TypeDesign<T> : NodeDesign<T>
    where T : Opc.Ua.ModelCompiler.TypeDesign, new()
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="TypeDesign"/> class.
    /// </summary>
    /// <param name="child">The child.</param>
    public TypeDesign(T node)
      : base(node)
    {
      this.ClassName = node.ClassName;
      this.IsItRootType = false;
      this.BaseType = new XmlQualifiedNameEditorWithDefaultValue(node.BaseType, this, GetBaseTypeDefaultValue);
      this.IsAbstract = node.IsAbstract;
      this.NoClassGeneration = node.NoClassGeneration;
    }

    /// <summary>
    /// Gets the get base type default value depending on the node class.
    /// </summary>
    /// <value>The get base type default value.</value>
    protected abstract XmlQualifiedName GetBaseTypeDefaultValue { get; }
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(T node)
    {
      base.UpdateModelNode(node);
      node.ClassName = this.ClassName;
      node.BaseType = this.BaseType.XmlQualifiedName;
      node.IsAbstract = this.IsAbstract;
      node.NoClassGeneration = this.NoClassGeneration;
    }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is it root type.
    /// </summary>
    /// <value>
    /// 	<c>true</c> if this instance is it root type; otherwise, <c>false</c>.
    /// </value>
    internal bool IsItRootType { get; set; }
  }
  #endregion
  #region class ObjectDesign
  /// <summary>
  /// Defines the structure of an Object in the information model.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  internal partial class ObjectDesign<T> : InstanceDesign<T>
    where T : Opc.Ua.ModelCompiler.ObjectDesign, new()
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ObjectDesign"/> class.
    /// </summary>
    /// <param name="child">The child.</param>
    public ObjectDesign(T node)
      : base(node)
    {
      if (node.SupportsEventsSpecified)
        this.SupportsEvents = node.SupportsEvents;
    }
    /// <summary>
    /// Creates the new instance.
    /// </summary>
    /// <returns>InstanceDesign&lt;T&gt;.</returns>
    protected override InstanceDesign<T> CreateNewInstance()
    {
      return new ObjectDesign<T>(new T());
    }
    /// <summary>
    /// Derives the properties values from the <paramref name="source" />.
    /// </summary>
    /// <param name="source">The source to get values from if not defined.</param>
    protected override void CopyPropertyValuesFrom(IInstanceDesign source)
    {
      base.CopyPropertyValuesFrom(source);
      IObjectDesign ISource = (IObjectDesign)source;
      if (this.SupportsEvents == null)
        this.SupportsEvents = ISource.SupportsEvents;
    }
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(T node)
    {
      base.UpdateModelNode(node);
      node.SupportsEventsSpecified = this.SupportsEvents.HasValue;
      node.SupportsEvents = this.SupportsEvents.GetValueOrDefault();
    }
    /// <summary>
    /// Gets the default type definition.
    /// </summary>
    /// <returns></returns>
    protected override XmlQualifiedName GetDefaultTypeDefinition
    {
      get { return BuildInXmlQualifiedNames.BaseObjectType; }
    }
  }
  #endregion
  #region class ReferenceTypeDesign
  /// <summary>
  /// ReferenceType define typed references between Nodes.
  /// </summary>
  internal partial class ReferenceTypeDesign : TypeDesign<Opc.Ua.ModelCompiler.ReferenceTypeDesign>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ReferenceTypeDesign"/> class.
    /// </summary>
    /// <param name="node"></param>
    public ReferenceTypeDesign(Opc.Ua.ModelCompiler.ReferenceTypeDesign node)
      : base(node)
    {
      this.InverseName = new LocalizedText(node.InverseName);
      if (node.SymmetricSpecified)
        this.Symmetric = node.Symmetric;
    }
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="child">The child.</param>
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.ReferenceTypeDesign node)
    {
      base.UpdateModelNode(node);
      node.InverseName = this.InverseName.Source;
      node.Symmetric = this.Symmetric.GetValueOrDefault();
      node.SymmetricSpecified = this.Symmetric.HasValue;
    }
    protected override XmlQualifiedName GetBaseTypeDefaultValue
    {
      get
      {
        if (this.SymbolicId.XmlQualifiedName == BuildInXmlQualifiedNames.BaseReferenceType)
        {
          this.IsItRootType = true;
          return new XmlQualifiedName();
        }
        else
          return BuildInXmlQualifiedNames.BaseReferenceType;
      }
    }
  }
  #endregion
  #region class DataTypeDesign
  /// <summary>
  /// DataTypes define structure of a Value for Variables in the information model.
  /// </summary>
  internal partial class DataTypeDesign : TypeDesign<Opc.Ua.ModelCompiler.DataTypeDesign>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypeDesign"/> class.
    /// </summary>
    /// <param name="node"></param>
    public DataTypeDesign(Opc.Ua.ModelCompiler.DataTypeDesign node)
      : base(node)
    {
      this.NoArraysAllowed = node.NoArraysAllowed;
      this.NotInAddressSpace = node.NotInAddressSpace;
    }
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.DataTypeDesign node)
    {
      base.UpdateModelNode(node);
      node.NoArraysAllowed = this.NoArraysAllowed;
      node.NotInAddressSpace = this.NotInAddressSpace;
    }
    /// <summary>
    /// Gets the get base type default value depending on the node class.
    /// </summary>
    /// <value>The get base type default value.</value>
    protected override XmlQualifiedName GetBaseTypeDefaultValue
    {
      get
      {
        if (this.SymbolicName.XmlQualifiedName == BuildInXmlQualifiedNames.BaseDataType)
        {
          this.IsItRootType = true;
          return new XmlQualifiedName();
        }
        else
          return BuildInXmlQualifiedNames.BaseDataType;
      }
    }
  }
  #endregion
  #region class EncodingDesign
  /// <summary>
  /// Defines an Object which is a DataTypeEncoding for a DataType.
  /// </summary>
  internal partial class EncodingDesign : ObjectDesign<Opc.Ua.ModelCompiler.EncodingDesign>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ObjectDesign"/> class.
    /// </summary>
    /// <param name="child">The child.</param>
    public EncodingDesign(Opc.Ua.ModelCompiler.EncodingDesign child)
      : base(child)
    { }
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.EncodingDesign node)
    {
      base.UpdateModelNode(node);
    }
  }
  #endregion
  #region class VariableTypeDesign
  /// <summary>
  /// VariableTypes define structure of a Variable in the information model.
  /// </summary>
  internal partial class VariableTypeDesign : TypeDesign<Opc.Ua.ModelCompiler.VariableTypeDesign>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="VariableTypeDesignGeneric"/> class.
    /// </summary>
    /// <param name="child">The child.</param>
    public VariableTypeDesign(Opc.Ua.ModelCompiler.VariableTypeDesign node)
      : base(node)
    {
      if (node.ValueRankSpecified)
        this.ValueRank = node.ValueRank;
      this.ArrayDimensions = node.ArrayDimensions;
      if (node.AccessLevelSpecified)
        this.AccessLevel = node.AccessLevel;
      if (node.MinimumSamplingIntervalSpecified)
        this.MinimumSamplingInterval = node.MinimumSamplingInterval;
      if (node.HistorizingSpecified)
        this.Historizing = node.Historizing;
      this.ExposesItsChildren = node.ExposesItsChildren;
      this.DataType = new XmlQualifiedNameEditor(node.DataType, this);
      this.DefaultValue = node.DefaultValue;
    }
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="child">The child.</param>
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.VariableTypeDesign node)
    {
      base.UpdateModelNode(node);
      node.ArrayDimensions = this.ArrayDimensions;
      node.ValueRankSpecified = this.ValueRank.HasValue;
      node.ValueRank = this.ValueRank.GetValueOrDefault();
      node.AccessLevelSpecified = this.AccessLevel.HasValue;
      node.AccessLevel = this.AccessLevel.GetValueOrDefault();
      node.MinimumSamplingInterval = this.MinimumSamplingInterval.GetValueOrDefault();
      node.MinimumSamplingIntervalSpecified = this.MinimumSamplingInterval.HasValue;
      node.Historizing = this.Historizing.GetValueOrDefault();
      node.HistorizingSpecified = this.Historizing.HasValue;
      node.ExposesItsChildren = this.ExposesItsChildren;
      node.DataType = this.DataType.XmlQualifiedName;
      node.DefaultValue = this.DefaultValue;
    }
    /// <summary>
    /// Gets the get base type default value depending on the node class.
    /// </summary>
    /// <value>The get base type default value.</value>
    protected override XmlQualifiedName GetBaseTypeDefaultValue
    {
      get
      {
        if (this.SymbolicName.XmlQualifiedName == BuildInXmlQualifiedNames.BaseVariableType)
        {
          this.IsItRootType = true;
          return new XmlQualifiedName();
        }
        else
          return BuildInXmlQualifiedNames.BaseVariableType;
      }
    }
  }
  #endregion
  #region class ObjectTypeDesign
  /// <summary>
  /// ObjectTypes define structure of an Object in the information model.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  internal partial class ObjectTypeDesign<T> : TypeDesign<T>
    where T : Opc.Ua.ModelCompiler.ObjectTypeDesign, new()
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ObjectTypeDesign&lt;T&gt;"/> class.
    /// </summary>
    /// <param name="node"></param>
    public ObjectTypeDesign(T node)
      : base(node)
    {
      if (node.SupportsEventsSpecified)
        this.SupportsEvents = node.SupportsEvents;
    }
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(T node)
    {
      base.UpdateModelNode(node);
      node.SupportsEvents = this.SupportsEvents.GetValueOrDefault();
      node.SupportsEventsSpecified = this.SupportsEvents.HasValue;
    }
    /// <summary>
    /// Gets the get base type default value depending on the node class.
    /// </summary>
    /// <value>The get base type default value.</value>
    protected override XmlQualifiedName GetBaseTypeDefaultValue
    {
      get
      {
        if (this.SymbolicName.XmlQualifiedName == BuildInXmlQualifiedNames.BaseObjectType)
        {
          this.IsItRootType = true;
          return new XmlQualifiedName();
        }
        else
          return BuildInXmlQualifiedNames.BaseObjectType;
      }
    }
  }
  #endregion
  #region class ViewDesign
  /// <summary>
  /// ViewDesign define structure of an View in the information model.
  /// </summary>
  internal partial class ViewDesign : NodeDesign<Opc.Ua.ModelCompiler.ViewDesign>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ViewDesign"/> class.
    /// </summary>
    /// <param name="node">The node.</param>
    public ViewDesign(Opc.Ua.ModelCompiler.ViewDesign node)
      : base(node)
    {
      this.SupportsEvents = node.SupportsEvents;
      this.ContainsNoLoops = node.ContainsNoLoops;
    }
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.ViewDesign node)
    {
      base.UpdateModelNode(node);
      node.SupportsEvents = this.SupportsEvents;
      node.ContainsNoLoops = this.ContainsNoLoops;
    }
  }
  #endregion
  #region class VariableDesign
  /// <summary>
  /// Defines the structure of a Variable in the information model.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  internal partial class VariableDesign<T> : InstanceDesign<T>
    where T : Opc.Ua.ModelCompiler.VariableDesign, new()
  {
    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="VariableDesignGeneric"/> class.
    /// </summary>
    /// <param name="node"></param>
    public VariableDesign(T node)
      : base(node)
    {
      this.DefaultValue = new VariableValueEditor(node.DefaultValue);
      this.DataType = new XmlQualifiedNameEditor(node.DataType, this);
      if (node.ValueRankSpecified)
        this.ValueRank = node.ValueRank;
      this.ArrayDimensions = node.ArrayDimensions;
      if (node.AccessLevelSpecified)
        this.AccessLevel = node.AccessLevel;
      if (node.MinimumSamplingIntervalSpecified)
        this.MinimumSamplingInterval = node.MinimumSamplingInterval;
      if (node.HistorizingSpecified)
        this.Historizing = node.Historizing;
    }
    #endregion
    protected override InstanceDesign<T> CreateNewInstance()
    {
      return new VariableDesign<T>(new T());
    }
    /// <summary>
    /// Derives the properties values from the <paramref name="source" />.
    /// </summary>
    /// <param name="source">The source to get values from if not defined.</param>
    protected override void CopyPropertyValuesFrom(IInstanceDesign source)
    {
      base.CopyPropertyValuesFrom(source);
      IVariableDesign ISource = (IVariableDesign)source;
      if (this.Historizing == null)
        this.Historizing = ISource.Historizing;
      if (this.MinimumSamplingInterval == null)
        this.MinimumSamplingInterval = ISource.MinimumSamplingInterval;
      if (this.AccessLevel == null)
        this.AccessLevel = ISource.AccessLevel;
      if (this.ValueRank == null)
        this.ValueRank = ISource.ValueRank;
      if (string.IsNullOrEmpty(this.ArrayDimensions))
        this.ArrayDimensions = ISource.ArrayDimensions;
      if (this.DataType.IsNull || this.DataType.NameIsBasedOnDefault)
        this.DataType.UpdateNameAndNamespaceBasedOn(ISource.DataType);
      if (this.DefaultValue.IsEmpty())
        this.DefaultValue.UpdateValueBasedOnOtherVariableValueEditor(ISource.DefaultValue);
    }
    #region private
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(T node)
    {
      base.UpdateModelNode(node);
      node.DefaultValue = this.DefaultValue.XmlElement;
      node.DataType = this.DataType.XmlQualifiedName;
      node.ValueRank = this.ValueRank.GetValueOrDefault();
      node.ValueRankSpecified = this.ValueRank.HasValue;
      node.ArrayDimensions = this.ArrayDimensions;
      node.AccessLevel = this.AccessLevel.GetValueOrDefault();
      node.AccessLevelSpecified = this.AccessLevel.HasValue;
      node.MinimumSamplingInterval = this.MinimumSamplingInterval.GetValueOrDefault();
      node.MinimumSamplingIntervalSpecified = this.MinimumSamplingInterval.HasValue;
      node.Historizing = this.Historizing.GetValueOrDefault();
      node.HistorizingSpecified = this.Historizing.HasValue;
    }
    protected override XmlQualifiedName GetDataType
    {
      get { return this.DataType.XmlQualifiedName; }
    }
    #endregion

    /// <summary>
    /// Gets the default type definition.
    /// </summary>
    /// <returns></returns>
    protected override XmlQualifiedName GetDefaultTypeDefinition
    {
      get { return BuildInXmlQualifiedNames.BaseVariableType; }
    }
  }
  #endregion
  #region class DictionaryDesign
  /// <summary>
  /// Defines an Variable which is a DataTypeDictionary.
  /// </summary>
  internal partial class DictionaryDesign : VariableDesign<Opc.Ua.ModelCompiler.DictionaryDesign>
  {
    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="DictionaryDesign"/> class.
    /// </summary>
    /// <param name="actualChild">The actual child.</param>
    public DictionaryDesign(Opc.Ua.ModelCompiler.DictionaryDesign actualChild)
      : base(actualChild)
    {
      this.EncodingName = new XmlQualifiedNameEditor(actualChild.EncodingName, this);
    }
    #endregion

    protected override InstanceDesign<Opc.Ua.ModelCompiler.DictionaryDesign> CreateNewInstance()
    {
      return new DictionaryDesign(new Opc.Ua.ModelCompiler.DictionaryDesign());
    }
    /// <summary>
    /// Derives the properties values from the <paramref name="source" />.
    /// </summary>
    /// <param name="source">The source to get values from if not defined.</param>
    protected override void CopyPropertyValuesFrom(IInstanceDesign source)
    {
      base.CopyPropertyValuesFrom(source);
      IDictionaryDesign ISource = (IDictionaryDesign)source;
      if (this.EncodingName.IsNull || this.EncodingName.NameIsBasedOnDefault)
        this.EncodingName.UpdateNameAndNamespaceBasedOn(ISource.EncodingName);
    }

    #region private
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="child">The child.</param>
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.DictionaryDesign node)
    {
      base.UpdateModelNode(node);
      node.EncodingName = this.EncodingName.XmlQualifiedName;
    }
    #endregion

  }
  #endregion
  #region class PropertyDesign
  /// <summary>
  /// Defines a Variable which is a Property for a Node.
  /// </summary>
  internal partial class PropertyDesign : VariableDesign<Opc.Ua.ModelCompiler.PropertyDesign>
  {
    #region cretors
    public PropertyDesign(Opc.Ua.ModelCompiler.PropertyDesign node)
      : base(node)
    { }
    #endregion
    protected override InstanceDesign<Opc.Ua.ModelCompiler.PropertyDesign> CreateNewInstance()
    {
      return new PropertyDesign(new Opc.Ua.ModelCompiler.PropertyDesign());
    }
    /// <summary>
    /// Updates the specific child. This method should be overridden by child and should be called for complete update.
    /// </summary>
    /// <param name="node">The node.</param>
    protected override void UpdateModelNode(Opc.Ua.ModelCompiler.PropertyDesign node)
    {
      base.UpdateModelNode(node);
    }
    /// <summary>
    /// Gets the default type definition.
    /// </summary>
    /// <returns></returns>
    protected override XmlQualifiedName GetDefaultTypeDefinition
    {
      get { return BuildInXmlQualifiedNames.PropertyType; }
    }
  }
  #endregion
}
