//_______________________________________________________________
//  Title   : InformationModelFactoryBase
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
using UAOOI.SemanticData.InformationModelFactory;
using TraceMessage = UAOOI.SemanticData.UANodeSetValidation.TraceMessage;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal class InformationModelFactoryBase : NodesContainer, IModelFactory
  {

    public InformationModelFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }
    
    //IModelFactory
    public void CreateNamespace(string uri) { }

  }

}
