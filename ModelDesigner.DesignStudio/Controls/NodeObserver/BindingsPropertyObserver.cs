//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System.ComponentModel;
using CAS.UA.Model.Designer.Wrappers;
using UAOOI.Configuration.Core;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  /// <summary>
  /// Dedicated observer to manage content edited in the bindings PropertyGrid.
  /// </summary>
  internal partial class BindingsPropertyObserver: PropertyGridObserver
  {
    #region constructor
    public BindingsPropertyObserver()
    {
      InitializeComponent();
    }
    #endregion

    #region private
    protected override void UpdatePropertyGridSelectedObject( IModelNode imodelNode )
    {
      INodeDescriptor dscr = imodelNode.GetINodeDescriptor();
      if ( dscr == null )
        this.PropertyGrid.SelectedObject = null;
      else
        this.PropertyGrid.SelectedObject = new InstanceConfigurationMasterEditor(SolutionTreeNode.SolutionRoot.GetInstanceConfiguration( dscr ) );
    }
    protected override void OnSelectedItemIsChanged( object sender, SelectedItemEventArgs e )
    {
      base.OnSelectedItemIsChanged( sender, e );
      this.PropertyGrid.Enabled = true;
    }
    private class InstanceConfigurationMasterEditor
    {
      /// <summary>
      /// Gets or sets the real-time process bindings.
      /// </summary>
      /// <value>The bindings.</value>
      #region Attributes
      [
      TypeConverterAttribute( typeof( ExpandableObjectConverter ) ),
      DisplayName( "Process Bindings" ),
      DescriptionAttribute(
        "This property contains configuration of bindings between this instance node in the model " +
        "and underlying real-time process data source. The configuration data depends on the data provider plug-in " +
        "that has been used. Expand this property row to edit configuration."
      ),
      CategoryAttribute( "Process data binding" )
      ]
      #endregion
      public IInstanceConfiguration Bindings { get; set; }
      /// <summary>
      /// Initializes a new instance of the <see cref="InstanceDesign&lt;type, OPCType&gt;.InstanceDesignTreeNodeControl&lt;T&gt;.Wrapper"/> class.
      /// </summary>
      /// <param name="bindings">The bindings.</param>
      public InstanceConfigurationMasterEditor( IInstanceConfiguration bindings )
      {
        if ( bindings == null )
          Bindings = new MessageProvider();
        else
          Bindings = bindings;
      }
      private class MessageProvider: IInstanceConfiguration
      {
        #region public properties
        #region Attributes
        [
        DisplayName( "Process Bindings" ),
        DescriptionAttribute( "To setup configuration editor select Select Editor ... on the UA Server menu. " +
          "The dialog Open Configuration Editor is then displayed. Using Open Configuration Editor dialog box " +
          "open the vendor specific plug-in providing the server configuration functionality, i.e. implementing " +
          "necessary interfaces. See product documentation to get more."
        ),
        CategoryAttribute( "Process data binding" )
        ]
        #endregion
        public string ConfiguratinEditor { get { return "To setup select it using the UA Server menu (see description below)."; } } 
        #endregion
        public override string ToString()
        {
          return "Configuration editor is not set!";
        }
        #region IInstanceConfiguration Members
        public void Edit()
        {
          throw new System.NotImplementedException();
        }
        public void ClearConfiguration()
        {
          throw new System.NotImplementedException();
        }
        #endregion
      }
    }
    #endregion

  }
}
