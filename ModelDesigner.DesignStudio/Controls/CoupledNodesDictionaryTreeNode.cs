//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using System.Collections.Generic;
using System.Linq;

namespace CAS.UA.Model.Designer.Controls
{

  internal class CoupledNodesDictionaryTreeNode : DictionaryTreeNode
  {

    public CoupledNodesDictionaryTreeNode(IEnumerable<BaseDictionaryTreeNode> nodes)
    {
      Nodes.AddRange(nodes.ToArray<BaseDictionaryTreeNode>());
      this.Expand();
    }
    internal CoupledNodesDictionaryTreeNode()
    {
      this.Text = Resources.DictionaryTreeNode_CoupledNodes;
    }

    #region DictionaryTreeNode
    protected override void Unregister() { }
    #endregion
  }
}
