//_______________________________________________________________
//  Title   : UAModelDesignerSolution
//  System  : Microsoft VisualStudio 2015 / C#
//  $LastChangedDate:  $
//  $Rev: $
//  $LastChangedBy: $
//  $URL: $
//  $Id:  $
//
//  Copyright (C) 2017, CAS LODZ POLAND.
//  TEL: +48 608 61 98 99 
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________


using CAS.UA.Model.Designer.Properties;

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
        ServerDetails = new UAModelDesignerSolutionServerDetails() { codebase = string.Empty, configuration = string.Empty }
      };

    }
  }
}
