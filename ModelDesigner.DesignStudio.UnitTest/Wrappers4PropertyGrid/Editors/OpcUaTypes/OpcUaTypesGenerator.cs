﻿//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers4ProperyGrid.Editors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid.Editors.OpcUaTypes
{
  [TestClass]
  public class OpcUaTypesGenerator
  {
    [TestMethod]
    [DeploymentItem(@"OpcUaTypes\XML\", @"OpcUaTypes\XML\")]
    public void OpcUaTypesGeneratorTest()
    {
      SortedList<string, string> opcuaListOfTypes = new SortedList<string, string>();
      List<string> m_XmlType = new List<string>(Enum.GetNames(typeof(XmlTypeCode)));
      string BuiltInTypesPath = Path.Combine(Environment.CurrentDirectory, @"OpcUaTypes\XML\Opc.Ua.Types.xsd");
      Assert.IsTrue(File.Exists(BuiltInTypesPath));
      using (XmlReader reader = XmlReader.Create(BuiltInTypesPath))
      {
        XmlSchema schema = new XmlSchema();
        schema = XmlSchema.Read(reader, null);
        reader.Dispose();
        string NameSpace = schema.TargetNamespace;
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add(schema);
        schemaSet.Compile();
        List<string> OpcUaTypesList = new List<string>();
        foreach (XmlSchema sch in schemaSet.Schemas())
          foreach (XmlSchemaElement element in sch.Elements.Values)
          {
            XmlSchemaSimpleType et = element.ElementSchemaType as XmlSchemaSimpleType;
            if (et == null)
              continue;
            if ((m_XmlType.Contains(et.TypeCode.ToString())))
            {
              Debug.WriteLine($"TypeCode = {et.TypeCode}, Name={element.Name}");
              OpcUaTypesList.Add(element.Name);
              //  m_TypeList.Add(element.Name, new XmlStandardValueEditor(element.Name));
            }
            //        m_TypeList.Add(RangeValueValueEditor.LocalName, new RangeValueValueEditor());
            //        m_TypeList.Add(XmValueValueEditor.LocalName, new XmValueValueEditor());
            //        m_TypeList.Add(NotSetValueEditor.LocalName, new NotSetValueEditor());
          }

        OpcUaTypesTemplate generator = new OpcUaTypesTemplate(OpcUaTypesList);
        string pageContent = generator.TransformText();
        string builtInTypePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OpcUaTypes.cs");
        File.WriteAllText(builtInTypePath, pageContent);
        Debug.WriteLine(builtInTypePath);
      }
    }

    private static readonly SortedList<string, ValueEditor> m_TypeList = new SortedList<string, ValueEditor>();
  }
}