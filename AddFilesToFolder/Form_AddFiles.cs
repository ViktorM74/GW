using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FileAction;
using System.IO;
using TreeFoldersClass;
using Distinary;
using DBClass;

namespace AddFilesToFolder
{
    public partial class Form_AddFiles : Form
    {
        string pathL;
        string pathS;
        string pathRoot;
        int Napr;
        string nameRoot;
        List<TreeNode> listfolder = new List<TreeNode>(); // Короткий путь до уровня root 

        public List<string> ListFiles = new List<string>();

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


            rb_All.Click += (a, s) =>
            {
                CheckedChange();
                SetRootNode();
                CreateTreeNodeFolder();
            };
            rb_Loc.Click += (a, s) =>
            {
                CheckedChange();
                SetRootNode();
                CreateTreeNodeFolder();
            };
            rb_Serv.Click += (a, s) =>
            {
                CheckedChange();
                SetRootNode();
                CreateTreeNodeFolder();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetNapr(int i)
        {
            switch (i)
            {
                case 0: // только локально
                    rb_Loc.Enabled = true;
                    rb_Serv.Enabled = false;
                    rb_All.Enabled = false;
                    rb_Loc.Checked = true;
                    rb_Serv.Checked = false;
                    rb_All.Checked = false;
                    textBox1.Enabled = true;
                    textBox2.Enabled = false;
                    break;
                case 1: // только сервер
                    rb_Loc.Enabled = false;
                    rb_Serv.Enabled = true;
                    rb_All.Enabled = false;
                    rb_Serv.Checked = true;
                    rb_Loc.Checked = false;
                    rb_All.Checked = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = true;
                    break;
                case 2: // два направления
                    rb_Loc.Enabled = false;
                    rb_Serv.Enabled = false;
                    rb_All.Enabled = true;
                    rb_All.Checked = true;
                    rb_Loc.Checked = false;
                    rb_Serv.Checked = false;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    break;
                default: // на выбор пользователя
                    rb_Loc.Enabled = true;
                    rb_Serv.Enabled = true;
                    rb_All.Enabled = true;
                    rb_All.Checked = true;
                    rb_Loc.Checked = false;
                    rb_Serv.Checked = false;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    break;
            }

           
        }

        /// <summary>
        /// Определяет направление копирования
        /// </summary>
        /// <returns></returns>
        private int CheckedChange()
        {
            int result = 0;
            if (rb_All.Checked)
                result = 2;
            if (rb_Loc.Checked)
                result = 0;
            if (rb_Serv.Checked)
                result = 1;
            return result;
        }

        private string Set_pth(TreeNode node)
        {
            string path = node.FullPath; // получаем путь вывделенного в дереве каталога

            if (pathRoot != path) //Проверяем, не выбран ли корневой каталог
                path = path.Remove(0, pathRoot.Length + 1); //Если нет, то удаляем название корневого каталога из пути
            else
                path = ""; // Если да, то очищаем путь до корневого каталога
            return path;
        }

        /// <summary>
        /// Создать новый каталог в указанном
        /// </summary>
        private void MenuItemNewFolder_Click(object sender, EventArgs e)
        {
            bool t = false;
            string pth = Set_pth(treeViewFolder.SelectedNode);
            string pthL = Path.Combine(pathL, pth); // rootPathLocal Получаем путь для локальной папки
            string pthS = Path.Combine(pathS, pth); // rootPathServer Получаем путь для сетевой папки

            switch (Napr) // в зависимости от направления создаем новый каталог
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
            if (t) // Если создание нового каталога прошло успешно, то добавляем его в дерево 
            {
                int inode = treeViewFolder.SelectedNode.Index;
                TreeNode node = treeViewFolder.SelectedNode.Nodes.Insert(inode, tb_newNameFolder.Text);
                treeViewFolder.SelectedNode.Expand();
                treeViewFolder.SelectedNode = node;
                treeViewFolder.Select();
            }
        }

  

        /// <summary>
        /// Переименовывает указанный каталог 
        /// </summary>
        private void MenuItemReName_Click(object sender, EventArgs e)
        {
            bool t = false;
            string pth = Set_pth(treeViewFolder.SelectedNode);
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
        /// <summary>
        /// Удаляет указанный каталог
        /// </summary>
        private void MenuItemDeleteFolder_Click(object sender, EventArgs e)
        {
            bool t = false;
            string pth = Set_pth(treeViewFolder.SelectedNode);
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

        /// <summary>
        /// Происходит при загрузке формы и создает дерево узлов 
        /// </summary>
        private void Form_SelectSave_Load(object sender, EventArgs e)
        {
            SetRootNode();

            CreateTreeNodeFolder();

            if (ListFiles.Count != 0)
            {
                foreach (string l in ListFiles)
                {
                    listBoxFiles.Items.Add(l);
                }
            }

        }

        private void SetRootNode()
        {
            Napr = CheckedChange();
            if (Napr == 2 || Napr == 0)
            {
                pathRoot = textBox1.Text;
            }
            else
            {
                pathRoot = textBox2.Text;
            }
        }

        private void CreateTreeNodeFolder()
        {
            //TreeFolders.GetTreeDir(treeViewFolder, pathRoot); //Создает дерево узлов
            TreeDirectory.FillDirNodes(treeViewFolder, pathRoot);
            //treeViewFolder.Nodes[0].Text = nameRoot; //Устанавливает имя первого узла
            treeViewFolder.CheckBoxes = true; //Разрешает CheckBox в узлах
        }

        /// <summary>
        /// Создает список отмеченных узлов
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="list">Список отмеченных Node</param>
        private void CheckedNode(TreeNodeCollection nodes, List<TreeNode> list)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    list.Add(node);
                }
                    

                CheckedNode(node.Nodes, list);
            }
        }
        /// <summary>
        /// Добавляет новый узел ко всем ранее выбранным
        /// </summary>
        private void AddNewNodeToSelectedNodes(TreeNodeCollection nodes, string newName)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    int inode = node.Index;
                    // добавить узлы в TreeNode 
                    TreeNode nd = node.Nodes.Insert(inode, newName);
                    nd.Expand();
                   
                }
                AddNewNodeToSelectedNodes(node.Nodes, newName);
            }
        }

        /// <summary>
        /// Создание списка путей для сохранения файлов по выбору пользователя
        /// listFolders - список путей для копирования файлов
        /// listFileDBPath - список для сохранения в базе данных
        /// </summary>
        public void GetPathFolders(List<string> listFolders, List<string> listFileDBPath)
        {
            // listFolders - список путей для копирования файлов
            listFolders.Clear(); // - список выбранных путей из дерева узлов
            listFileDBPath.Clear(); // - список для сохранения в базе данных

            CheckedNode(treeViewFolder.Nodes, listfolder); //Получаем список путей к папкам для копирования (без учета локального или сетевого каталога)

            foreach (TreeNode n in listfolder) // перебор папок
            {
                string pth = Set_pth(n);

                if (Napr == 2) // в два направления
                {
                    listFolders.Add(Path.Combine(pathL, pth));
                    listFolders.Add(Path.Combine(pathS, pth));

                    listFileDBPath.Add(Path.Combine(pathL, pth));
                }
                if (Napr == 1) // только на сервер
                {
                    listFolders.Add(Path.Combine(pathS, pth));

                    listFileDBPath.Add(Path.Combine(pathS, pth));
                }
                if (Napr == 0) // только локально
                {
                    listFolders.Add(Path.Combine(pathL, pth));

                    listFileDBPath.Add(Path.Combine(pathL, pth));
                }
            }
        }

        /// <summary>
        /// Обеспечивает выделение Node по правому клику мыши 
        /// нужно для правильной работы контекстного меню по выбранному узлу
        /// </summary>
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

        #endregion test

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            bool ac = false;
            if (chb_CopyToNewFolder.Checked)
            {
                // По списку выбранных узлов
                // создать новые папки 
                //AddNewFolderToSelectedFolder();
                // добавляем новые папки в пути копирования и копируем файлы
                ac = CopySelectedFilesToNewFolder();
                
            }
            else
            {
                ac = CopySelectedFiles();
            }

            if (ac)
            {
                MessageBox.Show("Файлы успешно скопированы.");
                Close();
            }
                
        }

        private void AddNewFolderToSelectedFolder()
        {
            List<string> listFolders = new List<string>();
            List<string> listFileDBPath = new List<string>();
            string newNameFolder = "";
            // генерируем имя новой папки
            GenerateNewFolderName();
            newNameFolder = tb_newNameFolder.Text;
            // Получаем список выбранных узлов
            GetPathFolders(listFolders, listFileDBPath);
            if (listFolders.Count == 0)
            {
                throw new Exception("Вы не выбрали пути для копирования. Повторите операцию!");
            }
            // создать новые папки 
            foreach(string p in listFolders)
            {
                FileA.CreateFolder(newNameFolder, p); // создаем new-папку для каждого выбранного узла
            }
            //добавляем узлы в TreeViewFolder
            AddNewNodeToSelectedNodes(treeViewFolder.Nodes, newNameFolder);

        }

        private void btn_contextMenuNameFolder_Click(object sender, EventArgs e)
        {
            GenerateNewFolderName();
        }

        private void GenerateNewFolderName()
        {
            if (tb_newNameFolder.Text == "Новая папка" ||
                tb_newNameFolder.Text == DateTime.Now.ToString("yyyy.MM.dd"))
            {
                tb_newNameFolder.Text = "";
            }
            if (tb_newNameFolder.Text != "")
            {
                tb_newNameFolder.Text = DateTime.Now.ToString("yyyy.MM.dd") + " "
                   + tb_newNameFolder.Text;
            }
            else
            {
                tb_newNameFolder.Text = DateTime.Now.ToString("yyyy.MM.dd");
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string path in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
               listBoxFiles.Items.Add(path);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Remove(listBoxFiles.SelectedItem);
        }

        private void очиститьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
        }

        private bool CopySelectedFiles()
        {
            List<string> fileList = new List<string>();
            List<string> listFolders = new List<string>();
            List<string> listFileDBPath = new List<string>();

            GetPathFolders(listFolders, listFileDBPath);
            
            try
            {
                if (listFolders.Count == 0 || listFileDBPath.Count == 0)
                    throw new Exception("Не выбран ни один путь для копирования");

                foreach (string fl in listBoxFiles.Items)
                {
                    fileList.Add(fl);
                }

                FileA.CopyListFiles(fileList, listFolders);
                //TODO: Добавить регистрация в базе по списку listFileDBPath
                DB_Cmd.AddDocumentToDB(listFileDBPath);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private bool CopySelectedFilesToNewFolder()
        {
            List<string> fileList = new List<string>();
            List<string> listFolders = new List<string>();
            List<string> listNewFolders = new List<string>();
            List<string> listFileDBPath = new List<string>();

            GetPathFolders(listFolders, listFileDBPath);

            try
            {
                if (listFolders.Count == 0 || listFileDBPath.Count == 0)
                    throw new Exception("Не выбран ни один путь для копирования");

                GenerateNewFolderName();

                foreach (string fl in listBoxFiles.Items)
                {
                    fileList.Add(fl);
                }
               
                foreach(string p in listFolders)
                {
                    listNewFolders.Add(Path.Combine(p, tb_newNameFolder.Text));
                }
               
                FileA.CopyListFiles(fileList, listNewFolders);
                //TODO: Добавить регистрация в базе по списку listFileDBPath
               
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void treeViewFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeDirectory.BeforeExpand(sender, e);
        }

        private void treeViewFolder_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            TreeDirectory.BeforeSelect(sender, e);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileA.RunFolder(treeViewFolder.SelectedNode.FullPath);
        }
    }
}
