//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAS.UA.Model.Designer.IO
{
  [TestClass]
  public class UniqueNameGeneratorUnitTest
  {
    [TestMethod]
    public void GenerateNewNameTest()
    {
      UniqueNameGenerator _newInstance = new UniqueNameGenerator("RandomPrefix");
      string _newName1 = _newInstance.GenerateNewName();
      Assert.IsTrue(_newName1.StartsWith("RandomPrefix"));
      for (int i = 0; i < 1000; i++)
      {
        string _newName = _newInstance.GenerateNewName();
        Assert.AreNotEqual<string>(_newName1, _newName);
        Assert.IsTrue(_newName.StartsWith("RandomPrefix"));
        Assert.IsTrue(_newName.Contains($"{i+1}"), $"{_newName} - for {i}");
      }
    }
  }
}
