//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid
{
  //TODO Use moc to test CAS.UA.Model.Designer.Wrappers4PropertyGrid #40
  [TestClass]
  public class ParameterUnitTest
  {
    [TestMethod]
    public void TestMethod1()
    {
      Opc.Ua.ModelCompiler.Parameter _parameter = new Opc.Ua.ModelCompiler.Parameter()
      {
        ArrayDimensions = "ArrayDimensions",
        DataType = new System.Xml.XmlQualifiedName("name", "ns"),
        Description = new Opc.Ua.ModelCompiler.LocalizedText() { Key = "Key", Value = "Value" },
        Identifier = 0,
        IdentifierSpecified = false,
        Name = "Name",
        ValueRank = Opc.Ua.ModelCompiler.ValueRank.Scalar
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
      Assert.AreEqual<Opc.Ua.ModelCompiler.ValueRank>(Opc.Ua.ModelCompiler.ValueRank.Scalar, _wrapper.ValueRank);
      Assert.IsNull(_wrapper.Parent);
      Opc.Ua.ModelCompiler.Parameter _parameterExported = _wrapper.Update();
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
      Assert.AreEqual<Opc.Ua.ModelCompiler.ValueRank>(Opc.Ua.ModelCompiler.ValueRank.Scalar, _parameterExported.ValueRank);
    }
  }
}
