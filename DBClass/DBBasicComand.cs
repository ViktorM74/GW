using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBClass._bsp_snhpDataSetTableAdapters;

namespace DBClass
{
    public class DB_Cmd
    {
        public static _bsp_snhpDataSet dsDB = new _bsp_snhpDataSet();
        public static TableAdapterManager tableManager = new TableAdapterManager();
        #region TableAdapters
        public static ProjectTableAdapter adpProject = new ProjectTableAdapter();
        public static CustomersTableAdapter adpCustomer = new CustomersTableAdapter();
        public static DocumentsTableAdapter adpDocument = new DocumentsTableAdapter();
        public static Documets_typeTableAdapter adpTypeDocument = new Documets_typeTableAdapter();
        public static DogovorTableAdapter adpDogovor = new DogovorTableAdapter();
        public static TenderTableAdapter adpTender = new TenderTableAdapter();
        public static CalendarPlanTableAdapter adpCPlan = new CalendarPlanTableAdapter();
        public static DopSoglasheniaTableAdapter adpDDogovor = new DopSoglasheniaTableAdapter();
        public static EventsTableAdapter adpEvent = new EventsTableAdapter();
        public static Stady_projectTableAdapter adpStadyPrj = new Stady_projectTableAdapter();
        public static ActTableAdapter adpAct = new ActTableAdapter();
        public static OBJECTSTableAdapter adpObject = new OBJECTSTableAdapter();
        public static SostavDocTableAdapter adpSostavD = new SostavDocTableAdapter();
        public static Mark_projectTableAdapter adpMark = new Mark_projectTableAdapter();
        public static ZadaniaTableAdapter adpZadania = new ZadaniaTableAdapter();
        public static HistoryTableAdapter adpHistory = new HistoryTableAdapter();
        public static OtdelTableAdapter adpOtdel = new OtdelTableAdapter();
        public static Users_GIPTableAdapter adpGIP = new Users_GIPTableAdapter();
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
        public static BindingSource bndDopDogovor = new BindingSource();
        public static BindingSource bndObject = new BindingSource();
        public static BindingSource bndAct = new BindingSource();
        public static BindingSource bndSostavObj = new BindingSource();
        public static BindingSource bndZadania = new BindingSource();
        public static BindingSource bndEvents = new BindingSource();
        public static BindingSource bndMark = new BindingSource();
        public static BindingSource bndHistory = new BindingSource();
        public static BindingSource bndOtdel = new BindingSource();
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

        private static void InitializeBindingSources()
        {

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

            //Events
            bndEvents.DataSource = bndObject;
            bndEvents.DataMember = "OBJECTSEvents";

            //MarkProject
            bndMark.DataSource = DB_Cmd.dsDB;
            bndMark.DataMember = "Mark_project";

            //History
            bndHistory.DataSource = DB_Cmd.dsDB;
            bndHistory.DataMember = "History";

            //Otdel
            bndOtdel.DataSource = DB_Cmd.dsDB;
            bndOtdel.DataMember = "Otdel";

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
            tableManager.TenderTableAdapter = adpTender;
            tableManager.DogovorTableAdapter = adpDogovor;
            tableManager.DopSoglasheniaTableAdapter = adpDDogovor;
            tableManager.CalendarPlanTableAdapter = adpCPlan;
            tableManager.ActTableAdapter = adpAct;
            tableManager.OBJECTSTableAdapter = adpObject;
            tableManager.SostavDocTableAdapter = adpSostavD;
            tableManager.ZadaniaTableAdapter = adpZadania;
            tableManager.HistoryTableAdapter = adpHistory;
            tableManager.EventsTableAdapter = adpEvent;

            tableManager.BackupDataSetBeforeUpdate = true;
            tableManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
        }

        public string GetCurrentValueField(BindingSource bnd, string Name)
        {
            return ((DataRowView)bnd.Current).Row[Name].ToString();
        }
        
       
        #region Project

