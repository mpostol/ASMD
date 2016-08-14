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
using System.Windows.Media.Media3D;
using _3DTools;
using MeshDiagram3D.Utils;

namespace MeshDiagram3D.Presentation
{
  /// <summary>
  /// Interaction logic for MeshDiagramViewport3D.xaml
  /// </summary>
  public partial class MeshDiagramViewport3D: UserControl
  {
    #region readonly
    public const double defaultCamLocation_x = 10;
    public const double defaultCamLocation_y = 10;
    public const double defaultCamLocation_z = 10;
    #endregion
    #region private
    private ListOfIModelVisual3D elements;
    private ModelVisual3DFilter filter;
    private Trackball Trackball_3DTools;
    private void mainViewport_MouseLeftButtonDown( object sender, System.Windows.Input.MouseButtonEventArgs e )
    {
      IModelVisual3D selectedModel = elements.GetMatchedElement( e.GetPosition( mainViewportCanvas ), filter );
      if ( selectedModel != null )
      {
        if ( selectediModelVisual != null )
          selectediModelVisual.IsSelected = false;
        selectediModelVisual = selectedModel;
        selectediModelVisual.IsSelected = true;
        RaiseiModelVisualIsSelected();
      }
    }
    private void Trackball_3DTools_Initialisation()
    {
      //Trackball_3DTools initialisation:
      Trackball_3DTools = new Trackball();
      Trackball_3DTools.EventSource = mainViewport;
      this.mainViewport.Camera.Transform = Trackball_3DTools.Transform;
    }
    private static Transform3DGroup PrepareTransform3D( double Offset_X, double Offset_Y, double Offset_Z, double Scale_X, double Scale_Y, double Scale_Z, double Rot_X, double Rot_Y, double Rot_Z )
    {
      TranslateTransform3D MyTranslateTransform3D = new TranslateTransform3D( Offset_X, Offset_Y, Offset_Z ); //center point
      AxisAngleRotation3D AxisAngleRotator_rot_x = new AxisAngleRotation3D( new Vector3D( 1, 0, 0 ), Rot_X ); // setup rotation angle
      AxisAngleRotation3D AxisAngleRotator_rot_y = new AxisAngleRotation3D( new Vector3D( 0, 1, 0 ), Rot_Y ); // setup rotation angle
      AxisAngleRotation3D AxisAngleRotator_rot_z = new AxisAngleRotation3D( new Vector3D( 0, 0, 1 ), Rot_Z ); // setup rotation angle
      ScaleTransform3D ScaleTransform3D_zoom = new ScaleTransform3D( Scale_X, Scale_Y, Scale_Z );

      Transform3DGroup Transform3DGroup_transform = new Transform3DGroup();
      Transform3DGroup_transform.Children.Add( ScaleTransform3D_zoom );
      // the order of the following three is significant
      Transform3DGroup_transform.Children.Add( new RotateTransform3D( AxisAngleRotator_rot_y ) );
      Transform3DGroup_transform.Children.Add( new RotateTransform3D( AxisAngleRotator_rot_x ) );
      Transform3DGroup_transform.Children.Add( new RotateTransform3D( AxisAngleRotator_rot_z ) );

      Transform3DGroup_transform.Children.Add( MyTranslateTransform3D );
      return Transform3DGroup_transform;
    }
    private void SetCameraTransform()
    {
      mainViewport.Camera.Transform = PrepareTransform3D( 0, 0, 0, Scale, Scale, Scale, Rot_x, Rot_y, Rot_z );
      RaiseCameraIsChanged();
    }
    private void RaiseCameraIsChanged()
    {
      if ( CameraIsChanged != null )
        CameraIsChanged( this, EventArgs.Empty );
    }
    private void SetCameraLocation()
    {
      if ( mainViewport != null )
      {
        PerspectiveCamera camera = (PerspectiveCamera)mainViewport.Camera;
        Point3D position = new Point3D( CamLocation_x, CamLocation_y, CamLocation_z );
        Vector3D lookDirection = new Vector3D( -CamLocation_x, -CamLocation_y, -CamLocation_z );
        camera.Position = position;
        camera.LookDirection = lookDirection;

      }
      RaiseCameraIsChanged();
    }
    private void filter_FilterIsChanged( object sender, EventArgs e )
    {
      RefreshScene();
    }
    private void ClearViewport()
    {
      if ( mainViewport != null )
      {
        ModelVisual3D m;
        for ( int i = mainViewport.Children.Count - 1; i >= 0; i-- )
        {
          m = (ModelVisual3D)mainViewport.Children[ i ];
          if ( m.Content is DirectionalLight == false )
            mainViewport.Children.Remove( m );
        }
      }
      if ( mainViewportCanvas != null )
      {
        UIElement uielement;
        for ( int i = mainViewportCanvas.Children.Count - 1; i >= 0; i-- )
        {
          uielement = mainViewportCanvas.Children[ i ];
          mainViewportCanvas.Children.Remove( uielement );
        }
      }
    }
    #endregion private
    #region For transforms
    #region For transforms private
    private double camLocation_x = defaultCamLocation_x;
    private double camLocation_y = defaultCamLocation_y;
    private double camLocation_z = defaultCamLocation_z;
    private double rot_x = 0;
    private double rot_y = 0;
    private double rot_z = 0;
    private double scale = 1;
    private void Raise_CamLocation_x_HasChanged()
    {
      if ( CamLocation_x_HasChanged != null )
        CamLocation_x_HasChanged( this, new MeshdiagramViewport3DPropertyChangeEventArgs<double>( camLocation_x ) );
    }
    private void Raise_CamLocation_y_HasChanged()
    {
      if ( CamLocation_y_HasChanged != null )
        CamLocation_y_HasChanged( this, new MeshdiagramViewport3DPropertyChangeEventArgs<double>( camLocation_y ) );
    }
    private void Raise_CamLocation_z_HasChanged()
    {
      if ( CamLocation_z_HasChanged != null )
        CamLocation_z_HasChanged( this, new MeshdiagramViewport3DPropertyChangeEventArgs<double>( camLocation_z ) );
    }
    private void Raise_Rot_x_HasChanged()
    {
      if ( Rot_x_HasChanged != null )
        Rot_x_HasChanged( this, new MeshdiagramViewport3DPropertyChangeEventArgs<double>( rot_x ) );
    }
    private void Raise_Rot_y_HasChanged()
    {
      if ( Rot_y_HasChanged != null )
        Rot_y_HasChanged( this, new MeshdiagramViewport3DPropertyChangeEventArgs<double>( rot_y ) );
    }
    private void Raise_Rot_z_HasChanged()
    {
      if ( Rot_z_HasChanged != null )
        Rot_z_HasChanged( this, new MeshdiagramViewport3DPropertyChangeEventArgs<double>( rot_z ) );
    }
    private void Raise_Scale_HasChanged()
    {
      if ( Scale_HasChanged != null )
        Scale_HasChanged( this, new MeshdiagramViewport3DPropertyChangeEventArgs<double>( scale ) );
    }
    #endregion For transforms private
    #region For transforms public
    public double CamLocation_x
    {
      get { return camLocation_x; }
      set { camLocation_x = value; SetCameraLocation(); Raise_CamLocation_x_HasChanged(); }
    }
    public event EventHandler<MeshdiagramViewport3DPropertyChangeEventArgs<double>> CamLocation_x_HasChanged;
    public double CamLocation_y
    {
      get { return camLocation_y; }
      set { camLocation_y = value; SetCameraLocation(); Raise_CamLocation_y_HasChanged(); }
    }
    public event EventHandler<MeshdiagramViewport3DPropertyChangeEventArgs<double>> CamLocation_y_HasChanged;
    public double CamLocation_z
    {
      get { return camLocation_z; }
      set { camLocation_z = value; SetCameraLocation(); Raise_CamLocation_z_HasChanged(); }
    }
    public event EventHandler<MeshdiagramViewport3DPropertyChangeEventArgs<double>> CamLocation_z_HasChanged;
    public double Rot_x
    {
      get { return rot_x; }
      set { rot_x = value; SetCameraTransform(); Raise_Rot_x_HasChanged(); }
    }
    public event EventHandler<MeshdiagramViewport3DPropertyChangeEventArgs<double>> Rot_x_HasChanged;
    public double Rot_y
    {
      get { return rot_y; }
      set { rot_y = value; SetCameraTransform(); Raise_Rot_y_HasChanged(); }
    }
    public event EventHandler<MeshdiagramViewport3DPropertyChangeEventArgs<double>> Rot_y_HasChanged;
    public double Rot_z
    {
      get { return rot_z; }
      set { rot_z = value; SetCameraTransform(); Raise_Rot_z_HasChanged(); }
    }
    public event EventHandler<MeshdiagramViewport3DPropertyChangeEventArgs<double>> Rot_z_HasChanged;
    public double Scale
    {
      get { return scale; }
      set { scale = value; SetCameraTransform(); Raise_Scale_HasChanged(); }
    }
    public event EventHandler<MeshdiagramViewport3DPropertyChangeEventArgs<double>> Scale_HasChanged;
    public double DistanceFromCenter
    {
      get
      {
        return Math.Sqrt( CamLocation_x * CamLocation_x + CamLocation_y * CamLocation_y + CamLocation_z * CamLocation_z );
      }
    }
    #endregion For transforms public
    #endregion For transforms
    #region item is selected
    public IModelVisual3D selectediModelVisual = null;
    public IModelVisual3D SelectedIModelVisual
    {
      get
      {
        return selectediModelVisual;
      }
    }
    public event EventHandler IModelVisualIsSelected;
    private void RaiseiModelVisualIsSelected()
    {
      if ( IModelVisualIsSelected != null )
      {
        IModelVisualIsSelected( this, EventArgs.Empty );
      }
    }
    #endregion item is selected
    #region public
    public void RefreshScene()
    {
      ClearViewport();
      AddModels();
    }
    public event EventHandler CameraIsChanged;
    public Camera GetCamera()
    {
      return mainViewport.Camera;
    }
    public void ClearElements()
    {
      this.ClearViewport();
      elements.Clear();
    }
    public void AddModels()
    {
      if ( elements != null && mainViewport != null )
      {
        PerspectiveCamera camera = (PerspectiveCamera)mainViewport.Camera;
        Vector3D newlookdirection = camera.LookDirection;
        bool success;
        Viewport3DVisual vp3dv = MeshDiagram3DMath.GetViewport3DVisual( mainViewport, out success );
        if ( success )
          foreach ( IModelVisual3D element in elements )
          {
            this.mainViewport.Children.Add( element.GetModelVisual3D( filter, false ) ); // this is the beginning so no item is selected

            this.mainViewportCanvas.Children.Add( element.GetUIElement( filter, vp3dv ) );
          }
      }
    }
    public ModelVisual3DFilter Filter
    {
      get { return filter; }
    }
    internal void AddIModelVisual3D( IModelVisual3D mv3d )
    {
      this.mainViewport.Children.Add( mv3d.GetModelVisual3D( ModelVisual3DFilter.AllOn, false ) );// this is the beginning so no item is selected
      elements.Add( mv3d );
      mv3d.Register( this );
    }
    public MeshDiagramViewport3D()
    {
      InitializeComponent();
      SetCameraTransform();
      filter = ModelVisual3DFilter.AllOnExceptTexts;
      filter.FilterIsChanged += new EventHandler( filter_FilterIsChanged );
      elements = new ListOfIModelVisual3D();
      //RefreshScene();
      Trackball_3DTools_Initialisation();
    }
    #endregion public
    #region AutoZoom
    public void TryAutoZoom()
    {
      try
      {
        AutoZoom();
      }
      catch ( Exception ex )
      {
        MessageBox.Show( String.Format( "Cannot perform auto zoom (possible 3D scene is too small (other reason: {0})", ex.Message ) );
      }
    }
    /// <summary>
    /// Test whether curent 3D scene is too big for current Viewport3DVisual: vp3dv  .
    /// </summary>
    /// <param name="vp3dv">Current Viewport3DVisual.</param>
    /// <param name="success">if set to <c>true</c> the scene is too big for this Viewport.</param>
    /// <returns></returns>
    private static bool TooBig( Viewport3DVisual vp3dv, out bool success )
    {
      Rect r = MeshDiagram3DMath.Get2DBoundingBox( vp3dv, out success );
      if ( success && r.Height > 0 && r.Width > 0 )
      {
        if ( r.Left < 0 || r.Top < 0 || r.Right > vp3dv.Viewport.Width || r.Bottom > vp3dv.Viewport.Height )
          return true;
      }
      else
      {
        //The vieweport has 0 size
        success = false;
      }
      return false;
    }
    private void AutoZoom()
    {
      bool success;
      Viewport3DVisual vp3dv = MeshDiagram3DMath.GetViewport3DVisual( mainViewport, out  success );
      if ( TooBig( vp3dv, out success ) && success )
      {
        while ( TooBig( vp3dv, out success ) && success )
        {
          Scale += 0.1;
        }
        while ( !TooBig( vp3dv, out success ) && Scale > 0 && success )
        {
          Scale -= 0.01;
        }
        Scale += 0.01;
      }
      else
      {
        while ( !TooBig( vp3dv, out success ) && success )
        {
          Scale -= 0.1;
          if ( Scale <= 0 )
          {
            Scale = 0.01;
            break;
          }
        }
        while ( TooBig( vp3dv, out success ) && success )
        {
          Scale += 0.01;
        }
      }
    }
    #endregion AutoZoom
  }
}
