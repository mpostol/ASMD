//_______________________________________________________________
//  Title   : Name of Application
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
using AccessLevel = Opc.Ua.ModelCompiler.AccessLevel;
using InstanceDesign = Opc.Ua.ModelCompiler.InstanceDesign;
using NodeDesign = Opc.Ua.ModelCompiler.NodeDesign;
using VariableTypeDesign = Opc.Ua.ModelCompiler.VariableTypeDesign;


namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{
  internal class VariableTypeFactoryBase : TypeFactoryBase, IVariableTypeFactory
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="VariableTypeFactoryBase"/> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public VariableTypeFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    #region IVariableTypeFactory
    public XmlElement DefaultValue
    {
      set;
      private get;
    }
    public XmlQualifiedName DataType
    {
      set;
      private get;
    }
    public int? ValueRank
    {
      set;
      private get;
    }
    public string ArrayDimensions
    {
      set;
      private get;
    }
    #endregion

    //internal API
    internal override NodeDesign Export(List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
    {
      VariableTypeDesign _ret = new VariableTypeDesign()
      {
        ArrayDimensions = this.ArrayDimensions,
        DataType = this.DataType,
        DefaultValue = this.DefaultValue,
        //Not supported by the VariableType NodeClass 
        ExposesItsChildren = false,
        AccessLevel =  AccessLevel.ReadWrite,
        AccessLevelSpecified = false,
        Historizing = false,
        HistorizingSpecified = false,
        MinimumSamplingInterval = 0,
        MinimumSamplingIntervalSpecified = false,
      };
      _ret.ValueRank = this.ValueRank.GetValueRank(x => _ret.ValueRankSpecified = x, TraceEvent);
      base.Update(_ret, path, createInstanceType);
      return _ret;
    }
  }
}
