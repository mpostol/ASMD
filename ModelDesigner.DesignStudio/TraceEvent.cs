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

using System.Diagnostics;
namespace CAS.UA.Model.Designer
{
  /// <summary>
  /// class responsible for tracing inside this module, it uses  <see cref="TraceSource"/> with the name "CAS.UA.Model.Designer.TraceEvent"
  /// </summary>
  internal class TraceEvent : TraceSource
  {
    /// <summary>
    /// Prevents a default instance of the <see cref="TraceEvent"/> class from being created. Private to create singleton;
    /// </summary>
    private TraceEvent()
      : base(typeof(TraceEvent).ToString())
    { }
    private static TraceEvent m_traceSource = new TraceEvent();
    /// <summary>
    /// Gets the tracer.
    /// </summary>
    /// <value>The tracer.</value>
    public static TraceEvent Tracer
    {
      get
      {
        return m_traceSource;
      }
    }
  }
}
