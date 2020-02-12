//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

namespace UAOOI.Windows.GUIAbstractions
{

  /// <summary>
  /// This interface is used by internal component to inform parent window that it is possible to enable accept button.
  /// </summary>
  [System.Obsolete("Replace it by ICommand")]
  public interface ICanBeAccepted
  {
    /// <summary>
    /// It sets the information if accept button in the parent dialog window can be accepted
    /// </summary>
    /// <param name="pOKState">true if it could be accepted</param>
    void CanBeAccepted( bool pOKState );

  }
}
