
namespace CPlan
{
    partial class Form_CP001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CP001));
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.btn_UpdateItem = new System.Windows.Forms.Button();
            this.btn_refreshItem = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.lb_Num = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.navigatorCP = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.group_Period = new System.Windows.Forms.GroupBox();
            this.group_Param_Period = new System.Windows.Forms.GroupBox();
            this.rb_fix_day = new System.Windows.Forms.RadioButton();
            this.rb_fix_konec = new System.Windows.Forms.RadioButton();
            this.rb_fix_nach = new System.Windows.Forms.RadioButton();
            this.lb_konec = new System.Windows.Forms.Label();
            this.lb_Nachalo = new System.Windows.Forms.Label();
            this.lb_day = new System.Windows.Forms.Label();
            this.dtp_konec = new System.Windows.Forms.DateTimePicker();
            this.dtp_nachalo = new System.Windows.Forms.DateTimePicker();
            this.tb_day = new System.Windows.Forms.TextBox();
            this.lb_Comments = new System.Windows.Forms.Label();
            this.lb_Summ = new System.Windows.Forms.Label();
            this.lb_Valute = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.lb_Sort = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Summ = new System.Windows.Forms.TextBox();
            this.tb_Comments = new System.Windows.Forms.TextBox();
            this.cb_Valute = new System.Windows.Forms.ComboBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.cb_DD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.navigatorCP)).BeginInit();
            this.navigatorCP.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.group_Period.SuspendLayout();
            this.group_Param_Period.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(20, 40);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(75, 23);
            this.btn_addItem.TabIndex = 0;
            this.btn_addItem.Text = "Добавить";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(20, 69);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteItem.TabIndex = 1;
            this.btn_deleteItem.Text = "Удалить";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // btn_UpdateItem
            // 
            this.btn_UpdateItem.Location = new System.Drawing.Point(20, 98);
            this.btn_UpdateItem.Name = "btn_UpdateItem";
            this.btn_UpdateItem.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateItem.TabIndex = 2;
            this.btn_UpdateItem.Text = "Сохранить";
            this.btn_UpdateItem.UseVisualStyleBackColor = true;
            this.btn_UpdateItem.Click += new System.EventHandler(this.btn_UpdateItem_Click);
            // 
            // btn_refreshItem
            // 
            this.btn_refreshItem.Location = new System.Drawing.Point(20, 11);
            this.btn_refreshItem.Name = "btn_refreshItem";
            this.btn_refreshItem.Size = new System.Drawing.Size(75, 23);
            this.btn_refreshItem.TabIndex = 3;
            this.btn_refreshItem.Text = "Обновить";
            this.btn_refreshItem.UseVisualStyleBackColor = true;
            this.btn_refreshItem.Click += new System.EventHandler(this.btn_refreshItem_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 72);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(386, 67);
            this.tb_name.TabIndex = 4;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(12, 27);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(100, 20);
            this.tb_num.TabIndex = 5;
            // 
            // lb_Num
            // 
            this.lb_Num.AutoSize = true;
            this.lb_Num.Location = new System.Drawing.Point(9, 11);
            this.lb_Num.Name = "lb_Num";
            this.lb_Num.Size = new System.Drawing.Size(50, 13);
            this.lb_Num.TabIndex = 9;
            this.lb_Num.Text = "№ этапа";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(12, 53);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(57, 13);
            this.lb_Name.TabIndex = 10;
            this.lb_Name.Text = "Название";
            // 
            // navigatorCP
            // 
            this.navigatorCP.AddNewItem = null;
            this.navigatorCP.CountItem = this.bindingNavigatorCountItem;
            this.navigatorCP.DeleteItem = null;
            this.navigatorCP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigatorCP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.navigatorCP.Location = new System.Drawing.Point(0, 350);
            this.navigatorCP.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.navigatorCP.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.navigatorCP.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.navigatorCP.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.navigatorCP.Name = "navigatorCP";
            this.navigatorCP.PositionItem = this.bindingNavigatorPositionItem;
            this.navigatorCP.Size = new System.Drawing.Size(712, 25);
            this.navigatorCP.TabIndex = 14;
            this.navigatorCP.Text = "bindingNavigator1";
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
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btn_refreshItem);
            this.panelButton.Controls.Add(this.btn_addItem);
            this.panelButton.Controls.Add(this.label12);
            this.panelButton.Controls.Add(this.btn_deleteItem);
            this.panelButton.Controls.Add(this.label11);
            this.panelButton.Controls.Add(this.btn_Close);
            this.panelButton.Controls.Add(this.lb_Sort);
            this.panelButton.Controls.Add(this.btn_UpdateItem);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButton.Location = new System.Drawing.Point(605, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(107, 350);
            this.panelButton.TabIndex = 15;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(20, 127);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // group_Period
            // 
            this.group_Period.Controls.Add(this.group_Param_Period);
            this.group_Period.Controls.Add(this.lb_konec);
            this.group_Period.Controls.Add(this.lb_Nachalo);
            this.group_Period.Controls.Add(this.lb_day);
            this.group_Period.Controls.Add(this.dtp_konec);
            this.group_Period.Controls.Add(this.dtp_nachalo);
            this.group_Period.Controls.Add(this.tb_day);
            this.group_Period.Dock = System.Windows.Forms.DockStyle.Right;
            this.group_Period.Location = new System.Drawing.Point(404, 0);
            this.group_Period.Name = "group_Period";
            this.group_Period.Size = new System.Drawing.Size(201, 350);
            this.group_Period.TabIndex = 16;
            this.group_Period.TabStop = false;
            this.group_Period.Text = "Период выполнения";
            // 
            // group_Param_Period
            // 
            this.group_Param_Period.Controls.Add(this.rb_fix_day);
            this.group_Param_Period.Controls.Add(this.rb_fix_konec);
            this.group_Param_Period.Controls.Add(this.rb_fix_nach);
            this.group_Param_Period.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.group_Param_Period.Location = new System.Drawing.Point(3, 225);
            this.group_Param_Period.Name = "group_Param_Period";
            this.group_Param_Period.Size = new System.Drawing.Size(195, 122);
            this.group_Param_Period.TabIndex = 21;
            this.group_Param_Period.TabStop = false;
            this.group_Param_Period.Text = "Параметры расчета периода";
            // 
            // rb_fix_day
            // 
            this.rb_fix_day.AutoSize = true;
            this.rb_fix_day.Checked = true;
            this.rb_fix_day.Location = new System.Drawing.Point(6, 75);
            this.rb_fix_day.Name = "rb_fix_day";
            this.rb_fix_day.Size = new System.Drawing.Size(178, 17);
            this.rb_fix_day.TabIndex = 20;
            this.rb_fix_day.TabStop = true;
            this.rb_fix_day.Text = "фиксированная длительность";
            this.rb_fix_day.UseVisualStyleBackColor = true;
            // 
            // rb_fix_konec
            // 
            this.rb_fix_konec.AutoSize = true;
            this.rb_fix_konec.Location = new System.Drawing.Point(6, 52);
            this.rb_fix_konec.Name = "rb_fix_konec";
            this.rb_fix_konec.Size = new System.Drawing.Size(161, 17);
            this.rb_fix_konec.TabIndex = 20;
            this.rb_fix_konec.Text = "фиксированное окончание";
            this.rb_fix_konec.UseVisualStyleBackColor = true;
            // 
            // rb_fix_nach
            // 
            this.rb_fix_nach.AutoSize = true;
            this.rb_fix_nach.Location = new System.Drawing.Point(6, 29);
            this.rb_fix_nach.Name = "rb_fix_nach";
            this.rb_fix_nach.Size = new System.Drawing.Size(143, 17);
            this.rb_fix_nach.TabIndex = 20;
            this.rb_fix_nach.Text = "фиксированное начало";
            this.rb_fix_nach.UseVisualStyleBackColor = true;
            // 
            // lb_konec
            // 
            this.lb_konec.AutoSize = true;
            this.lb_konec.Location = new System.Drawing.Point(3, 97);
            this.lb_konec.Name = "lb_konec";
            this.lb_konec.Size = new System.Drawing.Size(62, 13);
            this.lb_konec.TabIndex = 19;
            this.lb_konec.Text = "Окончание";
            // 
            // lb_Nachalo
            // 
            this.lb_Nachalo.AutoSize = true;
            this.lb_Nachalo.Location = new System.Drawing.Point(3, 57);
            this.lb_Nachalo.Name = "lb_Nachalo";
            this.lb_Nachalo.Size = new System.Drawing.Size(44, 13);
            this.lb_Nachalo.TabIndex = 18;
            this.lb_Nachalo.Text = "Начало";
            // 
            // lb_day
            // 
            this.lb_day.AutoSize = true;
            this.lb_day.Location = new System.Drawing.Point(3, 18);
            this.lb_day.Name = "lb_day";
            this.lb_day.Size = new System.Drawing.Size(28, 13);
            this.lb_day.TabIndex = 17;
            this.lb_day.Text = "Дни";
            // 
            // dtp_konec
            // 
            this.dtp_konec.Location = new System.Drawing.Point(6, 113);
            this.dtp_konec.Name = "dtp_konec";
            this.dtp_konec.Size = new System.Drawing.Size(120, 20);
            this.dtp_konec.TabIndex = 16;
            // 
            // dtp_nachalo
            // 
            this.dtp_nachalo.Location = new System.Drawing.Point(6, 73);
            this.dtp_nachalo.Name = "dtp_nachalo";
            this.dtp_nachalo.Size = new System.Drawing.Size(120, 20);
            this.dtp_nachalo.TabIndex = 15;
            // 
            // tb_day
            // 
            this.tb_day.Location = new System.Drawing.Point(6, 34);
            this.tb_day.Name = "tb_day";
            this.tb_day.Size = new System.Drawing.Size(120, 20);
            this.tb_day.TabIndex = 14;
            this.tb_day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_day_KeyPress);
            // 
            // lb_Comments
            // 
            this.lb_Comments.AutoSize = true;
            this.lb_Comments.Location = new System.Drawing.Point(13, 146);
            this.lb_Comments.Name = "lb_Comments";
            this.lb_Comments.Size = new System.Drawing.Size(77, 13);
            this.lb_Comments.TabIndex = 17;
            this.lb_Comments.Text = "Комментарий";
            // 
            // lb_Summ
            // 
            this.lb_Summ.AutoSize = true;
            this.lb_Summ.Location = new System.Drawing.Point(9, 261);
            this.lb_Summ.Name = "lb_Summ";
            this.lb_Summ.Size = new System.Drawing.Size(41, 13);
            this.lb_Summ.TabIndex = 17;
            this.lb_Summ.Text = "Сумма";
            // 
            // lb_Valute
            // 
            this.lb_Valute.AutoSize = true;
            this.lb_Valute.Location = new System.Drawing.Point(203, 260);
            this.lb_Valute.Name = "lb_Valute";
            this.lb_Valute.Size = new System.Drawing.Size(45, 13);
            this.lb_Valute.TabIndex = 17;
            this.lb_Valute.Text = "Валюта";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(115, 11);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(41, 13);
            this.lb_Status.TabIndex = 17;
            this.lb_Status.Text = "Статус";
            // 
            // lb_Sort
            // 
            this.lb_Sort.AutoSize = true;
            this.lb_Sort.Location = new System.Drawing.Point(43, 322);
            this.lb_Sort.Name = "lb_Sort";
            this.lb_Sort.Size = new System.Drawing.Size(52, 13);
            this.lb_Sort.TabIndex = 17;
            this.lb_Sort.Text = "Num_sort";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "StatGlob";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Begin";
            // 
            // tb_Summ
            // 
            this.tb_Summ.Location = new System.Drawing.Point(12, 277);
            this.tb_Summ.Name = "tb_Summ";
            this.tb_Summ.Size = new System.Drawing.Size(188, 20);
            this.tb_Summ.TabIndex = 14;
            this.tb_Summ.TextChanged += new System.EventHandler(this.tb_Summ_TextChanged_1);
            this.tb_Summ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Summ_KeyPress);
            this.tb_Summ.Leave += new System.EventHandler(this.tb_Summ_Leave);
            // 
            // tb_Comments
            // 
            this.tb_Comments.Location = new System.Drawing.Point(12, 162);
            this.tb_Comments.Multiline = true;
            this.tb_Comments.Name = "tb_Comments";
            this.tb_Comments.Size = new System.Drawing.Size(386, 95);
            this.tb_Comments.TabIndex = 4;
            // 
            // cb_Valute
            // 
            this.cb_Valute.FormattingEnabled = true;
            this.cb_Valute.Items.AddRange(new object[] {
            "BYN",
            "RUB",
            "EUR",
            "USD"});
            this.cb_Valute.Location = new System.Drawing.Point(206, 276);
            this.cb_Valute.Name = "cb_Valute";
            this.cb_Valute.Size = new System.Drawing.Size(96, 21);
            this.cb_Valute.TabIndex = 18;
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Активен",
            "Приостановлен",
            "Завершен",
            "Закрыт актом"});
            this.cb_Status.Location = new System.Drawing.Point(118, 27);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(167, 21);
            this.cb_Status.TabIndex = 18;
            // 
            // cb_DD
            // 
            this.cb_DD.FormattingEnabled = true;
            this.cb_DD.Location = new System.Drawing.Point(291, 27);
            this.cb_DD.Name = "cb_DD";
            this.cb_DD.Size = new System.Drawing.Size(89, 21);
            this.cb_DD.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ДС";
            // 
            // Form_CP001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 375);
            this.Controls.Add(this.cb_DD);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.cb_Valute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_Valute);
            this.Controls.Add(this.lb_Summ);
            this.Controls.Add(this.tb_Summ);
            this.Controls.Add(this.lb_Comments);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.lb_Num);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.group_Period);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.navigatorCP);
            this.Controls.Add(this.tb_Comments);
            this.Controls.Add(this.tb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_CP001";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор записи календарного плана";
            ((System.ComponentModel.ISupportInitialize)(this.navigatorCP)).EndInit();
            this.navigatorCP.ResumeLayout(false);
            this.navigatorCP.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.group_Period.ResumeLayout(false);
            this.group_Period.PerformLayout();
            this.group_Param_Period.ResumeLayout(false);
            this.group_Param_Period.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_deleteItem;
        private System.Windows.Forms.Button btn_UpdateItem;
        private System.Windows.Forms.Button btn_refreshItem;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label lb_Num;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.BindingNavigator navigatorCP;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.GroupBox group_Period;
        private System.Windows.Forms.Label lb_konec;
        private System.Windows.Forms.Label lb_Nachalo;
        private System.Windows.Forms.Label lb_day;
        private System.Windows.Forms.DateTimePicker dtp_konec;
        private System.Windows.Forms.DateTimePicker dtp_nachalo;
        private System.Windows.Forms.TextBox tb_day;
        private System.Windows.Forms.GroupBox group_Param_Period;
        private System.Windows.Forms.RadioButton rb_fix_day;
        private System.Windows.Forms.RadioButton rb_fix_konec;
        private System.Windows.Forms.RadioButton rb_fix_nach;
        private System.Windows.Forms.Label lb_Comments;
        private System.Windows.Forms.Label lb_Summ;
        private System.Windows.Forms.Label lb_Valute;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_Sort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Summ;
        private System.Windows.Forms.TextBox tb_Comments;
        private System.Windows.Forms.ComboBox cb_Valute;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox cb_DD;
        private System.Windows.Forms.Label label1;
    }
}