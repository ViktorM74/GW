using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DBClass;
using FileAction;

namespace DogovorClass
{
    public partial class Form_Dogovor : Form
    {
        string link_LocalFld = null;

        public Form_Dogovor(string lnk)
        {
            InitializeComponent();

            link_LocalFld = lnk;

            SetView();
        }

        public void SetView()
        {
            tb_NumDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Nambe_Dog");
            dtp_DateDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "DataOt");

            cb_StatusDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Status");

            dtp_ToDateDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Data_Konec");
            tb_NameDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Name_Dog");

            // cb_StadiaDog
            cb_StadiaDog.DataSource = DB_Cmd.bndStadia;
            cb_StadiaDog.DisplayMember = "Обозначение";
            cb_StadiaDog.ValueMember = "StadyID";
            cb_StadiaDog.DataBindings.Add("SelectedValue", DB_Cmd.bndDogovor, "IDStady");

            //cb_GIPDog
            cb_GIPDog.DataSource = DB_Cmd.bndGip;
            cb_GIPDog.DisplayMember = "Family";
            cb_GIPDog.ValueMember = "UsedID";
            cb_GIPDog.DataBindings.Add("SelectedValue", DB_Cmd.bndDogovor, "IDGip");

            cb_Valute.DataBindings.Add("Text", DB_Cmd.bndDogovor, "V");
            tb_SostavDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Sostav");
            tb_CommentDog.DataBindings.Add("Text", DB_Cmd.bndDogovor, "Comments");

        }

        private void btn_SaveDogovor_Click(object sender, System.EventArgs e)
        {
            string s = null;
            this.Validate();
            if (!String.IsNullOrEmpty(tb_NumDog.Text))
            {
                s = link_LocalFld;

                if (!String.IsNullOrEmpty(s))
                {
                    string nameDog = tb_NumDog.Text;
                    nameDog = nameDog.Replace('/', '_').Replace('\\', '_').Replace('.', '_');

                    string newPath = Path.Combine(Path.Combine(s, "Договор"), nameDog);
                    FileA.CreateFolder(newPath);
                    ((DataRowView)DB_Cmd.bndDogovor.Current).Row["path"] = newPath;
                }

                DB_Cmd.SaveDogovor(s);
                Close();
            }
            else
            {
                MessageBox.Show("Номер договора не может быть пустым!");
            }

        }

        private void btn_CloseDogovor_Click(object sender, System.EventArgs e)
        {
            Validate();
            DB_Cmd.CancelDogovor();
            Close();
        }
    }
}
