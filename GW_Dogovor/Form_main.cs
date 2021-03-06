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

namespace GW_Dogovor
{
    public partial class Form_main : Form
    {
        //0-ИД; 1-Письма; 2-Задания; 3-Тендер; 4-Договор; 5-График; 6- Объект; 7- Изыскания; 8- Штамп; 9- Разное; 10- Основные положения; 11- Входящие; 12- Исходящие

        public static string[] NameFld = { "Исходные данные", "Письма", "Задания", "Тендер", "Договор", "График", "Объект", "Изыскания", "Штамп",  "Разное", "Основные положения", "Входящие", "Исходящие" };

        string tPathDB;

        bool R = false;

        #region BindingSource
        public static BindingSource bndProject = new BindingSource();
        BindingSource bndAreaStroy = new BindingSource();
        BindingSource bndDocument = new BindingSource();
        BindingSource bndTypeDoc = new BindingSource();
        BindingSource bndTender = new BindingSource();
        BindingSource bndStadia = new BindingSource();
        BindingSource bndGip = new BindingSource();
        BindingSource bndDogovor = new BindingSource();
        BindingSource bndCalendarPlan = new BindingSource();
        BindingSource bndDopDogovor = new BindingSource();
        BindingSource bndObject = new BindingSource();
        BindingSource bndAct = new BindingSource();
        BindingSource bndSostavObj = new BindingSource();
        BindingSource bndZadania = new BindingSource();
      
        #endregion
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

            //Project
            bndProject.DataSource = DB_Cmd.dsDB;
            bndProject.DataMember = "Project";
            bndAreaStroy.DataSource = DB_Cmd.dsDB;
            bndAreaStroy.DataMember = "Customers";
            //Ish Documents
            bndDocument.DataSource = bndProject; //привязка по связи к Проекту
            bndDocument.DataMember = "ProjectDocuments";
            bndTypeDoc.DataSource = DB_Cmd.dsDB;
            bndTypeDoc.DataMember = "Documets_type";
            //Tender
            bndTender.DataSource = bndProject;
            bndTender.DataMember = "ProjectTender";
            bndStadia.DataSource = DB_Cmd.dsDB;
            bndStadia.DataMember = "Stady_project";
            bndGip.DataSource = DB_Cmd.dsDB;
            bndGip.DataMember = "Users GIP";
            //Dogovor
            bndDogovor.DataSource = bndProject;
            bndDogovor.DataMember = "ProjectDogovor";
            bndCalendarPlan.DataSource = bndDogovor;
            bndCalendarPlan.DataMember = "DogovorCalendarPlan";
            bndAct.DataSource = bndCalendarPlan;
            bndAct.DataMember = "CalendarPlanAct";

            //DopDogovor
            bndDopDogovor.DataSource = bndDogovor;
            bndDopDogovor.DataMember = "DogovorDopSoglashenia";

            //Object
            bndObject.DataSource = bndDogovor;
            bndObject.DataMember = "DogovorOBJECTS";
            bndSostavObj.DataSource = bndObject;
            bndSostavObj.DataMember = "OBJECTSSostavDoc";
            bndZadania.DataSource = bndObject;
            bndZadania.DataMember = "OBJECTSZadania";
 
           
        }

