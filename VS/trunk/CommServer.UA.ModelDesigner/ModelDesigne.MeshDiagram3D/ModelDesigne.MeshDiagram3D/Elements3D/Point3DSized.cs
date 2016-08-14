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
using System.Windows.Media.Media3D;
using MeshDiagram3D.Presentation;
using MeshDiagram3D.Utils;

namespace MeshDiagram3D.Elements3D
{
  public class Point3DSized: MeshDiagram3DPoint3D, IModelVisual3D
  {
    #region private
    protected MeshDiagramViewport3D meshDiagramViewport3D;
    protected ModelVisual3D lastModelVisual3D = null;
    protected ModelVisual3DFilter lastModelVisual3DFilter = ModelVisual3DFilter.AllOff;
    private bool isSelected;
    private double size;
    private Material materialNormal;
    private Material materialSelected;
    private ModelType mModelType;
    private void UpdateLastModelVisual3D()
    {
      if ( lastModelVisual3D == null )
        lastModelVisual3D = new ModelVisual3D();
      else
        lastModelVisual3D.Children.Clear();
      lastModelVisual3D.Children.Add( MyModelVisual3D.GetModelVisual3D( lastModelVisual3DFilter, isSelected ) );
    }
    protected override void UpdateMyModelVisual3D()
    {
      MyModelVisual3D = new BasicModel3DModel(
        MaterialNormal, MaterialSelected, X, Y, Z, Size, Size, Size, true, this.ModelType );
    }
    #endregion private
    #region pubic
    public Material MaterialNormal { get { return materialNormal; } set { materialNormal = value; UpdateLastModelVisual3D(); } }
    public Material MaterialSelected { get { return materialSelected; } set { materialSelected = value; UpdateLastModelVisual3D(); } }
    public ModelType ModelType { get { return mModelType; } set { mModelType = value; UpdateLastModelVisual3D(); } }
    public virtual string Text
    {
      get
      {
        return MyModelVisual3D.Text;
      }
      set
      {
        ( (BasicModel3DModel)MyModelVisual3D ).Text = value;
      }
    }
    public virtual bool CanBeSelected
    {
      get
      {
        return true;
      }
    }
    public double Size
    {
      get
      {
        return size;
      }
      set
      {
        size = value;
        UpdateMyModelVisual3D();
      }
    }
    #endregion public
    #region constructor
    public Point3DSized( double x, double y, double z, double size,
      Material MaterialInNormalState, Material MaterialInSelectedState, ModelType modelType )
      : base( x, y, z )
    {
      this.Size = size;
      this.materialNormal = MaterialInNormalState;
      this.materialSelected = MaterialInSelectedState;
      this.mModelType = modelType;
      this.UpdateMyModelVisual3D();
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
          //lastModelVisual3D.Children.Clear();
          //lastModelVisual3D.Children.Add( MyModelVisual3D.GetModelVisual3D( lastModelVisual3DFilter, isSelected ) );
          this.GetModelVisual3D( lastModelVisual3DFilter, isSelected );
        }
      }
    }
    void IModelVisual3D.Register( MeshDiagramViewport3D mdv3d )
    {
      meshDiagramViewport3D = mdv3d;
      if ( MyModelVisual3D != null )
      {
        MyModelVisual3D.Register( mdv3d );
      }
    }
    void IModelVisual3D.Unregister()
    {
      meshDiagramViewport3D = null;
      if ( MyModelVisual3D != null )
      {
        MyModelVisual3D.Unregister();
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
    public virtual ModelVisual3D GetModelVisual3D( ModelVisual3DFilter FilterSettings, bool Selected )
    {
      lastModelVisual3DFilter = FilterSettings;
      isSelected = Selected;
      UpdateLastModelVisual3D();
      return lastModelVisual3D;
    }
    public virtual UIElement GetUIElement( ModelVisual3DFilter FilterSettings, Viewport3DVisual DestinationViewport3DVisual )
    {
      return this.MyModelVisual3D.GetUIElement( FilterSettings, DestinationViewport3DVisual );
    }
    #endregion
  }
}
