//_______________________________________________________________
//  Title   : ObjectInstanceFactoryBase
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
using UAOOI.SemanticData.InformationModelFactory;
using TraceMessage = UAOOI.SemanticData.UANodeSetValidation.TraceMessage;
using InstanceDesign = Opc.Ua.ModelCompiler.InstanceDesign;
using NodeDesign = Opc.Ua.ModelCompiler.NodeDesign;
using ObjectDesign = Opc.Ua.ModelCompiler.ObjectDesign;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal class ObjectInstanceFactoryBase : InstanceFactoryBase, IObjectInstanceFactory
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceFactoryBase" /> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public ObjectInstanceFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    #region IObjectInstanceFactory
    public bool? SupportsEvents
    {
      set;
      private get;
    }
    #endregion

    #region internal API
    internal override NodeDesign Export(List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
    {
      ObjectDesign _ret = new ObjectDesign()
      {
        SupportsEvents = this.SupportsEvents.GetValueOrDefault(),
        SupportsEventsSpecified = this.SupportsEvents.HasValue
      };
      base.UpdateInstance(_ret, path, TraceEvent, createInstanceType);
      return _ret;
    }
    #endregion

  }
}
