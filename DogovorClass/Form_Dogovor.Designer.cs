
namespace DogovorClass
{
    partial class Form_Dogovor
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
            this.tb_NumDog = new System.Windows.Forms.TextBox();
            this.tb_NameDog = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SostavDog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_StatusDog = new System.Windows.Forms.ComboBox();
            this.cb_StadiaDog = new System.Windows.Forms.ComboBox();
            this.cb_GIPDog = new System.Windows.Forms.ComboBox();
            this.btn_SaveDogovor = new System.Windows.Forms.Button();
            this.btn_CloseDogovor = new System.Windows.Forms.Button();
            this.dtp_DateDog = new System.Windows.Forms.DateTimePicker();
            this.dtp_ToDateDog = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Valute = new System.Windows.Forms.ComboBox();
            this.panelNotes = new System.Windows.Forms.Panel();
            this.tb_CommentDog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_customer = new System.Windows.Forms.ComboBox();
            this.panelNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_NumDog
            // 
            this.tb_NumDog.Location = new System.Drawing.Point(9, 61);
            this.tb_NumDog.Name = "tb_NumDog";
            this.tb_NumDog.Size = new System.Drawing.Size(100, 20);
            this.tb_NumDog.TabIndex = 7;
            // 
            // tb_NameDog
            // 
            this.tb_NameDog.Location = new System.Drawing.Point(9, 97);
            this.tb_NameDog.Multiline = true;
            this.tb_NameDog.Name = "tb_NameDog";
            this.tb_NameDog.Size = new System.Drawing.Size(525, 70);
            this.tb_NameDog.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Действует до";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Статус";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "от";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Номер";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 295);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Комментарий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Название договора";
            // 
            // tb_SostavDog
            // 
            this.tb_SostavDog.Location = new System.Drawing.Point(9, 233);
            this.tb_SostavDog.Multiline = true;
            this.tb_SostavDog.Name = "tb_SostavDog";
            this.tb_SostavDog.Size = new System.Drawing.Size(525, 59);
            this.tb_SostavDog.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Состав проекта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "ГИП";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Стадия проектирования";
            // 
            // cb_StatusDog
            // 
            this.cb_StatusDog.FormattingEnabled = true;
            this.cb_StatusDog.Items.AddRange(new object[] {
            "подписан",
            "на согласовании руководства",
            "на согласовании Заказчика",
            "остановлен",
            "финансово закрыт",
            "закрыт"});
            this.cb_StatusDog.Location = new System.Drawing.Point(249, 61);
            this.cb_StatusDog.Name = "cb_StatusDog";
            this.cb_StatusDog.Size = new System.Drawing.Size(147, 21);
            this.cb_StatusDog.TabIndex = 29;
            // 
            // cb_StadiaDog
            // 
            this.cb_StadiaDog.FormattingEnabled = true;
            this.cb_StadiaDog.Location = new System.Drawing.Point(9, 190);
            this.cb_StadiaDog.Name = "cb_StadiaDog";
            this.cb_StadiaDog.Size = new System.Drawing.Size(184, 21);
            this.cb_StadiaDog.TabIndex = 30;
            // 
            // cb_GIPDog
            // 
            this.cb_GIPDog.FormattingEnabled = true;
            this.cb_GIPDog.Location = new System.Drawing.Point(210, 190);
            this.cb_GIPDog.Name = "cb_GIPDog";
            this.cb_GIPDog.Size = new System.Drawing.Size(186, 21);
            this.cb_GIPDog.TabIndex = 29;
            // 
            // btn_SaveDogovor
            // 
            this.btn_SaveDogovor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveDogovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveDogovor.Location = new System.Drawing.Point(570, 13);
            this.btn_SaveDogovor.Name = "btn_SaveDogovor";
            this.btn_SaveDogovor.Size = new System.Drawing.Size(95, 33);
            this.btn_SaveDogovor.TabIndex = 31;
            this.btn_SaveDogovor.Text = "Сохранить";
            this.btn_SaveDogovor.UseVisualStyleBackColor = true;
            this.btn_SaveDogovor.Click += new System.EventHandler(this.btn_SaveDogovor_Click);
            // 
            // btn_CloseDogovor
            // 
            this.btn_CloseDogovor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseDogovor.Location = new System.Drawing.Point(570, 52);
            this.btn_CloseDogovor.Name = "btn_CloseDogovor";
            this.btn_CloseDogovor.Size = new System.Drawing.Size(95, 33);
            this.btn_CloseDogovor.TabIndex = 31;
            this.btn_CloseDogovor.Text = "Закрыть";
            this.btn_CloseDogovor.UseVisualStyleBackColor = true;
            this.btn_CloseDogovor.Click += new System.EventHandler(this.btn_CloseDogovor_Click);
            // 
            // dtp_DateDog
            // 
            this.dtp_DateDog.Location = new System.Drawing.Point(118, 61);
            this.dtp_DateDog.Name = "dtp_DateDog";
            this.dtp_DateDog.Size = new System.Drawing.Size(125, 20);
            this.dtp_DateDog.TabIndex = 32;
            // 
            // dtp_ToDateDog
            // 
            this.dtp_ToDateDog.Location = new System.Drawing.Point(406, 61);
            this.dtp_ToDateDog.Name = "dtp_ToDateDog";
            this.dtp_ToDateDog.Size = new System.Drawing.Size(128, 20);
            this.dtp_ToDateDog.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Валюта";
            // 
            // cb_Valute
            // 
            this.cb_Valute.FormattingEnabled = true;
            this.cb_Valute.Items.AddRange(new object[] {
            "BYN",
            "BYR",
            "RUB",
            "USD",
            "EUR"});
            this.cb_Valute.Location = new System.Drawing.Point(406, 190);
            this.cb_Valute.Name = "cb_Valute";
            this.cb_Valute.Size = new System.Drawing.Size(128, 21);
            this.cb_Valute.TabIndex = 29;
            // 
            // panelNotes
            // 
            this.panelNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotes.Controls.Add(this.tb_CommentDog);
            this.panelNotes.Location = new System.Drawing.Point(12, 311);
            this.panelNotes.Name = "panelNotes";
            this.panelNotes.Size = new System.Drawing.Size(525, 95);
            this.panelNotes.TabIndex = 34;
            // 
            // tb_CommentDog
            // 
            this.tb_CommentDog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CommentDog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CommentDog.Location = new System.Drawing.Point(0, 0);
            this.tb_CommentDog.Name = "tb_CommentDog";
            this.tb_CommentDog.Size = new System.Drawing.Size(523, 93);
            this.tb_CommentDog.TabIndex = 0;
            this.tb_CommentDog.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Заказчик";
            // 
            // cb_customer
            // 
            this.cb_customer.FormattingEnabled = true;
            this.cb_customer.Items.AddRange(new object[] {
            "подписан",
            "на согласовании руководства",
            "на согласовании Заказчика",
            "остановлен",
            "финансово закрыт",
            "закрыт"});
            this.cb_customer.Location = new System.Drawing.Point(73, 20);
            this.cb_customer.Name = "cb_customer";
            this.cb_customer.Size = new System.Drawing.Size(461, 21);
            this.cb_customer.TabIndex = 29;
            // 
            // Form_Dogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(677, 419);
            this.Controls.Add(this.panelNotes);
            this.Controls.Add(this.dtp_ToDateDog);
            this.Controls.Add(this.dtp_DateDog);
            this.Controls.Add(this.btn_CloseDogovor);
            this.Controls.Add(this.btn_SaveDogovor);
            this.Controls.Add(this.cb_Valute);
            this.Controls.Add(this.cb_GIPDog);
            this.Controls.Add(this.cb_customer);
            this.Controls.Add(this.cb_StatusDog);
            this.Controls.Add(this.cb_StadiaDog);
            this.Controls.Add(this.tb_SostavDog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_NumDog);
            this.Controls.Add(this.tb_NameDog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label4);
            this.Name = "Form_Dogovor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор данных договора";
            this.panelNotes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_NumDog;
        private System.Windows.Forms.TextBox tb_NameDog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_SostavDog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_StatusDog;
        private System.Windows.Forms.ComboBox cb_StadiaDog;
        private System.Windows.Forms.ComboBox cb_GIPDog;
        private System.Windows.Forms.Button btn_SaveDogovor;
        private System.Windows.Forms.Button btn_CloseDogovor;
        private System.Windows.Forms.DateTimePicker dtp_DateDog;
        private System.Windows.Forms.DateTimePicker dtp_ToDateDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Valute;
        private System.Windows.Forms.Panel panelNotes;
        private System.Windows.Forms.RichTextBox tb_CommentDog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_customer;
    }
}