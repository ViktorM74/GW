using System;
using System.Data;
using System.Windows.Forms;
using DBClass;
using feature_сlass;

namespace CPlan
{
    public partial class Form_CP001 : Form
    {
        public Form_CP001()
        {
            InitializeComponent();

            string idnum = ((DataRowView)DB_Cmd.bndCalendarPlanDD.Current).Row["ID_Kplan"].ToString();

            this.Text = this.Text + " - " + idnum;

            navigatorCP.BindingSource = DB_Cmd.bndCalendarPlanDD;

            tb_num.DataBindings.Add("Text", DB_Cmd.bndCalendarPlanDD, "Num_Etap");
            tb_name.DataBindings.Add("Text", DB_Cmd.bndCalendarPlanDD, "Name_Etap");
            tb_day.DataBindings.Add("Text", DB_Cmd.bndCalendarPlanDD, "Days");
            dtp_nachalo.DataBindings.Add("Text", DB_Cmd.bndCalendarPlanDD, "Nachalo_Data");
            dtp_konec.DataBindings.Add("Text", DB_Cmd.bndCalendarPlanDD, "Konec_Data");
            cb_Status.DataBindings.Add("Text", DB_Cmd.bndCalendarPlanDD, "Status");
            tb_Summ.DataBindings.Add("Text", DB_Cmd.bndCalendarPlanDD, "Summ");
            cb_Valute.DataBindings.Add("Text", DB_Cmd.bndCalendarPlanDD, "V");
            tb_Comments.DataBindings.Add("Text", DB_Cmd.bndCalendarPlanDD, "Comments");
          
            chk_visable_CP.DataBindings.Add("Checked", DB_Cmd.bndCalendarPlanDD, "ViewCPDog", false, DataSourceUpdateMode.OnPropertyChanged);

            cb_DD.DataSource = DB_Cmd.bndDopDogovor; // источник данных
            cb_DD.DisplayMember = "Nambe_DS"; // отображаемое значение
            cb_DD.ValueMember = "DS_ID"; // значение передаваемое в источник данных или привязанный источник
            cb_DD.DataBindings.Add("SelectedValue", DB_Cmd.bndCalendarPlanDD, "ID_DopS"); // привязка к данным таблицы CalendarPlan        
        }

        private void btn_deleteItem_Click(object sender, System.EventArgs e)
        {
            DB_Cmd.DeleteCalendarPlanDD();
            Close();
        }

        private void btn_refreshItem_Click(object sender, System.EventArgs e)
        {
            DB_Cmd.RefreshCPlanDD();
            DB_Cmd.bndCalendarPlanDD.ResetBindings(true);
        }

        private void btn_UpdateItem_Click(object sender, System.EventArgs e)
        {
            //Автозаполнение поля для правильной сортировки Num_sort
            if (DB_Cmd.bndCalendarPlanDD.Count != 0)
                ((DataRowView)DB_Cmd.bndCalendarPlanDD.Current).Row["Num_sort"] = feature.NormalizeNumSort(((DataRowView)DB_Cmd.bndCalendarPlanDD.Current).Row["Num_Etap"].ToString());

            this.Validate();
            DB_Cmd.SaveCalendarPlanDD();
            Close();
        }

        private void btn_addItem_Click(object sender, System.EventArgs e)
        {
            //DB_Cmd.SaveCalendarPlanDD();
            this.Validate();
            DB_Cmd.AddCalendarPlanDD();
        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            DB_Cmd.CancelCalendarPlanDD();
            Close();
        }

        private void tb_Summ_KeyPress(object sender, KeyPressEventArgs e)
        {
            feature.TextIsDigitOnly(sender, e);
        }

        private void tb_day_KeyPress(object sender, KeyPressEventArgs e)
        {
            feature.TextIsDigitOnly(sender, e);
        }

        private void tb_Summ_TextChanged_1(object sender, EventArgs e)
        {
            feature.TextBoxCurrency(tb_Summ);
        }

        private void tb_Summ_Leave(object sender, EventArgs e)
        {
            feature.TextBoxCurrency(tb_Summ);
        }

        private void Form_CP001_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB_Cmd.CancelCalendarPlanDD();
        }
    }
}
