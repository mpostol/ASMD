//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.Lib.CodeProtect;
using CAS.UA.Model.Designer.Properties;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Security.Permissions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using ModelsContainer = CAS.CommServer.UA.ConfigurationEditor.ModelsContainer;

namespace CAS.UA.Model.Designer
{

  /// <summary>
  /// Class Program.
  /// </summary>
  internal static class Program
  {

    #region API
    /// <summary>
    /// Program entry point.
    /// </summary>
    [STAThreadAttribute()]
    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
    private static void Main()
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
            MessageBoxShow(string.Format(Resources.InstalationOfExampleSolutionException, ex.Message));
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
        SetupExceptionHandlers();
        if (installationWasPerformed || args == null || args.Length < 2 || string.IsNullOrEmpty(args[1]))
          m_ApplicationEntryForm = new MainForm(installationWasPerformed);
        else
          m_ApplicationEntryForm = new MainForm(args[1]); //args[ 0 ] - is application file name , args[ 1 ] - is first argument 
        Application.Run(m_ApplicationEntryForm);
        Settings.Default.Save();
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 40, "Application finished");
      }
      catch (Exception ex)
      {
        MessageBoxShow(string.Format(Resources.MainForm_StartupExceptionMessage, ex.Message));
      }
      finally
      {
        AssemblyTraceEvent.Tracer.Flush();
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
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 113, "Installed the License without errors");
      }
      catch (Exception ex)
      {
        MessageBoxShow(string.Format(Resources.MainProgram_LicenseInstalation_Failure, ex.Message));
      }
    }
    internal static Func<string, DialogResult> MessageBoxShow { get; set; } = (x) =>
                                                                                 {
                                                                                   AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Error, 2085089167, x);
                                                                                   return MessageBox.Show(x, "Execution Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                                                                                 };
    #endregion

    #region private
    private static readonly string m_InstallLicenseString = "installic";
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
    public static void SetupExceptionHandlers()
    {
      // Add the event handler for handling UI thread exceptions to the event.
      Application.ThreadException += new ThreadExceptionEventHandler(Form1_UIThreadException);
      // Set the unhandled exception mode to force all Windows Forms errors to go through our handler.
      Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
      // Add the event handler for handling non-UI thread exceptions to the event. 
      AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
    }
    /// <summary>
    /// Handle the UI exceptions by showing a dialog box, and asking the user whether or not they wish to abort execution.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="t">The <see cref="ThreadExceptionEventArgs"/> instance containing the event data.</param>
    private static void Form1_UIThreadException(object sender, ThreadExceptionEventArgs t)
    {
      DialogResult _result = DialogResult.Cancel;
      try
      {
        _result = ShowThreadExceptionDialog(t.Exception);
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Error, 111680094, $"In UI exception handling procedure user selected {_result}");
      }
      catch (Exception _ex)
      {
        try
        {
          AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Critical, -695035256, $"Application exits in the Form1_UIThreadException after next error: {_ex.Message}");
        }
        finally
        {
          Application.Exit();
        }
      }
      if (_result == DialogResult.Abort)
      {
        AssemblyTraceEvent.Tracer.TraceInformation("Exits the program when the user clicks Abort");
        Application.Exit();
      }
    }
    /// <summary>
    /// Handle the UI exceptions by showing a dialog box, and asking the user whether or not they wish to abort execution.
    /// </summary>
    /// <remarks>
    /// NOTE: This exception cannot be kept from terminating the application - it can only log the event, and inform the user about it.
    /// </remarks>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="UnhandledExceptionEventArgs"/> instance containing the event data.</param>
    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
      try
      {
        Exception ex = (Exception)e.ExceptionObject;
        string errorMsg = "An application error occurred. Please contact the administrator with the following information:\n\n";
        // Since we can't prevent the app from terminating, log this to the event log.
        if (!EventLog.SourceExists("ThreadException"))
        {
          EventLog.CreateEventSource("ThreadException", "Application");
        }
        // Create an EventLog instance and assign its source.
        EventLog myLog = new EventLog
        {
          Source = "ThreadException"
        };
        myLog.WriteEntry(errorMsg + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
      }
      catch (Exception exc)
      {
        try
        {
          MessageBox.Show("Fatal Non-UI Error", "Fatal Non-UI Error. Could not write the error to the event log. Reason: " + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        finally
        {
          Application.Exit();
        }
      }
    }
    /// <summary>
    /// Creates the error message and displays it.
    /// </summary>
    /// <param name="title">The title.</param>
    /// <param name="e">The e.</param>
    /// <returns>DialogResult.</returns>
    private static DialogResult ShowThreadExceptionDialog(Exception e)
    {
      string errorMsg = "An application error occurred. Please contact the administrator with the following information:\n\n";
      errorMsg = errorMsg + e.Message + "\n\nStack Trace:\n" + e.StackTrace;
      return MessageBoxShow(errorMsg);
    }
    #endregion

  }
}
