using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBClass._bsp_snhpDataSetTableAdapters;
using feature_сlass;
using FileAction;

namespace DBClass
{
    public class DB_Cmd
    {
        public static _bsp_snhpDataSet dsDB = new _bsp_snhpDataSet();
        public static TableAdapterManager tableManager = new TableAdapterManager();

        #region DataBaseLoad
        #region TableAdapters
        public static ProjectTableAdapter adpProject = new ProjectTableAdapter(); //+
        public static CustomersTableAdapter adpCustomer = new CustomersTableAdapter(); //+
        public static DocumentsTableAdapter adpDocument = new DocumentsTableAdapter(); //+
        public static Documets_typeTableAdapter adpTypeDocument = new Documets_typeTableAdapter(); //+
        public static DogovorTableAdapter adpDogovor = new DogovorTableAdapter(); //+
        public static TenderTableAdapter adpTender = new TenderTableAdapter(); //+
        public static CalendarPlanTableAdapter adpCPlan = new CalendarPlanTableAdapter(); //+
        public static DopSoglasheniaTableAdapter adpDDogovor = new DopSoglasheniaTableAdapter(); //+
        public static EventsTableAdapter adpEvent = new EventsTableAdapter(); //+
        public static Stady_projectTableAdapter adpStadyPrj = new Stady_projectTableAdapter(); //+
        public static ActTableAdapter adpAct = new ActTableAdapter(); //+
        public static OBJECTSTableAdapter adpObject = new OBJECTSTableAdapter(); //+
        public static SostavDocTableAdapter adpSostavD = new SostavDocTableAdapter(); //+
        public static Mark_projectTableAdapter adpMark = new Mark_projectTableAdapter(); //+
        public static ZadaniaTableAdapter adpZadania = new ZadaniaTableAdapter(); //+
        public static HistoryTableAdapter adpHistory = new HistoryTableAdapter(); //+
        public static OtdelTableAdapter adpOtdel = new OtdelTableAdapter(); //+
        public static Users_GIPTableAdapter adpGIP = new Users_GIPTableAdapter();
        public static Otdel_SNHPTableAdapter adpOtdel_SNHP = new Otdel_SNHPTableAdapter();
        public static Doc_GroupTableAdapter adpDoc_Group = new Doc_GroupTableAdapter();
        #endregion TableAdapters

        #region BindingSources
        public static BindingSource bndProject = new BindingSource();
        public static BindingSource bndAreaStroy = new BindingSource();
        public static BindingSource bndDocument = new BindingSource();
        public static BindingSource bndTypeDoc = new BindingSource();
        public static BindingSource bndTender = new BindingSource();
        public static BindingSource bndStadia = new BindingSource();
        public static BindingSource bndGip = new BindingSource();
        public static BindingSource bndDogovor = new BindingSource();
        public static BindingSource bndCalendarPlan = new BindingSource();
        public static BindingSource bndCalendarPlanDD = new BindingSource();
        public static BindingSource bndDopDogovor = new BindingSource();
        public static BindingSource bndObject = new BindingSource();
        public static BindingSource bndAct = new BindingSource();
        public static BindingSource bndSostavObj = new BindingSource();
        public static BindingSource bndZadania = new BindingSource();
        public static BindingSource bndEvents = new BindingSource();
        public static BindingSource bndMark = new BindingSource();
        public static BindingSource bndHistory = new BindingSource();
        public static BindingSource bndOtdel = new BindingSource();
        public static BindingSource bndOtdel_SNHP = new BindingSource();
        public static BindingSource bndDoc_Group = new BindingSource();
        #endregion BindingSources

        /// <summary>
        /// Загрузка данных в DataSet
        /// Связывание TableAdapters
        /// </summary>
        public static void DBLoad()
        {
            GreateTableManager_1();
            DBFills();
            InitializeBindingSources();
        }

