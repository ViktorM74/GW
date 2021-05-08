using System;
using System.Collections.Generic;
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
        //List<ListFile> listp = new List<ListFile>(); // список свойств (имя \ дата, путьЛок, путьСерв)
        //List<string> listNPathFolders = new List<string>(); // список папок выбранных как путь сохранения

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
            Napr = CheckedChange();

            rb_All.Click += (a, s) => CheckedChange();
            rb_Loc.Click += (a, s) => CheckedChange();
            rb_Serv.Click += (a, s) => CheckedChange();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        /// <summary>
        /// Создать новый каталог в указанном
        /// </summary>
        private void MenuItemNewFolder_Click(object sender, EventArgs e)
        {
            string pth = treeViewFolder.SelectedNode.FullPath; // получаем путь вывделенного в дереве каталога
            bool t = false;
            if (nameRoot.Length != pth.Length) //Проверяем, не выбран ли корневой каталог
                pth = pth.Remove(0, nameRoot.Length + 1); //Если нет, то удаляем название корневого каталога из пути
            else
                pth = ""; // Если да, то очищаем путь до корневого каталога
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
        /// <summary>
        /// Удаляет указанный каталог
        /// </summary>
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

        /// <summary>
        /// Происходит при загрузке формы и создает дерево узлов 
        /// </summary>
        private void Form_SelectSave_Load(object sender, EventArgs e)
        {
            TreeFolders.GetTreeDir(treeViewFolder, textBox1.Text); //Создает дерево узлов
            treeViewFolder.Nodes[0].Text = nameRoot; //Устанавливает имя первого узла
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
                    list.Add(node);

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
            listfolder.Clear(); // - список выбранных путей из дерева узлов
            listFileDBPath.Clear(); // - список для сохранения в базе данных

            CheckedNode(treeViewFolder.Nodes, listfolder); //Получаем список путей к папкам для копирования (без учета локального или сетевого каталога)

            foreach (TreeNode n in listfolder) // перебор папок
            {
                string sp = (n.FullPath).Remove(0, nameRoot.Length + 1);

                if (Napr == 2) // в два направления
                {
                    listFolders.Add(Path.Combine(pathL, sp));
                    listFolders.Add(Path.Combine(pathS, sp));

                    listFileDBPath.Add(Path.Combine(pathL, sp));
                }
                if (Napr == 1) // только на сервер
                {
                    listFolders.Add(Path.Combine(pathS, sp));

                    listFileDBPath.Add(Path.Combine(pathS, sp));
                }
                if (Napr == 0) // только локально
                {
                    listFolders.Add(Path.Combine(pathL, sp));

                    listFileDBPath.Add(Path.Combine(pathL, sp));
                }
            }
        }


        //public List<ListFile> CreateNewPath(object sender, List<string> listfile, int typeDocument)
        //{
        //    listp.Clear();
        //    listfolder.Clear();

        //    CheckedNode(treeViewFolder.Nodes, listfolder);

        //    foreach (string pfile in listfile) // перебор всех путей переданных по DargDrop
        //    {
        //        if (FileA.GetAtributesPath(pfile))
        //        {
        //            // Файл
        //            string dfile = File.GetLastWriteTime(pfile).ToShortDateString(); //дата
        //            string nfile = Path.GetFileNameWithoutExtension(pfile); // имя
        //            listp.Add(new ListFile(pfile, nfile, dfile)); // создание списка файлов

        //        }
        //        else
        //        {   // Папка
        //            string dfile = File.GetLastWriteTime(pfile).ToShortDateString(); //дата
        //            string nfile = Path.GetFileName(pfile); // имя
        //            listp.Add(new ListFile(pfile, nfile, dfile)); // создание списка файлов

        //        }
        //    }

        //    nPathes(listp, typeDocument);

        //    return listp;
        //}

        //private void nPathes(List<ListFile> listp_, int typeDocument)
        //{
        //    int i = 0;
        //    foreach (ListFile lf in listp_) // перебор списка файлов 
        //    {
        //        switch (typeDocument)
        //        {
        //            case 0: // Исходные данные | Основные положения Form_main.NameFld[5]
        //                /// в два направления всегда
        //                gb_Napravlenie.Enabled = false;
        //                foreach (TreeNode n in listfolder) // перебор папок
        //                {
        //                    //string sp = (n.FullPath).Remove(0, 4);
        //                    string sp = (n.FullPath).Remove(0, nameRoot.Length + 1);

        //                    if (Napr == 2)
        //                    {
        //                        lf.NewPathFile.pathLocal.Add(Path.Combine(pathL, sp));
        //                        lf.NewPathFile.pathServer.Add(Path.Combine(pathS, sp));
        //                    }
        //                    if (Napr == 1)
        //                    {
        //                        lf.NewPathFile.pathServer.Add(Path.Combine(pathS, sp));
        //                    }
        //                    if (Napr == 0)
        //                    {
        //                        lf.NewPathFile.pathLocal.Add(Path.Combine(pathL, sp));
        //                    }

        //                }

        //                break;
        //            case 1: // Письма
        //                /// только локально
        //                lf.NewPathFile.pathLocal.Add(Path.Combine(pathL, Libr.NameFld[6]));
        //                lf.NewPathFile.pathServer.Add("");
        //                /// выбор объекта
        //                /// В имя папки добавить Название файла и дату 
        //                break;
        //            case 2: // Задания
        //                /// выбор объекта
        //                /// выбор раздела проекта либо своё название папки
        //                break;
        //            case 3:
        //                /// выбор объекта
        //                /// выбор раздела проекта либо своё название папки
        //                break;
        //            case 4:
        //                /// выбор объекта
        //                /// выбор раздела проекта либо своё название папки
        //                break;
        //            case 5:
        //                /// выбор объекта
        //                /// выбор раздела проекта либо своё название папки
        //                break;
        //            case 6:
        //                /// выбор раздела проекта либо своё название папки
        //                break;
        //            default:

        //                break;
        //        }
        //    }
        //}

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
      
        #endregion

        private void btn_Accept_Click(object sender, EventArgs e)
        {
           if (chb_CopyToNewFolder.Checked)
            {
                // По списку выбранных узлов
                // создать новые папки 
                AddNewFolderToSelectedFolder();
                // добавляем новые папки в пути копирования и копируем файлы
                if (CopySelectedFilesToNewFolder())
                {
                    MessageBox.Show("Файлы скопированы по указанным адресам");
                }
                else { MessageBox.Show("При копировании возникли ошибки"); }
            }
            else
            {
                if (CopySelectedFiles())
                {
                    MessageBox.Show("Файлы скопированы по указанным адресам");
                }
                else { MessageBox.Show("При копировании возникли ошибки"); }
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

            try
            {

                foreach (string fl in listBoxFiles.Items)
                {
                    fileList.Add(fl);
                }
                GetPathFolders(listFolders, listFileDBPath);

                if (listFolders.Count != 0 || listFileDBPath.Count != 0)
                {
                    FileA.CopyListFiles(fileList, listFolders);
                    //TODO: Добавить регистрация в базе по списку listFileDBPath
                }
                else
                {
                    MessageBox.Show("Не выбран ни один путь для копирования");
                }
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

            try
            {

                foreach (string fl in listBoxFiles.Items)
                {
                    fileList.Add(fl);
                }
                GetPathFolders(listFolders, listFileDBPath);
                foreach(string p in listFolders)
                {
                    listNewFolders.Add(Path.Combine(p, tb_newNameFolder.Text));
                }
                if (listNewFolders.Count != 0 || listFileDBPath.Count != 0)
                {
                    FileA.CopyListFiles(fileList, listNewFolders);
                    //TODO: Добавить регистрация в базе по списку listFileDBPath
                }
                else
                {
                    MessageBox.Show("Не выбран ни один путь для копирования");
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
