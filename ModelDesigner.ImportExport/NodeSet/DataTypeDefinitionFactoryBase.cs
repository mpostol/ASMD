//_______________________________________________________________
//  Title   : DataTypeDefinitionFactoryBase
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
using System.Xml;
using UAOOI.SemanticData.InformationModelFactory;
using Parameter = Opc.Ua.ModelCompiler.Parameter;
using TraceMessage = UAOOI.SemanticData.UANodeSetValidation.TraceMessage;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal class DataTypeDefinitionFactoryBase : IDataTypeDefinitionFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypeDefinitionFactoryBase"/> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public DataTypeDefinitionFactoryBase(Action<TraceMessage> traceEvent)
    {
      Debug.Assert(traceEvent != null);
      m_TraceEvent = traceEvent;
    }

    #region IDataTypeDefinitionFactory
    public IDataTypeFieldFactory NewField()
    {
      DataTypeFieldFactoryBase _new = new DataTypeFieldFactoryBase(m_TraceEvent);
      m_ListOfDataTypeFieldFactoryBase.Add(_new);
      return _new;
    }
    public XmlQualifiedName Name
    {
      set { }
    }
    public XmlQualifiedName BaseType
    {
      set { }
    }
    public string SymbolicName
    {
      set { }
    }
    #endregion

    #region internal API
    internal IEnumerable<Parameter> Export()
    {
      return m_ListOfDataTypeFieldFactoryBase.Select<DataTypeFieldFactoryBase, Parameter>(x => x.Export());
    }
    #endregion

    #region private
    private Action<TraceMessage> m_TraceEvent = null;
    private List<DataTypeFieldFactoryBase> m_ListOfDataTypeFieldFactoryBase = new List<DataTypeFieldFactoryBase>();
    #endregion

  }

}
