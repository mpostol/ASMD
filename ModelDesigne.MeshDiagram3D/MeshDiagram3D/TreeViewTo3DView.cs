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
using System.Collections.Generic;
using System.Windows.Forms;
using MeshDiagram3D.Elements3D;
using MeshDiagram3D.Presentation;

namespace MeshDiagram3D
{
  public class TreeViewTo3DView: TreeViewTo3DView<Point3DSizedLabeledWithTreeNode<TreeNode>, TreeNode>
  {
    public TreeViewTo3DView( TreeNode StartTreeNode )
      : base( StartTreeNode )
    {
    }
  }
  public class Point3DSizedLabeledWithTreeNode<T_PointTreeNode>: Point3DSizedLabeled
    where T_PointTreeNode: TreeNode
  {
    public T_PointTreeNode TreeNode { get; set; }
  }
  public class TreeViewTo3DView<T_Point3DSizedLabeled, T_TreeNode>
    where T_Point3DSizedLabeled: Point3DSizedLabeledWithTreeNode<T_TreeNode>, new()
    where T_TreeNode: TreeNode
  {
    #region private
    private const double defaultsize = 0.25;
    private const double defaultdistance = 1;
    private class TreeNodePoint3DSizedLabeledPair
    {
      public T_TreeNode TreeNode { get; private set; }
      public T_Point3DSizedLabeled Point3DSizedLabeled { get; private set; }
      internal TreeNodePoint3DSizedLabeledPair( T_TreeNode TreeNode, T_Point3DSizedLabeled Point3DSizedLabeled )
      {
        this.TreeNode = TreeNode;
        this.Point3DSizedLabeled = Point3DSizedLabeled;
      }
    }
    private ListOfIModelVisual3D elements;
    private void AddChildElements( TreeNodePoint3DSizedLabeledPair pair )
    {
      int count = pair.TreeNode.Nodes.Count;
      List<TreeNodePoint3DSizedLabeledPair> MyPairs = new List<TreeNodePoint3DSizedLabeledPair>( count );
      double current_z_level = pair.Point3DSizedLabeled.Z + defaultdistance;
      foreach ( TreeNode tn in pair.TreeNode.Nodes )
      {

        T_Point3DSizedLabeled point = new T_Point3DSizedLabeled();
        point.X = 0;
        point.Y = 0;
        point.Z = current_z_level;
        point.Size = defaultsize;
        point.Label = tn.Text;
        point.TreeNode = (T_TreeNode)tn;
        MyPairs.Add( new TreeNodePoint3DSizedLabeledPair(
          (T_TreeNode)tn, point ) );
      }
      int setcount = (int)Math.Round( Math.Sqrt( count ) );
      double x = pair.Point3DSizedLabeled.X;
      double y = pair.Point3DSizedLabeled.Y;
      int idx = 0;
      foreach ( TreeNodePoint3DSizedLabeledPair tnp3dpair in MyPairs )
      {
        tnp3dpair.Point3DSizedLabeled.X = pair.Point3DSizedLabeled.X
          + ( idx % setcount ) * defaultdistance;
        tnp3dpair.Point3DSizedLabeled.Y = y;
        elements.Add( tnp3dpair.Point3DSizedLabeled );
        elements.Add( new Connection3D( pair.Point3DSizedLabeled, tnp3dpair.Point3DSizedLabeled ) );
        idx++;
        if ( ( idx % setcount ) == 0 )
          y += defaultdistance;
        AddChildElements( tnp3dpair );
      }
    }
    #endregion private
    public void AddContentToScene( MeshDiagram3D.Panel3DUserControl PanelWithScene )
    {
      foreach ( var element in elements )
      {
        PanelWithScene.AddModelVisual3D( element );
      }
    }
    public TreeViewTo3DView( T_TreeNode StartTreeNode )
    {
      elements = new ListOfIModelVisual3D();

      T_Point3DSizedLabeled RootTreeNodePoint3DSizedLabeled =
        new T_Point3DSizedLabeled();
      RootTreeNodePoint3DSizedLabeled.X = 0;
      RootTreeNodePoint3DSizedLabeled.Y = 0;
      RootTreeNodePoint3DSizedLabeled.Z = 0;
      RootTreeNodePoint3DSizedLabeled.Size = defaultsize;
      RootTreeNodePoint3DSizedLabeled.Label = StartTreeNode.Text;
      RootTreeNodePoint3DSizedLabeled.TreeNode = StartTreeNode;
      elements.Add( RootTreeNodePoint3DSizedLabeled );
      AddChildElements( new TreeNodePoint3DSizedLabeledPair(
        StartTreeNode, RootTreeNodePoint3DSizedLabeled ) );
    }
  }
}
