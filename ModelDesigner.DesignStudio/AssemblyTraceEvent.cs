//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using System;
using System.Diagnostics;
using System.Reflection;
using UAOOI.SemanticData.UANodeSetValidation;

namespace CAS.UA.Model.Designer
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
    public static TraceSource Tracer
    {
      get
      {
        return m_traceSource.Value;
      }
    }
    internal static void TraceMessage(TraceMessage message, string at, int id)
    {
      Tracer.TraceEvent(message.TraceLevel, id, "At {0}: {}", at, message.Message);
    }
  }
}
