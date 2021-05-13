
namespace ProjectClass
{
    partial class Form_Project
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbl_Code_object = new System.Windows.Forms.Label();
            this.tb_Code = new System.Windows.Forms.TextBox();
            this.lbl_pName = new System.Windows.Forms.Label();
            this.tb_pName = new System.Windows.Forms.TextBox();
            this.lbl_pNotes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStroy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_linkLocalFld = new System.Windows.Forms.TextBox();
            this.tb_linkServerFld = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelNotes = new System.Windows.Forms.Panel();
            this.tb_pNotes = new System.Windows.Forms.RichTextBox();
            this.panelNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(599, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 29);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(599, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 29);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbl_Code_object
            // 
            this.lbl_Code_object.AutoSize = true;
            this.lbl_Code_object.Location = new System.Drawing.Point(13, 12);
            this.lbl_Code_object.Name = "lbl_Code_object";
            this.lbl_Code_object.Size = new System.Drawing.Size(70, 13);
            this.lbl_Code_object.TabIndex = 26;
            this.lbl_Code_object.Text = "Код проекта";
            // 
            // tb_Code
            // 
            this.tb_Code.Location = new System.Drawing.Point(12, 28);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.Size = new System.Drawing.Size(147, 20);
            this.tb_Code.TabIndex = 31;
            // 
            // lbl_pName
            // 
            this.lbl_pName.AutoSize = true;
            this.lbl_pName.Location = new System.Drawing.Point(13, 51);
            this.lbl_pName.Name = "lbl_pName";
            this.lbl_pName.Size = new System.Drawing.Size(57, 13);
            this.lbl_pName.TabIndex = 28;
            this.lbl_pName.Text = "Название";
            // 
            // tb_pName
            // 
            this.tb_pName.Location = new System.Drawing.Point(12, 67);
            this.tb_pName.Multiline = true;
            this.tb_pName.Name = "tb_pName";
            this.tb_pName.Size = new System.Drawing.Size(548, 112);
            this.tb_pName.TabIndex = 27;
            // 
            // lbl_pNotes
            // 
            this.lbl_pNotes.AutoSize = true;
            this.lbl_pNotes.Location = new System.Drawing.Point(13, 182);
            this.lbl_pNotes.Name = "lbl_pNotes";
            this.lbl_pNotes.Size = new System.Drawing.Size(57, 13);
            this.lbl_pNotes.TabIndex = 30;
            this.lbl_pNotes.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Площадка строительства";
            // 
            // cbStroy
            // 
            this.cbStroy.FormattingEnabled = true;
            this.cbStroy.Location = new System.Drawing.Point(179, 28);
            this.cbStroy.Name = "cbStroy";
            this.cbStroy.Size = new System.Drawing.Size(381, 21);
            this.cbStroy.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Статус";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "тендер",
            "остановлен",
            "в разработке",
            "финансово закрыт",
            "закрыт"});
            this.cb_Status.Location = new System.Drawing.Point(12, 438);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(302, 21);
            this.cb_Status.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Рабочий каталог";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Сетевой каталог";
            // 
            // tb_linkLocalFld
            // 
            this.tb_linkLocalFld.Location = new System.Drawing.Point(12, 483);
            this.tb_linkLocalFld.Name = "tb_linkLocalFld";
            this.tb_linkLocalFld.Size = new System.Drawing.Size(509, 20);
            this.tb_linkLocalFld.TabIndex = 41;
            // 
            // tb_linkServerFld
            // 
            this.tb_linkServerFld.Location = new System.Drawing.Point(12, 524);
            this.tb_linkServerFld.Name = "tb_linkServerFld";
            this.tb_linkServerFld.Size = new System.Drawing.Size(509, 20);
            this.tb_linkServerFld.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelNotes
            // 
            this.panelNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotes.Controls.Add(this.tb_pNotes);
            this.panelNotes.Location = new System.Drawing.Point(13, 198);
            this.panelNotes.Name = "panelNotes";
            this.panelNotes.Size = new System.Drawing.Size(547, 205);
            this.panelNotes.TabIndex = 44;
            // 
            // tb_pNotes
            // 
            this.tb_pNotes.AcceptsTab = true;
            this.tb_pNotes.AutoWordSelection = true;
            this.tb_pNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_pNotes.HideSelection = false;
            this.tb_pNotes.Location = new System.Drawing.Point(0, 0);
            this.tb_pNotes.Name = "tb_pNotes";
            this.tb_pNotes.Size = new System.Drawing.Size(545, 203);
            this.tb_pNotes.TabIndex = 44;
            this.tb_pNotes.Text = "";
            // 
            // Form_Project
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(711, 598);
            this.Controls.Add(this.panelNotes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_linkServerFld);
            this.Controls.Add(this.tb_linkLocalFld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStroy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Code_object);
            this.Controls.Add(this.tb_Code);
            this.Controls.Add(this.lbl_pName);
            this.Controls.Add(this.tb_pName);
            this.Controls.Add(this.lbl_pNotes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(727, 465);
            this.Name = "Form_Project";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор данных проекта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Project_FormClosed);
            this.panelNotes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbl_Code_object;
        private System.Windows.Forms.TextBox tb_Code;
        private System.Windows.Forms.Label lbl_pName;
        private System.Windows.Forms.TextBox tb_pName;
        private System.Windows.Forms.Label lbl_pNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStroy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_linkLocalFld;
        private System.Windows.Forms.TextBox tb_linkServerFld;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelNotes;
        private System.Windows.Forms.RichTextBox tb_pNotes;
    }
}