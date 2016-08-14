//<summary>
//  Title   : Save Constrain 
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

using System.Diagnostics;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Check save constrain class. The license is checked only once while using any of the public members.
  /// </summary>
  [System.ComponentModel.LicenseProvider( typeof( CAS.Lib.CodeProtect.CodeProtectLP ) )]
  [System.Runtime.InteropServices.GuidAttribute( "2601698A-593A-40f0-AFCC-4C205A67A3C3" )]
  internal sealed class SaveConstrain: StartUpSplashScreen.LogedIsLicensed<SaveConstrain>
  {
    #region public
    internal static bool IsLicensed { get; private set; }
    internal static void CheckConstrain()
    {
      if ( m_Checked )
        return;
      TraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 144, "Checking Constrain SaveConstrain.");
      SaveConstrain sc = new SaveConstrain();
      IsLicensed = sc.Licensed;
      m_Checked = true;
    }
    #endregion

    #region private
    private SaveConstrain()
    {
      IsLicensed = this.Licensed;
    }
    static SaveConstrain()
    {
      CheckConstrain();
    }
    private static bool m_Checked = false;
    #endregion

  }
}
