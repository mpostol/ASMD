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
  internal interface IOPCFModelConfigurationManagement
  {
    UAModelDesignerProject UAModelDesignerProject { get; }
    OPCFModelDesign ModelDesign { get; }
    string Name { get; }

    bool SaveModelDesign();

    void ReadModelDesign();
    string CalculateEffectiveAbsoluteModelFilePath();
    void SaveModelDesign(XmlFile.DataToSerialize<OPCFModelDesign> modelDesign);
    void Build(TextWriter output);
  }

  /// <summary>
  /// Class to save and restore UA Information Model to/from external file.
  /// </summary>
  internal class OPCFModelConfigurationManagement : TypeGenericConfigurationManagement<OPCFModelDesign>, IOPCFModelConfigurationManagement
  {
    #region private
    private const string m_ModelExtension = ".xml";

    private readonly UAModelDesignerProject m_UAModelDesignerProject;
    private readonly ISolutionConfigurationManagement m_ISolutionConfigurationManagement;
    private OPCFModelDesign m_ModelDesign;

    /// <summary>
    /// Gets the type of the configuration.
    /// </summary>
    /// <value>The type of the configuration defined in <see cref="ConfigurationType" />.</value>
    protected override ConfigurationType Configuration => ConfigurationType.Project;

    /// <summary>
    /// Gets the configuration.
    /// </summary>
    /// <value>The configuration .</value>
    /// <remarks>Not implemented in this class</remarks>
    protected override XmlFile.DataToSerialize<OPCFModelDesign> GetConfiguration(OPCFModelDesign configuration)
    {
      throw new NotImplementedException();
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
    /// <summary>
    /// Gets or sets the model file name.
    /// </summary>
    /// <value>The name of the file.</value>
    internal string FileName
    {
      get
      {
        if (!Path.HasExtension(m_UAModelDesignerProject.FileName))
          return Path.ChangeExtension(m_UAModelDesignerProject.FileName, m_ModelExtension);
        else
          return m_UAModelDesignerProject.FileName;
      }
    }

    internal string CSVFileName
    {
      get
      {
        if (string.IsNullOrEmpty(m_UAModelDesignerProject.CSVFileName))
          m_UAModelDesignerProject.CSVFileName = Resources.DefaultCSVFileName;
        return m_UAModelDesignerProject.CSVFileName;
      }
      set => m_UAModelDesignerProject.CSVFileName = value;
    }

    internal string CSVFilePath => ReplaceTokenAndReturnFullPath(CSVFileName, m_UAModelDesignerProject.Name, m_ISolutionConfigurationManagement.SolutionDirectoryPathManagement.BaseDirectory);

    internal Guid ProjectIdentifier
    {
      get => new Guid(m_UAModelDesignerProject.ProjectIdentifier);
      set => m_UAModelDesignerProject.ProjectIdentifier = value.ToString();
    }

    internal string BuildOutputDirectoryName
    {
      get
      {
        if (string.IsNullOrEmpty(m_UAModelDesignerProject.BuildOutputDirectoryName))
          m_UAModelDesignerProject.BuildOutputDirectoryName = Resources.DefaultOutputBuildDirectory;
        return m_UAModelDesignerProject.BuildOutputDirectoryName;
      }
      set => m_UAModelDesignerProject.BuildOutputDirectoryName = value;
    }

    internal string BuildOutputDirectoryPath => ReplaceTokenAndReturnFullPath(BuildOutputDirectoryName, m_UAModelDesignerProject.Name, m_ISolutionConfigurationManagement.SolutionDirectoryPathManagement.BaseDirectory);

    #endregion private 

    #region constructor

    internal OPCFModelConfigurationManagement(ISolutionConfigurationManagement solution, IGraphicalUserInterface graphicalUserInterface, UAModelDesignerProject uaModelDesignerProject) :
      base(graphicalUserInterface, uaModelDesignerProject.Name)
    {
      m_UAModelDesignerProject = uaModelDesignerProject ?? throw new ArgumentNullException(nameof(uaModelDesignerProject));
      m_ISolutionConfigurationManagement = solution ?? throw new ArgumentNullException(nameof(solution));
      solution.SolutionDirectoryPathManagement.BaseDirectoryPathChanged += SolutionHomeDirectoryBaseDirectoryPathChanged;
    }

    public OPCFModelConfigurationManagement(ISolutionConfigurationManagement solution, IGraphicalUserInterface graphicalUserInterface, string Name, OPCFModelDesign modelDesign) : base(graphicalUserInterface, Name)
    {
      this.m_ModelDesign = modelDesign;
      this.m_ISolutionConfigurationManagement = solution ?? throw new ArgumentNullException(nameof(solution));
      this.m_ModelDesign = modelDesign;
      solution.SolutionDirectoryPathManagement.BaseDirectoryPathChanged += SolutionHomeDirectoryBaseDirectoryPathChanged;
    }

    internal static IOPCFModelConfigurationManagement ImportNodeSet(ISolutionConfigurationManagement solution, IGraphicalUserInterface graphicalUserInterface, Action<TraceMessage> traceEvent)
    {
      Tuple<OPCFModelDesign, string> _model = IO.ImportNodeSet.Import(solution.SolutionDirectoryPathManagement.BaseDirectory, traceEvent);
      if (_model == null)
        return null;
      return new OPCFModelConfigurationManagement(solution, graphicalUserInterface, _model.Item2, _model.Item1);
    }
    /// <summary>
    /// Creates new model encapsulated by instance of this class
    /// </summary>
    /// <param name="solution">The solution description.</param>
    /// <param name="graphicalUserInterface">The graphical user interface.</param>
    /// <param name="projectName">Name of the project.</param>
    /// <returns><see cref="IOPCFModelConfigurationManagement"/>.</returns>
    internal static IOPCFModelConfigurationManagement CreateNew(ISolutionConfigurationManagement solution, IGraphicalUserInterface graphicalUserInterface, string projectName)
    {
      UAModelDesignerProject _projectDescription = new UAModelDesignerProject()
      {
        BuildOutputDirectoryName = Resources.DefaultOutputBuildDirectory,
        CSVFileName = Resources.DefaultCSVFileName,
        FileName = RelativeFilePathsCalculator.TryComputeRelativePath(solution.SolutionDirectoryPathManagement.BaseDirectory, projectName),
        ProjectIdentifier = Guid.NewGuid().ToString(),
        Name = projectName
      };
      return new OPCFModelConfigurationManagement(solution, graphicalUserInterface, projectName, new OPCFModelDesign());
    }
    #endregion constructor

    #region IOPCFModelConfigurationManagement

    OPCFModelDesign IOPCFModelConfigurationManagement.ModelDesign => m_ModelDesign;

    void IOPCFModelConfigurationManagement.ReadModelDesign()
    {
      m_ModelDesign = this.ReadConfiguration();
    }

    UAModelDesignerProject IOPCFModelConfigurationManagement.UAModelDesignerProject { get; }

    string IOPCFModelConfigurationManagement.Name => this.m_UAModelDesignerProject.Name;

    bool IOPCFModelConfigurationManagement.SaveModelDesign()
    {
      return base.Save(false, m_ModelDesign);
    }

    internal static IOPCFModelConfigurationManagement ImportModelDesign(OPCFSolutionConfigurationManagement oPCFSolutionConfigurationManagement, IGraphicalUserInterface graphicalUserInterface, UAModelDesignerProject x)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Calculates the effective absolute model file path.
    /// </summary>
    /// <returns>System.String.</returns>
    public string CalculateEffectiveAbsoluteModelFilePath()
    {
      return RelativeFilePathsCalculator.CalculateAbsoluteFileName(this.FileName, this.m_ISolutionConfigurationManagement.SolutionDirectoryPathManagement.BaseDirectory);
    }

    string IOPCFModelConfigurationManagement.CalculateEffectiveAbsoluteModelFilePath()
    {
      throw new NotImplementedException();
    }

    void IOPCFModelConfigurationManagement.SaveModelDesign(XmlFile.DataToSerialize<OPCFModelDesign> modelDesign)
    {
      string _filePath = CalculateEffectiveAbsoluteModelFilePath();
      XmlFile.WriteXmlFile<OPCFModelDesign>(modelDesign, _filePath, FileMode.Create);
    }
    /// <summary>
    /// Builds the project and write any massages to specified output.
    /// </summary>
    /// <param name="output">The output containing text sent by the compiler.</param>
    void IOPCFModelConfigurationManagement.Build(TextWriter output)
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