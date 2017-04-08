//<summary>
//  Title   : Project Root TreeNode
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  20090106: mzbrzezny created
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
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

  internal class ProjectTreeNode : WrapperTreeNode
  {

    #region private
    private ProjectWrapper m_ProjectWrapper
    {
      get { return (ProjectWrapper)Wrapper; }
    }
    private ModelDesign m_ModelDesign;
    private OPCFModelConfigurationManagement m_ConfigManager;
    private void m_TSMI_remove_Click(object sender, System.EventArgs e)
    {
      string name = "empty";
      if (m_ProjectWrapper != null && m_ProjectWrapper.Name != null)
        name = m_ProjectWrapper.Name;
      if (MessageBox.Show(
        string.Format(Resources.ProjectTreeNode_AreYouSureToRemove_text, name),
        Resources.ProjectTreeNode_AreYouSureToRemove_caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        Parent.Remove(this);
      }
    }
    private void SetText()
    {
      if (m_ProjectWrapper != null)
        this.Text = "Project: " + m_ProjectWrapper.Name;
      else
        this.Text = "Project";
    }
    private void project_OnNameChanged(object sender, EventArgs e)
    {
      SetText();
    }
    private void InitializeComponent(ModelDesign model)
    {
      m_ModelDesign = model;
      Add(model);
      SetText();
    }
    protected class TreeNode : WrapperTreeNode.TreeNode<ProjectTreeNode>
    {
      public TreeNode(ProjectTreeNode parent)
        : base(parent)
      { }
      #region public
      ///// <summary>
      ///// Validates this instance.
      ///// </summary>
      //public override void Validate()
      //{
      //  Creator.Validate();
      //  base.Validate();
      //}

      #endregion

      #region private
      protected override void BeforeMenuStripOpening()
      {
        ToolStripMenuItem m_TSMI_remove = new ToolStripMenuItem("Remove project", Resources.delete);
        m_TSMI_remove.Click += new System.EventHandler(Creator.m_TSMI_remove_Click);
        //this.ContextMenuStrip = new ContextMenuStrip();
        this.ContextMenuStrip.Items.Add(m_TSMI_remove);
        base.BeforeMenuStripOpening();
      }
      #endregion
    }
    #endregion private

    #region creator
    private ProjectTreeNode(OPCFModelConfigurationManagement cm, ProjectWrapper project, ModelDesign model) :
      base(project)
    {
      m_ConfigManager = cm;
      InitializeComponent(model);
      project.OnNameChanged += new EventHandler(project_OnNameChanged);
    }
    internal ProjectTreeNode(ProjectWrapper project, string NodeName)
      : base(project)
    {
      m_ConfigManager = new OPCFModelConfigurationManagement();
      OPCFModelDesign model = m_ConfigManager.ReadConfiguration(project.FileName);
      InitializeComponent(new ModelDesign(model, false));
      project.OnNameChanged += new EventHandler(project_OnNameChanged);
    }
    #endregion

    #region public
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.ProjectNode; }
    }
    public ModelDesign Model { get { return m_ModelDesign; } }
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
    /// <summary>
    /// Saves the project to the specified directory.
    /// </summary>
    /// <param name="solutionDirectory">The solution directory.</param>
    /// <returns></returns>
    internal bool Save(string solutionDirectory)
    {
      TypeGenericConfigurationManagement<OPCFModelDesign, OPCFModelDesign>.DataToSerialize config;
      config.Data = m_ModelDesign.ModelDesignerNode as OPCFModelDesign;
      config.XmlNamespaces = m_ModelDesign.XmlNamespaces;
      config.StylesheetName = "OPCFModelDesign.xslt";
      m_ProjectWrapper.SetNewSolutionHomeDirectory(solutionDirectory);
      m_ProjectWrapper.ChangeFilenameToAbsolutePath();
      if (String.IsNullOrEmpty(m_ProjectWrapper.FileName))
        m_ProjectWrapper.FileName = m_ProjectWrapper.Name + ".xml";
      m_ConfigManager.DefaultFileName = m_ProjectWrapper.FilePath;
      if (!m_ConfigManager.Save(false, config))
        return false;
      m_ProjectWrapper.FileName = m_ConfigManager.DefaultFileName;
      return true;
    }
    //TODO it could be omitted - it was used to create relative paths, but now all gets create relative paths.
    /// <summary>
    /// Clones the project.
    /// </summary>
    /// <param name="solutionPath">The solution path.</param>
    /// <returns>Copy of the project</returns>
    internal ProjectWrapper CloneProject(string solutionPath)
    {
      return new ProjectWrapper(m_ProjectWrapper, solutionPath);
    }
    /// <summary>
    /// Validates this instance.
    /// </summary>
    public void Validate()
    {
      SetText();
    }
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    internal override DictionaryTreeView.DictionaryTreeNode GetTreeNode()
    {
      return new TreeNode(this);
    }
    /// <summary>
    /// Builds the project and write any massages to specified output.
    /// </summary>
    /// <param name="output">The output containing text sent by the compiler.</param>
    internal void Build(TextWriter output)
    {
      try
      {
        lock (BuildLockObject)
        {
          output.WriteLine(String.Format(Resources.Build_project_name, this.Text));
          output.WriteLine(String.Format(Resources.Build_started_at, System.DateTime.Now.ToString()));
          // some verification at the beginning 
          DirectoryInfo dirinfo = new DirectoryInfo(m_ProjectWrapper.BuildOutputDirectoryPath);
          if (!dirinfo.Exists)
            Directory.CreateDirectory(m_ProjectWrapper.BuildOutputDirectoryPath);
          if (!new FileInfo(m_ProjectWrapper.FilePath).Exists)
          {
            string msg = String.Format(Resources.BuildError_Fie_DoesNotExist, m_ProjectWrapper.FilePath);
            output.WriteLine(msg);
            MessageBox.Show(msg, Resources.Build_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          if (!new FileInfo(m_ProjectWrapper.CSVFilePath).Exists)
          {
            string msg = String.Format(Resources.BuildError_Fie_DoesNotExist_doyouwanttocreateone, m_ProjectWrapper.CSVFilePath);
            if (MessageBox.Show(msg, "Build", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              //we are creating an blank file (one empty line inside)
              StreamWriter myCsvFile = new StreamWriter(m_ProjectWrapper.CSVFilePath, false);
              using (myCsvFile)
              {
                myCsvFile.WriteLine(" ");
                myCsvFile.Flush();
                myCsvFile.Close();
              }
            }
            else
            {
              output.WriteLine(String.Format(Resources.BuildError_Fie_DoesNotExist, m_ProjectWrapper.CSVFilePath));
              return;
            }
          }
          string argument = String.Format(Properties.Settings.Default.Build_ProjectCompilationString, m_ProjectWrapper.FilePath, m_ProjectWrapper.CSVFilePath, m_ProjectWrapper.BuildOutputDirectoryPath);
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

    #region static
    private static object BuildLockObject = new object(); // this object is used to prevent many code generator usage at the same time
    internal static ProjectTreeNode GetProject(bool existing, string solutionPath)
    {
      OPCFModelConfigurationManagement _ConfigurationManagement = new OPCFModelConfigurationManagement();
      ModelDesign _modelDesign = null;
      if (existing)
      {
        _ConfigurationManagement.DefaultFileName = Path.Combine(solutionPath, Resources.DefaultProjectName);
        OPCFModelDesign model = _ConfigurationManagement.ReadConfiguration();
        if (model == null)
          return null;
        _modelDesign = new ModelDesign(model, false);
      }
      else
      {
        _ConfigurationManagement.DefaultFileName = Path.Combine(solutionPath, ProjectWrapper.UniqueProjectName);
        _modelDesign = new ModelDesign() { };
      }
      ProjectWrapper _project = new ProjectWrapper(solutionPath, _ConfigurationManagement.DefaultFileName);
      ProjectTreeNode _ret = new ProjectTreeNode(_ConfigurationManagement, _project, _modelDesign);
      return _ret;
    }
    internal static ProjectTreeNode ImportNodeSet(string solutionPath, Action<TraceMessage> traceEvent)
    {
      try
      {
        OPCFModelConfigurationManagement _ConfigurationManagement = new OPCFModelConfigurationManagement();
        OPCFModelDesign _model = IO.ImportNodeSet.Import(solutionPath, x => _ConfigurationManagement.DefaultFileName = x, traceEvent);
        if (_model == null)
          return null;
        ModelDesign _modelDesign = new ModelDesign(_model, false);
        ProjectWrapper _project = new ProjectWrapper(solutionPath, _ConfigurationManagement.DefaultFileName);
        ProjectTreeNode _ret = new ProjectTreeNode(_ConfigurationManagement, _project, _modelDesign);
        return _ret;
      }
      catch (Exception ex)
      {
        IO.ImportNodeSet.ExceptionHandling(ex, traceEvent);
        return null;
      }
    }
    #endregion

  }

}
