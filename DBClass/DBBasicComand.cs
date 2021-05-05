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

      
        #region Project
        public static bool SaveProject(BindingSource bnd)
        {
            int position = bnd.Position;
            string tableName = bnd.DataMember;
            try
            {
                bnd.EndEdit();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpProject.Update(dsDB.Project);
                dsDB.Tables["Project"].AcceptChanges();
                adpProject.Fill(dsDB.Project);

                bnd.Position = position;
            }

            return false;
        }

        public static void CancelProject(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpProject.Update(dsDB.Project);
            dsDB.Tables["Project"].AcceptChanges();
            adpProject.Fill(dsDB.Project);

            bnd.Position = position;
        }

        public static void AddProject(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteProject(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Name"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    string exMessage = ex.Message.ToString();
                    MessageBox.Show("Удаление вызвало ошибку: " + exMessage, "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion

        #region Document

        public static void SaveDoc(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpDocument.Update(dsDB.Documents);
                dsDB.Tables["Documents"].AcceptChanges();
                adpDocument.Fill(dsDB.Documents);

                bnd.Position = position;
            }
        }

        public static void CancelDoc(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpDocument.Update(dsDB.Documents);
            dsDB.Tables["Documents"].AcceptChanges();
            adpDocument.Fill(dsDB.Documents);

            bnd.Position = position;
        }

        public static void AddDoc(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteDoc(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Namedoc"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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

        public static void SaveTypeDoc(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpTypeDocument.Update(dsDB.Documets_type);
                dsDB.Tables["Documets_type"].AcceptChanges();
                adpTypeDocument.Fill(dsDB.Documets_type);

                bnd.Position = position;
            }
        }

        public static void CancelTypeDoc(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpTypeDocument.Update(dsDB.Documets_type);
            dsDB.Tables["Documets_type"].AcceptChanges();
            adpTypeDocument.Fill(dsDB.Documets_type);

            bnd.Position = position;
        }

        public static void AddTypeDoc(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteTypeDoc(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Name_doc"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveDogovor(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpDogovor.Update(dsDB.Dogovor);
                dsDB.Tables["Dogovor"].AcceptChanges();
                adpDogovor.Fill(dsDB.Dogovor);

                bnd.Position = position;
            }
        }

        public static void CancelDogovor(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpDogovor.Update(dsDB.Dogovor);
            dsDB.Tables["Dogovor"].AcceptChanges();
            adpDogovor.Fill(dsDB.Dogovor);

            bnd.Position = position;
        }

        public static void AddDogovor(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteDogovor(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Nambe_Dog"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveTender(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpTender.Update(dsDB.Tender);
                dsDB.Tables["Tender"].AcceptChanges();
                adpTender.Fill(dsDB.Tender);

                bnd.Position = position;
            }
        }

        public static void CancelTender(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpTender.Update(dsDB.Tender);
            dsDB.Tables["Tender"].AcceptChanges();
            adpTender.Fill(dsDB.Tender);

            bnd.Position = position;
        }

        public static void AddTender(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteTender(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Name_Tender"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveCalendarPlan(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpCPlan.Update(dsDB.CalendarPlan);
                dsDB.Tables["CalendarPlan"].AcceptChanges();
                adpCPlan.Fill(dsDB.CalendarPlan);

                bnd.Position = position;
            }
        }

        public static void CancelCalendarPlan(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpCPlan.Update(dsDB.CalendarPlan);
            dsDB.Tables["CalendarPlan"].AcceptChanges();
            adpCPlan.Fill(dsDB.CalendarPlan);

            bnd.Position = position;
        }

        public static void AddCalendarPlan(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteCalendarPlan(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Name_Etap"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveDopSoglashenia(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpDDogovor.Update(dsDB.DopSoglashenia);
                dsDB.Tables["DopSoglashenia"].AcceptChanges();
                adpDDogovor.Fill(dsDB.DopSoglashenia);

                bnd.Position = position;
            }
        }

        public static void CancelDopSoglashenia(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpDDogovor.Update(dsDB.DopSoglashenia);
            dsDB.Tables["DopSoglashenia"].AcceptChanges();
            adpDDogovor.Fill(dsDB.DopSoglashenia);

            bnd.Position = position;
        }

        public static void AddDopSoglashenia(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteDopSoglashenia(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Nambe_DS"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveEvents(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpEvent.Update(dsDB.Events);
                dsDB.Tables["Events"].AcceptChanges();
                adpEvent.Fill(dsDB.Events);

                bnd.Position = position;
            }
        }

        public static void CancelEvents(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpEvent.Update(dsDB.Events);
            dsDB.Tables["Events"].AcceptChanges();
            adpEvent.Fill(dsDB.Events);

            bnd.Position = position;
        }

        public static void AddEvents(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteEvents(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Событие"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveStady_project(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpStadyPrj.Update(dsDB.Stady_project);
                dsDB.Tables["Stady_project"].AcceptChanges();
                adpStadyPrj.Fill(dsDB.Stady_project);

                bnd.Position = position;
            }
        }

        public static void CancelStady_project(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpStadyPrj.Update(dsDB.Stady_project);
            dsDB.Tables["Stady_project"].AcceptChanges();
            adpStadyPrj.Fill(dsDB.Stady_project);

            bnd.Position = position;
        }

        public static void AddStady_project(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteStady_project(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Расшифровка"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveAct(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpAct.Update(dsDB.Act);
                dsDB.Tables["Act"].AcceptChanges();
                adpAct.Fill(dsDB.Act);

                bnd.Position = position;
            }
        }

        public static void CancelAct(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpAct.Update(dsDB.Act);
            dsDB.Tables["Act"].AcceptChanges();
            adpAct.Fill(dsDB.Act);

            bnd.Position = position;
        }

        public static void AddAct(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteAct(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Nambe_Act"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveOBJECTS(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpObject.Update(dsDB.OBJECTS);
                dsDB.Tables["OBJECTS"].AcceptChanges();
                adpObject.Fill(dsDB.OBJECTS);

                bnd.Position = position;
            }
        }

        public static void CancelOBJECTS(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpObject.Update(dsDB.OBJECTS);
            dsDB.Tables["OBJECTS"].AcceptChanges();
            adpObject.Fill(dsDB.OBJECTS);

            bnd.Position = position;
        }

        public static void AddOBJECTS(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteOBJECTS(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Name_object"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveSostavDoc(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpSostavD.Update(dsDB.SostavDoc);
                dsDB.Tables["SostavDoc"].AcceptChanges();
                adpSostavD.Fill(dsDB.SostavDoc);

                bnd.Position = position;
            }
        }

        public static void CancelSostavDoc(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpSostavD.Update(dsDB.SostavDoc);
            dsDB.Tables["SostavDoc"].AcceptChanges();
            adpSostavD.Fill(dsDB.SostavDoc);

            bnd.Position = position;
        }

        public static void AddSostavDoc(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteSostavDoc(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Mark"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveMark_project(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpMark.Update(dsDB.Mark_project);
                dsDB.Tables["Mark_project"].AcceptChanges();
                adpMark.Fill(dsDB.Mark_project);

                bnd.Position = position;
            }
        }

        public static void CancelMark_project(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpMark.Update(dsDB.Mark_project);
            dsDB.Tables["Mark_project"].AcceptChanges();
            adpMark.Fill(dsDB.Mark_project);

            bnd.Position = position;
        }

        public static void AddMark_project(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteMark_project(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["Марка"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveZadania(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpZadania.Update(dsDB.Zadania);
                dsDB.Tables["Zadania"].AcceptChanges();
                adpZadania.Fill(dsDB.Zadania);

                bnd.Position = position;
            }
        }

        public static void CancelZadania(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpZadania.Update(dsDB.Zadania);
            dsDB.Tables["Zadania"].AcceptChanges();
            adpZadania.Fill(dsDB.Zadania);

            bnd.Position = position;
        }

        public static void AddZadania(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteZadania(BindingSource bnd)
        {
            //DataRowView rw = bnd.Current as DataRowView;
            //string NameDelete = rw.Row["Коментарий"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + "" + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveHistory(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpHistory.Update(dsDB.History);
                dsDB.Tables["History"].AcceptChanges();
                adpHistory.Fill(dsDB.History);

                bnd.Position = position;
            }
        }

        public static void CancelHistory(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpHistory.Update(dsDB.History);
            dsDB.Tables["History"].AcceptChanges();
            adpHistory.Fill(dsDB.History);

            bnd.Position = position;
        }

        public static void AddHistory(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteHistory(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["EvHist"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
        public static void SaveOtdel(BindingSource bnd)
        {
            int position = bnd.Position;
            try
            {
                bnd.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранение вызвало ошибку: " + ex.Message);
                bnd.ResetBindings(false);
            }
            finally
            {
                adpOtdel.Update(dsDB.Otdel);
                dsDB.Tables["Otdel"].AcceptChanges();
                adpOtdel.Fill(dsDB.Otdel);

                bnd.Position = position;
            }
        }

        public static void CancelOtdel(BindingSource bnd)
        {
            int position = bnd.Position;

            bnd.ResetBindings(false);

            adpOtdel.Update(dsDB.Otdel);
            dsDB.Tables["Otdel"].AcceptChanges();
            adpOtdel.Fill(dsDB.Otdel);

            bnd.Position = position;
        }

        public static void AddOtdel(BindingSource bnd)
        {
            bnd.AddNew();
        }

        public static void DeleteOtdel(BindingSource bnd)
        {
            DataRowView rw = bnd.Current as DataRowView;
            string NameDelete = rw.Row["NameOtd"].ToString();
            if (MessageBox.Show("Вы действитель хотите удалить " + NameDelete + "? \r\n ДЕЙСТВИЕ НЕВОЗМОЖНО ОТМЕНИТЬ!", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bnd.RemoveCurrent();
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
           
                AddDoc(bnd);
                ((DataRowView)bnd.Current).Row["NameDoc"] = name;
                ((DataRowView)bnd.Current).Row["DataDoc"] = date;
                ((DataRowView)bnd.Current).Row["PathDoc"] = path;
                ((DataRowView)bnd.Current).Row["Doc_Group"] = Group;
                if ((Group == 1) || (Group == 11) || (Group == 12))
                {
                    ((DataRowView)bnd.Current).Row["Control"] = true;
                }

            }

            SaveDoc(bnd);

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

                AddDoc(bnd);
                ((DataRowView)bnd.Current).Row["NameDoc"] = name;
                ((DataRowView)bnd.Current).Row["DataDoc"] = date;
                ((DataRowView)bnd.Current).Row["PathDoc"] = path;
                ((DataRowView)bnd.Current).Row["Tender_id"] = id;


            }

            SaveDoc(bnd);
        }
    }
}
