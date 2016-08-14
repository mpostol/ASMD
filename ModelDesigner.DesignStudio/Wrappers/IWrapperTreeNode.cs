//<summary>
//  Title   : interface that returns child in wrapper tree node
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  20090106: mzbrzezny created
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// This interface provides description of the node to be used by the main program to expose it in the user interface.
  /// </summary>
  internal interface IWrapperTreeNode: IModelNode
  {

    /// <summary>
    /// Gets the instance of the model node. Model node represents the location of the node in the model hierarchy.
    /// </summary>
    /// <value>An instance of class inherited from <see cref="IModelNodeAdvance"/>.</value>
    IModelNodeAdvance IModelNodeAdvance { get; }

  }
}
