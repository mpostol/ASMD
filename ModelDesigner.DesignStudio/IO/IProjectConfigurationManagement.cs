//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Solution;
using System;
using System.IO;
using OPCFModelDesign = Opc.Ua.ModelCompiler.ModelDesign;

namespace CAS.UA.Model.Designer.IO
{
  internal interface IProjectConfigurationManagement
  {
    UAModelDesignerProject UAModelDesignerProject { get; }
    OPCFModelDesign ModelDesign { get; }
    string Name { get; }

    void Build(TextWriter output);

    /// <summary>
    /// Saves the project at calculated effective path in relation to the default solution directory.
    /// </summary>
    /// <param name="defaultDirectory">The default solution location path.</param>
    /// <returns>Effective project location absolute path.</returns>
    string Save(string defaultDirectory);

    Func<OPCFModelDesign> GetModel { set; }
  }
}