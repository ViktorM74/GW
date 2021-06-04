using System.Windows.Forms;
using DBClass;

namespace TenderClass
{
    public partial class Form_Tender : Form
    {
        //public Form_Tender()
        //{
        //    InitializeComponent();
        //}

        public Form_Tender()
        {
            InitializeComponent();

            cb_Customer.DataSource = DB_Cmd.bndAreaStroy;
            cb_Customer.DisplayMember = "NameCust";
            cb_Customer.ValueMember = "IDCustomer";
            cb_Customer.DataBindings.Add("SelectedValue", DB_Cmd.bndTender, "IDCust");

            cb_Stadia.DataSource = DB_Cmd.bndStadia;
            cb_Stadia.DisplayMember = "Обозначение";
            cb_Stadia.ValueMember = "StadyID";
            cb_Stadia.DataBindings.Add("SelectedValue", DB_Cmd.bndTender, "IDStadia");

            cb_GIP.DataSource = DB_Cmd.bndGip;
            cb_GIP.DisplayMember = "Family";
            cb_GIP.ValueMember = "UsedID";
            cb_GIP.DataBindings.Add("SelectedValue", DB_Cmd.bndTender, "GIP");

            cb_Status.DataBindings.Add("Text", DB_Cmd.bndTender, "Status");

            tb_Name.DataBindings.Add("Text", DB_Cmd.bndTender, "Name_Tender");
            dtp_Tender.DataBindings.Add("Text", DB_Cmd.bndTender, "Data_End");
            tb_Sostav.DataBindings.Add("Text", DB_Cmd.bndTender, "Sostav");
            tb_Comment.DataBindings.Add("Text", DB_Cmd.bndTender, "Comments");
            tb_pathTender.DataBindings.Add("Text", DB_Cmd.bndTender, "Path");
        }

        private void btn_setPathTender_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog openDialog1 = new FolderBrowserDialog();
            if (tb_pathTender.Text != "")
            {
                openDialog1.SelectedPath = tb_pathTender.Text;
            }
            if (openDialog1.ShowDialog() == DialogResult.OK)
            {   // получаем выбранный каталог
                tb_pathTender.Text = openDialog1.SelectedPath;
            }
        }

        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            DB_Cmd.SaveTender();
        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            DB_Cmd.CancelTender();

        }
    }
}
