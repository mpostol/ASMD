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
using System.Windows.Media.Media3D;

namespace MeshDiagram3D.Presentation
{
  public class MeshDiagram3DPoint3D: ICloneable
  {
    #region private
    private double x, y, z;
    private IModelVisual3D myModelVisual3D;
    protected IModelVisual3D MyModelVisual3D
    {
      get
      {
        return myModelVisual3D;
      }
      set
      {
        if ( myModelVisual3D != null )
          myModelVisual3D.Unregister();
        myModelVisual3D = value;
      }
    }
    protected virtual void UpdateMyModelVisual3D() {/*do nothing*/}
    #endregion private
    #region public
    public double X
    {
      get
      {
        return x;
      }
      set
      {
        x = value;
        UpdateMyModelVisual3D();
      }
    }
    public double Y
    {
      get
      {
        return y;
      }
      set
      {
        y = value;
        UpdateMyModelVisual3D();
      }
    }
    public double Z
    {
      get
      {
        return z;
      }
      set
      {
        z = value;
        UpdateMyModelVisual3D();
      }
    }
    public Point3D Point3D
    {
      get
      {
        return new Point3D( X, Y, Z );
      }
    }
    #endregion public
    #region creator
    public MeshDiagram3DPoint3D( double x, double y, double z )
    {
      X = x;
      Y = y;
      Z = z;
    }
    #endregion creator
    #region ICloneable Members
    object ICloneable.Clone()
    {
      return this.MemberwiseClone();
    }
    #endregion
  }
}
