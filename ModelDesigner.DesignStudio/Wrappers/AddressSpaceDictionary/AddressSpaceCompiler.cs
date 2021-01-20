//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________


using CAS.UA.Model.Designer.Types;
using Opc.Ua.ModelCompiler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using UAOOI.Configuration.Core;

namespace CAS.UA.Model.Designer.Wrappers.AddressSpaceDictionary
{
  /// <summary>
  /// Class AddressSpaceCompiler - implements compilation of the information model into an address space instance.
  /// </summary>
  internal class AddressSpaceCompiler : AddressSpaceService, IAddressSpaceCreator
  {

    #region public
    /// <summary>
    /// Adds the reference to the AddressSpace.
    /// </summary>
    /// <param name="sourceIndex">Index of the source element that must be registered before this method is called.</param>
    /// <param name="referenceTypeName">Name of the reference type.</param>
    /// <param name="inverse">if set to <c>true</c> it is inverse reference.</param>
    /// <param name="targetIndex">Index of the target.</param>
    internal void AddReference(int sourceIndex, XmlQualifiedName referenceTypeName, bool inverse, int targetIndex)
    {
      if (referenceTypeName == null || referenceTypeName.IsEmpty || String.IsNullOrEmpty(referenceTypeName.Name))
        Assert(false, sourceIndex, "Reference type name cannot be null or empty");
      string name = referenceTypeName.Name;
      if (!inverse)
      {
        foreach (AddressSpace.ReferencesTableRow rowInRefTable in m_AddressSpace.ReferencesTable)
          if ((rowInRefTable.TargetNodeIndex == targetIndex) && (rowInRefTable.SourceNodeIndex == sourceIndex) && (rowInRefTable.Name == name))
            return;
      }
      else
        foreach (AddressSpace.ReferencesTableRow rowInRefTable in m_AddressSpace.ReferencesTable)
          if ((rowInRefTable.TargetNodeIndex == sourceIndex) && (rowInRefTable.SourceNodeIndex == targetIndex) && (rowInRefTable.Name == name))
            return;
      AddressSpace.ReferencesTableRow _newRow = m_AddressSpace.ReferencesTable.NewReferencesTableRow();
      _newRow.ReferenceTypeIndex = TryGetAndAddIfNeeded(referenceTypeName.ToString());
      if (inverse)
      {
        _newRow.SourceNodeIndex = targetIndex;
        _newRow.TargetNodeIndex = sourceIndex;
      }
      else
      {
        _newRow.SourceNodeIndex = sourceIndex;
        _newRow.TargetNodeIndex = targetIndex;
      }
      _newRow.Name = name;
      m_AddressSpace.ReferencesTable.AddReferencesTableRow(_newRow);
    }
    #endregion

