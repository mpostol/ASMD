//<summary>
//  Title   : Start Up Splash Screen
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2010, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Properties;
using CAS.Windows.Forms.CodeProtectControls;

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
