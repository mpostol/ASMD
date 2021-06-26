//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using UAOOI.Common.Infrastructure.Serializers;

namespace CAS.UA.Model.Designer.Solution
{
  /// <summary>
  /// Class UAModelDesignerSolution.
  /// </summary>
  public partial class UAModelDesignerSolution : INamespaces
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

    public IEnumerable<XmlQualifiedName> GetNamespaces()
    {
      return new List<XmlQualifiedName>();
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
    internal static UAModelDesignerProject CreateEmpty(string name)
    {
      return new UAModelDesignerProject()
      {
        buildOutputDirectoryNameField = Resources.Token_ProjectFileName,
        cSVFileNameField = Resources.DefaultCSVFileName,
        fileNameField = Path.ChangeExtension(Resources.Token_ProjectFileName, Resources.Project_FileDialogDefaultExt),
        nameField = name,
        ProjectIdentifier = Guid.NewGuid().ToString(),
      };
    }
  }
}