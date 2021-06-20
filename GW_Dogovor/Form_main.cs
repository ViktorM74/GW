#region Using
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddFilesToFolder;
using CPlan;
using DBClass;
using DocTYPELibrary;
using DocumentsClass;
using DogovorClass;
using DopSoglClass;
using feature_сlass;
using FileAction;
using FolderManager;
using GW_Dogovor.Properties;
using ObjectClass;
using PRD;
using ProjectClass;
using TenderClass;
using Zadania;
#endregion Using

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

            DB_Cmd.ConnectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + tPathDB;

            if (File.Exists(tPathDB))
            {
                DB_Cmd.ReConnect();
                if (DB_Cmd.DBLoad())
                {
                    SetView();
                    R = true;
                }
                else
                {
                    using (ContactManager cmForm = new ContactManager()) 
                    {
                        if (cmForm.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show(Settings.Default.TextReloadProgramm);
                            R = false;
                            Application.Restart();

                        }
                    }
                }
                
            }
            else
            {
                using (ContactManager cmForm = new ContactManager()) 
                {
                    if (cmForm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show(Settings.Default.TextReloadProgramm);
                        R = false;
                        Application.Restart();
                    }
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
                SetViewBindNavigators();

                SetFilterTabGrid();
            }

        }
     
        // Все простые события Клик
        private void Clk() 
        {
            menuItem_PropertyConnect.Click += (s, a) => 
            { using (ContactManager cmForm = new ContactManager()) { cmForm.ShowDialog(); Application.Restart(); } };

            menuItem_TypeDoc.Click += (s, a) => 
            { using (Lib_doc_type libDocForm = new Lib_doc_type()) { libDocForm.ShowDialog(); } };

            tbtn_ViewProject.Click += ProjectPanelsVisable;

            tbtn_AddFolders.Click += (s, a) => {
                using (Form_FolderManager ff = new Form_FolderManager(link_LocalFld.Text, link_ServetFld.Text, false))
                { ff.ShowDialog(); }
            };
            
            #region DoubleClikGRID
            gridDocument.DoubleClick += (s, a) => { EditDoc(); };
            grid_MailControl.DoubleClick += (s, a) => { EditDoc(); };
            grid_Zadania.DoubleClick += (s, a) => { EditDoc(); };
            grid_TenderDoc.DoubleClick += (s, a) => { EditDoc(); };
            grid_DogovorDoc.DoubleClick += (s, a) => { EditDoc(); };
            grid_DocumentDD.DoubleClick += (s, a) => { EditDoc(); };
            grid_Z.DoubleClick += (s, a) => { EditDoc(); };
            grid_RKD.DoubleClick += (s, a) => { EditDoc(); };
            grid_Izysk.DoubleClick += (s, a) => { EditDoc(); };
            grid_KMD.DoubleClick += (s, a) => { EditDoc(); };
            #endregion DoubleClikGRID

            #region FileAction
            link_LocalFld.Click += (s, a) => {
                FileA.RunFolder(link_LocalFld.Text);
            };

            link_ServetFld.Click += (s, a) => {
                FileA.RunFolder(link_ServetFld.Text);
            };

            tmCopySelect.Click += (s, a) => {
                if (tbNameProject.SelectionLength > 0)
                    tbNameProject.Copy();
            };

            tmOpenLocalFolder.Click += (s, a) => {
                FileA.RunFolder(link_LocalFld.Text);
            };

            tmOpenServerFolder.Click += (s, a) => {
                FileA.RunFolder(link_ServetFld.Text);
            };
            #endregion FileAction

            #region EditText
            tb_TndComents.DoubleClick += (s, a) => {
                dbEditText(DB_Cmd.bndTender, "Comments");
            };

            tb_pNotes.DoubleClick += (s, a) => {
                dbEditText(DB_Cmd.bndProject, "Notes");
            };

            tb_CommentDog.DoubleClick += (s, a) => {
                dbEditText(DB_Cmd.bndDogovor, "Comments");
            };

            tb_NotesDD.DoubleClick += (s, a) => {
                dbEditText(DB_Cmd.bndDopDogovor, "Comments");
            };
            #endregion EditText
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
           
        }
        private void SetViewDataDocument()
        {
           
            gridDocument.AutoGenerateColumns = false;
            gridDocument.DataSource = DB_Cmd.bndDocument;
            gridDocument.Columns["Obj_name"].DataPropertyName = "Object";
            gridDocument.Columns["NameDoc"].DataPropertyName = "NameDoc";
            gridDocument.Columns["Nambe_Doc"].DataPropertyName = "Nambe_Doc";
            gridDocument.Columns["DataDoc"].DataPropertyName = "DataDoc";
            gridDocument.Columns["Status"].DataPropertyName = "Status";
            gridDocument.Columns["PathDoc"].DataPropertyName = "PathDoc";
        
            bndNvg_Doc.BindingSource = DB_Cmd.bndDocument;

            grid_MailControl.AutoGenerateColumns = false;
            grid_MailControl.DataSource = DB_Cmd.bndDocument;
            grid_MailControl.Columns["ObjectCode"].DataPropertyName = "Object";
            grid_MailControl.Columns["Mail_name"].DataPropertyName = "NameDoc";
            grid_MailControl.Columns["mail_num"].DataPropertyName = "Nambe_Doc";
            grid_MailControl.Columns["mail_date"].DataPropertyName = "DataDoc";
            grid_MailControl.Columns["mail_stat"].DataPropertyName = "Status";
            grid_MailControl.Columns["mail_path"].DataPropertyName = "PathDoc";
          
            bndNvg_Doc.BindingSource = DB_Cmd.bndDocument;

            grid_Zadania.AutoGenerateColumns = false;
            grid_Zadania.DataSource = DB_Cmd.bndDocument;
            grid_Zadania.Columns["ObjectCodeZ"].DataPropertyName = "Object";
            grid_Zadania.Columns["Zname"].DataPropertyName = "NameDoc";
            grid_Zadania.Columns["Znum"].DataPropertyName = "Nambe_Doc";
            grid_Zadania.Columns["Zdate"].DataPropertyName = "DataDoc";
            grid_Zadania.Columns["Zstat"].DataPropertyName = "Status";
            grid_Zadania.Columns["Zpath"].DataPropertyName = "PathDoc";
          
            bndNvg_Doc.BindingSource = DB_Cmd.bndDocument;

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
          
        }
        private void SetViewDogovor()
        {
            bndNavigatorDogovor.BindingSource = DB_Cmd.bndDogovor;
            bndNavigator_KP_Dog.BindingSource = DB_Cmd.bndCalendarPlan;
           

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
         

            grid_CPlan.Columns["Name_Etap"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grid_CPlan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            grid_CPlan.Columns["Name_Etap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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


            grid_DocumentDD.AutoGenerateColumns = false;
            grid_DocumentDD.DataSource = DB_Cmd.bndDocument;
            grid_DocumentDD.Columns["nameDoc_DS"].DataPropertyName = "NameDoc";


            bndNavigatorDDog.BindingSource = DB_Cmd.bndDopDogovor;
            bndNavigator_KP_Dop.BindingSource = DB_Cmd.bndCalendarPlanDD;
           

        }
        private void SetViewObject()
        {
            tb_NameUObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Name_Ustanovka");
            tb_NameObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Name_object");
            tb_CodeObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Nambe_Object");
            tb_TitleObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Titul");
         
            tb_Obj_std.DataBindings.Add("Text", DB_Cmd.bndObject, "Stady");

            //GIP
            tb_ObjComment.DataBindings.Add("Text", DB_Cmd.bndObject, "Comments");
            //Object
            grid_Object.AutoGenerateColumns = false;
            grid_Object.DataSource = DB_Cmd.bndObject;
            grid_Object.Columns["CodeObj"].DataPropertyName = "CodeOBJ";
          

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
            grid_GrafZ.Columns["blok"].DataPropertyName = "Blok";
            grid_GrafZ.Columns["zadania_name"].DataPropertyName = "Coments";
            grid_GrafZ.Columns["zadania_otdel_out"].DataPropertyName = "Otdel_id_out";
            grid_GrafZ.Columns["zadania_otdel_in"].DataPropertyName = "Otdel_id_in";
            grid_GrafZ.Columns["zadania_plan"].DataPropertyName = "Date_graf";
            grid_GrafZ.Columns["zadania_fakt"].DataPropertyName = "Date_fact";


            bndNavigatorObject.BindingSource = DB_Cmd.bndObject;
            bndNavigator_Graph_Mark.BindingSource = DB_Cmd.bndSostavObj;
            bndNavigator_Graph_Z.BindingSource = DB_Cmd.bndZadania;
            bndNavigator_Zadania_file.BindingSource = DB_Cmd.bndDocument;
            bndNavi_RKD.BindingSource = DB_Cmd.bndDocument;
            bndNavi_Izysk.BindingSource = DB_Cmd.bndDocument;
            bndNavi_KMD.BindingSource = DB_Cmd.bndDocument;

            grid_Z.AutoGenerateColumns = false;
            grid_RKD.AutoGenerateColumns = false;
            grid_Izysk.AutoGenerateColumns = false;
            grid_KMD.AutoGenerateColumns = false;

            grid_Z.Columns["name_Zmail"].DataPropertyName = "NameDoc";
            grid_Z.Columns["num_Zmail"].DataPropertyName = "Nambe_Doc";
            grid_Z.Columns["date_Zmail"].DataPropertyName = "DataDoc";
            grid_Z.Columns["stat_Zmail"].DataPropertyName = "Status";
            grid_Z.Columns["path_Zmail"].DataPropertyName = "PathDoc";

            grid_RKD.Columns["name_RKD"].DataPropertyName = "NameDoc";
            grid_RKD.Columns["num_RKD"].DataPropertyName = "Nambe_Doc";
            grid_RKD.Columns["date_RKD"].DataPropertyName = "DataDoc";
            grid_RKD.Columns["stat_RKD"].DataPropertyName = "Status";
            grid_RKD.Columns["path_RKD"].DataPropertyName = "PathDoc";

            grid_Izysk.Columns["name_Iz"].DataPropertyName = "NameDoc";
            grid_Izysk.Columns["num_Iz"].DataPropertyName = "Nambe_Doc";
            grid_Izysk.Columns["date_Iz"].DataPropertyName = "DataDoc";
            grid_Izysk.Columns["stat_Iz"].DataPropertyName = "Status";
            grid_Izysk.Columns["path_Iz"].DataPropertyName = "PathDoc";

            grid_KMD.Columns["name_KMD"].DataPropertyName = "NameDoc";
            grid_KMD.Columns["num_KMD"].DataPropertyName = "Nambe_Doc";
            grid_KMD.Columns["date_KMD"].DataPropertyName = "DataDoc";
            grid_KMD.Columns["stat_KMD"].DataPropertyName = "Status";
            grid_KMD.Columns["path_KMD"].DataPropertyName = "PathDoc";


        }
        #endregion Установка связей контролов с базой

        #region FilterGrid

        private void SetFilterTabGrid()
        {
            // Предположение: Ошибка происходит при переключении ТАБ, если текущий объект "родитель" пустой (не имеет записей)
            // Вариант проверки 1: 
            // Проверить, существует ли объект или является пустым
            //if (DB_Cmd.bndDocument.DataSource == null || ((BindingSource)DB_Cmd.bndDocument.DataSource).Count == 0) 
            //{
            //    //DB_Cmd.adpDocument.Fill(DB_Cmd.dsDB.Documents);
            //    //return;
            //}
            if (((BindingSource)DB_Cmd.bndDocument.DataSource).Count == 0)
            {
                //Психанул 
                DB_Cmd.RebuildBndDocuments();
            }

            if (DB_Cmd.bndDocument.IsSorted && DB_Cmd.bndDocument.SupportsSorting)
                    DB_Cmd.bndDocument.RemoveSort();
                DB_Cmd.bndDocument.RemoveFilter();
                DB_Cmd.bndDocument.DataMember = null;
                DB_Cmd.bndDocument.DataSource = null;
               
           
            void DocumentTabFilter()
            {               
                DB_Cmd.bndDocument.DataSource = DB_Cmd.bndProject;
                DB_Cmd.bndDocument.DataMember = "ProjectDocuments";
                DB_Cmd.bndDocument.Sort = "Object_id, Doc_Type, DataDoc";
                DB_Cmd.bndDocument.ResetBindings(false);

                switch (tabDocuments.SelectedIndex)
                {
                    case 0: // Исходные документы
                        DB_Cmd.bndDocument.RemoveFilter();
                        DB_Cmd.bndDocument.Filter = "(Project_id Not Is Null) AND (Control = false) AND (Zadania = false)";
                        gridDocument.DataSource = DB_Cmd.bndDocument;
                        break;
                    case 1: // На контроле
                        DB_Cmd.bndDocument.RemoveFilter();
                        DB_Cmd.bndDocument.Filter = "(Project_id Not Is Null) AND (Control = true) AND (Zadania = false)";
                        grid_MailControl.DataSource = DB_Cmd.bndDocument;
                        break;
                    case 2: // Задания
                        DB_Cmd.bndDocument.RemoveFilter();
                        DB_Cmd.bndDocument.Filter = "(Project_id Not Is Null) AND (Zadania = true)";
                        grid_MailControl.DataSource = DB_Cmd.bndDocument;
                        break;
                    default:
                        DB_Cmd.bndDocument.RemoveFilter();
                        break;

                }
            } 
            
            void ObjectTabFilter()
            {
                DB_Cmd.bndDocument.DataSource = DB_Cmd.bndObject;
                DB_Cmd.bndDocument.DataMember = "OBJECTSDocuments";
                DB_Cmd.bndDocument.Sort = "DataDoc";
                DB_Cmd.bndDocument.ResetBindings(false);

                switch (tabControlGrafics.SelectedIndex)
                {
                    case 2: // Задания
                        DB_Cmd.bndDocument.RemoveFilter();
                        DB_Cmd.bndDocument.Filter = "(Object_id Not Is Null) AND (Zadania = true)";
                        grid_Z.DataSource = DB_Cmd.bndDocument;
                        break;
                    case 3: // РКД
                        DB_Cmd.bndDocument.RemoveFilter();
                        DB_Cmd.bndDocument.Filter = "(Object_id Not Is Null) AND (RKD = true)";
                        grid_RKD.DataSource = DB_Cmd.bndDocument;
                        break;
                    case 4: // Изыскания
                        DB_Cmd.bndDocument.RemoveFilter();
                        DB_Cmd.bndDocument.Filter = "(Object_id Not Is Null) AND (Izyskania = true)";
                        grid_Izysk.DataSource = DB_Cmd.bndDocument;
                        break;
                    case 5: // КМД
                        DB_Cmd.bndDocument.RemoveFilter();
                        DB_Cmd.bndDocument.Filter = "(Object_id Not Is Null) AND (KMD = true)";
                        grid_KMD.DataSource = DB_Cmd.bndDocument;
                        break;
                    default:
                        DB_Cmd.bndDocument.RemoveFilter();
                        break;
                }

            }

            switch (tabControlMain.SelectedIndex)
            {
                case 0: // Документы
                    DocumentTabFilter();
                    break;
                case 1: // Тендер
                    DB_Cmd.bndDocument.DataSource = DB_Cmd.bndTender;
                    DB_Cmd.bndDocument.DataMember = "TenderDocuments";
                    DB_Cmd.bndDocument.Sort = "DataDoc";
                    DB_Cmd.bndDocument.ResetBindings(false);

                    DB_Cmd.bndDocument.Filter = "(Tender_id Not Is Null)";
                    grid_TenderDoc.DataSource = DB_Cmd.bndDocument;
                    break;
                case 2: // Договор
                    DB_Cmd.bndDocument.DataSource = DB_Cmd.bndDogovor;
                    DB_Cmd.bndDocument.DataMember = "DogovorDocuments";
                    DB_Cmd.bndDocument.Sort = "DataDoc";
                    DB_Cmd.bndDocument.ResetBindings(false);

                    DB_Cmd.bndDocument.Filter = "(Dogovor_id Not Is Null)";
                    grid_DogovorDoc.AutoGenerateColumns = false;
                    grid_DogovorDoc.DataSource = DB_Cmd.bndDocument;

                    DB_Cmd.bndCalendarPlan.RemoveFilter();
                    DB_Cmd.bndCalendarPlan.Filter = "(ViewCPDog = true)";
                    grid_CPlan.DataSource = DB_Cmd.bndCalendarPlan;

                    break;
                case 3: // Доп соглашения
                    DB_Cmd.bndDocument.DataSource = DB_Cmd.bndDopDogovor;
                    DB_Cmd.bndDocument.DataMember = "DopSoglasheniaDocuments";
                    DB_Cmd.bndDocument.Sort = "DataDoc";
                    DB_Cmd.bndDocument.ResetBindings(false);

                    DB_Cmd.bndDocument.Filter = "(DD_id Not Is Null)";
                    grid_DocumentDD.AutoGenerateColumns = false;
                    grid_DocumentDD.DataSource = DB_Cmd.bndDocument;

                    break;
                case 4: // Объект
                    ObjectTabFilter();
                    break;
                default:
                    DB_Cmd.bndDocument.RemoveFilter();
                    break;
            }
         
        }

        private void tabControlGrafics_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFilterTabGrid();
        }

        private void tabDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFilterTabGrid();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (tabControlMain.SelectedIndex == 0 ||
                tabControlMain.SelectedIndex == 1 ||
                tabControlMain.SelectedIndex == 2 ||
                tabControlMain.SelectedIndex == 3 ||
                tabControlMain.SelectedIndex == 4 )
            SetFilterTabGrid();
        }

 
        #endregion FilterGrid

        #region View
        #region View Buttons BindingNavigators
        private void TabControlCount(DataGridView grid, BindingNavigator bndNav)
        {
            if (grid.Rows.Count == 0)
            {
                bndNav.Items[9].Enabled = false; //Button Edit
                bndNav.Items[11].Enabled = false; //Button Delete
            }
            else
            {
                bndNav.Items[9].Enabled = true;
                bndNav.Items[11].Enabled = true;
            }
        }

        private void bndNavigator_Graph_Mark_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_GrafMark, bndNavigator_Graph_Mark);
        }

        private void bndNavigatorObject_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_Object, bndNavigatorObject);
        }

        private void bndNavigator_Graph_Z_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_GrafZ, bndNavigator_Graph_Z);
        }
       
        private void bndNavigator_Zadania_file_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_Z, bndNavigator_Zadania_file);
        }

        private void bndNavi_KMD_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_KMD, bndNavi_KMD);
        }

        private void bndNavi_Izysk_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_Izysk, bndNavi_Izysk);
        }

        private void bndNavi_RKD_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_RKD, bndNavi_RKD);
        }

        private void bndNavigatorDDog_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_DD, bndNavigatorDDog);
        }

        private void bndNavigator_KP_Dop_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_CPlanDD, bndNavigator_KP_Dop);
        }

        private void bndNavigatorDogovor_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_Dogovor, bndNavigatorDogovor);
        }

        private void bndNavigator_KP_Dog_Paint(object sender, PaintEventArgs e)
        {
            //TabControlCount(grid_CPlan, bndNavigator_KP_Dog);
        }
      
        private void bndNav_Act_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(grid_Act, bndNav_Act);
        }

        private void bndNavigatorTender_Paint(object sender, PaintEventArgs e)
        {
            //TabControlCount(grid_Act, bndNav_Act);
            if (DB_Cmd.bndTender.Count == 0)
            {
                bndNavigatorTender.Items[9].Enabled = false; //Button Edit
                bndNavigatorTender.Items[11].Enabled = false; //Button Delete
            }
            else
            {
                bndNavigatorTender.Items[9].Enabled = true;
                bndNavigatorTender.Items[11].Enabled = true;
            }
        }

        private void bndNvg_IshDoc_Paint(object sender, PaintEventArgs e)
        {
            TabControlCount(gridDocument, bndNvg_Doc);
        }



        #endregion View Buttons BindingNavigators

        private void SetViewBindNavigators()
        {
            if (DB_Cmd.bndProject.Count != 0)
            {
                bndNvg_Doc.Enabled = true;
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
                bndNvg_Doc.Enabled = false;
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

            if (Settings.Default.TabDogovorSplit_position != 0 &&
                Settings.Default.TabDDogSplit_position != 0 &&
                Settings.Default.Splitter_position != 0)
            {
                splitter1.SplitPosition = Settings.Default.TabDogovorSplit_position;
                splitter2.SplitPosition = Settings.Default.TabDDogSplit_position;
                this.splitContainer1.SplitterDistance = Settings.Default.Splitter_position;
            }
            tabControlMain.SelectTab(Settings.Default.TabPage);
            
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
            string loc_path = null;
            string serv_path = null;
            //TODO: Определить где, на какой вкладке, объекте находится пользователь. Сгенерировать путь
            string pathUI = GetPositionUser();
            if (pathUI != null)
            {
                loc_path = Path.Combine(link_LocalFld.Text, pathUI);
                serv_path = Path.Combine(link_ServetFld.Text, pathUI);
            }
            else
            {
                loc_path = link_LocalFld.Text;
                serv_path = link_ServetFld.Text;
            }
            using (Form_AddFiles fSel = new Form_AddFiles(loc_path, serv_path))
            {
                fSel.ShowDialog();
            };
        }

        // Узнаём, где находится пользователь и формируем путь для сохранения файлов по Drag
        private string GetPositionUser()
        {
            string pth = null;
            switch (tabControlMain.SelectedIndex)
            {
                case 0:
                    pth = null;
                    break;
                case 1:
                    pth = DB_Cmd.GetCurrentValueField(DB_Cmd.bndTender, "Path").ToString();
                    string s = feature.RemoveSubString(pth, link_LocalFld.Text);
                    if (s != null)
                    {
                        pth = s;
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    pth = null;
                    break;
            }


            return pth;
        }
        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            /////////
        }
        #endregion View



        private void cb_ObjetFilter_MouseDown(object sender, MouseEventArgs e)
        {
            cb_ObjetFilter.Items.Clear();
            cb_ObjetFilter.Items.AddRange(DB_Cmd.GetListValueFields(DB_Cmd.bndDocument, "Object").ToArray());
        }

        private void toolStripComboBox1_MouseEnter(object sender, EventArgs e)
        {
            cb_BlokFilterMark.Items.Clear();
            cb_BlokFilterMark.Items.AddRange(DB_Cmd.GetListValueFields(DB_Cmd.bndSostavObj, "Block").ToArray());
        }

        private void cb_BlockFilterZ_MouseEnter(object sender, EventArgs e)
        {
            cb_BlockFilterZ.Items.Clear();
            cb_BlockFilterZ.Items.AddRange(DB_Cmd.GetListValueFields(DB_Cmd.bndZadania, "Blok").ToArray());
        }


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
            using (Form_Project fed = new Form_Project())
            {
                fed.ShowDialog();
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
        #endregion DoubleClik_EditProject

        #endregion Project

        #region Tender
        private void EditTender()
        {
            using (Form_Tender fe = new Form_Tender())
            {
                fe.ShowDialog();
            }
               

        }

        #endregion Tender

        #region Dogovor
        private void EditDogovor()
        {
            using (Form_Dogovor fе = new Form_Dogovor(link_LocalFld.Text))
            {
                fе.ShowDialog();

            }
        }

        #endregion Dogovor

        #region DopDogovor
        private void EditDopDogovor()
        {
            using (Form_DopSogl fе = new Form_DopSogl())
            {
                fе.ShowDialog();
            }
            
        }

        #endregion DopDogovor

        #region Document
        private void EditDoc()
        {
            using (Form_Document fed = new Form_Document()) 
            {
               fed.ShowDialog(); 
            }
        }

        private void DeleteDoc()
        {
            // вносим изменения в БД
            string pth = DB_Cmd.GetCurrentValueField(DB_Cmd.bndDocument, "PathDoc").ToString();

            bool delFile = DB_Cmd.DeleteDoc();
            
            if (delFile)
            {
                DB_Cmd.SaveDoc();

                string p = null;
                string lp = link_LocalFld.Text;
                string Sp = link_ServetFld.Text;

               
                if (pth.Contains(lp))
                    p = pth.Remove(0, lp.Length + 1);
                else
                    lp = null;
                if (pth.Contains(Sp))
                    p = pth.Remove(0, Sp.Length + 1);
                else
                    Sp = null;
                if (!String.IsNullOrEmpty(p))
                    FileA.DeleteDocument(p, lp, Sp);
            }

        }

        #endregion Document

        #region Object
        private void EditObject()
        {
            using (Form_Object fе = new Form_Object())
            {
                fе.ShowDialog();
            }
        }

        #endregion Object

        #region Calendar Plan

        #endregion Calendar Plan

        #region EditText
        private void dbEditText(BindingSource bnd, String fld)
        {
            using (FormEditText fe = new FormEditText(bnd, fld))
            {
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
            
        }
        #endregion EditText

        #region Zadania
        private void EditZadania()
        {
            using (Form_Zadania_Plan fеd = new Form_Zadania_Plan())
            {
                fеd.ShowDialog();
            }
            
        }

        #endregion Zadania

        #region Mark
        private void EditSostavObj()
        {
            using (Form_PRD fеd = new Form_PRD())
            {
                fеd.ShowDialog();
            }
            
        }
        #endregion Mark

        #endregion Edit DB

        #region CellContentClick

        private void grid_TenderDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentCellClickRun(e, 3);

            DocumentCellClikDelete(e, 4);
        }

        private void DocumentCellClikDelete(DataGridViewCellEventArgs e, int field)
        {
            if (e.ColumnIndex == field)
            {
                DeleteDoc();
            }
        }

        private void gridDocument_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DocumentCellClickRun(e, 6);
        }

        private void grid_MailControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentCellClickRun(e, 6);
        }

        private void grid_Zadania_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentCellClickRun(e, 6);
        }

        private void grid_DogovorDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentCellClickRun(e, 1);

            DocumentCellClikDelete(e, 2);
        }

        private void grid_DocumentDD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentCellClickRun(e, 1);

            DocumentCellClikDelete(e, 2);
        }

        private void grid_Z_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentCellClickRun(e, 5);
        }

        private void grid_RKD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentCellClickRun(e, 5);
        }

        private void grid_Izysk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentCellClickRun(e, 5);
        }

        private void grid_KMD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumentCellClickRun(e, 5);
        }

        private void DocumentCellClickRun(DataGridViewCellEventArgs e, int field)
        {
            if (e.ColumnIndex == field)
            {
                string p = DB_Cmd.GetCurrentValueField(DB_Cmd.bndDocument, "PathDoc").ToString(); ; // читаем путь

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

        private void DragDropCopyFiles(DragEventArgs e, int Narp, string Name)
        {
            if (MessageBox.Show("Вы хотите копировать выбранные файлы в рабочие папки?", "Выбор действия", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    string pLocal = Path.Combine(link_LocalFld.Text, Name);
                    string pServer = Path.Combine(link_ServetFld.Text, Name);
                    if (Narp == 0 || Narp == 2)
                        if (!Directory.Exists(link_LocalFld.Text))
                            throw new Exception(Properties.Settings.Default.NoPathLocal);

                    if (Narp == 1 || Narp == 2)
                        if (!Directory.Exists(link_ServetFld.Text))
                            throw new Exception(Properties.Settings.Default.NoPathServer);

                    using (Form_AddFiles frm_Copyfiles = new Form_AddFiles(pLocal, pServer))
                    {

                        frm_Copyfiles.SetNapr(Narp);
                        foreach (string f in (string[])e.Data.GetData(DataFormats.FileDrop))
                        {
                            frm_Copyfiles.ListFiles.Add(f); // передаем список файлов в модуль копирования
                        }
                        frm_Copyfiles.ShowDialog();
                    }
                }
                finally
                {
                }
            }
        }

        #region DRAG Documents
        private void _DragDropDocument(object sender, DragEventArgs e, int Narp, string Name)
        {
            DB_Cmd.AddDoc();
            if (tabDocuments.SelectedIndex == 1)
            {
                DB_Cmd.SetCuurentValueField(DB_Cmd.bndDocument, "Control", true);
                DB_Cmd.SetCuurentValueField(DB_Cmd.bndDocument, "Doc_Type", 30);
            }
            if (tabDocuments.SelectedIndex == 2)
            {
                DB_Cmd.SetCuurentValueField(DB_Cmd.bndDocument, "Doc_Type", 24);
            }

            EditDoc();

            DragDropCopyFiles(e, Narp, Name);

        }

        private void gridDocument_DragDrop(object sender, DragEventArgs e)
        {
            _DragDropDocument(sender, e, 2, "Основные положения");
        }
        private void grid_MailControl_DragDrop(object sender, DragEventArgs e)
        {
            _DragDropDocument(sender, e, 0, "Письма");
        }
        private void grid_Zadania_DragDrop(object sender, DragEventArgs e)
        {
            _DragDropDocument(sender, e, 1, "Объекты");
        }
        #endregion DRAG Documents
        private void DragDropDoc(object sender, DragEventArgs e, int Narp, string Name)
        {
            DB_Cmd.AddDoc();
            if (tabControlMain.SelectedIndex == 4)
            {
                if (tabControlGrafics.SelectedIndex == 2)
                {
                    DB_Cmd.SetCuurentValueField(DB_Cmd.bndDocument, "Doc_Type", 24);
                }
                if (tabControlGrafics.SelectedIndex == 3)
                {
                    DB_Cmd.SetCuurentValueField(DB_Cmd.bndDocument, "Doc_Type", 33);
                }
                if (tabControlGrafics.SelectedIndex == 4)
                {
                    DB_Cmd.SetCuurentValueField(DB_Cmd.bndDocument, "Doc_Type", 31);
                }
                if (tabControlGrafics.SelectedIndex == 5)
                {
                    DB_Cmd.SetCuurentValueField(DB_Cmd.bndDocument, "Doc_Type", 34);
                }
            }
                
            EditDoc();

            DragDropCopyFiles(e, Narp, Name);

        }
        private void grid_TenderDoc_DragDrop(object sender, DragEventArgs e)
        {
            DragDropDoc(sender, e, 0, "Тендер");
        }
        private void grid_DogovorDoc_DragDrop(object sender, DragEventArgs e)
        {
            string nameDog = DB_Cmd.GetCurrentValueField(DB_Cmd.bndDogovor, "Nambe_Dog").ToString();
            DragDropDoc(sender, e, 0, "Договор\\" + nameDog);
        }
        private void grid_DocumentDD_DragDrop(object sender, DragEventArgs e)
        {
            string nameDog = DB_Cmd.GetCurrentValueField(DB_Cmd.bndDogovor, "Nambe_Dog").ToString();
            string nameDS = DB_Cmd.GetCurrentValueField(DB_Cmd.bndDopDogovor, "Nambe_DS").ToString();
            DragDropDoc(sender, e, 0, "Договор\\" + nameDog  + "\\ДС\\" + nameDS);
        }

        private void grid_Z_DragDrop(object sender, DragEventArgs e)
        {
            string nameObj = DB_Cmd.GetCurrentValueField(DB_Cmd.bndObject, "CodeOBJ").ToString();
            nameObj = nameObj.Replace(" ", "").Replace("\\", "_").Replace("/", "_");
            DragDropDoc(sender, e, 1, "Объекты\\" + nameObj + "\\Задания");
        }

        private void grid_RKD_DragDrop(object sender, DragEventArgs e)
        {
            string nameObj = DB_Cmd.GetCurrentValueField(DB_Cmd.bndObject, "CodeOBJ").ToString();
            nameObj = nameObj.Replace(" ", "").Replace("\\", "_").Replace("/", "_"); ;
            DragDropDoc(sender, e, 1, "Объекты\\" + nameObj + "\\РКД");
        }

        private void grid_Izysk_DragDrop(object sender, DragEventArgs e)
        {
            string nameObj = DB_Cmd.GetCurrentValueField(DB_Cmd.bndObject, "CodeOBJ").ToString();
            nameObj = nameObj.Replace(" ", "").Replace("\\", "_").Replace("/", "_"); ;
            DragDropDoc(sender, e, 1, "Объекты\\" + nameObj + "\\Изыскания");
        }

        private void grid_KMD_DragDrop(object sender, DragEventArgs e)
        {
            string nameObj = DB_Cmd.GetCurrentValueField(DB_Cmd.bndObject, "CodeOBJ").ToString();
            nameObj = nameObj.Replace(" ", "").Replace("\\", "_").Replace("/", "_"); ;
            DragDropDoc(sender, e, 1, "Объекты\\" + nameObj + "\\КМД");
        }

        #endregion DRAG

        #region ARHIVE
        private void btn_BrouseArh_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tb_PathArh.Text = ofd.SelectedPath;
                    Settings.Default.PathArhive = tb_PathArh.Text;
                    Settings.Default.Save();
                }

            }

        }
        private void btn_ScanArh_Click(object sender, EventArgs e)
        {
            TreeFoldersClass.TreeDirectory.FillDirNodes(tree_Arh, tb_PathArh.Text);
        }

        private void tree_Arh_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeFoldersClass.TreeDirectory.BeforeExpand(sender, e);
        }

        private void tree_Arh_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            TreeFoldersClass.TreeDirectory.BeforeSelect(sender, e);
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

        #endregion ARHIVE

        #region BindingManager_button
        #region Project
        private void tbtn_AddProject_Click(object sender, EventArgs e)
        {
            DB_Cmd.AddProject();

            EditProject(); // Вызов окна редактирования новой записи

            string s = "Для обеспечения целостности данных\r\nнеобходимо создать тендер связанный с проектом. " +
                 "\r\nЕсли Вы согласны, то нажмите Ok!";

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
            DB_Cmd.SaveDogovor(null);
        }

        private void tbtn_AddDog_Click(object sender, EventArgs e)
        {
            //int pos = DB_Cmd.bndDogovor.Position;

            object newobject = DB_Cmd.AddDogovor();

            EditDogovor();

            //DB_Cmd.grid_SetOldPosition(pos, newobject, DB_Cmd.bndDogovor, "DogID");

            string s = "Для обеспечения целостности данных необходимо создать нулевое допсоглашение " +
               "связанное с текущим договором. \r\n Если Вы согласны, то нажмите Ok!";

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
            //Form_CPlan feCPlan = new Form_CPlan();
            //feCPlan.Show();
            ////DB_Cmd.InitializeBindingSources();

            //SetViewBindNavigators();
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

        #region Document
        private void bndNav_EditDoc_Click(object sender, EventArgs e)
        {
            EditDoc();
        }

        private void bndNav_AddDoc_Click(object sender, EventArgs e)
        {
            DB_Cmd.AddDoc();
            EditDoc();
        }

        private void bndNav_DeleteDoc_Click(object sender, EventArgs e)
        {
            DeleteDoc();
        }
        #endregion Document

        #region DopSogl
        private void tbtn_EditDDog_Click(object sender, EventArgs e)
        {
            EditDopDogovor();
        }

        private void tbtn_AddDDog_Click(object sender, EventArgs e)
        {
            DB_Cmd.AddDopSoglashenia();
            EditDopDogovor();
        }

        private void tbtn_DeleteDDog_Click(object sender, EventArgs e)
        {
            DB_Cmd.DeleteDopSoglashenia();
            DB_Cmd.SaveDopSoglashenia();
        }
        #endregion DopSogl


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
            DB_Cmd.DBLoad();
        }

        private void gridDocument_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("DF");
        }

        private void bndNvg_Doc_RefreshItems(object sender, EventArgs e)
        {

        }

        private void LocalInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = link_LocalFld.Text;
            string a_path = "Письма";
            path = Path.Combine(path, a_path);
            if (!File.Exists(path))
                FileA.CreateFolder(path);
            FileA.RunPath(path);
        }

        private void LocalOutMailMenuItem_Click(object sender, EventArgs e)
        {
            string path = link_LocalFld.Text;
            string nameObj = DB_Cmd.GetCurrentValueField(DB_Cmd.bndObject, "CodeOBJ").ToString();
            nameObj = nameObj.Replace(" ", "").Replace("\\", "_").Replace("/", "_"); ;
            string a_path = "Исх";
            path = Path.Combine(path, a_path);
            path = Path.Combine(path, nameObj);
            if (!File.Exists(path))
                FileA.CreateFolder(path);
            FileA.RunPath(path);
        }

        private void ServerInMailMenuItem1_Click(object sender, EventArgs e)
        {
            FileA.RunPath("\\\\Snhp03\\31 входящие документы");
        }

        private void ServerOutMailMenuItem1_Click(object sender, EventArgs e)
        {
            FileA.RunPath("\\\\Snhp03\\32 исходящие документы");
        }

        private void MailMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
                if (tabDocuments.SelectedIndex == 1)
                    ReplyInMenuItem.Enabled = true;
                else
                    ReplyInMenuItem.Enabled = false;

            if (tabControlMain.SelectedIndex == 4)
                if (DB_Cmd.bndObject.Count != 0)
                    MailObjectMenuItem.Enabled = true;
                else
                    MailObjectMenuItem.Enabled = false;
        }

 
    }

}
