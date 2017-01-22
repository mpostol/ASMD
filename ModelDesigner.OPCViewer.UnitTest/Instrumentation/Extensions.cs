
using System;
using System.Diagnostics;
using System.Reflection;

namespace CAS.CommServer.ModelDesigner.OPCViewer.UnitTest.Instrumentation
{
  internal static class Extensions
  {
    internal static string GetFileName(this DelimitedListTraceListener listener)
    {
      if (listener == null)
        throw new ArgumentNullException(nameof(listener));
      FieldInfo fi = typeof(TextWriterTraceListener).GetField("fileName", BindingFlags.NonPublic | BindingFlags.Instance);
      if (fi == null)
        throw new NullReferenceException("Cannot create FieldInfo object");
      return (string)fi.GetValue(listener);
    }

  }
}
