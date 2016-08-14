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
using System.Windows.Media.Media3D;
using _3DTools;

namespace MeshDiagram3D.Utils
{
  public class MeshDiagram3DMath
  {
    #region  Helpers
    public static Vector3D Transform3DVector( Transform3D transform, Vector3D vector )
    {
      Point3D input = new Point3D( vector.X, vector.Y, vector.Z );
      Point3D output;
      if ( transform.TryTransform( input, out output ) )
      {
        return new Vector3D( output.X, output.Y, output.Z );
      }
      return vector;
    }

    /// <summary>
    /// Gets the 2D bounding box.
    /// </summary>
    /// <param name="modelVisual3D">The model visual 3D.</param>
    /// <param name="success">if set to <c>true</c> [success].</param>
    /// <returns></returns>
    public static Rect Get2DBoundingBox( ModelVisual3D modelVisual3D, out bool success )
    {
      if ( modelVisual3D != null )
      {
        Viewport3DVisual vp3dv = GetViewport3DVisual( modelVisual3D, out success );
        if ( success )
          return Get2DBoundingBox( modelVisual3D, vp3dv, out success );
      }
      success = false;
      return new Rect();
    }
    /// <summary>
    /// Gets the 2D bounding box of all elements located on the view port 3d.
    /// </summary>
    /// <param name="viewPort3DVisual">The view port 3D.</param>
    /// <returns></returns>
    public static Rect Get2DBoundingBox( Viewport3DVisual viewPort3DVisual, out bool success )
    {
      bool transoformationMatrixCalculationFinishesOK;
      Matrix3D transoformationMatrix = MathUtils.TryWorldToViewportTransform( viewPort3DVisual,
          out transoformationMatrixCalculationFinishesOK );
      if ( !transoformationMatrixCalculationFinishesOK )
      {
        success = false;
        return new Rect();
      }
      bool firstPoint = true;
      success = true;
      Rect rectangleToBeReturned = new Rect();
      foreach ( Visual3D visual3D in viewPort3DVisual.Children )
      {
        if ( !success )
          break;
        ModelVisual3D modelVisual3D = visual3D as ModelVisual3D;
        if ( modelVisual3D != null )
        {
          if ( firstPoint )
          {
            rectangleToBeReturned = Get2DBoundingBox( modelVisual3D, viewPort3DVisual, transoformationMatrix, out success );
            firstPoint = false;
          }
          else
          {
            rectangleToBeReturned.Union( Get2DBoundingBox( modelVisual3D, viewPort3DVisual, transoformationMatrix, out success ) );
          }
        }

      }
      return rectangleToBeReturned;
    }
    public static Viewport3DVisual GetViewport3DVisual( DependencyObject visual, out bool success )
    {
      if ( visual is Viewport3D )
      {
        //when Viewport3D is passed first children is taken for further processing
        visual = ( (Viewport3D)visual ).Children[ 0 ];
      }
      Viewport3DVisual viewport;
      if ( !( visual is Visual3D ) )
      {
        throw new ArgumentException( "Must be of type Visual3D or Viewport3D.", "visual" );
      }
      while ( visual != null )
      {
        if ( !( visual is ModelVisual3D ) )
        {
          break;
        }
        visual = VisualTreeHelper.GetParent( visual );
      }
      viewport = visual as Viewport3DVisual;
      if ( viewport == null && visual != null )
      {
        // In WPF 3D v1 the only possible configuration is a chain of
        // ModelVisual3Ds leading up to a Viewport3DVisual.
        throw new ApplicationException(
            String.Format( "Unsupported type: '{0}'.  Expected tree of ModelVisual3Ds leading up to a Viewport3DVisual.",
            visual.GetType().FullName ) );
      }
      if ( viewport == null )
        success = false;
      else
        success = true;
      return viewport;
    }
    /// <summary>
    /// Gets the cross product of two 3d vectors.
    /// 
    /// Let u and v be two vectors given by their 3 components as follows
    /// u = [ x1 , y1 , z1 ] and v = [ x2 , y2 , z2 ]
    /// The cross product, noted by x, of the two vectors u and v given above is another vector w given by
    /// w = u x v = [ x1 , y1 , z1 ] x [ x2 , y2 , z2 ] = [ x , y , z ]
    /// with the components x, y and z given by:
    /// x = y1*z2 - z1*y2 , y = z1*x2 - x1*z2 and z = x1*y2 - y1*x2
    /// 
    /// </summary>
    /// <param name="U">The U vector.</param>
    /// <param name="V">The V vector.</param>
    /// <returns>cross product of two 3d vectors</returns>
    public static Vector3D GetCrossProduct( Vector3D U, Vector3D V )
    {
      return new Vector3D( U.Y * V.Z - U.Z * V.Y, U.Z * V.X - U.X * V.Z, U.X * V.Y - U.Y * V.X );
    }
    #region BoundingBox helpers
    private static Rect Get2DBoundingBox( ModelVisual3D modelVisual3D, Viewport3DVisual viewPort3DVisual, out bool success )
    {
      if ( modelVisual3D == null )
        throw new ArgumentNullException( "modelVisual3D" );
      if ( viewPort3DVisual == null )
        throw new ArgumentNullException( "viewPort3DVisual" );
      bool transoformationMatrixCalculationFinishesOK;
      Matrix3D transoformationMatrix = MathUtils.TryWorldToViewportTransform( viewPort3DVisual,
          out transoformationMatrixCalculationFinishesOK );
      if ( !transoformationMatrixCalculationFinishesOK )
      {
        success = false;
        return new Rect();
      }
      return Get2DBoundingBox( modelVisual3D, viewPort3DVisual, transoformationMatrix, out success );
    }
    private static Rect Get2DBoundingBox( ModelVisual3D modelVisual3D, Viewport3DVisual viewPort3DVisual, Matrix3D transoformationMatrix, out bool success )
    {
      bool firstPoint = true;
      Rect rectangleToBeReturned = new Rect();
      if ( modelVisual3D.Content is GeometryModel3D )
      {
        GeometryModel3D geometryModel3D =
            (GeometryModel3D)modelVisual3D.Content;

        if ( geometryModel3D.Geometry is MeshGeometry3D )
        {
          MeshGeometry3D mg3d =
              (MeshGeometry3D)geometryModel3D.Geometry;
          Get2DBoundingBoxFromPoint3DCollection( transoformationMatrix, ref firstPoint, ref rectangleToBeReturned, mg3d.Positions );
        }
      }
      else if ( modelVisual3D.Content is Model3DGroup )
      {
        Model3DGroup m3dg = (Model3DGroup)modelVisual3D.Content;
        Rect3D myR3D = m3dg.Bounds;
        Get2DBoundingBoxFromPoint3DCollection( transoformationMatrix, ref firstPoint,
          ref rectangleToBeReturned, GetPoint3DCollectionFromRect3D( myR3D ) );
      }
      success = true;
      foreach ( ModelVisual3D child in modelVisual3D.Children )
      {
        if ( !success )
          break;
        if ( firstPoint )
        {
          rectangleToBeReturned = Get2DBoundingBox( child, viewPort3DVisual, out success );
          firstPoint = false;
        }
        else
        {
          rectangleToBeReturned.Union( Get2DBoundingBox( child, viewPort3DVisual, out success ) );
        }
      }
      return rectangleToBeReturned;
    }
    private static Point3DCollection GetPoint3DCollectionFromRect3D( Rect3D myR3D )
    {
      Point3DCollection P3DCollection = new Point3DCollection();
      P3DCollection.Add( new Point3D( myR3D.X, myR3D.Y, myR3D.Z ) );
      P3DCollection.Add( new Point3D( myR3D.X + myR3D.SizeX, myR3D.Y, myR3D.Z ) );
      P3DCollection.Add( new Point3D( myR3D.X, myR3D.Y + myR3D.SizeY, myR3D.Z ) );
      P3DCollection.Add( new Point3D( myR3D.X, myR3D.Y, myR3D.Z + myR3D.SizeZ ) );
      P3DCollection.Add( new Point3D( myR3D.X + myR3D.SizeX, myR3D.Y + myR3D.SizeY, myR3D.Z ) );
      P3DCollection.Add( new Point3D( myR3D.X + myR3D.SizeX, myR3D.Y + myR3D.SizeY, myR3D.Z + myR3D.SizeZ ) );
      P3DCollection.Add( new Point3D( myR3D.X, myR3D.Y + myR3D.SizeY, myR3D.Z + myR3D.SizeZ ) );
      P3DCollection.Add( new Point3D( myR3D.X + myR3D.SizeX, myR3D.Y + myR3D.SizeY, myR3D.Z + myR3D.SizeZ ) );
      return P3DCollection;
    }
    private static void Get2DBoundingBoxFromPoint3DCollection( Matrix3D transoformationMatrix, ref bool firstPoint, ref Rect rectangleToBeReturned, Point3DCollection P3DCollection )
    {
      foreach ( Point3D point3D in P3DCollection )
      {
        Point point2D = Get2DPointBasedOnPoint3DAndTRansformation( transoformationMatrix, point3D );
        if ( firstPoint )
        {
          rectangleToBeReturned = new Rect( point2D, new Size( 1, 1 ) );
          firstPoint = false;
        }
        else
        {
          rectangleToBeReturned.Union( point2D );
        }
      }
    }
    private static Point Get2DPointBasedOnPoint3DAndTRansformation( Matrix3D transoformationMatrix, Point3D point3D )
    {
      Point3D point3Dtransformed = transoformationMatrix.Transform( point3D );
      Point point2D = new Point( point3Dtransformed.X, point3Dtransformed.Y );
      return point2D;
    }
    #endregion BoundingBox helpers


    //private static Matrix3D GetTransformationMatrixFromViewPort2D( Viewport3DVisual viewPort3DVisual )
    //{
    //  bool transoformationMatrixCalculationFinishesOK;
    //  Matrix3D transoformationMatrix =
    //      MathUtils.TryWorldToViewportTransform(viewPort3DVisual,
    //      out transoformationMatrixCalculationFinishesOK);
    //  if (!transoformationMatrixCalculationFinishesOK)
    //    throw new Exception("Transormation matrix cannot be calculated");
    //  return transoformationMatrix;
    //}
    public static Point Get2DPoint( Point3D point3d, Viewport3DVisual viewport3Dvisual )
    {
      bool TransformationResultOK;
      Matrix3D m = MathUtils.TryWorldToViewportTransform( viewport3Dvisual, out TransformationResultOK );
      if ( !TransformationResultOK )
        return new Point( 0, 0 );
      Point3D pb = m.Transform( point3d );
      Point p2d = new Point( pb.X, pb.Y );
      return p2d;
    }
    #endregion
  }
}
