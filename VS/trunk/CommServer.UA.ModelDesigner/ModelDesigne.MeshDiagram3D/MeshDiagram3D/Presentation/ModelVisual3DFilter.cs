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

namespace MeshDiagram3D.Presentation
{
  public class ModelVisual3DFilter
  {
    #region private
    private bool mTriangles;
    private bool mTexts3D;
    private bool mTexts2D;
    private bool mLines;
    private void RaiseFilterIsChanged()
    {
      if ( FilterIsChanged != null )
        FilterIsChanged( this, EventArgs.Empty );
    }
    private ModelVisual3DFilter( bool EnableTriangles,
      bool EnableTexts3D,
      bool EnableTexts2D,
      bool EnableLines )
    {
      Triangles = EnableTriangles;
      Texts3D = EnableTexts3D;
      Texts2D = EnableTexts3D;
      Lines = EnableLines;
    }
    #endregion
    public event EventHandler FilterIsChanged;
    public bool Triangles
    {
      get { return mTriangles; }
      set { mTriangles = value; RaiseFilterIsChanged(); }
    }
    public bool Texts3D
    {
      get { return mTexts3D; }
      set { mTexts3D = value; RaiseFilterIsChanged(); }
    }
    public bool Texts2D
    {
      get { return mTexts2D; }
      set { mTexts2D = value; RaiseFilterIsChanged(); }
    }
    public bool Lines
    {
      get { return mLines; }
      set { mLines = value; RaiseFilterIsChanged(); }
    }
    public static ModelVisual3DFilter AllOn
    {
      get
      {
        return new ModelVisual3DFilter( true, true, true, true );
      }
    }
    public static ModelVisual3DFilter AllOnExceptTexts
    {
      get
      {
        return new ModelVisual3DFilter( true, false, false, true );
      }
    }
    public static ModelVisual3DFilter AllOff
    {
      get
      {
        return new ModelVisual3DFilter( false, false, false, false );
      }
    }
  }
}
