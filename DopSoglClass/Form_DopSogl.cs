using System.Data;
using System.Windows.Forms;
using DBClass;
using feature_сlass;

namespace DopSoglClass
{
    public partial class Form_DopSogl : Form
    {
        public Form_DopSogl()
        {
            InitializeComponent();

            tb_NumDD.DataBindings.Add("Text", DB_Cmd.bndDopDogovor, "Nambe_DS");
            dtp_DateDD.DataBindings.Add("Text", DB_Cmd.bndDopDogovor, "DataPodp");
            cb_StatusDD.DataBindings.Add("Text", DB_Cmd.bndDopDogovor, "Status");
            dtp_ToDateDD.DataBindings.Add("Text", DB_Cmd.bndDopDogovor, "Data_Konec");
            tb_NotesDD.DataBindings.Add("Text", DB_Cmd.bndDopDogovor, "Comments");
        }

        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            if (DB_Cmd.bndDopDogovor.Count != 0)
                ((DataRowView)DB_Cmd.bndDopDogovor.Current).Row["Nambe_DS"] = feature.NormalizeNumSort(((DataRowView)DB_Cmd.bndDopDogovor.Current).Row["Nambe_DS"].ToString());

            this.Validate();
            DB_Cmd.SaveDopSoglashenia();

        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            DB_Cmd.CancelDopSoglashenia();
        }
    }
}
