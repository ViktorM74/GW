using DBClass;
using DBClass._bsp_snhpDataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace DocTYPELibrary
{
    public partial class Lib_doc_type : Form
    {
        //static _bsp_snhpDataSet ds = new _bsp_snhpDataSet();
        //static Documets_typeTableAdapter adapterTypeDoc = new Documets_typeTableAdapter();

        BindingSource bndTypeDoc = new BindingSource();

        public Lib_doc_type()
        {
            InitializeComponent();

            SetView();
        }

        private void SetView()
        {
            bndTypeDoc.DataSource = DB_Cmd.dsDB;
            bndTypeDoc.DataMember = "Documets_type";
            bndTypeDoc.Sort = "Name_doc";

             DB_Cmd.adpTypeDocument.Fill(DB_Cmd.dsDB.Documets_type);

            lb_NameDoc.DataSource = bndTypeDoc;
            lb_NameDoc.DisplayMember = "Name_doc";
            lb_NameDoc.ValueMember = "DOCTypeID";
            //lb_NameDoc.Sorted = true; // не работает если указан DataSource

            tb_Name_doc.DataBindings.Add("Text", bndTypeDoc, "Name_doc");
            tb_Notes.DataBindings.Add("Text", bndTypeDoc, "Notes");
            link_Path_to_template.DataBindings.Add("Text", bndTypeDoc, "Path_to_template");


            bndNavigator_LibDoc.BindingSource = bndTypeDoc;
            //grid_LibDoc.AutoGenerateColumns = false;
            //grid_LibDoc.DataSource = bndTypeDoc;
            //grid_LibDoc.Columns["Name_doc"].DataPropertyName = "Name_doc";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "All files(*.*)|*.*"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {   // получаем выбранный файл
                string filename = openFileDialog1.FileName;
                link_Path_to_template.Text = filename;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SaveDocLib();
            DB_Cmd.SaveTypeDoc();
            Close();
        }

       

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //AddDocLib();
            DB_Cmd.AddTypeDoc();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //DeleteDocLib();
            DB_Cmd.DeleteTypeDoc();
        }

        private void bindingNavigatorSave_Click(object sender, EventArgs e)
        {
            //SaveDocLib();
            DB_Cmd.SaveTypeDoc();
        }
    }
}
