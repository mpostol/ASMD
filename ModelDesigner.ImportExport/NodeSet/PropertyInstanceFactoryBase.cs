//_______________________________________________________________
//  Title   : PropertyInstanceFactoryBase
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
using PropertyDesign = Opc.Ua.ModelCompiler.PropertyDesign;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  /// <summary>
  /// Class PropertyInstanceFactoryBase.
  /// </summary>
  internal class PropertyInstanceFactoryBase : VariableInstanceFactoryBase, IPropertyInstanceFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="PropertyInstanceFactoryBase"/> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public PropertyInstanceFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    //internal API
    internal override NodeDesign Export(List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
    {
      PropertyDesign _ret = new PropertyDesign();
      base.Update(_ret, path, createInstanceType);
      return _ret;
    }

  }

}
