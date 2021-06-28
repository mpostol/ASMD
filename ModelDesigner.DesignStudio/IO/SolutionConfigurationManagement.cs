﻿//__________________________________________________________________________________________________
//
//  Copyright (C) 2021 Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Solution;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

    private ServerSelector m_Server;

    private List<IProjectConfigurationManagement> m_Projects;

    private void AddProjectTCollection(IProjectConfigurationManagement _newModel)
    {
      m_Projects.Add(_newModel);
      SolutionConfigurationManagementRoot.DefaultInstance.OnSolutionChanged();
    }

    #endregion private

    internal static void SetupFileDialog(IFileDialog dialog)
    {
      dialog.DefaultExt = Resources.Solution_FileDialogDefaultExt;
      dialog.Filter = Resources.Solution_FileDialogFilter;
      dialog.Title = Resources.Solution_FileDialogTitle;
    }

    #region TypeGenericConfigurationManagement

    /// <summary>
    /// Gets the name of the stylesheet.
    /// </summary>
    /// <returns>name of the stylesheet is if applicable</returns>
    protected override string GetStylesheetName()
    {
      return "UAModelDesignerSolution.xslt";
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
        string _effectiveAbsolutePath = _item.DefaultFileName;
        _projectDescriptor.FileName = RelativeFilePathsCalculator.TryComputeRelativePath(this.DefaultDirectory, _effectiveAbsolutePath);
      }
      string _codebaseRelativePathName = string.Empty;
      string _configurationRelativePathName = string.Empty;
      ServerSelector.ServerDescriptor _plugin = m_Server.ServerConfiguration;
      if (_plugin != null)
      {
        _codebaseRelativePathName = RelativeFilePathsCalculator.TryComputeRelativePath(this.DefaultDirectory, _plugin.Codebase);
        _configurationRelativePathName = RelativeFilePathsCalculator.TryComputeRelativePath(this.DefaultDirectory, _plugin.Configuration);
      }
      UAModelDesignerSolution _solutionDesription = new UAModelDesignerSolution()
      {
        Name = this.m_Name,
        Projects = m_Projects.Select<IProjectConfigurationManagement, UAModelDesignerProject>(x => x.UAModelDesignerProject).ToArray<UAModelDesignerProject>(),
        ServerDetails = new UAModelDesignerSolutionServerDetails { codebase = _codebaseRelativePathName, configuration = _configurationRelativePathName }
      };
      this.Save(_solutionDesription);
    }

    /// <summary>
    /// Imports the UANodeSet encapsulated by a new project.
    /// </summary>
    /// <param name="solutionPathProvider">The solution path provider.</param>
    /// <param name="traceEvent">The trace event.</param>
    /// <returns>ProjectTreeNode.</returns>
    void ISolutionConfigurationManagement.ImportNodeSet()
    {
      IProjectConfigurationManagement _newModel = ProjectConfigurationManagement.ImportNodeSet(this, base.GraphicalUserInterface, x => AssemblyTraceEvent.Log.TraceMessage(x, nameof(ISolutionConfigurationManagement.ImportNodeSet), 486245093));
      if (_newModel == null)
        return;
      AddProjectTCollection(_newModel);
    }

    void ISolutionConfigurationManagement.NewModelDesign()
    {
      IProjectConfigurationManagement _newModel = ProjectConfigurationManagement.CreateNew(this, base.GraphicalUserInterface, m_UniqueNameGenerator.GenerateNewName());
      if (_newModel == null)
        throw new ApplicationException("New project must be created");
      AddProjectTCollection(_newModel);
    }

    void ISolutionConfigurationManagement.ImportModelDesign()
    {
      IProjectConfigurationManagement _newModel = ProjectConfigurationManagement.ImportModelDesign(this, base.GraphicalUserInterface);
      if (_newModel == null)
        return;
      AddProjectTCollection(_newModel);
    }

    #endregion ISolutionConfigurationManagement

    #region constructors

    internal SolutionConfigurationManagement(Tuple<UAModelDesignerSolution, string> solutionDescription, bool changesArePresent, IGraphicalUserInterface gui) : base(solutionDescription.Item2, changesArePresent, gui)
    {
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 335242041, "Creating new private solution using Empty model");
      m_Name = solutionDescription.Item1.Name;
      UAModelDesignerSolutionServerDetails _ServerDetails = solutionDescription.Item1.ServerDetails ?? throw new ArgumentNullException(nameof(UAModelDesignerSolution.ServerDetails));
      m_Projects = solutionDescription.Item1.Projects.Select<UAModelDesignerProject, IProjectConfigurationManagement>(x => ProjectConfigurationManagement.ImportModelDesign(this, base.GraphicalUserInterface, x)).ToList<IProjectConfigurationManagement>();
      string _codebase = RelativeFilePathsCalculator.CalculateAbsoluteFileName(this.DefaultDirectory, _ServerDetails.codebase);
      string _configuration = RelativeFilePathsCalculator.CalculateAbsoluteFileName(this.DefaultDirectory, _ServerDetails.configuration);
      m_Server = new ServerSelector(base.GraphicalUserInterface, this, _codebase, _configuration);
      if (string.IsNullOrEmpty(Settings.Default.DefaultSolutionFileName))
      {
        Settings.Default.DefaultSolutionFileName = DefaultFileName;
        Settings.Default.Save();
      }
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 335242042, "Finished successfully CommonInitialization");
    }

    #endregion constructors
  }
}