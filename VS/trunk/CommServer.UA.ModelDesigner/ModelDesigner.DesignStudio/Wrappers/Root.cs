//<summary>
//  Title   : Top most representation of the model tree - get access to all branches in the tree.
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.IServerConfiguration;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Top most representation of the Information Model tree - allows access to all branches in the tree.
  /// </summary>
  internal static class Root
  {
    /// <summary>
    /// Gets or sets the library root.
    /// </summary>
    /// <value>The library root.</value>
    internal static Libraries LibraryRoot { get; set; } = new Libraries();
    /// <summary>
    /// Gets or sets the solution root.
    /// </summary>
    /// <value>The solution root.</value>
    internal static SolutionTreeNode SolutionRoot { get; set; }
    /// <summary>
    /// Finds the type starting form <see cref="Root.SolutionRoot"/> and if not succeeded tries <see cref="Root.LibraryRoot"/>.
    /// </summary>
    /// <param name="myType">My type.</param>
    /// <returns></returns>
    internal static ITypeDesign FindType( XmlQualifiedName myType )
    {
      ITypeDesign ret = SolutionRoot.FindType( myType );
      if ( ret != null )
        return ret;
      return LibraryRoot.FindType( myType );
    }
    /// <summary>
    /// Resets the information model and adds recursively all nodes to the address space from <see cref="Root.LibraryRoot"/> and next from <see cref="Root.SolutionRoot"/>.
    /// </summary>
    /// <param name="space">The address space.</param>
    internal static void ResetAndAddToAddressSpace(IAddressSpaceCreator space)
    {
      LibraryRoot.AddNode2AddressSpace( space );
      SolutionRoot.AddNode2AddressSpace( space );
    }
    /// <summary>
    /// Gets the instance configuration.
    /// </summary>
    /// <param name="nodeUniqueIdentifier">The node unique identifier.</param>
    /// <returns>IInstanceConfiguration.</returns>
    internal static IInstanceConfiguration GetInstanceConfiguration( INodeDescriptor nodeUniqueIdentifier )
    {
      return SolutionRoot.GetInstanceConfiguration( nodeUniqueIdentifier );
    }
  }
}
