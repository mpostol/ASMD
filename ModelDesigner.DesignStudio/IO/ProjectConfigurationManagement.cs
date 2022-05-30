//__________________________________________________________________________________________________
//
//  Copyright (C) 2022, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Solution;
using OOI.ModelCompiler;
using System;
using System.Collections.Generic;
using System.IO;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;
using TraceMessage = UAOOI.SemanticData.BuildingErrorsHandling.TraceMessage;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Class to save and restore UA Information Model to/from external file.
  /// </summary>
  internal class ProjectConfigurationManagement : TypeGenericConfigurationManagement<OpcUaModelCompiler.ModelDesign>, IProjectConfigurationManagement
  {
    #region private

    private class CompilerOptions : ICompilerOptions
    {
      public string OutputPath
      {
        get { return OutputPathBacked ?? throw new ArgumentNullException($"{nameof(OutputPath)}"); }
        internal set
        {
          if (value == null) throw new ArgumentNullException($"{nameof(value)}");
          OutputPathBacked = value;
        }
      }

      public IList<string> DesignFiles { internal set; get; } = new List<string>();

      public string IdentifierFile { get; internal set; }

      public string Version { get; internal set; }

      public uint StartId { get; internal set; }

      public bool UseAllowSubtypes { get; internal set; }

      public IList<string> Exclusions { get; internal set; }

      public string ModelPublicationDate { get; internal set; }

      public bool ReleaseCandidate { get; internal set; }

      public string ModelVersion { get; internal set; }

      private string OutputPathBacked;
    }

    private readonly UAModelDesignerProject m_UAModelDesignerProject;
    private readonly ISolutionConfigurationManagement m_ISolutionConfigurationManagement;
    private readonly bool m_NewModel = false;
    private OpcUaModelCompiler.ModelDesign m_ModelDesign;

    private static void SetupFileDialog(IFileDialog _dialog)
    {
      _dialog.DefaultExt = Resources.Project_FileDialogDefaultExt;
      _dialog.Filter = Resources.Project_FileDialogFilter;
      _dialog.Title = Resources.Project_FileDialogTitle;
    }

    private static string ReplaceTokenAndReturnFullPath(string fileNameToBeProcessed, string projectName, string solutionDirectory)
    {
      string _Name = fileNameToBeProcessed.Replace(Resources.Token_ProjectFileName, projectName);
      return RelativeFilePathsCalculator.CalculateAbsoluteFileName(solutionDirectory, _Name);
    }

    private (string CSVFileName, string OutputDirectory) BuildCalculateFileNames()
    {
      UAModelDesignerProject _def = UAModelDesignerProject.CreateEmpty("temporal");
      if (String.IsNullOrEmpty(m_UAModelDesignerProject.Name))
        m_UAModelDesignerProject.Name = Guid.NewGuid().ToString();
      if (String.IsNullOrEmpty(m_UAModelDesignerProject.CSVFileName))
        m_UAModelDesignerProject.CSVFileName = _def.CSVFileName;
      if (String.IsNullOrEmpty(m_UAModelDesignerProject.BuildOutputDirectoryName))
        m_UAModelDesignerProject.BuildOutputDirectoryName = _def.BuildOutputDirectoryName;
      string _CSVFileName = ReplaceTokenAndReturnFullPath(m_UAModelDesignerProject.CSVFileName, m_UAModelDesignerProject.Name, this.DefaultDirectory);
      string _OutputDirectory = ReplaceTokenAndReturnFullPath(m_UAModelDesignerProject.BuildOutputDirectoryName, m_UAModelDesignerProject.Name, this.DefaultDirectory);
      return new ValueTuple<string, string>(_CSVFileName, _OutputDirectory);
    }

    #endregion private

    #region TypeGenericConfigurationManagement

    /// <summary>
    /// Gets the name of the stylesheet.
    /// </summary>
    /// <returns>name of the stylesheet is if applicable</returns>
    protected override string GetStylesheetName()
    {
      return String.Empty;
    }

    #endregion TypeGenericConfigurationManagement

    #region constructor

    private ProjectConfigurationManagement(bool newModel, UAModelDesignerProject uaModelDesignerProject, ISolutionConfigurationManagement solution, Tuple<OpcUaModelCompiler.ModelDesign, string> modelDesign, IGraphicalUserInterface gui) :
      base(modelDesign.Item2, newModel, gui)
    {
      m_UAModelDesignerProject = uaModelDesignerProject;
      m_ISolutionConfigurationManagement = solution;
      this.m_ModelDesign = modelDesign.Item1;
      m_NewModel = newModel;
    }

    internal static IProjectConfigurationManagement ImportNodeSet(ISolutionConfigurationManagement solution, IGraphicalUserInterface graphicalUserInterface, Action<TraceMessage> traceEvent)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (graphicalUserInterface == null) throw new ArgumentNullException(nameof(graphicalUserInterface));
      Tuple<OpcUaModelCompiler.ModelDesign, string> _modelDesign = IO.ImportNodeSet.Import(solution.DefaultDirectory, traceEvent);
      if (_modelDesign == null)
        return null;
      UAModelDesignerProject _newProjctDesription = UAModelDesignerProject.CreateEmpty(_modelDesign.Item2);
      return new ProjectConfigurationManagement(true, _newProjctDesription, solution, _modelDesign, graphicalUserInterface);
    }

    internal static IProjectConfigurationManagement ImportModelDesign(ISolutionConfigurationManagement solution, IGraphicalUserInterface gui)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (gui == null) throw new ArgumentNullException(nameof(gui));
      Tuple<OpcUaModelCompiler.ModelDesign, string> _modelDesign = TypeGenericConfigurationManagement<OpcUaModelCompiler.ModelDesign>.ReadConfiguration(gui, SetupFileDialog);
      if (_modelDesign.Item1 == null)
        return null;
      UAModelDesignerProject uaModelDesignerProject = UAModelDesignerProject.CreateEmpty(Path.GetFileNameWithoutExtension(_modelDesign.Item2));
      uaModelDesignerProject.FileName = CAS.CommServer.UA.ModelDesigner.Configuration.IO.RelativeFilePathsCalculator.TryComputeRelativePath(solution.DefaultDirectory, _modelDesign.Item2);
      return new ProjectConfigurationManagement(false, uaModelDesignerProject, solution, _modelDesign, gui);
    }

    internal static IProjectConfigurationManagement ImportModelDesign(ISolutionConfigurationManagement solution, IGraphicalUserInterface gui, UAModelDesignerProject uaModelDesignerProject)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (gui == null) throw new ArgumentNullException(nameof(gui));
      if (uaModelDesignerProject == null) throw new ArgumentNullException(nameof(uaModelDesignerProject));
      string _filePath = Path.Combine(solution.DefaultDirectory, uaModelDesignerProject.FileName);
      Tuple<OpcUaModelCompiler.ModelDesign, string> _modelDesign = new Tuple<OpcUaModelCompiler.ModelDesign, string>(TypeGenericConfigurationManagement<OpcUaModelCompiler.ModelDesign>.ReadConfiguration(Path.Combine(solution.DefaultDirectory, uaModelDesignerProject.FileName), gui), _filePath);
      return new ProjectConfigurationManagement(false, uaModelDesignerProject, solution, _modelDesign, gui);
    }

    /// <summary>
    /// Creates new model encapsulated by an instance of this class
    /// </summary>
    /// <param name="solution">The solution description.</param>
    /// <param name="gui">The graphical user interface.</param>
    /// <param name="projectName">Name of the project.</param>
    /// <returns><see cref="IProjectConfigurationManagement"/>.</returns>
    internal static IProjectConfigurationManagement CreateNew(ISolutionConfigurationManagement solution, IGraphicalUserInterface gui, string projectName)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (gui == null) throw new ArgumentNullException(nameof(gui));
      UAModelDesignerProject _projectDescription = UAModelDesignerProject.CreateEmpty(projectName);
      //TODO Creating new project the existing one should not be overridden #174
      string _defFilePath = Path.ChangeExtension(RelativeFilePathsCalculator.CalculateAbsoluteFileName(solution.DefaultDirectory, projectName), Resources.Project_FileDialogDefaultExt);
      return new ProjectConfigurationManagement(true, _projectDescription, solution, new Tuple<OpcUaModelCompiler.ModelDesign, string>(OpcUaModelCompilerModelDesigner.GetDefault(), _defFilePath), gui);
    }

    #endregion constructor

    #region IProjectConfigurationManagement

    OpcUaModelCompiler.ModelDesign IProjectConfigurationManagement.ModelDesign => m_ModelDesign;
    UAModelDesignerProject IProjectConfigurationManagement.UAModelDesignerProject => m_UAModelDesignerProject;
    string IProjectConfigurationManagement.Name => this.m_UAModelDesignerProject.Name;

    /// <summary>
    /// Builds the model managed by this project
    /// </summary>
    /// <param name="traceMessage">Action to be used to trace the messages.</param>
    void IProjectConfigurationManagement.Build(Action<string> traceMessage)
    {
      string _filePath = RelativeFilePathsCalculator.CalculateAbsoluteFileName(this.m_ISolutionConfigurationManagement.DefaultDirectory, m_UAModelDesignerProject.FileName);
      if (!File.Exists(this.DefaultFileName))
      {
        string msg = string.Format(Resources.BuildError_Fie_DoesNotExist, _filePath);
        traceMessage(msg);
        GraphicalUserInterface.MessageBoxShowError(msg, Resources.Build_Caption);
        return;
      }
      (string CSVFileName, string OutputDirectory) = BuildCalculateFileNames();
      if (!Directory.Exists(OutputDirectory))
        Directory.CreateDirectory(OutputDirectory);
      if (!File.Exists(CSVFileName))
      {
        string msg = string.Format(Resources.BuildError_Fie_DoesNotExist_doyouwanttocreateone, CSVFileName);
        if (GraphicalUserInterface.MessageBoxShowWarningAskYN(msg, Resources.Build_Caption))
          using (StreamWriter myCsvFile = new StreamWriter(CSVFileName, false))//we are creating an blank file (one empty line inside)
          {
            myCsvFile.WriteLine(" ");
            myCsvFile.Flush();
          }
        else
        {
          traceMessage(string.Format(Resources.BuildError_Fie_DoesNotExist, CSVFileName));
          return;
        }
      }
      CompilerOptions options = new CompilerOptions();
      options.DesignFiles.Add(_filePath);
      options.IdentifierFile = CSVFileName;
      options.OutputPath = OutputDirectory;
      if (!Directory.Exists(OutputDirectory))
        Directory.CreateDirectory(options.OutputPath);
      try
      {
        string _commandLine = string.Format(Properties.Settings.Default.Build_ProjectCompilationString, _filePath, CSVFileName, OutputDirectory);
        traceMessage($"Started build at 499457465 with parameters {_commandLine}");
        ModelDesignCompiler.BuildModel(options);
      }
      catch (Exception ex)
      {
        string errorMessage = $"Compilation ended with error {ex.GetType().Name}: {ex.Message} at 552021345 {Environment.NewLine}{ex.StackTrace}";
        traceMessage(errorMessage);
      }
    }

    void IProjectConfigurationManagement.Save(OpcUaModelCompiler.ModelDesign modelDesign)
    {
      m_ModelDesign = modelDesign;
      base.Save(this.m_ModelDesign);
    }

    #endregion IProjectConfigurationManagement
  }
}