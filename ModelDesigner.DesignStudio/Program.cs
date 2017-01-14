//<summary>
//  Title   : UA Model Designer
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Properties;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Web;
using System.Windows.Forms;
using ModelsContainer = CAS.CommServer.UA.ConfigurationEditor.ModelsContainer;

namespace CAS.UA.Model.Designer
{
  /// <summary>
  /// Class Program.
  /// </summary>
  static class Program
  {

    /// <summary>
    /// Mains the specified args.
    /// </summary>
    /// <param name="args">The args.</param>
    [STAThreadAttribute()]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      string _cmmdLine = string.Empty;
      try
      {
        bool installationWasPerformed = false;
        _cmmdLine = Environment.CommandLine.ToLower();
        if (IsFirstRun() || _cmmdLine.Contains("installsample"))
        {
          installationWasPerformed = true;
          try
          {
            ModelsContainer.ContainerResources.ExampleSolutionInstallation(Settings.Default.SampleInstallationDirectory, (x, y) => AssemblyTraceEvent.Tracer.TraceEvent(y, 49, x));
            AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 50, "Example solution installation completed");
          }
          catch (Exception ex)
          {
            string message = String.Format(Resources.InstalationOfExampleSolutionException, ex.Message);
            MessageBox.Show(message);
            AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Error, 59, message);
          }
          // license installation 
          try
          {
            Lib.CodeProtect.LibInstaller.InstallLicense(true);
            AssemblyTraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 65, "Installed the License");
          }
          catch (Exception ex)
          {
            string message = "License installation has failed, reason: " + ex.Message;
            AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Error, 70, message);
          }
          finally
          {
            AssemblyTraceEvent.Tracer.Flush();
          }
        }
        else if (_cmmdLine.ToLower().Contains("installic"))
        {
          try
          {
            CAS.Lib.CodeProtect.LibInstaller.InstallLicense(true);
            AssemblyTraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 82, "Installed the License");
            installationWasPerformed = true;
          }
          catch (Exception ex)
          {
            MessageBox.Show(
              string.Format(Resources.MainProgram_LicenseInstalation_Failure, ex.Message),
              Resources.MainProgram_LicenseInstalation_Failure_Caption,
              MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          finally
          {
            AssemblyTraceEvent.Tracer.Flush();
          }
        }
        string[] args = GetArguments();
        MainForm mainForm;
        if (installationWasPerformed || args == null || args.Length < 2 || string.IsNullOrEmpty(args[1]))
          mainForm = new MainForm(installationWasPerformed);
        else
          mainForm = new MainForm(args[1]); //args[ 0 ] - is application file name , args[ 1 ] - is first argument 
        Application.Run(mainForm);
        Settings.Default.Save();
      }
      catch (Exception ex)
      {
        MessageBox.Show(String.Format(Resources.MainForm_StartupExceptionMessage, ex.Message), "Command line error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    #region private
    private static string[] GetArguments()
    {
      try
      {
        if (ApplicationDeployment.IsNetworkDeployed && ApplicationDeployment.CurrentDeployment.ActivationUri != null)
        {
          //ClickOnce deployment
          string query = HttpUtility.UrlDecode(ApplicationDeployment.CurrentDeployment.ActivationUri.Query);
          if (!string.IsNullOrEmpty(query) && query.StartsWith("?"))
          {
            string[] arguments = query.Substring(1).Split(' ');
            string[] commandLineArgs = new string[arguments.Length + 1];
            commandLineArgs[0] = Environment.GetCommandLineArgs()[0];
            arguments.CopyTo(commandLineArgs, 1);
            return commandLineArgs;
          }
        }

      }
      catch (DeploymentException) { }
      if (AppDomain.CurrentDomain.SetupInformation != null &&
          AppDomain.CurrentDomain.SetupInformation.ActivationArguments != null &&
          AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData != null)
      {
        //MSInstaller
        string[] arguments = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;
        string[] commandLineArgs = new string[arguments.Length + 1];
        commandLineArgs[0] = Environment.GetCommandLineArgs()[0];
        arguments.CopyTo(commandLineArgs, 1);
        return commandLineArgs;
      }
      //Command line execution.
      return Environment.GetCommandLineArgs();
    }
    private static bool IsFirstRun()
    {
      try
      {
        return ApplicationDeployment.IsNetworkDeployed && ApplicationDeployment.CurrentDeployment.IsFirstRun;
      }
      catch (DeploymentException)
      {
        return false;
      }
    }
    #endregion

  }
}
