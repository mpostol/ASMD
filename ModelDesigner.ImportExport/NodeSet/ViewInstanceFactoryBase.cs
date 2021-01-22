//_______________________________________________________________
//  Title   : ViewInstanceFactoryBase
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
using TraceMessage= UAOOI.SemanticData.UANodeSetValidation.TraceMessage;
using InstanceDesign = Opc.Ua.ModelCompiler.InstanceDesign;
using NodeDesign = Opc.Ua.ModelCompiler.NodeDesign;
using ViewDesign = Opc.Ua.ModelCompiler.ViewDesign;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal class ViewInstanceFactoryBase : InstanceFactoryBase, IViewInstanceFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceFactoryBase" /> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public ViewInstanceFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    //IViewInstanceFactory
    public bool? SupportsEvents
    {
      set;
      private get;
    }
    public bool ContainsNoLoops
    {
      set;
      private get;
    }

    //internal API
    internal override NodeDesign Export(List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
    {
      ViewDesign _ret = new ViewDesign()
      {
        ContainsNoLoops = this.ContainsNoLoops, //TODO test against the loops.
        SupportsEvents = this.SupportsEvents.GetValueOrDefault(),
      };
      base.UpdateInstance(_ret, path, TraceEvent, createInstanceType);
      return _ret;
    }
  }
}
