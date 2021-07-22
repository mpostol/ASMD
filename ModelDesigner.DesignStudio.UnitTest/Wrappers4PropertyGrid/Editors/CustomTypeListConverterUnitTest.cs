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
    public void ConstructorTestMethod()
    {
      CustomTypeListConverter instance2Test = new CustomTypeListConverter();
      Assert.IsFalse(instance2Test.CanConvertFrom(typeof(bool)));
      Assert.IsFalse(instance2Test.CanConvertFrom(typeof(float)));
      Assert.IsTrue(instance2Test.CanConvertFrom(typeof(string)));

      Assert.IsFalse(instance2Test.CanConvertTo(typeof(bool)));
      Assert.IsFalse(instance2Test.CanConvertTo(typeof(float)));
      Assert.IsTrue(instance2Test.CanConvertTo(typeof(string)));

      Assert.IsNotNull(instance2Test.ConvertFromInvariantString("1234"));

      Assert.IsTrue(instance2Test.GetStandardValuesSupported());
      Assert.IsFalse(instance2Test.GetStandardValuesExclusive());
      Mock<ITypeDescriptorContext> typeDescriptor = new Mock<ITypeDescriptorContext>();
      TypeConverter.StandardValuesCollection values = instance2Test.GetStandardValues(typeDescriptor.Object);
      Assert.IsNotNull(values);
      Assert.AreEqual<int>(83, values.Count);
    }

    [TestMethod]
    public void ConvertFromTestMethod1()
    {
      //TODO DefaultValue - implement editor for VariableType #9
      CustomTypeListConverter instance2Test = new CustomTypeListConverter();
      Assert.IsInstanceOfType(instance2Test.ConvertFrom("AccessLevelExType"), typeof(XmlStandardValueEditor));
      Assert.IsInstanceOfType(instance2Test.ConvertFrom("Boolean"), typeof(XmlStandardValueEditor));
      Assert.IsInstanceOfType(instance2Test.ConvertFrom("DataChangeTrigger"), typeof(XmlStandardValueEditor));
      Assert.IsInstanceOfType(instance2Test.ConvertFrom("VersionTime"), typeof(XmlStandardValueEditor));
    }
    [TestMethod]
    public void ConvertFromTestMethod2()
    {
      //TODO DefaultValue - implement editor for VariableType #9
      CustomTypeListConverter instance2Test = new CustomTypeListConverter();
      Assert.IsInstanceOfType(instance2Test.ConvertFrom(null, null, "AccessLevelExType"), typeof(XmlStandardValueEditor));
      Assert.IsInstanceOfType(instance2Test.ConvertFrom(null, null, "Boolean"), typeof(XmlStandardValueEditor));
      Assert.IsInstanceOfType(instance2Test.ConvertFrom(null, null, "DataChangeTrigger"), typeof(XmlStandardValueEditor));
      Assert.IsInstanceOfType(instance2Test.ConvertFrom(null, null, "VersionTime"), typeof(XmlStandardValueEditor));
    }
  }
}