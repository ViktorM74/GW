using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectClass
{
    public partial class Form_Object : Form
    {
        public Form_Object(BindingSource bndObject, BindingSource bndGIP, BindingSource bndStadia)
        {
            InitializeComponent();

            tb_NameUObject.DataBindings.Add("Text", bndObject, "Name_Ustanovka");
            tb_NameObject.DataBindings.Add("Text", bndObject, "Name_object");
            tb_CodeObject.DataBindings.Add("Text", bndObject, "Nambe_Object");
            tb_TitleObject.DataBindings.Add("Text", bndObject, "Titul");
            tb_BlockObject.DataBindings.Add("Text", bndObject, "Block");
            tb_CommentsObj.DataBindings.Add("Text", bndObject, "Comments");

            // Stadia
            cb_Stadia.DataSource = bndStadia;
            cb_Stadia.DisplayMember = "Обозначение";
            cb_Stadia.ValueMember = "StadyID";
            cb_Stadia.DataBindings.Add("SelectedValue", bndObject, "IDStadia");

            //GIP
            tb_GIPObject.DataSource = bndGIP;
            tb_GIPObject.DisplayMember = "Family";
            tb_GIPObject.ValueMember = "UsedID";
            tb_GIPObject.DataBindings.Add("SelectedValue", bndObject, "GIP");

        }
    }
}
