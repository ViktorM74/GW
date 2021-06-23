
namespace ExcelActive
{
    partial class FormActiveExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Brouse = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_find = new System.Windows.Forms.Button();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.tb_replace = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_ReadExcelToTable = new System.Windows.Forms.Button();
            this.cb_nameTable = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Brouse
            // 
            this.btn_Brouse.Location = new System.Drawing.Point(340, 22);
            this.btn_Brouse.Name = "btn_Brouse";
            this.btn_Brouse.Size = new System.Drawing.Size(71, 29);
            this.btn_Brouse.TabIndex = 0;
            this.btn_Brouse.Text = "Обзор";
            this.btn_Brouse.UseVisualStyleBackColor = true;
            this.btn_Brouse.Click += new System.EventHandler(this.btn_Brouse_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(10, 23);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(324, 20);
            this.tb_path.TabIndex = 1;
            this.tb_path.Text = "E:\\OneDrive\\Programs\\C#\\DBGIP\\Журнал - ftp.xlsx";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuGrid;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 240);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            // 
            // contextMenuGrid
            // 
            this.contextMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDeleteRow,
            this.MenuDeleteColumn});
            this.contextMenuGrid.Name = "contextMenuGrid";
            this.contextMenuGrid.Size = new System.Drawing.Size(167, 48);
            // 
            // MenuDeleteRow
            // 
            this.MenuDeleteRow.Name = "MenuDeleteRow";
            this.MenuDeleteRow.Size = new System.Drawing.Size(166, 22);
            this.MenuDeleteRow.Text = "Удалить строку";
            this.MenuDeleteRow.Click += new System.EventHandler(this.MenuDeleteRow_Click);
            // 
            // MenuDeleteColumn
            // 
            this.MenuDeleteColumn.Name = "MenuDeleteColumn";
            this.MenuDeleteColumn.Size = new System.Drawing.Size(166, 22);
            this.MenuDeleteColumn.Text = "Удалить столбец";
            this.MenuDeleteColumn.Click += new System.EventHandler(this.MenuDeleteColumn_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(6, 75);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(187, 29);
            this.btn_find.TabIndex = 5;
            this.btn_find.Text = "Поиск и Замена";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // tb_find
            // 
            this.tb_find.Location = new System.Drawing.Point(81, 23);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(112, 20);
            this.tb_find.TabIndex = 7;
            // 
            // tb_replace
            // 
            this.tb_replace.Location = new System.Drawing.Point(81, 49);
            this.tb_replace.Name = "tb_replace";
            this.tb_replace.Size = new System.Drawing.Size(112, 20);
            this.tb_replace.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(0, 13);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(784, 25);
            this.dataGridView2.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(31, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 40);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_ReadExcelToTable
            // 
            this.btn_ReadExcelToTable.Location = new System.Drawing.Point(185, 57);
            this.btn_ReadExcelToTable.Name = "btn_ReadExcelToTable";
            this.btn_ReadExcelToTable.Size = new System.Drawing.Size(71, 29);
            this.btn_ReadExcelToTable.TabIndex = 2;
            this.btn_ReadExcelToTable.Text = "Загрузить";
            this.btn_ReadExcelToTable.UseVisualStyleBackColor = true;
            this.btn_ReadExcelToTable.Click += new System.EventHandler(this.btn_ReadExcelToTable_Click);
            // 
            // cb_nameTable
            // 
            this.cb_nameTable.FormattingEnabled = true;
            this.cb_nameTable.Location = new System.Drawing.Point(9, 62);
            this.cb_nameTable.Name = "cb_nameTable";
            this.cb_nameTable.Size = new System.Drawing.Size(170, 21);
            this.cb_nameTable.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 113);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(623, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 113);
            this.panel3.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(31, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Brouse);
            this.groupBox2.Controls.Add(this.btn_ReadExcelToTable);
            this.groupBox2.Controls.Add(this.tb_path);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_nameTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(206, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 113);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Загрузка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_find);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_replace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_find);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 113);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Найти и заменить";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Заменить на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Найти";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 283);
            this.panel2.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 38);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(784, 5);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Назначение связей с таблицей календарного плана";
            // 
            // FormActiveExcel
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 396);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormActiveExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт данных из Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Brouse;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.TextBox tb_replace;
        private System.Windows.Forms.ContextMenuStrip contextMenuGrid;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteRow;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_ReadExcelToTable;
        private System.Windows.Forms.ComboBox cb_nameTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label4;
    }
}