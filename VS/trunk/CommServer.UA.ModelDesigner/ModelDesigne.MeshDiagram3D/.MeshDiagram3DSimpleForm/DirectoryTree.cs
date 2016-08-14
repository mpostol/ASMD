using System.IO;
using System.Windows.Forms;

namespace MeshDiagram3D
{
  public class DirectoryTree
  {
    public class PathTreeNode : TreeNode
    {
      public string Path { get; set; }
      public PathTreeNode(string path, string Text)
        : base(Text)
      {
        Path = path;
      }
    }
    /// <summary>
    /// A method to populate a TreeView with directories, subdirectories, files etc
    /// This method works recursively
    /// </summary>
    /// <param name="directoryPath">The path of the directory t6hat we want to add to the tree</param>
    /// <param name="startingTreeNode">The starting node, to populate the tree</param>
    /// <param name="includeFiles">if set to <c>true</c> files are included on the tree.</param>
    public static void CreateTreeFromDirectory(string directoryPath, PathTreeNode startingTreeNode, bool includeFiles, int depth)
    {
      if (depth <= 0) return;
      try
      {
        // 1. get the information of the directory
        DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
        // 2. get content of the directory and go through each subdirectory
        foreach (DirectoryInfo d in directoryInfo.GetDirectories())
        {
          //3. create a new tree node with text set to subdirectory name
          PathTreeNode t = new PathTreeNode(d.FullName, d.Name);
          //4. populate the new node recursively
          CreateTreeFromDirectory(d.FullName, t, includeFiles, depth - 1);
          //5. add the node to the starting (root) node
          startingTreeNode.Nodes.Add(t);
          //6. get next subdirectory and go to point 3
        }
        //7. test if file should be included on the tree
        if (includeFiles)
        {
          //8. loop through each file in the directory, and add these as nodes
          foreach (FileInfo f in directoryInfo.GetFiles())
          {
            //9. create a new node with name = file name
            PathTreeNode t = new PathTreeNode(f.FullName, f.Name);
            //10. add it to the starting node
            startingTreeNode.Nodes.Add(t);
            //11. get next file and go to point 9
          }
        }
      }
      catch
      {
        //it is possible that we receive an exception (e.g. directory cannot be accessed due to access privilidges
        // we do nothing, we just skip this node.
      }
    }
    public PathTreeNode GetRootTreeNode(bool includeFiles, int depth)
    {
      PathTreeNode rootTreeNode = new PathTreeNode(StartingPath, StartingPath);
      CreateTreeFromDirectory(StartingPath, rootTreeNode, includeFiles, depth);
      return rootTreeNode;
    }
    public string StartingPath { get; set; }
    public DirectoryTree(string startingPath)
    {
      StartingPath = startingPath;
    }
  }
}
