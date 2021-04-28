using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW_Dogovor
{
    public partial class Form_editTender : Form
    {
        public Form_editTender()
        {
            InitializeComponent();
        }

        public Form_editTender(BindingSource bndTender, BindingSource bndCustomer,
            BindingSource bndStadia, BindingSource bndGIP)
        {
            InitializeComponent();

            cb_Customer.DataSource = bndCustomer;
            cb_Customer.DisplayMember = "NameCust";
            cb_Customer.ValueMember = "IDCustomer";
            cb_Customer.DataBindings.Add("SelectedValue", bndTender, "IDCust");

            cb_Stadia.DataSource = bndStadia;
            cb_Stadia.DisplayMember = "Обозначение";
            cb_Stadia.ValueMember = "StadyID";
            cb_Stadia.DataBindings.Add("SelectedValue", bndTender, "IDStadia");

            cb_GIP.DataSource = bndGIP;
            cb_GIP.DisplayMember = "Family";
            cb_GIP.ValueMember = "UsedID";
            cb_GIP.DataBindings.Add("SelectedValue", bndTender, "GIP");

            cb_Status.DataBindings.Add("Text", bndTender, "Status");

            tb_Name.DataBindings.Add("Text", bndTender, "Name_Tender");
            dtp_Tender.DataBindings.Add("Text", bndTender, "Data_End");
            tb_Sostav.DataBindings.Add("Text", bndTender, "Sostav");
            tb_Comment.DataBindings.Add("Text", bndTender, "Comments");
        }
    }
}
