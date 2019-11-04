//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelCompiler.Common;
using CAS.UA.Model.Designer.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using UADataTypeDesign = Opc.Ua.ModelCompiler.DataTypeDesign;
using UAModelDesign = Opc.Ua.ModelCompiler.ModelDesign;
using UANodeDesign = Opc.Ua.ModelCompiler.NodeDesign;

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
        UAModelDesign _modelTypes = UAResources.LoadUADefinedTypes();
        if (Properties.Settings.Default.OnlyItemsInAddressSpace)
        {
          _modelTypes.Items = _modelTypes.Items.Where<UANodeDesign>((x) => { UADataTypeDesign _dt = x as UADataTypeDesign; return _dt == null ? true : !_dt.NotInAddressSpace; }).ToArray<UANodeDesign>();
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
    #endregion

    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="Libraries"/> class.
    /// </summary>
    /// <param name="container">The container that contains zero or more components..</param>
    public Libraries()
      : base("")
    {
      InitializeTypes();
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    public override BaseDictionaryTreeNode GetTreeNode()
    {
      throw new NotImplementedException();
    }
    internal void AddTreeNodes(TreeNodeCollection nodes)
    {
      foreach (LibraryTreeNode lib in this)
        nodes.Add(lib.GetTreeNode());
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
    #endregion
  }
}
