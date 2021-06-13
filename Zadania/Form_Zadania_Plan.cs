using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DBClass;


namespace Zadania
{
    public partial class Form_Zadania_Plan : Form
    {
        public Form_Zadania_Plan()
        {
            InitializeComponent();

            List<string> combo_list = new List<string>();

            DataView dw1 = DB_Cmd.dsDB.Tables["Otdel_SNHP"].DefaultView;

            //foreach (DataRowView r in DB_Cmd.bndOtdel_SNHP)
            //{
            //    combo_list.Add(r.Row[1].ToString() + " - " + r.Row[2].ToString());
            //}
            //cb_otdel_V.DataSource = combo_list;
            //cb_otdel_V.DataBindings.Add("SelectedValue", DB_Cmd.bndZadania, "Otdel_id_out");

            cb_otdel_V.DataSource = dw1.ToTable();
            cb_otdel_V.DisplayMember = "FullName";
            cb_otdel_V.ValueMember = "Abbreviation";
            cb_otdel_V.DataBindings.Add("SelectedValue", DB_Cmd.bndZadania, "Otdel_id_out");

            cb_otdel_P.DataSource = dw1.ToTable();
            cb_otdel_P.DisplayMember = "FullName";
            cb_otdel_P.ValueMember = "Abbreviation";
            cb_otdel_P.DataBindings.Add("SelectedValue", DB_Cmd.bndZadania, "Otdel_id_in");

            dtp_date_plan.DataBindings.Add("Text", DB_Cmd.bndZadania, "Date_graf");
            dtp_date_fakt.DataBindings.Add("Text", DB_Cmd.bndZadania, "Date_fact");

            tb_comments.DataBindings.Add("Text", DB_Cmd.bndZadania, "Coments");

            cb_blok.Items.AddRange(DB_Cmd.GetListValueFields(DB_Cmd.bndZadania, "Blok").ToArray());
            //cb_blok.DisplayMember = "Blok";
            //cb_blok.ValueMember = "Blok";
            cb_blok.DataBindings.Add("Text", DB_Cmd.bndZadania, "Blok");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DB_Cmd.SaveZadania();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DB_Cmd.CancelZadania();
        }
    }
}
