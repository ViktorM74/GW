
namespace ObjectClass
{
    partial class Form_Object
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
            this.label28 = new System.Windows.Forms.Label();
            this.tb_TitleObject = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_CodeObject = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_NameObject = new System.Windows.Forms.TextBox();
            this.tb_NameUObject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_GIPObject = new System.Windows.Forms.ComboBox();
            this.panelComments = new System.Windows.Forms.Panel();
            this.tb_CommentsObj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Stadia = new System.Windows.Forms.ComboBox();
            this.panelButton.SuspendLayout();
            this.panelComments.SuspendLayout();
            this.SuspendLayout();
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 132);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 13);
            this.label28.TabIndex = 18;
            this.label28.Text = "ГИП";
            // 
            // tb_TitleObject
            // 
            this.tb_TitleObject.BackColor = System.Drawing.SystemColors.Window;
            this.tb_TitleObject.Location = new System.Drawing.Point(386, 63);
            this.tb_TitleObject.Name = "tb_TitleObject";
            this.tb_TitleObject.Size = new System.Drawing.Size(136, 20);
            this.tb_TitleObject.TabIndex = 16;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(383, 46);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "Титул";
            // 
            // tb_CodeObject
            // 
            this.tb_CodeObject.BackColor = System.Drawing.SystemColors.Window;
            this.tb_CodeObject.Location = new System.Drawing.Point(386, 21);
            this.tb_CodeObject.Name = "tb_CodeObject";
            this.tb_CodeObject.Size = new System.Drawing.Size(136, 20);
            this.tb_CodeObject.TabIndex = 17;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(383, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Шифр";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 68);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(102, 13);
            this.label27.TabIndex = 13;
            this.label27.Text = "Название объекта";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Название установки";
            // 
            // tb_NameObject
            // 
            this.tb_NameObject.BackColor = System.Drawing.SystemColors.Window;
            this.tb_NameObject.Location = new System.Drawing.Point(12, 84);
            this.tb_NameObject.Multiline = true;
            this.tb_NameObject.Name = "tb_NameObject";
            this.tb_NameObject.Size = new System.Drawing.Size(368, 45);
            this.tb_NameObject.TabIndex = 8;
            // 
            // tb_NameUObject
            // 
            this.tb_NameUObject.BackColor = System.Drawing.SystemColors.Window;
            this.tb_NameUObject.Location = new System.Drawing.Point(12, 21);
            this.tb_NameUObject.Multiline = true;
            this.tb_NameUObject.Name = "tb_NameUObject";
            this.tb_NameUObject.Size = new System.Drawing.Size(368, 45);
            this.tb_NameUObject.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Комментарий";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btn_Close);
            this.panelButton.Controls.Add(this.btn_Save);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButton.Location = new System.Drawing.Point(529, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(126, 351);
            this.panelButton.TabIndex = 20;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(12, 53);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(102, 33);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(12, 10);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 33);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_GIPObject
            // 
            this.tb_GIPObject.FormattingEnabled = true;
            this.tb_GIPObject.Location = new System.Drawing.Point(12, 148);
            this.tb_GIPObject.Name = "tb_GIPObject";
            this.tb_GIPObject.Size = new System.Drawing.Size(204, 21);
            this.tb_GIPObject.TabIndex = 21;
            // 
            // panelComments
            // 
            this.panelComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelComments.Controls.Add(this.tb_CommentsObj);
            this.panelComments.Location = new System.Drawing.Point(12, 189);
            this.panelComments.Name = "panelComments";
            this.panelComments.Size = new System.Drawing.Size(510, 150);
            this.panelComments.TabIndex = 22;
            // 
            // tb_CommentsObj
            // 
            this.tb_CommentsObj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CommentsObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CommentsObj.Location = new System.Drawing.Point(0, 0);
            this.tb_CommentsObj.Name = "tb_CommentsObj";
            this.tb_CommentsObj.Size = new System.Drawing.Size(508, 148);
            this.tb_CommentsObj.TabIndex = 0;
            this.tb_CommentsObj.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Стадия";
            // 
            // cb_Stadia
            // 
            this.cb_Stadia.FormattingEnabled = true;
            this.cb_Stadia.Location = new System.Drawing.Point(229, 148);
            this.cb_Stadia.Name = "cb_Stadia";
            this.cb_Stadia.Size = new System.Drawing.Size(151, 21);
            this.cb_Stadia.TabIndex = 21;
            // 
            // Form_Object
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(655, 351);
            this.Controls.Add(this.panelComments);
            this.Controls.Add(this.cb_Stadia);
            this.Controls.Add(this.tb_GIPObject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.tb_TitleObject);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tb_CodeObject);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tb_NameObject);
            this.Controls.Add(this.tb_NameUObject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Object";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор данных объекта";
            this.panelButton.ResumeLayout(false);
            this.panelComments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_TitleObject;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_CodeObject;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_NameObject;
        private System.Windows.Forms.TextBox tb_NameUObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox tb_GIPObject;
        private System.Windows.Forms.Panel panelComments;
        private System.Windows.Forms.RichTextBox tb_CommentsObj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Stadia;
    }
}