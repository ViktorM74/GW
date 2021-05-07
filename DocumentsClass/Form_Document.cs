using System.Windows.Forms;
using DBClass;

namespace DocumentsClass
{
    public partial class Form_Document : Form
    {
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
    }
}
