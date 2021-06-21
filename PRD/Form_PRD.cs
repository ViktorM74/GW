﻿using System;
using System.Data;
using System.Windows.Forms;
using DBClass;
using DateTimePickerNullable;

namespace PRD
{   
    public partial class Form_PRD : Form
    {
        public Form_PRD()
        {
            InitializeComponent();

            tb_Mark.DataBindings.Add("Text", DB_Cmd.bndSostavObj, "Mark");
            tb_Notes.DataBindings.Add("Text", DB_Cmd.bndSostavObj, "Notes");
            chb_GIP_viz.DataBindings.Add("Checked", DB_Cmd.bndSostavObj, "GIP_viz", true, DataSourceUpdateMode.OnPropertyChanged);
            chb_Arhiv.DataBindings.Add("Checked", DB_Cmd.bndSostavObj, "Arhiv", true, DataSourceUpdateMode.OnPropertyChanged);

            //dtp_Data_plan.DataBindings.Add("NulableValue", DB_Cmd.bndSostavObj, "Data_plan", false, DataSourceUpdateMode.OnPropertyChanged, "");
            dtp_Data_plan.DataBindings.Add("NullableValue", DB_Cmd.bndSostavObj, "Data_plan", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            dtp_Data_plan.Format = DateTimePickerFormat.Custom;
            dtp_Data_plan.NullableValue = null;
            dtp_Data_plan.OriginalValue = null;
           
            dtp_Data_GIP_viz.DataBindings.Add("NullableValue", DB_Cmd.bndSostavObj, "Data_GIP_viz", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            dtp_Data_GIP_viz.Format = DateTimePickerFormat.Custom;
            dtp_Data_GIP_viz.NullableValue = null;
            dtp_Data_GIP_viz.OriginalValue = null;

            dtp_Data_fakt.DataBindings.Add("NullableValue", DB_Cmd.bndSostavObj, "Data_fakt", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            dtp_Data_fakt.Format = DateTimePickerFormat.Custom;
            dtp_Data_fakt.NullableValue = null;
            dtp_Data_fakt.OriginalValue = null;

            cb_blok.Items.AddRange(DB_Cmd.GetListValueFields(DB_Cmd.bndSostavObj, "Block").ToArray());
            //cb_blok.DisplayMember = "Block";
            //cb_blok.ValueMember = "Block";
            cb_blok.DataBindings.Add("Text", DB_Cmd.bndSostavObj, "Block");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (chb_GIP_viz.Checked)
            {
                //if (!dateGipSet) // true если User выбрал дату из календаря
                if (dtp_Data_GIP_viz.NullableValue == null)
                    //dtp_Data_GIP_viz.Value = DateTime.Today;
                    //((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_GIP_viz"] = DateTime.Today;
                    dtp_Data_GIP_viz.NullableValue = DateTime.Today;
                //else
                //    ((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_GIP_viz"] = dtp_Data_GIP_viz.Value;
            }
            else
                //((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_GIP_viz"] = DBNull.Value;
                dtp_Data_GIP_viz.NullableValue = null;

            if (chb_Arhiv.Checked)
            {
                if (dtp_Data_fakt.NullableValue == null)
                    //((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_fakt"] = DateTime.Today;
                    dtp_Data_fakt.NullableValue = DateTime.Today;
                //else
                //    //((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_fakt"] = dtp_Data_fakt.Value;
                //    dtp_Data_fakt.NullableValue = 
            }
            else
                //((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_fakt"] = DBNull.Value;
                dtp_Data_fakt.NullableValue = null;




            DB_Cmd.SaveSostavObj();
           
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DB_Cmd.CancelSostavObj();
            Close();
        }

        private void NullDate(DateTimePicker chb)
        {
            // Use ValueChanged to decide if the value should be displayed:
            chb.ValueChanged += (s, e) => { chb.CustomFormat = (chb.Checked && chb.Value != chb.MinDate) ? "MM/dd/yyyy" : " "; };

            //When getting the value back out, use something like the following:
            DateTime? dt = (chb.Checked && chb.Value != chb.MinDate) ? (DateTime?)chb.Value : null;
            // or
            DateTime dt2 = (chb.Checked && chb.Value != chb.MinDate) ? chb.Value : DateTime.MinValue;
        }


        private void dtp_Data_GIP_viz_CloseUp(object sender, EventArgs e)
        {
            chb_GIP_viz.Checked = true;
           
        }

        private void dtp_Data_fakt_CloseUp(object sender, EventArgs e)
        {
            chb_Arhiv.Checked = true;
           
        }

        private void dtp_Data_plan_ValueChanged(object sender, EventArgs e)
        {
            DateIsNullControl(sender, e, "Data_plan");

        }
        private void dtp_Data_GIP_viz_ValueChanged(object sender, EventArgs e)
        {
            DateIsNullControl(sender, e, "Data_GIP_viz");
        }
        private void dtp_Data_fakt_ValueChanged(object sender, EventArgs e)
        {
            DateIsNullControl(sender, e, "Data_fakt");
        }


        private static void DateIsNullControl(object sender, EventArgs e, string field)
        {
                //if (DB_Cmd.GetCurrentValueField(DB_Cmd.bndSostavObj, field) == DBNull.Value)
                //if (((DateTimePicker)sender).Value == DateTime.MinValue)
                //{
                //    ((DateTimePicker)sender).CustomFormat = " ";
                //    ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
                //}
                //else
                //{
                //    ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
                //}
        }

    }
}
