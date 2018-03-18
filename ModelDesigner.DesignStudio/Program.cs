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

using CAS.Lib.CodeProtect;
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

    #region API
    /// <summary>
    /// Program entry point.
    /// </summary>
    [STAThreadAttribute()]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      string _commandLine = string.Empty;
      try
      {
        bool installationWasPerformed = false;
        _commandLine = Environment.CommandLine.ToLower();
        if (IsFirstRun() || _commandLine.Contains("installsample"))
        {
          installationWasPerformed = true;
          try
          {
            ModelsContainer.ContainerResources.ExampleSolutionInstallation(Settings.Default.SampleInstallationDirectory, (x, y) => AssemblyTraceEvent.Tracer.TraceEvent(y, 49, x));
            AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 50, "Example solution installation completed");
          }
          catch (Exception ex)
          {
            MessageBoxShow(String.Format(Resources.InstalationOfExampleSolutionException, ex.Message));
          }
          // license installation 
          try
          {
            DoInstallLicense(true);
          }
          catch (Exception ex)
          {
            string _message = "License installation has failed, reason: " + ex.Message;
            MessageBoxShow(_message);
          }
          finally
          {
            AssemblyTraceEvent.Tracer.Flush();
          }
        }
        else if (_commandLine.Contains(m_InstallLicenseString))
        {
          try
          {
            DoInstallLicense(true);
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
        ComposeApplication();
        if (installationWasPerformed || args == null || args.Length < 2 || string.IsNullOrEmpty(args[1]))
          m_ApplicationEntryForm = new MainForm(installationWasPerformed);
        else
          m_ApplicationEntryForm = new MainForm(args[1]); //args[ 0 ] - is application file name , args[ 1 ] - is first argument 
        DoApplicationRun(Application.Run);
        Settings.Default.Save();
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 40, "Application finished");
      }
      catch (Exception ex)
      {
        MessageBoxShow(String.Format(Resources.MainForm_StartupExceptionMessage, ex.Message));
      }
    }
    private static void ComposeApplication()
    {
      Wrappers.ViewModelFactory.Factory = new Wrappers4ProperyGrid.ViewModelFactory();
    }
    internal static void DoInstallLicense(bool loadLicenseFromDefaultContainer)
    {
      try
      {
        LibInstaller.InstallLicense(loadLicenseFromDefaultContainer);
        AssemblyTraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 113, "Installed the License without errors");
      }
      catch (Exception ex)
      {
        MessageBoxShow(string.Format(Resources.MainProgram_LicenseInstalation_Failure, ex.Message));
      }
    }
    internal static void DoApplicationRun(Action<Form> applicationRun)
    {
      applicationRun(m_ApplicationEntryForm);
    }
    internal static Func<string, DialogResult> MessageBoxShow { get { return m_MessageBoxShow; } set { m_MessageBoxShow = value; } }
    #endregion

    #region private
    private static Func<string, DialogResult> m_MessageBoxShow = (x) =>
    {
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Error, 108, x);
      return MessageBox.Show(x, "Excution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    };
    private readonly static string m_InstallLicenseString = "installic";
    private static Form m_ApplicationEntryForm;
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
