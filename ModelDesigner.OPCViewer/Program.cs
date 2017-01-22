//_______________________________________________________________
//  Title   : Program - starting point for the application.
//  System  : Microsoft VisualStudio 2015 / C#
//  $LastChangedDate:  $
//  $Rev: $
//  $LastChangedBy: $
//  $URL: $
//  $Id:  $
//
//  Copyright (C) 2016, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

using CAS.Lib.CodeProtect;
using CAS.Lib.OPCClientControlsLib;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;

namespace CAS.CommServer.ModelDesigner.OPCViewer
{
  /// <summary>
  /// Class Program.
  /// </summary>
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Information, 43, $"Starting application {  Assembly.GetCallingAssembly().GetName().Name}");
#if DEBUG
      string m_cmmdLine = Environment.CommandLine;
      if (m_cmmdLine.ToLower().Contains("debugstop"))
        MessageBox.Show("Attach debug point");
      if (m_cmmdLine.ToLower().Contains(m_InstallingString))
      {
        try
        {
          LibInstaller.InstallLicense(false);
        }
        catch (Exception ex)
        {
          MessageBox.Show("License installation has failed, reason: " + ex.Message);
        }
      }
#endif
      try
      {
        SecurityPermission permission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
        if (!SecurityManager.IsGranted(permission))
        {
          string msg = "";
          msg += "This application requires permission to access unmanaged code ";
          msg += "in order to connect to COM-DA servers directly.\r\n\r\n";
          msg += "Connections to XML-DA servers will not be affected.";
          MessageBox.Show(msg, "CAS OPCViewer Data Access Client");
        }
        MainFormV2008 mainForm = mainForm = new MainFormV2008();
        Application.Run(mainForm);
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Information, 43, $"Finishing application {  Assembly.GetCallingAssembly().GetName().Name}");
      }
      catch (Exception e)
      {
        MessageBox.Show("An unexpected exception occurred. Application exiting.\r\n\r\n" + e.Message, "OPCViewer - Data Access Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private readonly static string m_InstallingString = "installic";

  }
}
