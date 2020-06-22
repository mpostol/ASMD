//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.Solution;
using System;
using System.Diagnostics;
using System.IO;

namespace CAS.UA.Model.Designer.IO
{
  internal class SolutionConfigurationManagementRoot
  {
    #region private

    private static SolutionConfigurationManagementRoot m_This;
    private ISolutionConfigurationManagement CurrentConfiguration { get; set; }

    private void OnSolutionChanged(ISolutionConfigurationManagement solution)
    {
      CurrentConfiguration = solution;
      OnSolutionChanged();
    }

    #endregion private

    internal class AfterSolutionChangeEventArgs : EventArgs
    {
      public ISolutionConfigurationManagement Solution { get; private set; }

      public AfterSolutionChangeEventArgs(ISolutionConfigurationManagement solution)
      {
        Solution = solution;
      }
    }

    internal void OnSolutionChanged()
    {
      AfterSolutionChange?.Invoke(this, new AfterSolutionChangeEventArgs(CurrentConfiguration));
    }

    internal event EventHandler<AfterSolutionChangeEventArgs> AfterSolutionChange;

    internal static SolutionConfigurationManagementRoot DefaultInstance
    {
      get
      {
        if (m_This == null)
          m_This = new SolutionConfigurationManagementRoot();
        return m_This;
      }
    }

    internal static ISolutionConfigurationManagement OpenExisting(string solutionFileName, IGraphicalUserInterface gui)
    {
      if (String.IsNullOrEmpty(solutionFileName))
        return NewSoliution(gui);
      if (!File.Exists(solutionFileName))
        return OpenExisting(gui);
      Tuple<UAModelDesignerSolution, string> _solution = null;
      if (File.Exists(solutionFileName))
        _solution = new Tuple<UAModelDesignerSolution, string>(SolutionConfigurationManagement.ReadConfiguration(solutionFileName, gui), solutionFileName);
      else
      {
        _solution = SolutionConfigurationManagement.ReadConfiguration(gui, SolutionConfigurationManagement.SetupFileDialog);
        if (_solution == null)
          return null;
      }
      UAModelDesignerSolutionServerDetails _ServerDetails = _solution.Item1.ServerDetails ?? UAModelDesignerSolutionServerDetails.CreateEmptyInstance();
      try
      {
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 234587501, "Opening an existing instance of the OPCFSolutionConfigurationManagement");
        SolutionConfigurationManagement _newSolution = new SolutionConfigurationManagement(_solution, gui);
        DefaultInstance.OnSolutionChanged(_newSolution);
        return _newSolution;
      }
      catch (Exception ex)
      {
        string _tmp = "Cannot initialize {0} described by {1} because of exception: {2}.";
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Critical, 234587502, string.Format(_tmp, typeof(SolutionConfigurationManagement).FullName, _solution.Item2, ex.Message));
        throw;
      }
    }

    internal static ISolutionConfigurationManagement OpenExisting(IGraphicalUserInterface gui)
    {
      Tuple<UAModelDesignerSolution, string> _solution = SolutionConfigurationManagement.ReadConfiguration(gui, SolutionConfigurationManagement.SetupFileDialog);
      if (_solution == null)
        return null;
      UAModelDesignerSolutionServerDetails _ServerDetails = _solution.Item1.ServerDetails ?? UAModelDesignerSolutionServerDetails.CreateEmptyInstance();
      try
      {
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 234587501, "Opening an existing instance of the OPCFSolutionConfigurationManagement");
        SolutionConfigurationManagement _newSolution = new SolutionConfigurationManagement(_solution, gui);
        DefaultInstance.OnSolutionChanged(_newSolution);
        return _newSolution;
      }
      catch (Exception ex)
      {
        string _tmp = "Cannot initialize {0} described by {1} because of exception: {2}.";
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Critical, 234587502, string.Format(_tmp, typeof(SolutionConfigurationManagement).FullName, _solution.Item2, ex.Message));
        throw;
      }
    }

    internal static ISolutionConfigurationManagement NewSoliution(IGraphicalUserInterface gui)
    {
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 234587503, "Creating new instance of the OPCFSolutionConfigurationManagement");
      string _defPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UAModelDesignerSolution");
      SolutionConfigurationManagement _newSolution = new SolutionConfigurationManagement(new Tuple<UAModelDesignerSolution, string>(UAModelDesignerSolution.CreateEmptyModel(), _defPath), gui);
      DefaultInstance.OnSolutionChanged(_newSolution);
      return _newSolution;
    }
  }
}