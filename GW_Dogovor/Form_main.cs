using DBClass;
using DBClass._bsp_snhpDataSetTableAdapters;
using DocTYPELibrary;
using GW_Dogovor.Properties;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FileAction;
using TreeFoldersClass;
using System.Collections;
using ProjectClass;
using TenderClass;
using Distinary;
using AddFilesToFolder;
using FolderManager;
using ObjectClass;
using DogovorClass;
using DocumentsClass;
using DopSoglClass;
using CPlan;

namespace GW_Dogovor
{
    public partial class Form_main : Form
    {

        string tPathDB;

        bool R = false;

     
        public Form_main()
        {
            InitializeComponent();

            AppSetting seting = new AppSetting();

            tPathDB = seting.GetConnectionString();

            if (File.Exists(tPathDB))
            {
                ConnectDB();
                SetView();
                R = true;
            }
            else
            {
                ContactManager cmForm = new ContactManager();
                if (cmForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Для применения изменений перезапустите программу");
                    R = true;
                }
            }

            void SetView()
            {
                SetViewDataProject();
                SetViewDataDocument();
                SetViewTender();
                SetViewDogovor();
                SetViewDDog();
                SetViewObject();
                SetViewTabControl();
                SetViewBindNavigators();
            }

        }
        public void ConnectDB()
        {
            DB_Cmd.DBLoad();
        }

        #region ViewForms 
        // Установка связей контролов с базой
        private void SetViewDataProject()
        {
            tbNameProject.DataBindings.Add("Text", DB_Cmd.bndProject, "Name");
            tb_Code_object.DataBindings.Add("Text", DB_Cmd.bndProject, "Code_object");
            tb_pName.DataBindings.Add("Text", DB_Cmd.bndProject, "Name");
            tb_pNotes.DataBindings.Add("Text", DB_Cmd.bndProject, "Notes");
            tb_AreaStroy.DataBindings.Add("Text", DB_Cmd.bndProject, "AreaStroy"); // Parent([CustomersProject]).[NameCust]
            tb_Status.DataBindings.Add("Text", DB_Cmd.bndProject, "Status");
            link_LocalFld.DataBindings.Add("Text", DB_Cmd.bndProject, "Path_folder");
            link_ServetFld.DataBindings.Add("Text", DB_Cmd.bndProject, "Path_server");

            grid_ProjectCode.AutoGenerateColumns = false;
            grid_ProjectCode.DataSource = DB_Cmd.bndProject;
            grid_ProjectCode.Columns["Code_object"].DataPropertyName = "Code_object";
        }
        private void SetViewDataDocument()
        {
            // Parent([Documets_typeDocuments]).[Name_doc]
            gridDocument.AutoGenerateColumns = false;
            gridDocument.DataSource = DB_Cmd.bndDocument;
            gridDocument.Columns["NameDoc"].DataPropertyName = "NameDoc";
            gridDocument.Columns["Nambe_Doc"].DataPropertyName = "Nambe_Doc";
            gridDocument.Columns["DataDoc"].DataPropertyName = "DataDoc";
            gridDocument.Columns["Status"].DataPropertyName = "Status";
            gridDocument.Columns["PathDoc"].DataPropertyName = "PathDoc";

            bndNvg_IshDoc.BindingSource = DB_Cmd.bndDocument;
         
        }
        private void SetViewTender()
        {
            bndNavigatorTender.BindingSource = DB_Cmd.bndTender;
            
            tb_TndCustomer.DataBindings.Add("Text", DB_Cmd.bndTender, "Customer");
            tb_TndName.DataBindings.Add("Text", DB_Cmd.bndTender, "Name_Tender");
            tb_TndStadia.DataBindings.Add("Text", DB_Cmd.bndTender, "Stadia");
            dtp_TenderData.DataBindings.Add("Text", DB_Cmd.bndTender, "Data_End");
            tb_TndStatus.DataBindings.Add("Text", DB_Cmd.bndTender, "Status");
            tb_TndGIP.DataBindings.Add("Text", DB_Cmd.bndTender, "NameGip");
            tb_TndSostav.DataBindings.Add("Text", DB_Cmd.bndTender, "Sostav");
            tb_TndComents.DataBindings.Add("Text", DB_Cmd.bndTender, "Comments");

            grid_TenderDoc.AutoGenerateColumns = false;
            grid_TenderDoc.DataSource = DB_Cmd.bndDocument;
            grid_TenderDoc.Columns["NameTDoc"].DataPropertyName = "NameDoc";
            grid_TenderDoc.Columns["StatudTDoc"].DataPropertyName = "Status";
            grid_TenderDoc.Columns["PathTDoc"].DataPropertyName = "PathDoc";
           // Фильтр по ["Tender_id"] != null

        }
        private void SetViewDogovor()
        {
            bndNavigatorDogovor.BindingSource = DB_Cmd.bndDogovor;
            bndNavigator_KP_Dog.BindingSource = DB_Cmd.bndCalendarPlan;
            //bndCalendarPlan.RemoveFilter();


            tb_NumDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Nambe_Dog");
            dtp_DateDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "DataOt");
            tb_StatusDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Status");
            dtp_ToDateDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Data_Konec");
            tb_NameDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Name_Dog");
            // tb_AllSummDog
            // tb_spentSummDog
            // tb_remainedSummDog
            tb_CommentDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Comments");
            
