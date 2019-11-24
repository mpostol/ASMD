//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Solution;
using System;
using System.Diagnostics;
using System.IO;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Singleton class to save and restore solution configuration to/from external file.
  /// </summary>
  internal class OPCFSolutionConfigurationManagement : TypeGenericConfigurationManagement<UAModelDesignerSolution>//, IBaseDirectoryProvider
  {

    #region private
    private static OPCFSolutionConfigurationManagement m_This;
    private string m_LastOpenedFile = string.Empty;
    protected override string ReadErrorInvalidOperationStringFormat => Resources.OPCFSolutionConfigurationManagement_ReadError;
    protected override void RaiseConfigurationChanged(UAModelDesignerSolution model)
    {
      base.RaiseConfigurationChanged(model);
      if (model == null)
        model = UAModelDesignerSolution.CreateEmptyModel();
      AfterSolutionChange?.Invoke(this, new AfterSolutionChangeEventArgs(model));
      //e.Configuration.SetHomeDirectory(Path.GetDirectoryName(DefaultFileName));
      //SolutionRootNode = new SolutionTreeNode(e.Configuration, new ViewModelFactory(), Path.GetDirectoryName(DefaultFileName), new EventHandler<EventArgs>(OnNodeChange));
    }
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
    private OPCFSolutionConfigurationManagement(IGraphicalUserInterface graphicalUserInterface, string fileName) : base(graphicalUserInterface, fileName) { }
    #endregion

    #region override
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
    #endregion override

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
            m_This = new OPCFSolutionConfigurationManagement(new GraphicalUserInterface(), _defPath);
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
    internal class AfterSolutionChangeEventArgs : EventArgs
    {
      public UAModelDesignerSolution Solution { get; private set; }
      public AfterSolutionChangeEventArgs(UAModelDesignerSolution solution)
      {
        Solution = solution;
      }
    }
    internal event EventHandler<AfterSolutionChangeEventArgs> AfterSolutionChange;
    #endregion

  }
}
