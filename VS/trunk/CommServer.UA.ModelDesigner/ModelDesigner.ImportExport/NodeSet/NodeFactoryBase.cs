//_______________________________________________________________
//  Title   : NodeFactoryBase
//  System  : Microsoft VisualStudio 2013 / C#
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2015, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using UAOOI.SemanticData.InformationModelFactory;
using ModelDesign = Opc.Ua.ModelCompiler;
using TraceMessage = UAOOI.SemanticData.UANodeSetValidation.TraceMessage;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal abstract class NodeFactoryBase : NodesContainer, INodeFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="NodeFactoryBase"/> class.
    /// </summary>
    /// <param name="traceEvent">Encapsulates an action used to trace events and model errors.</param>
    public NodeFactoryBase(Action<TraceMessage> traceEvent) : base(traceEvent) { }

    #region INodeFactory
    public string BrowseName
    {
      set;
      private get;
    }
    public IReferenceFactory NewReference()
    {
      ReferenceFactoryBase _ret = new ReferenceFactoryBase();
      m_References.Add(_ret);
      return _ret;
    }
    public XmlQualifiedName SymbolicName
    {
      set;
      internal get;
    }
    public uint WriteAccess
    {
      set;
      private get;
    }
    public void AddDescription(string localeField, string valueField)
    {
      Extensions.AddLocalizedText(localeField, valueField, ref m_Description, this.TraceEvent);
    }
    public void AddDisplayName(string localeField, string valueField)
    {
      Extensions.AddLocalizedText(localeField, valueField, ref m_DisplayName, this.TraceEvent);
    }
    #endregion

    #region internal API
    internal abstract ModelDesign.NodeDesign Export(List<string> path, Action<ModelDesign.InstanceDesign, List<string>> createInstanceType);
    #endregion

    #region private
    protected void UpdateNode(ModelDesign.NodeDesign nodeDesign, List<string> path, Action<ModelDesign.InstanceDesign, List<string>> createInstanceType)
    {
      string _defaultDisplay = String.IsNullOrEmpty(BrowseName) ? SymbolicName.Name : BrowseName;
      nodeDesign.BrowseName = BrowseName == SymbolicName.Name ? null : BrowseName;
      List<ModelDesign.NodeDesign> _Members = new List<ModelDesign.NodeDesign>();
      path.Add(this.SymbolicName.Name);
      base.ExportNodes(_Members, path, createInstanceType);
      ModelDesign.InstanceDesign[] _items = _Members.Cast<ModelDesign.InstanceDesign>().ToArray<ModelDesign.InstanceDesign>();
      nodeDesign.Children = _items == null || _items.Length == 0 ? null : new ModelDesign.ListOfChildren() { Items = _items };
      nodeDesign.Description = this.m_Description;
      nodeDesign.DisplayName = this.m_DisplayName == null || this.m_DisplayName.Value == _defaultDisplay ? null : m_DisplayName;
      nodeDesign.IsDeclaration = false;
      nodeDesign.NumericId = 0;
      nodeDesign.NumericIdSpecified = false;
      nodeDesign.References = m_References.Count == 0 ? null : m_References.Select<ReferenceFactoryBase, ModelDesign.Reference>(x => x.Export()).ToArray<ModelDesign.Reference>();
      nodeDesign.StringId = null;
      nodeDesign.SymbolicId = null;
      nodeDesign.SymbolicName = this.SymbolicName;
      nodeDesign.WriteAccess = this.WriteAccess;
    }
    private ModelDesign.LocalizedText m_Description = null;
    private ModelDesign.LocalizedText m_DisplayName = null;
    private List<ReferenceFactoryBase> m_References = new List<ReferenceFactoryBase>();
    #endregion

  }

}
