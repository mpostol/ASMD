//_______________________________________________________________
//  Title   : IBaseDirectoryProvider
//  System  : Microsoft VisualStudio 2013 / C#
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2016, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________


namespace CAS.CommServer.UA.ModelDesigner.Configuration
{
  /// <summary>
  /// Interface used to provide path to base directory used as a root of the configuration files.
  /// </summary>
  public interface IBaseDirectoryProvider
  {
    /// <summary>
    /// Gets the base directory.
    /// </summary>
    /// <returns>string with base directory</returns>
    string GetBaseDirectory();

  }
}
