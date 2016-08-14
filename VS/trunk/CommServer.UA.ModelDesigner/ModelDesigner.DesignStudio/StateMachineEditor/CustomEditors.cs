using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAS.UA.Model.Designer.StateMachineEditor
{
  [System.ComponentModel.LicenseProvider( typeof( CAS.Lib.CodeProtect.CodeProtectLP ) )]
  [System.Runtime.InteropServices.GuidAttribute( "3713DDE1-B759-4b5c-BBD0-5B1E8422FA61" )]
  internal sealed class CustomEditors: StartUpSplashScreen.LogedIsLicensed<CustomEditors> 
  { 
        #region public
    internal static bool IsLicensed { get; private set; }
    internal static void CheckConstrain()
    {
      if ( m_Checked )
        return;
      CustomEditors sc = new CustomEditors();
      IsLicensed = sc.Licensed;
      m_Checked = true;
    }
    #endregion

    #region private
    private CustomEditors()
    {
      IsLicensed = this.Licensed;
    }
    static CustomEditors()
    {
      CheckConstrain();
    }
    private static bool m_Checked = false;
    #endregion

  }
}
