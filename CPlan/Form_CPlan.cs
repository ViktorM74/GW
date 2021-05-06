using System;
using System.Windows.Forms;
using DBClass;

namespace CPlan
{
    public partial class Form_CPlan : Form
    {
       
        public Form_CPlan()
        {
            InitializeComponent();

            bndNavigator_edit_CPlan.BindingSource = DB_Cmd.bndCalendarPlan;

            dgv_edit_CPlan.AutoGenerateColumns = false;
            dgv_edit_CPlan.DataSource = DB_Cmd.bndCalendarPlan;
            dgv_edit_CPlan.Columns["Num_Etap"].DataPropertyName = "Num_Etap";
            dgv_edit_CPlan.Columns["Name_Etap"].DataPropertyName = "Name_Etap";
            dgv_edit_CPlan.Columns["Nachalo_Data"].DataPropertyName = "Nachalo_Data";
            dgv_edit_CPlan.Columns["Konec_Data"].DataPropertyName = "Konec_Data";
            dgv_edit_CPlan.Columns["Summ"].DataPropertyName = "Summ";
            dgv_edit_CPlan.Columns["Valute"].DataPropertyName = "V";
            dgv_edit_CPlan.Columns["StatusCPlan"].DataPropertyName = "Status";

            tb_Num_Etap.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Num_Etap");
            tb_Days.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Days");
            dp_Nachalo_Data.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Nachalo_Data");
            dp_Konec_Data.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Konec_Data");
            tb_Summ.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Summ");
            cb_Valute.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "V");
            cb_Status.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Status");
            chb_Begin.DataBindings.Add("Checked", DB_Cmd.bndCalendarPlan, "Begin");
            tb_Name_Etap.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Name_Etap");
            tb_Comments.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Comments");

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DB_Cmd.AddCalendarPlan(DB_Cmd.bndCalendarPlan);
            DB_Cmd.SaveCalendarPlan(DB_Cmd.bndCalendarPlan);
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DB_Cmd.DeleteCalendarPlan(DB_Cmd.bndCalendarPlan);
            DB_Cmd.SaveCalendarPlan(DB_Cmd.bndCalendarPlan);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DB_Cmd.SaveCalendarPlan(DB_Cmd.bndCalendarPlan);
        }
    }
}
