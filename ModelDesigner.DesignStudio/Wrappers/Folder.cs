//<summary>
//  Title   : Folder node
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

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Folder tree node
  /// </summary>
  internal abstract class Folder: WrapperTreeNode
  {
    #region private
    //protected abstract class FolderTreeNodeControl<T>: WrapperTreeNodeControl<T>
    //  where T: Folder
    //{
    //  public FolderTreeNodeControl( T parent )
    //    : base( parent )
    //  { }
    //}
    #endregion

    #region public
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.None; }// this is not UA node class
    }
    #endregion

    #region creator
    public Folder( string text, string toolStripTip )
      : base( null )
    {
      Text = text;
      ToolTipText = toolStripTip;
    }
    #endregion
  }
}
