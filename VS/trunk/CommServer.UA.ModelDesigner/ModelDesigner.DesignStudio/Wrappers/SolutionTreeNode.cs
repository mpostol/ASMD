﻿//<summary>
//  Title   : Solution Root TreeNode
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using CAS.UA.Common;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using CAS.UA.IServerConfiguration;

namespace CAS.UA.Model.Designer.Wrappers
{
  /// <summary>
  /// The class representing the solution node in the model.
  /// </summary>
  internal abstract class SolutionTreeNode : WrapperTreeNode
  {
    #region private
    private void configuration_OnNameChanged(object sender, EventArgs e)
    {
      SetText();
    }
    private void SetText()
    {
      if (Configuration != null)
        this.Text = "Solution: " + Configuration.Name;
      else
        this.Text = "Solution";
    }
    private UAModelDesignerSolution Configuration
    {
      get { return (UAModelDesignerSolution)Wrapper; }
    }
    private void AddProjectsNodes(UAModelDesignerSolution configuration)
    {
      if (configuration.Projects == null || configuration.Projects.Length == 0)
        return;
      List<ProjectTreeNode> nodes = new List<ProjectTreeNode>(configuration.Projects.Length);
      foreach (ProjectWrapper proj in configuration.Projects)
      {
        proj.SetNewSolutionHomeDirectory(configuration.HomeDirectory);
        ProjectTreeNode project = null;
        try
        {
          project = new ProjectTreeNode(proj, proj.Name);
        }
        catch (FileNotFoundException fnfe)
        {
          MessageBox.Show(String.Format(Resources.ProjectFileNotFound_Info, fnfe.Message), Resources.ProjectFileNotFound_Header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
          System.Windows.Forms.MessageBox.Show
            (
              String.Format(Properties.Resources.Project_FileOpenError, ex.Message),
              Properties.Resources.Project_OpenFileCaption,
              System.Windows.Forms.MessageBoxButtons.OK,
              System.Windows.Forms.MessageBoxIcon.Error
            );
        }
        if (project != null)
          nodes.Add(project);
      }
      foreach (var node in nodes)
        Add(node);
    }
    private EventHandler m_OnChangeHandler = null;
    protected override void CreateInstanceConfigurations(BaseTreeNode node, bool SkipOpeningConfigurationFile, out bool CancelWasPressed)
    {
      IConfiguration svr = Configuration.Server.GetIServerConfiguration();
      if (svr == null)
      {
        CancelWasPressed = SkipOpeningConfigurationFile;
        return;
      }
      INodeDescriptor[] dscriptors = node.GetNodeDescriptors();
      svr.CreateInstanceConfigurations(dscriptors, SkipOpeningConfigurationFile, out CancelWasPressed);
    }
    private void GetPluginMenuItems(ToolStripItemCollection menu)
    {
      this.Configuration.GetPluginMenuItems(menu);
    }
    protected new abstract class TreeNode<T> : WrapperTreeNode.TreeNode<T>
      where T : SolutionTreeNode
    {
      #region constructor
      public TreeNode(T parent)
        : base(parent)
      { }
      #endregion

      #region private
      protected override void BeforeMenuStripOpening()
      {
        this.Creator.GetPluginMenuItems(this.ContextMenuStrip.Items);
        base.BeforeMenuStripOpening();
      }
      #endregion
    }
    #endregion

    #region creator
    /// <summary>
    /// Initializes a new instance of the <see cref="SolutionTreeNode"/> class.
    /// </summary>
    /// <param name="configuration">The configuration.</param>
    /// <param name="NodeName">Name of the node.</param>
    /// <param name="OnChangeHandler">The on change handler.</param>
    internal SolutionTreeNode
      (UAModelDesignerSolution configuration, string NodeName, EventHandler<EventArgs> OnChangeHandler)
      : base(configuration)
    {
      if (configuration == null)
        throw new ArgumentNullException("configuration");
      configuration.NodeCouple = this;
      OnDataChanged += OnChangeHandler;
      SetText();
      configuration.OnNameChanged += new EventHandler(configuration_OnNameChanged);
      AddProjectsNodes(configuration);
      Root.SolutionRoot = this;
    }
    #endregion

    #region public
    public override NodeTypeEnum NodeType
    {
      get { return NodeTypeEnum.SolutionNode; }
    }
    /// <summary>
    /// Gets the name of the help topic.
    /// </summary>
    /// <value>The name of the help topic.</value>
    public override string HelpTopicName
    {
      get { return Resources.SolutionTreeNode; }
    }
    /// <summary>
    /// Gets the node class.
    /// </summary>
    /// <value>The node class.</value>
    public override NodeClassesEnum NodeClass
    {
      get { return NodeClassesEnum.None; }
    }
    internal override bool TestIfReadOnlyAndRetrunTrueIfReadOnly()
    {
      return false;
    }
    internal UAModelDesignerSolution SaveProjectsCreateConfiguration(string solutionPath)
    {
      Configuration.Save(solutionPath);
      List<ProjectWrapper> nodes = new List<ProjectWrapper>();
      foreach (ProjectTreeNode proj in this)
      {
        if (proj.Save(solutionPath))
          nodes.Add(proj.CloneProject(solutionPath));
      }
      Configuration.Projects = nodes.ToArray();
      return Configuration;
    }
    internal void AddProject(bool existing)
    {
      ProjectTreeNode node = ProjectTreeNode.GetProject(existing, Configuration.HomeDirectory);
      if (node == null)
        return;
      Add(node);
    }
    internal void ImportNodeSetHandler(object sender, EventArgs e)
    {
      ProjectTreeNode node = ProjectTreeNode.ImportNodeSet(Configuration.HomeDirectory, x => TraceEvent.Tracer.TraceEvent(x.TraceLevel, 186, x.ToString()));
      if (node == null)
        return;
      Add(node);
    }
    /// <summary>
    /// Builds the solution and write any massages to specified output.
    /// </summary>
    /// <param name="output">The compiler output.</param>
    internal void Build(TextWriter output)
    {
      output.WriteLine(Resources.Build_all);
      foreach (ProjectTreeNode proj in this)
        proj.Build(output);
    }
    internal event EventHandler<EventArgs> OnDataChanged;
    internal protected override void RaiseOnChangeHandler()
    {
      if (m_OnChangeHandler != null)
        m_OnChangeHandler(this, EventArgs.Empty);
      if (OnDataChanged != null)
        OnDataChanged(this, EventArgs.Empty);
    }
    internal void GetServerUAMenu(ToolStripItemCollection toolStripItemCollection)
    {
      GetPluginMenuItems(toolStripItemCollection);
    }
    internal void RegenerateSubTree()
    {
      this.RaiseSubtreeChanged();
    }
    internal void AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      foreach (ProjectTreeNode node in this)
        node.AddNode2AddressSpace(space);
    }
    internal ITypeDesign FindType(XmlQualifiedName myType)
    {
      foreach (ProjectTreeNode node in this)
      {
        ITypeDesign ret = node.Find(myType);
        if (ret != null)
          return ret;
      }
      return null;
    }
    internal IInstanceConfiguration GetInstanceConfiguration(INodeDescriptor nodeUniqueIdentifier)
    {
      return Configuration.Server.GetInstanceConfiguration(nodeUniqueIdentifier);
    }
    internal string CurrentSoultionDirectory
    {
      get
      {
        if (Configuration != null)
          return Configuration.HomeDirectory;
        return string.Empty;
      }
    }
    #endregion

  }
}