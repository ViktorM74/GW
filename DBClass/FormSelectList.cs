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
    public partial class FormSelectList : Form
    {
        private List<string> listSelectedVal;
        public List<string> listSelected
        {
            get { return listSelectedVal; }
        }

        public FormSelectList(List<string> list)
        {
            InitializeComponent();

            foreach (string el in list)
            {
                checkedListBox1.Items.Add(el);
            }
                  
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSelectedVal.Add(e.ToString());
        }
    }
}
