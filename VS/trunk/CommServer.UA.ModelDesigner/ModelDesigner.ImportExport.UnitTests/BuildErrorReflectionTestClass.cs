using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using CAS.UA.Model.Designer.ImportExport.NodeSet;
using System.Collections.Generic;
using System.Xml;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  [TestClass]
  public class BuildErrorReflectionTestClass
  {
    //[TestMethod]
    public void BuildErrorReflectionTestMethod()
    {
      PropertyInfo[] _importer = typeof(BuildError).GetProperties(BindingFlags.Static | BindingFlags.GetProperty | BindingFlags.Public);
      Assert.IsNotNull(_importer);
      Assert.IsTrue(_importer.Length > 0);
      List<NamedBuildError> _ListNamedBuildError = new List<NamedBuildError>();
      foreach (PropertyInfo _item in _importer)
      {
        BuildError _be = (BuildError)_item.GetMethod.Invoke(null, new Object[] { });
        NamedBuildError _newBuildError = new NamedBuildError()
        {
          Name = _item.Name,
          Descriptor = _be.Descriptor,
          Focus = _be.Focus,
          Identifier = _be.Identifier
        };
        _ListNamedBuildError.Add(_newBuildError);
      }
      BuildErrorsCollection _errorList = new BuildErrorsCollection()
      {
        ListOfBuildErrors = _ListNamedBuildError.ToArray()
      };
      XmlFile.WriteXmlFile<BuildErrorsCollection>(_errorList, @"BuildErrorsCollection.xml", System.IO.FileMode.Create, "BuildErrorsCollection.xmls");

    }
    //[TestMethod]
    public void ReadXmlTestMethod()
    {
      XmlDocument _doc = new XmlDocument();
      _doc.Load(@"BuildErrorsCollection.xml");
      Assert.IsTrue(_doc.HasChildNodes);
      XmlNode _list = _doc.SelectSingleNode("BuildErrorsCollection/ListOfBuildErrors");
      Assert.IsTrue(_doc.HasChildNodes);
      foreach (XmlNode _node in _list.SelectNodes("NamedBuildError"))
      {
        Assert.IsNotNull(_node.SelectSingleNode("Descriptor").InnerText);
        Assert.IsNotNull(_node.SelectSingleNode("Focus").InnerText);
        Assert.IsNotNull(_node.SelectSingleNode("Identifier").InnerText);
        Assert.IsNotNull(_node.SelectSingleNode("Name").InnerText);
      }
    }
  }
}
