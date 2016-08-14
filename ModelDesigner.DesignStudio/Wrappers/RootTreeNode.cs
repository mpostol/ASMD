//<summary>
//  Title   : Root TreeNode
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Base class for valitable classes that do not represent Address Space node classes.
  /// </summary>
  internal abstract class RootTreeNode: BaseTreeNode
  {
    #region creator
    public RootTreeNode( string NodeName )
      : base( NodeName )
    { }
    #endregion
    
    #region private
    protected new abstract class TreeNode<T>: BaseTreeNode.TreeNode<T>
      where T: RootTreeNode
    {

      #region creator
      public TreeNode( T parent )
        : base( parent )
      { }
      #endregion

    }
    #endregion
  }
}
