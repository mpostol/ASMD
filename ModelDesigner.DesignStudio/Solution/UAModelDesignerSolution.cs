//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace CAS.UA.Model.Designer.Solution
{
  /// <summary>
  /// Class UAModelDesignerSolution.
  /// </summary>
  public partial class UAModelDesignerSolution
  {
    /// <summary>
    /// Creates an empty solution model.
    /// </summary>
    /// <returns>UAModelDesignerSolution.</returns>
    internal static UAModelDesignerSolution CreateEmptyModel(string solutionName)
    {
      return new UAModelDesignerSolution()
      {
        Name = solutionName,
        Projects = new UAModelDesignerProject[] { },
        ServerDetails = UAModelDesignerSolutionServerDetails.CreateEmptyInstance()
      };
    }

    [OnDeserialized()]
    public void OnDeserialized(StreamingContext context)
    {
      ServerDetails = ServerDetails ?? UAModelDesignerSolutionServerDetails.CreateEmptyInstance();
    }
  }

  /// <summary>
  /// Class UAModelDesignerSolutionServerDetails - encapsulates details about the associated server configuration
  /// </summary>
  public partial class UAModelDesignerSolutionServerDetails
  {
    internal static UAModelDesignerSolutionServerDetails CreateEmptyInstance()
    {
      return new UAModelDesignerSolutionServerDetails() { codebase = string.Empty, configuration = string.Empty };
    }
  }
  public partial class UAModelDesignerProject
  {
    internal static UAModelDesignerProject CreateEmpty(string solutionBaseDirectory, string name)
    {
      return new UAModelDesignerProject()
      {
        buildOutputDirectoryNameField = Path.Combine(solutionBaseDirectory, name),
        cSVFileNameField = Resources.DefaultCSVFileName,
        fileNameField = Path.ChangeExtension(name, "xml"),
        nameField = name,
        ProjectIdentifier = Guid.NewGuid().ToString(),
      };
    }
  }
}