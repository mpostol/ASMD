//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.Collections.Generic;

namespace UAOOI.OPCUA.CoreDefinitionsUnitTest.BuiltInTypes
{
  public partial class BuiltInTypesEnumTemplate
  {
    public BuiltInTypesEnumTemplate(IEnumerable<string> buildInTypes)
    {
      BuildInTypes = buildInTypes;
    }
    private IEnumerable<string> BuildInTypes; 
  }
}