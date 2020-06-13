﻿//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration;
using CAS.CommServer.UA.ModelDesigner.Configuration.IO;
using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Solution;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using UAOOI.SemanticData.UANodeSetValidation;

namespace CAS.UA.Model.Designer.IO
{
  internal interface ISolutionConfigurationManagement
  {
    string Name { get; }
    UAModelDesignerSolutionServerDetails ServerDetails { get; }
    IEnumerable<IOPCFModelConfigurationManagement> Projects { get; }
    ISolutionDirectoryPathManagement SolutionDirectoryPathManagement { get; }

    void Save(bool prompt);

    void ImportNodeSet(Action<TraceMessage> traceEvent);

    void CreateNewModel(Action<TraceMessage> traceEvent);
    void OpenExistingModel(Action<TraceMessage> traceEvent);
  }

  /// <summary>
  /// Singleton class to save and restore solution configuration to/from external file.
  /// </summary>
  internal sealed class OPCFSolutionConfigurationManagement : TypeGenericConfigurationManagement<UAModelDesignerSolution>, ISolutionConfigurationManagement//, IBaseDirectoryProvider
  {
    #region private

    /// <summary>
    /// Class GraphicalUserInterface - stub implementation of the <see cref="IGraphicalUserInterface"/>
    /// Implements the <see cref="IGraphicalUserInterface" />
    /// </summary>
    /// <seealso cref="IGraphicalUserInterface" />
    private class GraphicalUserInterfaceStub : IGraphicalUserInterface
    {
      public Action<string, string> MessageBoxShowWarning => throw new NotImplementedException();

      public Action<string, string> MessageBoxShowExclamation => throw new NotImplementedException();

      public Action<string, string> MessageBoxShowError => throw new NotImplementedException();

      public Func<IFileDialog> OpenFileDialogFunc => throw new NotImplementedException();

      public Func<IFileDialog> SaveFileDialogFuc => throw new NotImplementedException();

      public Func<IFolderBrowserDialog> OpenFolderBrowserDialogFunc => throw new NotImplementedException();

      public Func<string, string, bool> MessageBoxShowWarningAskYN => throw new NotImplementedException();

      public bool UseWaitCursor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    private static UniqueNameGenerator m_UniqueNameGenerator = new UniqueNameGenerator(Resources.DefaultProjectName);

    private class SolutionDirectoryPathManagement : SolutionDirectoryPathManagementBase
    {
      internal void SetNewPath(string path)
      {
        base.BaseDirectory = path;
      }

      public SolutionDirectoryPathManagement(string defaultPath) : base(defaultPath)
      {
      }
    }

    private readonly SolutionDirectoryPathManagement m_PathManagement;

    /// <summary>
    /// Gets the home directory path management.
    /// </summary>
    /// <value>The home directory.</value>
    public ISolutionDirectoryPathManagement HomeDirectory => m_PathManagement;

    private static OPCFSolutionConfigurationManagement m_This;
    private string m_LastOpenedFile = string.Empty;

