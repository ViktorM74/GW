﻿using DateTimePickerNullable;

namespace PRD
{
    partial class Form_PRD
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
            this.lb_Mark = new System.Windows.Forms.Label();
            this.tb_Mark = new System.Windows.Forms.TextBox();
            this.lb_Data_plan = new System.Windows.Forms.Label();
            this.dtp_Data_plan = new System.Windows.Forms.DateTimePicker();
            this.dtp_Data_fakt = new System.Windows.Forms.DateTimePicker();
            this.chb_GIP_viz = new System.Windows.Forms.CheckBox();
            this.chb_Arhiv = new System.Windows.Forms.CheckBox();
            this.dtp_Data_GIP_viz = new System.Windows.Forms.DateTimePicker();
            this.lb_Notes = new System.Windows.Forms.Label();
            this.tb_Notes = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.group_Mark_project = new System.Windows.Forms.GroupBox();
            this.cb_blok = new System.Windows.Forms.ComboBox();
            this.lb_blok = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.group_Mark_project.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Mark
            // 
            this.lb_Mark.AutoSize = true;
            this.lb_Mark.Location = new System.Drawing.Point(14, 22);
            this.lb_Mark.Name = "lb_Mark";
            this.lb_Mark.Size = new System.Drawing.Size(29, 13);
            this.lb_Mark.TabIndex = 0;
            this.lb_Mark.Text = "Имя";
            // 
            // tb_Mark
            // 
            this.tb_Mark.Location = new System.Drawing.Point(17, 38);
            this.tb_Mark.Name = "tb_Mark";
            this.tb_Mark.Size = new System.Drawing.Size(74, 20);
            this.tb_Mark.TabIndex = 1;
            // 
            // lb_Data_plan
            // 
            this.lb_Data_plan.AutoSize = true;
            this.lb_Data_plan.Location = new System.Drawing.Point(279, 22);
            this.lb_Data_plan.Name = "lb_Data_plan";
            this.lb_Data_plan.Size = new System.Drawing.Size(80, 13);
            this.lb_Data_plan.TabIndex = 0;
            this.lb_Data_plan.Text = "Дата по плану";
            // 
            // dtp_Data_plan
            // 
            this.dtp_Data_plan.Checked = false;
            this.dtp_Data_plan.Location = new System.Drawing.Point(282, 38);
            this.dtp_Data_plan.Name = "dtp_Data_plan";
            this.dtp_Data_plan.Size = new System.Drawing.Size(151, 20);
            this.dtp_Data_plan.TabIndex = 2;
            this.dtp_Data_plan.ValueChanged += new System.EventHandler(this.dtp_Data_plan_ValueChanged);
            // 
            // dtp_Data_fakt
            // 
            this.dtp_Data_fakt.Location = new System.Drawing.Point(125, 59);
            this.dtp_Data_fakt.Name = "dtp_Data_fakt";
            this.dtp_Data_fakt.Size = new System.Drawing.Size(195, 20);
            this.dtp_Data_fakt.TabIndex = 2;
            this.dtp_Data_fakt.CloseUp += new System.EventHandler(this.dtp_Data_fakt_CloseUp);
            this.dtp_Data_fakt.ValueChanged += new System.EventHandler(this.dtp_Data_fakt_ValueChanged);
            // 
            // chb_GIP_viz
            // 
            this.chb_GIP_viz.AutoSize = true;
            this.chb_GIP_viz.Location = new System.Drawing.Point(24, 23);
            this.chb_GIP_viz.Name = "chb_GIP_viz";
            this.chb_GIP_viz.Size = new System.Drawing.Size(81, 17);
            this.chb_GIP_viz.TabIndex = 3;
            this.chb_GIP_viz.Text = "виза ГИПа";
            this.chb_GIP_viz.UseVisualStyleBackColor = true;
            // 
            // chb_Arhiv
            // 
            this.chb_Arhiv.AutoSize = true;
            this.chb_Arhiv.Location = new System.Drawing.Point(24, 59);
            this.chb_Arhiv.Name = "chb_Arhiv";
            this.chb_Arhiv.Size = new System.Drawing.Size(97, 17);
            this.chb_Arhiv.TabIndex = 3;
            this.chb_Arhiv.Text = "сдано в архив";
            this.chb_Arhiv.UseVisualStyleBackColor = true;
            // 
            // dtp_Data_GIP_viz
            // 
            this.dtp_Data_GIP_viz.Location = new System.Drawing.Point(125, 23);
            this.dtp_Data_GIP_viz.Name = "dtp_Data_GIP_viz";
            this.dtp_Data_GIP_viz.Size = new System.Drawing.Size(195, 20);
            this.dtp_Data_GIP_viz.TabIndex = 2;
            this.dtp_Data_GIP_viz.CloseUp += new System.EventHandler(this.dtp_Data_GIP_viz_CloseUp);
            this.dtp_Data_GIP_viz.ValueChanged += new System.EventHandler(this.dtp_Data_GIP_viz_ValueChanged);
            // 
            // lb_Notes
            // 
            this.lb_Notes.AutoSize = true;
            this.lb_Notes.Location = new System.Drawing.Point(14, 71);
            this.lb_Notes.Name = "lb_Notes";
            this.lb_Notes.Size = new System.Drawing.Size(57, 13);
            this.lb_Notes.TabIndex = 0;
            this.lb_Notes.Text = "Описание";
            // 
            // tb_Notes
            // 
            this.tb_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Notes.Location = new System.Drawing.Point(17, 87);
            this.tb_Notes.Multiline = true;
            this.tb_Notes.Name = "tb_Notes";
            this.tb_Notes.Size = new System.Drawing.Size(416, 157);
            this.tb_Notes.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Location = new System.Drawing.Point(484, 301);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(106, 34);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(484, 341);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(106, 34);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Закрыть";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // group_Mark_project
            // 
            this.group_Mark_project.Controls.Add(this.cb_blok);
            this.group_Mark_project.Controls.Add(this.dtp_Data_plan);
            this.group_Mark_project.Controls.Add(this.lb_Data_plan);
            this.group_Mark_project.Controls.Add(this.lb_blok);
            this.group_Mark_project.Controls.Add(this.tb_Mark);
            this.group_Mark_project.Controls.Add(this.lb_Mark);
            this.group_Mark_project.Controls.Add(this.tb_Notes);
            this.group_Mark_project.Controls.Add(this.lb_Notes);
            this.group_Mark_project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_Mark_project.Location = new System.Drawing.Point(10, 10);
            this.group_Mark_project.Margin = new System.Windows.Forms.Padding(10);
            this.group_Mark_project.Name = "group_Mark_project";
            this.group_Mark_project.Size = new System.Drawing.Size(450, 261);
            this.group_Mark_project.TabIndex = 5;
            this.group_Mark_project.TabStop = false;
            this.group_Mark_project.Text = "Марка / Комплект";
            // 
            // cb_blok
            // 
            this.cb_blok.FormattingEnabled = true;
            this.cb_blok.Location = new System.Drawing.Point(118, 37);
            this.cb_blok.Name = "cb_blok";
            this.cb_blok.Size = new System.Drawing.Size(93, 21);
            this.cb_blok.TabIndex = 3;
            // 
            // lb_blok
            // 
            this.lb_blok.AutoSize = true;
            this.lb_blok.Location = new System.Drawing.Point(115, 22);
            this.lb_blok.Name = "lb_blok";
            this.lb_blok.Size = new System.Drawing.Size(32, 13);
            this.lb_blok.TabIndex = 0;
            this.lb_blok.Text = "Блок";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.group_Mark_project, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.36815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.63185F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 383);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb_Arhiv);
            this.groupBox2.Controls.Add(this.chb_GIP_viz);
            this.groupBox2.Controls.Add(this.dtp_Data_fakt);
            this.groupBox2.Controls.Add(this.dtp_Data_GIP_viz);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 96);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исполнение";
            // 
            // Form_PRD
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(602, 383);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_PRD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор данных марки проекта";
            this.group_Mark_project.ResumeLayout(false);
            this.group_Mark_project.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Mark;
        private System.Windows.Forms.TextBox tb_Mark;
        private System.Windows.Forms.Label lb_Data_plan;
        private System.Windows.Forms.DateTimePicker dtp_Data_plan;
        private System.Windows.Forms.DateTimePicker dtp_Data_fakt;
        private System.Windows.Forms.CheckBox chb_GIP_viz;
        private System.Windows.Forms.CheckBox chb_Arhiv;
        private System.Windows.Forms.DateTimePicker dtp_Data_GIP_viz;
        private System.Windows.Forms.Label lb_Notes;
        private System.Windows.Forms.TextBox tb_Notes;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox group_Mark_project;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_blok;
        private System.Windows.Forms.ComboBox cb_blok;
    }
}