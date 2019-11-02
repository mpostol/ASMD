//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{

  internal class CoupledNodesDictionaryTreeNode : DictionaryTreeNode
  {
    internal override BaseDictionaryTreeNode CreateCopy()
    {
      return null;
    }
    /// <summary>
    /// Is called befores the menu strip opening to add all required menu items.
    /// </summary>
    protected override void BeforeMenuStripOpening()
    {
      base.BeforeMenuStripOpening();
    }
    protected override void Unregister() { }
    internal override void AddNodeToDictionary() { }
    internal CoupledNodesDictionaryTreeNode()
    {
      this.Text = Resources.DictionaryTreeNode_CoupledNodes;
    }
  }
}
