//<summary>
//  Title   : Observer for label with OPC UA node class name
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Wrappers;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  /// <summary>
  /// Observer for label with OPC UA node class name
  /// </summary>
  internal partial class NodeClassLabelObserver: SelectedItemObserver
  {
    public NodeClassLabelObserver()
    {
      InitializeComponent();
    }
    #region protected
    protected override void OnSelectedItemIsChanged( object sender, SelectedItemEventArgs e )
    {
      IModelNode imodelNode = e.SelectedIModelNode;
      if ( imodelNode != null )
      {
        m_label.Text = imodelNode.NodeClass != NodeClassesEnum.None ? imodelNode.NodeClass.ToString() : "";
      }
      else
      {
        m_label.Text = "";
      }
    }
    #endregion protected
  }
  /// <summary>
  /// Observer for label with OPC UA node class name
  /// Note: this observer can be placed on toolstrip
  /// </summary>
  [ToolStripItemDesignerAvailability( ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip )]
  internal class ToolStripNodeClassLabelOberver: ToolStripControlHost
  {
    public ToolStripNodeClassLabelOberver()
      : base( new NodeClassLabelObserver() )
    {}
    [DesignerSerializationVisibility( DesignerSerializationVisibility.Content )]
    public NodeClassLabelObserver MyNodeClassLabelOberver
    {
      get { return (NodeClassLabelObserver)this.Control; }
    }
  }
}
