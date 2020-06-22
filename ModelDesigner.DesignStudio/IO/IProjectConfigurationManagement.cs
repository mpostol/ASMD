//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Solution;
using System.IO;
using OPCFModelDesign = Opc.Ua.ModelCompiler.ModelDesign;

namespace CAS.UA.Model.Designer.IO
{
  internal interface IProjectConfigurationManagement
  {
    UAModelDesignerProject UAModelDesignerProject { get; }
    OPCFModelDesign ModelDesign { get; }
    string Name { get; }

    void SaveModelDesign(OPCFModelDesign modelDesign);

    void Build(TextWriter output);
  }
}