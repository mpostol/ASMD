//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;
using System;
using System.Windows.Forms;
using UAOOI.ASMD.GUIAbstractions;

namespace CAS.UA.Model.Designer.Controls
{
  internal partial class AddNode : UserControl
  {
    internal AddNode(ICanBeAccepted parent, INodeFactory[] list) : this()
    {
      m_listBox.Items.AddRange(list);
      m_Parent = parent;
    }
    private AddNode()
    {
      InitializeComponent();
    }
    public WrapperTreeNode Node
    {
      get
      {
        INodeFactory factory = m_listBox.SelectedItem as INodeFactory;
        if (factory == null)
          return null;
        return factory.Node;
      }
    }
    private ICanBeAccepted m_Parent;
    private void m_listBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      m_Parent.CanBeAccepted(m_listBox.SelectedItem != null);
    }
  }
}