        #region ViewForms 
        // Установка связей контролов с базой
        private void SetViewDataProject()
        {
            tbNameProject.DataBindings.Add("Text", bndProject, "Name");
            tb_Code_object.DataBindings.Add("Text", bndProject, "Code_object");
            tb_pName.DataBindings.Add("Text", bndProject, "Name");
            tb_pNotes.DataBindings.Add("Text", bndProject, "Notes");
            tb_AreaStroy.DataBindings.Add("Text", bndProject, "AreaStroy"); // Parent([CustomersProject]).[NameCust]
            tb_Status.DataBindings.Add("Text", bndProject, "Status");
            link_LocalFld.DataBindings.Add("Text", bndProject, "Path_folder");
            link_ServetFld.DataBindings.Add("Text", bndProject, "Path_server");

            grid_ProjectCode.AutoGenerateColumns = false;
            grid_ProjectCode.DataSource = bndProject;
            grid_ProjectCode.Columns["Code_object"].DataPropertyName = "Code_object";
        }
        private void SetViewDataDocument()
        {
            // Parent([Documets_typeDocuments]).[Name_doc]
            gridDocument.AutoGenerateColumns = false;
            gridDocument.DataSource = bndDocument;
            gridDocument.Columns["NameDoc"].DataPropertyName = "NameDoc";
            gridDocument.Columns["Nambe_Doc"].DataPropertyName = "Nambe_Doc";
            gridDocument.Columns["DataDoc"].DataPropertyName = "DataDoc";
            gridDocument.Columns["Status"].DataPropertyName = "Status";
            gridDocument.Columns["PathDoc"].DataPropertyName = "PathDoc";

            bndNvg_IshDoc.BindingSource = bndDocument;
         
        }
        private void SetViewTender()
        {
            bndNavigatorTender.BindingSource = bndTender;
            
            tb_TndCustomer.DataBindings.Add("Text", bndTender, "Customer");
            tb_TndName.DataBindings.Add("Text", bndTender, "Name_Tender");
            tb_TndStadia.DataBindings.Add("Text", bndTender, "Stadia");
            dtp_TenderData.DataBindings.Add("Text", bndTender, "Data_End");
            tb_TndStatus.DataBindings.Add("Text", bndTender, "Status");
            tb_TndGIP.DataBindings.Add("Text", bndTender, "NameGip");
            tb_TndSostav.DataBindings.Add("Text", bndTender, "Sostav");
            tb_TndComents.DataBindings.Add("Text", bndTender, "Comments");

            grid_TenderDoc.AutoGenerateColumns = false;
            grid_TenderDoc.DataSource = bndDocument;
            grid_TenderDoc.Columns["NameTDoc"].DataPropertyName = "NameDoc";
            grid_TenderDoc.Columns["StatudTDoc"].DataPropertyName = "Status";
            grid_TenderDoc.Columns["PathTDoc"].DataPropertyName = "PathDoc";
           // Фильтр по ["Tender_id"] != null

        }
        private void SetViewDogovor()
        {
            bndNavigatorDogovor.BindingSource = bndDogovor;
            bndNavigator_KP_Dog.BindingSource = bndCalendarPlan;
            //bndCalendarPlan.RemoveFilter();


            tb_NumDog.DataBindings.Add("Text", bndDogovor, "Nambe_Dog");
            dtp_DateDog.DataBindings.Add("Text", bndDogovor, "DataOt");
            tb_StatusDog.DataBindings.Add("Text", bndDogovor, "Status");
            dtp_ToDateDog.DataBindings.Add("Text", bndDogovor, "Data_Konec");
            tb_NameDog.DataBindings.Add("Text", bndDogovor, "Name_Dog");
            // tb_AllSummDog
            // tb_spentSummDog
            // tb_remainedSummDog
            tb_CommentDog.DataBindings.Add("Text", bndDogovor, "Comments");
            
            // grid Dogovor
            grid_Dogovor.AutoGenerateColumns = false;
            grid_Dogovor.DataSource = bndDogovor;
            grid_Dogovor.Columns["NumDogovor"].DataPropertyName = "Nambe_Dog";

            // grid Documents
            grid_DogovorDoc.AutoGenerateColumns = false;
            grid_DogovorDoc.DataSource = bndDocument;
            grid_DogovorDoc.Columns["dogNameDoc"].DataPropertyName = "NameDoc";
            //grid_DogovorDoc.Columns["dRunDoc"].DataPropertyName = "PathDoc";

            // grid CPlan
            grid_CPlan.AutoGenerateColumns = false;
            grid_CPlan.DataSource = bndCalendarPlan;
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
            tb_NumDD.DataBindings.Add("Text", bndDopDogovor, "Nambe_DS");
            tb_DateDD.DataBindings.Add("Text", bndDopDogovor, "DataPodp");
            tb_StatusDD.DataBindings.Add("Text", bndDopDogovor, "Status");
            tb_ToDateDD.DataBindings.Add("Text", bndDopDogovor, "Data_Konec");
            tb_NotesDD.DataBindings.Add("Text", bndDopDogovor, "Comments");

            grid_DD.AutoGenerateColumns = false;
            grid_DD.DataSource = bndDopDogovor;
            grid_DD.Columns["NumDD"].DataPropertyName = "Nambe_DS";

            bndNavigatorDDog.BindingSource = bndDopDogovor;
            bndNavigator_KP_Dop.BindingSource = bndCalendarPlan;
            //bndCalendarPlan.Filter = "";
            
        }
        private void SetViewObject()
        {
            tb_NameUObject.DataBindings.Add("Text", bndObject, "Name_Ustanovka");
            tb_NameObject.DataBindings.Add("Text", bndObject, "Name_object");
            tb_CodeObject.DataBindings.Add("Text", bndObject, "Nambe_Object");
            tb_TitleObject.DataBindings.Add("Text", bndObject, "Titul");
            tb_BlockObject.DataBindings.Add("Text", bndObject, "Block");
          
            //GIP
            tb_GIPObject.DataBindings.Add("Text", bndObject, "NameGIP");

            grid_Object.AutoGenerateColumns = false;
            grid_Object.DataSource = bndObject;
            grid_Object.Columns["CodeObj"].DataPropertyName = "CodeOBJ";

            bndNavigatorObject.BindingSource = bndObject;
            bndNavigator_Graph_Mark.BindingSource = bndSostavObj;
            bndNavigator_Graph_Z.BindingSource = bndZadania;
            bndNavigator_Z.BindingSource = bndZadania;

        }
        //
        public static void GetTreeDir(TreeView tree, string root)
        {
            tree.Nodes.Clear();
            TreeFolders tf = new TreeFolders();
            tf.startPath = root;
            tf.CreateTree(tree);
            tree.ExpandAll();
        }
        private void SetViewTabControl()
        {
            //0-ИД; 1-Письма; 2-Задания; 3-Тендер; 4-Договор; 5-График; 6- Объект; 7- Изыскания; 8- Штамп; 9- Разное; 10- Основные положения; 11- Входящие; 12- Исходящие
            switch (tabControlMain.SelectedIndex)
            {
                case 0: // Документы
                    SelectedTypeDocuments();
                    break;
                case 1: // Тендер
                    bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Not Is Null) AND (Object_id Is Null) AND (Event_id Is Null) AND (Act_id Is Null)";
                    break;
                case 2: // Договор * добавить поле id_Dogovor
                    bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Not Is Null) AND (Object_id Is Null) AND (Event_id Is Null) AND (Act_id Is Null)";
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5: // Архив
                    tb_PathArh.Text = Settings.Default.PathArhive;
                    if (Directory.Exists(tb_PathArh.Text))
                                GetTreeDir(tree_Arh, tb_PathArh.Text);
                    break;
                case 6:

