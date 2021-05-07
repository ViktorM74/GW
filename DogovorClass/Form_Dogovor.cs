using System.Windows.Forms;
using DBClass;

namespace DogovorClass
{
    public partial class Form_Dogovor : Form
    {
        public Form_Dogovor()
        {
            InitializeComponent();

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


    }
}
