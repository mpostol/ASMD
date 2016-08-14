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
using System.Windows.Media;
using System.Windows.Media.Media3D;
using MeshDiagram3D.Presentation;
using MeshDiagram3D.Utils;

namespace MeshDiagram3D.Elements3D
{
  public enum ModelType
  {
    Tetraeder,
    Cube
  }
  public class BasicModel3DModel: IModelVisual3D
  {
    #region private
    protected MeshDiagramViewport3D meshDiagramViewport3D;
    private ModelVisual3D lastModelVisual3D = null;
    private ModelVisual3DFilter lastFilterSettings = ModelVisual3DFilter.AllOff;
    private Material materialNormal;
    private Material materialSelected;
    private ModelType mModelType;
    private string mText;
    private bool isSelected = false;
    private double mX;
    private double mY;
    private double mZ;
    private double mSizeX;
    private double mSizeY;
    private double mSizeZ;
    private bool mCentric;

    private ModelVisual3D PrepareModelVisual3D( ModelVisual3DFilter FilterSettings, bool Selected )
    {
      if ( FilterSettings.Triangles )
      {

        if ( Centric )
        {
          return CreateModel3DModel( Selected ? materialSelected : materialNormal,
            X, Y, Z, SizeX, SizeY, SizeZ, ModelType );
        }
        else
        {
          return CreateModel3DModel( Selected ? materialSelected : materialNormal,
            X + SizeX / 2, Y + SizeY / 2, Z + SizeZ / 2, SizeX, SizeY, SizeZ, ModelType );
        }

      }
      else
        return new ModelVisual3D();
    }
    private void UpdateLastModelVisual3D()
    {
      lastModelVisual3D.Children.Clear();
      lastModelVisual3D.Children.Add( PrepareModelVisual3D( this.lastFilterSettings, this.isSelected ) );
    }
    #endregion
    #region static
    static private ModelVisual3D CreateModel3DModel( Material material, double X, double Y, double Z,
                                                         double sizeX, double sizeY, double sizeZ, ModelType mt )
    {
      Model3DGroup cube = CreateCubeModel3DGroup( material, X, Y, Z, sizeX, sizeY, sizeZ );
      switch ( mt )
      {
        case ModelType.Cube:
          cube = CreateCubeModel3DGroup( material, X, Y, Z, sizeX, sizeY, sizeZ );
          break;
        case ModelType.Tetraeder:
          cube = CreateTetraederModel3DGroup( material, X, Y, Z, sizeX, sizeY, sizeZ );
          break;
      }
      ModelVisual3D model = new ModelVisual3D();
      model.Content = cube;
      return model;
    }
    static private Model3DGroup CreateCubeModel3DGroup
   ( Material material, double X, double Y, double Z,
   double sizeX, double sizeY, double sizeZ )
    {
      Model3DGroup cube = new Model3DGroup();
      Point3D p0 = new Point3D( X - sizeX / 2, Y - sizeY / 2, Z - sizeZ / 2 );
      Point3D p1 = new Point3D( X + sizeX / 2, Y - sizeY / 2, Z - sizeZ / 2 );
      Point3D p2 = new Point3D( X + sizeX / 2, Y - sizeY / 2, Z + sizeZ / 2 );
      Point3D p3 = new Point3D( X - sizeX / 2, Y - sizeY / 2, Z + sizeZ / 2 );
      Point3D p4 = new Point3D( X - sizeX / 2, Y + sizeY / 2, Z - sizeZ / 2 );
      Point3D p5 = new Point3D( X + sizeX / 2, Y + sizeY / 2, Z - sizeZ / 2 );
      Point3D p6 = new Point3D( X + sizeX / 2, Y + sizeY / 2, Z + sizeZ / 2 );
      Point3D p7 = new Point3D( X - sizeX / 2, Y + sizeY / 2, Z + sizeZ / 2 );

      //front side triangles
      cube.Children.Add( CreateSquareModel( material, p3, p2, p1, p0 ) );
      //right side triangles               
      cube.Children.Add( CreateSquareModel( material, p4, p5, p6, p7 ) );
      //back side triangles                
      cube.Children.Add( CreateSquareModel( material, p2, p3, p7, p6 ) );
      //left side triangles               
      cube.Children.Add( CreateSquareModel( material, p0, p1, p5, p4 ) );
      //top side triangles                 
      cube.Children.Add( CreateSquareModel( material, p1, p2, p6, p5 ) );
      //bottom side triangles              
      cube.Children.Add( CreateSquareModel( material, p7, p3, p0, p4 ) );
      return cube;
    }

