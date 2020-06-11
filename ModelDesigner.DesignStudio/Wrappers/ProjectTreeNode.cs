//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.ToForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml;
using UAOOI.SemanticData.UANodeSetValidation;
using OPCFModelDesign = Opc.Ua.ModelCompiler.ModelDesign;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal interface IProjectModel : IBaseModel
  {
    string Name { get; }

    void Remove();
  }

  internal class ProjectTreeNode : WrapperTreeNode, IProjectModel
  {
    #region private

    //constants
    //private const string m_ModelExtension = ".xml";

    //var
    private static readonly object m_BuildLockObject = new object(); // this object is used to prevent many code generator usage at the same time

    //private readonly ISolutionDirectoryPathManagement m_SolutionHomeDirectory;
    private readonly IOPCFModelConfigurationManagement m_ProjectConfigurationManager;
    private IOPCFModelConfigurationManagement b_UAModelDesignerProject;
    //private static string m_GetNextUniqueProjectName => m_UniqueNameGenerator.GenerateNewName();

    private void InitializeComponent(ModelDesign model)
    {
      Model = model;
      Add(model);
    }

    //private static string ReplaceTokenAndReturnFullPath(string fileNameToBeProcessed, string projectName, string solutionDirectory)
    //{
    //  string _Name = fileNameToBeProcessed.Replace(Resources.Token_ProjectFileName, projectName);
    //  return RelativeFilePathsCalculator.CalculateAbsoluteFileName(_Name, solutionDirectory);
    //}

    //private void SolutionHomeDirectoryBaseDirectoryPathChanged(object sender, NewDirectoryPathEventArgs e)
    //{
    //  string _oldAbsoluteFilePath = RelativeFilePathsCalculator.CalculateAbsoluteFileName(this.UAModelDesignerProject.FileName, e.OldDirectoryPath);
    //  string _newAbsoluteFilePath = RelativeFilePathsCalculator.CalculateAbsoluteFileName(this.UAModelDesignerProject.FileName, e.NewDirectoryPath);
    //  this.UAModelDesignerProject.FileName = RelativeFilePathsCalculator.TryComputeRelativePath(_newAbsoluteFilePath, _oldAbsoluteFilePath);
    //}

    #endregion private

    #region constructors

    private ProjectTreeNode(IOPCFModelConfigurationManagement projectConfigurationManager, string nodeName) : base(null, projectConfigurationManager.Name)
    {
      m_ProjectConfigurationManager = projectConfigurationManager;
      //m_SolutionHomeDirectory = solutionPath;
      //m_SolutionHomeDirectory.BaseDirectoryPathChanged += SolutionHomeDirectoryBaseDirectoryPathChanged;
    }

    private ProjectTreeNode(IOPCFModelConfigurationManagement projectConfigurationManager, string filePath, OPCFModelDesign model) : this(projectConfigurationManager, Path.GetFileNameWithoutExtension(filePath))
    {
      //UAModelDesignerProject = new UAModelDesignerProject()
      //{
      //  BuildOutputDirectoryName = Resources.DefaultOutputBuildDirectory,
      //  CSVFileName = Resources.DefaultCSVFileName,
      //  FileName = RelativeFilePathsCalculator.TryComputeRelativePath(solutionPath.BaseDirectory, filePath),
      //  ProjectIdentifier = Guid.NewGuid().ToString(),
      //  Name = m_GetNextUniqueProjectName
      //};
      InitializeComponent(new ModelDesign(model, false));
    }
    private IOPCFModelConfigurationManagement m_UAModelDesignerProject = null;
    /// <summary>
    /// Initializes a new instance of the <see cref="ProjectTreeNode"/> encapsulating an existing UA model.
    /// </summary>
    /// <param name="solutionPath">The solution path.</param>
    /// <param name="projectDescription">The project description.</param>
    internal ProjectTreeNode(IOPCFModelConfigurationManagement projectDescription) : this(projectDescription, projectDescription.Name)
    {
      m_UAModelDesignerProject = projectDescription;
      ModelDesign _RootOfOPCUAInfromationModel = ModelDesign.CreateRootOfOPCUAInfromationModel(m_ProjectConfigurationManager.CalculateEffectiveAbsoluteModelFilePath());
      InitializeComponent(_RootOfOPCUAInfromationModel);
    }

    ///// <summary>
    ///// Imports the UANodeSet encapsulated by a new project.
    ///// </summary>
    ///// <param name="solutionPathProvider">The solution path provider.</param>
    ///// <param name="traceEvent">The trace event.</param>
    ///// <param name="importNodeSet">The import node set.</param>
    ///// <returns>ProjectTreeNode.</returns>
    //internal static ProjectTreeNode ImportNodeSet(ISolutionDirectoryPathManagement solutionPathProvider, Action<TraceMessage> traceEvent, Func<string, Action<TraceMessage>, Tuple<OPCFModelDesign, string>> importNodeSet)
    //{
    //  Tuple<OPCFModelDesign, string> _model = importNodeSet(solutionPathProvider.BaseDirectory, traceEvent);
    //  if (_model == null)
    //    return null;
    //  return new ProjectTreeNode(solutionPathProvider, _model.Item2, _model.Item1);
    //}

    ///// <summary>
    ///// Creates new model encapsulated by a new project.
    ///// </summary>
    ///// <param name="solutionPathProvider">The solution path provider.</param>
    ///// <returns>ProjectTreeNode.</returns>
    //internal static ProjectTreeNode CreateNewModel(ISolutionDirectoryPathManagement solutionPathProvider)
    //{
    //  return new ProjectTreeNode(solutionPathProvider, m_GetNextUniqueProjectName, new OPCFModelDesign());
    //}

    #endregion constructors

    #region WrapperTreeNode

    public override object Wrapper => this.Create();
    public override NodeTypeEnum NodeType => NodeTypeEnum.ProjectNode;

    public override Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> GetFolders()
    {
      Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> toBeReturned = base.GetFolders();
      toBeReturned.Add(FolderType.Model, Model);
      return toBeReturned;
    }

    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName => Resources.ProjectTreeNode;

    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass => NodeClassesEnum.None;

    #endregion WrapperTreeNode

    #region public

    //is used only in UT
    //internal IOPCFModelConfigurationManagement UAModelDesignerProject
    //{
    //  get
    //  {
    //    m_UAModelDesignerProject.Name = this.Text;
    //    return m_UAModelDesignerProject;
    //  }
    //  private set
    //  {
    //    b_UAModelDesignerProject = value;
    //    this.Text = m_UAModelDesignerProject.Name;
    //  }
    //}

    ///// <summary>
    ///// Gets or sets the model file name.
    ///// </summary>
    ///// <value>The name of the file.</value>
    //internal string FileName
    //{
    //  get
    //  {
    //    if (!Path.HasExtension(m_UAModelDesignerProject.FileName))
    //      return $"{m_UAModelDesignerProject.FileName}.{m_ModelExtension}";
    //    else
    //      return m_UAModelDesignerProject.FileName;
    //  }
    //}

    ///// <summary>
    ///// Calculates the effective absolute model file path.
    ///// </summary>
    ///// <returns>System.String.</returns>
    //internal string CalculateEffectiveAbsoluteModelFilePath()
    //{
    //  return RelativeFilePathsCalculator.CalculateAbsoluteFileName(this.FileName, m_SolutionHomeDirectory.BaseDirectory);
    //}

    //internal string CSVFileName
    //{
    //  get
    //  {
    //    if (string.IsNullOrEmpty(m_UAModelDesignerProject.CSVFileName))
    //      m_UAModelDesignerProject.CSVFileName = Resources.DefaultCSVFileName;
    //    return m_UAModelDesignerProject.CSVFileName;
    //  }
    //  set => m_UAModelDesignerProject.CSVFileName = value;
    //}

    //internal string CSVFilePath => ReplaceTokenAndReturnFullPath(CSVFileName, m_UAModelDesignerProject.Name, m_SolutionHomeDirectory.BaseDirectory);

    //internal Guid ProjectIdentifier
    //{
    //  get => new Guid(m_UAModelDesignerProject.ProjectIdentifier);
    //  set => m_UAModelDesignerProject.ProjectIdentifier = value.ToString();
    //}

    //internal string BuildOutputDirectoryName
    //{
    //  get
    //  {
    //    if (string.IsNullOrEmpty(m_UAModelDesignerProject.BuildOutputDirectoryName))
    //      m_UAModelDesignerProject.BuildOutputDirectoryName = Resources.DefaultOutputBuildDirectory;
    //    return m_UAModelDesignerProject.BuildOutputDirectoryName;
    //  }
    //  set => m_UAModelDesignerProject.BuildOutputDirectoryName = value;
    //}

    //internal string BuildOutputDirectoryPath => ReplaceTokenAndReturnFullPath(BuildOutputDirectoryName, m_UAModelDesignerProject.Name, m_SolutionHomeDirectory.BaseDirectory);

    internal ModelDesign Model { get; private set; }

    /// <summary>
    /// Saves the project to the specified directory.
    /// </summary>
    /// <param name="solutionDirectory">The solution directory.</param>
    /// <returns></returns>
    internal bool Save()
    {
      XmlFile.DataToSerialize < OPCFModelDesign > _modelDesign = Model.GetModel();
      m_ProjectConfigurationManager.SaveModelDesign(_modelDesign);
      return true;
    }

    /// <summary>
    /// Builds the project and write any massages to specified output.
    /// </summary>
    /// <param name="output">The output containing text sent by the compiler.</param>
    internal void Build(TextWriter output)
    {
      try
      {
        lock (m_BuildLockObject)
        {
          output.WriteLine(string.Format(Resources.Build_project_name, this.Text));
          output.WriteLine(string.Format(Resources.Build_started_at, System.DateTime.Now.ToString()));
          m_ProjectConfigurationManager.Build(output);
          //// some verification at the beginning
          //DirectoryInfo dirinfo = new DirectoryInfo(BuildOutputDirectoryPath);
          //if (!dirinfo.Exists)
          //  Directory.CreateDirectory(BuildOutputDirectoryPath);
          //string _filePath = CalculateEffectiveAbsoluteModelFilePath();
          //if (!new FileInfo(_filePath).Exists)
          //{
          //  string msg = string.Format(Resources.BuildError_Fie_DoesNotExist, _filePath);
          //  output.WriteLine(msg);
          //  this.MessageBoxHandling.Show(msg, Resources.Build_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  return;
          //}
          //if (!new FileInfo(CSVFilePath).Exists)
          //{
          //  string msg = string.Format(Resources.BuildError_Fie_DoesNotExist_doyouwanttocreateone, CSVFilePath);
          //  if (this.MessageBoxHandling.Show(msg, "Build", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          //  {
          //    //we are creating an blank file (one empty line inside)
          //    StreamWriter myCsvFile = new StreamWriter(CSVFilePath, false);
          //    using (myCsvFile)
          //    {
          //      myCsvFile.WriteLine(" ");
          //      myCsvFile.Flush();
          //      myCsvFile.Close();
          //    }
          //  }
          //  else
          //  {
          //    output.WriteLine(string.Format(Resources.BuildError_Fie_DoesNotExist, CSVFilePath));
          //    return;
          //  }
          //}
          //string argument = string.Format(Properties.Settings.Default.Build_ProjectCompilationString, _filePath, CSVFilePath, BuildOutputDirectoryPath);
          //string CompilationExecutable = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Properties.Settings.Default.ProjectCompilationExecutable);
          //ProcessStartInfo myStartInfo = new System.Diagnostics.ProcessStartInfo(CompilationExecutable)
          //{
          //  Arguments = argument,
          //  RedirectStandardOutput = true,
          //  RedirectStandardError = true,
          //  UseShellExecute = false,
          //  CreateNoWindow = true
          //};
          //output.WriteLine();
          //output.Write(CompilationExecutable);
          //output.Write(" ");
          //output.WriteLine(argument);
          //output.WriteLine();
          //Process myBuildProcess = new Process
          //{
          //  StartInfo = myStartInfo
          //};
          //if (!myBuildProcess.Start())
          //  this.MessageBoxHandling.Show(Resources.Build_click_ok_when_build_has_finished);
          //else
          //{
          //  myBuildProcess.WaitForExit();
          //  string outputfrombuildprocess = myBuildProcess.StandardOutput.ReadToEnd();
          //  string erroroutputfrombuildprocess = myBuildProcess.StandardError.ReadToEnd();
          //  if (!string.IsNullOrEmpty(erroroutputfrombuildprocess))
          //  {
          //    erroroutputfrombuildprocess = string.Format(Resources.BuildError_error_occured, erroroutputfrombuildprocess);
          //  }
          //  else
          //  {
          //    erroroutputfrombuildprocess = Resources.Build_project_ok;
          //  }
          //  outputfrombuildprocess += erroroutputfrombuildprocess;
          //  if (!string.IsNullOrEmpty(outputfrombuildprocess))
          //    output.WriteLine(outputfrombuildprocess);
        }
        output.WriteLine(string.Format(Resources.Build_ended_at, System.DateTime.Now.ToString()));
        output.WriteLine();
        // it is also possible in the future to use Opc.Ua.ModelCompiler.ModelGenerator2 gen = new Opc.Ua.ModelCompiler.ModelGenerator2();
        // or it can be done as: C:\vs\UAtrunk\Source\Utilities\ModelDesigner\Program.cs, function ProcessCommandLine2
      }
      catch (Exception ex)
      {
        output.WriteLine(Resources.BuildError_nocontinuation + "\n\r" + ex.Message, "Build", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    internal static ProjectTreeNode ImportNodeSet(ISolutionConfigurationManagement m_ISolutionConfigurationManagement, Action<TraceMessage> p)
    {
      throw new NotImplementedException();
    }

    internal void AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      foreach (ModelDesign item in this)
        item.AddNode2AddressSpace(space);
    }

    internal ITypeDesign Find(XmlQualifiedName myType)
    {
      foreach (ModelDesign node in this)
      {
        ITypeDesign ret = node.FindType(myType);
        if (ret != null)
          return ret;
      }
      return null;
    }

    #endregion public

    #region IProjectModel

    public void Remove()
    {
      Parent.Remove(this);
    }

    #endregion IProjectModel
  }
}