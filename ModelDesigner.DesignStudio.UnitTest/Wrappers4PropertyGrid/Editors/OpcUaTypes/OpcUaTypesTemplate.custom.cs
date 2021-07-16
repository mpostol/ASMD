//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.Collections.Generic;

namespace CAS.UA.Model.Designer.Wrappers4PropertyGrid.Editors.OpcUaTypes
{
  public partial class OpcUaTypesTemplate
  {
    public OpcUaTypesTemplate(IEnumerable<string> opcUaTypesList)
    {
      OpcUaTypesList = opcUaTypesList;
    }

    private readonly IEnumerable<string> OpcUaTypesList;
  }
}