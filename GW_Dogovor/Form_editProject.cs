using System;
using System.Windows.Forms;

namespace GW_Dogovor
{
    public partial class Form_editProject : Form
    {
        public Form_editProject()
        {
            InitializeComponent();
        }

        public Form_editProject(BindingSource bProject, BindingSource bCust)
        {
            InitializeComponent();
            //MessageBox.Show(Convert.ToString( ((DataRowView)bProject.Current).Row["Code_object"]));
            SetBinding(bProject, bCust);
        }

        public void SetBinding(BindingSource bProject, BindingSource bCust)
        {
            tb_Code.DataBindings.Add("Text", bProject, "Code_object");
            tb_pName.DataBindings.Add("Text", bProject, "Name");
            tb_pNotes.DataBindings.Add("Text", bProject, "Notes");
            tb_linkLocalFld.DataBindings.Add("Text", bProject, "Path_folder");
            tb_linkServerFld.DataBindings.Add("Text", bProject, "Path_server");

            cb_Status.DataBindings.Add("Text", bProject, "Status");

            cbStroy.DataSource = bCust; // источник данных
            cbStroy.DisplayMember = "NameCust"; // отображаемое значение
            cbStroy.ValueMember = "IDCustomer"; // значение передаваемое в источник данных или привязанный источник
            cbStroy.DataBindings.Add("SelectedValue", bProject, "AreaStroy_ID"); // привязка к данным таблицы User
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_main.AddProject();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Form_main.DeleteProject();
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
    }
}
