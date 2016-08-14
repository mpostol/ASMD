//<summary>
//  Title   : Simple observer that provides access to current selected IModelNode and IModelNodeAdvanced
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using System.ComponentModel;
using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  /// <summary>
  /// Simple observer that provides access to current selected IModelNode and IModelNodeAdvanced
  /// </summary>
  //MPTD we does not use it.
  internal partial class SelectedItemObserverComponent: MainController.SelectedItemObserverSimpleComponent
  {
    #region public
    public SelectedItemObserverComponent()
    {
      InitializeComponent();
    }
    public SelectedItemObserverComponent( IContainer container )
    {
      container.Add( this );
      InitializeComponent();
    }
    internal IModelNode IModelNode { get; private set; }
    internal IModelNodeAdvance IModelNodeAdvance { get; private set; }
    #endregion public
    #region protected
    protected override void OnSelectedItemIsChanged( object sender, SelectedItemEventArgs e )
    {
      //this is special observer that operates also on  IModelNodeAdvance 
      //this event returns IModelNode, so we must change it to IModelNodeAdvance
      //
      //here we do not know wheter we receive:
      // - e.SelectedIModelNode as IModelNodeAdvance
      // - e.SelectedIModelNode as IWrapperTreeNode
      //the code belows perform the conversion but this is very unclear situation
      //TODO: this should be changed in the future, see:
      //http://itrserver.hq.cas.com.pl/Bugs/BugDetail.aspx?bid=2253
      //http://itrserver.hq.cas.com.pl/Bugs/BugDetail.aspx?bid=2254
      if ( e.SelectedIModelNode is IModelNodeAdvance )
        this.IModelNodeAdvance = (IModelNodeAdvance)e.SelectedIModelNode;
      if ( e.SelectedIModelNode is IWrapperTreeNode )
        this.IModelNodeAdvance = ( (IWrapperTreeNode)e.SelectedIModelNode ).IModelNodeAdvance;
      this.IModelNode = e.SelectedIModelNode;
    }
    #endregion protected
  }
}
