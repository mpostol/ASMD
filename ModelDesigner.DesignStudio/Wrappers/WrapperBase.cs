//<summary>
//  Title   : Wrapper base class - it is to be used as a base for all ModelDesign wrapped classes
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

using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Wrapper base class - it is to be used as a base for all ModelDesign wrapped classes
  /// </summary>
  /// <typeparam name="OPCType">The OPCType of the wrapped class</typeparam>
  internal abstract class WrapperBase<type, OPCType>: ValidableTreeNode
    where type: Wrappers4ProperyGrid.Design<OPCType>
    where OPCType: class, new()
  {
    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="WrapperBase&lt;OPCType&gt;"/> class.
    /// </summary>
    /// <param name="child">The child (wrapped) object .</param>
    public WrapperBase( type child )
      : base( child )
    {
      Wrapper.Parent = this;
      Validate();
    }
    #endregion

    #region IParent
    /// <summary>
    /// Gets the model designer node and initialize it with the data from the tree.
    /// </summary>
    /// <value>
    /// The model designer node derived from <see cref="Opc.Ua.ModelCompiler.NodeDesign"/>.
    /// </value>
    public override object ModelDesignerNode { get { return Wrapper.Update(); } }
    #endregion

    #region public
    internal new type Wrapper
    {
      get { return (type)base.Wrapper; }
    }
    #endregion

    #region private
    public override void MenuItemCopy_Action()
    {
      base.MenuItemCopy_Action();
      Clipboard.SetText( this.ModelDesignerNodeStringRepresentation );
    }
    protected string ModelDesignerNodeStringRepresentation
    {
      get
      {
        StringWriter sw = new System.IO.StringWriter();
        XmlSerializer serializer = new XmlSerializer( this.ModelDesignerNode.GetType() );
        serializer.Serialize( sw, this.ModelDesignerNode );
        return sw.ToString();
      }
    }
    protected new abstract class TreeNode<T>: ValidableTreeNode.TreeNode<T>
      where T: WrapperBase<type, OPCType>
    {
      public TreeNode( T parent )
        : base( parent )
      { }
      protected override void BeforeMenuStripOpening()
      {
        AddMenuItemDelete();
        AddMenuItemCopyPasteCut();
        base.BeforeMenuStripOpening();
      }
      /// <summary>
      /// Checks the type filter.
      /// </summary>
      /// <param name="AllTypes">if set to <c>true</c> display all nodes.</param>
      /// <param name="types">The types to display.</param>
      /// <returns></returns>
      protected override bool CheckTypeFilter( bool AllTypes, IEnumerable<NodeClassesEnum> types )
      {
        if ( AllTypes )
          return true;
        if ( this.Creator.NodeClass == NodeClassesEnum.None )
          return true;
        else
          foreach ( NodeClassesEnum type in types )
            if ( this.Creator.NodeClass == type )
              return true;
        return false;
      }
    }//TreeNode
    #endregion
  }
}
