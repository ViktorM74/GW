using System.Windows.Forms;

namespace DogovorClass
{
    public partial class Form_Dogovor : Form
    {
        public Form_Dogovor()
        {
            InitializeComponent();
        }

        public Form_Dogovor(BindingSource bndDogovor, BindingSource bndCustomer, BindingSource bndStadia, BindingSource bndGIP)
        {
            InitializeComponent();

            SetView(bndDogovor, bndCustomer, bndStadia, bndGIP);
        }

        public void SetView(BindingSource bndDogovor, BindingSource bndCustomer, BindingSource bndStadia, BindingSource bndGIP)
        {
            tb_NumDog.DataBindings.Add("Text", bndDogovor, "Nambe_Dog");
            dtp_DateDog.DataBindings.Add("Text", bndDogovor, "DataOt");

            cb_StatusDog.DataBindings.Add("Text", bndDogovor, "Status");

            dtp_ToDateDog.DataBindings.Add("Text", bndDogovor, "Data_Konec");
            tb_NameDog.DataBindings.Add("Text", bndDogovor, "Name_Dog");

            // cb_StadiaDog
            cb_StadiaDog.DataSource = bndStadia;
            cb_StadiaDog.DisplayMember = "Обозначение";
            cb_StadiaDog.ValueMember = "StadyID";
            cb_StadiaDog.DataBindings.Add("SelectedValue", bndDogovor, "IDStady");

            //cb_GIPDog
            cb_GIPDog.DataSource = bndGIP;
            cb_GIPDog.DisplayMember = "Family";
            cb_GIPDog.ValueMember = "UsedID";
            cb_GIPDog.DataBindings.Add("SelectedValue", bndDogovor, "IDGip");

            cb_Valute.DataBindings.Add("Text", bndDogovor, "V");
            tb_SostavDog.DataBindings.Add("Text", bndDogovor, "Sostav");
            tb_CommentDog.DataBindings.Add("Text", bndDogovor, "Comments");

        }


    }
}
