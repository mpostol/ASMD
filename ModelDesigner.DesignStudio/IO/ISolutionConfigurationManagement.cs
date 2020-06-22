//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using System;
using System.Collections.Generic;
using UAOOI.SemanticData.UANodeSetValidation;

namespace CAS.UA.Model.Designer.IO
{
  internal interface ISolutionConfigurationManagement : ISolutionDirectoryPathManagement, IConfigurationManagement
  {
    string Name { get; }
    IEnumerable<IProjectConfigurationManagement> Projects { get; }
    ServerSelector ServerSelector { get; }

    void Save(bool prompt);

    void ImportNodeSet(Action<TraceMessage> traceEvent);

    void CreateNewModel(Action<TraceMessage> traceEvent);

    void OpenExistingModel(Action<TraceMessage> traceEvent);
  }
}