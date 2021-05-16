using System.Windows.Forms;
using DBClass;

namespace ObjectClass
{
    public partial class Form_Object : Form
    {
        public Form_Object()
        {
            InitializeComponent();

            tb_NameUObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Name_Ustanovka");
            tb_NameObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Name_object");
            tb_CodeObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Nambe_Object");
            tb_TitleObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Titul");
            tb_BlockObject.DataBindings.Add("Text", DB_Cmd.bndObject, "Block");
            tb_CommentsObj.DataBindings.Add("Text", DB_Cmd.bndObject, "Comments");

            // Stadia
            cb_Stadia.DataSource = DB_Cmd.bndStadia;
            cb_Stadia.DisplayMember = "Обозначение";
            cb_Stadia.ValueMember = "StadyID";
            cb_Stadia.DataBindings.Add("SelectedValue", DB_Cmd.bndObject, "IDStadia");

            //GIP
            tb_GIPObject.DataSource = DB_Cmd.bndGip;
            tb_GIPObject.DisplayMember = "Family";
            tb_GIPObject.ValueMember = "UsedID";
            tb_GIPObject.DataBindings.Add("SelectedValue", DB_Cmd.bndObject, "GIP");

        }
    }
}
