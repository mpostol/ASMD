//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid
{
  //TODO Use moc to test CAS.UA.Model.Designer.Wrappers4PropertyGrid #40
  [TestClass]
  public class DocumentationAttributeUnitTest
  {
    [TestMethod]
    public void Constructor1TestMethod()
    {
      DocumentationAttribute _attribute = new DocumentationAttribute("name");
      Assert.IsNotNull(_attribute);
      Assert.AreEqual<string>("name", _attribute.Name);
      IConverterToDocumentationString _converter = _attribute.ConverterToDocumentationString;
      Assert.IsNotNull(_converter);
      Assert.AreSame(_converter.GetType(), typeof(StringGetter));
      TestClass _TestClass = new TestClass();
      Assert.AreEqual<string>(_TestClass.TestString, _converter.ConvertToString(_TestClass, String.Empty));
    }
    [TestMethod]
    public void Constructor2TestMethod()
    {
      DocumentationAttribute _attribute = new DocumentationAttribute("name", typeof(StringGetter));
      Assert.IsNotNull(_attribute);
      Assert.AreEqual<string>("name", _attribute.Name);
      IConverterToDocumentationString _converter = _attribute.ConverterToDocumentationString;
      Assert.IsNotNull(_converter);
      Assert.AreSame(_converter.GetType(), typeof(StringGetter));
    }
    [TestMethod]
    public void DateTimeGetterTest()
    {
      DocumentationAttribute _attribute = new DocumentationAttribute("name", typeof(DateTimeGetter));
      Assert.IsNotNull(_attribute);
      Assert.AreEqual<string>("name", _attribute.Name);
      IConverterToDocumentationString _converter = _attribute.ConverterToDocumentationString;
      Assert.IsNotNull(_converter);
      Assert.AreSame(_converter.GetType(), typeof(DateTimeGetter));
      DateTime? _TestDate = DateTime.Today;
      Assert.AreEqual<string>(_TestDate.ToString(), _converter.ConvertToString(_TestDate, String.Empty));
      Assert.AreEqual<string>("Null date", _converter.ConvertToString(new Nullable<DateTime>(), "Null date"));
      Assert.AreEqual<string>("Null date", _converter.ConvertToString(null, "Null date"));
      Assert.AreEqual<string>("Null date", _converter.ConvertToString(new TestClass(), "Null date"));
    }
    private class TestClass
    {
      internal string TestString = "DFA0AC63-E1B0-46C6-96BF-B5A4FDB9C1B5";
      public override string ToString()
      {
        return TestString;
      }
    }
  }
}
