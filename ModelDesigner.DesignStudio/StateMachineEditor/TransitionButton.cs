//<summary>
//  Title   : Button with transition information 
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

using System.Windows.Forms;

namespace CAS.UA.Model.Designer.StateMachineEditor
{
  internal partial class TransitionButton: Button
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="TransitionButton"/> class.
    /// </summary>
    internal TransitionButton()
    {
      this.Width = 30;
      this.Height = 30;
      InitializeComponent();
    }
  }
}
