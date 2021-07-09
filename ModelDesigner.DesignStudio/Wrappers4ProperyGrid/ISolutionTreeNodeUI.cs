//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.CommServer.UA.ModelDesigner.Configuration.IO;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  internal interface ISolutionModelView : IBaseViewModel
  {
    /// <summary>
    /// Gets the home directory.
    /// </summary>
    /// <value>The home directory.</value>
    ISolutionDirectoryPathManagement HomeDirectory { get; }

    /// <summary>
    /// Gets the UI to select a server plug-in.
    /// </summary>
    /// <value>An instance of <see cref="ServerSelector"/> used by a software user to select a server plug-in.</value>
    ServerSelector Server { get; }
  }
}