namespace GW_Dogovor
{
    partial class Form_editDocument
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
            this.lb_NameDoc = new System.Windows.Forms.Label();
            this.lb_NumbeDoc = new System.Windows.Forms.Label();
            this.lb_DataDoc = new System.Windows.Forms.Label();
            this.lb_Notes = new System.Windows.Forms.Label();
            this.lb_TypeDoc = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.lb_PathDoc = new System.Windows.Forms.Label();
            this.tb_NameDoc = new System.Windows.Forms.TextBox();
            this.cb_TypeDoc = new System.Windows.Forms.ComboBox();
            this.tb_NumbeDoc = new System.Windows.Forms.TextBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.rtb_Notes = new System.Windows.Forms.RichTextBox();
            this.tb_PathDoc = new System.Windows.Forms.TextBox();
            this.btn_PathDoc = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.dtp_DateDoc = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lb_NameDoc
            // 
            this.lb_NameDoc.AutoSize = true;
            this.lb_NameDoc.Location = new System.Drawing.Point(9, 63);
            this.lb_NameDoc.Name = "lb_NameDoc";
            this.lb_NameDoc.Size = new System.Drawing.Size(114, 13);
            this.lb_NameDoc.TabIndex = 0;
            this.lb_NameDoc.Text = "Название документа";
            // 
            // lb_NumbeDoc
            // 
            this.lb_NumbeDoc.AutoSize = true;
            this.lb_NumbeDoc.Location = new System.Drawing.Point(12, 112);
            this.lb_NumbeDoc.Name = "lb_NumbeDoc";
            this.lb_NumbeDoc.Size = new System.Drawing.Size(42, 13);
            this.lb_NumbeDoc.TabIndex = 1;
            this.lb_NumbeDoc.Text = "№ док.";
            // 
            // lb_DataDoc
            // 
            this.lb_DataDoc.AutoSize = true;
            this.lb_DataDoc.Location = new System.Drawing.Point(124, 112);
            this.lb_DataDoc.Name = "lb_DataDoc";
            this.lb_DataDoc.Size = new System.Drawing.Size(33, 13);
            this.lb_DataDoc.TabIndex = 2;
            this.lb_DataDoc.Text = "Дата";
            // 
            // lb_Notes
            // 
            this.lb_Notes.AutoSize = true;
            this.lb_Notes.Location = new System.Drawing.Point(12, 164);
            this.lb_Notes.Name = "lb_Notes";
            this.lb_Notes.Size = new System.Drawing.Size(57, 13);
            this.lb_Notes.TabIndex = 3;
            this.lb_Notes.Text = "Описание";
            // 
            // lb_TypeDoc
            // 
            this.lb_TypeDoc.AutoSize = true;
            this.lb_TypeDoc.Location = new System.Drawing.Point(12, 9);
            this.lb_TypeDoc.Name = "lb_TypeDoc";
            this.lb_TypeDoc.Size = new System.Drawing.Size(83, 13);
            this.lb_TypeDoc.TabIndex = 4;
            this.lb_TypeDoc.Text = "Тип документа";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(240, 112);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(41, 13);
            this.lb_Status.TabIndex = 5;
            this.lb_Status.Text = "Статус";
            // 
            // lb_PathDoc
            // 
            this.lb_PathDoc.AutoSize = true;
            this.lb_PathDoc.Location = new System.Drawing.Point(12, 415);
            this.lb_PathDoc.Name = "lb_PathDoc";
            this.lb_PathDoc.Size = new System.Drawing.Size(96, 13);
            this.lb_PathDoc.TabIndex = 6;
            this.lb_PathDoc.Text = "Путь к документу";
            // 
            // tb_NameDoc
            // 
            this.tb_NameDoc.Location = new System.Drawing.Point(12, 79);
            this.tb_NameDoc.Name = "tb_NameDoc";
            this.tb_NameDoc.Size = new System.Drawing.Size(433, 20);
            this.tb_NameDoc.TabIndex = 7;
            // 
            // cb_TypeDoc
            // 
            this.cb_TypeDoc.FormattingEnabled = true;
            this.cb_TypeDoc.Location = new System.Drawing.Point(12, 26);
            this.cb_TypeDoc.Name = "cb_TypeDoc";
            this.cb_TypeDoc.Size = new System.Drawing.Size(433, 21);
            this.cb_TypeDoc.TabIndex = 8;
            // 
            // tb_NumbeDoc
            // 
            this.tb_NumbeDoc.Location = new System.Drawing.Point(12, 129);
            this.tb_NumbeDoc.Name = "tb_NumbeDoc";
            this.tb_NumbeDoc.Size = new System.Drawing.Size(100, 20);
            this.tb_NumbeDoc.TabIndex = 9;
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "утвержден",
            "отправлен",
            "в работе",
            "на согласовании"});
            this.cb_Status.Location = new System.Drawing.Point(243, 129);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(202, 21);
            this.cb_Status.TabIndex = 11;
            // 
            // rtb_Notes
            // 
            this.rtb_Notes.Location = new System.Drawing.Point(12, 181);
            this.rtb_Notes.Name = "rtb_Notes";
            this.rtb_Notes.Size = new System.Drawing.Size(433, 218);
            this.rtb_Notes.TabIndex = 12;
            this.rtb_Notes.Text = "";
            // 
            // tb_PathDoc
            // 
            this.tb_PathDoc.Location = new System.Drawing.Point(12, 432);
            this.tb_PathDoc.Name = "tb_PathDoc";
            this.tb_PathDoc.ReadOnly = true;
            this.tb_PathDoc.Size = new System.Drawing.Size(400, 20);
            this.tb_PathDoc.TabIndex = 13;
            // 
            // btn_PathDoc
            // 
            this.btn_PathDoc.Location = new System.Drawing.Point(419, 432);
            this.btn_PathDoc.Name = "btn_PathDoc";
            this.btn_PathDoc.Size = new System.Drawing.Size(26, 20);
            this.btn_PathDoc.TabIndex = 14;
            this.btn_PathDoc.Text = "...";
            this.btn_PathDoc.UseVisualStyleBackColor = true;
            this.btn_PathDoc.Click += new System.EventHandler(this.btn_PathDoc_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(472, 23);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 29);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Location = new System.Drawing.Point(472, 58);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(89, 29);
            this.bt_Cancel.TabIndex = 15;
            this.bt_Cancel.Text = "Закрыть";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            // 
            // dtp_DateDoc
            // 
            this.dtp_DateDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateDoc.Location = new System.Drawing.Point(127, 130);
            this.dtp_DateDoc.Name = "dtp_DateDoc";
            this.dtp_DateDoc.Size = new System.Drawing.Size(100, 20);
            this.dtp_DateDoc.TabIndex = 16;
            this.dtp_DateDoc.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // Form_editDocument
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Cancel;
            this.ClientSize = new System.Drawing.Size(577, 478);
            this.Controls.Add(this.dtp_DateDoc);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_PathDoc);
            this.Controls.Add(this.tb_PathDoc);
            this.Controls.Add(this.rtb_Notes);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.tb_NumbeDoc);
            this.Controls.Add(this.cb_TypeDoc);
            this.Controls.Add(this.tb_NameDoc);
            this.Controls.Add(this.lb_PathDoc);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_TypeDoc);
            this.Controls.Add(this.lb_Notes);
            this.Controls.Add(this.lb_DataDoc);
            this.Controls.Add(this.lb_NumbeDoc);
            this.Controls.Add(this.lb_NameDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_editDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор данных документа";
            this.Load += new System.EventHandler(this.Form_docEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_NameDoc;
        private System.Windows.Forms.Label lb_NumbeDoc;
        private System.Windows.Forms.Label lb_DataDoc;
        private System.Windows.Forms.Label lb_Notes;
        private System.Windows.Forms.Label lb_TypeDoc;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_PathDoc;
        private System.Windows.Forms.TextBox tb_NameDoc;
        private System.Windows.Forms.ComboBox cb_TypeDoc;
        private System.Windows.Forms.TextBox tb_NumbeDoc;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.RichTextBox rtb_Notes;
        private System.Windows.Forms.TextBox tb_PathDoc;
        private System.Windows.Forms.Button btn_PathDoc;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.DateTimePicker dtp_DateDoc;
    }
}