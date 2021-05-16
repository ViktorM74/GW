
namespace CPlan
{
    partial class Form_CPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CPlan));
            this.dgv_edit_CPlan = new System.Windows.Forms.DataGridView();
            this.Num_Etap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Etap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachalo_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konec_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valute = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StatusCPlan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusStrip_edit_CPlan = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_Begin = new System.Windows.Forms.CheckBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.cb_Valute = new System.Windows.Forms.ComboBox();
            this.tb_Summ = new System.Windows.Forms.TextBox();
            this.tb_Comments = new System.Windows.Forms.TextBox();
            this.tb_Days = new System.Windows.Forms.TextBox();
            this.dp_Konec_Data = new System.Windows.Forms.DateTimePicker();
            this.dp_Nachalo_Data = new System.Windows.Forms.DateTimePicker();
            this.tb_Name_Etap = new System.Windows.Forms.TextBox();
            this.tb_Num_Etap = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_V = new System.Windows.Forms.Label();
            this.lbl_Summ = new System.Windows.Forms.Label();
            this.lbl_Comments = new System.Windows.Forms.Label();
            this.lbl_Days = new System.Windows.Forms.Label();
            this.lbl_Konec_Data = new System.Windows.Forms.Label();
            this.lbl_Nachalo_Data = new System.Windows.Forms.Label();
            this.lbl_Name_Etap = new System.Windows.Forms.Label();
            this.lbl_Num_Etap = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitter_CPlan = new System.Windows.Forms.Splitter();
            this.bndNavigator_edit_CPlan = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.btn_Del = new System.Windows.Forms.ToolStripButton();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_edit_CPlan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndNavigator_edit_CPlan)).BeginInit();
            this.bndNavigator_edit_CPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_edit_CPlan
            // 
            this.dgv_edit_CPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_edit_CPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Etap,
            this.Name_Etap,
            this.Nachalo_Data,
            this.Konec_Data,
            this.Summ,
            this.Valute,
            this.StatusCPlan});
            this.dgv_edit_CPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_edit_CPlan.Location = new System.Drawing.Point(3, 16);
            this.dgv_edit_CPlan.Name = "dgv_edit_CPlan";
            this.dgv_edit_CPlan.Size = new System.Drawing.Size(1025, 245);
            this.dgv_edit_CPlan.TabIndex = 0;
            // 
            // Num_Etap
            // 
            this.Num_Etap.HeaderText = "№";
            this.Num_Etap.Name = "Num_Etap";
            // 
            // Name_Etap
            // 
            this.Name_Etap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_Etap.HeaderText = "Название";
            this.Name_Etap.Name = "Name_Etap";
            // 
            // Nachalo_Data
            // 
            this.Nachalo_Data.HeaderText = "Начало";
            this.Nachalo_Data.Name = "Nachalo_Data";
            // 
            // Konec_Data
            // 
            this.Konec_Data.HeaderText = "Окончание";
            this.Konec_Data.Name = "Konec_Data";
            // 
            // Summ
            // 
            this.Summ.HeaderText = "Сумма";
            this.Summ.Name = "Summ";
            // 
            // Valute
            // 
            this.Valute.HeaderText = "Валюта";
            this.Valute.Items.AddRange(new object[] {
            "BYN",
            "RUB",
            "EUR",
            "USD"});
            this.Valute.Name = "Valute";
            this.Valute.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Valute.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // StatusCPlan
            // 
            this.StatusCPlan.HeaderText = "Статус";
            this.StatusCPlan.Items.AddRange(new object[] {
            "Активен",
            "Приостановлен",
            "Завершен",
            "Закрыт актом"});
            this.StatusCPlan.Name = "StatusCPlan";
            this.StatusCPlan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusCPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // statusStrip_edit_CPlan
            // 
            this.statusStrip_edit_CPlan.Location = new System.Drawing.Point(0, 501);
            this.statusStrip_edit_CPlan.Name = "statusStrip_edit_CPlan";
            this.statusStrip_edit_CPlan.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip_edit_CPlan.TabIndex = 1;
            this.statusStrip_edit_CPlan.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_Begin);
            this.groupBox1.Controls.Add(this.cb_Status);
            this.groupBox1.Controls.Add(this.cb_Valute);
            this.groupBox1.Controls.Add(this.tb_Summ);
            this.groupBox1.Controls.Add(this.tb_Comments);
            this.groupBox1.Controls.Add(this.tb_Days);
            this.groupBox1.Controls.Add(this.dp_Konec_Data);
            this.groupBox1.Controls.Add(this.dp_Nachalo_Data);
            this.groupBox1.Controls.Add(this.tb_Name_Etap);
            this.groupBox1.Controls.Add(this.tb_Num_Etap);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.lbl_V);
            this.groupBox1.Controls.Add(this.lbl_Summ);
            this.groupBox1.Controls.Add(this.lbl_Comments);
            this.groupBox1.Controls.Add(this.lbl_Days);
            this.groupBox1.Controls.Add(this.lbl_Konec_Data);
            this.groupBox1.Controls.Add(this.lbl_Nachalo_Data);
            this.groupBox1.Controls.Add(this.lbl_Name_Etap);
            this.groupBox1.Controls.Add(this.lbl_Num_Etap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные по этапу";
            // 
            // chb_Begin
            // 
            this.chb_Begin.AutoSize = true;
            this.chb_Begin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_Begin.Location = new System.Drawing.Point(832, 37);
            this.chb_Begin.Name = "chb_Begin";
            this.chb_Begin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chb_Begin.Size = new System.Drawing.Size(119, 17);
            this.chb_Begin.TabIndex = 6;
            this.chb_Begin.Text = "Включен в график";
            this.chb_Begin.UseVisualStyleBackColor = true;
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Активен",
            "Приостановлен",
            "Завершен",
            "Закрыт актом"});
            this.cb_Status.Location = new System.Drawing.Point(638, 32);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(175, 21);
            this.cb_Status.TabIndex = 5;
            // 
            // cb_Valute
            // 
            this.cb_Valute.FormattingEnabled = true;
            this.cb_Valute.Items.AddRange(new object[] {
            "BYN",
            "RUB",
            "EUR",
            "USD"});
            this.cb_Valute.Location = new System.Drawing.Point(555, 32);
            this.cb_Valute.Name = "cb_Valute";
            this.cb_Valute.Size = new System.Drawing.Size(77, 21);
            this.cb_Valute.TabIndex = 5;
            // 
            // tb_Summ
            // 
            this.tb_Summ.Location = new System.Drawing.Point(417, 32);
            this.tb_Summ.Name = "tb_Summ";
            this.tb_Summ.Size = new System.Drawing.Size(132, 20);
            this.tb_Summ.TabIndex = 4;
            // 
            // tb_Comments
            // 
            this.tb_Comments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Comments.Location = new System.Drawing.Point(521, 71);
            this.tb_Comments.Multiline = true;
            this.tb_Comments.Name = "tb_Comments";
            this.tb_Comments.Size = new System.Drawing.Size(498, 135);
            this.tb_Comments.TabIndex = 4;
            // 
            // tb_Days
            // 
            this.tb_Days.Location = new System.Drawing.Point(103, 32);
            this.tb_Days.Name = "tb_Days";
            this.tb_Days.Size = new System.Drawing.Size(45, 20);
            this.tb_Days.TabIndex = 4;
            // 
            // dp_Konec_Data
            // 
            this.dp_Konec_Data.Location = new System.Drawing.Point(281, 32);
            this.dp_Konec_Data.Name = "dp_Konec_Data";
            this.dp_Konec_Data.Size = new System.Drawing.Size(125, 20);
            this.dp_Konec_Data.TabIndex = 3;
            // 
            // dp_Nachalo_Data
            // 
            this.dp_Nachalo_Data.Location = new System.Drawing.Point(154, 32);
            this.dp_Nachalo_Data.Name = "dp_Nachalo_Data";
            this.dp_Nachalo_Data.Size = new System.Drawing.Size(121, 20);
            this.dp_Nachalo_Data.TabIndex = 3;
            // 
            // tb_Name_Etap
            // 
            this.tb_Name_Etap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_Name_Etap.Location = new System.Drawing.Point(12, 71);
            this.tb_Name_Etap.Multiline = true;
            this.tb_Name_Etap.Name = "tb_Name_Etap";
            this.tb_Name_Etap.Size = new System.Drawing.Size(503, 135);
            this.tb_Name_Etap.TabIndex = 2;
            // 
            // tb_Num_Etap
            // 
            this.tb_Num_Etap.Location = new System.Drawing.Point(12, 32);
            this.tb_Num_Etap.Name = "tb_Num_Etap";
            this.tb_Num_Etap.Size = new System.Drawing.Size(70, 20);
            this.tb_Num_Etap.TabIndex = 1;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(635, 16);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(41, 13);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "Статус";
            // 
            // lbl_V
            // 
            this.lbl_V.AutoSize = true;
            this.lbl_V.Location = new System.Drawing.Point(552, 16);
            this.lbl_V.Name = "lbl_V";
            this.lbl_V.Size = new System.Drawing.Size(45, 13);
            this.lbl_V.TabIndex = 0;
            this.lbl_V.Text = "Валюта";
            // 
            // lbl_Summ
            // 
            this.lbl_Summ.AutoSize = true;
            this.lbl_Summ.Location = new System.Drawing.Point(414, 16);
            this.lbl_Summ.Name = "lbl_Summ";
            this.lbl_Summ.Size = new System.Drawing.Size(41, 13);
            this.lbl_Summ.TabIndex = 0;
            this.lbl_Summ.Text = "Сумма";
            // 
            // lbl_Comments
            // 
            this.lbl_Comments.AutoSize = true;
            this.lbl_Comments.Location = new System.Drawing.Point(523, 55);
            this.lbl_Comments.Name = "lbl_Comments";
            this.lbl_Comments.Size = new System.Drawing.Size(56, 13);
            this.lbl_Comments.TabIndex = 0;
            this.lbl_Comments.Text = "Comments";
            // 
            // lbl_Days
            // 
            this.lbl_Days.AutoSize = true;
            this.lbl_Days.Location = new System.Drawing.Point(100, 16);
            this.lbl_Days.Name = "lbl_Days";
            this.lbl_Days.Size = new System.Drawing.Size(28, 13);
            this.lbl_Days.TabIndex = 0;
            this.lbl_Days.Text = "Дни";
            // 
            // lbl_Konec_Data
            // 
            this.lbl_Konec_Data.AutoSize = true;
            this.lbl_Konec_Data.Location = new System.Drawing.Point(281, 16);
            this.lbl_Konec_Data.Name = "lbl_Konec_Data";
            this.lbl_Konec_Data.Size = new System.Drawing.Size(62, 13);
            this.lbl_Konec_Data.TabIndex = 0;
            this.lbl_Konec_Data.Text = "Окончание";
            // 
            // lbl_Nachalo_Data
            // 
            this.lbl_Nachalo_Data.AutoSize = true;
            this.lbl_Nachalo_Data.Location = new System.Drawing.Point(151, 16);
            this.lbl_Nachalo_Data.Name = "lbl_Nachalo_Data";
            this.lbl_Nachalo_Data.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nachalo_Data.TabIndex = 0;
            this.lbl_Nachalo_Data.Text = "Начало";
            // 
            // lbl_Name_Etap
            // 
            this.lbl_Name_Etap.AutoSize = true;
            this.lbl_Name_Etap.Location = new System.Drawing.Point(9, 55);
            this.lbl_Name_Etap.Name = "lbl_Name_Etap";
            this.lbl_Name_Etap.Size = new System.Drawing.Size(63, 13);
            this.lbl_Name_Etap.TabIndex = 0;
            this.lbl_Name_Etap.Text = "Name_Etap";
            // 
            // lbl_Num_Etap
            // 
            this.lbl_Num_Etap.AutoSize = true;
            this.lbl_Num_Etap.Location = new System.Drawing.Point(9, 16);
            this.lbl_Num_Etap.Name = "lbl_Num_Etap";
            this.lbl_Num_Etap.Size = new System.Drawing.Size(53, 13);
            this.lbl_Num_Etap.TabIndex = 0;
            this.lbl_Num_Etap.Text = " № этапа";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_edit_CPlan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 264);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Календарный план";
            // 
            // splitter_CPlan
            // 
            this.splitter_CPlan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitter_CPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter_CPlan.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter_CPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter_CPlan.Location = new System.Drawing.Point(0, 237);
            this.splitter_CPlan.Name = "splitter_CPlan";
            this.splitter_CPlan.Padding = new System.Windows.Forms.Padding(1);
            this.splitter_CPlan.Size = new System.Drawing.Size(1031, 3);
            this.splitter_CPlan.TabIndex = 5;
            this.splitter_CPlan.TabStop = false;
            // 
            // bndNavigator_edit_CPlan
            // 
            this.bndNavigator_edit_CPlan.AddNewItem = null;
            this.bndNavigator_edit_CPlan.CountItem = this.bindingNavigatorCountItem;
            this.bndNavigator_edit_CPlan.DeleteItem = null;
            this.bndNavigator_edit_CPlan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btn_Add,
            this.btn_Del,
            this.btn_Save,
            this.btn_Refresh,
            this.toolStripSeparator1});
            this.bndNavigator_edit_CPlan.Location = new System.Drawing.Point(0, 0);
            this.bndNavigator_edit_CPlan.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndNavigator_edit_CPlan.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndNavigator_edit_CPlan.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndNavigator_edit_CPlan.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndNavigator_edit_CPlan.Name = "bndNavigator_edit_CPlan";
            this.bndNavigator_edit_CPlan.PositionItem = this.bindingNavigatorPositionItem;
            this.bndNavigator_edit_CPlan.Size = new System.Drawing.Size(1031, 25);
            this.bndNavigator_edit_CPlan.TabIndex = 6;
            this.bndNavigator_edit_CPlan.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Add
            // 
            this.btn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RightToLeftAutoMirrorImage = true;
            this.btn_Add.Size = new System.Drawing.Size(23, 22);
            this.btn_Add.Text = "Добавить";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // btn_Del
            // 
            this.btn_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Del.Image = ((System.Drawing.Image)(resources.GetObject("btn_Del.Image")));
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.RightToLeftAutoMirrorImage = true;
            this.btn_Del.Size = new System.Drawing.Size(23, 22);
            this.btn_Del.Text = "Удалить";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click_1);
            // 
            // btn_Save
            // 
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = global::CPlan.Properties.Resources.Save;
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(23, 22);
            this.btn_Save.Text = "toolStripButton1";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refresh.Image = global::CPlan.Properties.Resources.Refresh;
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(23, 22);
            this.btn_Refresh.Text = "toolStripButton1";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Form_CPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 523);
            this.Controls.Add(this.splitter_CPlan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip_edit_CPlan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bndNavigator_edit_CPlan);
            this.Name = "Form_CPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор календарного плана";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CPlan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_edit_CPlan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bndNavigator_edit_CPlan)).EndInit();
            this.bndNavigator_edit_CPlan.ResumeLayout(false);
            this.bndNavigator_edit_CPlan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_edit_CPlan;
        private System.Windows.Forms.StatusStrip statusStrip_edit_CPlan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Num_Etap;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_V;
        private System.Windows.Forms.Label lbl_Summ;
        private System.Windows.Forms.Label lbl_Comments;
        private System.Windows.Forms.Label lbl_Days;
        private System.Windows.Forms.Label lbl_Konec_Data;
        private System.Windows.Forms.Label lbl_Nachalo_Data;
        private System.Windows.Forms.Label lbl_Name_Etap;
        private System.Windows.Forms.CheckBox chb_Begin;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.ComboBox cb_Valute;
        private System.Windows.Forms.TextBox tb_Summ;
        private System.Windows.Forms.TextBox tb_Comments;
        private System.Windows.Forms.TextBox tb_Days;
        private System.Windows.Forms.DateTimePicker dp_Konec_Data;
        private System.Windows.Forms.DateTimePicker dp_Nachalo_Data;
        private System.Windows.Forms.TextBox tb_Name_Etap;
        private System.Windows.Forms.TextBox tb_Num_Etap;
        private System.Windows.Forms.Splitter splitter_CPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Etap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Etap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachalo_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konec_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        private System.Windows.Forms.DataGridViewComboBoxColumn Valute;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusCPlan;
        private System.Windows.Forms.BindingNavigator bndNavigator_edit_CPlan;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btn_Del;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}