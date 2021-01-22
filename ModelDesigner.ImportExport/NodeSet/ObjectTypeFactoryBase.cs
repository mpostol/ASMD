//_______________________________________________________________
//  Title   : ObjectTypeFactoryBase
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
using TraceMessage = UAOOI.SemanticData.BuildingErrorsHandling.TraceMessage;
using InstanceDesign = Opc.Ua.ModelCompiler.InstanceDesign;
using NodeDesign = Opc.Ua.ModelCompiler.NodeDesign;
using ObjectTypeDesign = Opc.Ua.ModelCompiler.ObjectTypeDesign;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal class ObjectTypeFactoryBase : TypeFactoryBase, IObjectTypeFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="NodeFactoryBase" /> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public ObjectTypeFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    //internal API
    internal override NodeDesign Export(List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
    {
      ObjectTypeDesign _ret = new ObjectTypeDesign()
      {
        SupportsEvents = false,
        SupportsEventsSpecified = false
      };
      base.Update(_ret, path, createInstanceType);
      return _ret;
    }

  }

}