            // grid Dogovor
            grid_Dogovor.AutoGenerateColumns = false;
            grid_Dogovor.DataSource = DB_Cmd.bndDogovor;
            grid_Dogovor.Columns["NumDogovor"].DataPropertyName = "Nambe_Dog";

            // grid Documents
            grid_DogovorDoc.AutoGenerateColumns = false;
            grid_DogovorDoc.DataSource = DB_Cmd.bndDocument;
            grid_DogovorDoc.Columns["dogNameDoc"].DataPropertyName = "NameDoc";
            //grid_DogovorDoc.Columns["dRunDoc"].DataPropertyName = "PathDoc";

            // grid CPlan
            grid_CPlan.AutoGenerateColumns = false;
            grid_CPlan.DataSource = DB_Cmd.bndCalendarPlan;
            grid_CPlan.Columns["Num_Etap"].DataPropertyName = "Num_Etap";
            grid_CPlan.Columns["Name_Etap"].DataPropertyName = "Name_Etap";
            grid_CPlan.Columns["Nachalo_Data"].DataPropertyName = "Nachalo_Data";
            grid_CPlan.Columns["Konec_Data"].DataPropertyName = "Konec_Data";
            grid_CPlan.Columns["Summ"].DataPropertyName = "Summ";
            grid_CPlan.Columns["Valute"].DataPropertyName = "V";
            grid_CPlan.Columns["StatusCPlan"].DataPropertyName = "Status";

            grid_CPlan.EditingPanel.BorderStyle = BorderStyle.Fixed3D;
           

        }
        private void SetViewDDog()
        {
            tb_NumDD.DataBindings.Add("Text", DB_Cmd.bndDopDogovor, "Nambe_DS");
            tb_DateDD.DataBindings.Add("Text", DB_Cmd.bndDopDogovor, "DataPodp");
            tb_StatusDD.DataBindings.Add("Text", DB_Cmd.bndDopDogovor, "Status");
            tb_ToDateDD.DataBindings.Add("Text", DB_Cmd.bndDopDogovor, "Data_Konec");
            tb_NotesDD.DataBindings.Add("Text", DB_Cmd.bndDopDogovor, "Comments");

            grid_DD.AutoGenerateColumns = false;
            grid_DD.DataSource = DB_Cmd.bndDopDogovor;
            grid_DD.Columns["NumDD"].DataPropertyName = "Nambe_DS";

            bndNavigatorDDog.BindingSource = DB_Cmd.bndDopDogovor;
            bndNavigator_KP_Dop.BindingSource = DB_Cmd.bndCalendarPlan;
            //bndCalendarPlan.Filter = "";
            
        }
        private void SetViewObject()
        {
            tb_NameUObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Name_Ustanovka");
            tb_NameObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Name_object");
            tb_CodeObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Nambe_Object");
            tb_TitleObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Titul");
            tb_BlockObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Block");
          
            //GIP
            tb_GIPObject.DataBindings.Add("Text", DB_Cmd.bndObject, "NameGIP");

            grid_Object.AutoGenerateColumns = false;
            grid_Object.DataSource = DB_Cmd.bndObject;
            grid_Object.Columns["CodeObj"].DataPropertyName = "CodeOBJ";

            bndNavigatorObject.BindingSource = DB_Cmd.bndObject;
            bndNavigator_Graph_Mark.BindingSource = DB_Cmd.bndSostavObj;
            bndNavigator_Graph_Z.BindingSource = DB_Cmd.bndZadania;
            bndNavigator_Z.BindingSource = DB_Cmd.bndZadania;

        }
        //
      
