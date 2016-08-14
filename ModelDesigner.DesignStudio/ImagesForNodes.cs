using System;
using System.ComponentModel;
using System.Windows.Forms;
using CAS.UA.Model.Designer.Wrappers.AddressSpaceDictionary;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;

namespace CAS.UA.Model.Designer
{
  internal partial class ImagesForNodes: Component
  {
    internal ImagesForNodes()
    {
      InitializeComponent();
    }
    internal ImagesForNodes( IContainer container )
    {
      container.Add( this );
      InitializeComponent();
    }
    internal ImageList ImageListNodes
    {
      get
      {
        return this.imageList_nodes;
      }
    }
    internal enum IconsIndex
    {
      Default = 0,
      DataTypeDesign = 1,
      DictionaryDesign = 2,
      EventTypeDesign = 3,
      MethodDesign = 4,
      ModelDesign = 5,
      Namespace = 6,
      NamespacesFolder = 7,
      ObjectDesign = 8,
      ObjectTypeDesign = 9,
      PropertyDesign = 10,
      ReferenceTypeDesign = 11,
      StateMachineDesign = 12,
      VariableDesign = 13,
      VariableTypeDesign = 14,
      ViewDesign = 15,
      Children = 16,
      EncodingDesign = 17,
      ProjectTreeNode = 18,
      LibraryTreeNode = 19,
      SimpleItem = 20,
      SelectedChildren = 21,
      SelectedDataTypeDesign = 22,
      SelectedDefault = 23,
      SelectedDictionaryDesign = 24,
      SelectedEncodingDesign = 25,
      SelectedEventTypeDesign = 26,
      SelectedMethodDesign = 27,
      SelectedModelDesign = 28,
      SelectedNamespace = 29,
      SelectedNamespacesFolder = 30,
      SelectedObjectDesign = 31,
      SelectedObjectTypeDesign = 32,
      SelectedProjectTreeNode = 33,
      SelectedPropertyDesign = 34,
      SelectedReferenceTypeDesign = 35,
      SelectedLibraryTreeNode = 36,
      SelectedStateMachineDesign = 37,
      SelectedVariableDesign = 38,
      SelectedVariableTypeDesign = 39,
      SelectedViewDesign = 40,
      SelectedSimpleItem = 41,
      PrivateSolution = 42,
      SelectedPrivateSolution = 43,
      Error = 44,
      SelectedError = 45
    }

    /// <summary>
    /// Gets the icon numer.
    /// </summary>
    /// <param name="ie">The ie.</param>
    /// <param name="isItReference">if set to <c>true</c> [is it reference].</param>
    /// <param name="isItSelectedIcon">if set to <c>true</c> [is it selected icon].</param>
    /// <returns></returns>
    internal static int GetIconNumber( IElement ie, bool isItReference, bool isItSelectedIcon )
    {
      Array values = Enum.GetValues( typeof( IconsIndex ) );
      ImagesForNodes images = new ImagesForNodes();
      if ( ie != null )
      {
        if ( isItReference == true && isItSelectedIcon == true )
          return (int)IconsIndex.SelectedSimpleItem;
        else if ( isItReference == true && isItSelectedIcon == false )
          return (int)IconsIndex.SimpleItem;
        else if ( isItReference == false && isItSelectedIcon == false )
        {
          foreach ( string nameFromEnum in IconsIndex.GetNames( typeof( IconsIndex ) ) )
            if ( ( nameFromEnum.Contains( ie.NodeClass.ToString() ) ) && !( nameFromEnum.ToString().Contains( "Selected" ) ) )
              for ( int ind = 0; ind < values.Length; ind++ )
                if ( values.GetValue( ind ).ToString() == nameFromEnum )
                  return ind;
        }
        else if ( isItReference == false && isItSelectedIcon == true )
        {
          foreach ( string nameFromEnum in IconsIndex.GetNames( typeof( IconsIndex ) ) )
            if ( ( nameFromEnum.Contains( ie.NodeClass.ToString() ) ) && ( nameFromEnum.ToString().Contains( "Selected" ) ) )
              for ( int ind = 0; ind < values.Length; ind++ )
                if ( values.GetValue( ind ).ToString() == nameFromEnum )
                  return ind;
        }
      }
      if ( ( ie == null ) || ( ( ie != null ) && ( ie.NodeClass == NodeClassesEnum.None ) ) )
      {
        if ( isItSelectedIcon == true && isItReference == false )
          return (int)IconsIndex.SelectedDefault;
        else if ( isItSelectedIcon == false && isItReference == false )
          return (int)IconsIndex.Default;
        else if ( isItSelectedIcon == true && isItReference == true )
          return (int)IconsIndex.SelectedSimpleItem;
        else
          return (int)IconsIndex.SimpleItem;
      }
      return (int)IconsIndex.Default;
    }

    /// <summary>
    /// Sets the icon index for node and selected node.
    /// </summary>
    /// <param name="name">The name of the nodeClass.</param>
    /// <param name="imgIdx">The image index.</param>
    /// <param name="selImgIdx">The selected image index.</param>
    internal static int SetIconIndexForNodeAndSelectedNode( string name, bool isItSelected )
    {
      Array values = Enum.GetValues( typeof( IconsIndex ) );
      if ( isItSelected == false )
      {
        foreach ( string nameFromEnum in IconsIndex.GetNames( typeof( IconsIndex ) ) )
        {
          if ( nameFromEnum.Contains( name ) && !( nameFromEnum.ToString().Contains( "Selected" ) ) )
          {
            for ( int ind = 0; ind < values.Length; ind++ )
              if ( values.GetValue( ind ).ToString() == nameFromEnum )
                return ind;
          }
        }
        return (int)IconsIndex.Default;
      }
      else
      {
        foreach ( string nameFromEnum in IconsIndex.GetNames( typeof( IconsIndex ) ) )
        {
          if ( nameFromEnum.Contains( name ) && ( nameFromEnum.ToString().Contains( "Selected" ) ) )
          {
            for ( int ind = 0; ind < values.Length; ind++ )
              if ( values.GetValue( ind ).ToString() == nameFromEnum )
                return ind;
          }
        }
        return (int)IconsIndex.SelectedDefault;
      }
    }
  }
}
