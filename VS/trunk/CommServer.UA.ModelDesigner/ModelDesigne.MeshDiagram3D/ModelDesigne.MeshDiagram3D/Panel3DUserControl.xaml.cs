//---------------------------------------------------------------------------
// This file is part of the following project:
// Mesh Diagram 3D
// Author:  Maciej Zbrzezny
// 
// This source is subject to the Microsoft Public License (Ms-PL)
// See http://meshdiagram3d.codeplex.com/license
//
// For more information, see:
// http://meshdiagram3d.codeplex.com/
//
//---------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MeshDiagram3D.Presentation;

namespace MeshDiagram3D
{
  /// <summary>
  /// Interaction logic for Panel3DUserControl.xaml
  /// </summary>
  public partial class Panel3DUserControl: UserControl
  {
    #region private static, classes, readonly
    readonly Brush brushdefault = new SolidColorBrush( Color.FromRgb( 0xE2, 0xE2, 0xE2 ) );
    readonly Brush brushselection = new SolidColorBrush( Colors.Gold );
    private static double GetDoubleValueOrDefault( string ValueAsString, double DefaultValue )
    {
      double ret;
      if ( double.TryParse( ValueAsString, out ret ) )
        return ret;
      else
        return DefaultValue;
    }
    private enum SliderFunctionality
    {
      Rotator,
      CameraLocation
    }
    #endregion private static, classes, readonly
    #region private
    private SliderFunctionality m_sliderfunctionality;
    private double txt_zomm_as_double
    {
      get
      {
        return GetDoubleValueOrDefault( txt_zoom.Text, 0 );
      }
      set
      {
        txt_zoom.Text = value.ToString();
      }
    }
    private void ChangeSliderFunctionality( SliderFunctionality functionality )
    {
      m_sliderfunctionality = functionality;
      switch ( m_sliderfunctionality )
      {
        case SliderFunctionality.Rotator:
          btn_Rotator.Background = brushselection;
          btn_CameraLocation.Background = brushdefault;
          slider_x.Value = MyMeshDiagramViewport3D.Rot_x;
          slider_y.Value = MyMeshDiagramViewport3D.Rot_y;
          slider_z.Value = MyMeshDiagramViewport3D.Rot_z;
          slider_zoom.Value = MyMeshDiagramViewport3D.Scale;
          break;
        case SliderFunctionality.CameraLocation:
          btn_Rotator.Background = brushdefault;
          btn_CameraLocation.Background = brushselection;
          slider_x.Value = MyMeshDiagramViewport3D.CamLocation_x;
          slider_y.Value = MyMeshDiagramViewport3D.CamLocation_y;
          slider_z.Value = MyMeshDiagramViewport3D.CamLocation_z;
          slider_zoom.Value = MyMeshDiagramViewport3D.DistanceFromCenter;
          break;
      }
    }
    private void MyMeshDiagramViewport3D_iModelVisualIsSelected( object sender, EventArgs e )
    {
      this.textblock_info.Text = MyMeshDiagramViewport3D.SelectedIModelVisual.Text;
    }
    #region SlidersRotator
    private void txt_camloc_zoom_TextChanged( object sender, TextChangedEventArgs e )
    {

    }
    private void txt_camloc_x_TextChanged( object sender, TextChangedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      MyMeshDiagramViewport3D.CamLocation_x = GetDoubleValueOrDefault( txt_camloc_x.Text, MeshDiagramViewport3D.defaultCamLocation_x );
      if ( m_sliderfunctionality == SliderFunctionality.CameraLocation )
        slider_x.Value = MyMeshDiagramViewport3D.CamLocation_x;
    }
    private void txt_camloc_y_TextChanged( object sender, TextChangedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      MyMeshDiagramViewport3D.CamLocation_y = GetDoubleValueOrDefault( txt_camloc_y.Text, MeshDiagramViewport3D.defaultCamLocation_y );
      if ( m_sliderfunctionality == SliderFunctionality.CameraLocation )
        slider_y.Value = MyMeshDiagramViewport3D.CamLocation_y;
    }
    private void txt_camloc_z_TextChanged( object sender, TextChangedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      MyMeshDiagramViewport3D.CamLocation_z = GetDoubleValueOrDefault( txt_camloc_z.Text, MeshDiagramViewport3D.defaultCamLocation_z );
      if ( m_sliderfunctionality == SliderFunctionality.CameraLocation )
        slider_z.Value = MyMeshDiagramViewport3D.CamLocation_z;
    }
    private void slider_x_changed( object sender, RoutedEventArgs args )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      TurnOffLabels();
      double val = System.Math.Round( slider_x.Value, 2 );
      switch ( m_sliderfunctionality )
      {
        case SliderFunctionality.Rotator:
          MyMeshDiagramViewport3D.Rot_x = val;
          if ( GetDoubleValueOrDefault( txt_rot_x.Text, 0 ) != MyMeshDiagramViewport3D.Rot_x )
            txt_rot_x.Text = MyMeshDiagramViewport3D.Rot_x.ToString();
          break;
        case SliderFunctionality.CameraLocation:
          MyMeshDiagramViewport3D.CamLocation_x = val;
          if ( GetDoubleValueOrDefault( txt_camloc_x.Text, MeshDiagramViewport3D.defaultCamLocation_x ) != MyMeshDiagramViewport3D.CamLocation_x )
            txt_camloc_x.Text = MyMeshDiagramViewport3D.CamLocation_x.ToString();
          break;
      }
    }
    private void slider_y_changed( object sender, RoutedEventArgs args )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      TurnOffLabels();
      double val = System.Math.Round( slider_y.Value, 2 );
      switch ( m_sliderfunctionality )
      {
        case SliderFunctionality.Rotator:
          MyMeshDiagramViewport3D.Rot_y = val;
          if ( GetDoubleValueOrDefault( txt_rot_y.Text, 0 ) != MyMeshDiagramViewport3D.Rot_y )
            txt_rot_y.Text = MyMeshDiagramViewport3D.Rot_y.ToString();
          break;
        case SliderFunctionality.CameraLocation:
          MyMeshDiagramViewport3D.CamLocation_y = val;
          if ( GetDoubleValueOrDefault( txt_camloc_y.Text, MeshDiagramViewport3D.defaultCamLocation_y ) != MyMeshDiagramViewport3D.CamLocation_y )
            txt_camloc_y.Text = MyMeshDiagramViewport3D.CamLocation_y.ToString();
          break;
      }
    }
    private void slider_z_changed( object sender, RoutedEventArgs args )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      TurnOffLabels();
      double val = System.Math.Round( slider_z.Value, 2 );
      switch ( m_sliderfunctionality )
      {
        case SliderFunctionality.Rotator:
          MyMeshDiagramViewport3D.Rot_z = val;
          if ( GetDoubleValueOrDefault( txt_rot_z.Text, 0 ) != MyMeshDiagramViewport3D.Rot_z )
            txt_rot_z.Text = MyMeshDiagramViewport3D.Rot_z.ToString();
          break;
        case SliderFunctionality.CameraLocation:
          MyMeshDiagramViewport3D.CamLocation_z = val;
          if ( GetDoubleValueOrDefault( txt_camloc_z.Text, MeshDiagramViewport3D.defaultCamLocation_z ) != MyMeshDiagramViewport3D.CamLocation_z )
            txt_camloc_z.Text = MyMeshDiagramViewport3D.CamLocation_z.ToString();
          break;
      }
    }
    private void slider_zoom_changed( object sender, RoutedEventArgs args )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      TurnOffLabels();
      double slider_zoom_Value = System.Math.Round( slider_zoom.Value, 2 );
      switch ( m_sliderfunctionality )
      {
        case SliderFunctionality.Rotator:
          MyMeshDiagramViewport3D.Scale = slider_zoom_Value;
          if ( GetDoubleValueOrDefault( txt_zoom.Text, 1 ) != MyMeshDiagramViewport3D.Scale )
            txt_zoom.Text = MyMeshDiagramViewport3D.Scale.ToString();
          break;
        case SliderFunctionality.CameraLocation:
          break;
      }
    }
    private void txt_rotx_TextChanged( object sender, TextChangedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      MyMeshDiagramViewport3D.Rot_x = GetDoubleValueOrDefault( txt_rot_x.Text, 0 );
      if ( m_sliderfunctionality == SliderFunctionality.Rotator && slider_x != null && slider_x.Value != MyMeshDiagramViewport3D.Rot_x )
        slider_x.Value = MyMeshDiagramViewport3D.Rot_x;
    }
    private void txt_rotz_TextChanged( object sender, TextChangedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      MyMeshDiagramViewport3D.Rot_z = GetDoubleValueOrDefault( txt_rot_z.Text, 0 );
      if ( m_sliderfunctionality == SliderFunctionality.Rotator && slider_z != null && slider_z.Value != MyMeshDiagramViewport3D.Rot_z )
        slider_z.Value = MyMeshDiagramViewport3D.Rot_z;
    }
    private void txt_roty_TextChanged( object sender, TextChangedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      MyMeshDiagramViewport3D.Rot_y = GetDoubleValueOrDefault( txt_rot_y.Text, 0 );
      if ( m_sliderfunctionality == SliderFunctionality.Rotator && slider_y != null && slider_y.Value != MyMeshDiagramViewport3D.Rot_y )
        slider_y.Value = MyMeshDiagramViewport3D.Rot_y;
    }

    private void txt_zoom_TextChanged( object sender, TextChangedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      double scale = txt_zomm_as_double;
      MyMeshDiagramViewport3D.Scale = scale;
      if ( m_sliderfunctionality == SliderFunctionality.Rotator &&
        slider_zoom != null && slider_zoom.Value != scale )
        MyMeshDiagramViewport3D.Scale = scale;
    }
    #endregion SlidersRotator
    #region filter checkboxes
    private void TurnOffLabels()
    {
      CheckBoxTexts2D.IsChecked = false;
      CheckBoxTexts3D.IsChecked = false;
    }
    private void CheckBoxTriangles_Checked( object sender, RoutedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      if ( CheckBoxTriangles.IsChecked.HasValue )
      {
        if ( (bool)CheckBoxTriangles.IsChecked )
          MyMeshDiagramViewport3D.Filter.Triangles = true;
        else
          MyMeshDiagramViewport3D.Filter.Triangles = false;
      }
    }
    private void CheckBoxLines_Checked( object sender, RoutedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      if ( CheckBoxLines.IsChecked.HasValue )
      {
        if ( (bool)CheckBoxLines.IsChecked )
          MyMeshDiagramViewport3D.Filter.Lines = true;
        else
          MyMeshDiagramViewport3D.Filter.Lines = false;
      }
    }
    private void CheckBoxLables3D_Checked( object sender, RoutedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      if ( CheckBoxTexts3D.IsChecked.HasValue )
      {
        if ( (bool)CheckBoxTexts3D.IsChecked )
          MyMeshDiagramViewport3D.Filter.Texts3D = true;
        else
          MyMeshDiagramViewport3D.Filter.Texts3D = false;
      }
    }
    private void CheckBoxLables2D_Checked( object sender, RoutedEventArgs e )
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      if ( CheckBoxTexts2D.IsChecked.HasValue )
      {
        if ( (bool)CheckBoxTexts2D.IsChecked )
          MyMeshDiagramViewport3D.Filter.Texts2D = true;
        else
          MyMeshDiagramViewport3D.Filter.Texts2D = false;
      }
    }
    #endregion filter checkboxes
    private void btn_Rotator_Click( object sender, RoutedEventArgs e )
    {
      ChangeSliderFunctionality( SliderFunctionality.Rotator );
    }
    private void btn_CameraLocation_Click( object sender, RoutedEventArgs e )
    {
      ChangeSliderFunctionality( SliderFunctionality.CameraLocation );
    }
    private void btn_AutoZoom_Click( object sender, RoutedEventArgs e )
    {
      TryAutoZoom();
    }
    private void MyMeshDiagramViewport3D_CamLocation_x_HasChanged( object sender, MeshdiagramViewport3DPropertyChangeEventArgs<double> e )
    {
      if ( m_sliderfunctionality == SliderFunctionality.CameraLocation )
      {
        slider_x.Value = e.Value;
      }
    }
    private void MyMeshDiagramViewport3D_CamLocation_y_HasChanged( object sender, MeshdiagramViewport3DPropertyChangeEventArgs<double> e )
    {
      if ( m_sliderfunctionality == SliderFunctionality.CameraLocation )
      {
        slider_y.Value = e.Value;
      }
    }
    private void MyMeshDiagramViewport3D_CamLocation_z_HasChanged( object sender, MeshdiagramViewport3DPropertyChangeEventArgs<double> e )
    {
      if ( m_sliderfunctionality == SliderFunctionality.CameraLocation )
      {
        slider_z.Value = e.Value;
      }
    }

    private void MyMeshDiagramViewport3D_Rot_x_HasChanged( object sender, MeshdiagramViewport3DPropertyChangeEventArgs<double> e )
    {
      if ( m_sliderfunctionality == SliderFunctionality.Rotator )
      {
        slider_x.Value = e.Value;
      }
    }
    private void MyMeshDiagramViewport3D_Rot_y_HasChanged( object sender, MeshdiagramViewport3DPropertyChangeEventArgs<double> e )
    {
      if ( m_sliderfunctionality == SliderFunctionality.Rotator )
      {
        slider_y.Value = e.Value;
      }
    }
    private void MyMeshDiagramViewport3D_Rot_z_HasChanged( object sender, MeshdiagramViewport3DPropertyChangeEventArgs<double> e )
    {
      if ( m_sliderfunctionality == SliderFunctionality.Rotator )
      {
        slider_z.Value = e.Value;
      }
    }
    private void MyMeshDiagramViewport3D_Scale_HasChanged( object sender, MeshdiagramViewport3DPropertyChangeEventArgs<double> e )
    {
      this.slider_zoom.Value = e.Value;
    }
    #endregion private
    #region public
    public Brush CommandPanelBackgroundBrush
    {
      get
      {
        return this.CommandPanel.Background;
      }
      set
      {
        this.CommandPanel.Background = value;
      }
    }
    public void TryAutoZoom()
    {
      MyMeshDiagramViewport3D.TryAutoZoom();
    }
    public Panel3DUserControl()
    {
      InitializeComponent();
      //MyMeshDiagramViewport3D.iModelVisualIsSelected += new EventHandler( MyMeshDiagramViewport3D_iModelVisualIsSelected );
    }
    public void RefreshScene()
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      //MyMeshDiagramViewport3D.RefreshScene();
    }
    public void Clear()
    {
      if ( MyMeshDiagramViewport3D == null )
        return;
      MyMeshDiagramViewport3D.ClearElements();
    }
    public void AddModelVisual3D( IModelVisual3D mv3d )
    {
      MyMeshDiagramViewport3D.AddIModelVisual3D( mv3d );
    }
    public MeshDiagramViewport3D MeshDiagramViewport3D
    {
      get
      {
        return MyMeshDiagramViewport3D;
      }
    }
    #endregion public
  }
}
