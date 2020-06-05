//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using System.Runtime.Serialization;

namespace CAS.UA.Model.Designer.Solution
{
  /// <summary>
  /// Class UAModelDesignerSolution.
  /// </summary>
  public partial class UAModelDesignerSolution
  {
    /// <summary>
    /// Creates the empty model.
    /// </summary>
    /// <returns>UAModelDesignerSolution.</returns>
    internal static UAModelDesignerSolution CreateEmptyModel()
    {
      return new UAModelDesignerSolution()
      {
        Name = Resources.DefaultSolutionName,
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
}