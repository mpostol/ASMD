//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Properties;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System;
using System.Collections.Generic;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{

  internal class ProjectTreeNode : WrapperTreeNode, IProjectModelView
  {
    #region private

    private readonly IProjectConfigurationManagement m_ProjectConfigurationManager;
    private readonly ModelDesign Model;
    private static readonly object m_BuildLockObject = new object(); // this object is used to prevent many code generator usage at the same time

    #endregion private

    #region constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="ProjectTreeNode"/> encapsulating an existing UA model.
    /// </summary>
    /// <param name="solutionPath">The solution path.</param>
    /// <param name="projectDescription">The project description.</param>
    internal ProjectTreeNode(IProjectConfigurationManagement projectDescription) : base(null, projectDescription.Name)
    {
      m_ProjectConfigurationManager = projectDescription;
      Model = new ModelDesign(projectDescription.ModelDesign, false);
      Add(Model);
    }

    #endregion constructors

    #region WrapperTreeNode

    public override object Wrapper => this.Create();
    public override NodeTypeEnum NodeType => NodeTypeEnum.ProjectNode;

    /// <summary>
    /// Gets the folders.
    /// </summary>
    /// <returns>Dictionary{FolderType, IEnumerable&lt;IModelNodeAdvance}</returns>
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

    /// <summary>
    /// Builds the project and write any trace massages.
    /// </summary>
    /// <param name="traceMessage">Delegate to trace message.</param>
    internal void Build(Action<string> traceMessage)
    {
      try
      {
        lock (m_BuildLockObject)
        {
          traceMessage(string.Format(Resources.Build_project_name, this.Text));
          traceMessage(string.Format(Resources.Build_started_at, System.DateTime.Now.ToString()));
          m_ProjectConfigurationManager.Build(traceMessage);
        }
        traceMessage(string.Format(Resources.Build_ended_at, System.DateTime.Now.ToString()));
        traceMessage("");
      }
      catch (Exception ex)
      {
        traceMessage(Resources.BuildError_nocontinuation);
        traceMessage(ex.Message);
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

    #endregion public

    #region IProjectModel

    public void Remove()
    {
      Parent.Remove(this);
    }

    internal void Save()
    {
      m_ProjectConfigurationManager.Save(Model.GetModel());
    }

    #endregion IProjectModel
  }
}