//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.Common;
using CAS.Lib.RTLib.Utils;
using CAS.UA.Model.Designer.Controls;
using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Solution;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using UAOOI.SemanticData.UANodeSetValidation;
using OPCFModelDesign = Opc.Ua.ModelCompiler.ModelDesign;

namespace CAS.UA.Model.Designer.Wrappers
{
  interface IProjectModel : IBaseModel
  {
    string Name { get; }
    void Remove();
  }
  internal class ProjectTreeNode : WrapperTreeNode, IProjectModel
  {

    #region private
    //var
    private static object m_BuildLockObject = new object(); // this object is used to prevent many code generator usage at the same time
    private static UniqueNameGenerator m_UniqueNameGenerator = new UniqueNameGenerator(Resources.DefaultProjectName);
    private IBaseDirectoryProvider m_SolutionHomeDirectory;
    private ModelDesign m_ModelDesign;
    private UAModelDesignerProject b_UAModelDesignerProject;

    //methods
    internal UAModelDesignerProject UAModelDesignerProject
    {
      get
      {
        b_UAModelDesignerProject.Name = this.Text;
        return b_UAModelDesignerProject;
      }
      set
      {
        b_UAModelDesignerProject = value;
        this.Text = b_UAModelDesignerProject.Name;
      }
    }
    private ModelDesign ReadConfiguration()
    {
      FileInfo info = new FileInfo(FilePath);
      if (!info.Exists)
        throw new FileNotFoundException(FilePath);
      Opc.Ua.ModelCompiler.ModelDesign _ModelDesign = XmlFile.ReadXmlFile<Opc.Ua.ModelCompiler.ModelDesign>(FilePath);
      return new ModelDesign(_ModelDesign, false);
    }
    private string GetRelativePath(string fileName)
    {
      if (!string.IsNullOrEmpty(m_SolutionHomeDirectory.GetBaseDirectory()) && !string.IsNullOrEmpty(fileName))
      {
        Directory.SetCurrentDirectory(m_SolutionHomeDirectory.GetBaseDirectory());
        string _fullPath = Path.GetFullPath(fileName);
        fileName = RelativeFilePathsCalculator.TryComputeRelativePath(m_SolutionHomeDirectory.GetBaseDirectory(), _fullPath);
      }
      return fileName;
    }
    private void InitializeComponent(ModelDesign model)
    {
      m_ModelDesign = model;
      Add(model);
    }
    private string ReplaceTokenAndReturnFullPath(string nameToBeReturned)
    {
      string myName = nameToBeReturned.Replace(Resources.Token_ProjectFileName, Path.GetFileNameWithoutExtension(FileName));
      if (RelativeFilePathsCalculator.TestIfPathIsAbsolute(myName))
        return myName;
      string directory = Path.GetDirectoryName(FilePath);
      return Path.Combine(directory, myName);
    }

    ////Types
    //protected class TreeNode : WrapperTreeNode.TreeNode<ProjectTreeNode>
    //{
    //  public TreeNode(ProjectTreeNode parent)
    //    : base(parent)
    //  { }

    //  #region public
    //  ///// <summary>
    //  ///// Validates this instance.
    //  ///// </summary>
    //  //public override void Validate()
    //  //{
    //  //  Creator.Validate();
    //  //  base.Validate();
    //  //}

    //  #endregion

    //  #region private
    //  protected override void BeforeMenuStripOpening()
    //  {
    //    ToolStripMenuItem m_TSMI_remove = new ToolStripMenuItem("Remove project", Resources.delete);
    //    m_TSMI_remove.Click += new System.EventHandler(m_TSMI_remove_Click);
    //    //this.ContextMenuStrip = new ContextMenuStrip();
    //    this.ContextMenuStrip.Items.Add(m_TSMI_remove);
    //    base.BeforeMenuStripOpening();
    //  }
    //  private void m_TSMI_remove_Click(object sender, EventArgs e)
    //  {
    //    string name = Creator.Name;
    //    if (MessageBox.Show(string.Format(Resources.ProjectTreeNode_AreYouSureToRemove_text, name), Resources.ProjectTreeNode_AreYouSureToRemove_caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
    //      Creator.Remove();
    //  }
    //  #endregion
    //}
    #endregion private

