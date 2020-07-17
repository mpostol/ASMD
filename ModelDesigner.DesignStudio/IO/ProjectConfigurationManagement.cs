//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Solution;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using UAOOI.SemanticData.UANodeSetValidation;
using OPCFModelDesign = Opc.Ua.ModelCompiler.ModelDesign;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Class to save and restore UA Information Model to/from external file.
  /// </summary>
  internal class ProjectConfigurationManagement : TypeGenericConfigurationManagement<OPCFModelDesign>, IProjectConfigurationManagement
  {
    #region private

    private readonly UAModelDesignerProject m_UAModelDesignerProject;
    private readonly ISolutionConfigurationManagement m_ISolutionConfigurationManagement;
    private readonly bool m_NewModel = false;
    private OPCFModelDesign m_ModelDesign;

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

    #region TypeGenericConfigurationManagement<OPCFModelDesign>

    protected override XmlFile.DataToSerialize<OPCFModelDesign> PrepareDataToSerialize(OPCFModelDesign modelDesign)
    {
      XmlFile.DataToSerialize<OPCFModelDesign> _config;
      _config.Data = modelDesign;
      _config.XmlNamespaces = null;
      _config.StylesheetName = "OPCUAModelDesign.xslt";
      return _config;
    }

    #endregion TypeGenericConfigurationManagement<OPCFModelDesign>

    #region constructor

    private ProjectConfigurationManagement(bool newModel, UAModelDesignerProject uaModelDesignerProject, ISolutionConfigurationManagement solution, Tuple<OPCFModelDesign, string> modelDesign, IGraphicalUserInterface gui) :
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
      Tuple<OPCFModelDesign, string> _modelDesign = IO.ImportNodeSet.Import(solution.DefaultDirectory, traceEvent);
      if (_modelDesign == null)
        return null;
      UAModelDesignerProject _newProjctDesription = UAModelDesignerProject.CreateEmpty(_modelDesign.Item2);
      return new ProjectConfigurationManagement(true, _newProjctDesription, solution, _modelDesign, graphicalUserInterface);
    }

    internal static IProjectConfigurationManagement ImportModelDesign(ISolutionConfigurationManagement solution, IGraphicalUserInterface gui)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (gui == null) throw new ArgumentNullException(nameof(gui));
      Tuple<OPCFModelDesign, string> _modelDesign = TypeGenericConfigurationManagement<OPCFModelDesign>.ReadConfiguration(gui, SetupFileDialog);
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
      Tuple<OPCFModelDesign, string> _modelDesign = new Tuple<OPCFModelDesign, string>(TypeGenericConfigurationManagement<OPCFModelDesign>.ReadConfiguration(Path.Combine(solution.DefaultDirectory, uaModelDesignerProject.FileName), gui), _filePath);
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
      return new ProjectConfigurationManagement(true, _projectDescription, solution, new Tuple<OPCFModelDesign, string>(OpcUaModelCompilerModelDesigner.GetDefault(), _defFilePath), gui);
    }

    #endregion constructor

    #region IProjectConfigurationManagement

    OPCFModelDesign IProjectConfigurationManagement.ModelDesign => m_ModelDesign;
    UAModelDesignerProject IProjectConfigurationManagement.UAModelDesignerProject => m_UAModelDesignerProject;
    string IProjectConfigurationManagement.Name => this.m_UAModelDesignerProject.Name;

    /// <summary>
    /// Builds the project and write any massages to specified output.
    /// </summary>
    /// <param name="output">The output containing text sent by the compiler.</param>
    void IProjectConfigurationManagement.Build(TextWriter output)
    {
      //TODO Tools => Build/Verify - failed #173 - build must refer to current model file but not any calculated path
      string _filePath = RelativeFilePathsCalculator.CalculateAbsoluteFileName(this.m_ISolutionConfigurationManagement.DefaultDirectory, m_UAModelDesignerProject.FileName);
      if (!File.Exists(this.DefaultFileName))
      {
        string msg = string.Format(Resources.BuildError_Fie_DoesNotExist, _filePath);
        output.WriteLine(msg);
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
          output.WriteLine(string.Format(Resources.BuildError_Fie_DoesNotExist, CSVFileName));
          return;
        }
      }
      string _commandLine = string.Format(Properties.Settings.Default.Build_ProjectCompilationString, _filePath, CSVFileName, OutputDirectory);
      string _compilerPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Properties.Settings.Default.ProjectCompilationExecutable);
      ProcessStartInfo myStartInfo = new ProcessStartInfo(_compilerPath)
      {
        Arguments = _commandLine,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false,
        CreateNoWindow = true
      };
      output.WriteLine();
      output.Write(_compilerPath);
      output.Write(" ");
      output.WriteLine(_commandLine);
      output.WriteLine();
      Process _buildProcess = new Process
      {
        StartInfo = myStartInfo
      };
      if (!_buildProcess.Start())
        GraphicalUserInterface.MessageBoxShowWarning(Resources.Build_click_ok_when_build_has_finished, Resources.Build_Caption);
      else
      {
        _buildProcess.WaitForExit();
        string _outputfrombuildprocess = _buildProcess.StandardOutput.ReadToEnd();
        string _erroroutputfrombuildprocess = _buildProcess.StandardError.ReadToEnd();
        if (!string.IsNullOrEmpty(_erroroutputfrombuildprocess))
          _erroroutputfrombuildprocess = string.Format(Resources.BuildError_error_occured, _erroroutputfrombuildprocess);
        else
          _erroroutputfrombuildprocess = Resources.Build_project_ok;
        _outputfrombuildprocess += _erroroutputfrombuildprocess;
        if (!string.IsNullOrEmpty(_outputfrombuildprocess))
          output.WriteLine(_outputfrombuildprocess);
      }
    }

    void IProjectConfigurationManagement.Save(OPCFModelDesign modelDesign)
    {
      m_ModelDesign = modelDesign;
      base.Save(this.m_ModelDesign);
    }

    #endregion IProjectConfigurationManagement
  }
}