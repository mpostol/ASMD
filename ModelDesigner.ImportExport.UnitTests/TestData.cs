using CAS.UA.Model.Designer.ImportExport.NodeSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  internal static class TestData
  {
    public static UANodeSet CreateNodeSetModel()
    {
      UANodeSet _ns = new UANodeSet()
      {
        NamespaceUris = new string[] { @"http://cas.eu/UA/Demo/" },
        Aliases = new NodeIdAlias[] { 
                                      new NodeIdAlias() { Alias = "Boolean", Value = "i=1" },
                                      new NodeIdAlias() { Alias = "HasSubtype", Value = "i=45" } 
                                    },
        Items = new UANode[]
        {
          new UAReferenceType() {  NodeId = "ns=1;i=985", BrowseName="1:FlowTo", DisplayName = new LocalizedText[]{ new LocalizedText()  { Value = "FlowTo"}}, Symmetric = true, 
                                   References = new Reference[] { new Reference() {ReferenceType="HasSubtype", IsForward=false, Value = "i=32"}  }
                                }
        }
      };
      return _ns;
    }

  }
}
