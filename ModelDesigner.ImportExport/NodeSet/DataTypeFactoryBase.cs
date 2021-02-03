//_______________________________________________________________
//  Title   : DataTypeFactoryBase
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
using System.Diagnostics;
using System.Linq;
using UAOOI.SemanticData.InformationModelFactory;
using TraceMessage = UAOOI.SemanticData.BuildingErrorsHandling.TraceMessage;
using DataTypeDesign = Opc.Ua.ModelCompiler.DataTypeDesign;
using InstanceDesign = Opc.Ua.ModelCompiler.InstanceDesign;
using NodeDesign = Opc.Ua.ModelCompiler.NodeDesign;
using Parameter = Opc.Ua.ModelCompiler.Parameter;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal class DataTypeFactoryBase : TypeFactoryBase, IDataTypeFactory
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="NodeFactoryBase" /> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public DataTypeFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    //IDataTypeFactory
    public IDataTypeDefinitionFactory NewDefinition()
    {
      Debug.Assert(m_DataTypeDefinitionFactoryBase == null);
      m_DataTypeDefinitionFactoryBase = new DataTypeDefinitionFactoryBase(TraceEvent);
      return m_DataTypeDefinitionFactoryBase;
    }

    //internal  API
    internal override NodeDesign Export(List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
    {
      DataTypeDesign _new = new DataTypeDesign()
      {
        Fields = m_DataTypeDefinitionFactoryBase.Export().ToArray<Parameter>(),
        Encodings = null, //Not supported
        NoArraysAllowed = false, //Not supported
        NotInAddressSpace = false //Not supported
      };
      base.Update(_new, path, createInstanceType);
      return _new;
    }

    //private
    private DataTypeDefinitionFactoryBase m_DataTypeDefinitionFactoryBase = null;

  }
}
