using System;
using System.IO;
using System.Windows.Forms;

namespace TreeFoldersClass
{
    public class TreeFolders
    {
        public String startPath
        {
            get; set;
        }


        public static void GetTreeDir(TreeView tree, string root)
        {
            tree.Nodes.Clear();
            TreeFolders tf = new TreeFolders();
            tf.startPath = root;
            tf.CreateTree(tree);
            tree.Nodes[0].Expand();
        }

        private void CreateTree(TreeView tree)
        {
            // Создаем корневой узел
            TreeNode nodeDrive = new TreeNode(startPath);
            // Добавляем корневой узел к дереву просмотра
            tree.Nodes.Add(nodeDrive);
            // Развертываем корневой узел
            nodeDrive.Expand();

            // Считываем дерево каталогов
            CreateDirectoryTree(nodeDrive);
            //  treeView1.ExpandAll();
        }

        private void CreateFilesTree(TreeView tree, TreeNode node)
        {
            string pdir = tree.SelectedNode.FullPath.ToString();

            if (Directory.Exists(pdir))
            {
                try
                {
                    string[] fls = Directory.GetFiles(pdir, "*.*");

                    foreach (string fl in fls)
                    {
                        FileInfo info = new FileInfo(fl);
                        tree.Nodes.Add(info.Name);
                        //fileGridView.Rows.Add(info.Name, info.LastWriteTime.ToString("dd.MM.yyyy"));

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error of add file");
                }
            }
        }

        private void CreateDirectoryTree(TreeNode node)
        {
            // Для текущего узла node получаем полный путь к корню дерева
            string strPath = node.FullPath;
            // Создаем объект текущего каталога
            DirectoryInfo dirInfo = new DirectoryInfo(strPath);
            // Объявляем ссылку на массив подкаталогов текущего каталога
            DirectoryInfo[] arrayDirInfo;
            try
            {
                // Пытаемся получить список подкаталогов
                arrayDirInfo = dirInfo.GetDirectories();
            }
            catch
            {
                // Подкаталогов нет, выходим из рекурсии
                return;
            }

            // Добавляем прочитанные подкаталоги как узлы в дерево просмотра
            foreach (DirectoryInfo dir in arrayDirInfo)
            {

                // Создаем новый узел с именем подкаталога
                TreeNode nodeDir = new TreeNode(dir.Name);
                // Добавляем его как дочерний к текущему узлу
                node.Nodes.Add(nodeDir);

                // Развертываем узел
                nodeDir.Expand();
                // Делаем дочерний узел текущим и спускаемся рекурсивно ниже
                CreateDirectoryTree(nodeDir);
            }
        }
        //////////

        public static void SelectNodeByName(TreeView tree, int IndexNode)
        {
            foreach (TreeNode item in tree.Nodes)
            {
                if (item.Index == IndexNode)
                {
                    tree.SelectedNode = item;
                }
            }

        }

        public static void SelectNodeByName(TreeView tree, string nameNode)
        {
            foreach (TreeNode item in tree.Nodes)
            {
                if (item.Name == nameNode)
                {
                    tree.SelectedNode = item;
                }
            }

        }
    }
}