                    break;
                default:
                    bndDocument.RemoveFilter();
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
                       
                        bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Is Null) AND (Object_id Is Null) " +
                            "AND (Event_id Is Null) AND (Act_id Is Null) AND (Control = false)";
                        break;
                    case 1: /// Письма на контроле
                       
                        bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Is Null) AND (Object_id Is Null) " +
                            "AND (Event_id Is Null) AND (Act_id Is Null) AND (Control = true)";
                        break;
                    case 2: /// Задания
                       
                        bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Not Is Null) AND (Object_id Not Is Null) " +
                           "AND (Event_id Is Null) AND (Act_id Is Null) AND (Control = false)";
                        break;
                    default: // Исходные данные
                       
                        bndDocument.Filter = "(Project_id Not Is Null) AND (Tender_id Is Null) AND (Object_id Is Null) " +
                           "AND (Event_id Is Null) AND (Act_id Is Null) AND (Control = false)";
                        break;
                }
            }

        } // Фильтры для Документов вкладка Документы
        private void SetViewBindNavigators()
        {
            if (bndProject.Count != 0)
            { 
              bndNvg_IshDoc.Enabled = true;
                bndNavigatorTender.Enabled = true;
                if (bndTender.Count != 0)
                {
                    bndNavigatorDogovor.Enabled = true;
                    if (bndDogovor.Count != 0)
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
                AddDoc();
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
                AddProject();
                EditProject();
            };

            tbtn_DeleteProject.Click += (s, a) =>
            {
                DeleteProject();
            };

            tbtn_TndEdit.Click += (s, a) =>
            {
                EditTender();
            };

            tbtn_TndAdd.Click += (s, a) =>
            {
                AddTender();
            };

            tbtn_TndDelete.Click += (s, a) =>
            {
                DeleteTender();
            };

            tbtn_AddFolders.Click += (s, a) =>
            {
                Form_Folders ff = new Form_Folders(link_LocalFld.Text, link_ServetFld.Text, false);
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
                dbEditText(bndTender, "Comments");
            };

            tb_pNotes.DoubleClick += (s, a) =>
            {
                dbEditText(bndProject, "Notes");
            };

            tb_CommentDog.DoubleClick += (s, a) =>
            {
                dbEditText(bndDogovor, "Comments");
            };

            tb_NotesDD.DoubleClick += (s, a) =>
            {
                dbEditText(bndDopDogovor, "Comments");
            };

            tbtn_EditDog.Click += (s, a) =>
            {
                EditDogovor();
            };

            tbtn_AddDog.Click += (s, a) =>
            {
                AddDogovor();
            };

            tbtn_DeleteDog.Click += (s, a) =>
            {
                DeleteDogovor();
            };

            tbtn_EditDDog.Click += (s, a) =>
            {
                EditDopDogovor();
            };

            tbtn_AddDDog.Click += (s, a) =>
            {
                AddDopDogovor();
            };

            tbtn_DeleteDDog.Click += (s, a) =>
            {
                DeleteDopDogovor();
            };

            tbtn_EditObj.Click += (s, a) =>
            {
                EditObject();
            };

            tbtn_AddObj.Click += (s, a) =>
            {
                AddObject();
            };

            tbtn_DeleteObj.Click += (s, a) =>
            {
                DeleteObject();
            };

            tbtn_Edit_ItemCPlan.Click += (s, a) =>
            {
                Add_CPlan();
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

        #region Add-Delete-Edit DB
        #region Project
        public static void AddProject()
        {
            DB_Cmd.AddProject(bndProject);
        }

        public static void DeleteProject()
        {
            DB_Cmd.DeleteProject(bndProject);
        }

        private void EditProject()
        {
            Form_editProject fed = new Form_editProject(bndProject, bndAreaStroy);
            if (fed.ShowDialog() == DialogResult.OK)
            {
                fed.Validate();
                DB_Cmd.SaveProject(bndProject);
            }
            else
            {
                fed.Validate();
                DB_Cmd.CancelProject(bndProject);
            }
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

        #region Dogovor
        private void EditDogovor()
        {
            Form_editDogovor fе = new Form_editDogovor(bndDogovor, bndAreaStroy, bndStadia, bndGip);

            if (fе.ShowDialog() == DialogResult.OK)
            {
                fе.Validate();
                DB_Cmd.SaveDogovor(bndDogovor);
            }
            else
            {
                fе.Validate();
                DB_Cmd.CancelDogovor(bndDogovor);
            }
        }
        private void AddDogovor()
        {
            if (bndTender.Count != 0)
            {
                DB_Cmd.AddDogovor(bndDogovor);

                ((DataRowView)bndDogovor.Current).Row["IDCust"] = ((DataRowView)bndTender.Current).Row["IDCust"];
                ((DataRowView)bndDogovor.Current).Row["Name_Dog"] = ((DataRowView)bndTender.Current).Row["Name_Tender"];
                ((DataRowView)bndDogovor.Current).Row["IDGip"] = ((DataRowView)bndTender.Current).Row["GIP"];
                ((DataRowView)bndDogovor.Current).Row["id_Tender"] = ((DataRowView)bndTender.Current).Row["ID_Teder"];
                ((DataRowView)bndDogovor.Current).Row["IDStady"] = ((DataRowView)bndTender.Current).Row["IDStadia"];
                ((DataRowView)bndDogovor.Current).Row["Sostav"] = ((DataRowView)bndTender.Current).Row["Sostav"];
                EditDogovor();
            }
            else
            {
                MessageBox.Show("Для создания договора требуется активная запись 'Тендер'", "Внимание!", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
        }
        private void DeleteDogovor()
        {
            DB_Cmd.DeleteDogovor(bndDogovor);
            DB_Cmd.SaveDogovor(bndDogovor);
        }
        #endregion

        #region DopDogovor
        private void EditDopDogovor()
        {
            Form_editDDogovor fе = new Form_editDDogovor(bndDopDogovor);

            if (fе.ShowDialog() == DialogResult.OK)
            {
                fе.Validate();
                DB_Cmd.SaveDopSoglashenia(bndDopDogovor);
            }
            else
            {
                fе.Validate();
                DB_Cmd.CancelDopSoglashenia(bndDopDogovor);
            }
        }
        private void AddDopDogovor()
        {
            if (bndDogovor.Count != 0)
            {
                DB_Cmd.AddDopSoglashenia(bndDopDogovor);

                ((DataRowView)bndDopDogovor.Current).Row["DogID"] = ((DataRowView)bndDogovor.Current).Row["DogID"];

                EditDopDogovor();
            }
            else
            {
                MessageBox.Show("Для создания допсоглашения требуется активная запись 'Договор'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteDopDogovor()
        {
            DB_Cmd.DeleteDopSoglashenia(bndDopDogovor);
            DB_Cmd.SaveDopSoglashenia(bndDopDogovor);
        }
        #endregion

        #region Document
        private void EditDoc()
        {
            Form_editDocument fed = new Form_editDocument(bndDocument, bndTypeDoc);
            if (fed.ShowDialog() == DialogResult.OK)
            {
                fed.Validate();
                DB_Cmd.SaveDoc(bndDocument);
            }
            else
            {
                fed.Validate();
                DB_Cmd.CancelDoc(bndDocument);
            }
        }
        private void AddDoc()
        {
            DB_Cmd.AddDoc(bndDocument);
            EditDoc();
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
            

         //   //удаляем из базы
         //   DB_Cmd.DeleteDoc(bndDocument);
         //   DB_Cmd.SaveDoc(bndDocument);
           
        }
        private void deleteDocument(object sender, EventArgs e)
        {
            //0-ИД; 1-Письма; 2-Задания; 3-Тендер; 4-Договор; 5-График; 6- Объект; 7- Изыскания; 8- Штамп; 9- Разное; 10- Основные положения; 11- Входящие; 12- Исходящие

            switch (tabDocuments.SelectedIndex)
            {
                case 0:
                    DeleteDoc(NameFld[0]);
                    break;
                case 1:
                    DeleteDoc(NameFld[1]);
                    break;
                case 2:

                    break;

                default:
                    DeleteDoc(NameFld[0]);
                    break;
            }
        }
        #endregion

        #region Tender
        private void EditTender()
        {
            Form_editTender fе = new Form_editTender(bndTender, bndAreaStroy, bndStadia, bndGip);

            if (fе.ShowDialog() == DialogResult.OK)
            {
                fе.Validate();
                DB_Cmd.SaveTender(bndTender);
            }
            else
            {
                fе.Validate();
                DB_Cmd.CancelTender(bndTender);
            }
        }

        private void AddTender()
        {
            DB_Cmd.AddTender(bndTender);

            ((DataRowView)bndTender.Current).Row["IDCust"] = ((DataRowView)bndProject.Current).Row["AreaStroy_ID"];
            ((DataRowView)bndTender.Current).Row["Name_Tender"] = ((DataRowView)bndProject.Current).Row["Name"];

            EditTender();
        }

        private void DeleteTender()
        {
            DB_Cmd.DeleteTender(bndTender);
            DB_Cmd.SaveTender(bndTender);
        }

        #endregion

        #region Object
        private void EditObject()
        {
            Form_editObject fе = new Form_editObject(bndObject, bndGip, bndStadia);

            if (fе.ShowDialog() == DialogResult.OK)
            {
                fе.Validate();
                DB_Cmd.SaveOBJECTS(bndObject);
            }
            else
            {
                fе.Validate();
                DB_Cmd.CancelOBJECTS(bndObject);
            }
        }
        private void AddObject()
        {
            if (bndDogovor.Count != 0)
            {
                DB_Cmd.AddOBJECTS(bndObject);

                ((DataRowView)bndObject.Current).Row["IDCust"] = ((DataRowView)bndDogovor.Current).Row["IDCust"];
                ((DataRowView)bndObject.Current).Row["GIP"] = ((DataRowView)bndDogovor.Current).Row["IDGip"];
                ((DataRowView)bndObject.Current).Row["Name_Ustanovka"] = ((DataRowView)bndDogovor.Current).Row["Name_Dog"];


                EditObject();
            }
            else
            {
                MessageBox.Show("Для создания объекта требуется активная запись 'Договор'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteObject()
        {
            DB_Cmd.DeleteOBJECTS(bndObject);
            DB_Cmd.SaveOBJECTS(bndObject);
        }

        #endregion

        #region Calendar Plan
        private void Edit_CPlan()
        {
            //Form_editObject fе = new Form_editObject(bndObject, bndGip, bndStadia);
            Form_editCalendarPlan feCPlan = new Form_editCalendarPlan(bndCalendarPlan);
            feCPlan.Show();
            //if (feCPlan.ShowDialog() == DialogResult.OK)
            //{
            //feCPlan.Validate();
            //DB_Cmd.SaveCalendarPlan(bndCalendarPlan);
            //}
            //else
            //{
            //    feCPlan.Validate();
            //    DB_Cmd.CancelOBJECTS(bndObject);
            //}
        }
        private void Add_CPlan()
        {
            if (bndDogovor.Count != 0)
            {
                //DB_Cmd.AddCalendarPlan(bndCalendarPlan);

                Form_editCalendarPlan feCPlan = new Form_editCalendarPlan(bndCalendarPlan);
                feCPlan.Show();

            //   ((DataRowView)bndCalendarPlan.Current).Row["IDCust"] = ((DataRowView)bndDogovor.Current).Row["IDCust"];
            //    ((DataRowView)bndObject.Current).Row["GIP"] = ((DataRowView)bndDogovor.Current).Row["IDGip"];
            //    ((DataRowView)bndObject.Current).Row["Name_Ustanovka"] = ((DataRowView)bndDogovor.Current).Row["Name_Dog"];


                //Edit_CPlan();
            }
            else
            {
                MessageBox.Show("Для создания объекта требуется активная запись 'Договор'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Delete_CPlan()
        {
            DB_Cmd.DeleteCalendarPlan(bndCalendarPlan);
            DB_Cmd.SaveCalendarPlan(bndCalendarPlan);
        }

        #endregion

        #region EditText
        private void dbEditText(BindingSource bnd, String fld)
        {
            FormEditText fe = new FormEditText(bnd, fld);
            if (fe.ShowDialog() == DialogResult.OK)
            {
                fe.Validate();
                DB_Cmd.SaveProject(bnd);
            }
            else
            {
                fe.Validate();
                DB_Cmd.CancelProject(bnd);
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



            aPathWorkDir.Add(Path.Combine(link_LocalFld.Text, NameFld[SubFolderIndex]));
            aPathWorkDir.Add(Path.Combine(link_ServetFld.Text, NameFld[SubFolderIndex]));
            //* Здесь определить Таб

            ListFiles = DDFile_Class.GetListFiles(e);

           Form_SelectSave fs = new Form_SelectSave(aPathWorkDir[0], aPathWorkDir[1]);
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
                DB_Cmd.AddDocDragDrop(ListFiles, el, bndDocument, SubFolderIndex);
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
                DB_Cmd.AddTenderDragDrop(newPathDoc, bndDocument, (int)((DataRowView)bndTender.Current).Row["ID_Teder"]);
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
            GetTreeDir(tree_Arh, tb_PathArh.Text);
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
            Form_SelectSave fSel = new Form_SelectSave(link_LocalFld.Text, link_ServetFld.Text);
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
    }

}
