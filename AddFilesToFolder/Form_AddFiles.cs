using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FileAction;
using System.IO;
using TreeFoldersClass;
using Distinary;


namespace AddFilesToFolder
{
    public partial class Form_AddFiles : Form
    {
        string pathL;
        string pathS;
        int Napr;
        string nameRoot;
        List<TreeNode> listfolder = new List<TreeNode>(); // Короткий путь до уровня root 
        List<ListFile> listp = new List<ListFile>(); // список свойств (имя \ дата, путьЛок, путьСерв)
        List<string> listNPathFolders = new List<string>(); // список папок выбранных как путь сохранения

        public Form_AddFiles()
        {
            InitializeComponent();
        }

        public Form_AddFiles(string pathLocal, string pathServer)
        {
            InitializeComponent();

            pathL = pathLocal;
            pathS = pathServer;
            nameRoot = Path.GetFileName(pathLocal);
            textBox1.Text = pathL;
            textBox2.Text = pathS;
            if (rb_All.Checked) Napr = 2;
            if (rb_Loc.Checked) Napr = 0;
            if (rb_Serv.Checked) Napr = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void MenuItemNewFolder_Click(object sender, EventArgs e)
        {
            string pth = treeViewFolder.SelectedNode.FullPath;
            bool t = false;
            if (nameRoot.Length != pth.Length)
                pth = pth.Remove(0, nameRoot.Length + 1);
            else
                pth = "";
            string pthL = Path.Combine(pathL, pth); // rootPathLocal
            string pthS = Path.Combine(pathS, pth); // rootPathServer

            switch (Napr) // направление
            {
                case 0:
                    FileA.CreateFolder(tb_newNameFolder.Text, pthL);
                    t = true;
                    break;
                case 1:
                    FileA.CreateFolder(tb_newNameFolder.Text, pthS);
                    t = true;
                    break;
                case 2:
                    FileA.CreateFolder(tb_newNameFolder.Text, pthL);
                    FileA.CreateFolder(tb_newNameFolder.Text, pthS);
                    t = true;
                    break;
                default:
                    t = false;
                    break;
            }
            if (t)
            {
                int inode = treeViewFolder.SelectedNode.Index;
                TreeNode node = treeViewFolder.SelectedNode.Nodes.Insert(inode, tb_newNameFolder.Text);
                treeViewFolder.SelectedNode.Expand();
                treeViewFolder.SelectedNode = node;
                treeViewFolder.Select();
            }
        }
        private void MenuItemReName_Click(object sender, EventArgs e)
        {
            string pth = treeViewFolder.SelectedNode.FullPath;

            bool t = false;
            pth = pth.Remove(0, nameRoot.Length + 1);
            string pthL = Path.Combine(pathL, pth); // rootPathLocal
            string pthS = Path.Combine(pathS, pth); // rootPathServer

            switch (Napr) // направление
            {
                case 0:
                    FileA.RenameDirectory(pthL, tb_newNameFolder.Text);
                    t = true;
                    break;
                case 1:
                    FileA.RenameDirectory(pthS, tb_newNameFolder.Text);
                    t = true;
                    break;
                case 2:
                    FileA.RenameDirectory(pthL, tb_newNameFolder.Text);
                    FileA.RenameDirectory(pthS, tb_newNameFolder.Text);
                    t = true;
                    break;
                default:
                    t = false;
                    break;
            }
            if (t)
            {
                treeViewFolder.SelectedNode.Text = tb_newNameFolder.Text;
            }
        }
        private void MenuItemDeleteFolder_Click(object sender, EventArgs e)
        {
            string pth = treeViewFolder.SelectedNode.FullPath;
            bool t = false;
            pth = pth.Remove(0, nameRoot.Length + 1);
            string pthL = Path.Combine(pathL, pth); // rootPathLocal
            string pthS = Path.Combine(pathS, pth); // rootPathServer

            switch (Napr) // направление
            {
                case 0:
                    FileA.DeleteFolder(pthL);
                    t = true;
                    break;
                case 1:
                    FileA.DeleteFolder(pthS);
                    t = true;
                    break;
                case 2:
                    FileA.DeleteFolder(pthL);
                    FileA.DeleteFolder(pthS);
                    t = true;
                    break;
                default:
                    t = false;
                    break;
            }
            if (t)
            {
                treeViewFolder.SelectedNode.Remove();
            }

        }
        private void Form_SelectSave_Load(object sender, EventArgs e)
        {
            TreeFolders.GetTreeDir(treeViewFolder, textBox1.Text);
            treeViewFolder.Nodes[0].Text = nameRoot;
            treeViewFolder.CheckBoxes = true;
        }
        private void CheckedNode(TreeNodeCollection nodes, List<TreeNode> list)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                    list.Add(node);

                CheckedNode(node.Nodes, list);
            }
        }

