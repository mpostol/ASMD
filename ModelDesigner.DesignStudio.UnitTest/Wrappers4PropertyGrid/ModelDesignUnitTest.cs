
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.Wrappers4PropertyGrid
{
  [TestClass]
  public class ModelDesignUnitTest
  {
    [TestMethod]
    public void ModelDesignTest()
    {
      Opc.Ua.ModelCompiler.ModelDesign _node = new Opc.Ua.ModelCompiler.ModelDesign()
      {
        AnyAttr = null,
        DefaultLocale = null,
        Items = null,
        Namespaces = new Opc.Ua.ModelCompiler.Namespace[] { },
        TargetNamespace = "TargetNamespace",
        TargetPublicationDate = DateTime.Today,
        TargetPublicationDateSpecified = false,
        TargetVersion = "TargetVersion",
        TargetXmlNamespace = "TargetXmlNamespace"
      };
      ModelDesign _model = new ModelDesign(_node);
      Assert.IsNull(_model.AnyAttr);
      Assert.IsNull(_model.DefaultLocale);
      Assert.IsNull(_model.Parent);
      Assert.AreEqual<string>("TargetNamespace", _model.TargetNamespace);
      Assert.IsFalse(_model.TargetPublicationDate.HasValue);
      Assert.AreEqual<string>("TargetVersion", _model.TargetVersion);
      Assert.AreEqual<string>("TargetXmlNamespace", _model.TargetXmlNamespace);
      Opc.Ua.ModelCompiler.ModelDesign _nodeExported = _model.Update();
      Assert.IsNotNull(_nodeExported);
      Assert.IsNull(_nodeExported.AnyAttr);
      Assert.IsNull(_nodeExported.DefaultLocale);
      Assert.IsNull(_nodeExported.Items);
      Assert.IsNull(_nodeExported.Namespaces);
      Assert.AreEqual<string>("TargetNamespace", _nodeExported.TargetNamespace);
      Assert.IsFalse(_nodeExported.TargetPublicationDateSpecified);
      Assert.AreEqual<string>("TargetVersion", _nodeExported.TargetVersion);
      Assert.AreEqual<string>("TargetXmlNamespace", _nodeExported.TargetXmlNamespace);

    }
  }
}
