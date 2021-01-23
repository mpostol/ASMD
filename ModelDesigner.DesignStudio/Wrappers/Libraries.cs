//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelCompiler.Common;
using System;
using System.Linq;
using System.Xml;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class Libraries : RootTreeNode
  {
    #region private

    private void InitializeTypes()
    {
      try
      {
        AssemblyTraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 37, "Loading the OPC UA Defined Types.");
        OpcUaModelCompiler.ModelDesign _modelTypes = UAResources.LoadUADefinedTypes(); //TODO UAModelDesignExport must provide also ModelDesign but not only export to a file. #498
        if (Properties.Settings.Default.OnlyItemsInAddressSpace)
        {
          _modelTypes.Items = _modelTypes.Items.Where<OpcUaModelCompiler.NodeDesign>((x) => { OpcUaModelCompiler.DataTypeDesign _dt = x as OpcUaModelCompiler.DataTypeDesign; return _dt == null ? true : !_dt.NotInAddressSpace; }).ToArray<OpcUaModelCompiler.NodeDesign>();
          AssemblyTraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 41, "Removed DataTypeDesign items not belonging to the model.");
        }
        AssemblyTraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 37, "Creating the LibraryTreeNode containing standard model");
        Add(new LibraryTreeNode(_modelTypes, "UA Defined Types"));
      }
      catch (Exception _ex)
      {
        string _tmp = "Cannot load Defined OPC UA Types in {0} from {1} because of error {2}";
        AssemblyTraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Critical, 37, _tmp, typeof(Libraries).FullName, typeof(UAResources), _ex.Message);
      }
    }

    #endregion private

    #region creators

    /// <summary>
    /// Initializes a new instance of the <see cref="Libraries"/> class.
    /// </summary>
    /// <param name="container">The container that contains zero or more components..</param>
    public Libraries() : base("")
    {
      InitializeTypes();
    }

    #endregion creators

    #region public

    internal void AddNodes(Action<LibraryTreeNode> callBack)
    {
      foreach (LibraryTreeNode lib in this)
        callBack(lib);
    }

    /// <summary>
    /// Resets the and adds to address space. For each <see cref="LibraryTreeNode"/> item in this collection call <see cref="LibraryTreeNode.AddNode2AddressSpace"/>
    /// </summary>
    /// <param name="space">The space.</param>
    internal void AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      foreach (LibraryTreeNode lib in this)
        lib.AddNode2AddressSpace(space);
    }

    internal ITypeDesign FindType(XmlQualifiedName myType)
    {
      foreach (LibraryTreeNode node in this)
      {
        ITypeDesign ret = node.FindType(myType);
        if (ret != null)
          return ret;
      }
      return null;
    }

    #endregion public
  }
}