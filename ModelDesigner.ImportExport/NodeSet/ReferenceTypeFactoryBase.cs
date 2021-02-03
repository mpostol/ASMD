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
using UAOOI.SemanticData.InformationModelFactory;
using TraceMessage = UAOOI.SemanticData.BuildingErrorsHandling.TraceMessage;
using InstanceDesign = Opc.Ua.ModelCompiler.InstanceDesign;
using LocalizedText = Opc.Ua.ModelCompiler.LocalizedText;
using NodeDesign = Opc.Ua.ModelCompiler.NodeDesign;
using ReferenceTypeDesign = Opc.Ua.ModelCompiler.ReferenceTypeDesign;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal class ReferenceTypeFactoryBase : TypeFactoryBase, IReferenceTypeFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="NodeFactoryBase" /> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public ReferenceTypeFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    //IReferenceTypeFactory
    public bool Symmetric
    {
      set;
      private get;
    }
    public void AddInverseName(string localeField, string valueField)
    {
      Extensions.AddLocalizedText(localeField, valueField, ref m_InverseName, TraceEvent);
    }

    //internal API
    internal override NodeDesign Export(List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
    {
      ReferenceTypeDesign _ret = new ReferenceTypeDesign()
      {
        InverseName = m_InverseName,
        Symmetric = this.Symmetric,
        SymmetricSpecified = this.Symmetric
      };
      Update(_ret, path, createInstanceType);
      return _ret;
    }

    //private
    private LocalizedText m_InverseName;
  }

}
