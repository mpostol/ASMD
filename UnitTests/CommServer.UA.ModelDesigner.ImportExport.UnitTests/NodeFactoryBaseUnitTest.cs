
using CAS.UA.Model.Designer.ImportExport.NodeSet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UAOOI.SemanticData.UANodeSetValidation;
using InstanceDesign = Opc.Ua.ModelCompiler.InstanceDesign;
using LocalizedText = Opc.Ua.ModelCompiler.LocalizedText;
using NodeDesign = Opc.Ua.ModelCompiler.NodeDesign;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  [TestClass]
  public class NodeFactoryBaseUnitTest
  {
    [TestMethod]
    public void CreatorTestMethod()
    {
      NodeFactory _nf = new NodeFactory(x => { });
      Assert.IsNotNull(_nf);
    }
    [TestMethod]
    public void DescriptionTestMethod()
    {
      int _counter = 0;
      NodeFactory _nf = new NodeFactory(x => _counter++);
      Assert.AreEqual<int>(0, _counter);
      LocalizedText _lt = new LocalizedText() { Key = "localeField", Value = "valueField" };
      _nf.AddDescription(_lt.Key, _lt.Value);
      Assert.AreEqual<int>(0, _counter);
      _nf.AddDescription(_lt.Key, _lt.Value);
      Assert.AreEqual<int>(1, _counter);
      _nf.AddDescription(_lt.Key, _lt.Value);
      Assert.AreEqual<int>(2, _counter);
      List<string> _path = new List<string>();
      NodeDesign _nd = _nf.Export(_path, (x, Y) => { });
      _lt.Compare(_nd.Description);
    }
    private class NodeFactory : NodeFactoryBase
    {
      public NodeFactory(Action<TraceMessage> traceEvent)
        : base(traceEvent)
      {
        SymbolicName = new System.Xml.XmlQualifiedName( "Name", "NameSpace");
      }
      internal override NodeDesign Export(List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
      {
        NodeDesign _nd = new NodeDesign() {  };
        base.UpdateNode(_nd, path, createInstanceType);
        return _nd;
      }
    }
  }
}