        private static void DBFills()
        {
            adpProject.Fill(dsDB.Project);
            adpCustomer.Fill(dsDB.Customers);
            adpDocument.Fill(dsDB.Documents);
            adpTypeDocument.Fill(dsDB.Documets_type);
            //Dogovor
            adpDogovor.Fill(dsDB.Dogovor);
            //Tender
            adpTender.Fill(dsDB.Tender);
            //CalendarPlan
            adpCPlan.Fill(dsDB.CalendarPlan);
            //DopSoglashenia
            adpDDogovor.Fill(dsDB.DopSoglashenia);
            //Events
            adpEvent.Fill(dsDB.Events);
            //Stady_project
            adpStadyPrj.Fill(dsDB.Stady_project);
            //Act
            adpAct.Fill(dsDB.Act);
            //OBJECT
            adpObject.Fill(dsDB.OBJECTS);
            //SostavDoc
            adpSostavD.Fill(dsDB.SostavDoc);
            //Mark_project
            adpMark.Fill(dsDB.Mark_project);
            //Zadania
            adpZadania.Fill(dsDB.Zadania);
            //History
            adpHistory.Fill(dsDB.History);
            //Otdel
            adpOtdel.Fill(dsDB.Otdel);
            //GIP
            adpGIP.Fill(dsDB.Users_GIP);
            //Otdel_SNHP
            adpOtdel_SNHP.Fill(dsDB.Otdel_SNHP);
            //Doc_Group
            adpDoc_Group.Fill(dsDB.Doc_Group);
        }

        public static void InitializeBindingSources()
        {
            //Project
            bndProject.DataSource = DB_Cmd.dsDB;
            bndProject.DataMember = "Project";
            bndProject.Sort = "Code_object";
            bndAreaStroy.DataSource = DB_Cmd.dsDB;
            bndAreaStroy.DataMember = "Customers";
            
            //Ish Documents
            bndDocument.DataSource = bndProject; //привязка по связи к Проекту
            bndDocument.DataMember = "ProjectDocuments";
            bndDocument.Sort = "Object_id, Doc_Type, DataDoc";

            bndTypeDoc.DataSource = DB_Cmd.dsDB;
            bndTypeDoc.DataMember = "Documets_type";
            bndTypeDoc.Sort = "Name_doc";
            
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
            bndDogovor.Sort = "Nambe_Dog";
            bndCalendarPlan.DataSource = bndDogovor;
            bndCalendarPlan.DataMember = "DogovorCalendarPlan";
            bndCalendarPlan.Sort = "Num_sort";
            bndAct.DataSource = bndCalendarPlan;
            bndAct.DataMember = "CalendarPlanAct";
            bndAct.Sort = "Data_podp";

            //DopDogovor
            bndDopDogovor.DataSource = bndDogovor;
            bndDopDogovor.DataMember = "DogovorDopSoglashenia";
            bndDopDogovor.Sort = "Nambe_DS";
            bndCalendarPlanDD.DataSource = bndDopDogovor;
            bndCalendarPlanDD.DataMember = "DopSoglasheniaCalendarPlan";
            bndCalendarPlanDD.Sort = "Num_sort";

            //Object
            bndObject.DataSource = bndDogovor;
            bndObject.DataMember = "DogovorOBJECTS";
            bndObject.Sort = "Nambe_Object";
            
            //SostavObj
            bndSostavObj.DataSource = bndObject;
            bndSostavObj.DataMember = "OBJECTSSostavDoc";
            
            //Zadania
            bndZadania.DataSource = bndObject;
            bndZadania.DataMember = "OBJECTSZadania";
            bndZadania.Sort = "Date_graf";

            //Events
            bndEvents.DataSource = bndObject;
            bndEvents.DataMember = "OBJECTSEvents";
            bndEvents.Sort = "Срок_по_плану";

            //MarkProject
            bndMark.DataSource = DB_Cmd.dsDB;
            bndMark.DataMember = "Mark_project";
           

            //History
            bndHistory.DataSource = DB_Cmd.dsDB;
            bndHistory.DataMember = "History";
            bndHistory.Sort = "DataHist";

            //Otdel
            bndOtdel.DataSource = DB_Cmd.dsDB;
            bndOtdel.DataMember = "Otdel";

            //SostavObj
            bndSostavObj.DataSource = bndObject;
            bndSostavObj.DataMember = "OBJECTSSostavDoc";
            bndSostavObj.Sort = "Block ASC";

            //Otdel_SNHP
            bndOtdel_SNHP.DataSource = DB_Cmd.dsDB;
            bndOtdel_SNHP.DataMember = "Otdel_SNHP";

            //Doc_Group
            bndDoc_Group.DataSource = DB_Cmd.dsDB;
            bndDoc_Group.DataMember = "Doc_Group";
            bndDoc_Group.Sort = "Name_group";

        }

