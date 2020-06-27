//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.IO
{
  internal interface ISolutionConfigurationManagement : ISolutionDirectoryPathManagement, IConfigurationManagement
  {
    string Name { get; }
    IEnumerable<IProjectConfigurationManagement> Projects { get; }
    ServerSelector ServerSelector { get; }

    void Save(bool prompt);

    void ImportNodeSet();

    void NewModelDesign();

    void ImportModelDesign();
  }
}