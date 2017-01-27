
using CAS.UA.Model.Designer.ImportExport.NodeSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using OldModel = Opc.Ua.ModelCompiler;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  [TestClass]
  public class NamespaceUnitTest
  {

    [TestMethod]
    public void NamespaceTestMethod1()
    {

      List<TraceMessage> _trace = new List<NodeSet.TraceMessage>();
      UANodeSet _ns = TestData.CreateNodeSetModel();
      int _diagnosticCounter = 0;
      Assert.IsTrue(_ns.NamespaceUris.Length >= 1, "Wrong test data - NamespaceUris must contain more then 2 items");
      OldModel.ModelDesign _md = NodeSet.AddressSpaceContextService.CreateInstance
        (_ns.NamespaceUris[0], x => x.ImportNodeSet(_ns, y => TraceDiagnostic(y, _trace, ref _diagnosticCounter), true), z => TraceDiagnostic(z, _trace, ref _diagnosticCounter));
      Assert.AreEqual<int>(2, _md.Namespaces.Length);
      Assert.AreEqual<int>(0, _trace.Where<TraceMessage>(x => x.BuildError.Focus != Focus.Diagnostic ).Count<TraceMessage>());
    }

    [TestMethod]
    public void TraceMessageTestMethod()
    {
      List<TraceMessage> _trace = new List<NodeSet.TraceMessage>();
      int _diagnosticCounter = 0;
      UANodeSet _ns = TestData.CreateNodeSetModel();
      Assert.IsTrue(_ns.NamespaceUris.Length >= 1, "Wrong test data - NamespaceUris must contain more then 2 items");
      OldModel.ModelDesign _md = NodeSet.AddressSpaceContextService.CreateInstance
        (_ns.NamespaceUris[0], x => x.ImportNodeSet(_ns, y => TraceDiagnostic(y, _trace, ref _diagnosticCounter), true), z => TraceDiagnostic(z, _trace, ref _diagnosticCounter));
      Assert.IsTrue(_trace.Count == 0);
      Assert.IsTrue(_diagnosticCounter > 0);
    }
    private void TraceDiagnostic(TraceMessage msg, List<TraceMessage> errors, ref int diagnosticCounter)
    {
      Console.WriteLine(msg.ToString());
      if (msg.BuildError.Focus == Focus.Diagnostic)
      {
        diagnosticCounter++;
      }
      else
        errors.Add(msg);
    }
  }
}
