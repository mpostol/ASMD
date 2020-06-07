//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal abstract class ValidableTreeNode : WrapperTreeNode, IParent
  {
    #region IParent Members

    /// <summary>
    /// Validates this instance.
    /// </summary>
    public virtual void Validate()
    {
      bool error = false;
      ToolTipText = NodeTip();
      if (String.IsNullOrEmpty(NodeName()))
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

    #endregion IParent Members

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

    #endregion private

    #region constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ValidableTreeNode"/> class.
    /// </summary>
    /// <param name="wrapper">The instance that will be used as a wrapper to provide user interface.</param>
    public ValidableTreeNode(object wrapper) : base(wrapper) { }

    #endregion constructors
  }
}