    static private Model3DGroup CreateTetraederModel3DGroup
  ( Material material, double X, double Y, double Z,
  double sizeX, double sizeY, double sizeZ )
    {
      Model3DGroup tetraeder = new Model3DGroup();
      Point3D p0 = new Point3D( X - sizeX / 2, Y - sizeY / 2, Z - sizeZ / 2 );
      Point3D p2 = new Point3D( X + sizeX / 2, Y - sizeY / 2, Z + sizeZ / 2 );
      Point3D p5 = new Point3D( X + sizeX / 2, Y + sizeY / 2, Z - sizeZ / 2 );
      Point3D p7 = new Point3D( X - sizeX / 2, Y + sizeY / 2, Z + sizeZ / 2 );
      tetraeder.Children.Add( CreateTriangleModel( material, p0, p5, p7 ) );
      tetraeder.Children.Add( CreateTriangleModel( material, p0, p2, p5 ) );
      tetraeder.Children.Add( CreateTriangleModel( material, p0, p7, p2 ) );
      tetraeder.Children.Add( CreateTriangleModel( material, p5, p2, p7 ) );
      return tetraeder;
    }
    static private Model3DGroup CreateTriangleModel( Material material, Point3D p0, Point3D p1, Point3D p2 )
    {
      MeshGeometry3D mesh = new MeshGeometry3D();
      mesh.Positions.Add( p0 );
      mesh.Positions.Add( p1 );
      mesh.Positions.Add( p2 );
      mesh.TriangleIndices.Add( 0 );
      mesh.TriangleIndices.Add( 1 );
      mesh.TriangleIndices.Add( 2 );
      Vector3D normal = CalculateNormal( p0, p1, p2 );
      mesh.Normals.Add( normal );
      mesh.Normals.Add( normal );
      mesh.Normals.Add( normal );
      GeometryModel3D model = new GeometryModel3D(
          mesh, material );
      Model3DGroup group = new Model3DGroup();
      group.Children.Add( model );
      return group;
    }
    static private Model3DGroup CreateSquareModel( Material material, Point3D p0, Point3D p1, Point3D p2, Point3D p3 )
    {
      MeshGeometry3D mesh = new MeshGeometry3D();
      mesh.Positions.Add( p0 );
      mesh.Positions.Add( p1 );
      mesh.Positions.Add( p2 );
      mesh.Positions.Add( p3 );
      // 0,1,2,0,2,3
      mesh.TriangleIndices.Add( 2 );
      mesh.TriangleIndices.Add( 1 );
      mesh.TriangleIndices.Add( 0 );
      mesh.TriangleIndices.Add( 3 );
      mesh.TriangleIndices.Add( 2 );
      mesh.TriangleIndices.Add( 0 );
      mesh.TextureCoordinates = ( (PointCollection)new PointCollectionConverter().ConvertFromString( "0,1  0,0 1,0  1,1 " ) );
      //TODO: tamto texture coordinates powinny zostac przeniesione
      GeometryModel3D model = new GeometryModel3D(
          mesh, material );
      Model3DGroup group = new Model3DGroup();
      group.Children.Add( model );
      return group;
    }
    static private Vector3D CalculateNormal( Point3D p0, Point3D p1, Point3D p2 )
    {
      Vector3D v0 = new Vector3D(
          p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z );
      Vector3D v1 = new Vector3D(
          p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z );
      return Vector3D.CrossProduct( v0, v1 );
    }
    #endregion
    #region pubic
    public double X { get { return mX; } set { mX = value; UpdateLastModelVisual3D(); } }
    public double Y { get { return mY; } set { mY = value; UpdateLastModelVisual3D(); } }
    public double Z { get { return mZ; } set { mZ = value; UpdateLastModelVisual3D(); } }
    public double SizeX { get { return mSizeX; } set { mSizeX = value; UpdateLastModelVisual3D(); } }
    public double SizeY { get { return mSizeY; } set { mSizeY = value; UpdateLastModelVisual3D(); } }
    public double SizeZ { get { return mSizeZ; } set { mSizeZ = value; UpdateLastModelVisual3D(); } }
    public bool Centric { get { return mCentric; } set { mCentric = value; UpdateLastModelVisual3D(); } }
    public virtual string Text { get { return mText; } set { mText = value; UpdateLastModelVisual3D(); } }
    public ModelType ModelType { get { return mModelType; } set { mModelType = value; UpdateLastModelVisual3D(); } }
    public virtual bool CanBeSelected
    {
      get
      {
        return true;
      }
    }
    #endregion public
    #region constructor
    public BasicModel3DModel()
      : this( new DiffuseMaterial( new SolidColorBrush( Colors.DarkKhaki ) ),
      new DiffuseMaterial( new SolidColorBrush( Colors.Red ) ), 0, 0, 0, 1, 1, 1, true, ModelType.Tetraeder )
    {
    }
    public BasicModel3DModel( Material MaterialInNormalState, Material MaterialInSelectedState, double X, double Y, double Z,
      double sizeX, double sizeY, double sizeZ, bool centric, ModelType modelType )
    {
      this.mX = X;
      this.mY = Y;
      this.mZ = Z;
      this.mSizeX = sizeX;
      this.mSizeY = sizeY;
      this.mSizeZ = sizeZ;
      this.mCentric = centric;
      this.materialNormal = MaterialInNormalState;
      this.materialSelected = MaterialInSelectedState;
      this.mModelType = modelType;
    }
    #endregion constructor
    #region IModelVisual3D Members
    object IModelVisual3D.Tag { get; set; }
    void IModelVisual3D.Register( MeshDiagramViewport3D mdv3d )
    {
      meshDiagramViewport3D = mdv3d;
    }
    bool IModelVisual3D.IsSelected
    {
      get { return isSelected; }
      set
      {
        if ( this.lastModelVisual3D != null && isSelected != value )
        {
          this.isSelected = value;
          UpdateLastModelVisual3D();
        }
      }
    }
    void IModelVisual3D.Unregister()
    {
      meshDiagramViewport3D = null;
    }
    ModelVisual3D IModelVisual3D.GetModelVisual3D( ModelVisual3DFilter FilterSettings, bool Selected )
    {
      lastFilterSettings = FilterSettings;
      return lastModelVisual3D = PrepareModelVisual3D( FilterSettings, Selected );
    }
    bool IModelVisual3D.Match( Point point2D )
    {
      bool success = false;
      Rect my2DRect = MeshDiagram3DMath.Get2DBoundingBox( lastModelVisual3D, out success );
      if ( !success )
        return false;
      return my2DRect.Contains( point2D );
    }
    UIElement IModelVisual3D.GetUIElement( ModelVisual3DFilter FilterSettings, Viewport3DVisual DestinationViewport3D )
    {
      return new UIElement();
    }
    #endregion //IModelVisual3D Members
  }
}
