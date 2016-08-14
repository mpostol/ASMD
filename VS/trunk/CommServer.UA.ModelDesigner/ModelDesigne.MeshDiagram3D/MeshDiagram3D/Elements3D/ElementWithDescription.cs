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

using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using MeshDiagram3D.Presentation;
using MeshDiagram3D.Utils;

namespace MeshDiagram3D.Elements3D
{
  class ElementWithDescription: IModelVisual3D
  {
    #region public static
    /// <summary>
    /// Creates a ModelVisual3D containing a text label.
    /// </summary>
    /// <param name="text">The string to be drawn</param>
    /// <param name="textColor">The color of the text.</param>
    /// <param name="isDoubleSided">Visible from both sides?</param>
    /// <param name="height">Height of the characters</param>
    /// <param name="basePoint">The base point of the label</param>
    /// <param name="isBasePointCenterPoint">if set to <c>true</c> the base point 
    /// is center point of the label.</param>
    /// <param name="vectorOver">Horizontal direction of the label</param>
    /// <param name="vectorUp">Vertical direction of the label</param>
    /// <returns>Suitable for adding to your Viewport3D</returns>
    /// <remarks>Two vectors: vectorOver and vectorUp are creating the surface 
    /// on which we are drawing the text. Both those vectors are used for 
    /// calculation of label size, so it is resonable that each co-ordinate 
    /// should be 0 or 1. e.g. [1,1,0] or [1,0,1], etc...</remarks>
    public static ModelVisual3D CreateTextLabel3D(
        string text,
        Brush textColor,
        bool isDoubleSided,
        double height,
        Point3D basePoint,
        bool isBasePointCenterPoint,
        Vector3D vectorOver,
        Vector3D vectorUp )
    {
      // First we need a textbox containing the text of our label
      TextBlock textblock = new TextBlock( new Run( text ) );
      textblock.Foreground = textColor; // setting the text color
      textblock.FontFamily = new FontFamily( "Arial" ); // setting the font to be used
      // Now use that TextBox as the brush for a material
      DiffuseMaterial mataterialWithLabel = new DiffuseMaterial();
      // Allows the application of a 2-D brush, 
      // like a SolidColorBrush or TileBrush, to a diffusely-lit 3-D model. 
      // we are creating the brush from the TextBlock    
      mataterialWithLabel.Brush = new VisualBrush( textblock );
      //calculation of text width (assumming that characters are square):
      double width = text.Length * height;
      // we need to find the four corners
      // p0: the lower left corner;  p1: the upper left
      // p2: the lower right; p3: the upper right
      Point3D p0 = basePoint;
      // when the base point is the center point we have to set it up in different way
      if ( isBasePointCenterPoint )
        p0 = basePoint - width / 2 * vectorOver - height / 2 * vectorUp;
      Point3D p1 = p0 + vectorUp * 1 * height;
      Point3D p2 = p0 + vectorOver * width;
      Point3D p3 = p0 + vectorUp * 1 * height + vectorOver * width;
      // we are going to create object in 3D now:
      // this object will be painted using the (text) brush created before
      // the object is rectangle made of two triangles (on each side).
      MeshGeometry3D mg_RestangleIn3D = new MeshGeometry3D();
      mg_RestangleIn3D.Positions = new Point3DCollection();
      mg_RestangleIn3D.Positions.Add( p0 );    // 0
      mg_RestangleIn3D.Positions.Add( p1 );    // 1
      mg_RestangleIn3D.Positions.Add( p2 );    // 2
      mg_RestangleIn3D.Positions.Add( p3 );    // 3
      // when we want to see the text on both sides:
      if ( isDoubleSided )
      {
        mg_RestangleIn3D.Positions.Add( p0 );    // 4
        mg_RestangleIn3D.Positions.Add( p1 );    // 5
        mg_RestangleIn3D.Positions.Add( p2 );    // 6
        mg_RestangleIn3D.Positions.Add( p3 );    // 7
      }
      mg_RestangleIn3D.TriangleIndices.Add( 0 );
      mg_RestangleIn3D.TriangleIndices.Add( 3 );
      mg_RestangleIn3D.TriangleIndices.Add( 1 );
      mg_RestangleIn3D.TriangleIndices.Add( 0 );
      mg_RestangleIn3D.TriangleIndices.Add( 2 );
      mg_RestangleIn3D.TriangleIndices.Add( 3 );
      // when we want to see the text on both sides:
      if ( isDoubleSided )
      {
        mg_RestangleIn3D.TriangleIndices.Add( 4 );
        mg_RestangleIn3D.TriangleIndices.Add( 5 );
        mg_RestangleIn3D.TriangleIndices.Add( 7 );
        mg_RestangleIn3D.TriangleIndices.Add( 4 );
        mg_RestangleIn3D.TriangleIndices.Add( 7 );
        mg_RestangleIn3D.TriangleIndices.Add( 6 );
      }
      // texture coordinates must be set to
      // stretch the TextBox brush to cover 
      // the full side of the 3D label.
      mg_RestangleIn3D.TextureCoordinates.Add( new Point( 0, 1 ) );
      mg_RestangleIn3D.TextureCoordinates.Add( new Point( 0, 0 ) );
      mg_RestangleIn3D.TextureCoordinates.Add( new Point( 1, 1 ) );
      mg_RestangleIn3D.TextureCoordinates.Add( new Point( 1, 0 ) );
      // when the label is double sided:
      if ( isDoubleSided )
      {
        mg_RestangleIn3D.TextureCoordinates.Add( new Point( 1, 1 ) );
        mg_RestangleIn3D.TextureCoordinates.Add( new Point( 1, 0 ) );
        mg_RestangleIn3D.TextureCoordinates.Add( new Point( 0, 1 ) );
        mg_RestangleIn3D.TextureCoordinates.Add( new Point( 0, 0 ) );
      }
      // Now it is time to create ModelVisual3D (that we are going to return):
      ModelVisual3D result = new ModelVisual3D();
      // we are setting the content:
      // our 3D rectangle object covered with materila that is made of label (TextBox with text)
      result.Content = new GeometryModel3D( mg_RestangleIn3D, mataterialWithLabel );
      ;
      return result;
    }
    #endregion public static
    #region private
    private bool isSelected;
    private BasicModel3DModel element;
    private Vector3D TextVectorOver;
    private Vector3D TextVectorUp;
    private double x, y, z, size;
    private bool displayDescriptionFrontToCamera;
    protected MeshDiagramViewport3D meshDiagramViewport3D;
    private ModelVisual3D lastModelVisual3D;
    private ModelVisual3DFilter lastModelVisual3DFilter = ModelVisual3DFilter.AllOff;
    private Material materialNormal;
    private Material materialSelected;
    private ModelType mModelType;
    private void meshDiagramViewport3D_CameraIsChanged( object sender, System.EventArgs e )
    {
      if ( lastModelVisual3D != null && displayDescriptionFrontToCamera )
      {
        //        Transform3D tr = meshDiagramViewport3D.GetCamera().Transform;
        Viewport3DVisual mv3dv = Utilities.GetViewport3DVisual( lastModelVisual3D );
        Matrix3D mt3d = Utilities.GetTotalTransformModelVisual3D( lastModelVisual3D );
        Matrix3D mt3dcamera = Utilities.GetCameraTransform( mv3dv );
        //mt3d.Invert();
        Transform3D tr = new MatrixTransform3D( mt3d );
        ProjectionCamera camera = mv3dv.Camera as ProjectionCamera;
        Vector3D BaseTextVectorOver = MeshDiagram3DMath.GetCrossProduct( camera.LookDirection, camera.UpDirection );
        //Vector3D BaseTextVectorUp = new Vector3D( -camera.LookDirection.Z * camera.LookDirection.X, -camera.LookDirection.Z * camera.LookDirection.Y, camera.LookDirection.Y * camera.LookDirection.Y + camera.LookDirection.X * camera.LookDirection.X );
        Vector3D BaseTextVectorUp = new Vector3D( camera.UpDirection.X, camera.UpDirection.Y, camera.UpDirection.Z );

        //bool TransformationResultOK;
        //Matrix3D m = _3DTools.MathUtils.TryWorldToViewportTransform( mv3dv, out TransformationResultOK );
        ////BaseTextVectorOver.Normalize();
        //// BaseTextVectorUp.Normalize();

        //// model.Transform = tr;
        //lastModelVisual3D.Children.Clear();
        //// TextVectorOver = Panel3DMath.Transform3DVector( tr, TextVectorOver );
        //// TextVectorUp = Panel3DMath.Transform3DVector( tr, TextVectorUp );
        //if ( TransformationResultOK )
        //{
        //  TextVectorOver = BaseTextVectorOver * m;
        //  TextVectorUp = BaseTextVectorUp * m;
        //}
        //else
        //{
        //  TextVectorOver = BaseTextVectorOver * mt3dcamera;
        //  TextVectorUp = BaseTextVectorUp * mt3dcamera;
        //}
        TextVectorOver = BaseTextVectorOver;
        TextVectorUp = BaseTextVectorUp;

        TextVectorOver.Normalize();
        TextVectorUp.Normalize();
        FillModel( false );//TODO: I am not sure whether false is OK??
      }
    }
    private void FillModel( bool Selected )
    {
      if ( lastModelVisual3DFilter.Texts3D )
      {
        lastModelVisual3D.Children.Add( CreateTextLabel3D(
          Text, new SolidColorBrush( Colors.Black ),
          true, Size, new Point3D( X, Y, Z ), false,
         TextVectorOver, TextVectorUp ) );
      }
      lastModelVisual3D.Children.Add( ( (IModelVisual3D)element ).GetModelVisual3D( lastModelVisual3DFilter, Selected ) );
    }
    private void UpdateLastModelVisual3D()
    {
      element = new BasicModel3DModel( materialNormal, materialSelected, x, y, z, Size, Size, Size, true, this.mModelType );
    }
    #endregion
    #region pubic
    public double X { get { return x; } set { x = value; UpdateLastModelVisual3D(); } }
    public double Y { get { return y; } set { y = value; UpdateLastModelVisual3D(); } }
    public double Z { get { return z; } set { z = value; UpdateLastModelVisual3D(); } }
    public double Size { get { return size; } set { size = value; UpdateLastModelVisual3D(); } }
    public Material MaterialNormal { get { return materialNormal; } set { materialNormal = value; UpdateLastModelVisual3D(); } }
    public Material MaterialSelected { get { return materialSelected; } set { materialSelected = value; UpdateLastModelVisual3D(); } }
    public ModelType ModelType { get { return mModelType; } set { mModelType = value; UpdateLastModelVisual3D(); } }
    public string Text { get; set; }
    public virtual bool CanBeSelected
    {
      get
      {
        return true;
      }
    }
    public Point3D Point3D
    {
      get
      {
        return new Point3D( x, y, z );
      }
    }
    #endregion public
    #region constructor
    public ElementWithDescription( double x, double y, double z, double size, string description,
      Material MaterialInNormalState, Material MaterialInSelectedState,
      bool displayDescriptionFrontToCamera, ModelType modelType )
    {
      this.size = size;
      this.x = x;
      this.y = y;
      this.z = z;
      this.Text = description;
      this.materialNormal = MaterialInNormalState;
      this.materialSelected = MaterialInSelectedState;
      this.mModelType = modelType;
      element = new BasicModel3DModel( MaterialNormal, MaterialSelected, x, y, z, size, size, size, true, this.ModelType );
      TextVectorOver = new Vector3D( 1, 0, 0 );
      TextVectorUp = new Vector3D( 0, 1, 0 );
      this.displayDescriptionFrontToCamera = displayDescriptionFrontToCamera;
    }
    #endregion constructor
    #region IModelVisual3D Members
    object IModelVisual3D.Tag { get; set; }
    bool IModelVisual3D.IsSelected
    {
      get { return isSelected; }
      set
      {
        if ( this.lastModelVisual3D != null && isSelected != value )
        {
          this.isSelected = value;
          lastModelVisual3D.Children.Clear();
          FillModel( isSelected );
        }
        ( (IModelVisual3D)element ).IsSelected = value;
      }
    }

