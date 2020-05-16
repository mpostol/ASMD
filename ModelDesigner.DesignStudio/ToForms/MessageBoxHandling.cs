//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

namespace CAS.UA.Model.Designer.ToForms
{

  internal class MessageBoxHandling : IMessageBoxHandling
  {
    public void Show(string message)
    {
      System.Windows.Forms.MessageBox.Show(message);
    }
    public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
      return (DialogResult)System.Windows.Forms.MessageBox.Show(text, caption, (System.Windows.Forms.MessageBoxButtons)buttons, (System.Windows.Forms.MessageBoxIcon)icon);
    }
  }
}