        // Создание списка путей для сохранения файлов по выбору пользователя
        public void GetPathFolders(List<string> listFolders, List<string> listFileDBPath)
        {
            listfolder.Clear();
            listFileDBPath.Clear();

            CheckedNode(treeViewFolder.Nodes, listfolder);

            foreach (TreeNode n in listfolder) // перебор папок
            {
                string sp = (n.FullPath).Remove(0, nameRoot.Length + 1);

                if (Napr == 2)
                {
                    listFolders.Add(Path.Combine(pathL, sp));
                    listFolders.Add(Path.Combine(pathS, sp));

                    listFileDBPath.Add(Path.Combine(pathL, sp));
                }
                if (Napr == 1)
                {
                    listFolders.Add(Path.Combine(pathS, sp));

                    listFileDBPath.Add(Path.Combine(pathS, sp));
                }
                if (Napr == 0)
                {
                    listFolders.Add(Path.Combine(pathL, sp));

                    listFileDBPath.Add(Path.Combine(pathL, sp));
                }
            }
        }


        public List<ListFile> CreateNewPath(object sender, List<string> listfile, int typeDocument)
        {
            listp.Clear();
            listfolder.Clear();

            CheckedNode(treeViewFolder.Nodes, listfolder);

            foreach (string pfile in listfile) // перебор всех путей переданных по DargDrop
            {
                if (FileA.GetAtributesPath(pfile))
                {
                    // Файл
                    string dfile = File.GetLastWriteTime(pfile).ToShortDateString(); //дата
                    string nfile = Path.GetFileNameWithoutExtension(pfile); // имя
                    listp.Add(new ListFile(pfile, nfile, dfile)); // создание списка файлов

                }
                else
                {   // Папка
                    string dfile = File.GetLastWriteTime(pfile).ToShortDateString(); //дата
                    string nfile = Path.GetFileName(pfile); // имя
                    listp.Add(new ListFile(pfile, nfile, dfile)); // создание списка файлов

                }
            }

            nPathes(listp, typeDocument);

            return listp;
        }

        private void nPathes(List<ListFile> listp_, int typeDocument)
        {
            int i = 0;
            foreach (ListFile lf in listp_) // перебор списка файлов 
            {
                switch (typeDocument)
                {
                    case 0: // Исходные данные | Основные положения Form_main.NameFld[5]
                        /// в два направления всегда
                        gb_Napravlenie.Enabled = false;
                        foreach (TreeNode n in listfolder) // перебор папок
                        {
                            //string sp = (n.FullPath).Remove(0, 4);
                            string sp = (n.FullPath).Remove(0, nameRoot.Length + 1);

                            if (Napr == 2)
                            {
                                lf.NewPathFile.pathLocal.Add(Path.Combine(pathL, sp));
                                lf.NewPathFile.pathServer.Add(Path.Combine(pathS, sp));
                            }
                            if (Napr == 1)
                            {
                                lf.NewPathFile.pathServer.Add(Path.Combine(pathS, sp));
                            }
                            if (Napr == 0)
                            {
                                lf.NewPathFile.pathLocal.Add(Path.Combine(pathL, sp));
                            }

                        }

                        break;
                    case 1: // Письма
                        /// только локально
                        lf.NewPathFile.pathLocal.Add(Path.Combine(pathL, Libr.NameFld[6]));
                        lf.NewPathFile.pathServer.Add("");
                        /// выбор объекта
                        /// В имя папки добавить Название файла и дату 
                        break;
                    case 2: // Задания
                        /// выбор объекта
                        /// выбор раздела проекта либо своё название папки
                        break;
                    case 3:
                        /// выбор объекта
                        /// выбор раздела проекта либо своё название папки
                        break;
                    case 4:
                        /// выбор объекта
                        /// выбор раздела проекта либо своё название папки
                        break;
                    case 5:
                        /// выбор объекта
                        /// выбор раздела проекта либо своё название папки
                        break;
                    case 6:
                        /// выбор раздела проекта либо своё название папки
                        break;
                    default:

                        break;
                }
            }
        }

        private void rb_All_Click(object sender, EventArgs e)
        {
            Napr = 2;
        }

        private void rb_Serv_CheckedChanged(object sender, EventArgs e)
        {
            Napr = 1;
        }

        private void rb_Loc_CheckedChanged(object sender, EventArgs e)
        {
            Napr = 0;
        }

        private void treeViewFolder_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewFolder.SelectedNode = e.Node;
        }

        #region test
        public void CreateListFolders()
        {
            List<TreeNode> list = new List<TreeNode>();
            CheckedNode(treeViewFolder.Nodes, list);
            MessageBox.Show(list.Count.ToString());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        #endregion

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            //CheckedNode(treeViewFolder.Nodes, listfolder);
            //MessageBox.Show(listfolder.Count.ToString());
        }

        private void contextMenuSave_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