        /// <summary>
        /// Создание Менеджера таблиц
        /// </summary>
        public static void GreateTableManager_1()
        {
            tableManager.ProjectTableAdapter = adpProject;
            tableManager.CustomersTableAdapter = adpCustomer;
            tableManager.DocumentsTableAdapter = adpDocument;
            tableManager.Documets_typeTableAdapter = adpTypeDocument;
            tableManager.DogovorTableAdapter = adpDogovor;
            tableManager.TenderTableAdapter = adpTender;
            tableManager.DopSoglasheniaTableAdapter = adpDDogovor;
            tableManager.CalendarPlanTableAdapter = adpCPlan;
            tableManager.ActTableAdapter = adpAct;
            tableManager.OBJECTSTableAdapter = adpObject;
            tableManager.SostavDocTableAdapter = adpSostavD;
            tableManager.ZadaniaTableAdapter = adpZadania;
            tableManager.HistoryTableAdapter = adpHistory;
            tableManager.EventsTableAdapter = adpEvent;
            tableManager.Stady_projectTableAdapter = adpStadyPrj;
            tableManager.Mark_projectTableAdapter = adpMark;
            tableManager.OtdelTableAdapter = adpOtdel;
            tableManager.Otdel_SNHPTableAdapter = adpOtdel_SNHP;
            tableManager.Doc_GroupTableAdapter = adpDoc_Group;

            
            tableManager.BackupDataSetBeforeUpdate = true;
            tableManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
        }
        #endregion DataBaseLoad

        public static string GetCurrentValueField(BindingSource bnd, string field)
        {
            return ((DataRowView)bnd.Current).Row[field].ToString();
        }

        public static void SetCuurentValueField(BindingSource bnd, string field, string value)
        {
            ((DataRowView)bnd.Current).Row[field] = value;
        }

        public static bool Save_BndDB(BindingSource bnd)
        {
            int position = bnd.Position;

            try
            {
                bnd.EndEdit();
                tableManager.UpdateAll(dsDB);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);

            }
            finally
            {
                bnd.Position = position;
            }

            return false;
        }

        public static bool Cancel_BndDB(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.CancelEdit();
                bnd.ResetBindings(false);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отмена действия вызвала ошибку: " + ex.Message);
            }
            finally
            {
                bnd.Position = position;
            }

