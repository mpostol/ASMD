//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Properties;
using UAOOI.Windows.Forms.CodeProtectControls;

namespace CAS.UA.Model.Designer
{
  internal class StartUpSplashScreen: SplashScreen
  {
    public StartUpSplashScreen()
      : base()
    {
      this.ShowSplashScreen = Settings.Default.ShowSplashScreen;
      this.MaintenancePeriodWarning = Settings.Default.MaintenancePeriodWarning;
      this.OnShowSplashScreenChanged += new System.EventHandler<BoolEventArg>( StartUpSplashScreen_OnShowSplashScreenChanged );
      this.OnMaintenancePeriodWarning += new System.EventHandler<BoolEventArg>( StartUpSplashScreen_OnMaintenancePeriodWarning );
    }
    private void StartUpSplashScreen_OnMaintenancePeriodWarning( object sender, SplashScreen.BoolEventArg e )
    {
      Settings.Default.MaintenancePeriodWarning = e.Value;
      Settings.Default.Save();
    }
    private void StartUpSplashScreen_OnShowSplashScreenChanged( object sender, SplashScreen.BoolEventArg e )
    {
      Settings.Default.ShowSplashScreen = e.Value;
      Settings.Default.Save();
    }
  }
}
