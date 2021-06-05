
namespace Zadania
{
    partial class Form_Zadania_Plan
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
            this.lb_Otdel_id_out = new System.Windows.Forms.Label();
            this.lb_Otdel_id_in = new System.Windows.Forms.Label();
            this.lb_Date_graf = new System.Windows.Forms.Label();
            this.lb_Date_fact = new System.Windows.Forms.Label();
            this.group_Otdel = new System.Windows.Forms.GroupBox();
            this.cb_otdel_P = new System.Windows.Forms.ComboBox();
            this.cb_otdel_V = new System.Windows.Forms.ComboBox();
            this.group_Date = new System.Windows.Forms.GroupBox();
            this.dtp_date_fakt = new System.Windows.Forms.DateTimePicker();
            this.dtp_date_plan = new System.Windows.Forms.DateTimePicker();
            this.group_Comments = new System.Windows.Forms.GroupBox();
            this.tb_comments = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_blok = new System.Windows.Forms.Label();
            this.cb_blok = new System.Windows.Forms.ComboBox();
            this.group_Otdel.SuspendLayout();
            this.group_Date.SuspendLayout();
            this.group_Comments.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Otdel_id_out
            // 
            this.lb_Otdel_id_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Otdel_id_out.AutoSize = true;
            this.lb_Otdel_id_out.Location = new System.Drawing.Point(6, 22);
            this.lb_Otdel_id_out.Name = "lb_Otdel_id_out";
            this.lb_Otdel_id_out.Size = new System.Drawing.Size(141, 13);
            this.lb_Otdel_id_out.TabIndex = 0;
            this.lb_Otdel_id_out.Text = "Отдел выдающий задание";
            // 
            // lb_Otdel_id_in
            // 
            this.lb_Otdel_id_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Otdel_id_in.AutoSize = true;
            this.lb_Otdel_id_in.Location = new System.Drawing.Point(6, 64);
            this.lb_Otdel_id_in.Name = "lb_Otdel_id_in";
            this.lb_Otdel_id_in.Size = new System.Drawing.Size(159, 13);
            this.lb_Otdel_id_in.TabIndex = 0;
            this.lb_Otdel_id_in.Text = "Отдел принимающий задание";
            // 
            // lb_Date_graf
            // 
            this.lb_Date_graf.AutoSize = true;
            this.lb_Date_graf.Location = new System.Drawing.Point(21, 26);
            this.lb_Date_graf.Name = "lb_Date_graf";
            this.lb_Date_graf.Size = new System.Drawing.Size(51, 13);
            this.lb_Date_graf.TabIndex = 0;
            this.lb_Date_graf.Text = "по плану";
            // 
            // lb_Date_fact
            // 
            this.lb_Date_fact.AutoSize = true;
            this.lb_Date_fact.Location = new System.Drawing.Point(21, 68);
            this.lb_Date_fact.Name = "lb_Date_fact";
            this.lb_Date_fact.Size = new System.Drawing.Size(52, 13);
            this.lb_Date_fact.TabIndex = 0;
            this.lb_Date_fact.Text = "по факту";
            // 
            // group_Otdel
            // 
            this.group_Otdel.Controls.Add(this.cb_otdel_P);
            this.group_Otdel.Controls.Add(this.cb_otdel_V);
            this.group_Otdel.Controls.Add(this.lb_Otdel_id_out);
            this.group_Otdel.Controls.Add(this.lb_Otdel_id_in);
            this.group_Otdel.Location = new System.Drawing.Point(12, 38);
            this.group_Otdel.Name = "group_Otdel";
            this.group_Otdel.Size = new System.Drawing.Size(336, 113);
            this.group_Otdel.TabIndex = 1;
            this.group_Otdel.TabStop = false;
            this.group_Otdel.Text = "Отделы";
            // 
            // cb_otdel_P
            // 
            this.cb_otdel_P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_otdel_P.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_otdel_P.DropDownWidth = 400;
            this.cb_otdel_P.FormattingEnabled = true;
            this.cb_otdel_P.Location = new System.Drawing.Point(9, 80);
            this.cb_otdel_P.Name = "cb_otdel_P";
            this.cb_otdel_P.Size = new System.Drawing.Size(321, 21);
            this.cb_otdel_P.TabIndex = 1;
            // 
            // cb_otdel_V
            // 
            this.cb_otdel_V.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_otdel_V.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_otdel_V.DropDownWidth = 400;
            this.cb_otdel_V.FormattingEnabled = true;
            this.cb_otdel_V.Location = new System.Drawing.Point(9, 39);
            this.cb_otdel_V.Name = "cb_otdel_V";
            this.cb_otdel_V.Size = new System.Drawing.Size(321, 21);
            this.cb_otdel_V.TabIndex = 1;
            // 
            // group_Date
            // 
            this.group_Date.Controls.Add(this.dtp_date_fakt);
            this.group_Date.Controls.Add(this.dtp_date_plan);
            this.group_Date.Controls.Add(this.lb_Date_graf);
            this.group_Date.Controls.Add(this.lb_Date_fact);
            this.group_Date.Location = new System.Drawing.Point(354, 12);
            this.group_Date.Name = "group_Date";
            this.group_Date.Size = new System.Drawing.Size(149, 139);
            this.group_Date.TabIndex = 2;
            this.group_Date.TabStop = false;
            this.group_Date.Text = "Сроки";
            // 
            // dtp_date_fakt
            // 
            this.dtp_date_fakt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_fakt.Location = new System.Drawing.Point(21, 82);
            this.dtp_date_fakt.Name = "dtp_date_fakt";
            this.dtp_date_fakt.Size = new System.Drawing.Size(101, 20);
            this.dtp_date_fakt.TabIndex = 1;
            // 
            // dtp_date_plan
            // 
            this.dtp_date_plan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_plan.Location = new System.Drawing.Point(21, 41);
            this.dtp_date_plan.Name = "dtp_date_plan";
            this.dtp_date_plan.Size = new System.Drawing.Size(101, 20);
            this.dtp_date_plan.TabIndex = 1;
            // 
            // group_Comments
            // 
            this.group_Comments.Controls.Add(this.tb_comments);
            this.group_Comments.Location = new System.Drawing.Point(12, 157);
            this.group_Comments.Name = "group_Comments";
            this.group_Comments.Size = new System.Drawing.Size(364, 139);
            this.group_Comments.TabIndex = 3;
            this.group_Comments.TabStop = false;
            this.group_Comments.Text = "Комментарий";
            // 
            // tb_comments
            // 
            this.tb_comments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_comments.Location = new System.Drawing.Point(3, 16);
            this.tb_comments.Multiline = true;
            this.tb_comments.Name = "tb_comments";
            this.tb_comments.Size = new System.Drawing.Size(358, 120);
            this.tb_comments.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(382, 217);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(118, 30);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(382, 253);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(118, 30);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Закрыть";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lb_blok
            // 
            this.lb_blok.AutoSize = true;
            this.lb_blok.Location = new System.Drawing.Point(18, 12);
            this.lb_blok.Name = "lb_blok";
            this.lb_blok.Size = new System.Drawing.Size(32, 13);
            this.lb_blok.TabIndex = 5;
            this.lb_blok.Text = "Блок";
            // 
            // cb_blok
            // 
            this.cb_blok.FormattingEnabled = true;
            this.cb_blok.Location = new System.Drawing.Point(58, 12);
            this.cb_blok.Name = "cb_blok";
            this.cb_blok.Size = new System.Drawing.Size(121, 21);
            this.cb_blok.TabIndex = 6;
            // 
            // Form_Zadania_Plan
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(512, 304);
            this.Controls.Add(this.cb_blok);
            this.Controls.Add(this.lb_blok);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.group_Comments);
            this.Controls.Add(this.group_Date);
            this.Controls.Add(this.group_Otdel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Zadania_Plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор данных о заданиях";
            this.group_Otdel.ResumeLayout(false);
            this.group_Otdel.PerformLayout();
            this.group_Date.ResumeLayout(false);
            this.group_Date.PerformLayout();
            this.group_Comments.ResumeLayout(false);
            this.group_Comments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Otdel_id_out;
        private System.Windows.Forms.Label lb_Otdel_id_in;
        private System.Windows.Forms.Label lb_Date_graf;
        private System.Windows.Forms.Label lb_Date_fact;
        private System.Windows.Forms.GroupBox group_Otdel;
        private System.Windows.Forms.ComboBox cb_otdel_P;
        private System.Windows.Forms.ComboBox cb_otdel_V;
        private System.Windows.Forms.GroupBox group_Date;
        private System.Windows.Forms.DateTimePicker dtp_date_fakt;
        private System.Windows.Forms.DateTimePicker dtp_date_plan;
        private System.Windows.Forms.GroupBox group_Comments;
        private System.Windows.Forms.TextBox tb_comments;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lb_blok;
        private System.Windows.Forms.ComboBox cb_blok;
    }
}