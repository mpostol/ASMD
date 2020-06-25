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

    private static readonly UniqueNameGenerator m_UniqueNameGenerator = new UniqueNameGenerator(Properties.Resources.DefaultSolutionName);
    private static SolutionConfigurationManagementRoot m_This;

    private void OnSolutionChanged(ISolutionConfigurationManagement solution)
    {
      CurrentConfiguration = solution;
      OnSolutionChanged();
    }

    #endregion private

    internal ISolutionConfigurationManagement CurrentConfiguration { get; private set; }

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

    internal static void OpenExisting(string solutionFileName, IGraphicalUserInterface gui)
    {
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 234587501, $"Opening an existing solution captured in the file {solutionFileName} of the {nameof(SolutionConfigurationManagement)}");
      if ((DefaultInstance.CurrentConfiguration != null) && !DefaultInstance.CurrentConfiguration.TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued())
        return;
      Tuple<UAModelDesignerSolution, string> _solution = null;
      bool _ChangesArePresent = false;
      try
      {
        if (String.IsNullOrEmpty(solutionFileName) || !File.Exists(solutionFileName))
        {
          if (DefaultInstance.CurrentConfiguration != null)
          {
            _solution = SolutionConfigurationManagement.ReadConfiguration(gui, SolutionConfigurationManagement.SetupFileDialog);
            if (_solution == null)
              return;
          }
          else
          {
            string _defPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UAModelDesignerSolution");
            _solution = new Tuple<UAModelDesignerSolution, string>(UAModelDesignerSolution.CreateEmptyModel(m_UniqueNameGenerator.GenerateNewName()), _defPath);
            _ChangesArePresent = true;
          }
        }
        else
        {
          solutionFileName = Path.GetFullPath(solutionFileName);
          _solution = new Tuple<UAModelDesignerSolution, string>(SolutionConfigurationManagement.ReadConfiguration(solutionFileName, gui), solutionFileName);
        }
        if (_solution.Item1.ServerDetails == null)
          _solution.Item1.ServerDetails = UAModelDesignerSolutionServerDetails.CreateEmptyInstance();
        ISolutionConfigurationManagement _newSolution = new SolutionConfigurationManagement(_solution, _ChangesArePresent, gui);
        DefaultInstance.OnSolutionChanged(_newSolution);
        return;
      }
      catch (Exception ex)
      {
        string _tmp = "Cannot initialize {0} described by {1} because of exception: {2}.";
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Critical, 234587502, string.Format(_tmp, typeof(SolutionConfigurationManagement).FullName, _solution.Item2, ex.Message));
        throw;
      }
    }

    internal static void NewSoliution(IGraphicalUserInterface gui)
    {
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 234587504, $"New instance of the {nameof(SolutionConfigurationManagement)} is required");
      if ((DefaultInstance.CurrentConfiguration != null) && (!DefaultInstance.CurrentConfiguration.TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued()))
        return;
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 234587503, $"Creating new instance of the {nameof(SolutionConfigurationManagement)}");
      string _defPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UAModelDesignerSolution");
      SolutionConfigurationManagement _newSolution = new SolutionConfigurationManagement(new Tuple<UAModelDesignerSolution, string>(UAModelDesignerSolution.CreateEmptyModel(m_UniqueNameGenerator.GenerateNewName()), _defPath), true, gui);
      DefaultInstance.OnSolutionChanged(_newSolution);
      return;
    }
  }
}