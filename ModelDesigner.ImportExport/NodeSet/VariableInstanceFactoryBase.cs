//_______________________________________________________________
//  Title   : VariableInstanceFactoryBase
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
using System.Xml;
using UAOOI.SemanticData.InformationModelFactory;
using TraceMessage = UAOOI.SemanticData.UANodeSetValidation.TraceMessage;
using InstanceDesign = Opc.Ua.ModelCompiler.InstanceDesign;
using NodeDesign = Opc.Ua.ModelCompiler.NodeDesign;
using VariableDesign = Opc.Ua.ModelCompiler.VariableDesign;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal class VariableInstanceFactoryBase : InstanceFactoryBase, IVariableInstanceFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceFactoryBase" /> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public VariableInstanceFactoryBase(System.Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    #region IVariableInstanceFactory
    public byte? AccessLevel
    {
      set;
      private get;
    }
    public string ArrayDimensions
    {
      set;
      private get;
    }
    public XmlQualifiedName DataType
    {
      set;
      private get;
    }
    public XmlElement DefaultValue
    {
      set;
      internal get;
    }
    public bool? Historizing
    {
      set;
      private get;
    }
    public int? MinimumSamplingInterval
    {
      set;
      private get;
    }
    public byte? UserAccessLevel
    {
      set;
      private get;
    }
    public int? ValueRank
    {
      set;
      private get;
    }
    #endregion

    //internal API
    internal override NodeDesign Export(List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
    {
      VariableDesign _ret = new VariableDesign() { };
      Update(_ret, path, createInstanceType);
      return _ret;
    }

    //private
    protected void Update(VariableDesign node, List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
    {
      node.AccessLevel = this.AccessLevel.GetAccessLevel(x => node.AccessLevelSpecified = x, TraceEvent);
      node.ValueRank = this.ValueRank.GetValueRank(x => node.ValueRankSpecified = x, TraceEvent);
      node.ArrayDimensions = this.ArrayDimensions;
      node.DataType = this.DataType; //TODO must be DataType, must not be abstract
      node.DefaultValue = this.DefaultValue; //TODO must be of type defined by DataType
      node.Historizing = this.Historizing.GetValueOrDefault();
      node.HistorizingSpecified = this.Historizing.HasValue;
      node.MinimumSamplingInterval = this.MinimumSamplingInterval.GetValueOrDefault();
      node.MinimumSamplingIntervalSpecified = this.MinimumSamplingInterval.HasValue;
      base.UpdateInstance(node, path, TraceEvent, createInstanceType);
    }

  }

}