    #region IAddressSpaceCreator
    /// <summary>
    /// Adds the node to the AddressSpace.
    /// </summary>
    /// <param name="node">The node.</param>
    /// <param name="name">The name.</param>
    /// <returns>Unique index in the AddressSpace</returns>
    public int AddNode2AddressSpace(IModelNode node, string uniqueName)
    {
      int index = TryGetAndAddIfNeeded(uniqueName);
      Debug.Assert(m_NodesList[index] != null);
      if (m_NodesList[index].Type == NodeHandle.NodeType.DanglingReference)
        m_NodesList[index] = NodeHandle.CreateRegularNode(node);
      else
      {
        string msg = "Node: " + node.Name + " is declared twice.";
        bool _errorListContainsNode = false;
        for (int i = 0; i < m_NodesList[index].Node.ErrorList.Count; i++)
        {
          if (String.Compare(m_NodesList[index].Node.ErrorList[i].Message, msg) == 0)
          {
            _errorListContainsNode = true;
            break;
          }
        }
        if (!_errorListContainsNode)
        {
          AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Information, 95, "AddNode compiler error '{0}' for node SymbolicName: {1}", msg, node.SymbolicName);
          m_NodesList[index].Node.ErrorList.Add(new Diagnostics(msg));
        }
      }
      return index;
    }
    /// <summary>
    /// Adds an information model instance node <paramref name="node" /> to address space.
    /// It is used to register an existing node.
    /// </summary>
    /// <param name="node">The node to be added to the address space.</param>
    void IAddressSpaceCreator.AddNode2AddressSpace(IInstanceNode node)
    {
      new InstanceNodeContext(this, node);
    }
    /// <summary>
    /// Adds a reference to the AddressSpace.
    /// </summary>
    /// <param name="sourceIndex">Index of the source node that must be registered before this method is called.</param>
    /// <param name="referenceTypeName">Name of the reference type.</param>
    /// <param name="inverse">if set to <c>true</c> it is inverse reference.</param>
    /// <param name="targetName">Name of the target element this reference points to.</param>
    public void AddReference(int sourceIndex, XmlQualifiedName referenceTypeName, bool inverse, XmlQualifiedName targetName)
    {
      //targetName can be null in case of HasTypeDefinition of basic types. 
      this.Assert((referenceTypeName != null && !referenceTypeName.IsEmpty), sourceIndex, "The reference type name of the reference cannot be null or empty");
      if (targetName.IsNullOrEmpty() || referenceTypeName.IsNullOrEmpty())
        return;
      int targetIndex = TryGetAndAddIfNeeded(targetName.ToString());
      this.AddReference(sourceIndex, referenceTypeName, inverse, targetIndex);
    }
    /// <summary>
    /// Checks for a condition; if the condition is false, trace the <paramref name="errorMessage"/> message and adds diagnostic information <see cref="Diagnostics"/> 
    /// to the node pointed out by the <paramref name="sourceIndex"/>.
    /// </summary>
    /// <param name="condition">The conditional expression to evaluate. If the condition is not true, the specified message is 
    /// reported as the compilation error.</param>
    /// <param name="sourceIndex">Index of the source.</param>
    /// <param name="errorMessage">The error message.</param>
    public void Assert(bool condition, int sourceIndex, string errorMessage)
    {
      if (condition)
        return;
      Debug.Assert(m_NodesList.ContainsKey(sourceIndex), "m_NodesList does not contain the selected node.");
      IModelNode _node = m_NodesList[sourceIndex].Node;
      string _msg = String.Format(c_ErrorTemplate, m_ErrorNumber, _node.Name, _node.SymbolicName.ToString(), errorMessage);
      _node.ErrorList.Add(new Diagnostics(_msg));
      m_TraceEvent(_msg);
    }
    /// <summary>
    /// Creates the nodes collection to start processing instance declarations recursively and override nodes in the derived types.
    /// All collected nodes must be added to the address space together at the end of processing.
    /// </summary>
    /// <returns>An instance of <see cref="IInstanceNodesCollection" />IAddressSpaceNodesCollection.</returns>
    IInstanceNodesCollection IAddressSpaceCreator.CreateNodesCollection()
    {
      return new InstanceNodesCollection(this);
    }
    #endregion

    #region AddressSpaceService
    /// <summary>
    /// Internal method to initialize and populate the address space using the <paramref name="getNodesFromModel"/>. The <paramref name="getNodesFromModel"/> 
    /// should be used while traversing the information model to add address space nodes and references.
    /// </summary>
    /// <param name="getNodesFromModel">The get nodes from model.</param>
    /// <returns>IAddressSpaceContent.</returns>
    protected override IElement[] InternalCreateInstance(Action<IAddressSpaceCreator> getNodesFromModel, Action<string> traceEvent)
    {
      m_TraceEvent = traceEvent;
      traceEvent("Starting address space compilation, the process could take minutes.");
      IElement[] _ret = new IElement[0];
      m_AddressSpace = new AddressSpace();
      getNodesFromModel(this);
      Validate(traceEvent);
      if (m_Root == null)
        throw new ApplicationException("Cannot display the model because the Root element cannot ne found in the model.");
      _ret = new IElement[] { AddressSpaceElement.CreateAddressSpaceElement(m_Root, this) };
      traceEvent(String.Format("Created the Root element {0}", _ret[0].Name));
      return _ret;
    }
    #endregion

    #region private
    //classes
    private class AddressSpaceElement : IElement
    {
      #region private
      private AddressSpaceElement(AddressSpace.ReferencesTableRow reference, AddressSpace.NodesTableRow node, AddressSpaceCompiler parent)
      {
        m_ReferenceRow = reference;
        m_NodeRow = node;
        m_parent = parent;
      }
      private IModelNode ReferenceTypeModelNode
      {
        get
        {
          NodeHandle md = m_parent.m_NodesList[m_ReferenceRow.ReferenceTypeIndex];
          return md == null ? null : md.Node;
        }
      }
      private IModelNode ModelNode
      {
        get
        {
          NodeHandle md = m_parent.m_NodesList[m_NodeRow.ObjectIndex];
          return md == null ? null : md.Node;
        }
      }
      private AddressSpace.ReferencesTableRow m_ReferenceRow;
      private AddressSpace.NodesTableRow m_NodeRow;
      private string tempName = "";
      private AddressSpaceCompiler m_parent;
      #endregion

