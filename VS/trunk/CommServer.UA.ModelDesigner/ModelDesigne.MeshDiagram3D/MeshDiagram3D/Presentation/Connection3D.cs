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
using _3DTools;
using MeshDiagram3D.Utils;

namespace MeshDiagram3D.Presentation
{
  public class Connection3D: IModelVisual3D
  {
    #region private
    private bool isSelected = false;
    private MeshDiagramViewport3D meshDiagramViewport3D;
    private ModelVisual3D lastModelVisual3D = null;
    private ModelVisual3DFilter lastModelVisual3DFilter = ModelVisual3DFilter.AllOff;
    private ModelVisual3D PrepareModelVisual3D( ModelVisual3DFilter FilterSettings, bool Selected )
    {
      if ( Selected )
        throw new NotImplementedException( "Selection of lines is not yet implemented" );
      if ( FilterSettings.Lines )
      {
        ScreenSpaceLines3D line = new ScreenSpaceLines3D();
        line.Thickness = 1;
        line.Color = Colors.Black;
        line.Points.Add( Start.Point3D );
        line.Points.Add( End.Point3D );
        return line;
      }
      else
        return new ModelVisual3D();
    }
    #endregion
    #region public
    public MeshDiagram3DPoint3D Start { get; set; }
    public MeshDiagram3DPoint3D End { get; set; }
    public string Text { get; set; }
    public virtual bool CanBeSelected
    {
      get
      {
        return false;
      }
    }
    #endregion public
    #region creator
    public Connection3D( MeshDiagram3DPoint3D start, MeshDiagram3DPoint3D end )
    {
      Start = start;
      End = end;
    }
    #endregion creator
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
          lastModelVisual3D.Children.Add( PrepareModelVisual3D( lastModelVisual3DFilter, isSelected ) );
        }
      }
    }

    void IModelVisual3D.Register( MeshDiagramViewport3D mdv3d )
    {
      meshDiagramViewport3D = mdv3d;
    }
    void IModelVisual3D.Unregister()
    {
      meshDiagramViewport3D = null;
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
      lastModelVisual3DFilter = FilterSettings;
      return lastModelVisual3D = PrepareModelVisual3D( FilterSettings, Selected );
    }
    UIElement IModelVisual3D.GetUIElement( ModelVisual3DFilter FilterSettings, Viewport3DVisual DestinationViewport3D )
    {
      return new UIElement();
    }
    #endregion
  }
}
