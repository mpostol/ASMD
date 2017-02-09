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
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto:techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System;
using System.Diagnostics;
using System.Reflection;

namespace CAS.CommServer.UA.ModelDesigner.OPCViewer
{
  /// <summary>
  /// class responsible for tracing inside this module, it uses  <see cref="TraceSource"/> with the name "CAS.CommServer.UA.ModelDesigner.DesignStudio"
  /// </summary>
  internal static class AssemblyTraceEvent
  {
    private static Lazy<TraceSource> m_traceSource = new Lazy<TraceSource>( () => new TraceSource(Assembly.GetCallingAssembly().GetName().Name));
    /// <summary>
    /// Gets the tracer.
    /// </summary>
    /// <value>The tracer.</value>
    internal static TraceSource Tracer
    {
      get
      {
        return m_traceSource.Value;
      }
    }
  }
}
