using System;
using System.Windows.Forms;
using DBClass;

namespace ProjectClass
{
    public partial class Form_Project : Form
    {
        public Form_Project()
        {
            InitializeComponent();
            //MessageBox.Show(Convert.ToString( ((DataRowView)bProject.Current).Row["Code_object"]));
            SetBinding();
        }

        public void SetBinding()
        {
            tb_Code.DataBindings.Add("Text", DB_Cmd.bndProject, "Code_object");
            tb_pName.DataBindings.Add("Text", DB_Cmd.bndProject, "Name");
            tb_pNotes.DataBindings.Add("Text", DB_Cmd.bndProject, "Notes");
            tb_linkLocalFld.DataBindings.Add("Text", DB_Cmd.bndProject, "Path_folder");
            tb_linkServerFld.DataBindings.Add("Text", DB_Cmd.bndProject, "Path_server");

            cb_Status.DataBindings.Add("Text", DB_Cmd.bndProject, "Status");

            cbStroy.DataSource = DB_Cmd.bndAreaStroy; // источник данных
            cbStroy.DisplayMember = "NameCust"; // отображаемое значение
            cbStroy.ValueMember = "IDCustomer"; // значение передаваемое в источник данных или привязанный источник
            cbStroy.DataBindings.Add("SelectedValue", DB_Cmd.bndProject, "AreaStroy_ID"); // привязка к данным таблицы User
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string SetFolder()
        {
            string fld = "";
            FolderBrowserDialog openDialog1 = new FolderBrowserDialog();
            if (openDialog1.ShowDialog() == DialogResult.OK)
            {   // получаем выбранный файл
                fld = openDialog1.SelectedPath;
            }
            return fld;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_linkLocalFld.Text = SetFolder();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_linkServerFld.Text = SetFolder();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            DB_Cmd.SaveProject();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
            Close();
        }

        private void Cancel()
        {
            this.Validate();
            DB_Cmd.CancelProject();

        }

        private void Form_Project_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cancel();
        }
    }
}