      #region public
      internal static AddressSpaceElement CreateAddressSpaceElement(AddressSpace.NodesTableRow row, AddressSpaceCompiler parent)
      {
        return new AddressSpaceElement(null, row, parent);
      }
      #endregion

      #region IElement Members
      object IElement.ReferenceTypeWrapper4PropertyGrid
      {
        get { return ReferenceTypeModelNode.Wrapper4PropertyGrid; }
      }
      object IElement.NodeWrapper4PropertyGrid
      {
        get
        {
          if (ModelNode == null)
            return null;
          else
            return ModelNode.Wrapper4PropertyGrid;
        }
      }
      /// <summary>
      /// Gets the children of the node.
      /// </summary>
      /// <param name="backward">if set to <c>true</c> return all nodes in the backward direction.</param>
      /// <param name="forward">if set to <c>true</c> return all nodes in the forward direction.</param>
      /// <returns></returns>
      /// <value>The children.</value>
      IElement[] IElement.GetChildren(bool backward, bool forward)
      {
        List<IElement> list = new List<IElement>();
        if (forward)
          foreach (AddressSpace.ReferencesTableRow _refItem in m_NodeRow.GetReferencesTableRows())
          {
            IElement _newElement = new AddressSpaceElement(_refItem, (AddressSpace.NodesTableRow)_refItem.GetParentRow(_refItem.Table.ParentRelations["TargetNodesReferences"]), m_parent);
            if (String.IsNullOrEmpty(_newElement.Name))
              foreach (KeyValuePair<string, int> _item in m_parent.m_Dictionary)
                if (_item.Value == _refItem.TargetNodeIndex)
                {
                  _newElement.Name = _item.Key;
                  break;
                }
            list.Add(_newElement);
          }
        //TODO to be implemented
        //if (backward)
        return list.ToArray();
      }
      string IElement.Name
      {
        get
        {
          if (ModelNode != null)
            return ModelNode.Name;
          return tempName;
        }
        set
        {
          tempName = value;
        }
      }
      string IElement.ReferenceName
      {
        get
        {
          if (m_ReferenceRow == null)
            return "";
          else
            return m_ReferenceRow.Name;
        }
      }
      NodeClassesEnum IElement.NodeClass
      {
        get
        {
          if (this.ModelNode == null)
            return NodeClassesEnum.None;
          else
            return this.ModelNode.NodeClass;
        }
      }
      IList<Diagnostics> IElement.ErrorsList
      {
        get { return this.ModelNode.ErrorList; }
      }
      /// <summary>
      /// Gets an instance of thy <see cref="IModelNode"/>.
      /// </summary>
      /// <value>The instance implementing IModelNode.</value>
      /// <remarks>
      /// If the target represented by this instance is the instance declaration the <see cref="IModelNode"/> is provided
      /// by a read only stub.
      /// </remarks>
      IModelNode IElement.ModelNode
      {
        get { return ModelNode; }
      }
      #endregion

    }
    private class NodeHandle
    {

      #region public
      internal enum NodeType { RegularNode, DanglingReference };
      internal NodeType Type { get; private set; }
      internal IModelNode Node { get; private set; }
      /// <summary>
      /// Creates a regular node that is to bne used to replace the dangling reference olready added to the address space.
      /// </summary>
      /// <param name="node">The node to contain model information..</param>
      /// <returns>ModelNode.</returns>
      internal static NodeHandle CreateRegularNode(IModelNode node)
      {
        return new NodeHandle()
        {
          Type = NodeType.RegularNode,
          Node = node
        };
      }
      internal static NodeHandle CreateDanglingReference(string name)
      {
        DanglingReference dr = new DanglingReference(name);
        return new NodeHandle()
        {
          Type = NodeType.DanglingReference,
          Node = dr
        };
      }
      #endregion

