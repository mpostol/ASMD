//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid.Editors
{
  [TestClass]
  public class NotSetValueEditorUnitTest
  {
    [TestMethod]
    public void ConstructorTest()
    {
      NotSetValueEditor instance2Test = new NotSetValueEditor();
      Assert.AreEqual<string>("<Not set>", instance2Test.TypeName);
      Assert.AreEqual<string>("<Not set>", instance2Test.ToString());
      Assert.IsNull(instance2Test.XmlElement);
    }
  }
}