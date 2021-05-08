
namespace AddFilesToFolder
{
    partial class Form_AddFiles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddFiles));
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.contextMenuSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReName = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeleteFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Napravlenie = new System.Windows.Forms.GroupBox();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.rb_Serv = new System.Windows.Forms.RadioButton();
            this.rb_Loc = new System.Windows.Forms.RadioButton();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb_CopyToNewFolder = new System.Windows.Forms.CheckBox();
            this.btn_contextMenuNameFolder = new System.Windows.Forms.Button();
            this.tb_newNameFolder = new System.Windows.Forms.TextBox();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnRenameFolder = new System.Windows.Forms.Button();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.contextMenuListFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSave.SuspendLayout();
            this.gb_Napravlenie.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuListFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.ContextMenuStrip = this.contextMenuSave;
            this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewFolder.ImageIndex = 2;
            this.treeViewFolder.ImageList = this.imageList1;
            this.treeViewFolder.Location = new System.Drawing.Point(0, 0);
            this.treeViewFolder.Name = "treeViewFolder";
            this.treeViewFolder.SelectedImageIndex = 3;
            this.treeViewFolder.Size = new System.Drawing.Size(261, 402);
            this.treeViewFolder.TabIndex = 0;
            this.treeViewFolder.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFolder_NodeMouseClick);
            // 
            // contextMenuSave
            // 
            this.contextMenuSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNewFolder,
            this.MenuItemReName,
            this.MenuItemDeleteFolder});
            this.contextMenuSave.Name = "contextMenuSave";
            this.contextMenuSave.Size = new System.Drawing.Size(162, 70);
            // 
            // MenuItemNewFolder
            // 
            this.MenuItemNewFolder.Name = "MenuItemNewFolder";
            this.MenuItemNewFolder.Size = new System.Drawing.Size(161, 22);
            this.MenuItemNewFolder.Text = "Создать папку";
            this.MenuItemNewFolder.Click += new System.EventHandler(this.MenuItemNewFolder_Click);
            // 
            // MenuItemReName
            // 
            this.MenuItemReName.Name = "MenuItemReName";
            this.MenuItemReName.Size = new System.Drawing.Size(161, 22);
            this.MenuItemReName.Text = "Переименовать";
            this.MenuItemReName.Click += new System.EventHandler(this.MenuItemReName_Click);
            // 
            // MenuItemDeleteFolder
            // 
            this.MenuItemDeleteFolder.Name = "MenuItemDeleteFolder";
            this.MenuItemDeleteFolder.Size = new System.Drawing.Size(161, 22);
            this.MenuItemDeleteFolder.Text = "Удалить папку";
            this.MenuItemDeleteFolder.Click += new System.EventHandler(this.MenuItemDeleteFolder_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "folder (1).png");
            this.imageList1.Images.SetKeyName(2, "icons8-folder-30.png");
            this.imageList1.Images.SetKeyName(3, "icons8-live-folder-30.png");
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(267, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(371, 13);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "путь к локальному каталогу";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(389, 349);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(122, 42);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(267, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Локальный каталог";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(267, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(371, 13);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "путь к серверному каталогу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(267, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сетевой каталог";
            // 
            // gb_Napravlenie
            // 
            this.gb_Napravlenie.Controls.Add(this.rb_All);
            this.gb_Napravlenie.Controls.Add(this.rb_Serv);
            this.gb_Napravlenie.Controls.Add(this.rb_Loc);
            this.gb_Napravlenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Napravlenie.Location = new System.Drawing.Point(270, 102);
            this.gb_Napravlenie.Name = "gb_Napravlenie";
            this.gb_Napravlenie.Size = new System.Drawing.Size(368, 95);
            this.gb_Napravlenie.TabIndex = 4;
            this.gb_Napravlenie.TabStop = false;
            this.gb_Napravlenie.Text = "Направление записи: ";
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_All.Location = new System.Drawing.Point(15, 64);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(112, 17);
            this.rb_All.TabIndex = 1;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "два направления";
            this.rb_All.UseVisualStyleBackColor = true;
            // 
            // rb_Serv
            // 
            this.rb_Serv.AutoSize = true;
            this.rb_Serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Serv.Location = new System.Drawing.Point(15, 42);
            this.rb_Serv.Name = "rb_Serv";
            this.rb_Serv.Size = new System.Drawing.Size(86, 17);
            this.rb_Serv.TabIndex = 1;
            this.rb_Serv.Text = "только сеть";
            this.rb_Serv.UseVisualStyleBackColor = true;
            // 
            // rb_Loc
            // 
            this.rb_Loc.AutoSize = true;
            this.rb_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Loc.Location = new System.Drawing.Point(15, 19);
            this.rb_Loc.Name = "rb_Loc";
            this.rb_Loc.Size = new System.Drawing.Size(111, 17);
            this.rb_Loc.TabIndex = 1;
            this.rb_Loc.Text = "только локально";
            this.rb_Loc.UseVisualStyleBackColor = true;
            // 
            // btn_Accept
            // 
            this.btn_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Accept.Location = new System.Drawing.Point(517, 349);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(122, 42);
            this.btn_Accept.TabIndex = 2;
            this.btn_Accept.Text = "Подтвердить копирование файлов";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb_CopyToNewFolder);
            this.groupBox2.Controls.Add(this.btn_contextMenuNameFolder);
            this.groupBox2.Controls.Add(this.tb_newNameFolder);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(270, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 140);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Имя папки для создания либо переименования";
            // 
            // chb_CopyToNewFolder
            // 
            this.chb_CopyToNewFolder.AutoSize = true;
            this.chb_CopyToNewFolder.Location = new System.Drawing.Point(8, 103);
            this.chb_CopyToNewFolder.Name = "chb_CopyToNewFolder";
            this.chb_CopyToNewFolder.Size = new System.Drawing.Size(344, 17);
            this.chb_CopyToNewFolder.TabIndex = 2;
            this.chb_CopyToNewFolder.Text = "При коприровании создавать новый каталог с датой";
            this.chb_CopyToNewFolder.UseVisualStyleBackColor = true;
            // 
            // btn_contextMenuNameFolder
            // 
            this.btn_contextMenuNameFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_contextMenuNameFolder.Location = new System.Drawing.Point(198, 28);
            this.btn_contextMenuNameFolder.Name = "btn_contextMenuNameFolder";
            this.btn_contextMenuNameFolder.Size = new System.Drawing.Size(67, 23);
            this.btn_contextMenuNameFolder.TabIndex = 1;
            this.btn_contextMenuNameFolder.Text = "доб. дату";
            this.btn_contextMenuNameFolder.UseVisualStyleBackColor = true;
            this.btn_contextMenuNameFolder.Click += new System.EventHandler(this.btn_contextMenuNameFolder_Click);
            // 
            // tb_newNameFolder
            // 
            this.tb_newNameFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_newNameFolder.Location = new System.Drawing.Point(8, 28);
            this.tb_newNameFolder.Name = "tb_newNameFolder";
            this.tb_newNameFolder.Size = new System.Drawing.Size(186, 20);
            this.tb_newNameFolder.TabIndex = 0;
            this.tb_newNameFolder.Text = "Новая папка";
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(276, 267);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFolder.TabIndex = 6;
            this.btnCreateFolder.Text = "Создать";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.MenuItemNewFolder_Click);
            // 
            // btnRenameFolder
            // 
            this.btnRenameFolder.Location = new System.Drawing.Point(357, 267);
            this.btnRenameFolder.Name = "btnRenameFolder";
            this.btnRenameFolder.Size = new System.Drawing.Size(97, 23);
            this.btnRenameFolder.TabIndex = 6;
            this.btnRenameFolder.Text = "Переименовать";
            this.btnRenameFolder.UseVisualStyleBackColor = true;
            this.btnRenameFolder.Click += new System.EventHandler(this.MenuItemReName_Click);
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Location = new System.Drawing.Point(460, 267);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFolder.TabIndex = 6;
            this.btnDeleteFolder.Text = "Удалить";
            this.btnDeleteFolder.UseVisualStyleBackColor = true;
            this.btnDeleteFolder.Click += new System.EventHandler(this.MenuItemDeleteFolder_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.AllowDrop = true;
            this.listBoxFiles.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxFiles.ContextMenuStrip = this.contextMenuListFiles;
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 402);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.ScrollAlwaysVisible = true;
            this.listBoxFiles.Size = new System.Drawing.Size(643, 108);
            this.listBoxFiles.Sorted = true;
            this.listBoxFiles.TabIndex = 7;
            this.listBoxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBoxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // contextMenuListFiles
            // 
            this.contextMenuListFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.очиститьСписокToolStripMenuItem});
            this.contextMenuListFiles.Name = "contextMenuListFiles";
            this.contextMenuListFiles.Size = new System.Drawing.Size(169, 48);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // очиститьСписокToolStripMenuItem
            // 
            this.очиститьСписокToolStripMenuItem.Name = "очиститьСписокToolStripMenuItem";
            this.очиститьСписокToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.очиститьСписокToolStripMenuItem.Text = "Очистить список";
            this.очиститьСписокToolStripMenuItem.Click += new System.EventHandler(this.очиститьСписокToolStripMenuItem_Click);
            // 
            // Form_AddFiles
            // 
            this.AcceptButton = this.btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(643, 510);
            this.Controls.Add(this.btnDeleteFolder);
            this.Controls.Add(this.btnRenameFolder);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_Napravlenie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeViewFolder);
            this.Controls.Add(this.listBoxFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_AddFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры сохранения";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_SelectSave_Load);
            this.contextMenuSave.ResumeLayout(false);
            this.gb_Napravlenie.ResumeLayout(false);
            this.gb_Napravlenie.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuListFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_Napravlenie;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.ContextMenuStrip contextMenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewFolder;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReName;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteFolder;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.RadioButton rb_Serv;
        private System.Windows.Forms.RadioButton rb_Loc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_newNameFolder;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnRenameFolder;
        private System.Windows.Forms.Button btnDeleteFolder;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button btn_contextMenuNameFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuListFiles;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьСписокToolStripMenuItem;
        private System.Windows.Forms.CheckBox chb_CopyToNewFolder;
    }
}