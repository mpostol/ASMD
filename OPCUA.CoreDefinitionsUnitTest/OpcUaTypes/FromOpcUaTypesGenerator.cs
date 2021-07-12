//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Schema;

namespace UAOOI.OPCUA.CoreDefinitionsUnitTest.OpcUaTypes
{
  [TestClass]
  public class FromOpcUaTypesGenerator
  {
    [TestMethod]
    public void FromCodeGenerator()
    {
      List<string> xmlType = new List<string>(Enum.GetNames(typeof(XmlTypeCode)));
      Assembly thisAssembly = Assembly.GetExecutingAssembly();
      Type[] publicTypes = thisAssembly.GetExportedTypes();
      List<string> dataTypes = (from type in publicTypes
                                where (type.Namespace == typeof(Opc.Ua.Types.NodeId).Namespace)
                                where !type.Name.StartsWith("ListOf")
                                select type.Name).ToList<string>();
      Assert.AreEqual<int>(338, dataTypes.Count<string>(), $"Number of data types is {dataTypes.Count<string>()}");
    }
  }
}