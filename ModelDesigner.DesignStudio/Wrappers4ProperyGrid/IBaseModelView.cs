//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System;

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  /// <summary>
  /// Class TextEventArgs.
  /// Implements the <see cref="EventArgs" />
  /// </summary>
  /// <seealso cref="EventArgs" />
  internal class TextEventArgs : EventArgs
  {
    public readonly IBaseViewModel Node;

    public TextEventArgs(IBaseViewModel node)
    {
      Node = node;
    }
  }

  /// <summary>
  /// Class ProjectEventArgs.
  /// Implements the <see cref="EventArgs" />
  /// </summary>
  /// <seealso cref="EventArgs" />
  internal class ProjectEventArgs : EventArgs { }

  internal interface IBaseViewModel
  {
    event EventHandler<TextEventArgs> TextChanged;

    event EventHandler<ProjectEventArgs> SubtreeChanged;

    string Text { get; set; }
    string ToolTipText { get; set; }
  }
}