        public static bool SaveProject()
        {
            int position = bndProject.Position;
           
            try
            {
                bndProject.EndEdit();
                adpProject.Update(dsDB.Project);
                dsDB.Tables["Project"].AcceptChanges();
                adpProject.Fill(dsDB.Project);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                //bndProject.ResetBindings(false);
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

            //bndProject.ResetBindings(false);

            adpProject.Update(dsDB.Project);
            dsDB.Tables["Project"].AcceptChanges();
            adpProject.Fill(dsDB.Project);

            bndProject.Position = position;
        }

        public static void AddProject()
        {
            bndProject.AddNew();
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
        public static void SaveDogovor()
        {
            int position = bndDogovor.Position;
            try
            {
                bndDogovor.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndDogovor.ResetBindings(false);
            }
            finally
            {
                adpDogovor.Update(dsDB.Dogovor);
                dsDB.Tables["Dogovor"].AcceptChanges();
                adpDogovor.Fill(dsDB.Dogovor);

                bndDogovor.Position = position;
            }
        }

        public static void CancelDogovor()
        {
            int position = bndDogovor.Position;

            bndDogovor.ResetBindings(false);

            adpDogovor.Update(dsDB.Dogovor);
            dsDB.Tables["Dogovor"].AcceptChanges();
            adpDogovor.Fill(dsDB.Dogovor);

            bndDogovor.Position = position;
        }

        public static void AddDogovor()
        {
            if (DB_Cmd.bndTender.Count != 0)
            {
                bndDogovor.AddNew();
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["IDCust"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["IDCust"];
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["Name_Dog"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["Name_Tender"];
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["IDGip"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["GIP"];
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["id_Tender"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["ID_Teder"];
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["IDStady"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["IDStadia"];
                ((DataRowView)DB_Cmd.bndDogovor.Current).Row["Sostav"] = ((DataRowView)DB_Cmd.bndTender.Current).Row["Sostav"];
            }
            else
            {
                MessageBox.Show("Для создания договора требуется активная запись 'Тендер'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                //bndTender.ResetBindings(false);
            }
            finally
            {
                adpTender.Update(dsDB.Tender);
                dsDB.Tables["Tender"].AcceptChanges();
                adpTender.Fill(dsDB.Tender);

                bndTender.Position = position;
            }
        }

        public static void CancelTender()
        {
            int position = bndTender.Position;

            //bndTender.ResetBindings(false);

            adpTender.Update(dsDB.Tender);
            dsDB.Tables["Tender"].AcceptChanges();
            adpTender.Fill(dsDB.Tender);

            bndTender.Position = position;
        }
        
        public static void AddTender()
        {
            bndTender.AddNew();
            ((DataRowView)bndTender.Current).Row["IDCust"] = ((DataRowView)bndProject.Current).Row["AreaStroy_ID"];
            ((DataRowView)bndTender.Current).Row["Name_Tender"] = ((DataRowView)bndProject.Current).Row["Name"];

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

        #region CalendarPlan
        public static void SaveCalendarPlan()
        {
            int position = bndCalendarPlan.Position;
            try
            {
                bndCalendarPlan.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndCalendarPlan.ResetBindings(false);
            }
            finally
            {
                adpCPlan.Update(dsDB.CalendarPlan);
                dsDB.Tables["CalendarPlan"].AcceptChanges();
                adpCPlan.Fill(dsDB.CalendarPlan);

                bndCalendarPlan.Position = position;
            }
        }

        public static void CancelCalendarPlan()
        {
            int position = bndCalendarPlan.Position;

            bndCalendarPlan.ResetBindings(false);

            adpCPlan.Update(dsDB.CalendarPlan);
            dsDB.Tables["CalendarPlan"].AcceptChanges();
            adpCPlan.Fill(dsDB.CalendarPlan);

            bndCalendarPlan.Position = position;
        }

        public static void AddCalendarPlan()
        {
            if (DB_Cmd.bndDogovor.Count != 0)
            {
                bndCalendarPlan.AddNew();
                //   ((DataRowView)bndCalendarPlan.Current).Row["IDCust"] = ((DataRowView)bndDogovor.Current).Row["IDCust"];
                //    ((DataRowView)bndObject.Current).Row["GIP"] = ((DataRowView)bndDogovor.Current).Row["IDGip"];
                //    ((DataRowView)bndObject.Current).Row["Name_Ustanovka"] = ((DataRowView)bndDogovor.Current).Row["Name_Dog"];

            }
            else
            {
                MessageBox.Show("Для создания объекта требуется активная запись 'Договор'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        #endregion

        #region DopSoglashenia
        public static void SaveDopSoglashenia()
        {
            int position = bndDopDogovor.Position;
            try
            {
                bndDopDogovor.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndDopDogovor.ResetBindings(false);
            }
            finally
            {
                adpDDogovor.Update(dsDB.DopSoglashenia);
                dsDB.Tables["DopSoglashenia"].AcceptChanges();
                adpDDogovor.Fill(dsDB.DopSoglashenia);

                bndDopDogovor.Position = position;
            }
        }

        public static void CancelDopSoglashenia()
        {
            int position = bndDopDogovor.Position;

            bndDopDogovor.ResetBindings(false);

            adpDDogovor.Update(dsDB.DopSoglashenia);
            dsDB.Tables["DopSoglashenia"].AcceptChanges();
            adpDDogovor.Fill(dsDB.DopSoglashenia);

            bndDopDogovor.Position = position;
        }

        public static void AddDopSoglashenia()
        {
            if (DB_Cmd.bndDogovor.Count != 0)
            {
                bndDopDogovor.AddNew();

                ((DataRowView)DB_Cmd.bndDopDogovor.Current).Row["DogID"] = ((DataRowView)DB_Cmd.bndDogovor.Current).Row["DogID"];

               
            }
            else
            {
                MessageBox.Show("Для создания допсоглашения требуется активная запись 'Договор'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public static void SaveSostavDoc()
        {
            int position = bndSostavObj.Position;
            try
            {
                bndSostavObj.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndSostavObj.ResetBindings(false);
            }
            finally
            {
                adpSostavD.Update(dsDB.SostavDoc);
                dsDB.Tables["SostavDoc"].AcceptChanges();
                adpSostavD.Fill(dsDB.SostavDoc);

                bndSostavObj.Position = position;
            }
        }

        public static void CancelSostavDoc()
        {
            int position = bndSostavObj.Position;

            bndSostavObj.ResetBindings(false);

            adpSostavD.Update(dsDB.SostavDoc);
            dsDB.Tables["SostavDoc"].AcceptChanges();
            adpSostavD.Fill(dsDB.SostavDoc);

            bndSostavObj.Position = position;
        }

        public static void AddSostavDoc()
        {
            bndSostavObj.AddNew();
        }

        public static void DeleteSostavDoc()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndMark.ResetBindings(false);
            }
            finally
            {
                adpMark.Update(dsDB.Mark_project);
                dsDB.Tables["Mark_project"].AcceptChanges();
                adpMark.Fill(dsDB.Mark_project);

                bndMark.Position = position;
            }
        }

        public static void CancelMark_project()
        {
            int position = bndMark.Position;

            bndMark.ResetBindings(false);

            adpMark.Update(dsDB.Mark_project);
            dsDB.Tables["Mark_project"].AcceptChanges();
            adpMark.Fill(dsDB.Mark_project);

            bndMark.Position = position;
        }

        public static void AddMark_project()
        {
            bndMark.AddNew();
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

        #endregion

        #region Zadania
        public static void SaveZadania()
        {
            int position = bndZadania.Position;
            try
            {
                bndZadania.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndZadania.ResetBindings(false);
            }
            finally
            {
                adpZadania.Update(dsDB.Zadania);
                dsDB.Tables["Zadania"].AcceptChanges();
                adpZadania.Fill(dsDB.Zadania);

                bndZadania.Position = position;
            }
        }

        public static void CancelZadania()
        {
            int position = bndZadania.Position;

            bndZadania.ResetBindings(false);

            adpZadania.Update(dsDB.Zadania);
            dsDB.Tables["Zadania"].AcceptChanges();
            adpZadania.Fill(dsDB.Zadania);

            bndZadania.Position = position;
        }

        public static void AddZadania()
        {
            bndZadania.AddNew();
        }

        public static void DeleteZadania()
        {
            //DataRowView rw = bnd.Current as DataRowView;
            //string NameDelete = rw.Row["Коментарий"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + "" + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bndOtdel.ResetBindings(false);
            }
            finally
            {
                adpOtdel.Update(dsDB.Otdel);
                dsDB.Tables["Otdel"].AcceptChanges();
                adpOtdel.Fill(dsDB.Otdel);

                bndOtdel.Position = position;
            }
        }

        public static void CancelOtdel()
        {
            int position = bndOtdel.Position;

            bndOtdel.ResetBindings(false);

            adpOtdel.Update(dsDB.Otdel);
            dsDB.Tables["Otdel"].AcceptChanges();
            adpOtdel.Fill(dsDB.Otdel);

            bndOtdel.Position = position;
        }

        public static void AddOtdel()
        {
            bndOtdel.AddNew();
        }

        public static void DeleteOtdel()
        {
            DataRowView rw = bndOtdel.Current as DataRowView;
            string NameDelete = rw.Row["NameOtd"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        public static void AddDocDragDrop(List<string> ListFiles, string el, BindingSource bnd, int Group)
        {
            String name;
            DateTime date;
            String path;
           
            foreach (string file in ListFiles)
            {
                path = el;
                name = System.IO.Path.GetFileNameWithoutExtension(el);
                date = System.IO.File.GetLastWriteTime(el);
           
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
    }
}
