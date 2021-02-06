//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using System.Diagnostics;
using System.Reflection;
using TraceMessage = UAOOI.SemanticData.BuildingErrorsHandling.TraceMessage;

namespace CAS.UA.Model.Designer
{
  /// <summary>
  /// class responsible for tracing inside this module, it uses  <see cref="TraceSource"/> with the name "CAS.CommServer.UA.ModelDesigner.DesignStudio"
  /// </summary>
  internal static class AssemblyTraceEvent
  {
    private static Lazy<TraceSource> m_traceSource = new Lazy<TraceSource>(() => new TraceSource(Assembly.GetCallingAssembly().GetName().Name));

    /// <summary>
    /// Gets the tracer.
    /// </summary>
    /// <value>The tracer.</value>
    public static TraceSource Tracer => m_traceSource.Value;
    internal static event EventHandler<string> Listeners;
    internal static void TraceMessage(TraceMessage message, string at, int id)
    {
      Tracer.TraceEvent(message.TraceLevel, id, "At {0}: {1}", at, message.Message);
      Listeners?.Invoke(null, $"At {at}: {id} {message.BuildError.ToString()}; {message.Message}");
    }
  }
}