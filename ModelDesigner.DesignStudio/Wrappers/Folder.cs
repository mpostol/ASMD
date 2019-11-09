//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// Folder tree node
  /// </summary>
  internal abstract class Folder: WrapperTreeNode
  {

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
