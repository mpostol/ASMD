//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.UA.Model.Designer.Solution;
using System.IO;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.IO
{
  internal interface IProjectConfigurationManagement : ISolutionDirectoryPathManagement
  {
    UAModelDesignerProject UAModelDesignerProject { get; }
    OpcUaModelCompiler.ModelDesign ModelDesign { get; }
    string Name { get; }

    void Build(TextWriter output);

    void Save(OpcUaModelCompiler.ModelDesign model);
  }
}