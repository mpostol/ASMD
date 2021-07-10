//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.ComponentModel;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid.Editors
{
  [TestClass]
  public class CustomTypeListConverterUnitTest
  {
    [TestMethod]
    public void StaticTestMethod()
    {
      string name = CustomTypeListConverter.NameSpace;
      Assert.IsTrue(string.IsNullOrEmpty(name));
    }

    [TestMethod]
    public void ConstructorTestMethod()
    {
      CustomTypeListConverter instance2Test = new CustomTypeListConverter();
      Mock<ITypeDescriptorContext> typeDescriptor = new Mock<ITypeDescriptorContext>();
      TypeConverter.StandardValuesCollection values = instance2Test.GetStandardValues(typeDescriptor.Object);
      Assert.IsNotNull(values);
      Assert.AreEqual<int>(0, values.Count);
      Assert.IsFalse(instance2Test.CanConvertFrom(typeof(bool)));
      Assert.IsFalse(instance2Test.CanConvertFrom(typeof(float)));
      Assert.IsTrue(instance2Test.CanConvertFrom(typeof(string)));
    }

  }
}