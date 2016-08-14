//<summary>
//  Title   : AddressSpaceService
//  System  : Microsoft VisualStudio 2013 / C#
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2014, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Wrappers.AddressSpaceDictionary;
using System;

namespace CAS.UA.Model.Designer
{
  /// <summary>
  /// Class AddressSpaceService - Entry point to create address space and using <paramref name="getNodesFromModel"/> populate it.
  /// </summary>
  /// <remarks>It is used to decouple name spaces from each other.</remarks>
  internal abstract class AddressSpaceService
  {
    #region public static
    /// <summary>
    /// Creates the instance of the address space.
    /// </summary>
    /// <param name="getNodesFromModel">An action called to get nodes from the information model.</param>
    /// <param name="traceEvent">An action to trace the compilation errors.</param>
    /// <returns>AddressSpace.</returns>
    internal static IElement[] CreateInstance(Action<IAddressSpaceCreator> getNodesFromModel, Action<string> traceEvent)
    {
      AddressSpaceCompiler _instance = new AddressSpaceCompiler();
      return _instance.InternalCreateInstance(getNodesFromModel, traceEvent);
    }
    #endregion

    #region private
    protected AddressSpaceService() { }
    protected abstract IElement[] InternalCreateInstance(Action<IAddressSpaceCreator> getNodesFromModel, Action<string> traceEvent);
    #endregion

  }
}
