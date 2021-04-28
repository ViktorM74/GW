using System.Windows.Forms;

namespace GW_Dogovor
{
    public partial class Form_editDocument : Form
    {
        public Form_editDocument(BindingSource bndDocument, BindingSource bndTypeDoc)
        {
            InitializeComponent();

            SetViewForm(bndDocument, bndTypeDoc);
        }

        private void SetViewForm(BindingSource bndDocument, BindingSource bndTypeDoc)
        {
            cb_TypeDoc.DataSource = bndTypeDoc;
            cb_TypeDoc.DisplayMember = "Name_doc";
            cb_TypeDoc.ValueMember = "DOCTypeID";
            cb_TypeDoc.DataBindings.Add("SelectedValue", bndDocument, "Doc_Type");

            tb_NameDoc.DataBindings.Add("Text", bndDocument, "NameDoc");
            tb_NumbeDoc.DataBindings.Add("Text", bndDocument, "Nambe_Doc");
            dtp_DateDoc.DataBindings.Add("Text", bndDocument, "DataDoc");
            cb_Status.DataBindings.Add("Text", bndDocument, "Status");
            rtb_Notes.DataBindings.Add("Text", bndDocument, "Notes");
            tb_PathDoc.DataBindings.Add("Text", bndDocument, "PathDoc");

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
