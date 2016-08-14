using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MeshDiagram3D.Elements3D;
using MeshDiagram3D.Presentation;
using MeshDiagram3D.SimpleForm.Properties;
using System.Windows.Media.Media3D;
using System.Windows.Media;

namespace MeshDiagram3D.SimpleForm
{
  public partial class MainForm : Form
  {
    const double defaultsize = 0.25;
    const double defaultdistance = 1;
    public MainForm()
    {
      InitializeComponent();
      CreateCoordinateSystem();


      panel3DUserControl1.RefreshScene();
    }

    private void CreateCoordinateSystem()
    {
      panel3DUserControl1.Clear();
      Point3DSizedLabeled center = new Point3DSizedLabeled( 0, 0, 0, defaultsize, "0,0,0",
        new DiffuseMaterial( new SolidColorBrush( Colors.DarkKhaki ) ),
      new DiffuseMaterial( new SolidColorBrush( Colors.LightGreen ) ) );
      Point3DSizedLabeled x = new Point3DSizedLabeled( 5, 0, 0, defaultsize, "5,0,0",
        new DiffuseMaterial( new SolidColorBrush( Colors.DarkKhaki ) ),
      new DiffuseMaterial( new SolidColorBrush( Colors.LightGreen ) ) );
      Point3DSizedLabeled y = new Point3DSizedLabeled( 0, 5, 0, defaultsize, "0,5,0",
        new DiffuseMaterial( new SolidColorBrush( Colors.DarkKhaki ) ),
      new DiffuseMaterial( new SolidColorBrush( Colors.LightGreen ) ) );
      Point3DSizedLabeled z = new Point3DSizedLabeled( 0, 0, 5, defaultsize, "0,0,5",
        new DiffuseMaterial( new SolidColorBrush( Colors.DarkKhaki ) ),
      new DiffuseMaterial( new SolidColorBrush( Colors.LightGreen ) ) );
      panel3DUserControl1.AddModelVisual3D( center );
      panel3DUserControl1.AddModelVisual3D( x );
      panel3DUserControl1.AddModelVisual3D( y );
      panel3DUserControl1.AddModelVisual3D( z );
      panel3DUserControl1.AddModelVisual3D( ( new Connection3D( center, x ) ) );
      panel3DUserControl1.AddModelVisual3D( new Connection3D( center, y ) );
      panel3DUserControl1.AddModelVisual3D( new Connection3D( center, z ) );
    }

    private void coordinateSystemToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CreateCoordinateSystem();
      panel3DUserControl1.RefreshScene();
    }

    class DirectoryPoint3DSizedLabeledWithTreeNode : Point3DSizedLabeledWithTreeNode<DirectoryTree.PathTreeNode>
    {
      public override string Text
      {
        get
        {
          string tobereturned = Path.GetDirectoryName(this.TreeNode.Path);
          //if ( tobereturned == this.TreeNode.Path)
          //{
          //  //it is directory
            StringBuilder sb=new StringBuilder();
            DirectoryInfo dirinfo = new DirectoryInfo(this.TreeNode.Path);
            sb.AppendLine(  dirinfo.ToString());
            if (dirinfo.Exists)
            {
              foreach (var dir in dirinfo.GetDirectories())
                sb.AppendLine(String.Format("<dir>{0}", dir.ToString()));
              foreach (var file in dirinfo.GetFiles())
                sb.AppendLine(file.ToString());
            }
            tobereturned= sb.ToString();
          //}
          //else
          //{
          //  //it is file
          //  FileInfo fileinfo = new FileInfo(this.TreeNode.Path);
          //  tobereturned= fileinfo.ToString();
          //}
          return tobereturned;
        }
      }
    }
    private void directoryTreeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
      if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        DirectoryTree dt=new DirectoryTree(folderBrowserDialog1.SelectedPath);
        TreeViewTo3DView<DirectoryPoint3DSizedLabeledWithTreeNode, DirectoryTree.PathTreeNode> myTreeViewTo3DView
          = new TreeViewTo3DView<DirectoryPoint3DSizedLabeledWithTreeNode, DirectoryTree.PathTreeNode>(dt.GetRootTreeNode(false, Settings.Default.DirectoryDepth));
        panel3DUserControl1.Clear();
        myTreeViewTo3DView.AddContentToScene(panel3DUserControl1);
        panel3DUserControl1.RefreshScene();
      }
    }
  }
}
