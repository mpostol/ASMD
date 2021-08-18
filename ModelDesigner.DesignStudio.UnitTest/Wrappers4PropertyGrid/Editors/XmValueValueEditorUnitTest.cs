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
  public class XmValueValueEditorUnitTest
  {
    [TestMethod]
    public void Constructor1Test()
    {
      XmValueValueEditor _instance2Test = new XmValueValueEditor();
      //TODO DefaultValue - implement editor for VariableType #9
      Assert.Inconclusive("Must be implemented");
      Assert.AreEqual<string>("", _instance2Test.NodeId);
    }
  }
}