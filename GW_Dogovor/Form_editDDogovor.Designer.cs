namespace GW_Dogovor
{
    partial class Form_editDDogovor
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
            this.tb_NumDD = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dtp_DateDD = new System.Windows.Forms.DateTimePicker();
            this.cb_StatusDD = new System.Windows.Forms.ComboBox();
            this.dtp_ToDateDD = new System.Windows.Forms.DateTimePicker();
            this.panelNotes = new System.Windows.Forms.Panel();
            this.tb_NotesDD = new System.Windows.Forms.RichTextBox();
            this.panelNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_NumDD
            // 
            this.tb_NumDD.Location = new System.Drawing.Point(15, 23);
            this.tb_NumDD.Name = "tb_NumDD";
            this.tb_NumDD.Size = new System.Drawing.Size(100, 20);
            this.tb_NumDD.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(438, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Действует до";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(243, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Статус";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(118, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "от";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Номер";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 43);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(139, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Описание допсоглашения";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(573, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(98, 34);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(573, 52);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(98, 34);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // dtp_DateDD
            // 
            this.dtp_DateDD.CustomFormat = "dd.MM.YYYY";
            this.dtp_DateDD.Location = new System.Drawing.Point(121, 23);
            this.dtp_DateDD.Name = "dtp_DateDD";
            this.dtp_DateDD.Size = new System.Drawing.Size(119, 20);
            this.dtp_DateDD.TabIndex = 16;
            // 
            // cb_StatusDD
            // 
            this.cb_StatusDD.FormattingEnabled = true;
            this.cb_StatusDD.Items.AddRange(new object[] {
            "подготовка",
            "согласование",
            "отправлен",
            "подписан",
            "закрыт"});
            this.cb_StatusDD.Location = new System.Drawing.Point(246, 23);
            this.cb_StatusDD.Name = "cb_StatusDD";
            this.cb_StatusDD.Size = new System.Drawing.Size(189, 21);
            this.cb_StatusDD.TabIndex = 17;
            // 
            // dtp_ToDateDD
            // 
            this.dtp_ToDateDD.Location = new System.Drawing.Point(441, 23);
            this.dtp_ToDateDD.Name = "dtp_ToDateDD";
            this.dtp_ToDateDD.Size = new System.Drawing.Size(119, 20);
            this.dtp_ToDateDD.TabIndex = 16;
            // 
            // panelNotes
            // 
            this.panelNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotes.Controls.Add(this.tb_NotesDD);
            this.panelNotes.Location = new System.Drawing.Point(15, 59);
            this.panelNotes.Name = "panelNotes";
            this.panelNotes.Size = new System.Drawing.Size(545, 229);
            this.panelNotes.TabIndex = 20;
            // 
            // tb_NotesDD
            // 
            this.tb_NotesDD.AcceptsTab = true;
            this.tb_NotesDD.AutoWordSelection = true;
            this.tb_NotesDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NotesDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_NotesDD.Location = new System.Drawing.Point(0, 0);
            this.tb_NotesDD.Name = "tb_NotesDD";
            this.tb_NotesDD.Size = new System.Drawing.Size(543, 227);
            this.tb_NotesDD.TabIndex = 20;
            this.tb_NotesDD.Text = "";
            // 
            // Form_editDDogovor
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(683, 300);
            this.Controls.Add(this.panelNotes);
            this.Controls.Add(this.cb_StatusDD);
            this.Controls.Add(this.dtp_ToDateDD);
            this.Controls.Add(this.dtp_DateDD);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_NumDD);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Name = "Form_editDDogovor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор данных дополнительного соглашения";
            this.panelNotes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_NumDD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DateTimePicker dtp_DateDD;
        private System.Windows.Forms.ComboBox cb_StatusDD;
        private System.Windows.Forms.DateTimePicker dtp_ToDateDD;
        private System.Windows.Forms.Panel panelNotes;
        private System.Windows.Forms.RichTextBox tb_NotesDD;
    }
}