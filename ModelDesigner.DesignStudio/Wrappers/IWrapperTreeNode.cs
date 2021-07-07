//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// This interface provides description of the node to be used by the main program to expose it in the user interface.
  /// </summary>
  internal interface IWrapperTreeNode : IModelNode
  {
    /// <summary>
    /// Gets the instance of the model node. Model node represents the location of the node in the model hierarchy.
    /// </summary>
    /// <value>An instance of class inherited from <see cref="IModelNodeAdvance"/>.</value>
    IModelNodeAdvance IModelNodeAdvance { get; }
  }
}