    void IModelVisual3D.Register( MeshDiagramViewport3D mdv3d )
    {
      if ( meshDiagramViewport3D != null )
        meshDiagramViewport3D.CameraIsChanged -= new System.EventHandler( meshDiagramViewport3D_CameraIsChanged );
      meshDiagramViewport3D = mdv3d;
      meshDiagramViewport3D.CameraIsChanged += new System.EventHandler( meshDiagramViewport3D_CameraIsChanged );
    }
    void IModelVisual3D.Unregister()
    {
      if ( meshDiagramViewport3D != null )
      {
        meshDiagramViewport3D.CameraIsChanged -= new System.EventHandler( meshDiagramViewport3D_CameraIsChanged );
        meshDiagramViewport3D = null;
      }
    }
    bool IModelVisual3D.Match( Point point2D )
    {
      bool success = false;
      Rect my2DRect = MeshDiagram3DMath.Get2DBoundingBox( lastModelVisual3D, out success );
      if ( !success )
        return false;
      return my2DRect.Contains( point2D );
    }
    ModelVisual3D IModelVisual3D.GetModelVisual3D( ModelVisual3DFilter FilterSettings, bool Selected )
    {
      if ( lastModelVisual3D == null )
        lastModelVisual3D = new ModelVisual3D();
      else
        lastModelVisual3D.Children.Clear();
      lastModelVisual3DFilter = FilterSettings;
      FillModel( Selected );
      return lastModelVisual3D;
    }


