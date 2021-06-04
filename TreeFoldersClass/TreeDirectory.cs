using System;
using System.IO;
using System.Windows.Forms;

namespace TreeFoldersClass
{
    public class TreeDirectory
    {
        public static void FillDirNodes(TreeView tree, string rootPath)
        {
            tree.Nodes.Clear();
            try
            {
                // Создаем корневой узел
                TreeNode nodeRoot = new TreeNode(rootPath);

                //nodeRoot.Text = rootPath.Remove(0, rootPath.LastIndexOf("\\") + 1);

                tree.Nodes.Add(nodeRoot);

                FillTreeNode(nodeRoot, rootPath);

                tree.Nodes[0].Expand();

            }
            catch (Exception ex) { }
        }

        // получаем дочерние узлы для определенного узла
        private static void FillTreeNode(TreeNode Node, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    Node.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }
        }

        // событие перед раскрытием узла
        public static void BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }


        // событие перед выделением узла
        public static void BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

    }
}
