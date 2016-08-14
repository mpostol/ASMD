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
  public class MeshdiagramViewport3DPropertyChangeEventArgs<T>: EventArgs
  {
    public T Value { get; private set; }
    public MeshdiagramViewport3DPropertyChangeEventArgs( T init )
    {
      Value = init;
    }
  }
}
