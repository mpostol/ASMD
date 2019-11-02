//<summary>
//  Title   : Validable Tree Node
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

using CAS.UA.Model.Designer.Controls;
using System;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal abstract class ValidableTreeNode: WrapperTreeNode, IParent
  {
    #region IParent Members
    /// <summary>
    /// Validates this instance.
    /// </summary>
    public virtual void Validate()
    {
      bool error = false;
      ToolTipText = NodeTip();
      if ( String.IsNullOrEmpty( NodeName() ) )
      {
        Text = "< name not set>";
        error |= true;
        ToolTipText += " Error: node name cannot be empty";
      }
      else
        Text = NodeName();
    }
    /// <summary>
    /// Gets the model designer node and initialize it with the data from the tree.
    /// </summary>
    /// <value>
    /// The model designer node derived from <see cref="Opc.Ua.ModelCompiler.NodeDesign"/>.
    /// </value>
    public abstract object ModelDesignerNode { get; }

    #endregion

    #region private
    protected abstract string NodeName();
    protected abstract string NodeTip();
    //protected abstract class ValidableTreeNodeControl<T>: WrapperTreeNodeControl<T>, IValidate
    //    where T: ValidableTreeNode
    //{
    //  #region creator
    //  public ValidableTreeNodeControl( T parent )
    //    : base( parent )
    //  { }
    //  #endregion

    //  #region IValidate Members
    //  public void Validate()
    //  {
    //    ModelEntity.Validate();
    //    if ( this.TreeView != null )
    //      this.TreeView.RebuildDictionary();
    //  }
    //  #endregion
    //}
    #endregion

    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidableTreeNode"/> class.
    /// </summary>
    /// <param name="wrapper">The instance that will be used as a wrapper to provide user interface.</param>
    public ValidableTreeNode( object wrapper )
      : base( wrapper )
    { }
    #endregion creators

  }
}
