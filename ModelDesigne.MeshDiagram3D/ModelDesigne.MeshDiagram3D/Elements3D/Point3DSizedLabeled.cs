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

using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace MeshDiagram3D.Elements3D
{
  public class Point3DSizedLabeled: Point3DSized
  {
    #region private
    private string label;
    protected override void UpdateMyModelVisual3D()
    {
      MyModelVisual3D = new ElementWithDescription( X, Y, Z, Size, Label, MaterialNormal, MaterialSelected, true, this.ModelType );
    }
    #endregion private
    #region public
    public string Label
    {
      get
      {
        return label;
      }
      set
      {
        label = value;
        UpdateMyModelVisual3D();
      }
    }
    #endregion private
    #region creator
    public Point3DSizedLabeled()
      : base( 0, 0, 0, 0, new DiffuseMaterial( new SolidColorBrush( Colors.DarkKhaki ) ),
      new DiffuseMaterial( new SolidColorBrush( Colors.Red ) ),ModelType.Tetraeder )
    {
      this.UpdateMyModelVisual3D();
    }
    public Point3DSizedLabeled( double x, double y, double z, double size, string label,
      Material MaterialInNormalState, Material MaterialInSelectedState, ModelType modelType )
      : base( x, y, z, size, MaterialInNormalState, MaterialInSelectedState, modelType )
    {
      Label = label;
      this.UpdateMyModelVisual3D();
    }
    #endregion creator
  }
}
