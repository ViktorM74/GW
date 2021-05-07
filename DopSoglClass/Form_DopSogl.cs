using System.Windows.Forms;
using DBClass;

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
    }
}