    //void IModelVisual3D.UpdateViewToLookDirection( Vector3D LookDirection )
    //{
    //  Vector3D look = LookDirection;
    //  look.Normalize();
    //  TextVectorOver = new Vector3D( -look.Y, look.X, 0 );
    //  TextVectorUp = new Vector3D( -look.Z * look.X, -look.Z * look.Y, look.Y * look.Y + look.X * look.X );
    //  TextVectorOver.Normalize();
    //  TextVectorUp.Normalize();
    //}
    UIElement IModelVisual3D.GetUIElement( ModelVisual3DFilter FilterSettings, Viewport3DVisual DestinationViewport3D )
    {
      if ( FilterSettings.Texts2D )
      {
        TextBlock tb = new TextBlock();
        tb.FontSize += 1;
        tb.FontWeight = FontWeights.Bold;
        tb.Foreground = new SolidColorBrush( Colors.DarkGreen );
        tb.Text = Text;
        Point p2d = MeshDiagram3DMath.Get2DPoint( this.Point3D, DestinationViewport3D );
        Canvas.SetTop( tb, p2d.Y + 0 );
        Canvas.SetLeft( tb, p2d.X + 10 );
        return tb;
      }
      else
        return new UIElement();
    }
    #endregion //IModelVisual3D Members
  }
}
