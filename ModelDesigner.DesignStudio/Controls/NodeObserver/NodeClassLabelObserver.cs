//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Wrappers;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  /// <summary>
  /// Observer for label with OPC UA node class name
  /// </summary>
  internal partial class NodeClassLabelObserver : SelectedItemObserver
  {
    public NodeClassLabelObserver()
    {
      InitializeComponent();
    }

    #region SelectedItemObserver

    protected override void AfterSolutionChange(object sender, SolutionConfigurationManagementRoot.AfterSolutionChangeEventArgs e)
    {
    }

    protected override void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
      IModelNode imodelNode = e.SelectedIModelNode;
      if (imodelNode != null)
      {
        m_label.Text = imodelNode.NodeClass != NodeClassesEnum.None ? imodelNode.NodeClass.ToString() : "";
      }
      else
      {
        m_label.Text = "";
      }
    }

    #endregion SelectedItemObserver
  }

  /// <summary>
  /// Observer for label with OPC UA node class name
  /// Note: this observer can be placed on toolstrip
  /// </summary>
  [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)]
  internal class ToolStripNodeClassLabelOberver : ToolStripControlHost
  {
    public ToolStripNodeClassLabelOberver()
      : base(new NodeClassLabelObserver())
    { }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public NodeClassLabelObserver MyNodeClassLabelOberver => (NodeClassLabelObserver)this.Control;
  }
}