      #region private
      private class DanglingReference : IModelNode
      {
        public DanglingReference(string name)
        {
          Name = name;
          ErrorList = new List<Diagnostics>();
          ErrorList.Add(new Diagnostics("Node is not declared"));
        }

        #region IModelNode Members
        public string Name { get; private set; }
        public XmlQualifiedName SymbolicName { get { return null; } }
        public IList<Diagnostics> ErrorList { get; private set; }
        public object Wrapper4PropertyGrid { get { return null; } }
        public INodeDescriptor GetINodeDescriptor() { return null; }
        public NodeClassesEnum NodeClass { get { return NodeClassesEnum.None; } }
        public string HelpTopicName { get { return string.Empty; } }
        public bool IsReadOnly { get { return true; } }
        #endregion

      }
      #endregion

    }
    //methods
    /// <summary>
    /// Tries to get the position of the name or adds it if needed.
    /// </summary>
    /// <param name="uniqueName">A globally unique name of the node.</param>
    /// <returns>Position of the name in the dictionary.</returns>
    private int TryGetAndAddIfNeeded(string uniqueName)
    {
      int _listPosition;
      if (m_Dictionary.TryGetValue(uniqueName, out _listPosition))
        return _listPosition;
      _listPosition = m_listPosition++;
      m_NodesList.Add(_listPosition, NodeHandle.CreateDanglingReference(uniqueName));
      m_Dictionary.Add(uniqueName, _listPosition);
      AddressSpace.NodesTableRow row = m_AddressSpace.NodesTable.NewNodesTableRow();
      row.ObjectIndex = _listPosition;
      m_AddressSpace.NodesTable.AddNodesTableRow(row);
      if (uniqueName.CompareTo(BuildInXmlQualifiedNames.RootFolder.ToString()) == 0)
        m_Root = row;
      return _listPosition;
    }
    private void Validate(Action<string> traceEvent)
    {
      //Modeling rules validation.
      foreach (ModellingRule _value in Enum.GetValues(typeof(ModellingRule)))
      {
        if (_value == ModellingRule.None || _value == ModellingRule.CardinalityRestriction) //ModellingRule.CardinalityRestriction has not been defined in the spec.
          continue;
        string _symbolicName = BuildInXmlQualifiedNames.ModelingRuleSymbolicName(_value).ToString();
        int _key = 0;
        if (!m_Dictionary.TryGetValue(_symbolicName, out _key))
        {
          traceEvent(String.Format("Cannot find an object representing the modeling rules {0} name: {1} in the dictionary.", _value, _symbolicName));
          continue;
        }
        if (m_NodesList[_key].Type == NodeHandle.NodeType.DanglingReference)
        {
          traceEvent(String.Format("Cannot find definition of the object representing the modeling rules {0} name: {1} ", _value, _symbolicName));
          continue;
        }
      }
      IEnumerable<KeyValuePair<int, IModelNode>> _collection = m_NodesList.Where(x => x.Value.Type == NodeHandle.NodeType.DanglingReference).
                    Select<KeyValuePair<int, NodeHandle>, KeyValuePair<int, IModelNode>>(x => new KeyValuePair<int, IModelNode>(x.Key, x.Value.Node)).
                    OrderBy<KeyValuePair<int, IModelNode>, string>(x => x.Value.Name);
      foreach (KeyValuePair<int, IModelNode> _Handle in _collection)
      {
        int _errorNumber = m_ErrorNumber;
        traceEvent(String.Format("Error {0}: The node name {1} has not bee defined or there is a wrong reference defined, and it is: ", _errorNumber, _Handle.Value.Name));
        IEnumerable<AddressSpace.ReferencesTableRow> _errors = m_AddressSpace.ReferencesTable.Where<AddressSpace.ReferencesTableRow>(x => x.TargetNodeIndex == _Handle.Key);
        int _maxErrors = c_MaxNumberOfErrors;
        foreach (AddressSpace.ReferencesTableRow _targetItem in _errors)
        {
          if (_maxErrors == 0)
          {
            traceEvent(String.Format("Error {0}: There are {1} affected nodes, but the listing is too long to be practical.", _errorNumber, _errors.Count()));
            break;
          }
          traceEvent(String.Format("Error {0}: The destination node for the reference type name: {1} and source node class : {2} and name: {3}.",
                                    _errorNumber,
                                    m_NodesList[_targetItem.ReferenceTypeIndex].Node.Name,
                                    m_NodesList[_targetItem.SourceNodeIndex].Node.NodeClass,
                                    m_NodesList[_targetItem.SourceNodeIndex].Node.SymbolicName));
          m_NodesList[_targetItem.SourceNodeIndex].Node.ErrorList.Add(new Diagnostics(String.Format("Error {0}: The destination node for the reference type name: {1}",
                                                                                                     _errorNumber,
                                                                                                     m_NodesList[_targetItem.ReferenceTypeIndex].Node.SymbolicName)));
          _maxErrors--;
        }
        _errors = m_AddressSpace.ReferencesTable.Where<AddressSpace.ReferencesTableRow>(x => x.ReferenceTypeIndex == _Handle.Key);
        _maxErrors = c_MaxNumberOfErrors;
        foreach (AddressSpace.ReferencesTableRow _targetItem in _errors)
        {
          if (_maxErrors == 0)
          {
            traceEvent(String.Format("Error {0}: There are {1} affected nodes, but the listing is too long to be practical.", _errorNumber, _errors.Count()));
            break;
          }
          traceEvent(String.Format("Error {0}: The type definition for the reference connecting the source node class: {1} and name: {2} and the target node class: {3} and name: {4}",
                                   _errorNumber,
                                   m_NodesList[_targetItem.SourceNodeIndex].Node.NodeClass,
                                   m_NodesList[_targetItem.SourceNodeIndex].Node.Name,
                                   m_NodesList[_targetItem.TargetNodeIndex].Node.NodeClass,
                                   m_NodesList[_targetItem.TargetNodeIndex].Node.Name));
          m_NodesList[_targetItem.SourceNodeIndex].Node.ErrorList.Add(new Diagnostics(String.Format("Error {0}: The type definition for the reference pointing out the target node class: {1} and name: {2}",
                                                                                                     _errorNumber,
                                                                                                     m_NodesList[_targetItem.TargetNodeIndex].Node.NodeClass,
                                                                                                     m_NodesList[_targetItem.TargetNodeIndex].Node.Name)));
          _maxErrors--;
        }
        _errors = m_AddressSpace.ReferencesTable.Where<AddressSpace.ReferencesTableRow>(x => x.SourceNodeIndex == _Handle.Key);
        _maxErrors = c_MaxNumberOfErrors;
        foreach (AddressSpace.ReferencesTableRow _targetItem in _errors)
        {
          if (_maxErrors == 0)
          {
            traceEvent(String.Format("Error {0}: There are {1} affected nodes, but the listing is too long to be practical.", _errorNumber, _errors.Count()));
            break;
          }
          traceEvent(String.Format("Error {0}: The source node for the reference type name: {1} and target node class: {2} and name: {3}",
                                   _errorNumber,
                                   m_NodesList[_targetItem.ReferenceTypeIndex].Node.Name,
                                   m_NodesList[_targetItem.TargetNodeIndex].Node.NodeClass,
                                   m_NodesList[_targetItem.TargetNodeIndex].Node.Name));
          m_NodesList[_targetItem.SourceNodeIndex].Node.ErrorList.Add(new Diagnostics(String.Format("Error {0}: The destination node {1} for the reference type name: {2}.",
                                                                                                     _errorNumber,
                                                                                                     _Handle.Value.Name,
                                                                                                     m_NodesList[_targetItem.ReferenceTypeIndex].Node.Name)));
          _maxErrors--;
        }
      }
      traceEvent(String.Format("Finishing address space compilation. there are {0} nodes in the address space", m_NodesList.Count));
    }
    //fields
    private int m_ErrorNumber { get { return p_ErrorNumber++; } }
    private int p_ErrorNumber = 0;
    private const int c_MaxNumberOfErrors = 20;
    private SortedList<string, int> m_Dictionary = new SortedList<string, int>();
    private Dictionary<int, NodeHandle> m_NodesList = new Dictionary<int, NodeHandle>();
    private AddressSpace.NodesTableRow m_Root = null;
    private AddressSpace m_AddressSpace { get; set; }
    private int m_listPosition = 0;
    private Action<string> m_TraceEvent;
    private string c_ErrorTemplate = "Error {0} for the name: {1} SymbolicName: {2} message: {3}";
    #endregion

  }
}
