
namespace FolderManager
{
    partial class Form_FolderManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Close = new System.Windows.Forms.Button();
            this.btn_DeleteFld = new System.Windows.Forms.Button();
            this.bt_CreateFld = new System.Windows.Forms.Button();
            this.gr_Folders = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ch_FreeNameFld = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ch_OutFld = new System.Windows.Forms.CheckBox();
            this.ch_dw = new System.Windows.Forms.CheckBox();
            this.ch_InFld = new System.Windows.Forms.CheckBox();
            this.ch_DogovorFld = new System.Windows.Forms.CheckBox();
            this.ch_OsnFld = new System.Windows.Forms.CheckBox();
            this.ch_GeoFld = new System.Windows.Forms.CheckBox();
            this.ch_OtherFld = new System.Windows.Forms.CheckBox();
            this.ch_StampFld = new System.Windows.Forms.CheckBox();
            this.ch_ZadaniaFld = new System.Windows.Forms.CheckBox();
            this.tb_NewNameFld = new System.Windows.Forms.TextBox();
            this.ch_ds = new System.Windows.Forms.CheckBox();
            this.ch_gs = new System.Windows.Forms.CheckBox();
            this.ch_ss = new System.Windows.Forms.CheckBox();
            this.ch_zs = new System.Windows.Forms.CheckBox();
            this.ch_os = new System.Windows.Forms.CheckBox();
            this.ch_oss = new System.Windows.Forms.CheckBox();
            this.ch_ins = new System.Windows.Forms.CheckBox();
            this.ch_outs = new System.Windows.Forms.CheckBox();
            this.ch_gw = new System.Windows.Forms.CheckBox();
            this.ch_sw = new System.Windows.Forms.CheckBox();
            this.ch_zw = new System.Windows.Forms.CheckBox();
            this.ch_ow = new System.Windows.Forms.CheckBox();
            this.ch_osw = new System.Windows.Forms.CheckBox();
            this.ch_inw = new System.Windows.Forms.CheckBox();
            this.ch_outw = new System.Windows.Forms.CheckBox();
            this.gr_fldSorce = new System.Windows.Forms.GroupBox();
            this.ch_ServerFld = new System.Windows.Forms.CheckBox();
            this.ch_WorkFld = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.gr_Folders.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gr_fldSorce.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.bt_Close);
            this.panel1.Controls.Add(this.btn_DeleteFld);
            this.panel1.Controls.Add(this.bt_CreateFld);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 299);
            this.panel1.TabIndex = 0;
            // 
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.Location = new System.Drawing.Point(11, 87);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(99, 27);
            this.bt_Close.TabIndex = 0;
            this.bt_Close.Text = "Закрыть";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // btn_DeleteFld
            // 
            this.btn_DeleteFld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteFld.Location = new System.Drawing.Point(11, 43);
            this.btn_DeleteFld.Name = "btn_DeleteFld";
            this.btn_DeleteFld.Size = new System.Drawing.Size(99, 27);
            this.btn_DeleteFld.TabIndex = 0;
            this.btn_DeleteFld.Text = "Удалить папки";
            this.btn_DeleteFld.UseVisualStyleBackColor = true;
            this.btn_DeleteFld.Click += new System.EventHandler(this.btn_DeleteFld_Click);
            // 
            // bt_CreateFld
            // 
            this.bt_CreateFld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_CreateFld.Location = new System.Drawing.Point(11, 12);
            this.bt_CreateFld.Name = "bt_CreateFld";
            this.bt_CreateFld.Size = new System.Drawing.Size(99, 27);
            this.bt_CreateFld.TabIndex = 0;
            this.bt_CreateFld.Text = "Создать папки";
            this.bt_CreateFld.UseVisualStyleBackColor = true;
            this.bt_CreateFld.Click += new System.EventHandler(this.bt_CreateFld_Click);
            // 
            // gr_Folders
            // 
            this.gr_Folders.BackColor = System.Drawing.SystemColors.Control;
            this.gr_Folders.Controls.Add(this.tableLayoutPanel1);
            this.gr_Folders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_Folders.Location = new System.Drawing.Point(0, 0);
            this.gr_Folders.Name = "gr_Folders";
            this.gr_Folders.Size = new System.Drawing.Size(303, 299);
            this.gr_Folders.TabIndex = 1;
            this.gr_Folders.TabStop = false;
            this.gr_Folders.Text = "Папки...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ch_FreeNameFld, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ch_OutFld, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.ch_dw, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ch_InFld, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ch_DogovorFld, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ch_OsnFld, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ch_GeoFld, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ch_OtherFld, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ch_StampFld, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ch_ZadaniaFld, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_NewNameFld, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.ch_ds, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ch_gs, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ch_ss, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ch_zs, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ch_os, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ch_oss, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.ch_ins, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.ch_outs, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.ch_gw, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ch_sw, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ch_zw, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ch_ow, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ch_osw, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ch_inw, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.ch_outw, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 280);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "сет.";
            // 
            // ch_FreeNameFld
            // 
            this.ch_FreeNameFld.AutoSize = true;
            this.ch_FreeNameFld.Enabled = false;
            this.ch_FreeNameFld.Location = new System.Drawing.Point(3, 225);
            this.ch_FreeNameFld.Name = "ch_FreeNameFld";
            this.ch_FreeNameFld.Size = new System.Drawing.Size(105, 17);
            this.ch_FreeNameFld.TabIndex = 0;
            this.ch_FreeNameFld.Text = "Другая папка...";
            this.ch_FreeNameFld.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "раб.";
            // 
            // ch_OutFld
            // 
            this.ch_OutFld.AutoSize = true;
            this.ch_OutFld.Enabled = false;
            this.ch_OutFld.Location = new System.Drawing.Point(3, 191);
            this.ch_OutFld.Name = "ch_OutFld";
            this.ch_OutFld.Size = new System.Drawing.Size(84, 17);
            this.ch_OutFld.TabIndex = 0;
            this.ch_OutFld.Tag = "12";
            this.ch_OutFld.Text = "Исходящие";
            this.ch_OutFld.UseVisualStyleBackColor = true;
            // 
            // ch_dw
            // 
            this.ch_dw.AutoSize = true;
            this.ch_dw.Enabled = false;
            this.ch_dw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_dw.Location = new System.Drawing.Point(220, 23);
            this.ch_dw.Name = "ch_dw";
            this.ch_dw.Size = new System.Drawing.Size(12, 11);
            this.ch_dw.TabIndex = 2;
            this.ch_dw.UseVisualStyleBackColor = true;
            // 
            // ch_InFld
            // 
            this.ch_InFld.AutoSize = true;
            this.ch_InFld.Enabled = false;
            this.ch_InFld.Location = new System.Drawing.Point(3, 167);
            this.ch_InFld.Name = "ch_InFld";
            this.ch_InFld.Size = new System.Drawing.Size(77, 17);
            this.ch_InFld.TabIndex = 0;
            this.ch_InFld.Tag = "11";
            this.ch_InFld.Text = "Входящие";
            this.ch_InFld.UseVisualStyleBackColor = true;
            // 
            // ch_DogovorFld
            // 
            this.ch_DogovorFld.AutoSize = true;
            this.ch_DogovorFld.Enabled = false;
            this.ch_DogovorFld.Location = new System.Drawing.Point(3, 23);
            this.ch_DogovorFld.Name = "ch_DogovorFld";
            this.ch_DogovorFld.Size = new System.Drawing.Size(70, 17);
            this.ch_DogovorFld.TabIndex = 0;
            this.ch_DogovorFld.Tag = "4";
            this.ch_DogovorFld.Text = "Договор";
            this.ch_DogovorFld.UseVisualStyleBackColor = true;
            // 
            // ch_OsnFld
            // 
            this.ch_OsnFld.AutoSize = true;
            this.ch_OsnFld.Enabled = false;
            this.ch_OsnFld.Location = new System.Drawing.Point(3, 143);
            this.ch_OsnFld.Name = "ch_OsnFld";
            this.ch_OsnFld.Size = new System.Drawing.Size(137, 17);
            this.ch_OsnFld.TabIndex = 0;
            this.ch_OsnFld.Tag = "10";
            this.ch_OsnFld.Text = "Основные положения";
            this.ch_OsnFld.UseVisualStyleBackColor = true;
            // 
            // ch_GeoFld
            // 
            this.ch_GeoFld.AutoSize = true;
            this.ch_GeoFld.Enabled = false;
            this.ch_GeoFld.Location = new System.Drawing.Point(3, 47);
            this.ch_GeoFld.Name = "ch_GeoFld";
            this.ch_GeoFld.Size = new System.Drawing.Size(84, 17);
            this.ch_GeoFld.TabIndex = 0;
            this.ch_GeoFld.Tag = "7";
            this.ch_GeoFld.Text = "Изыскания";
            this.ch_GeoFld.UseVisualStyleBackColor = true;
            // 
            // ch_OtherFld
            // 
            this.ch_OtherFld.AutoSize = true;
            this.ch_OtherFld.Enabled = false;
            this.ch_OtherFld.Location = new System.Drawing.Point(3, 119);
            this.ch_OtherFld.Name = "ch_OtherFld";
            this.ch_OtherFld.Size = new System.Drawing.Size(63, 17);
            this.ch_OtherFld.TabIndex = 0;
            this.ch_OtherFld.Tag = "9";
            this.ch_OtherFld.Text = "Разное";
            this.ch_OtherFld.UseVisualStyleBackColor = true;
            // 
            // ch_StampFld
            // 
            this.ch_StampFld.AutoSize = true;
            this.ch_StampFld.Enabled = false;
            this.ch_StampFld.Location = new System.Drawing.Point(3, 71);
            this.ch_StampFld.Name = "ch_StampFld";
            this.ch_StampFld.Size = new System.Drawing.Size(60, 17);
            this.ch_StampFld.TabIndex = 0;
            this.ch_StampFld.Tag = "8";
            this.ch_StampFld.Text = "Штамп";
            this.ch_StampFld.UseVisualStyleBackColor = true;
            // 
            // ch_ZadaniaFld
            // 
            this.ch_ZadaniaFld.AutoSize = true;
            this.ch_ZadaniaFld.Enabled = false;
            this.ch_ZadaniaFld.Location = new System.Drawing.Point(3, 95);
            this.ch_ZadaniaFld.Name = "ch_ZadaniaFld";
            this.ch_ZadaniaFld.Size = new System.Drawing.Size(69, 17);
            this.ch_ZadaniaFld.TabIndex = 0;
            this.ch_ZadaniaFld.Tag = "2";
            this.ch_ZadaniaFld.Text = "Задания";
            this.ch_ZadaniaFld.UseVisualStyleBackColor = true;
            // 
            // tb_NewNameFld
            // 
            this.tb_NewNameFld.Location = new System.Drawing.Point(3, 249);
            this.tb_NewNameFld.Name = "tb_NewNameFld";
            this.tb_NewNameFld.Size = new System.Drawing.Size(208, 20);
            this.tb_NewNameFld.TabIndex = 1;
            // 
            // ch_ds
            // 
            this.ch_ds.AutoSize = true;
            this.ch_ds.Checked = true;
            this.ch_ds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_ds.Enabled = false;
            this.ch_ds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_ds.Location = new System.Drawing.Point(260, 23);
            this.ch_ds.Name = "ch_ds";
            this.ch_ds.Size = new System.Drawing.Size(12, 11);
            this.ch_ds.TabIndex = 2;
            this.ch_ds.UseVisualStyleBackColor = true;
            // 
            // ch_gs
            // 
            this.ch_gs.AutoSize = true;
            this.ch_gs.Enabled = false;
            this.ch_gs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_gs.Location = new System.Drawing.Point(260, 47);
            this.ch_gs.Name = "ch_gs";
            this.ch_gs.Size = new System.Drawing.Size(12, 11);
            this.ch_gs.TabIndex = 2;
            this.ch_gs.UseVisualStyleBackColor = true;
            // 
            // ch_ss
            // 
            this.ch_ss.AutoSize = true;
            this.ch_ss.Enabled = false;
            this.ch_ss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_ss.Location = new System.Drawing.Point(260, 71);
            this.ch_ss.Name = "ch_ss";
            this.ch_ss.Size = new System.Drawing.Size(12, 11);
            this.ch_ss.TabIndex = 2;
            this.ch_ss.UseVisualStyleBackColor = true;
            // 
            // ch_zs
            // 
            this.ch_zs.AutoSize = true;
            this.ch_zs.Enabled = false;
            this.ch_zs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_zs.Location = new System.Drawing.Point(260, 95);
            this.ch_zs.Name = "ch_zs";
            this.ch_zs.Size = new System.Drawing.Size(12, 11);
            this.ch_zs.TabIndex = 2;
            this.ch_zs.UseVisualStyleBackColor = true;
            // 
            // ch_os
            // 
            this.ch_os.AutoSize = true;
            this.ch_os.Enabled = false;
            this.ch_os.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_os.Location = new System.Drawing.Point(260, 119);
            this.ch_os.Name = "ch_os";
            this.ch_os.Size = new System.Drawing.Size(12, 11);
            this.ch_os.TabIndex = 2;
            this.ch_os.UseVisualStyleBackColor = true;
            // 
            // ch_oss
            // 
            this.ch_oss.AutoSize = true;
            this.ch_oss.Enabled = false;
            this.ch_oss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_oss.Location = new System.Drawing.Point(260, 143);
            this.ch_oss.Name = "ch_oss";
            this.ch_oss.Size = new System.Drawing.Size(12, 11);
            this.ch_oss.TabIndex = 2;
            this.ch_oss.UseVisualStyleBackColor = true;
            // 
            // ch_ins
            // 
            this.ch_ins.AutoSize = true;
            this.ch_ins.Enabled = false;
            this.ch_ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_ins.Location = new System.Drawing.Point(260, 167);
            this.ch_ins.Name = "ch_ins";
            this.ch_ins.Size = new System.Drawing.Size(12, 11);
            this.ch_ins.TabIndex = 2;
            this.ch_ins.UseVisualStyleBackColor = true;
            // 
            // ch_outs
            // 
            this.ch_outs.AutoSize = true;
            this.ch_outs.Enabled = false;
            this.ch_outs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_outs.Location = new System.Drawing.Point(260, 191);
            this.ch_outs.Name = "ch_outs";
            this.ch_outs.Size = new System.Drawing.Size(12, 11);
            this.ch_outs.TabIndex = 2;
            this.ch_outs.UseVisualStyleBackColor = true;
            // 
            // ch_gw
            // 
            this.ch_gw.AutoSize = true;
            this.ch_gw.Enabled = false;
            this.ch_gw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_gw.Location = new System.Drawing.Point(220, 47);
            this.ch_gw.Name = "ch_gw";
            this.ch_gw.Size = new System.Drawing.Size(12, 11);
            this.ch_gw.TabIndex = 2;
            this.ch_gw.UseVisualStyleBackColor = true;
            // 
            // ch_sw
            // 
            this.ch_sw.AutoSize = true;
            this.ch_sw.Enabled = false;
            this.ch_sw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_sw.Location = new System.Drawing.Point(220, 71);
            this.ch_sw.Name = "ch_sw";
            this.ch_sw.Size = new System.Drawing.Size(12, 11);
            this.ch_sw.TabIndex = 2;
            this.ch_sw.UseVisualStyleBackColor = true;
            // 
            // ch_zw
            // 
            this.ch_zw.AutoSize = true;
            this.ch_zw.Enabled = false;
            this.ch_zw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_zw.Location = new System.Drawing.Point(220, 95);
            this.ch_zw.Name = "ch_zw";
            this.ch_zw.Size = new System.Drawing.Size(12, 11);
            this.ch_zw.TabIndex = 2;
            this.ch_zw.UseVisualStyleBackColor = true;
            // 
            // ch_ow
            // 
            this.ch_ow.AutoSize = true;
            this.ch_ow.Enabled = false;
            this.ch_ow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_ow.Location = new System.Drawing.Point(220, 119);
            this.ch_ow.Name = "ch_ow";
            this.ch_ow.Size = new System.Drawing.Size(12, 11);
            this.ch_ow.TabIndex = 2;
            this.ch_ow.UseVisualStyleBackColor = true;
            // 
            // ch_osw
            // 
            this.ch_osw.AutoSize = true;
            this.ch_osw.Enabled = false;
            this.ch_osw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_osw.Location = new System.Drawing.Point(220, 143);
            this.ch_osw.Name = "ch_osw";
            this.ch_osw.Size = new System.Drawing.Size(12, 11);
            this.ch_osw.TabIndex = 2;
            this.ch_osw.UseVisualStyleBackColor = true;
            // 
            // ch_inw
            // 
            this.ch_inw.AutoSize = true;
            this.ch_inw.Enabled = false;
            this.ch_inw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_inw.Location = new System.Drawing.Point(220, 167);
            this.ch_inw.Name = "ch_inw";
            this.ch_inw.Size = new System.Drawing.Size(12, 11);
            this.ch_inw.TabIndex = 2;
            this.ch_inw.UseVisualStyleBackColor = true;
            // 
            // ch_outw
            // 
            this.ch_outw.AutoSize = true;
            this.ch_outw.Enabled = false;
            this.ch_outw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_outw.Location = new System.Drawing.Point(220, 191);
            this.ch_outw.Name = "ch_outw";
            this.ch_outw.Size = new System.Drawing.Size(12, 11);
            this.ch_outw.TabIndex = 2;
            this.ch_outw.UseVisualStyleBackColor = true;
            // 
            // gr_fldSorce
            // 
            this.gr_fldSorce.BackColor = System.Drawing.SystemColors.Control;
            this.gr_fldSorce.Controls.Add(this.ch_ServerFld);
            this.gr_fldSorce.Controls.Add(this.ch_WorkFld);
            this.gr_fldSorce.Dock = System.Windows.Forms.DockStyle.Right;
            this.gr_fldSorce.Location = new System.Drawing.Point(303, 0);
            this.gr_fldSorce.Name = "gr_fldSorce";
            this.gr_fldSorce.Size = new System.Drawing.Size(146, 299);
            this.gr_fldSorce.TabIndex = 2;
            this.gr_fldSorce.TabStop = false;
            this.gr_fldSorce.Text = "Где создаем... ";
            // 
            // ch_ServerFld
            // 
            this.ch_ServerFld.AutoSize = true;
            this.ch_ServerFld.Location = new System.Drawing.Point(7, 53);
            this.ch_ServerFld.Name = "ch_ServerFld";
            this.ch_ServerFld.Size = new System.Drawing.Size(110, 17);
            this.ch_ServerFld.TabIndex = 0;
            this.ch_ServerFld.Text = "сетевой каталог";
            this.ch_ServerFld.UseVisualStyleBackColor = true;
            this.ch_ServerFld.CheckedChanged += new System.EventHandler(this.ch_ServerFld_CheckedChanged);
            // 
            // ch_WorkFld
            // 
            this.ch_WorkFld.AutoSize = true;
            this.ch_WorkFld.Location = new System.Drawing.Point(7, 30);
            this.ch_WorkFld.Name = "ch_WorkFld";
            this.ch_WorkFld.Size = new System.Drawing.Size(110, 17);
            this.ch_WorkFld.TabIndex = 0;
            this.ch_WorkFld.Text = "рабочий каталог";
            this.ch_WorkFld.UseVisualStyleBackColor = true;
            this.ch_WorkFld.CheckedChanged += new System.EventHandler(this.ch_WorkFld_CheckedChanged);
            // 
            // Form_FolderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 299);
            this.Controls.Add(this.gr_Folders);
            this.Controls.Add(this.gr_fldSorce);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_FolderManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление папками";
            this.panel1.ResumeLayout(false);
            this.gr_Folders.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gr_fldSorce.ResumeLayout(false);
            this.gr_fldSorce.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_CreateFld;
        private System.Windows.Forms.GroupBox gr_Folders;
        private System.Windows.Forms.CheckBox ch_FreeNameFld;
        private System.Windows.Forms.CheckBox ch_OsnFld;
        private System.Windows.Forms.CheckBox ch_OtherFld;
        private System.Windows.Forms.CheckBox ch_ZadaniaFld;
        private System.Windows.Forms.CheckBox ch_StampFld;
        private System.Windows.Forms.CheckBox ch_GeoFld;
        private System.Windows.Forms.CheckBox ch_DogovorFld;
        private System.Windows.Forms.TextBox tb_NewNameFld;
        private System.Windows.Forms.GroupBox gr_fldSorce;
        private System.Windows.Forms.CheckBox ch_ServerFld;
        private System.Windows.Forms.CheckBox ch_WorkFld;
        private System.Windows.Forms.CheckBox ch_OutFld;
        private System.Windows.Forms.CheckBox ch_InFld;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ch_dw;
        private System.Windows.Forms.CheckBox ch_ds;
        private System.Windows.Forms.CheckBox ch_gs;
        private System.Windows.Forms.CheckBox ch_ss;
        private System.Windows.Forms.CheckBox ch_zs;
        private System.Windows.Forms.CheckBox ch_os;
        private System.Windows.Forms.CheckBox ch_oss;
        private System.Windows.Forms.CheckBox ch_ins;
        private System.Windows.Forms.CheckBox ch_outs;
        private System.Windows.Forms.CheckBox ch_gw;
        private System.Windows.Forms.CheckBox ch_sw;
        private System.Windows.Forms.CheckBox ch_zw;
        private System.Windows.Forms.CheckBox ch_ow;
        private System.Windows.Forms.CheckBox ch_osw;
        private System.Windows.Forms.CheckBox ch_inw;
        private System.Windows.Forms.CheckBox ch_outw;
        private System.Windows.Forms.Button btn_DeleteFld;
    }
}