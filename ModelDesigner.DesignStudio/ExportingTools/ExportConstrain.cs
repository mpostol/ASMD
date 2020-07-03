//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

namespace CAS.UA.Model.Designer.ExportingTools
{
  //TODO Remove limitation related to CAS licensing programs #53
  [System.ComponentModel.LicenseProvider(typeof(CAS.Lib.CodeProtect.CodeProtectLP))]
  [System.Runtime.InteropServices.GuidAttribute("6D0A7A45-9ADC-456e-A1EA-C0F926E3C96C")]
  internal sealed class ExportConstrain : StartUpSplashScreen.LogedIsLicensed<ExportConstrain>
  {
    #region public

    internal static bool IsLicensed { get; private set; }

    internal static void CheckConstrain()
    {
      if (m_Checked)
        return;
      ExportConstrain sc = new ExportConstrain();
      IsLicensed = sc.Licensed;
      m_Checked = true;
    }

    #endregion public

    #region private

    private ExportConstrain()
    {
      IsLicensed = this.Licensed;
    }

    static ExportConstrain()
    {
      CheckConstrain();
    }

    private static bool m_Checked = false;

    #endregion private
  }
}