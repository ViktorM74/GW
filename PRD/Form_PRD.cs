using System;
using System.Data;
using System.Windows.Forms;
using DBClass;

namespace PRD
{
    public partial class Form_PRD : Form
    {
        bool dateGipSet = false;
        bool dateArhivSet = false;
        public Form_PRD()
        {
            InitializeComponent();

            tb_Mark.DataBindings.Add("Text", DB_Cmd.bndSostavObj, "Mark");
            dtp_Data_plan.DataBindings.Add("Text", DB_Cmd.bndSostavObj, "Data_plan");
            tb_Notes.DataBindings.Add("Text", DB_Cmd.bndSostavObj, "Notes");
            chb_GIP_viz.DataBindings.Add("Checked", DB_Cmd.bndSostavObj, "GIP_viz");
            chb_Arhiv.DataBindings.Add("Checked", DB_Cmd.bndSostavObj, "Arhiv");
            dtp_Data_GIP_viz.DataBindings.Add("Text", DB_Cmd.bndSostavObj, "Data_GIP_viz");
            dtp_Data_fakt.DataBindings.Add("Text", DB_Cmd.bndSostavObj, "Data_fakt");
            tb_blok.DataBindings.Add("Text", DB_Cmd.bndSostavObj, "Block");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (chb_GIP_viz.Checked)
            {
                if (!dateGipSet)
                    ((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_GIP_viz"] = DateTime.Today;
                else
                    ((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_GIP_viz"] = dtp_Data_GIP_viz.Value;
            }
            else
                ((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_GIP_viz"] = DBNull.Value;

            if (chb_Arhiv.Checked)
            {
                if (!dateArhivSet)
                    ((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_fakt"] = DateTime.Today;
                else
                    ((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_fakt"] = dtp_Data_fakt.Value;
            }

            else
                ((DataRowView)DB_Cmd.bndSostavObj.Current).Row["Data_fakt"] = DBNull.Value;


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
            dateGipSet = true;
        }

        private void dtp_Data_fakt_CloseUp(object sender, EventArgs e)
        {
            chb_Arhiv.Checked = true;
            dateArhivSet = true;
        }
    }
}
