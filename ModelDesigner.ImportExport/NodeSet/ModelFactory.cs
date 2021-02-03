//_______________________________________________________________
//  Title   : ModelFactory
//  System  : Microsoft VisualStudio 2013 / C#
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C) 2015, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using UAOOI.SemanticData.InformationModelFactory;
using TraceMessage = UAOOI.SemanticData.BuildingErrorsHandling.TraceMessage;
using ModelDesign = Opc.Ua.ModelCompiler;
using CAS.UA.Model.Designer.ImportExport.NodeSet;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet2
{
  internal class ModelFactory : NodesContainer, IModelFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="ModelFactory"/> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public ModelFactory(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    //IModelFactory
    public void CreateNamespace(string uri)
    {
      ModelDesign.Namespace _new = new ModelDesign.Namespace()
      {
        FilePath = string.Empty,
        InternalPrefix = uri,
        Name = String.Format("Name{0}", m_Count),
        Prefix = String.Format("Prefix{0}", m_Count++),
        Value = uri,
        XmlNamespace = uri,
        XmlPrefix = String.Format("Prefix{0}", m_Count++)
      };
      m_Namespaces.Add(_new);
    }

    //internal  API
    internal ModelDesign.ModelDesign Export()
    {
      List<ModelDesign.NodeDesign> _mdNodes = new List<ModelDesign.NodeDesign>();
      List<string> path = new List<string>();
      base.ExportNodes(_mdNodes, path, (x, y) => CreateInstanceType(x, y, _mdNodes));
      //TODO add warnings to the model as the Property Nodes.
      //ModelDesign.NodeDesign _newNode = CreateNodeDesign((x, y) => { return CreateInstanceType(x, y, _mdNodes, _item.UAModelContext, traceEvent); }, null, _item, y =>
      //    {
      //      if (y.TraceLevel != TraceEventType.Verbose)
      //        _errors.Add(y.BuildError);
      //      traceEvent(y);
      //    });
      return new ModelDesign.ModelDesign()
      {
        Items = _mdNodes.ToArray<ModelDesign.NodeDesign>(),
        Namespaces = m_Namespaces.ToArray<ModelDesign.Namespace>(),
        TargetNamespace = m_Namespaces[1].Value,
        AnyAttr = null,
        DefaultLocale = null,
        TargetPublicationDate = DateTime.Today,
        TargetPublicationDateSpecified = false,
        TargetVersion = string.Empty,
        TargetXmlNamespace = null
      };
    }

    //private 
    private List<ModelDesign.Namespace> m_Namespaces = new List<ModelDesign.Namespace>();
    private static int m_Count = 0;
    private void CreateInstanceType(ModelDesign.InstanceDesign instance, List<string> browsePath, List<ModelDesign.NodeDesign> mdNodes)
    {
      Debug.Assert(instance != null, "CreateInstanceType.instance cannot be null");
      ModelDesign.InstanceDesign _ret = null;
      if (instance is ModelDesign.MethodDesign)
      {
        ModelDesign.MethodDesign _src = (ModelDesign.MethodDesign)instance;
        XmlQualifiedName _newSymbolicName = new XmlQualifiedName(browsePath.SymbolicName(), instance.SymbolicName.Namespace);
        ModelDesign.MethodDesign _method = new ModelDesign.MethodDesign
        {
          BrowseName = _src.BrowseName,
          Children = null,
          Declaration = _src.Declaration,
          Description = _src.Description,
          DisplayName = _src.DisplayName,
          InputArguments = _src.InputArguments,
          IsDeclaration = _src.IsDeclaration,
          MaxCardinality = _src.MaxCardinality,
          MinCardinality = _src.MinCardinality,
          ModellingRule = ModelDesign.ModellingRule.None,
          ModellingRuleSpecified = false,
          NonExecutable = _src.NonExecutable,
          NonExecutableSpecified = _src.NonExecutableSpecified,
          NumericId = _src.NumericId,
          NumericIdSpecified = _src.NumericIdSpecified,
          OutputArguments = _src.OutputArguments,
          PartNo = _src.PartNo,
          PreserveDefaultAttributes = _src.PreserveDefaultAttributes,
          References = _src.References,
          ReferenceType = _src.ReferenceType,
          StringId = _src.StringId,
          SymbolicId = _src.SymbolicId,
          SymbolicName = _newSymbolicName,
          TypeDefinition = null,
          WriteAccess = _src.WriteAccess,
        };
        _src.InputArguments = null;
        _src.OutputArguments = null;
        if (instance.Children == null || instance.Children.Items == null || instance.Children.Items.Length == 0)
          instance.Children = null;
        _src.TypeDefinition = _newSymbolicName;
        _ret = _method;
      }
      else
        Debug.Fail("In this release expected Method");
      if (_ret != null)
        mdNodes.Add(_ret);
    }

  }
}
