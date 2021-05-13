﻿using System;
using System.Data;
using System.Globalization;
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

            string idnum = ((DataRowView)DB_Cmd.bndCalendarPlan.Current).Row["ID_Kplan"].ToString();

            this.Text = this.Text + " - " + idnum;
            navigatorCP.BindingSource = DB_Cmd.bndCalendarPlan;

            tb_num.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Num_Etap");
            tb_name.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Name_Etap");
            tb_day.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Days");
            dtp_nachalo.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Nachalo_Data");
            dtp_konec.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Konec_Data");
            cb_Status.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Status");
            tb_Summ.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Summ");
            cb_Valute.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "V");
            tb_Comments.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Comments");
            lb_Sort.DataBindings.Add("Text", DB_Cmd.bndCalendarPlan, "Num_sort");

            cb_DD.DataSource = DB_Cmd.bndDopDogovor; // источник данных
            cb_DD.DisplayMember = "Nambe_DS"; // отображаемое значение
            cb_DD.ValueMember = "DS_ID"; // значение передаваемое в источник данных или привязанный источник
            cb_DD.DataBindings.Add("SelectedValue", DB_Cmd.bndCalendarPlan, "ID_DopS"); // привязка к данным таблицы CalendarPlan        
        }

        private void btn_deleteItem_Click(object sender, System.EventArgs e)
        {
            DB_Cmd.DeleteCalendarPlan();
            Close();
        }

        private void btn_refreshItem_Click(object sender, System.EventArgs e)
        {
            DB_Cmd.RefreshCPlan();
            DB_Cmd.bndCalendarPlan.ResetBindings(true);
        }

        private void btn_UpdateItem_Click(object sender, System.EventArgs e)
        {
            DB_Cmd.SaveCalendarPlan();
            Close();
        }

        private void btn_addItem_Click(object sender, System.EventArgs e)
        {
            DB_Cmd.SaveCalendarPlan();
            DB_Cmd.AddCalendarPlan();
        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            DB_Cmd.CancelCalendarPlan();
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
    }
}