    private void CommonInitialization()
    {
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 144, "Starting CommonInitialization and checking SaveConstrain");
      //SaveConstrain.CheckConstrain();
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 146, "Creating Libraries");
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 151, "Updating Settings Open File Dialog");
      //ConfigurationChanged = new EventHandler<OPCFSolutionConfigurationManagement.ConfigurationEventArg>(OnConfigurationChanged);
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 172, "Creating new private solution using Empty model");
      //SolutionRootNode = new PrivateSolution(this, UAModelDesignerSolution.CreateEmptyModel(), new ViewModelFactory(), DefaultDirectory, new EventHandler<EventArgs>(OnNodeChange));
      BeforeRead += new EventHandler<StringEventArgs>(OPCFSolutionConfigurationManagement_BeforeRead);
      if (string.IsNullOrEmpty(Settings.Default.DefaultSolutionFileName))
      {
        Settings.Default.DefaultSolutionFileName = DefaultFileName;
        Settings.Default.Save();
      }
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 146, "Finished successfully CommonInitialization");
    }

    private void OPCFSolutionConfigurationManagement_BeforeRead(object sender, StringEventArgs e)
    {
      m_LastOpenedFile = e.String;
    }

    private OPCFSolutionConfigurationManagement(IGraphicalUserInterface graphicalUserInterface, string fileName) : base(graphicalUserInterface, fileName)
    {
      m_PathManagement = new SolutionDirectoryPathManagement(Path.GetDirectoryName(fileName));
    }

    private UAModelDesignerSolutionServerDetails m_ServerDetails;

    private UAModelDesignerSolution SaveProjectsCreateConfiguration()
    {
      Server.Save(HomeDirectory);
      foreach (IOPCFModelConfigurationManagement _project in m_Projects)
        _project.SaveModelDesign();
      return new UAModelDesignerSolution()
      {
        Name = this.Name,
        Projects = m_Projects.Select<IOPCFModelConfigurationManagement, UAModelDesignerProject>(x => x.UAModelDesignerProject).ToArray<UAModelDesignerProject>(),
        ServerDetails = this.m_ServerDetails ?? UAModelDesignerSolutionServerDetails.CreateEmptyInstance()
      };
    }

    /// <summary>
    /// Gets the UI to select a server plug-in.
    /// </summary>
    /// <value>An instance of <see cref="ServerSelector" /> used by a software user to select a server plug-in.</value>
    public ServerSelector Server { get; private set; }

    private List<IOPCFModelConfigurationManagement> m_Projects;

    protected override string ReadErrorInvalidOperationStringFormat => Resources.OPCFSolutionConfigurationManagement_ReadError;

    protected override void RaiseConfigurationChanged(UAModelDesignerSolution model)
    {
      base.RaiseConfigurationChanged(model);
      if (model == null)
        model = UAModelDesignerSolution.CreateEmptyModel();
      m_ServerDetails = model.ServerDetails ?? UAModelDesignerSolutionServerDetails.CreateEmptyInstance();
      Name = model.Name;
      m_Projects = model.Projects.Select<UAModelDesignerProject, IOPCFModelConfigurationManagement>(x => OPCFModelConfigurationManagement.ImportModelDesign(this, base.GraphicalUserInterface, x)).ToList<IOPCFModelConfigurationManagement>();
      OnSolutionChanged();
      //e.Configuration.SetHomeDirectory(Path.GetDirectoryName(DefaultFileName));
      //SolutionRootNode = new SolutionTreeNode(e.Configuration, new ViewModelFactory(), Path.GetDirectoryName(DefaultFileName), new EventHandler<EventArgs>(OnNodeChange));
    }

    private void OnSolutionChanged()
    {
      AfterSolutionChange?.Invoke(this, new AfterSolutionChangeEventArgs(this));
    }

    protected override ConfigurationType Configuration => ConfigurationType.Solution;

    protected override XmlFile.DataToSerialize<UAModelDesignerSolution> GetConfiguration(UAModelDesignerSolution configuration)
    {
      string homeDirectory = Path.GetDirectoryName(this.DefaultFileName);
      XmlFile.DataToSerialize<UAModelDesignerSolution> _config;
      _config.Data = configuration;
      _config.XmlNamespaces = null;
      _config.StylesheetName = "UAModelDesignerSolution.xslt";
      return _config;
    }

    public override void New()
    {
      DefaultFileName = Settings.Default.DefaultSolutionFileName;
      base.New();
    }

    #endregion private

    #region internal singleton

    internal static OPCFSolutionConfigurationManagement DefaultInstance
    {
      get
      {
        if (m_This == null)
        {
          try
          {
            AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 204, "Creating new instance OPCFSolutionConfigurationManagement");
            string _defPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UAModelDesignerSolution");
            m_This = new OPCFSolutionConfigurationManagement(new GraphicalUserInterfaceStub(), _defPath);
            m_This.CommonInitialization();
          }
          catch (Exception ex)
          {
            string _tmp = "Cannot initialize {0} at {1} because of exception: {2}.";
            AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Critical, 212, string.Format(_tmp, typeof(OPCFSolutionConfigurationManagement).FullName, DefaultInstance, ex.Message));
            throw;
          }
        }
        return m_This;
      }
    }

    #region ISolutionConfigurationManagement

    public string Name { get; private set; }

    UAModelDesignerSolutionServerDetails ISolutionConfigurationManagement.ServerDetails => m_ServerDetails;

    IEnumerable<IOPCFModelConfigurationManagement> ISolutionConfigurationManagement.Projects => m_Projects;

    ISolutionDirectoryPathManagement ISolutionConfigurationManagement.SolutionDirectoryPathManagement => m_PathManagement;

    string ISolutionConfigurationManagement.Name => throw new NotImplementedException();

    void ISolutionConfigurationManagement.Save(bool prompt)
    {
      this.Save(prompt, SaveProjectsCreateConfiguration());
    }

    /// <summary>
    /// Imports the UANodeSet encapsulated by a new project.
    /// </summary>
    /// <param name="solutionPathProvider">The solution path provider.</param>
    /// <param name="traceEvent">The trace event.</param>
    /// <returns>ProjectTreeNode.</returns>
    void ISolutionConfigurationManagement.ImportNodeSet(Action<TraceMessage> traceEvent)
    {
      IOPCFModelConfigurationManagement _newModel = OPCFModelConfigurationManagement.ImportNodeSet(this, base.GraphicalUserInterface, traceEvent);
      if (_newModel == null)
        return;
      m_Projects.Add(_newModel);
      OnSolutionChanged();
    }

    void ISolutionConfigurationManagement.CreateNewModel(Action<TraceMessage> traceEvent)
    {
      IOPCFModelConfigurationManagement _newModel = OPCFModelConfigurationManagement.CreateNew(this, base.GraphicalUserInterface, m_UniqueNameGenerator.GenerateNewName());
      if (_newModel == null)
        throw new ApplicationException("New project must be created");
      m_Projects.Add(_newModel);
      OnSolutionChanged();
    }

    void ISolutionConfigurationManagement.OpenExistingModel(Action<TraceMessage> traceEvent)
    {
      IOPCFModelConfigurationManagement _newModel = OPCFModelConfigurationManagement.CreateNew(this, base.GraphicalUserInterface, m_UniqueNameGenerator.GenerateNewName());
      if (_newModel == null)
        throw new ApplicationException("New project must be created");
      m_Projects.Add(_newModel);
      OnSolutionChanged();
    }

    #endregion ISolutionConfigurationManagement

    internal class AfterSolutionChangeEventArgs : EventArgs
    {
      public ISolutionConfigurationManagement Solution { get; private set; }

      public AfterSolutionChangeEventArgs(ISolutionConfigurationManagement solution)
      {
        Solution = solution;
      }
    }

    internal event EventHandler<AfterSolutionChangeEventArgs> AfterSolutionChange;

    #endregion internal singleton
  }
}