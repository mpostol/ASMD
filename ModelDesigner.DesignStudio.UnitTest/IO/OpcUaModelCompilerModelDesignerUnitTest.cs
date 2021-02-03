//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;
using UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.IO
{
  [TestClass]
  public class OpcUaModelCompilerModelDesignerUnitTest
  {
    [TestMethod]
    public void DefaultValuesTest()
    {
      ModelDesign _default = OpcUaModelCompilerModelDesigner.GetDefault();
      Assert.IsNotNull(_default);
      Assert.IsNull(_default.AnyAttr);
      Assert.IsFalse(string.IsNullOrEmpty(_default.DefaultLocale));
      Assert.AreEqual<string>("en", _default.DefaultLocale);
      Assert.IsNull(_default.Items);
      Assert.IsNotNull(_default.Namespaces);
      Assert.AreEqual<int>(2, _default.Namespaces.Length);
      Assert.IsFalse(string.IsNullOrEmpty(_default.TargetNamespace));
      Assert.AreEqual<string>("http://cas.eu/UA/CommServer/", _default.TargetNamespace);
      Assert.IsFalse(_default.TargetPublicationDateSpecified);
      Assert.IsTrue(string.IsNullOrEmpty(_default.TargetVersion));
      Assert.IsNull(_default.TargetXmlNamespace);
      Assert.AreEqual<string>("OpcUa", _default.Namespaces[1].Name);
      Assert.AreEqual<string>("Opc.Ua", _default.Namespaces[1].Prefix);
      Assert.AreEqual<string>(@"http://opcfoundation.org/UA/", _default.Namespaces[1].Value);
      Assert.AreEqual<string>(@"http://opcfoundation.org/UA/2008/02/Types.xsd", _default.Namespaces[1].XmlNamespace);
    }
  }
}