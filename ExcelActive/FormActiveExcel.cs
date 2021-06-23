using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBClass;

namespace ExcelActive
{
    public partial class FormActiveExcel : Form
    {
        DataTable dt = new DataTable("Data");
        DataTable dl = new DataTable("Link");

        public FormActiveExcel()
        {
            InitializeComponent();
        }

        private void btn_Brouse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Excel files(*.xlsx)| *.xlsx|Excel macro(*.xlsm) | *.xlsm|Excel2003 files(*.xls) | *.xls";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = opf.FileName;
                cb_nameTable.Items.Clear();
                foreach (string s in ExcelOleDb.GetListTables(tb_path.Text))
                                          cb_nameTable.Items.Add(s.Replace("$", ""));
                cb_nameTable.SelectedIndex = 0;
            }
        }

        private void btn_ReadExcelToTable_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = ExcelOleDb.ReadXlsxToTable(tb_path.Text, cb_nameTable.Text);

            dataGridView1.DataSource = dt;

            GridProperty();

        }

        private void GridProperty()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView2.ColumnHeadersVisible = false;
                
                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.Items.Add("Номер");
                cmb.Items.Add("Название");
                cmb.Items.Add("Дни");
                cmb.Items.Add("Начало");
                cmb.Items.Add("Окончание");
                cmb.Items.Add("Сумма");
                dataGridView2.Columns.Add(cmb);
                dataGridView2.Columns[i].Width = column.Width;
                i++;
            }
            dataGridView2.Rows.Add();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow rv in dataGridView1.Rows)
            {
                int column = dataGridView1.CurrentCell.ColumnIndex;
                rv.Cells[column].Value = Convert.ToString(rv.Cells[column].Value).Replace(tb_find.Text, tb_replace.Text);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dl.Clear();
            if (dt != null)
            {
                dl = GetDataTableFromDGV(dataGridView2);
                DB_Cmd.RecordNewRows(dt, dl);
            }
            
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var table = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    table.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                table.Rows.Add(cellValues);
            }

            return table;
        }

        private void MenuDeleteRow_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(row);
        }

        private void MenuDeleteColumn_Click(object sender, EventArgs e)
        {
            int column = dataGridView1.CurrentCell.ColumnIndex;
            dataGridView1.Columns.RemoveAt(column);
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            GridWidth();
        }

        private void GridWidth()
        {
            int i = 0;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dataGridView2.Columns[i].Width = column.Width;
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
