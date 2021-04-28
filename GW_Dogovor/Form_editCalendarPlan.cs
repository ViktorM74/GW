using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBClass;

namespace GW_Dogovor
{
    public partial class Form_editCalendarPlan : Form
    {
        BindingSource bndCPlan = new BindingSource();
        public Form_editCalendarPlan(BindingSource bndCP)
        {
            InitializeComponent();

            bndCPlan = bndCP;

            bndNavigator_edit_CPlan.BindingSource = bndCPlan;

            dgv_edit_CPlan.AutoGenerateColumns = false;
            dgv_edit_CPlan.DataSource = bndCPlan;
            dgv_edit_CPlan.Columns["Num_Etap"].DataPropertyName = "Num_Etap";
            dgv_edit_CPlan.Columns["Name_Etap"].DataPropertyName = "Name_Etap";
            dgv_edit_CPlan.Columns["Nachalo_Data"].DataPropertyName = "Nachalo_Data";
            dgv_edit_CPlan.Columns["Konec_Data"].DataPropertyName = "Konec_Data";
            dgv_edit_CPlan.Columns["Summ"].DataPropertyName = "Summ";
            dgv_edit_CPlan.Columns["Valute"].DataPropertyName = "V";
            dgv_edit_CPlan.Columns["StatusCPlan"].DataPropertyName = "Status";

            tb_Num_Etap.DataBindings.Add("Text", bndCPlan, "Num_Etap");
            tb_Days.DataBindings.Add("Text", bndCPlan, "Days");
            dp_Nachalo_Data.DataBindings.Add("Text", bndCPlan, "Nachalo_Data");
            dp_Konec_Data.DataBindings.Add("Text", bndCPlan, "Konec_Data");
            tb_Summ.DataBindings.Add("Text", bndCPlan, "Summ");
            cb_Valute.DataBindings.Add("Text", bndCPlan, "V");
            cb_Status.DataBindings.Add("Text", bndCPlan, "Status");
            chb_Begin.DataBindings.Add("Checked", bndCPlan, "Begin");
            tb_Name_Etap.DataBindings.Add("Text", bndCPlan, "Name_Etap");
            tb_Comments.DataBindings.Add("Text", bndCPlan, "Comments");

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DB_Cmd.AddCalendarPlan(bndCPlan);
            DB_Cmd.SaveCalendarPlan(bndCPlan);
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DB_Cmd.DeleteCalendarPlan(bndCPlan);
            DB_Cmd.SaveCalendarPlan(bndCPlan);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DB_Cmd.SaveCalendarPlan(bndCPlan);
        }
    }
}
