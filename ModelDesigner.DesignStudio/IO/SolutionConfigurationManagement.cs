//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Solution;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UAOOI.SemanticData.UANodeSetValidation;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Singleton class to save and restore solution configuration to/from external file.
  /// </summary>
  internal sealed class SolutionConfigurationManagement : TypeGenericConfigurationManagement<UAModelDesignerSolution>, ISolutionConfigurationManagement
  {
    #region private

    private static UniqueNameGenerator m_UniqueNameGenerator = new UniqueNameGenerator(Resources.DefaultProjectName);
    private readonly string m_Name;
    private UAModelDesignerSolutionServerDetails m_ServerDetails;
    private ServerSelector m_Server;
    private List<IProjectConfigurationManagement> m_Projects;

    #endregion private

    internal static void SetupFileDialog(IFileDialog dialog)
    {
      dialog.DefaultExt = Resources.Solution_FileDialogDefaultExt;
      dialog.Filter = Resources.Solution_FileDialogFilter;
      dialog.Title = Resources.Solution_FileDialogTitle;
    }

    #region TypeGenericConfigurationManagement

    protected override XmlFile.DataToSerialize<UAModelDesignerSolution> PrepareDataToSerialize(UAModelDesignerSolution solutionDesription)
    {
      XmlFile.DataToSerialize<UAModelDesignerSolution> _config;
      _config.Data = solutionDesription;
      _config.XmlNamespaces = null;
      _config.StylesheetName = "UAModelDesignerSolution.xslt";
      return _config;
    }

    #endregion TypeGenericConfigurationManagement

    #region ISolutionConfigurationManagement

    IEnumerable<IProjectConfigurationManagement> ISolutionConfigurationManagement.Projects => m_Projects;
    string ISolutionConfigurationManagement.Name => m_Name;
    ServerSelector ISolutionConfigurationManagement.ServerSelector => m_Server;

    void ISolutionConfigurationManagement.Save(bool prompt)
    {
      m_Server.Save(this);
      this.SelectSavePath(prompt, SetupFileDialog);
      List<UAModelDesignerProject> _projects = new List<UAModelDesignerProject>();
      foreach (IProjectConfigurationManagement _item in m_Projects)
      {
        UAModelDesignerProject _projectDescriptor = _item.UAModelDesignerProject;
        string _effectiveAbsolutePath = _item.Save(this.DefaultDirectory);
        _projectDescriptor.FileName = RelativeFilePathsCalculator.TryComputeRelativePath(this.DefaultDirectory, _effectiveAbsolutePath);
      }
      UAModelDesignerSolution _solutionDesription = new UAModelDesignerSolution()
      {
        Name = this.m_Name,
        Projects = m_Projects.Select<IProjectConfigurationManagement, UAModelDesignerProject>(x => x.UAModelDesignerProject).ToArray<UAModelDesignerProject>(),
        ServerDetails = this.m_ServerDetails ?? UAModelDesignerSolutionServerDetails.CreateEmptyInstance()
      };
      this.Save(_solutionDesription);
    }

    /// <summary>
    /// Imports the UANodeSet encapsulated by a new project.
    /// </summary>
    /// <param name="solutionPathProvider">The solution path provider.</param>
    /// <param name="traceEvent">The trace event.</param>
    /// <returns>ProjectTreeNode.</returns>
    void ISolutionConfigurationManagement.ImportNodeSet(Action<TraceMessage> traceEvent)
    {
      IProjectConfigurationManagement _newModel = ProjectConfigurationManagement.ImportNodeSet(this, base.GraphicalUserInterface, traceEvent);
      if (_newModel == null)
        return;
      m_Projects.Add(_newModel);
      SolutionConfigurationManagementRoot.DefaultInstance.OnSolutionChanged();
    }

    void ISolutionConfigurationManagement.CreateNewModel(Action<TraceMessage> traceEvent)
    {
      IProjectConfigurationManagement _newModel = ProjectConfigurationManagement.CreateNew(this, base.GraphicalUserInterface, m_UniqueNameGenerator.GenerateNewName());
      if (_newModel == null)
        throw new ApplicationException("New project must be created");
      m_Projects.Add(_newModel);
      SolutionConfigurationManagementRoot.DefaultInstance.OnSolutionChanged();
    }

    void ISolutionConfigurationManagement.OpenExistingModel(Action<TraceMessage> traceEvent)
    {
      IProjectConfigurationManagement _newModel = ProjectConfigurationManagement.CreateNew(this, base.GraphicalUserInterface, m_UniqueNameGenerator.GenerateNewName());
      if (_newModel == null)
        throw new ApplicationException("New project must be created");
      m_Projects.Add(_newModel);
      SolutionConfigurationManagementRoot.DefaultInstance.OnSolutionChanged();
    }

    #endregion ISolutionConfigurationManagement

    #region constructors

    private void CommonInitialization()
    {
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 144, "Starting CommonInitialization and checking SaveConstrain");
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 146, "Creating Libraries");
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 151, "Updating Settings Open File Dialog");
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 172, "Creating new private solution using Empty model");
      if (string.IsNullOrEmpty(Settings.Default.DefaultSolutionFileName))
      {
        Settings.Default.DefaultSolutionFileName = DefaultFileName;
        Settings.Default.Save();
      }
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 146, "Finished successfully CommonInitialization");
    }

    internal SolutionConfigurationManagement(Tuple<UAModelDesignerSolution, string> solutionDescription, bool changesArePresent, IGraphicalUserInterface gui) : base(solutionDescription.Item2, changesArePresent, gui)
    {
      m_Name = solutionDescription.Item1.Name;
      m_ServerDetails = solutionDescription.Item1.ServerDetails ?? throw new ArgumentNullException(nameof(UAModelDesignerSolution.ServerDetails));
      m_Projects = solutionDescription.Item1.Projects.Select<UAModelDesignerProject, IProjectConfigurationManagement>(x => ProjectConfigurationManagement.ImportModelDesign(this, base.GraphicalUserInterface, x)).ToList<IProjectConfigurationManagement>();
      m_Server = new ServerSelector(base.GraphicalUserInterface, this, m_ServerDetails.codebase, m_ServerDetails.configuration);
      CommonInitialization();
    }

    #endregion constructors
  }
}