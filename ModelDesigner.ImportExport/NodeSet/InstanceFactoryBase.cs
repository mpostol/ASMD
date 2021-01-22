//_______________________________________________________________
//  Title   : InstanceFactoryBase
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
using TraceMessage = UAOOI.SemanticData.BuildingErrorsHandling.TraceMessage;
using InstanceDesign = Opc.Ua.ModelCompiler.InstanceDesign;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{
  internal abstract class InstanceFactoryBase : NodeFactoryBase, IInstanceFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceFactoryBase"/> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public InstanceFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    {}

    //IInstanceFactory
    public ModelingRules? ModelingRule
    {
      set;
      private get;
    }
    public XmlQualifiedName TypeDefinition
    {
      set;
      private get;
    }
    public XmlQualifiedName ReferenceType
    {
      set;
      private get;
    }

    //internal API
    protected void UpdateInstance(InstanceDesign nodeDesign, List<string> path, System.Action<TraceMessage> traceEvent, Action<InstanceDesign, List<string>> createInstanceType)
    {
      nodeDesign.Declaration = null;
      nodeDesign.MaxCardinality = 0;
      nodeDesign.MinCardinality = 0;
      nodeDesign.ModellingRule = this.ModelingRule.ConvertModellingRule(x => nodeDesign.ModellingRuleSpecified = x);
      nodeDesign.PreserveDefaultAttributes = false;
      nodeDesign.ReferenceType = this.ReferenceType;
      nodeDesign.TypeDefinition = this.TypeDefinition;
      base.UpdateNode(nodeDesign, path, createInstanceType);
    }

  }
}
