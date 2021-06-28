//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.CommServer.UA.Common;
using CAS.UA.Common.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using UAOOI.Common.Infrastructure.Serializers;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  [TestClass]
  [DeploymentItem(@"Coding\", @"Coding\")]
  public class ArgumentUnitTest
  {
    [TestMethod]
    public void ArgumentDecodingTestMethod()
    {
      FileInfo _file = new FileInfo(@"Coding\ArgumentsTest.xml");
      Assert.IsTrue(_file.Exists);
      ListOfExtensionObject _wrapper = XmlFile.ReadXmlFile<ListOfExtensionObject>(_file.FullName);
      Assert.IsNotNull(_wrapper);
      Assert.AreEqual<string>("i=297", _wrapper.ExtensionObject[0].TypeId.Identifier);
      Assert.AreEqual<int>(2, _wrapper.ExtensionObject.Length);
      Argument _argument1 = XmlHelper.GetObject<Argument>(_wrapper.ExtensionObject[0].Body);
      Assert.AreEqual<string>("Input1", _argument1.Name);
      Assert.AreEqual<int>(3, _argument1.ArrayDimensions.Length);
      Assert.AreEqual<int>(-1, _argument1.ValueRank);
      Assert.IsNull(_argument1.Description);
    }
  }
}