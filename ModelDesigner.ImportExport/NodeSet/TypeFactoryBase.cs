//_______________________________________________________________
//  Title   : TypeFactoryBase
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
using System.Xml;
using UAOOI.SemanticData.InformationModelFactory;
using UAOOI.SemanticData.UANodeSetValidation;
using ModelDesign = Opc.Ua.ModelCompiler;

namespace CAS.UA.Model.Designer.ImportExport.NodeSet
{

  internal abstract class TypeFactoryBase : NodeFactoryBase, ITypeFactory
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="NodeFactoryBase" /> class.
    /// </summary>
    /// <param name="traceEvent">The trace event.</param>
    public TypeFactoryBase(Action<TraceMessage> traceEvent)
      : base(traceEvent)
    { }

    #region ITypeFactory
    public XmlQualifiedName BaseType
    {
      set;
      private get;
    }
    public bool IsAbstract
    {
      set;
      private get;
    }
    #endregion

    //internal API
    internal void Update(ModelDesign.TypeDesign nodeDesign, List<string> path, Action<ModelDesign.InstanceDesign, List<string>> createInstanceType)
    {
      nodeDesign.BaseType = this.BaseType;
      nodeDesign.ClassName = String.Empty;
      nodeDesign.IsAbstract = this.IsAbstract;
      nodeDesign.NoClassGeneration = false;
      base.UpdateNode(nodeDesign, path, createInstanceType);
    }

  }
}
