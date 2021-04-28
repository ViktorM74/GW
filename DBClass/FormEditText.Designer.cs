namespace DBClass
{
    partial class FormEditText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditText));
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnCloseText = new System.Windows.Forms.Button();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.panelText = new System.Windows.Forms.Panel();
            this.rt_Text = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cb_Fonts = new System.Windows.Forms.ToolStripComboBox();
            this.cb_ColorFont = new System.Windows.Forms.ToolStripComboBox();
            this.cb_SizeFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btn_RegularStyle = new System.Windows.Forms.ToolStripButton();
            this.btn_BlodStyle = new System.Windows.Forms.ToolStripButton();
            this.btn_CursiveStyle = new System.Windows.Forms.ToolStripButton();
            this.panelBtn.SuspendLayout();
            this.panelText.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.btnCloseText);
            this.panelBtn.Controls.Add(this.btnSaveText);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtn.Location = new System.Drawing.Point(547, 0);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(119, 298);
            this.panelBtn.TabIndex = 0;
            // 
            // btnCloseText
            // 
            this.btnCloseText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseText.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseText.Location = new System.Drawing.Point(14, 46);
            this.btnCloseText.Name = "btnCloseText";
            this.btnCloseText.Size = new System.Drawing.Size(92, 28);
            this.btnCloseText.TabIndex = 2;
            this.btnCloseText.Text = "Закрыть";
            this.btnCloseText.UseVisualStyleBackColor = true;
            // 
            // btnSaveText
            // 
            this.btnSaveText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveText.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveText.Location = new System.Drawing.Point(14, 12);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(92, 28);
            this.btnSaveText.TabIndex = 1;
            this.btnSaveText.Text = "Сохранить";
            this.btnSaveText.UseVisualStyleBackColor = true;
            // 
            // panelText
            // 
            this.panelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelText.Controls.Add(this.rt_Text);
            this.panelText.Controls.Add(this.toolStrip2);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelText.Location = new System.Drawing.Point(0, 0);
            this.panelText.Name = "panelText";
            this.panelText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelText.Size = new System.Drawing.Size(547, 298);
            this.panelText.TabIndex = 1;
            // 
            // rt_Text
            // 
            this.rt_Text.AcceptsTab = true;
            this.rt_Text.AutoWordSelection = true;
            this.rt_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rt_Text.BulletIndent = 3;
            this.rt_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rt_Text.Location = new System.Drawing.Point(0, 39);
            this.rt_Text.Name = "rt_Text";
            this.rt_Text.Size = new System.Drawing.Size(545, 257);
            this.rt_Text.TabIndex = 1;
            this.rt_Text.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cb_Fonts,
            this.btn_RegularStyle,
            this.btn_BlodStyle,
            this.btn_CursiveStyle,
            this.cb_ColorFont,
            this.cb_SizeFont});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(666, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel1.Text = "Шрифт";
            // 
            // cb_Fonts
            // 
            this.cb_Fonts.Name = "cb_Fonts";
            this.cb_Fonts.Size = new System.Drawing.Size(121, 25);
            // 
            // cb_ColorFont
            // 
            this.cb_ColorFont.Name = "cb_ColorFont";
            this.cb_ColorFont.Size = new System.Drawing.Size(121, 25);
            // 
            // cb_SizeFont
            // 
            this.cb_SizeFont.Name = "cb_SizeFont";
            this.cb_SizeFont.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 5);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(545, 34);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DBClass.Properties.Resources.text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(31, 31);
            this.toolStripButton1.Text = "Выбор шрифта";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::DBClass.Properties.Resources.dropper;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(31, 31);
            this.toolStripButton2.Text = "Выбор цвета";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btn_RegularStyle
            // 
            this.btn_RegularStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_RegularStyle.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegularStyle.Image")));
            this.btn_RegularStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_RegularStyle.Name = "btn_RegularStyle";
            this.btn_RegularStyle.Size = new System.Drawing.Size(23, 22);
            this.btn_RegularStyle.Text = "toolStripButton1";
            // 
            // btn_BlodStyle
            // 
            this.btn_BlodStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_BlodStyle.Image = ((System.Drawing.Image)(resources.GetObject("btn_BlodStyle.Image")));
            this.btn_BlodStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_BlodStyle.Name = "btn_BlodStyle";
            this.btn_BlodStyle.Size = new System.Drawing.Size(23, 22);
            this.btn_BlodStyle.Text = "toolStripButton2";
            // 
            // btn_CursiveStyle
            // 
            this.btn_CursiveStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_CursiveStyle.Image = ((System.Drawing.Image)(resources.GetObject("btn_CursiveStyle.Image")));
            this.btn_CursiveStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CursiveStyle.Name = "btn_CursiveStyle";
            this.btn_CursiveStyle.Size = new System.Drawing.Size(23, 22);
            this.btn_CursiveStyle.Text = "toolStripButton3";
            // 
            // FormEditText
            // 
            this.AcceptButton = this.btnSaveText;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseText;
            this.ClientSize = new System.Drawing.Size(666, 298);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEditText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор";
            this.panelBtn.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnCloseText;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.RichTextBox rt_Text;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cb_Fonts;
        private System.Windows.Forms.ToolStripButton btn_RegularStyle;
        private System.Windows.Forms.ToolStripButton btn_BlodStyle;
        private System.Windows.Forms.ToolStripButton btn_CursiveStyle;
        private System.Windows.Forms.ToolStripComboBox cb_ColorFont;
        private System.Windows.Forms.ToolStripComboBox cb_SizeFont;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}