    #region constructors
    internal ProjectTreeNode(IBaseDirectoryProvider solutionPath, string filePath, OPCFModelDesign model) :
      this(solutionPath, Path.GetFileNameWithoutExtension(filePath))
    {
      UAModelDesignerProject = new UAModelDesignerProject()
      {
        BuildOutputDirectoryName = Resources.DefaultOutputBuildDirectory,
        CSVFileName = Resources.DefaultCSVFileName,
        FileName = GetRelativePath(filePath),
        ProjectIdentifier = Guid.NewGuid().ToString()
      };
      InitializeComponent(new ModelDesign(model, false));
    }
    internal ProjectTreeNode(IBaseDirectoryProvider solutionPath, UAModelDesignerProject projectDescription)
      : this(solutionPath, projectDescription.Name)
    {
      UAModelDesignerProject = projectDescription;
      ModelDesign _model = ReadConfiguration();
      InitializeComponent(_model);
    }
    private ProjectTreeNode(IBaseDirectoryProvider solutionPath, string nodeName) : base(null, nodeName)
    {
      m_SolutionHomeDirectory = solutionPath;
    }
    #endregion

    #region override WrapperTreeNode
    public  override object Wrapper
    {
      get
      {
        return this.Create();
      }
    }
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.ProjectNode; }
    }
    public override Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> GetFolders()
    {
      Dictionary<FolderType, IEnumerable<IModelNodeAdvance>> tobereturned = base.GetFolders();
      tobereturned.Add(FolderType.Model, Model);
      return tobereturned;
    }
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.ProjectTreeNode; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.None; }
    }
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      throw new NotImplementedException();
    }
    #endregion

    #region public
    /// <summary>
    /// Gets or sets the name of the file.
    /// </summary>
    /// <value>The name of the file.</value>
    internal string FileName
    {
      get
      {
        string _ret = GetRelativePath(UAModelDesignerProject.FileName);
        if (String.IsNullOrEmpty(_ret))
          _ret = $"{Name}.xml";
        return _ret;
      }
      set
      {
        UAModelDesignerProject.FileName = value;
      }
    }
    internal string FilePath
    {
      get
      {
        if (RelativeFilePathsCalculator.TestIfPathIsAbsolute(FileName) || (string.IsNullOrEmpty(m_SolutionHomeDirectory.GetBaseDirectory())))
          return FileName;
        return Path.GetFullPath(Path.Combine(this.m_SolutionHomeDirectory.GetBaseDirectory(), this.FileName));
      }
    }

    internal ProjectTreeNode CloneProject()
    {
      throw new NotImplementedException();
    }

    internal string CSVFileName
    {
      get
      {
        if (string.IsNullOrEmpty(UAModelDesignerProject.CSVFileName))
          UAModelDesignerProject.CSVFileName = Resources.DefaultCSVFileName;
        return UAModelDesignerProject.CSVFileName;
      }
      set
      {
        UAModelDesignerProject.CSVFileName = value;
      }
    }
    internal string CSVFilePath
    {
      get
      {
        return ReplaceTokenAndReturnFullPath(CSVFileName);
      }
    }
    internal Guid ProjectIdentifier
    {
      get { return new Guid(UAModelDesignerProject.ProjectIdentifier); }
      set { UAModelDesignerProject.ProjectIdentifier = value.ToString(); }
    }
    internal string BuildOutputDirectoryName
    {
      get
      {
        if (string.IsNullOrEmpty(UAModelDesignerProject.BuildOutputDirectoryName))
          UAModelDesignerProject.BuildOutputDirectoryName = Resources.DefaultOutputBuildDirectory;
        return UAModelDesignerProject.BuildOutputDirectoryName;
      }
      set
      {
        UAModelDesignerProject.BuildOutputDirectoryName = value;
      }
    }
    internal string BuildOutputDirectoryPath
    {
      get
      {
        return ReplaceTokenAndReturnFullPath(BuildOutputDirectoryName);
      }
    }
    [Obsolete]
    internal void SetNewSolutionHomeDirectory(string newPath) { }
    internal bool SaveModel(string solutionDirectory, XmlFile.DataToSerialize<Opc.Ua.ModelCompiler.ModelDesign> config)
    {
      return m_ModelDesign.SaveModel(FilePath);
      //m_OPCFModelConfigurationManagement.DefaultFileName = FilePath;
      //if (!m_OPCFModelConfigurationManagement.Save(false, config))
      //  return false;
      //FileName = m_OPCFModelConfigurationManagement.DefaultFileName;
      //return true;
    }
    internal ModelDesign Model { get { return m_ModelDesign; } }
    /// <summary>
    /// Saves the project to the specified directory.
    /// </summary>
    /// <param name="solutionDirectory">The solution directory.</param>
    /// <returns></returns>
    internal bool Save()
    {
      return m_ModelDesign.SaveModel(FilePath);
    }
    //TODO it could be omitted - it was used to create relative paths, but now all gets create relative paths.
    /// <summary>
    /// Clones the project.
    /// </summary>
    /// <param name="solutionPath">The solution path.</param>
    /// <returns>Copy of the project</returns>
    //internal ProjectWrapper CloneProject(string solutionPath)
    //{
    //  return new ProjectWrapper(m_ProjectViewModel, solutionPath);
    //}
    /// <summary>
    /// Validates this instance.
    /// </summary>
    public void Validate() { }
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
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
          output.WriteLine(String.Format(Resources.Build_project_name, this.Text));
          output.WriteLine(String.Format(Resources.Build_started_at, System.DateTime.Now.ToString()));
          // some verification at the beginning 
          DirectoryInfo dirinfo = new DirectoryInfo(BuildOutputDirectoryPath);
          if (!dirinfo.Exists)
            Directory.CreateDirectory(BuildOutputDirectoryPath);
          if (!new FileInfo(FilePath).Exists)
          {
            string msg = String.Format(Resources.BuildError_Fie_DoesNotExist, FilePath);
            output.WriteLine(msg);
            MessageBox.Show(msg, Resources.Build_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          if (!new FileInfo(CSVFilePath).Exists)
          {
            string msg = String.Format(Resources.BuildError_Fie_DoesNotExist_doyouwanttocreateone, CSVFilePath);
            if (MessageBox.Show(msg, "Build", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
              output.WriteLine(String.Format(Resources.BuildError_Fie_DoesNotExist, CSVFilePath));
              return;
            }
          }
          string argument = String.Format(Properties.Settings.Default.Build_ProjectCompilationString, FilePath, CSVFilePath, BuildOutputDirectoryPath);
          string CompilationExecutable = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Properties.Settings.Default.ProjectCompilationExecutable);
          ProcessStartInfo myStartInfo = new System.Diagnostics.ProcessStartInfo(CompilationExecutable);
          myStartInfo.Arguments = argument;
          myStartInfo.RedirectStandardOutput = true;
          myStartInfo.RedirectStandardError = true;
          myStartInfo.UseShellExecute = false;
          myStartInfo.CreateNoWindow = true;
          output.WriteLine();
          output.Write(CompilationExecutable);
          output.Write(" ");
          output.WriteLine(argument);
          output.WriteLine();
          Process myBuildProcess = new Process();
          myBuildProcess.StartInfo = myStartInfo;
          if (!myBuildProcess.Start())
            MessageBox.Show(Resources.Build_click_ok_when_build_has_finished);
          else
          {
            myBuildProcess.WaitForExit();
            string outputfrombuildprocess = myBuildProcess.StandardOutput.ReadToEnd();
            string erroroutputfrombuildprocess = myBuildProcess.StandardError.ReadToEnd();
            if (!String.IsNullOrEmpty(erroroutputfrombuildprocess))
            {
              erroroutputfrombuildprocess = String.Format(Resources.BuildError_error_occured, erroroutputfrombuildprocess);
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
        output.WriteLine(String.Format(Resources.Build_ended_at, System.DateTime.Now.ToString()));
        output.WriteLine();
        // it is also possible in the future to use Opc.Ua.ModelCompiler.ModelGenerator2 gen = new Opc.Ua.ModelCompiler.ModelGenerator2();
        // or it can be done as: C:\vs\UAtrunk\Source\Utilities\ModelDesigner\Program.cs, function ProcessCommandLine2
      }
      catch (Exception ex)
      {
        output.WriteLine(Resources.BuildError_nocontinuation + "\n\r" + ex.Message, "Build", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
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
    #endregion

    #region IProjectModel
    public void Remove()
    {
      Parent.Remove(this);
    }
    #endregion

    #region static
    internal static ProjectTreeNode ImportNodeSet
      (IBaseDirectoryProvider solutionPathProvider, Action<TraceMessage> traceEvent, Func<string, Action<TraceMessage>, Tuple<OPCFModelDesign, string>> importNodeSet)
    {
      Tuple<OPCFModelDesign, string> _model = importNodeSet(solutionPathProvider.GetBaseDirectory(), traceEvent);
      if (_model == null)
        return null;
      return new ProjectTreeNode(solutionPathProvider, _model.Item2, _model.Item1);
    }
    internal static ProjectTreeNode CreateNewModel(IBaseDirectoryProvider solutionPathProvider)
    {
      string _DefaultFileName = Path.Combine(solutionPathProvider.GetBaseDirectory(), UniqueProjectName);
      return new ProjectTreeNode(solutionPathProvider, _DefaultFileName, new OPCFModelDesign());
    }
    internal static string UniqueProjectName { get { return m_UniqueNameGenerator.GenerateNewName(); } }
    #endregion

  }

}
