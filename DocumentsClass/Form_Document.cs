using System;
using System.Data;
using System.Windows.Forms;
using DBClass;
using Zadania;

namespace DocumentsClass
{
    public partial class Form_Document : Form
    {
        public static string pathDoc
        {
            get; set;
        }

        public Form_Document()
        {
            InitializeComponent();

            SetViewForm();
        }

        private void SetViewForm()
        {
            cb_TypeDoc.DataSource = DB_Cmd.bndTypeDoc;
            cb_TypeDoc.DisplayMember = "Name_doc";
            cb_TypeDoc.ValueMember = "DOCTypeID";
            cb_TypeDoc.DataBindings.Add("SelectedValue", DB_Cmd.bndDocument, "Doc_Type");

            cb_object.DataSource = DB_Cmd.bndObject;
            cb_object.DisplayMember = "CodeOBJ";
            cb_object.ValueMember = "ID_Object";
            cb_object.DataBindings.Add("SelectedValue", DB_Cmd.bndDocument, "Object_id", false, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);

            chb_control.DataBindings.Add("Checked", DB_Cmd.bndDocument, "Control", false, DataSourceUpdateMode.OnPropertyChanged, false);

            tb_NameDoc.DataBindings.Add("Text", DB_Cmd.bndDocument, "NameDoc");
            tb_NumbeDoc.DataBindings.Add("Text", DB_Cmd.bndDocument, "Nambe_Doc");
            dtp_DateDoc.DataBindings.Add("Text", DB_Cmd.bndDocument, "DataDoc");
            cb_Status.DataBindings.Add("Text", DB_Cmd.bndDocument, "Status");
            rtb_Notes.DataBindings.Add("Text", DB_Cmd.bndDocument, "Notes");
            tb_PathDoc.DataBindings.Add("Text", DB_Cmd.bndDocument, "PathDoc");



        }

        private void Form_docEdit_Load(object sender, System.EventArgs e)
        {

        }

        private void btn_PathDoc_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openDialog1 = new OpenFileDialog();
            if (openDialog1.ShowDialog() == DialogResult.OK)
            {   // получаем выбранный файл
                tb_PathDoc.Text = openDialog1.FileName;
            }

        }

        private void Form_Document_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Tag = tb_PathDoc.Text;
        }

        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(cb_object.Text))
                    ((DataRowView)DB_Cmd.bndDocument.Current).Row["Object_id"] = DBNull.Value;
            else
            {
                if (cb_TypeDoc.SelectedValue != null && (int)cb_TypeDoc.SelectedValue == 24)
                {
                    ((DataRowView)DB_Cmd.bndDocument.Current).Row["Zadania"] = true;

                    // TODO: Связывать с Заданиями в плане
                    //string indZid = ((DataRowView)DB_Cmd.bndDocument.Current).Row["Zadania_id"].ToString();
                    //if (!String.IsNullOrEmpty(indZid))
                    //{

                    //    Form_Zadania_Plan fz = new Form_Zadania_Plan();
                    //    fz.ShowDialog();
                    //}
                }

                if (cb_TypeDoc.SelectedValue != null && (int)cb_TypeDoc.SelectedValue == 34)
                {
                    ((DataRowView)DB_Cmd.bndDocument.Current).Row["KMD"] = true;
                }

                if (cb_TypeDoc.SelectedValue != null && (int)cb_TypeDoc.SelectedValue == 33)
                {
                    // TODO: Связывать с Заданиями в плане
                    ((DataRowView)DB_Cmd.bndDocument.Current).Row["RKD"] = true;
                }

                if (cb_TypeDoc.SelectedValue != null && ((int)cb_TypeDoc.SelectedValue == 31 || (int)cb_TypeDoc.SelectedValue == 32))
                {
                    // TODO: Связывать с Заданиями в плане
                    ((DataRowView)DB_Cmd.bndDocument.Current).Row["Izyskania"] = true;
                }

            }

            this.Validate();
            DB_Cmd.SaveDoc();
            Close();
        }

        private void bt_Cancel_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            DB_Cmd.CancelDoc();
            Close();
        }
    }
}
