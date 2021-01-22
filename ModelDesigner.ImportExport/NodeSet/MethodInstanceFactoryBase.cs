//_______________________________________________________________
//  Title   : MethodInstanceFactoryBase
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
using System.Linq;
using System.Xml;
using UAOOI.SemanticData.InformationModelFactory;
using TraceMessage = UAOOI.SemanticData.UANodeSetValidation.TraceMessage;
using UAOOI.SemanticData.UANodeSetValidation.UAInformationModel;
using InstanceDesign = Opc.Ua.ModelCompiler.InstanceDesign;
using MethodDesign = Opc.Ua.ModelCompiler.MethodDesign;
using NodeDesign = Opc.Ua.ModelCompiler.NodeDesign;
using ParameterDesign = Opc.Ua.ModelCompiler.Parameter;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal class MethodInstanceFactoryBase : InstanceFactoryBase, IMethodInstanceFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceFactoryBase" /> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public MethodInstanceFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    #region IMethodInstanceFactory
    public bool? Executable
    {
      set;
      private get;
    }
    public bool? UserExecutable
    {
      set;
      private get;
    }
    public void AddInputArguments(Func<System.Xml.XmlElement, Parameter[]> argument)
    {
      m_InputArguments = RemoveArguments(BrowseNames.InputArguments, argument);
    }
    public void AddOutputArguments(Func<System.Xml.XmlElement, Parameter[]> argument)
    {
      m_OutputArguments = RemoveArguments(BrowseNames.OutputArguments, argument);
    }
    #endregion

    //internal API
    internal override NodeDesign Export(List<string> path, Action<InstanceDesign, List<string>> createInstanceType)
    {
      MethodDesign _new = new MethodDesign()
      {
        InputArguments = GetArguments(m_InputArguments),
        OutputArguments = GetArguments(m_OutputArguments),
        NonExecutable = Executable.GetValueOrDefault(false),
        NonExecutableSpecified = Executable.HasValue
      };
      base.UpdateInstance(_new, path, TraceEvent, createInstanceType);
      createInstanceType(_new, path);
      return _new;
    }
    //private
    private ParameterDesign[] GetArguments(IEnumerable<Parameter> parameter)
    {
      return parameter == null ? null : parameter.Select<Parameter, ParameterDesign>(x => x.ExportArgument(TraceEvent)).ToArray<ParameterDesign>();
    }
    private IEnumerable<Parameter> m_InputArguments = null;
    private IEnumerable<Parameter> m_OutputArguments = null;
    private IEnumerable<Parameter> RemoveArguments(string parameterKind, Func<XmlElement, Parameter[]> getParameters)
    {
      Parameter[] _parameters = null;
      List<NodeFactoryBase> _newChildrenCollection = new List<NodeFactoryBase>();
      foreach (NodeFactoryBase _item in m_Nodes)
      {
        if (_item.SymbolicName.Equals(new XmlQualifiedName(parameterKind, Namespaces.OpcUa)))
        {
          PropertyInstanceFactoryBase _arg = (PropertyInstanceFactoryBase)_item;
          _parameters = getParameters(_arg.DefaultValue);
        }
        else
          _newChildrenCollection.Add(_item);
      }
      m_Nodes = _newChildrenCollection;
      return _parameters == null || _parameters.Length == 0 ? null : _parameters.AsEnumerable<Parameter>();
    }

  }
}