            return false;
        }

        #region Update-Delete
        #region Project

        public static bool SaveProject()
        {
            int position = bndProject.Position;
           
            try
            {
                bndProject.EndEdit();
                tableManager.UpdateAll(dsDB);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                
            }
            finally
            {
                bndProject.Position = position;
            }

            return false;
        }

        public static void CancelProject()
        {
            int position = bndProject.Position;

            bndProject.CancelEdit();
            bndProject.ResetBindings(false);

            //adpProject.Update(dsDB.Project);
            //dsDB.Tables["Project"].AcceptChanges();
            //adpProject.Fill(dsDB.Project);

            bndProject.Position = position;
        }

        public static object AddProject()
        {
            return bndProject.AddNew();
        }

        public static void DeleteProject()
        {
            DataRowView rw = bndProject.Current as DataRowView;
            string NameDelete = rw.Row["Name"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndProject.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion Project

        #region Document

        public static void SaveDoc()
        {
            int position = bndDocument.Position;
            try
            {
                bndDocument.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndDocument.ResetBindings(false);
            }
            finally
            {
                adpDocument.Update(dsDB.Documents);
                dsDB.Tables["Documents"].AcceptChanges();
                adpDocument.Fill(dsDB.Documents);

                bndDocument.Position = position;
            }
        }

        public static void CancelDoc()
        {
            int position = bndDocument.Position;

            bndDocument.ResetBindings(false);

            adpDocument.Update(dsDB.Documents);
            dsDB.Tables["Documents"].AcceptChanges();
            adpDocument.Fill(dsDB.Documents);

            bndDocument.Position = position;
        }

        public static void AddDoc()
        {
            bndDocument.AddNew();
        }

        public static void DeleteDoc()
        {
            DataRowView rw = bndDocument.Current as DataRowView;
            string NameDelete = rw.Row["Namedoc"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndDocument.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

#endregion

        #region TypeDocument

        public static void SaveTypeDoc()
        {
            int position = bndTypeDoc.Position;
            try
            {
                bndTypeDoc.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndTypeDoc.ResetBindings(false);
            }
            finally
            {
                adpTypeDocument.Update(dsDB.Documets_type);
                dsDB.Tables["Documets_type"].AcceptChanges();
                adpTypeDocument.Fill(dsDB.Documets_type);

                bndTypeDoc.Position = position;
            }
        }

        public static void CancelTypeDoc()
        {
            int position = bndTypeDoc.Position;

            bndTypeDoc.ResetBindings(false);

            adpTypeDocument.Update(dsDB.Documets_type);
            dsDB.Tables["Documets_type"].AcceptChanges();
            adpTypeDocument.Fill(dsDB.Documets_type);

            bndTypeDoc.Position = position;
        }

        public static void AddTypeDoc()
        {
            bndTypeDoc.AddNew();
        }

        public static void DeleteTypeDoc()
        {
            DataRowView rw = bndTypeDoc.Current as DataRowView;
            string NameDelete = rw.Row["Name_doc"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndTypeDoc.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion

        #region Dogovor
        public static void SaveDogovor(string linkFolder)
        {
            int position = bndDogovor.Position;

            if (linkFolder != null)
            {
                string newPath = Path.Combine(Path.Combine(linkFolder, "Договор"), DateTime.Now.ToString("yyyy.MM.dd"));
                FileA.CreateFolder(newPath);
                ((DataRowView)bndDogovor.Current).Row["path"] = newPath;
            }

            try
            {
                bndDogovor.EndEdit();
                tableManager.UpdateAll(dsDB);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndDogovor.ResetBindings(false);
            }
            finally
            {
                bndDogovor.Position = position;
            }
        }

        public static void CancelDogovor()
        {
            int position = bndDogovor.Position;

            bndDogovor.CancelEdit();
            bndDogovor.ResetBindings(false);

            bndDogovor.Position = position;
        }

        public static object AddDogovor()
        {
            object newobj;

            if (DB_Cmd.bndTender.Count != 0)
            {
                newobj =  bndDogovor.AddNew();

                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["IDCust"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["IDCust"];
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["Name_Dog"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["Name_Tender"];
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["IDGip"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["GIP"];
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["id_Tender"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["ID_Teder"];
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["IDStady"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["IDStadia"];
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["Sostav"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["Sostav"];

                return newobj;
            }
            else
            {
                MessageBox.Show("Для создания договора требуется активная запись 'Тендер'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static void DeleteDogovor()
        {
            DataRowView rw = bndDogovor.Current as DataRowView;
            string NameDelete = rw.Row["Nambe_Dog"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndDogovor.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region Tender
        public static void SaveTender()
        {
            int position = bndTender.Position;
            try
            {
                bndTender.EndEdit();
                tableManager.UpdateAll(dsDB);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
               
            }
            finally
            {
                bndTender.Position = position;
            }
        }

        public static void CancelTender()
        {
            int position = bndTender.Position;

            bndTender.CancelEdit();
            bndTender.ResetBindings(false);

            bndTender.Position = position;
        }
        
        public static void AddTender(string linkFolder)
        {
            bndTender.AddNew();
            ((DataRowView)bndTender.Current).Row["IDCust"] = ((DataRowView)bndProject.Current).Row["AreaStroy_ID"];
            ((DataRowView)bndTender.Current).Row["Name_Tender"] = ((DataRowView)bndProject.Current).Row["Name"];
            if (linkFolder != "")
            {
                FileA.CreateFolder("Тендер", linkFolder);
                string newPath = Path.Combine(Path.Combine(linkFolder, "Тендер"), DateTime.Now.ToString("yyyy.MM.dd"));
                FileA.CreateFolder(newPath);
                ((DataRowView)bndTender.Current).Row["Path"] = newPath;
            }
        }

        public static void DeleteTender()
        {
            DataRowView rw = bndTender.Current as DataRowView;
            string NameDelete = rw.Row["Name_Tender"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndTender.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region CalendarPlanDD
        public static void SaveCalendarPlanDD()
        {
            int position = bndCalendarPlanDD.Position;
            try
            {
                //Автозаполнение поля для правильной сортировки Num_sort
                
                
                              
                bndCalendarPlanDD.EndEdit();
                tableManager.UpdateAll(dsDB);

                if (bndCalendarPlanDD.Count != 0)
                    ((DataRowView)bndCalendarPlanDD.Current).Row["Num_sort"] = feature.NormalizeNumSort(((DataRowView)bndCalendarPlanDD.Current).Row["Num_Etap"].ToString());

                bndCalendarPlanDD.EndEdit();
                tableManager.UpdateAll(dsDB);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndCalendarPlan.ResetBindings(false);
               
            }
            finally
            {
                bndCalendarPlanDD.Position = position;
            }
        }

        public static void RefreshCPlanDD()
        {
            bndCalendarPlanDD.EndEdit();
            tableManager.UpdateAll(dsDB);
            bndCalendarPlanDD.ResetBindings(true);
        }

        public static void CancelCalendarPlanDD()
        {
            int position = bndCalendarPlanDD.Position;

            bndCalendarPlanDD.ResetBindings(false);

            bndCalendarPlanDD.CancelEdit();

            bndCalendarPlanDD.Position = position;
        }

        public static object AddCalendarPlanDD()
        {
            if (DB_Cmd.bndDopDogovor.Count != 0)
            {
                object obj =  bndCalendarPlanDD.AddNew();
                    string idDog = GetCurrentValueField(bndDogovor, "DogID");
                    SetCuurentValueField(bndCalendarPlanDD, "IDDog", idDog);
                    SetCuurentValueField(bndCalendarPlanDD, "StatGlob", "0");
                return obj;
            }
            else
            {
                MessageBox.Show("Для создания объекта требуется активная запись 'Договор'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static void DeleteCalendarPlanDD()
        {
            DataRowView rw = bndCalendarPlanDD.Current as DataRowView;
            string NameDelete = rw.Row["Name_Etap"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndCalendarPlanDD.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion CalendarPlanDD

        #region CalendarPlan
        public static void SaveCalendarPlan()
        {
            int position = bndCalendarPlan.Position;
            try
            {
                //Автозаполнение поля для правильной сортировки Num_sort
                if (bndCalendarPlan.Count != 0)
                 ((DataRowView)bndCalendarPlan.Current).Row["Num_sort"] = feature.NormalizeNumSort(((DataRowView)bndCalendarPlan.Current).Row["Num_Etap"].ToString());

                //StatGlob

                bndCalendarPlan.EndEdit();

                tableManager.UpdateAll(dsDB);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndCalendarPlan.ResetBindings(false);
            }
            finally
            {
               bndCalendarPlan.Position = position;
            }
        }

        public static void RefreshCPlan()
        {
            bndCalendarPlan.EndEdit();
            tableManager.UpdateAll(dsDB);
            bndCalendarPlan.ResetBindings(true);
        }

        public static void CancelCalendarPlan()
        {
            int position = bndCalendarPlan.Position;

            bndCalendarPlan.CancelEdit();

            bndCalendarPlan.ResetBindings(false);

            bndCalendarPlan.Position = position;
        }

        public static object AddCalendarPlan()
        {
            if (DB_Cmd.bndDogovor.Count != 0)
            {
                return bndCalendarPlan.AddNew();
            }
            else
            {
                MessageBox.Show("Для создания объекта требуется активная запись 'Договор'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static void DeleteCalendarPlan()
        {
            DataRowView rw = bndCalendarPlan.Current as DataRowView;
            string NameDelete = rw.Row["Name_Etap"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndCalendarPlan.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion CalendarPlan

        #region DopSoglashenia
        public static void SaveDopSoglashenia()
        {
            int position = bndDopDogovor.Position;
            try
            {
                if (bndDopDogovor.Count != 0)
                    ((DataRowView)DB_Cmd.bndDopDogovor.Current).Row["Nambe_DS"] = feature.NormalizeNumSort(((DataRowView)DB_Cmd.bndDopDogovor.Current).Row["Nambe_DS"].ToString());

                bndDopDogovor.EndEdit();

                tableManager.UpdateAll(dsDB);
                //adpDDogovor.Update(dsDB.DopSoglashenia);
                //dsDB.Tables["DopSoglashenia"].AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndDopDogovor.ResetBindings(false);
            }
            finally
            {
                //adpDDogovor.Fill(dsDB.DopSoglashenia);
                bndDopDogovor.Position = position;
            }
        }

        public static void CancelDopSoglashenia()
        {
            int position = bndDopDogovor.Position;

            bndDopDogovor.CancelEdit();
            bndDopDogovor.ResetBindings(false);

            //adpDDogovor.Update(dsDB.DopSoglashenia);
            //dsDB.Tables["DopSoglashenia"].AcceptChanges();
            //adpDDogovor.Fill(dsDB.DopSoglashenia);

            bndDopDogovor.Position = position;
        }

        public static object AddDopSoglashenia()
        {
            if (DB_Cmd.bndDogovor.Count != 0)
            {
              object newobj =  bndDopDogovor.AddNew();

               ((DataRowView)DB_Cmd.bndDopDogovor.Current).Row["DogID"] = ((DataRowView)DB_Cmd.bndDogovor.Current).Row["DogID"];
               
               ((DataRowView)DB_Cmd.bndDopDogovor.Current).Row["Nambe_DS"] = Convert.ToString(DB_Cmd.bndDopDogovor.Count -1);

                return newobj;
               
            }
            else
            {
                MessageBox.Show("Для создания допсоглашения требуется активная запись 'Договор'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            
        }

        public static void DeleteDopSoglashenia()
        {
            DataRowView rw = bndDopDogovor.Current as DataRowView;
            string NameDelete = rw.Row["Nambe_DS"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndDopDogovor.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region Events
        public static void SaveEvents()
        {
            int position = bndEvents.Position;
            try
            {
                bndEvents.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndEvents.ResetBindings(false);
            }
            finally
            {
                adpEvent.Update(dsDB.Events);
                dsDB.Tables["Events"].AcceptChanges();
                adpEvent.Fill(dsDB.Events);

                bndEvents.Position = position;
            }
        }

        public static void CancelEvents()
        {
            int position = bndEvents.Position;

            bndEvents.ResetBindings(false);

            adpEvent.Update(dsDB.Events);
            dsDB.Tables["Events"].AcceptChanges();
            adpEvent.Fill(dsDB.Events);

            bndEvents.Position = position;
        }

        public static void AddEvents()
        {
            bndEvents.AddNew();
        }

        public static void DeleteEvents()
        {
            DataRowView rw = bndEvents.Current as DataRowView;
            string NameDelete = rw.Row["Событие"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndEvents.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region Stady_project
        public static void SaveStady_project()
        {
            int position = bndStadia.Position;
            try
            {
                bndStadia.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndStadia.ResetBindings(false);
            }
            finally
            {
                adpStadyPrj.Update(dsDB.Stady_project);
                dsDB.Tables["Stady_project"].AcceptChanges();
                adpStadyPrj.Fill(dsDB.Stady_project);

                bndStadia.Position = position;
            }
        }

        public static void CancelStady_project()
        {
            int position = bndStadia.Position;

            bndStadia.ResetBindings(false);

            adpStadyPrj.Update(dsDB.Stady_project);
            dsDB.Tables["Stady_project"].AcceptChanges();
            adpStadyPrj.Fill(dsDB.Stady_project);

            bndStadia.Position = position;
        }

        public static void AddStady_project()
        {
            bndStadia.AddNew();
        }

        public static void DeleteStady_project()
        {
            DataRowView rw = bndStadia.Current as DataRowView;
            string NameDelete = rw.Row["Расшифровка"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndStadia.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region Act
        public static void SaveAct()
        {
            int position = bndAct.Position;
            try
            {
                bndAct.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndAct.ResetBindings(false);
            }
            finally
            {
                adpAct.Update(dsDB.Act);
                dsDB.Tables["Act"].AcceptChanges();
                adpAct.Fill(dsDB.Act);

                bndAct.Position = position;
            }
        }

        public static void CancelAct()
        {
            int position = bndAct.Position;

            bndAct.ResetBindings(false);

            adpAct.Update(dsDB.Act);
            dsDB.Tables["Act"].AcceptChanges();
            adpAct.Fill(dsDB.Act);

            bndAct.Position = position;
        }

        public static void AddAct()
        {
            bndAct.AddNew();
        }

        public static void DeleteAct()
        {
            DataRowView rw = bndAct.Current as DataRowView;
            string NameDelete = rw.Row["Nambe_Act"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndAct.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region OBJECTS
        public static void SaveOBJECTS()
        {
            int position = bndObject.Position;
            try
            {
                bndObject.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndObject.ResetBindings(false);
            }
            finally
            {
                adpObject.Update(dsDB.OBJECTS);
                dsDB.Tables["OBJECTS"].AcceptChanges();
                adpObject.Fill(dsDB.OBJECTS);

                bndObject.Position = position;
            }
        }

        public static void CancelOBJECTS()
        {
            int position = bndObject.Position;

            bndObject.ResetBindings(false);

            adpObject.Update(dsDB.OBJECTS);
            dsDB.Tables["OBJECTS"].AcceptChanges();
            adpObject.Fill(dsDB.OBJECTS);

            bndObject.Position = position;
        }

        public static void AddOBJECTS()
        {
            if (DB_Cmd.bndDogovor.Count != 0)
            {
                bndObject.AddNew();
                ((DataRowView)DB_Cmd.bndObject.Current).Row["IDCust"] = ((DataRowView)DB_Cmd.bndDogovor.Current).Row["IDCust"];
                ((DataRowView)DB_Cmd.bndObject.Current).Row["GIP"] = ((DataRowView)DB_Cmd.bndDogovor.Current).Row["IDGip"];
                ((DataRowView)DB_Cmd.bndObject.Current).Row["Name_Ustanovka"] = ((DataRowView)DB_Cmd.bndDogovor.Current).Row["Name_Dog"];
            }
            else
            {
                MessageBox.Show("Для создания объекта требуется активная запись 'Договор'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void DeleteOBJECTS()
        {
            DataRowView rw = bndObject.Current as DataRowView;
            string NameDelete = rw.Row["Name_object"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndObject.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region SostavDoc
        public static void SaveSostavObj()
        {
            int position = bndSostavObj.Position;
            try
            {
                bndSostavObj.EndEdit();
                tableManager.UpdateAll(dsDB);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
               
            }
            finally
            {
                bndSostavObj.Position = position;
            }
        }

        public static void CancelSostavObj()
        {
            int position = bndSostavObj.Position;

            bndSostavObj.CancelEdit();

            bndSostavObj.ResetBindings(false);

            bndSostavObj.Position = position;
        }

        public static object AddSostavObj()
        {
            return bndSostavObj.AddNew();
        }

        public static void DeleteSostavObj()
        {
            DataRowView rw = bndSostavObj.Current as DataRowView;
            string NameDelete = rw.Row["Mark"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndSostavObj.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region Mark_project
        public static void SaveMark_project()
        {
            int position = bndMark.Position;
            try
            {
                bndMark.EndEdit();
                tableManager.UpdateAll(dsDB);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
               
            }
            finally
            {
                bndMark.Position = position;
            }
        }

        public static void CancelMark_project()
        {
            int position = bndMark.Position;

            bndMark.CancelEdit();
            
            bndMark.ResetBindings(false);

            bndMark.Position = position;
        }

        public static object AddMark_project()
        {
           return bndMark.AddNew();
        }

        public static void DeleteMark_project()
        {
            DataRowView rw = bndMark.Current as DataRowView;
            string NameDelete = rw.Row["Марка"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndMark.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion Mark_project

        #region Zadania
        public static void SaveZadania()
        {
            int position = bndZadania.Position;
            try
            {
                bndZadania.EndEdit();
                tableManager.UpdateAll(dsDB);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndZadania.ResetBindings(false);
            }
            finally
            {
                bndZadania.Position = position;
            }
        }

        public static void CancelZadania()
        {
            int position = bndZadania.Position;

            bndZadania.CancelEdit();
            bndZadania.ResetBindings(false);

            bndZadania.Position = position;
        }

        public static object AddZadania()
        {
            return bndZadania.AddNew();
        }

        public static void DeleteZadania()
        {
            DataRowView rw = bndZadania.Current as DataRowView;
            string NameDelete = rw.Row["Коментарий"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r \n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndZadania.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region History
        public static void SaveHistory()
        {
            int position = bndHistory.Position;
            try
            {
                bndHistory.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndHistory.ResetBindings(false);
            }
            finally
            {
                adpHistory.Update(dsDB.History);
                dsDB.Tables["History"].AcceptChanges();
                adpHistory.Fill(dsDB.History);

                bndHistory.Position = position;
            }
        }

        public static void CancelHistory()
        {
            int position = bndHistory.Position;

            bndHistory.ResetBindings(false);

            adpHistory.Update(dsDB.History);
            dsDB.Tables["History"].AcceptChanges();
            adpHistory.Fill(dsDB.History);

            bndHistory.Position = position;
        }

        public static void AddHistory()
        {
            bndHistory.AddNew();
        }

        public static void DeleteHistory()
        {
            DataRowView rw = bndHistory.Current as DataRowView;
            string NameDelete = rw.Row["EvHist"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndHistory.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region Otdel
        public static void SaveOtdel()
        {
            int position = bndOtdel.Position;
            try
            {
                bndOtdel.EndEdit();
                adpOtdel.Update(dsDB.Otdel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndOtdel.ResetBindings(false);
            }
            finally
            {
                //dsDB.Tables["Otdel"].AcceptChanges();
                //adpOtdel.Fill(dsDB.Otdel);

                bndOtdel.Position = position;
            }
        }

        public static void CancelOtdel()
        {
            int position = bndOtdel.Position;

            bndOtdel.CancelEdit();
            bndOtdel.ResetBindings(false);

           bndOtdel.Position = position;
        }

        public static object AddOtdel()
        {
            return bndOtdel.AddNew();
        }

        public static void DeleteOtdel()
        {
            DataRowView rw = bndOtdel.Current as DataRowView;
            string NameDelete = rw.Row["NameOtd"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r \n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndOtdel.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        #endregion

        #region Otdel_SNHP
        public static void SaveOtdel_SNHP()
        {
            int position = bndOtdel_SNHP.Position;
            try
            {
                bndOtdel_SNHP.EndEdit();
                adpOtdel_SNHP.Update(dsDB.Otdel_SNHP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndOtdel_SNHP.ResetBindings(false);
            }
            finally
            {
                //dsDB.Tables["Otdel"].AcceptChanges();
                //adpOtdel.Fill(dsDB.Otdel);

                bndOtdel_SNHP.Position = position;
            }
        }

        public static void CancelOtdel_SNHP()
        {
            int position = bndOtdel_SNHP.Position;

            bndOtdel_SNHP.CancelEdit();
            bndOtdel_SNHP.ResetBindings(false);

            bndOtdel_SNHP.Position = position;
        }

        public static object AddOtdel_SNHP()
        {
            return bndOtdel_SNHP.AddNew();
        }

        public static void DeleteOtdel_SNHP()
        {
            DataRowView rw = bndOtdel_SNHP.Current as DataRowView;
            string NameDelete = rw.Row["ИмяКО"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r \n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bndOtdel_SNHP.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion Otdel_SNHP
        #endregion Update-Delete

        #region DRAG
        public static void AddDocumentToDB(List<string> listFolderDBPath)
        {
            foreach (string file in listFolderDBPath)
            {
                string path = file;
                string name = Path.GetFileNameWithoutExtension(file);
                DateTime date = File.GetLastWriteTime(file);

                AddDoc();
                ((DataRowView)bndDocument.Current).Row["NameDoc"] = name;
                ((DataRowView)bndDocument.Current).Row["DataDoc"] = date;
                ((DataRowView)bndDocument.Current).Row["PathDoc"] = path;
            }

            SaveDoc();
        }

        public static void AddDocDragDrop(List<string> ListFiles, string el, BindingSource bnd, int Group)
        {
                
            foreach (string file in ListFiles)
            {
                string path = el;
                string name = Path.GetFileNameWithoutExtension(el);
                DateTime date = File.GetLastWriteTime(el);
           
                AddDoc();
                ((DataRowView)bnd.Current).Row["NameDoc"] = name;
                ((DataRowView)bnd.Current).Row["DataDoc"] = date;
                ((DataRowView)bnd.Current).Row["PathDoc"] = path;
                ((DataRowView)bnd.Current).Row["Doc_Group"] = Group;
                if ((Group == 1) || (Group == 11) || (Group == 12))
                {
                    ((DataRowView)bnd.Current).Row["Control"] = true;
                }

            }

            SaveDoc();

        }

        public static void AddTenderDragDrop(List<string> ListPath, BindingSource bnd, int id)
        {
            String name;
            string date;
            String path;


            foreach (string p in ListPath)
            {
                path = p;
                name = System.IO.Path.GetFileNameWithoutExtension(p);
                date = System.IO.File.GetLastWriteTime(p).ToShortDateString();

                AddDoc();
                ((DataRowView)bnd.Current).Row["NameDoc"] = name;
                ((DataRowView)bnd.Current).Row["DataDoc"] = date;
                ((DataRowView)bnd.Current).Row["PathDoc"] = path;
                ((DataRowView)bnd.Current).Row["Tender_id"] = id;


            }

            SaveDoc();
        }
        #endregion DRAG

        /// <summary>
        /// Устанавливает курсор в таблице на новую (созданную) запись
        /// </summary>
        /// <param name="pos">Позиция до добавления</param>
        /// <param name="newProject">Новый объект сразу после добавления</param>
        /// <param name="bnd">Управляющий BindingSource </param>
        /// <param name="nameField">Имя контрольного столбца</param>
        public static void grid_SetOldPosition(int pos, object newProject, BindingSource bnd, string nameField)
        {
            if (((DataRowView)newProject).Row.RowState != DataRowState.Detached)
            {
                string findID = ((DataRowView)newProject).Row[nameField].ToString();
                if (findID != null)
                    bnd.Position = bnd.Find(nameField, findID);
            }
            else
            {
                bnd.Position = pos;
            }
        }

        public static void Filter_Bnd(string findStr, BindingSource bnd, string field)
        {
            if (findStr != "")
            {
                bnd.Filter = "[" + field + "] Like '%" + findStr + "%'";
            }
            else
            {
                bnd.Filter = "";
            }
        }
    }
}
