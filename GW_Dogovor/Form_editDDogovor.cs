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
    public partial class Form_editDDogovor : Form
    {
        public Form_editDDogovor(BindingSource bndDDog)
        {
            InitializeComponent();

            tb_NumDD.DataBindings.Add("Text", bndDDog, "Nambe_DS");
            dtp_DateDD.DataBindings.Add("Text", bndDDog, "DataPodp");
            cb_StatusDD.DataBindings.Add("Text", bndDDog, "Status");
            dtp_ToDateDD.DataBindings.Add("Text", bndDDog, "Data_Konec");
            tb_NotesDD.DataBindings.Add("Text", bndDDog, "Comments");
        }
    }
}
