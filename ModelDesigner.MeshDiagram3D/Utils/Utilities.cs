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
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace MeshDiagram3D.Utils
{
  //saome functions are inspired on http://www.charlespetzold.com/3D/
  class Utilities
  {
    public static readonly Matrix3D ZeroMatrix = new Matrix3D( 0, 0, 0, 0, 0, 0, 0, 0,
                                                           0, 0, 0, 0, 0, 0, 0, 0 );
    public static Matrix3D GetTotalTransformModelVisual3D( ModelVisual3D mv3d )
    {
      Matrix3D matx = Matrix3D.Identity;
      DependencyObject obj = mv3d;
      while ( !( obj is Viewport3DVisual ) )
      {
        // This occurs when the visual is parent-less.
        if ( obj == null )
        {
          return ZeroMatrix;
        }

        else if ( obj is ModelVisual3D )
        {
          if ( ( obj as ModelVisual3D ).Transform != null )
            matx.Append( ( obj as ModelVisual3D ).Transform.Value );
        }

        else
        {
          throw new ApplicationException( "didn't end in Viewport3DVisual" );
        }

        obj = VisualTreeHelper.GetParent( obj );
      }

      // At this point, we know obj is Viewport3DVisual
      Viewport3DVisual vis = obj as Viewport3DVisual;
      Matrix3D matxViewport = GetTotalTransformViewport3DVisual( vis );
      matx.Append( matxViewport );

      return matx;
    }
    public static Matrix3D GetTotalTransformViewport3DVisual( Viewport3DVisual vis )
    {
      Matrix3D matx = GetCameraTransform( vis );
      matx.Append( GetViewportTransform( vis ) );
      return matx;
    }
    public static Matrix3D GetTotalTransformCamera( Camera cam, double aspectRatio )
    {
      Matrix3D matx = Matrix3D.Identity;

      if ( cam == null )
      {
        matx = ZeroMatrix;
      }

      else
      {
        if ( cam.Transform != null )
        {
          Matrix3D matxCameraTransform = cam.Transform.Value;

          if ( !matxCameraTransform.HasInverse )
          {
            matx = ZeroMatrix;
          }
          else
          {
            matxCameraTransform.Invert();
            matx.Append( matxCameraTransform );
          }
        }

        matx.Append( GetViewMatrix( cam ) );
        matx.Append( GetProjectionMatrix( cam, aspectRatio ) );
      }
      return matx;
    }
    public static Matrix3D GetViewportTransform( Viewport3DVisual vis )
    {
      return new Matrix3D( vis.Viewport.Width / 2, 0, 0, 0,
                          0, -vis.Viewport.Height / 2, 0, 0,
                          0, 0, 1, 0,
                                   vis.Viewport.X + vis.Viewport.Width / 2,
                                           vis.Viewport.Y + vis.Viewport.Height / 2, 0, 1 );

    }
    public static Matrix3D GetCameraTransform( Viewport3DVisual vis )
    {
      return GetTotalTransformCamera( vis.Camera,
                          vis.Viewport.Size.Width / vis.Viewport.Size.Height );
    }
    /// <summary>
    ///     Obtains the view transform matrix for a camera.
    /// </summary>
    /// <param name="camera">
    ///     Camera to obtain the 
    /// </param>
    /// <returns>
    ///     A Matrix3D objecvt with the camera view transform matrix,
    ///     or a Matrix3D with all zeros if the "camera" is null.
    /// </returns>
    /// <exception cref="TK">
    ///     if the 'camera' is neither of type MatrixCamera nor
    ///     ProjectionCamera.
    /// </exception>
    public static Matrix3D GetViewMatrix( Camera camera )
    {
      Matrix3D matx = Matrix3D.Identity;

      if ( camera == null )
      {
        matx = ZeroMatrix;
      }

      else if ( camera is MatrixCamera )
      {
        matx = ( camera as MatrixCamera ).ViewMatrix;
      }
      else if ( camera is ProjectionCamera )
      {
        ProjectionCamera projcam = camera as ProjectionCamera;

        Vector3D zAxis = -projcam.LookDirection;
        zAxis.Normalize();

        Vector3D xAxis = Vector3D.CrossProduct( projcam.UpDirection, zAxis );
        xAxis.Normalize();

        Vector3D yAxis = Vector3D.CrossProduct( zAxis, xAxis );
        Vector3D pos = (Vector3D)projcam.Position;

        matx = new Matrix3D( xAxis.X, yAxis.X, zAxis.X, 0,
                                     xAxis.Y, yAxis.Y, zAxis.Y, 0,
                                     xAxis.Z, yAxis.Z, zAxis.Z, 0,
                                     -Vector3D.DotProduct( xAxis, pos ),
                                     -Vector3D.DotProduct( yAxis, pos ),
                                     -Vector3D.DotProduct( zAxis, pos ), 1 );

      }

      else if ( camera != null )
      {
        throw new ApplicationException( "ViewMatrix" );
      }
      return matx;
    }
    public static Matrix3D GetProjectionMatrix( Camera cam, double aspectRatio )
    {
      Matrix3D matx = Matrix3D.Identity;

      if ( cam == null )
      {
        matx = ZeroMatrix;
      }

      else if ( cam is MatrixCamera )
      {
        matx = ( cam as MatrixCamera ).ProjectionMatrix;
      }

      else if ( cam is OrthographicCamera )
      {
        OrthographicCamera orthocam = cam as OrthographicCamera;

        double xScale = 2 / orthocam.Width;
        double yScale = xScale * aspectRatio;
        double zNear = orthocam.NearPlaneDistance;
        double zFar = orthocam.FarPlaneDistance;

        // Hey, check this out!
        if ( Double.IsPositiveInfinity( zFar ) )
          zFar = 1E10;

        matx = new Matrix3D( xScale, 0, 0, 0,
                            0, yScale, 0, 0,
                            0, 0, 1 / ( zNear - zFar ), 0,
                            0, 0, zNear / ( zNear - zFar ), 1 );

      }

      else if ( cam is PerspectiveCamera )
      {
        PerspectiveCamera perscam = cam as PerspectiveCamera;

        // The angle-to-radian formula is a little off because only
        //  half the angle enters the calculation.
        double xScale = 1 / Math.Tan( Math.PI * perscam.FieldOfView / 360 );
        double yScale = xScale * aspectRatio;
        double zNear = perscam.NearPlaneDistance;
        double zFar = perscam.FarPlaneDistance;
        double zScale = ( zFar == double.PositiveInfinity ? -1 : ( zFar / ( zNear - zFar ) ) );
        double zOffset = zNear * zScale;

        matx = new Matrix3D( xScale, 0, 0, 0,
                            0, yScale, 0, 0,
                            0, 0, zScale, -1,
                            0, 0, zOffset, 0 );
      }

      else if ( cam != null )
      {
        throw new ApplicationException( "ProjectionMatrix" );
      }

      return matx;
    }


    public static Viewport3DVisual GetViewport3DVisual( DependencyObject visual )
    {
      Viewport3DVisual viewport;
      if ( !( visual is Visual3D ) )
      {
        throw new ArgumentException( "Must be of type Visual3D.", "visual" );
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
        throw new ApplicationException(
            String.Format( "Unsupported type: '{0}'.  Expected tree of ModelVisual3Ds leading up to a Viewport3DVisual.",
            visual.GetType().FullName ) );
      }
      return viewport;
    }

  }
}