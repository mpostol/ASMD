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

namespace MeshDiagram3D.Presentation
{
  public interface IModelVisual3D
  {
    ModelVisual3D GetModelVisual3D( ModelVisual3DFilter FilterSettings, bool Selected );
    UIElement GetUIElement( ModelVisual3DFilter FilterSettings, Viewport3DVisual DestinationViewport3DVisual );
    bool Match( Point point2D );
    string Text { get; }
    object Tag { get; set; }
    bool CanBeSelected { get; }
    bool IsSelected { get; set; }
    void Register( MeshDiagramViewport3D mdv3d );
    void Unregister();
  }
}
