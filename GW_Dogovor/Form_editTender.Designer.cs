namespace GW_Dogovor
{
    partial class Form_editTender
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
            this.tb_Sostav = new System.Windows.Forms.TextBox();
            this.dtp_Tender = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Customer = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.cb_Customer = new System.Windows.Forms.ComboBox();
            this.cb_Stadia = new System.Windows.Forms.ComboBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.cb_GIP = new System.Windows.Forms.ComboBox();
            this.panelNotes = new System.Windows.Forms.Panel();
            this.tb_Comment = new System.Windows.Forms.RichTextBox();
            this.panelNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Sostav
            // 
            this.tb_Sostav.Location = new System.Drawing.Point(12, 233);
            this.tb_Sostav.Multiline = true;
            this.tb_Sostav.Name = "tb_Sostav";
            this.tb_Sostav.Size = new System.Drawing.Size(359, 59);
            this.tb_Sostav.TabIndex = 22;
            // 
            // dtp_Tender
            // 
            this.dtp_Tender.Checked = false;
            this.dtp_Tender.Location = new System.Drawing.Point(206, 151);
            this.dtp_Tender.Name = "dtp_Tender";
            this.dtp_Tender.Size = new System.Drawing.Size(167, 20);
            this.dtp_Tender.TabIndex = 18;
            this.dtp_Tender.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(12, 67);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(359, 65);
            this.tb_Name.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Состав проекта";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Комментарий";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ГИП";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Статус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата подачи предложения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Стадия проектирования";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(9, 51);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(57, 13);
            this.lb_Name.TabIndex = 13;
            this.lb_Name.Text = "Название";
            // 
            // lb_Customer
            // 
            this.lb_Customer.AutoSize = true;
            this.lb_Customer.Location = new System.Drawing.Point(9, 11);
            this.lb_Customer.Name = "lb_Customer";
            this.lb_Customer.Size = new System.Drawing.Size(55, 13);
            this.lb_Customer.TabIndex = 14;
            this.lb_Customer.Text = "Заказчик";
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(392, 25);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 34);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(392, 65);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(91, 34);
            this.btn_Close.TabIndex = 23;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // cb_Customer
            // 
            this.cb_Customer.FormattingEnabled = true;
            this.cb_Customer.Location = new System.Drawing.Point(12, 27);
            this.cb_Customer.Name = "cb_Customer";
            this.cb_Customer.Size = new System.Drawing.Size(359, 21);
            this.cb_Customer.TabIndex = 24;
            // 
            // cb_Stadia
            // 
            this.cb_Stadia.FormattingEnabled = true;
            this.cb_Stadia.Location = new System.Drawing.Point(11, 150);
            this.cb_Stadia.Name = "cb_Stadia";
            this.cb_Stadia.Size = new System.Drawing.Size(184, 21);
            this.cb_Stadia.TabIndex = 24;
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "подготовка",
            "согласование",
            "отправлен",
            "проигран",
            "выигран",
            "не состоялся"});
            this.cb_Status.Location = new System.Drawing.Point(11, 192);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(184, 21);
            this.cb_Status.TabIndex = 24;
            // 
            // cb_GIP
            // 
            this.cb_GIP.FormattingEnabled = true;
            this.cb_GIP.Location = new System.Drawing.Point(206, 192);
            this.cb_GIP.Name = "cb_GIP";
            this.cb_GIP.Size = new System.Drawing.Size(167, 21);
            this.cb_GIP.TabIndex = 24;
            // 
            // panelNotes
            // 
            this.panelNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotes.Controls.Add(this.tb_Comment);
            this.panelNotes.Location = new System.Drawing.Point(12, 311);
            this.panelNotes.Name = "panelNotes";
            this.panelNotes.Size = new System.Drawing.Size(359, 109);
            this.panelNotes.TabIndex = 25;
            // 
            // tb_Comment
            // 
            this.tb_Comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Comment.Location = new System.Drawing.Point(0, 0);
            this.tb_Comment.Name = "tb_Comment";
            this.tb_Comment.Size = new System.Drawing.Size(357, 107);
            this.tb_Comment.TabIndex = 0;
            this.tb_Comment.Text = "";
            // 
            // Form_editTender
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(492, 432);
            this.Controls.Add(this.panelNotes);
            this.Controls.Add(this.cb_GIP);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.cb_Stadia);
            this.Controls.Add(this.cb_Customer);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Sostav);
            this.Controls.Add(this.dtp_Tender);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_Customer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_editTender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор данных";
            this.panelNotes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Sostav;
        private System.Windows.Forms.DateTimePicker dtp_Tender;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Customer;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox cb_Customer;
        private System.Windows.Forms.ComboBox cb_Stadia;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.ComboBox cb_GIP;
        private System.Windows.Forms.Panel panelNotes;
        private System.Windows.Forms.RichTextBox tb_Comment;
    }
}