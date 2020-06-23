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
using Opc.Ua.ModelCompiler;
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
    private readonly OPCFModelDesign m_ModelDesign;

    private static void SetupFileDialog(IFileDialog _dialog)
    {
      _dialog.DefaultExt = Resources.Project_FileDialogDefaultExt;
      _dialog.Filter = Resources.Project_FileDialogFilter;
      _dialog.Title = Resources.Project_FileDialogTitle;
    }

    private static string ReplaceTokenAndReturnFullPath(string fileNameToBeProcessed, string projectName, string solutionDirectory)
    {
      string _Name = fileNameToBeProcessed.Replace(Resources.Token_ProjectFileName, projectName);
      return RelativeFilePathsCalculator.CalculateAbsoluteFileName(_Name, solutionDirectory);
    }

    private string CSVFileName
    {
      get
      {
        if (string.IsNullOrEmpty(m_UAModelDesignerProject.CSVFileName))
          m_UAModelDesignerProject.CSVFileName = Resources.DefaultCSVFileName;
        return m_UAModelDesignerProject.CSVFileName;
      }
    }

    private string CSVFilePath => ReplaceTokenAndReturnFullPath(CSVFileName, m_UAModelDesignerProject.Name, m_ISolutionConfigurationManagement.DefaultDirectory);
    private string BuildOutputDirectoryPath => ReplaceTokenAndReturnFullPath(BuildOutputDirectoryName, m_UAModelDesignerProject.Name, m_ISolutionConfigurationManagement.DefaultDirectory);

    private string BuildOutputDirectoryName
    {
      get
      {
        if (string.IsNullOrEmpty(m_UAModelDesignerProject.BuildOutputDirectoryName))
          m_UAModelDesignerProject.BuildOutputDirectoryName = Resources.DefaultOutputBuildDirectory;
        return Path.Combine(this.DefaultDirectory, m_UAModelDesignerProject.BuildOutputDirectoryName);
      }
    }

    /// <summary>
    /// Calculates the effective absolute model file path.
    /// </summary>
    /// <returns>System.String.</returns>
    private string CalculateEffectiveAbsoluteModelFilePath()
    {
      return RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_UAModelDesignerProject.FileName, this.m_ISolutionConfigurationManagement.DefaultDirectory);
    }

    protected override XmlFile.DataToSerialize<OPCFModelDesign> PrepareDataToSerialize(OPCFModelDesign modelDesign)
    {
      XmlFile.DataToSerialize<OPCFModelDesign> _config;
      _config.Data = modelDesign;
      _config.XmlNamespaces = null;
      _config.StylesheetName = "OPCUAModelDesign.xslt";
      return _config;
    }

    #endregion private

    #region constructor

    private ProjectConfigurationManagement(UAModelDesignerProject uaModelDesignerProject, ISolutionConfigurationManagement solution, Tuple<OPCFModelDesign, string> modelDesign, IGraphicalUserInterface gui) :
      base(modelDesign.Item2, modelDesign.Item1 == null, gui)
    {
      m_UAModelDesignerProject = uaModelDesignerProject;
      m_ISolutionConfigurationManagement = solution;
      this.m_ModelDesign = modelDesign.Item1 == null ? OpcUaModelCompilerModelDesigner.GetDefault() : modelDesign.Item1;
    }

    internal static IProjectConfigurationManagement ImportNodeSet(ISolutionConfigurationManagement solution, IGraphicalUserInterface graphicalUserInterface, Action<TraceMessage> traceEvent)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (graphicalUserInterface == null) throw new ArgumentNullException(nameof(graphicalUserInterface));
      Tuple<OPCFModelDesign, string> _modelDesign = IO.ImportNodeSet.Import(solution.DefaultDirectory, traceEvent);
      if (_modelDesign == null)
        return null;
      UAModelDesignerProject _newProjctDesription = UAModelDesignerProject.CreateEmpty(solution.DefaultDirectory, _modelDesign.Item2);
      return new ProjectConfigurationManagement(_newProjctDesription, solution, _modelDesign, graphicalUserInterface);
    }

    internal static IProjectConfigurationManagement ImportModelDesign(ISolutionConfigurationManagement solution, IGraphicalUserInterface gui, UAModelDesignerProject uaModelDesignerProject)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (gui == null) throw new ArgumentNullException(nameof(gui));
      if (uaModelDesignerProject == null) throw new ArgumentNullException(nameof(uaModelDesignerProject));
      string _filePath = Path.Combine(solution.DefaultDirectory, uaModelDesignerProject.FileName);
      Tuple<OPCFModelDesign, string> _modelDesign = new Tuple<OPCFModelDesign, string>(TypeGenericConfigurationManagement<OPCFModelDesign>.ReadConfiguration(Path.Combine(solution.DefaultDirectory, uaModelDesignerProject.FileName), gui), _filePath);
      return new ProjectConfigurationManagement(uaModelDesignerProject, solution, _modelDesign, gui);
    }

    /// <summary>
    /// Creates new model encapsulated by instance of this class
    /// </summary>
    /// <param name="solution">The solution description.</param>
    /// <param name="gui">The graphical user interface.</param>
    /// <param name="projectName">Name of the project.</param>
    /// <returns><see cref="IProjectConfigurationManagement"/>.</returns>
    internal static IProjectConfigurationManagement CreateNew(ISolutionConfigurationManagement solution, IGraphicalUserInterface gui, string projectName)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (gui == null) throw new ArgumentNullException(nameof(gui));
      UAModelDesignerProject _projectDescription = UAModelDesignerProject.CreateEmpty(solution.DefaultDirectory, projectName);
      string _defFilePath = Path.ChangeExtension(Path.Combine(solution.DefaultDirectory, projectName), Resources.Project_FileDialogDefaultExt);
      return new ProjectConfigurationManagement(_projectDescription, solution, new Tuple<OPCFModelDesign, string>(null, _defFilePath), gui);
    }

    #endregion constructor

    #region IOPCFModelConfigurationManagement

    OPCFModelDesign IProjectConfigurationManagement.ModelDesign => m_ModelDesign;
    UAModelDesignerProject IProjectConfigurationManagement.UAModelDesignerProject => m_UAModelDesignerProject;
    string IProjectConfigurationManagement.Name => this.m_UAModelDesignerProject.Name;

    /// <summary>
    /// Builds the project and write any massages to specified output.
    /// </summary>
    /// <param name="output">The output containing text sent by the compiler.</param>
    void IProjectConfigurationManagement.Build(TextWriter output)
    {
      // some verification at the beginning
      DirectoryInfo dirinfo = new DirectoryInfo(BuildOutputDirectoryPath);
      if (!dirinfo.Exists)
        Directory.CreateDirectory(BuildOutputDirectoryPath);
      string _filePath = CalculateEffectiveAbsoluteModelFilePath();
      if (!new FileInfo(_filePath).Exists)
      {
        string msg = string.Format(Resources.BuildError_Fie_DoesNotExist, _filePath);
        output.WriteLine(msg);
        GraphicalUserInterface.MessageBoxShowError(msg, Resources.Build_Caption);
        return;
      }
      if (!new FileInfo(CSVFilePath).Exists)
      {
        string msg = string.Format(Resources.BuildError_Fie_DoesNotExist_doyouwanttocreateone, CSVFilePath);
        if (GraphicalUserInterface.MessageBoxShowWarningAskYN(msg, Resources.Build_Caption))
        {
          //we are creating an blank file (one empty line inside)
          StreamWriter myCsvFile = new StreamWriter(CSVFilePath, false);
          using (myCsvFile)
          {
            myCsvFile.WriteLine(" ");
            myCsvFile.Flush();
            myCsvFile.Close();
          }
        }
        else
        {
          output.WriteLine(string.Format(Resources.BuildError_Fie_DoesNotExist, CSVFilePath));
          return;
        }
      }
      string argument = string.Format(Properties.Settings.Default.Build_ProjectCompilationString, _filePath, CSVFilePath, BuildOutputDirectoryPath);
      string CompilationExecutable = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Properties.Settings.Default.ProjectCompilationExecutable);
      ProcessStartInfo myStartInfo = new System.Diagnostics.ProcessStartInfo(CompilationExecutable)
      {
        Arguments = argument,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false,
        CreateNoWindow = true
      };
      output.WriteLine();
      output.Write(CompilationExecutable);
      output.Write(" ");
      output.WriteLine(argument);
      output.WriteLine();
      Process myBuildProcess = new Process
      {
        StartInfo = myStartInfo
      };
      if (!myBuildProcess.Start())
        GraphicalUserInterface.MessageBoxShowWarning(Resources.Build_click_ok_when_build_has_finished, Resources.Build_Caption);
      else
      {
        myBuildProcess.WaitForExit();
        string outputfrombuildprocess = myBuildProcess.StandardOutput.ReadToEnd();
        string erroroutputfrombuildprocess = myBuildProcess.StandardError.ReadToEnd();
        if (!string.IsNullOrEmpty(erroroutputfrombuildprocess))
        {
          erroroutputfrombuildprocess = string.Format(Resources.BuildError_error_occured, erroroutputfrombuildprocess);
        }
        else
        {
          erroroutputfrombuildprocess = Resources.Build_project_ok;
        }
        outputfrombuildprocess += erroroutputfrombuildprocess;
        if (!string.IsNullOrEmpty(outputfrombuildprocess))
          output.WriteLine(outputfrombuildprocess);
      }
    }

    void IProjectConfigurationManagement.SaveModelDesign(OPCFModelDesign modelDesign)
    {
      base.Save(modelDesign);
    }

    #endregion IOPCFModelConfigurationManagement
  }
}