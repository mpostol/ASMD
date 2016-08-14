//<summary>
//  Title   : Class representing all libraries added to the resources.
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2008, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.ModelCompiler.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal class Libraries: RootTreeNode
  {
    #region private
    private void InitializeTypes( IContainer container )
    {
      
      try
      {
        TraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 37, "Loading the OPC UA Defined Types.");
        var _modelTypes = UAResources.LoadUADefinedTypes();
        TraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 37, "Creating the LibraryTreeNode containing standard model");
        Add(new LibraryTreeNode(UAResources.LoadUADefinedTypes(), "UA Defined Types", container));
      }
      catch (Exception _ex)
      {
        string _tmp = "Cannot load Defined OPC UA Types in {0} from {1} because of error {2}";
        TraceEvent.Tracer.TraceEvent(System.Diagnostics.TraceEventType.Critical, 37, _tmp, typeof(Libraries).FullName, typeof(UAResources), _ex.Message);
      } 
    }
    #endregion

    #region creators
    /// <summary>
    /// Initializes a new instance of the <see cref="Libraries"/> class.
    /// </summary>
    /// <param name="container">The container that contains zero or more components..</param>
    public Libraries( IContainer container )
      : base( "" )
    {
      InitializeTypes( container );
      Root.LibraryRoot = this;
    }
    #endregion

    #region public
    /// <summary>
    /// Gets the tree node and all children.
    /// </summary>
    /// <returns>
    /// The node of the type <see cref="System.Windows.Forms.TreeNode"/> with all children added to the Nodes collection.
    /// </returns>
    internal override DictionaryTreeView.DictionaryTreeNode GetTreeNode()
    {
      throw new NotImplementedException();
    }
    internal void AddTreeNodes( TreeNodeCollection nodes )
    {
      foreach ( LibraryTreeNode lib in this )
        nodes.Add( lib.GetTreeNode() );
    }
    /// <summary>
    /// Resets the and adds to address space. For each <see cref="LibraryTreeNode"/> item in this collection call <see cref="LibraryTreeNode.AddNode2AddressSpace"/>
    /// </summary>
    /// <param name="space">The space.</param>
    internal void AddNode2AddressSpace(IAddressSpaceCreator space)
    {
      foreach ( LibraryTreeNode lib in this )
        lib.AddNode2AddressSpace( space );
    }
    internal ITypeDesign FindType( XmlQualifiedName myType )
    {
      foreach ( LibraryTreeNode node in this )
      {
        ITypeDesign ret = node.FindType( myType );
        if ( ret != null )
          return ret;
      }
      return null;
    }
    #endregion
  }
}
