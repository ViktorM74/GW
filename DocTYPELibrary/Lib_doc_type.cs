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

        //BindingSource bndTypeDoc = new BindingSource();

        public Lib_doc_type()
        {
            InitializeComponent();

            SetView();
        }

        private void SetView()
        {
            lb_NameDoc.DataSource = DB_Cmd.bndTypeDoc;
            lb_NameDoc.DisplayMember = "Name_doc";
            lb_NameDoc.ValueMember = "DOCTypeID";
         
            tb_Name_doc.DataBindings.Add("Text", DB_Cmd.bndTypeDoc, "Name_doc");
            tb_Notes.DataBindings.Add("Text", DB_Cmd.bndTypeDoc, "Notes");
            link_Path_to_template.DataBindings.Add("Text", DB_Cmd.bndTypeDoc, "Path_to_template");

            cb_group.DataSource = DB_Cmd.bndDoc_Group;
            cb_group.DisplayMember = "Name_group";
            cb_group.ValueMember = "id_group";
            cb_group.DataBindings.Add("SelectedValue", DB_Cmd.bndTypeDoc, "Doc_Group");

            bndNavigator_LibDoc.BindingSource = DB_Cmd.bndTypeDoc;
            
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
           DB_Cmd.AddTypeDoc();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           DB_Cmd.DeleteTypeDoc();
        }

        private void bindingNavigatorSave_Click(object sender, EventArgs e)
        {
           DB_Cmd.SaveTypeDoc();
        }
    }
}
