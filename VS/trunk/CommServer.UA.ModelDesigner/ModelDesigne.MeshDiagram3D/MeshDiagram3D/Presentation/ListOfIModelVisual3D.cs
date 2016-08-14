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

using System.Collections.Generic;
using System.Windows;

namespace MeshDiagram3D.Presentation
{
  public class ListOfIModelVisual3D: IEnumerable<IModelVisual3D>
  {
    #region private
    private List<IModelVisual3D> elements;
    #endregion private
    #region creator
    public ListOfIModelVisual3D()
    {
      elements = new List<IModelVisual3D>();
    }
    #endregion creator
    #region public
    public void Add( IModelVisual3D model )
    {
      elements.Add( model );
    }
    public void Clear()
    {
      foreach ( IModelVisual3D element in elements )
        element.Unregister();
      elements.Clear();
    }
    public IModelVisual3D GetMatchedElement( Point point2D, ModelVisual3DFilter FilterSettings )
    {
      IModelVisual3D returnedIModelVisual3D = null;
      foreach ( IModelVisual3D modelVisual3D in this )
      {
        if ( modelVisual3D.CanBeSelected && modelVisual3D.Match( point2D ) )
          returnedIModelVisual3D = modelVisual3D;
      }
      return returnedIModelVisual3D;
    }
    #endregion public
    #region IEnumerable<IModelVisual3D> Members
    IEnumerator<IModelVisual3D> IEnumerable<IModelVisual3D>.GetEnumerator()
    {
      return elements.GetEnumerator();
    }
    #endregion
    #region IEnumerable Members
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return elements.GetEnumerator();
    }
    #endregion
  }
}
