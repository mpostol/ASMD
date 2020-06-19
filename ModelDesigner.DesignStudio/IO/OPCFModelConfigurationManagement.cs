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
  internal class OPCFModelConfigurationManagement : TypeGenericConfigurationManagement<OPCFModelDesign>, IProjectConfigurationManagement
  {
    #region private

    private readonly UAModelDesignerProject m_UAModelDesignerProject;
    private readonly ISolutionConfigurationManagement m_ISolutionConfigurationManagement;
    private OPCFModelDesign m_ModelDesign;

    /// <summary>
    /// Gets the type of the configuration.
    /// </summary>
    /// <value>The type of the configuration defined in <see cref="ConfigurationType" />.</value>
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

    private void SolutionHomeDirectoryBaseDirectoryPathChanged(object sender, NewDirectoryPathEventArgs e)
    {
      string _oldAbsoluteFilePath = RelativeFilePathsCalculator.CalculateAbsoluteFileName(this.m_UAModelDesignerProject.FileName, e.OldDirectoryPath);
      string _newAbsoluteFilePath = RelativeFilePathsCalculator.CalculateAbsoluteFileName(this.m_UAModelDesignerProject.FileName, e.NewDirectoryPath);
      this.m_UAModelDesignerProject.FileName = RelativeFilePathsCalculator.TryComputeRelativePath(_newAbsoluteFilePath, _oldAbsoluteFilePath);
    }

    private string CSVFileName
    {
      get
      {
        if (string.IsNullOrEmpty(m_UAModelDesignerProject.CSVFileName))
          m_UAModelDesignerProject.CSVFileName = Resources.DefaultCSVFileName;
        return m_UAModelDesignerProject.CSVFileName;
      }
      set => m_UAModelDesignerProject.CSVFileName = value;
    }

    private string CSVFilePath => ReplaceTokenAndReturnFullPath(CSVFileName, m_UAModelDesignerProject.Name, m_ISolutionConfigurationManagement.DefaultDirectory);

    private string BuildOutputDirectoryName
    {
      get
      {
        if (string.IsNullOrEmpty(m_UAModelDesignerProject.BuildOutputDirectoryName))
          m_UAModelDesignerProject.BuildOutputDirectoryName = Resources.DefaultOutputBuildDirectory;
        return m_UAModelDesignerProject.BuildOutputDirectoryName;
      }
      set => m_UAModelDesignerProject.BuildOutputDirectoryName = value;
    }

    private string BuildOutputDirectoryPath => ReplaceTokenAndReturnFullPath(BuildOutputDirectoryName, m_UAModelDesignerProject.Name, m_ISolutionConfigurationManagement.DefaultDirectory);

    private static OPCFModelDesign ReadModelDesign(string solutionDirectoryPathManagementBaseDirectory, string fileName)
    {
      //m_ModelDesign = this.ReadConfiguration();
      string _filePath = RelativeFilePathsCalculator.CalculateAbsoluteFileName(fileName, solutionDirectoryPathManagementBaseDirectory);
      if (!File.Exists(_filePath))
        throw new FileNotFoundException($"Cannot find the model file at { _filePath}");
      return XmlFile.ReadXmlFile<OPCFModelDesign>(_filePath);
    }

    /// <summary>
    /// Calculates the effective absolute model file path.
    /// </summary>
    /// <returns>System.String.</returns>
    private string CalculateEffectiveAbsoluteModelFilePath()
    {
      return RelativeFilePathsCalculator.CalculateAbsoluteFileName(m_UAModelDesignerProject.FileName, this.m_ISolutionConfigurationManagement.DefaultDirectory);
    }

    #endregion private

    #region constructor

    private OPCFModelConfigurationManagement(ISolutionConfigurationManagement solution, IGraphicalUserInterface gui, UAModelDesignerProject uaModelDesignerProject, OPCFModelDesign modelDesign) :
      base(uaModelDesignerProject.FileName, gui)
    {
      m_ISolutionConfigurationManagement = solution;
      m_UAModelDesignerProject = uaModelDesignerProject;
      solution.DefaultFileNameHasChanged += SolutionHomeDirectoryBaseDirectoryPathChanged;
      this.m_ModelDesign = modelDesign;
    }

    internal static IProjectConfigurationManagement ImportNodeSet(ISolutionConfigurationManagement solution, IGraphicalUserInterface graphicalUserInterface, Action<TraceMessage> traceEvent)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (graphicalUserInterface == null) throw new ArgumentNullException(nameof(graphicalUserInterface));
      Tuple<OPCFModelDesign, string> _model = IO.ImportNodeSet.Import(solution.DefaultDirectory, traceEvent);
      if (_model == null)
        return null;
      UAModelDesignerProject _newProjctDesription = UAModelDesignerProject.CreateEmpty(solution.DefaultDirectory, _model.Item2);
      return new OPCFModelConfigurationManagement(solution, graphicalUserInterface, _newProjctDesription, _model.Item1);
    }

    internal static IProjectConfigurationManagement ImportModelDesign(ISolutionConfigurationManagement solution, IGraphicalUserInterface graphicalUserInterface, UAModelDesignerProject uaModelDesignerProject)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (graphicalUserInterface == null) throw new ArgumentNullException(nameof(graphicalUserInterface));
      if (uaModelDesignerProject == null) throw new ArgumentNullException(nameof(uaModelDesignerProject));
      OPCFModelDesign _modelDesign = ReadModelDesign(solution.DefaultDirectory, uaModelDesignerProject.FileName);
      return new OPCFModelConfigurationManagement(solution, graphicalUserInterface, uaModelDesignerProject, _modelDesign);
    }

    /// <summary>
    /// Creates new model encapsulated by instance of this class
    /// </summary>
    /// <param name="solution">The solution description.</param>
    /// <param name="graphicalUserInterface">The graphical user interface.</param>
    /// <param name="projectName">Name of the project.</param>
    /// <returns><see cref="IProjectConfigurationManagement"/>.</returns>
    internal static IProjectConfigurationManagement CreateNew(ISolutionConfigurationManagement solution, IGraphicalUserInterface graphicalUserInterface, string projectName)
    {
      if (solution == null) throw new ArgumentNullException(nameof(solution));
      if (graphicalUserInterface == null) throw new ArgumentNullException(nameof(graphicalUserInterface));
      UAModelDesignerProject _projectDescription = UAModelDesignerProject.CreateEmpty(solution.DefaultDirectory, projectName);
      OPCFModelDesign _OPCFModelDesign = new OPCFModelDesign()
      {
        TargetNamespace = Settings.Default.TargetNamespace,
        Namespaces = new Opc.Ua.ModelCompiler.Namespace[]
            { new  Opc.Ua.ModelCompiler.Namespace()
               {
                 Value = Settings.Default.TargetNamespace,
                 XmlPrefix = Settings.Default.TargetNamespaceXmlPrefix,
                 Name = Settings.Default.TargetNamespaceXmlPrefix
               },
             new Opc.Ua.ModelCompiler.Namespace()
               {
                 //Value = OPCUATargetNamespace, // TODO it is not present in new ModelCompiler release.
                 XmlPrefix = Settings.Default.XmlUATypesPrefix,
                 Name = Settings.Default.XmlUATypesPrefix
               }
            }
      };
      return new OPCFModelConfigurationManagement(solution, graphicalUserInterface, _projectDescription, _OPCFModelDesign);
    }

    #endregion constructor

    #region IOPCFModelConfigurationManagement

    OPCFModelDesign IProjectConfigurationManagement.ModelDesign => m_ModelDesign;

    UAModelDesignerProject IProjectConfigurationManagement.UAModelDesignerProject => m_UAModelDesignerProject;
    string IProjectConfigurationManagement.Name => this.m_UAModelDesignerProject.Name;

    //TODO Changing of the solution location doesn't recalculate the projects paths #134 - save operations must be consolidated
    public bool SaveModelDesign()
    {
      XmlFile.DataToSerialize<OPCFModelDesign> _config;
      _config.Data = m_ModelDesign;
      _config.XmlNamespaces = null;
      _config.StylesheetName = "OPCUAModelDesign.xslt";
      return base.Save(false, _config, SetupFileDialog);
    }

    bool IProjectConfigurationManagement.SaveModelDesign(OPCFModelDesign modelDesign)
    {
      m_ModelDesign = modelDesign;
      return this.SaveModelDesign();
    }

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

    #endregion IOPCFModelConfigurationManagement
  }
}