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
using feature_сlass;
using System.ComponentModel;
using PRD;
using Zadania;

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

           

        }

        #region ViewForms 
        #region Установка связей контролов с базой
        private void SetViewDataProject()
        {
            tbNameProject.DataBindings.Add("Text", DB_Cmd.bndProject, "Name");
            tb_num_dog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Nambe_Dog");
            
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
            //this.grid_ProjectCode.Sort(this.grid_ProjectCode.Columns["Code_object"], ListSortDirection.Ascending);
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
            //this.gridDocument.Sort(this.gridDocument.Columns["DataDoc"], ListSortDirection.Ascending);

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
            grid_CPlan.Columns["day"].DataPropertyName = "Days";
            grid_CPlan.Columns["Nachalo_Data"].DataPropertyName = "Nachalo_Data";
            grid_CPlan.Columns["Konec_Data"].DataPropertyName = "Konec_Data";
            grid_CPlan.Columns["Summ"].DataPropertyName = "Summ";
            grid_CPlan.Columns["Valute"].DataPropertyName = "V";
            grid_CPlan.Columns["StatusCPlan"].DataPropertyName = "Status";
            grid_CPlan.Columns["id_DDog"].DataPropertyName = "NumDD";
            grid_CPlan.Columns["Num_sort"].DataPropertyName = "Num_sort";

            grid_CPlan.Columns["Name_Etap"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grid_CPlan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            grid_CPlan.Columns["Name_Etap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //this.grid_CPlan.Sort(this.grid_CPlan.Columns["Num_sort"], ListSortDirection.Ascending);

            //grid_CPlan.EditingPanel.BorderStyle = BorderStyle.Fixed3D;


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
            //this.grid_DD.Sort(this.grid_DD.Columns["NumDD"], ListSortDirection.Ascending);

            grid_CPlanDD.AutoGenerateColumns = false;
            grid_CPlanDD.DataSource = DB_Cmd.bndCalendarPlanDD;
            grid_CPlanDD.Columns["num_ds"].DataPropertyName = "Num_Etap";
            grid_CPlanDD.Columns["name_ds"].DataPropertyName = "Name_Etap";
            grid_CPlanDD.Columns["day_ds"].DataPropertyName = "Days";
            grid_CPlanDD.Columns["nachalo_ds"].DataPropertyName = "Nachalo_Data";
            grid_CPlanDD.Columns["konec_ds"].DataPropertyName = "Konec_Data";
            grid_CPlanDD.Columns["summ_ds"].DataPropertyName = "Summ";
            grid_CPlanDD.Columns["valute_ds"].DataPropertyName = "V";
            grid_CPlanDD.Columns["status_ds"].DataPropertyName = "Status";
            grid_CPlanDD.Columns["num_sort_ds"].DataPropertyName = "Num_sort";

            grid_CPlanDD.Columns["name_ds"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grid_CPlanDD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            grid_CPlanDD.Columns["name_ds"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            bndNavigatorDDog.BindingSource = DB_Cmd.bndDopDogovor;
            bndNavigator_KP_Dop.BindingSource = DB_Cmd.bndCalendarPlanDD;
            //bndCalendarPlan.Filter = "";
            
        }
        private void SetViewObject()
        {
            tb_NameUObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Name_Ustanovka");
            tb_NameObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Name_object");
            tb_CodeObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Nambe_Object");
            tb_TitleObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Titul");
            //tb_BlockObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Block");
            tb_Obj_std.DataBindings.Add("Text", DB_Cmd.bndObject, "Stady");

            //GIP
            tb_ObjComment.DataBindings.Add("Text", DB_Cmd.bndObject, "Comments");
            //Object
            grid_Object.AutoGenerateColumns = false;
            grid_Object.DataSource = DB_Cmd.bndObject;
            grid_Object.Columns["CodeObj"].DataPropertyName = "CodeOBJ";
            //this.grid_Object.Sort(this.grid_Object.Columns["CodeObj"], ListSortDirection.Ascending);

            //Mark
            grid_GrafMark.AutoGenerateColumns = false;
            grid_GrafMark.DataSource = DB_Cmd.bndSostavObj;
            grid_GrafMark.Columns["blok_mark"].DataPropertyName = "Block";
            grid_GrafMark.Columns["Mark_name"].DataPropertyName = "Mark";
            grid_GrafMark.Columns["Mark_date_plan"].DataPropertyName = "Data_plan";
            grid_GrafMark.Columns["Mark_GIP"].DataPropertyName = "GIP_viz";
            grid_GrafMark.Columns["Mark_date_GIP"].DataPropertyName = "Data_GIP_viz";
            grid_GrafMark.Columns["Mark_Arhiv"].DataPropertyName = "Arhiv";
            grid_GrafMark.Columns["Mark_data_fakt"].DataPropertyName = "Data_fakt";
            grid_GrafMark.Columns["Mark_notes"].DataPropertyName = "Notes";

            //Graf_Zadania
            grid_GrafZ.AutoGenerateColumns = false;
            grid_GrafZ.DataSource = DB_Cmd.bndZadania;
            grid_GrafZ.Columns["zadania_name"].DataPropertyName = "Coments";
            grid_GrafZ.Columns["zadania_otdel_out"].DataPropertyName = "Otdel_id_out"; 
            grid_GrafZ.Columns["zadania_otdel_in"].DataPropertyName = "Otdel_id_in";
            grid_GrafZ.Columns["zadania_plan"].DataPropertyName = "Date_graf";
            grid_GrafZ.Columns["zadania_fakt"].DataPropertyName = "Date_fact";
            



            bndNavigatorObject.BindingSource = DB_Cmd.bndObject;
            bndNavigator_Graph_Mark.BindingSource = DB_Cmd.bndSostavObj;
            bndNavigator_Graph_Z.BindingSource = DB_Cmd.bndZadania;
            //bndNavigator_Zadania_file.BindingSource = DB_Cmd.bndZadania;

        }
        #endregion Установка связей контролов с базой

        #region FilterGrid
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
        #endregion FilterGrid

        #region View
        private void bndNavigator_Graph_Mark_Paint(object sender, PaintEventArgs e)
        {
            if (grid_GrafMark.Rows.Count == 0)
            {
                tbtn_EditMark.Enabled = false;
                tbtn_DeleteMark.Enabled = false;
            }
            else
            {
                tbtn_EditMark.Enabled = true;
                tbtn_DeleteMark.Enabled = true;
            }
        }
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
                        if (DB_Cmd.bndDopDogovor.Count != 0)
                        {
                            bndNavigator_KP_Dog.Enabled = true;
                            bndNavigator_KP_Dop.Enabled = true;
                            bndNavigatorObject.Enabled = true;
                            if (DB_Cmd.bndObject.Count != 0)
                            {
                                bndNavigator_Graph_Mark.Enabled = true;
                                bndNavigator_Graph_Z.Enabled = true;
                                bndNavigator_Zadania_file.Enabled = true;
                            }
                            else
                            {
                                bndNavigator_Graph_Mark.Enabled = false;
                                bndNavigator_Graph_Z.Enabled = false;
                                bndNavigator_Zadania_file.Enabled = false;
                            }
                        }
                        else
                        {
                            bndNavigator_KP_Dog.Enabled = false;
                            bndNavigator_KP_Dop.Enabled = false;
                            bndNavigatorObject.Enabled = false;
                        }
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
        private void ProjectPanelsVisable(object sender, EventArgs e)
        {
            Settings.Default.PanelsProjectView = !Settings.Default.PanelsProjectView;
            Settings.Default.Save();
            SetViewForm();
        } // Установка видимости панели Проект
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
            DB_Cmd.tableManager.UpdateAll(DB_Cmd.dsDB);
        }
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
        #endregion View

        private void Form_main_Load(object sender, EventArgs e)
        {
            if (!R) Close(); 
            GetFormView();
            Clk();
            lbl_BasePath.Text = tPathDB;
        }
        #endregion ViewForms

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
        #endregion DoubleClik_EditProject

        #endregion Project

        #region Tender
        private void EditTender()
        {
            Form_Tender fe = new Form_Tender();
            fe.ShowDialog();
            
        }

        #endregion Tender

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
            Form_Object fе = new Form_Object();

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
                DB_Cmd.Save_BndDB(bnd);
            }
            else
            {
                fe.Validate();
                DB_Cmd.Cancel_BndDB(bnd);
            }
        }
        #endregion EditText

        #region Zadania
        private void EditZadania()
        {
            Form_Zadania_Plan fеd = new Form_Zadania_Plan();
            fеd.ShowDialog();
        }

        #endregion Zadania

        #region Mark
        private void EditSostavObj()
        {
            Form_PRD fеd = new Form_PRD();
            fеd.ShowDialog();
        }
        #endregion Mark

        #endregion Edit DB

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

        #endregion CellContentClick

        #region DRAG

        private void _DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void _DragDrop(object sender, DragEventArgs e, int Narp, string Name)
        {
            try
            {
                string pLocal = Path.Combine(link_LocalFld.Text, Name);
                string pServer = Path.Combine(link_ServetFld.Text, Name);
                if (Narp == 0 || Narp == 2)
                    if (!Directory.Exists(link_LocalFld.Text))
                         throw new Exception("Локальная папка не указана. Укажите локальную папку в свойствах проекта");
            
                if (Narp == 1 || Narp == 2)
                   if (!Directory.Exists(link_ServetFld.Text))
                     throw new Exception("Серверная папка не указана. Укажите серверную папку в свойствах проекта");
            
                //DragDropDocuments(sender, e, 0); // Исходные данные
          
                Form_AddFiles frm_Copyfiles = new Form_AddFiles(pLocal, pServer);
                frm_Copyfiles.SetNapr(Narp);
                foreach (string f in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    frm_Copyfiles.ListFiles.Add(f); // передаем список файлов в модуль копирования
                }
                frm_Copyfiles.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //private void DragDropDocuments(object sender, DragEventArgs e, int typeDocument)
        //{
        //    // сформированная по индивидуальному выбору строка сохранения файла или папки 
        //    //List<ListFile> listNew = new List<ListFile>();
        //    List<string> listNewFolder = new List<string>(); // список путей для копирования
        //    List<string> listFileDBPath = new List<string>();
        //    List<string> ListFiles = new List<string>(); // список полных путей передаваемых файлов(папок)
        //    List<string> aPathWorkDir = new List<string>(); // Головные папки - локальная и серверная + папка категории
        //    int SubFolderIndex = 0;

        //    // Здесь определить Active Tab, по сути головная папка для сохранения
        //    //0-ИД; 1-Письма; 2-Задания; 3-Тендер; 4-Договор; 5-График; 6- Объект; 7- Изыскания; 8- Штамп; 9- Разное; 10- Основные положения; 11- Входящие; 12- Исходящие
        //    // Здесь определить Таб по сути головная папка для сохранения
        //    if (tabControlMain.SelectedIndex == 0 && tabDocuments.SelectedIndex == 0)
        //        {
        //            SubFolderIndex = 0; // Исходные данные
                   
        //        }
        //        if (tabControlMain.SelectedIndex == 0 && tabDocuments.SelectedIndex == 1)
        //        {
        //            SubFolderIndex = 2; // Задания (объект)
                   
        //        }
        //        if (tabControlMain.SelectedIndex == 0 && tabDocuments.SelectedIndex == 2)
        //        {
        //            SubFolderIndex = 1; // Письма на контроле (объект)
                    
        //        }



        //    aPathWorkDir.Add(Path.Combine(link_LocalFld.Text, Libr.NameFld[SubFolderIndex]));
        //    aPathWorkDir.Add(Path.Combine(link_ServetFld.Text, Libr.NameFld[SubFolderIndex]));
        //    //* Здесь определить Таб

        //    ListFiles = DDFile_Class.GetListFiles(e);

        //    Form_AddFiles fs = new Form_AddFiles(aPathWorkDir[0], aPathWorkDir[1]);
        //   if (fs.ShowDialog() == DialogResult.OK)
        //    {
        //        fs.GetPathFolders(listNewFolder, listFileDBPath); // получаем список путей для сохранения
        //    }
        //    // сохраняем файлы из списка            
        //    foreach (string el in listNewFolder)
        //    {
        //        FileA.CopyListFiles(ListFiles, el);
        //    }
        //    /// метод сохранения в базу данных записей из ListName по пути path
        //    /// входные ListFiles (список файлов), ListNewFolderL (список локальных путей), GroupFile(группа документов) 
        //    foreach (string el in listFileDBPath)
        //    {
        //        DB_Cmd.AddDocDragDrop(ListFiles, el, DB_Cmd.bndDocument, SubFolderIndex);
        //    }
            
            

        //    /// метод сохранения в базу данных записей из ListName по пути path

        //}
        //private void ShowListFile(List<ListFile> listNew)
        //{
        //    Form_Message msf = new Form_Message();

        //    foreach (ListFile l in listNew)
        //    {
        //        msf.listView1.Items.Add("ДАННЫЕ ФАЙЛА");
        //        msf.listView1.Items.Add(l.Name);
        //        msf.listView1.Items.Add(l.OldPath);
        //        msf.listView1.Items.Add("НОВЫЙ ПУТЬ ДЛЯ СОХРАНЕНИЯ");
        //        foreach (string s1 in l.NewPathFile.pathLocal)
        //        {
        //            msf.listView1.Items.Add(s1);
        //        }
        //        foreach (string s2 in l.NewPathFile.pathServer)
        //        {
        //            msf.listView1.Items.Add(s2);
        //        }
        //        msf.listView1.Items.Add("");
        //    }

        //    msf.ShowDialog();
        //}
        //private void ShowListFile(List<string> listNew)
        //{
        //    Form_Message msf = new Form_Message();



        //    foreach (string l in listNew)
        //    {
        //        msf.listView1.Items.Add(l);
   
        //    }

        //    msf.ShowDialog();
        //}
   

        #region DRAG Documents
        private void gridDocument_DragDrop(object sender, DragEventArgs e)
        {
            _DragDrop(sender, e, 2, "Основные положения");
        }
        private void grid_MailControl_DragDrop(object sender, DragEventArgs e)
        {
            _DragDrop(sender, e, 0, "Письма");
        }
        private void grid_Zadania_DragDrop(object sender, DragEventArgs e)
        {
            _DragDrop(sender, e, 1, "Задания");
        }
        #endregion DRAG Documents

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

        #endregion DRAG Tender Documents "Тендер"

        #endregion DRAG

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

        #region BindingManager_button
        #region Tender
        private void tbtn_TndEdit_Click(object sender, EventArgs e)
        {
            EditTender();
        }

        private void tbtn_TndDelete_Click(object sender, EventArgs e)
        {
            DB_Cmd.DeleteTender();
            DB_Cmd.SaveTender();
        }

        private void tbtn_TndAdd_Click(object sender, EventArgs e)
        {
            DB_Cmd.AddTender(link_LocalFld.Text);
            EditTender();

            SetViewBindNavigators();
        }
        #endregion Tender

        #region Dogovor
        private void tbtn_EditDog_Click(object sender, EventArgs e)
        {
            EditDogovor();
        }

        private void tbtn_DeleteDog_Click(object sender, EventArgs e)
        {
            DB_Cmd.DeleteDogovor();
            DB_Cmd.SaveDogovor();
        }

        private void tbtn_AddDog_Click(object sender, EventArgs e)
        {
            int pos = DB_Cmd.bndDogovor.Position;

            object newobject = DB_Cmd.AddDogovor(link_LocalFld.Text);

            EditDogovor();

            DB_Cmd.grid_SetOldPosition(pos, newobject, DB_Cmd.bndDogovor, "DogID");

            string s = "Для обеспечения целостности данных необходимо создать нулевое допсоглашение " +
               "связанное с текущим договором. \r \n Если Вы согласны, то нажмите Ok!";

            if (MessageBox.Show(s, "Автоматическое создание записи Дополнительного соглашения", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB_Cmd.AddDopSoglashenia();
                EditDopDogovor();
            }

            SetViewBindNavigators();
        }

        //CPlan Tab Dogovor
        private void tbtn_Edit_ItemCPlan_Click(object sender, EventArgs e)
        {
            Form_CPlan feCPlan = new Form_CPlan();
            feCPlan.Show();
            //DB_Cmd.InitializeBindingSources();

            SetViewBindNavigators();
        }
        #endregion Dogovor

        #region CPlan Tab DDog
        private void btn_add_CP_Click(object sender, EventArgs e)
        {
            DB_Cmd.AddCalendarPlanDD();

            Form_CP001 fr = new Form_CP001();
            fr.ShowDialog();

            //SetViewBindNavigators();
        }

        private void btn_delete_CP_Click(object sender, EventArgs e)
        {
            DB_Cmd.DeleteCalendarPlanDD();
        }

        private void btn_edit_CP_Click(object sender, EventArgs e)
        {
            Form_CP001 fr = new Form_CP001();
            fr.ShowDialog();
        }
        #endregion CPlan Tab DDog

        #region Project
        private void tbtn_AddProject_Click(object sender, EventArgs e)
        {
            int pos = DB_Cmd.bndProject.Position;
            object newProject = DB_Cmd.AddProject();

            EditProject();

            DB_Cmd.grid_SetOldPosition(pos, newProject, DB_Cmd.bndProject, "ID_project");

            string s = "Для обеспечения целостности данных \r\n необходимо создать тендер связанный с проектом. " +
                "\r \n Если Вы согласны, то нажмите Ok!";

            if (MessageBox.Show(s, "Автоматическое создание записи Тендера", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB_Cmd.AddTender(link_LocalFld.Text);
                EditTender();
            }

            SetViewBindNavigators();

        }

        private void tbtn_EditProject_Click(object sender, EventArgs e)
        {
            EditProject();
        }

        private void tbtn_DeleteProject_Click(object sender, EventArgs e)
        {
            DB_Cmd.DeleteProject();
            DB_Cmd.SaveProject();
        }
        #endregion Project

        #region Object
        private void tbtn_EditObj_Click(object sender, EventArgs e)
        {
            EditObject();
        }

        private void tbtn_AddObj_Click(object sender, EventArgs e)
        {
            DB_Cmd.AddOBJECTS();
            EditObject();
        }

        private void tbtn_DeleteObj_Click(object sender, EventArgs e)
        {
            DB_Cmd.DeleteOBJECTS();
            DB_Cmd.SaveOBJECTS();
        }

        #endregion Object

        #region SostavObj
        private void tbtn_EditMark_Click(object sender, EventArgs e)
        {
            EditSostavObj();
        }

        private void tbtn_AddMark_Click(object sender, EventArgs e)
        {
            DB_Cmd.AddSostavObj();
            EditSostavObj();
        }

        private void tbtn_DeleteMark_Click(object sender, EventArgs e)
        {
            DB_Cmd.DeleteSostavObj();
            DB_Cmd.SaveSostavObj();
        }

        #endregion SostavObj

        #region Zadania
        private void tbtn_edit_Zadania_Click(object sender, EventArgs e)
        {
            EditZadania();
        }

        private void tbtn_add_Zadania_Click(object sender, EventArgs e)
        {
            DB_Cmd.AddZadania();
            EditZadania();
        }

        private void tbtn_delete_Zadania_Click(object sender, EventArgs e)
        {
            DB_Cmd.DeleteZadania();
            DB_Cmd.SaveZadania();
        }

        #endregion Zadania

        #endregion BindingManager_button

        private void normalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(feature.NormalizeNumSort("1.34.12"));

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DB_Cmd.Filter_Bnd(tb_findProject.Text, DB_Cmd.bndProject, "Code_object");
        }

        private void tbtn_RefreshAll_Click(object sender, EventArgs e)
        {
            ConnectDB();
        }

        private void bndNavigatorTender_RefreshItems(object sender, EventArgs e)
        {

        }
    }

}
