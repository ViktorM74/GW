using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBClass
{
    public partial class FormEditText : Form
    {
        public FormEditText(BindingSource bnd, String field)
        {
            InitializeComponent();

            rt_Text.DataBindings.Add("Text", bnd, field);
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            rt_Text.SelectionFont = fd.Font;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            rt_Text.SelectionColor = cd.Color;
        }
    }
}