        private void SetViewTabControl() /// логика - вынести из UI
        {
            //0-ИД; 1-Письма; 2-Задания; 3-Тендер; 4-Договор; 5-График; 6- Объект; 7- Изыскания; 8- Штамп; 9- Разное; 10- Основные положения; 11- Входящие; 12- Исходящие
            switch (tabControlMain.SelectedIndex)
            {
                case 0: // Документы
                    SelectedTypeDocuments();
                    break;
                case 1: // Тендер
                    DB_Cmd.bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Not Is Null) AND (Object_id Is Null) AND (Event_id Is Null) AND (Act_id Is Null)";
                    break;
                case 2: // Договор * добавить поле id_Dogovor
                    DB_Cmd.bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Not Is Null) AND (Object_id Is Null) AND (Event_id Is Null) AND (Act_id Is Null)";
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5: // Архив
                    //tb_PathArh.Text = Settings.Default.PathArhive;
                    //if (Directory.Exists(tb_PathArh.Text))
                    //            GetTreeDir(tree_Arh, tb_PathArh.Text);
                    break;
                case 6:

                    break;
                default:
                    DB_Cmd.bndDocument.RemoveFilter();
                    break;

                    
            }
            
            SetViewBindNavigators();

        } // Фильтры для Документов
        private void SelectedTypeDocuments()
        {
            //0-ИД; 1-Письма; 2-Задания; 3-Тендер; 4-Договор; 5-График; 6- Объект; 7- Изыскания; 8- Штамп; 9- Разное; 10- Основные положения; 11- Входящие; 12- Исходящие
            if (tabControlMain.SelectedIndex == 0)
            {
                switch (tabDocuments.SelectedIndex)
                {
                    case 0: /// Исходные данные

                        DB_Cmd.bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Is Null) AND (Object_id Is Null) " +
                            "AND (Event_id Is Null) AND (Act_id Is Null) AND (Control = false)";
                        break;
                    case 1: /// Письма на контроле

                        DB_Cmd.bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Is Null) AND (Object_id Is Null) " +
                            "AND (Event_id Is Null) AND (Act_id Is Null) AND (Control = true)";
                        break;
                    case 2: /// Задания

                        DB_Cmd.bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Not Is Null) AND (Object_id Not Is Null) " +
                           "AND (Event_id Is Null) AND (Act_id Is Null) AND (Control = false)";
                        break;
                    default: // Исходные данные

                        DB_Cmd.bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Is Null) AND (Object_id Is Null) " +
                           "AND (Event_id Is Null) AND (Act_id Is Null) AND (Control = false)";
                        break;
                }
            }

        } // Фильтры для Документов вкладка Документы
        private void SetViewBindNavigators()
        {
            if (DB_Cmd.bndProject.Count != 0)
            { 
              bndNvg_IshDoc.Enabled = true;
                bndNavigatorTender.Enabled = true;
                if (DB_Cmd.bndTender.Count != 0)
                {
                    bndNavigatorDogovor.Enabled = true;
                    if (DB_Cmd.bndDogovor.Count != 0)
                    {
                        bndNavigatorDDog.Enabled = true;
                        bndNavigatorObject.Enabled = true;
                    }
                    else
                    {
                        bndNavigatorDDog.Enabled = false;
                        bndNavigatorObject.Enabled = false;
                    }
                }
                else
                {
                    bndNavigatorDogovor.Enabled = false;
                }
            }
            else
            {
                bndNvg_IshDoc.Enabled = false;
                bndNavigatorTender.Enabled = false;
            }
        } // Активность Навигаторов
        private void SetViewForm()
        {
            if (Settings.Default.PanelsProjectView)
            {
                splitContainer1.Panel1Collapsed = Settings.Default.PanelsProjectView;
                tbtn_ViewProject.Image = Resources.seo_and_web;
            }
            else
            {
                splitContainer1.Panel1Collapsed = Settings.Default.PanelsProjectView;
                
                tbtn_ViewProject.Image = Resources._return;
            }
        } // Установка иконки кнопки видимости панели Проект
        private void ProjectPanelsVisable(object sender, EventArgs e)
        {
            Settings.Default.PanelsProjectView = !Settings.Default.PanelsProjectView;
            Settings.Default.Save();
            SetViewForm();
        } // Установка видимости панели Проект
        private void ts_ComboBoxDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTypeDocuments();
        }
        #region WindowState
        private void GetFormView() // Устанавлюваем значения Формы из сохраненных параметров
        {
            if (Settings.Default.Main_Location != null)
            {
                this.Location = Settings.Default.Main_Location;
            }

            if (Settings.Default.Main_Size != null)
            {
                this.Size = Settings.Default.Main_Size;
            }

            this.splitContainer1.SplitterDistance = Settings.Default.Splitter_position;
            splitter1.SplitPosition = Settings.Default.TabDogovorSplit_position;
            splitter2.SplitPosition = Settings.Default.TabDDogSplit_position;
            //if (Settings.Default.TabPage != null)
            //{
            tabControlMain.SelectTab(Settings.Default.TabPage);
            //}

            splitContainerTender.SplitterDistance = 450;

            SetViewForm();
        } 
        private void SetFormView() // Сохраняем параметры Формы в конфиг
        {
            Settings.Default.Main_Location = this.Location;

            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.Main_Size = this.Size;
            }
            else
            {
                Settings.Default.Main_Size = this.RestoreBounds.Size;
            }

            Settings.Default.Splitter_position = this.splitContainer1.SplitterDistance;
            Settings.Default.TabDogovorSplit_position = splitter1.SplitPosition;
            Settings.Default.TabDDogSplit_position = splitter2.SplitPosition;
            Settings.Default.TabPage = tabControlMain.SelectedIndex;

            Settings.Default.Save();
        }
        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetFormView();
        }
        private void Clk() // Все простые события Клик
        {
            menuItem_PropertyConnect.Click += (s, a) =>
            {
                ContactManager cmForm = new ContactManager();
                cmForm.ShowDialog();
            };
            
            menuItem_TypeDoc.Click += (s, a) =>
            {
                Lib_doc_type libDocForm = new Lib_doc_type();
                libDocForm.ShowDialog();
            };
            
            bndNav_DeleteDoc.Click += deleteDocument;

            bndNav_AddDoc.Click += (s, a) =>
            {
                DB_Cmd.AddDoc();
                EditDoc();
            };

            bndNav_EditDoc.Click += (s, a) =>
            {
                EditDoc();
            };

            tbtn_ViewProject.Click += ProjectPanelsVisable;

            tbtn_EditProject.Click += (s, a) =>
            {
                EditProject();
            };

            tbtn_AddProject.Click += (s, a) =>
            {
                DB_Cmd.AddProject();
                
                EditProject();
            };

            tbtn_DeleteProject.Click += (s, a) =>
            {
                DB_Cmd.DeleteProject();
                DB_Cmd.SaveProject();
            };

            tbtn_TndEdit.Click += (s, a) =>
            {
                EditTender();
            };

            tbtn_TndAdd.Click += (s, a) =>
            {
                DB_Cmd.AddTender();
                FileA.CreateFolder("Тендер", link_LocalFld.Text);
                string newPath = Path.Combine(Path.Combine(link_LocalFld.Text, "Тендер"), DateTime.Now.ToString("yyyy.MM.dd"));
                FileA.CreateFolder(DateTime.Now.ToString("yyyy.MM.dd"), Path.Combine(link_LocalFld.Text, "Тендер"));
                ((DataRowView)DB_Cmd.bndTender.Current).Row["Path"] = newPath;
                EditTender();
               
                
            };

            tbtn_TndDelete.Click += (s, a) =>
            {
                DB_Cmd.DeleteTender();
                DB_Cmd.SaveTender();
            };

            tbtn_AddFolders.Click += (s, a) =>
            {
                Form_FolderManager ff = new Form_FolderManager(link_LocalFld.Text, link_ServetFld.Text, false);
                ff.ShowDialog();
            };

            gridDocument.DoubleClick += (s, a) =>
            {
                EditDoc();
            };
   
            link_LocalFld.Click += (s, a) =>
            {
                FileA.RunFolder(link_LocalFld.Text);
            };

            link_ServetFld.Click += (s, a) =>
            {
                FileA.RunFolder(link_ServetFld.Text);
            };

            tmCopySelect.Click += (s, a) =>
            {
                if (tbNameProject.SelectionLength > 0)
                    tbNameProject.Copy();
            };

            tmOpenLocalFolder.Click += (s, a) =>
            {
                FileA.RunFolder(link_LocalFld.Text);
            };

            tmOpenServerFolder.Click += (s, a) =>
            {
                FileA.RunFolder(link_ServetFld.Text);
            };

            tb_TndComents.DoubleClick += (s, a) =>
            {
                dbEditText(DB_Cmd.bndTender, "Comments");
            };

            tb_pNotes.DoubleClick += (s, a) =>
            {
                dbEditText(DB_Cmd.bndProject, "Notes");
            };

            tb_CommentDog.DoubleClick += (s, a) =>
            {
                dbEditText(DB_Cmd.bndDogovor, "Comments");
            };

            tb_NotesDD.DoubleClick += (s, a) =>
            {
                dbEditText(DB_Cmd.bndDopDogovor, "Comments");
            };

            tbtn_EditDog.Click += (s, a) =>
            {
                EditDogovor();
            };

            tbtn_AddDog.Click += (s, a) =>
            {
                DB_Cmd.AddDogovor();
                EditDogovor();
            };

            tbtn_DeleteDog.Click += (s, a) =>
            {
                DB_Cmd.DeleteDogovor();
                DB_Cmd.SaveDogovor();
            };

            tbtn_EditDDog.Click += (s, a) =>
            {
                EditDopDogovor();
            };

            tbtn_AddDDog.Click += (s, a) =>
            {
                DB_Cmd.AddDopSoglashenia();
                EditDopDogovor();
            };

            tbtn_DeleteDDog.Click += (s, a) =>
            {
                DB_Cmd.DeleteDopSoglashenia();
                DB_Cmd.SaveDopSoglashenia();
            };

            tbtn_EditObj.Click += (s, a) =>
            {
                EditObject();
            };

            tbtn_AddObj.Click += (s, a) =>
            {
                DB_Cmd.AddOBJECTS();
                EditObject();
            };

            tbtn_DeleteObj.Click += (s, a) =>
            {
                DB_Cmd.DeleteOBJECTS();
                DB_Cmd.SaveOBJECTS();
            };

            
        }
        #endregion
        private void Form_main_Load(object sender, EventArgs e)
        {
            if (!R) Close(); 
            GetFormView();
            Clk();
            lbl_BasePath.Text =tPathDB;
        }
        #endregion

        #region Edit DB
        #region Project
        private void EditProject()
        {
            Form_Project fed = new Form_Project();
            fed.ShowDialog();
        }

        #region DoubleClik_EditProject

        private void btn_EditProject_Click(object sender, EventArgs e)
        {
            EditProject();
        }

        private void grid_ProjectCode_DoubleClick(object sender, EventArgs e)
        {
            EditProject();
        }
        #endregion

        #endregion

        #region Tender
        private void EditTender()
        {
            Form_Tender fe = new Form_Tender();
  
            if (fe.ShowDialog() == DialogResult.OK)
            {
                fe.Validate();
                DB_Cmd.SaveTender();
            }
            else
            {
                fe.Validate();
                DB_Cmd.CancelTender();
            }
        }

        #endregion

        #region Dogovor
        private void EditDogovor()
        {
            Form_Dogovor fе = new Form_Dogovor();

            if (fе.ShowDialog() == DialogResult.OK)
            {
                fе.Validate();
                DB_Cmd.SaveDogovor();
            }
            else
            {
                fе.Validate();
                DB_Cmd.CancelDogovor();
            }
        }
 
        #endregion

        #region DopDogovor
        private void EditDopDogovor()
        {
            Form_DopSogl fе = new Form_DopSogl();

            if (fе.ShowDialog() == DialogResult.OK)
            {
                fе.Validate();
                DB_Cmd.SaveDopSoglashenia();
            }
            else
            {
                fе.Validate();
                DB_Cmd.CancelDopSoglashenia();
            }
        }
         
        #endregion

        #region Document
        private void EditDoc()
        {
            Form_Document fed = new Form_Document();
            if (fed.ShowDialog() == DialogResult.OK)
            {
                fed.Validate();
                DB_Cmd.SaveDoc();
            }
            else
            {
                fed.Validate();
                DB_Cmd.CancelDoc();
            }
        }
       
        private void DeleteDoc(string fld)
        {
            //   string pathDoc = ((DataRowView)bndDocument.Current).Row["PathDoc"].ToString();
            //   string pathSecond = pathDoc.Remove(0, (int)link_LocalFld.Text.Length-1);
            //   //удаляем физически
            //try
            //   {
            //       string name = Path.GetFileName(pathDoc);
            //       string PLocal = Path.Combine(link_LocalFld.Text, pathSecond);
            //       string PServer = Path.Combine(link_ServetFld.Text, pathSecond);
            //       FileA.DeleteDocument(name, PLocal, PServer);
            //   }
            //   catch (Exception ex)
            //  {
            //       MessageBox.Show(ex.Message);
            //  }


            //удаляем из базы
            DB_Cmd.DeleteDoc();
            DB_Cmd.SaveDoc();

        }
        private void deleteDocument(object sender, EventArgs e)
        {
            //0-ИД; 1-Письма; 2-Задания; 3-Тендер; 4-Договор; 5-График; 6- Объект; 7- Изыскания; 8- Штамп; 9- Разное; 10- Основные положения; 11- Входящие; 12- Исходящие

            switch (tabDocuments.SelectedIndex)
            {
                case 0:
                    //DeleteDoc(Libr.NameFld[0]);
                    break;
                case 1:
                    //DeleteDoc(Libr.NameFld[1]);
                    break;
                case 2:

                    break;

                default:
                    //DeleteDoc(Libr.NameFld[0]);
                    break;
            }
        }
        #endregion

        #region Object
        private void EditObject()
        {
            Form_Object fе = new Form_Object(DB_Cmd.bndObject, DB_Cmd.bndGip, DB_Cmd.bndStadia);

            if (fе.ShowDialog() == DialogResult.OK)
            {
                fе.Validate();
                DB_Cmd.SaveOBJECTS();
            }
            else
            {
                fе.Validate();
                DB_Cmd.CancelOBJECTS();
            }
        }
     
       #endregion

        #region Calendar Plan
       
        #endregion

        #region EditText
        private void dbEditText(BindingSource bnd, String fld)
        {
            FormEditText fe = new FormEditText(bnd, fld);
            if (fe.ShowDialog() == DialogResult.OK)
            {
                fe.Validate();
                DB_Cmd.SaveProject();
            }
            else
            {
                fe.Validate();
                DB_Cmd.CancelProject();
            }
        }
        #endregion

        #endregion

        #region CellContentClick
        private void gridDocument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string p = gridDocument[4, e.RowIndex].Value.ToString();

                if (FileA.GetAtributesPath(p))
                    FileA.RunFile(p);
                else
                    FileA.RunFolder(p);
    
            }
        }
        private void grid_TenderDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());

            if (e.ColumnIndex == 3)
            {
                string p = grid_TenderDoc[2, e.RowIndex].Value.ToString(); // читаем путь

                if (FileA.GetAtributesPath(p))
                    FileA.RunFile(p);
                else
                    FileA.RunFolder(p);

            }
            if (e.ColumnIndex == 4)
            {
                string DateFld = dtp_TenderData.Value.ToShortDateString();
                string fld = Path.Combine("Тендер", DateFld);
                DeleteDoc(fld);
            }
        }

        #endregion

        #region DRAG

        private void _DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

      

        private void DragDropDocuments(object sender, DragEventArgs e, int typeDocument)
        {
            // сформированная по индивидуальному выбору строка сохранения файла или папки 
            //List<ListFile> listNew = new List<ListFile>();
            List<string> listNewFolder = new List<string>(); // список путей для копирования
            List<string> listFileDBPath = new List<string>();
            List<string> ListFiles = new List<string>(); // список полных путей передаваемых файлов(папок)
            List<string> aPathWorkDir = new List<string>(); // Головные папки - локальная и серверная + папка категории
            int SubFolderIndex = 0;

            // Здесь определить Active Tab, по сути головная папка для сохранения
            //0-ИД; 1-Письма; 2-Задания; 3-Тендер; 4-Договор; 5-График; 6- Объект; 7- Изыскания; 8- Штамп; 9- Разное; 10- Основные положения; 11- Входящие; 12- Исходящие
            // Здесь определить Таб по сути головная папка для сохранения
            if (tabControlMain.SelectedIndex == 0 && tabDocuments.SelectedIndex == 0)
                {
                    SubFolderIndex = 0; // Исходные данные
                   
                }
                if (tabControlMain.SelectedIndex == 0 && tabDocuments.SelectedIndex == 1)
                {
                    SubFolderIndex = 2; // Задания (объект)
                   
                }
                if (tabControlMain.SelectedIndex == 0 && tabDocuments.SelectedIndex == 2)
                {
                    SubFolderIndex = 1; // Письма на контроле (объект)
                    
                }



            aPathWorkDir.Add(Path.Combine(link_LocalFld.Text, Libr.NameFld[SubFolderIndex]));
            aPathWorkDir.Add(Path.Combine(link_ServetFld.Text, Libr.NameFld[SubFolderIndex]));
            //* Здесь определить Таб

            ListFiles = DDFile_Class.GetListFiles(e);

            Form_AddFiles fs = new Form_AddFiles(aPathWorkDir[0], aPathWorkDir[1]);
           if (fs.ShowDialog() == DialogResult.OK)
            {
                fs.GetPathFolders(listNewFolder, listFileDBPath); // получаем список путей для сохранения
            }
            // сохраняем файлы из списка            
            foreach (string el in listNewFolder)
            {
                FileA.CopyListFiles(ListFiles, el);
            }
            /// метод сохранения в базу данных записей из ListName по пути path
            /// входные ListFiles (список файлов), ListNewFolderL (список локальных путей), GroupFile(группа документов) 
            foreach (string el in listFileDBPath)
            {
                DB_Cmd.AddDocDragDrop(ListFiles, el, DB_Cmd.bndDocument, SubFolderIndex);
            }
            
            

            /// метод сохранения в базу данных записей из ListName по пути path

        }

        private void ShowListFile(List<ListFile> listNew)
        {
            Form_Message msf = new Form_Message();

            foreach (ListFile l in listNew)
            {
                msf.listView1.Items.Add("ДАННЫЕ ФАЙЛА");
                msf.listView1.Items.Add(l.Name);
                msf.listView1.Items.Add(l.OldPath);
                msf.listView1.Items.Add("НОВЫЙ ПУТЬ ДЛЯ СОХРАНЕНИЯ");
                foreach (string s1 in l.NewPathFile.pathLocal)
                {
                    msf.listView1.Items.Add(s1);
                }
                foreach (string s2 in l.NewPathFile.pathServer)
                {
                    msf.listView1.Items.Add(s2);
                }
                msf.listView1.Items.Add("");
            }

            msf.ShowDialog();
        }
        private void ShowListFile(List<string> listNew)
        {
            Form_Message msf = new Form_Message();



            foreach (string l in listNew)
            {
                msf.listView1.Items.Add(l);
   
            }

            msf.ShowDialog();
        }


        #region DRAG Documents
        private void gridDocument_DragEnter(object sender, DragEventArgs e)
        {
            _DragEnter(sender, e);
        }

        private void gridDocument_DragDrop(object sender, DragEventArgs e)
        {
            DragDropDocuments(sender, e, 0); // Исходные данные
        }
        #endregion 

        #region DRAG Tender Documents "Тендер"
        private void grid_TenderDoc_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void grid_TenderDoc_DragDrop(object sender, DragEventArgs e)
        {
            List<string> pathDoc = new List<string>();
            List<string> nameDoc = new List<string>();
            List<string> newPathDoc = new List<string>();
                        
            string DateFld = dtp_TenderData.Value.ToShortDateString();
            string newPathLocal = Path.Combine(link_LocalFld.Text, "Тендер", DateFld);
            string newPathServer = Path.Combine(link_ServetFld.Text, "Тендер", DateFld);

            foreach (string fobj in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                string n = Path.GetFileName(fobj);
                nameDoc.Add(n); // список имен
                pathDoc.Add(fobj); // список полных путей
            }

            /// тиражировать файлы в рабочий и сетевой каталог
            ///
            if (FileA.CopyListFiles(pathDoc, newPathLocal)) // && FileA.CopyListFiles(pathDoc, newPathServer)
            {/// Переписать список из локального каталога
             /// 
                foreach (string nn in nameDoc)
                {
                    newPathDoc.Add(Path.Combine(newPathLocal, nn));
                }
                /// Записать данные в базу
                /// 
                DB_Cmd.AddTenderDragDrop(newPathDoc, DB_Cmd.bndDocument, (int)((DataRowView)DB_Cmd.bndTender.Current).Row["ID_Teder"]);
            }
        }

        #endregion

        #endregion

        #region ARHIVE
        private void btn_BrouseArh_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb_PathArh.Text = ofd.SelectedPath;
                Settings.Default.PathArhive = tb_PathArh.Text;
                Settings.Default.Save();
            }

        }
        private void btn_ScanArh_Click(object sender, EventArgs e)
        {
            //GetTreeDir(tree_Arh, tb_PathArh.Text);
        }
        private void tree_Arh_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Заполнять Грид файлами
            //CreateFilesTree(TreeView tree, TreeNode node);
            tree_Arh.SelectedNode = e.Node;
            string pdir = tree_Arh.SelectedNode.FullPath.ToString();

            grid_FileArh.Rows.Clear();

            if (Directory.Exists(pdir))
            {
                try
                {
                    string[] fls = Directory.GetFiles(pdir, "*.*");

                    foreach (string fl in fls)
                    {
                        FileInfo info = new FileInfo(fl);
                        grid_FileArh.Rows.Add(info.Name, info.LastWriteTime.ToString("dd.MM.yyyy"));

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error of add file");
                }
            }
        }
        private void grid_FileArh_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string pathf = tree_Arh.SelectedNode.FullPath.ToString() + "\\"
                   + grid_FileArh[0, grid_FileArh.CurrentCell.RowIndex].Value.ToString();
                if (File.Exists(pathf))
                {
                    Process.Start(pathf);
                }
            }
            catch
            {
                MessageBox.Show("Error of run file");
            }
        }
        private void grid_FileArh_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //string fs = grid_FileArh[0, e.RowIndex].Value.ToString();

            //try
            //{
            //    if (fs.Contains(".pdf") || fs.Contains(".PDF"))
            //    {
            //        string fullpathfile = tree_Arh.SelectedNode.FullPath.ToString() + "\\" + fs;
            //        if (File.Exists(fullpathfile))
            //        {
            //            axAcroPDF1.LoadFile(fullpathfile);
            //            axAcroPDF1.src = fullpathfile;
            //            axAcroPDF1.setShowToolbar(false);
            //            //axAcroPDF1.setView("FitH");
            //            axAcroPDF1.setLayoutMode("SinglePage");
            //            axAcroPDF1.Show();
            //        }

            //    }
            //    else
            //    {
            //        axAcroPDF1.Hide();
            //    }

            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        #endregion

        private void grid_ProjectCode_SelectionChanged(object sender, EventArgs e)
        {
            SetViewBindNavigators();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_AddFiles fSel = new Form_AddFiles(link_LocalFld.Text, link_ServetFld.Text);
            fSel.ShowDialog();
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            SetViewTabControl();
        }

        private void gridDocument_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string p = gridDocument[2, e.RowIndex].Value.ToString(); // читаем путь

                if (FileA.GetAtributesPath(p))
                    FileA.RunFile(p);
                else
                    FileA.RunFolder(p);

            }
        }

        private void tbtn_Edit_ItemCPlan_Click(object sender, EventArgs e)
        {
            Form_CPlan feCPlan = new Form_CPlan();
            feCPlan.Show();
        }
    }

}
