//<summary>
//  Title   : TraceEvent in CAS.UA.Model.Designer
//  System  : Microsoft Visual C# .NET 
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//  History :
//    20090715: mzbrzezny: created
//
//  Copyright (C)2009-2011, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto:techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System;
using System.Diagnostics;
using System.Reflection;

namespace CAS.CommServer.UA.ModelDesigner.Configuration
{
  /// <summary>
  /// class responsible for tracing inside using TraceSource( "CAS.CommServer.UA.ModelDesigner.DesignStudio" )
  /// </summary>
  internal static class TraceEvent
  {
    private static Lazy<TraceSource> m_traceEvent_internal = new Lazy<TraceSource>(() => new TraceSource(Assembly.GetCallingAssembly().GetName().Name));
    /// <summary>
    /// Gets the tracer.
    /// </summary>
    /// <value>The tracer.</value>
    internal static TraceSource Tracer
    {
      get
      {
        return m_traceEvent_internal.Value;
      }
    }
  }
}
