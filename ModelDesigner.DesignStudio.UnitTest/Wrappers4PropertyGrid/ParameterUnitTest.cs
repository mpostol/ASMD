//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid
{
  //TODO Use moc to test CAS.UA.Model.Designer.Wrappers4PropertyGrid #40
  [TestClass]
  public class ParameterUnitTest
  {
    [TestMethod]
    public void TestMethod1()
    {
      OpcUaModelCompiler.Parameter _parameter = new OpcUaModelCompiler.Parameter()
      {
        ArrayDimensions = "ArrayDimensions",
        DataType = new System.Xml.XmlQualifiedName("name", "ns"),
        Description = new OpcUaModelCompiler.LocalizedText() { Key = "Key", Value = "Value" },
        Identifier = 0,
        IdentifierSpecified = false,
        Name = "Name",
        ValueRank = OpcUaModelCompiler.ValueRank.Scalar
      };
      Parameter _wrapper = new Parameter(_parameter);
      Assert.AreEqual<string>(_parameter.ArrayDimensions, _wrapper.ArrayDimensions);
      Assert.IsNotNull(_wrapper.DataType);
      Assert.AreEqual<string>("name", _wrapper.DataType.Name);
      Assert.AreEqual<string>("ns", _wrapper.DataType.NameSpace);
      Assert.IsNotNull(_wrapper.Description);
      Assert.AreEqual<string>(_parameter.Description.Key, _wrapper.Description.Key);
      Assert.AreEqual<string>(_parameter.Description.Value, _wrapper.Description.Value);
      Assert.IsFalse(_wrapper.Identifier.HasValue);
      Assert.AreEqual<string>(_parameter.Name, _wrapper.Name);
      Assert.AreEqual<OpcUaModelCompiler.ValueRank>(OpcUaModelCompiler.ValueRank.Scalar, _wrapper.ValueRank);
      Assert.IsNull(_wrapper.Parent);
      OpcUaModelCompiler.Parameter _parameterExported = _wrapper.Update();
      Assert.IsNotNull(_parameterExported);
      Assert.AreEqual<string>(_parameter.ArrayDimensions, _parameterExported.ArrayDimensions);
      Assert.IsNotNull(_parameterExported.DataType);
      Assert.AreEqual<string>("name", _parameterExported.DataType.Name);
      Assert.AreEqual<string>("ns", _parameterExported.DataType.Namespace);
      Assert.IsNotNull(_wrapper.Description);
      Assert.AreEqual<string>(_parameter.Description.Key, _parameterExported.Description.Key);
      Assert.AreEqual<string>(_parameter.Description.Value, _parameterExported.Description.Value);
      Assert.IsFalse(_parameterExported.IdentifierSpecified);
      Assert.AreEqual<string>(_parameter.Name, _parameterExported.Name);
      Assert.AreEqual<OpcUaModelCompiler.ValueRank>(OpcUaModelCompiler.ValueRank.Scalar, _parameterExported.ValueRank);
    }
  }
}