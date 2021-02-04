//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.IO;
using CAS.UA.Model.Designer.Wrappers;
using MeshDiagram3D;
using MeshDiagram3D.Elements3D;
using MeshDiagram3D.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace CAS.UA.Model.Designer.Controls.NodeObserver
{
  internal partial class View3DModelObserver : SelectedItemObserver
  {
    #region classes

    private class NodePoint3DSizedLabeledIModelNodeAdvance : Point3DSizedLabeledWithIModelNodeAdvance<IModelNodeAdvance>
    {
      //public NodePoint3DSizedLabeledIModelNodeAdvance( IModelNodeAdvance imna ):base()
      //{
      //  ( (IModelVisual3D)this ).Tag = imna;
      //}
    }

    private class IModelNodeAdvanceMeshTo3DView : IModelNodeAdvanceMeshTo3DView<Point3DSizedLabeledWithIModelNodeAdvance<IModelNodeAdvance>, IModelNodeAdvance>
    {
      public IModelNodeAdvanceMeshTo3DView(IModelNodeAdvance StartNode)
        : base(StartNode)
      { }
    }

    private class Point3DSizedLabeledWithIModelNodeAdvance<T_PointNode> : Point3DSizedLabeled
      where T_PointNode : IModelNodeAdvance
    {
      private T_PointNode mNode;

      public T_PointNode Node
      {
        get => mNode;
        set
        {
          mNode = value;
          ((IModelVisual3D)this).Tag = value;
        }
      }
    }

    private class IModelNodeAdvanceMeshTo3DView<T_Point3DSizedLabeled, T_Node>
      where T_Point3DSizedLabeled : Point3DSizedLabeledWithIModelNodeAdvance<T_Node>, new()
      where T_Node : IModelNodeAdvance
    {
      private const double defaultsize = 0.25;
      private const double defaultdistance = 1;

      private class IModelNodeAdvancePoint3DSizedLabeledPair
      {
        public T_Node Node { get; private set; }
        public T_Point3DSizedLabeled Point3DSizedLabeled { get; private set; }

        internal IModelNodeAdvancePoint3DSizedLabeledPair(T_Node Node, T_Point3DSizedLabeled Point3DSizedLabeled)
        {
          this.Node = Node;
          this.Point3DSizedLabeled = Point3DSizedLabeled;
        }
      }

      private ListOfIModelVisual3D elements;

      private int GetSubElementCount(IModelNodeAdvance imna)
      {
        int count = 0;
        foreach (KeyValuePair<FolderType, IEnumerable<IModelNodeAdvance>> folder in imna.GetFolders())
        {
          foreach (IModelNodeAdvance el in folder.Value)
            count++;
        }
        return count;
      }

      private static T_Point3DSizedLabeled CreateT_Point3DSizedLabeledBasedOnIModelNodeAdvance(IModelNodeAdvance imna)
      {
        T_Point3DSizedLabeled point = new T_Point3DSizedLabeled
        {
          Label = imna.Name,
          Node = (T_Node)imna
        };
        //size and model type:
        switch (imna.NodeClass)
        {
          case NodeClassesEnum.ReferenceType:
            point.Size = defaultsize / 2;
            break;

          case NodeClassesEnum.DataType:
          case NodeClassesEnum.ObjectType:
          case NodeClassesEnum.VariableType:
            point.Size = defaultsize * 2;
            point.ModelType = ModelType.Cube;
            break;

          default:
            point.Size = defaultsize;
            point.ModelType = ModelType.Cube;
            break;
        }
        //colors:
        switch (imna.NodeClass)
        {
          case NodeClassesEnum.ObjectType:
            point.MaterialNormal = new DiffuseMaterial(new SolidColorBrush(Colors.Purple));
            break;

          case NodeClassesEnum.Variable:
            point.MaterialNormal = new DiffuseMaterial(new SolidColorBrush(Colors.Orange));
            break;

          case NodeClassesEnum.VariableType:
            point.MaterialNormal = new DiffuseMaterial(new SolidColorBrush(Colors.Green));
            break;

          case NodeClassesEnum.DataType:
            point.MaterialNormal = new DiffuseMaterial(new SolidColorBrush(Colors.Blue));
            break;

          case NodeClassesEnum.ReferenceType:
            point.MaterialNormal = new DiffuseMaterial(new SolidColorBrush(Colors.Yellow));
            break;

          case NodeClassesEnum.Method:
            point.MaterialNormal = new DiffuseMaterial(new SolidColorBrush(Colors.Gray));
            break;

          case NodeClassesEnum.Property:
            point.MaterialNormal = new DiffuseMaterial(new SolidColorBrush(Colors.LightGreen));
            break;

          default:
            break;
        }

        return point;
      }

      private void AddChildElements(IModelNodeAdvancePoint3DSizedLabeledPair pair)
      {
        int count = GetSubElementCount(pair.Node);
        List<IModelNodeAdvancePoint3DSizedLabeledPair> MyPairs = new List<IModelNodeAdvancePoint3DSizedLabeledPair>(count);
        double current_z_level = pair.Point3DSizedLabeled.Z + defaultdistance;
        foreach (KeyValuePair<FolderType, IEnumerable<IModelNodeAdvance>> folder in pair.Node.GetFolders())
        {
          foreach (IModelNodeAdvance el in folder.Value)
          {
            IModelNodeAdvance node = el as IModelNodeAdvance;
            T_Point3DSizedLabeled point = CreateT_Point3DSizedLabeledBasedOnIModelNodeAdvance(node);
            point.X = 0;
            point.Y = 0;
            point.Z = current_z_level;
            MyPairs.Add(new IModelNodeAdvancePoint3DSizedLabeledPair(
              (T_Node)node, point));
          }
        }
        int setcount = (int)Math.Round(Math.Sqrt(count));
        double x = pair.Point3DSizedLabeled.X;
        double y = pair.Point3DSizedLabeled.Y;
        int idx = 0;
        foreach (IModelNodeAdvancePoint3DSizedLabeledPair tnp3dpair in MyPairs)
        {
          tnp3dpair.Point3DSizedLabeled.X = pair.Point3DSizedLabeled.X
            + (idx % setcount) * defaultdistance;
          tnp3dpair.Point3DSizedLabeled.Y = y;
          elements.Add(tnp3dpair.Point3DSizedLabeled);
          elements.Add(new Connection3D(pair.Point3DSizedLabeled, tnp3dpair.Point3DSizedLabeled));
          idx++;
          if ((idx % setcount) == 0)
            y += defaultdistance;
          AddChildElements(tnp3dpair);
        }
      }

      public void AddContentToScene(Panel3DUserControl PanelWithScene)
      {
        foreach (IModelVisual3D element in elements)
        {
          PanelWithScene.AddModelVisual3D(element);
        }
      }

      public IModelNodeAdvanceMeshTo3DView(T_Node StartTreeNode)
      {
        elements = new ListOfIModelVisual3D();

        T_Point3DSizedLabeled RootTreeNodePoint3DSizedLabeled =
          new T_Point3DSizedLabeled
          {
            X = 0,
            Y = 0,
            Z = 0,
            Size = defaultsize,
            Label = StartTreeNode.Name,
            Node = StartTreeNode
          };
        elements.Add(RootTreeNodePoint3DSizedLabeled);
        AddChildElements(new IModelNodeAdvancePoint3DSizedLabeledPair(
          StartTreeNode, RootTreeNodePoint3DSizedLabeled));
      }
    }

    #endregion classes

    #region public

    public View3DModelObserver()
    {
      InitializeComponent();
      if (LicenseManager.CurrentContext.UsageMode == LicenseUsageMode.Designtime)
        return;
      this.VisibleChanged += new EventHandler(View3DModelObserver_VisibleChanged);
      this.panel3DUserControl1.CommandPanelBackgroundBrush = new LinearGradientBrush(new GradientStopCollection(new GradientStop[] { new GradientStop(Colors.Green, 0), new GradientStop(Colors.White, 0.5), new GradientStop(Colors.Green, 1) }));
      this.panel3DUserControl1.MeshDiagramViewport3D.IModelVisualIsSelected += new EventHandler(MeshDiagramViewport3D_IModelVisualIsSelected);
    }

    #endregion public

    #region private

    private void MeshDiagramViewport3D_IModelVisualIsSelected(object sender, EventArgs e)
    {
      IModelNodeAdvance imna = panel3DUserControl1.MeshDiagramViewport3D.SelectedIModelVisual.Tag as IModelNodeAdvance;
      RaiseSelectedItemIsChanged(new SelectedItemEventArgs(imna, false));
    }

    private IModelNodeAdvance previousMessage = null;

    private void View3DModelObserver_VisibleChanged(object sender, EventArgs e)
    {
      if (this.Visible && previousMessage != null)
      {
        InitializeScene(previousMessage);
        previousMessage = null;
      }
    }

    private void InitializeScene(IModelNodeAdvance imna)
    {
      if (imna != null)
      {
        IModelNodeAdvanceMeshTo3DView<NodePoint3DSizedLabeledIModelNodeAdvance, IModelNodeAdvance> myTreeViewTo3DView
          = new IModelNodeAdvanceMeshTo3DView<NodePoint3DSizedLabeledIModelNodeAdvance, IModelNodeAdvance>(imna);
        panel3DUserControl1.Clear();
        myTreeViewTo3DView.AddContentToScene(panel3DUserControl1);
        panel3DUserControl1.RefreshScene();
        panel3DUserControl1.TryAutoZoom();
      }
    }

    #endregion private

    #region SelectedItemObserver

    protected override void OnSelectedItemIsChanged(object sender, SelectedItemEventArgs e)
    {
      //this is special observer that operates on IModelNodeAdvance (it requires references between nodes)
      //this event returns IModelNode, so we must change it to IModelNodeAdvance
      //
      //here we do not know wheter we receive:
      // - e.SelectedIModelNode as IModelNodeAdvance
      // - e.SelectedIModelNode as IWrapperTreeNode
      //the code belows perform the conversion but this is very unclear situation
      //TODO: this should be changed in the future, see:
      //http://itrserver.hq.cas.com.pl/Bugs/BugDetail.aspx?bid=2253
      //http://itrserver.hq.cas.com.pl/Bugs/BugDetail.aspx?bid=2254
      IModelNodeAdvance imna = null;
      if (e.SelectedIModelNode is IModelNodeAdvance)
        imna = (IModelNodeAdvance)e.SelectedIModelNode;
      if (e.SelectedIModelNode is IWrapperTreeNode)
        imna = ((IWrapperTreeNode)e.SelectedIModelNode).IModelNodeAdvance;
      if (this.Visible)
        InitializeScene(imna);
      else
        previousMessage = imna;
    }

    protected override void AfterSolutionChange(object sender, SolutionConfigurationManagementRoot.AfterSolutionChangeEventArgs e)
    {
    }

    #endregion SelectedItemObserver
  }
}