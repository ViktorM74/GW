
namespace Events_Forms
{
    partial class Event_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_event_name = new System.Windows.Forms.TextBox();
            this.date_plan = new DateTimePickerNullable.DatePickerNullable();
            this.date_fakt = new DateTimePickerNullable.DatePickerNullable();
            this.tb_event_notes = new System.Windows.Forms.TextBox();
            this.chk_accept = new System.Windows.Forms.CheckBox();
            this.panel_btn = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_event_name
            // 
            this.tb_event_name.Location = new System.Drawing.Point(24, 33);
            this.tb_event_name.Multiline = true;
            this.tb_event_name.Name = "tb_event_name";
            this.tb_event_name.Size = new System.Drawing.Size(261, 57);
            this.tb_event_name.TabIndex = 0;
            // 
            // date_plan
            // 
            this.date_plan.CustomFormat = "--.--.----";
            this.date_plan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_plan.Location = new System.Drawing.Point(308, 33);
            this.date_plan.Name = "date_plan";
            this.date_plan.NullableValue = null;
            this.date_plan.OriginalValue = null;
            this.date_plan.Size = new System.Drawing.Size(160, 20);
            this.date_plan.TabIndex = 1;
            // 
            // date_fakt
            // 
            this.date_fakt.CustomFormat = "--.--.----";
            this.date_fakt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_fakt.Location = new System.Drawing.Point(307, 74);
            this.date_fakt.Name = "date_fakt";
            this.date_fakt.NullableValue = null;
            this.date_fakt.OriginalValue = null;
            this.date_fakt.Size = new System.Drawing.Size(160, 20);
            this.date_fakt.TabIndex = 2;
            // 
            // tb_event_notes
            // 
            this.tb_event_notes.Location = new System.Drawing.Point(24, 118);
            this.tb_event_notes.Multiline = true;
            this.tb_event_notes.Name = "tb_event_notes";
            this.tb_event_notes.Size = new System.Drawing.Size(443, 114);
            this.tb_event_notes.TabIndex = 3;
            // 
            // chk_accept
            // 
            this.chk_accept.AutoSize = true;
            this.chk_accept.Location = new System.Drawing.Point(485, 33);
            this.chk_accept.Name = "chk_accept";
            this.chk_accept.Size = new System.Drawing.Size(83, 17);
            this.chk_accept.TabIndex = 4;
            this.chk_accept.Text = "Выполнено";
            this.chk_accept.UseVisualStyleBackColor = true;
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.btn_Close);
            this.panel_btn.Controls.Add(this.btn_Save);
            this.panel_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_btn.Location = new System.Drawing.Point(574, 0);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(132, 255);
            this.panel_btn.TabIndex = 5;
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(12, 59);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(108, 41);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(12, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 41);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Событие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата по плану";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(304, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата по факту";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание";
            // 
            // Event_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 255);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.chk_accept);
            this.Controls.Add(this.tb_event_notes);
            this.Controls.Add(this.date_fakt);
            this.Controls.Add(this.date_plan);
            this.Controls.Add(this.tb_event_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Event_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Событие";
            this.panel_btn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_event_name;
        private DateTimePickerNullable.DatePickerNullable date_plan;
        private DateTimePickerNullable.DatePickerNullable date_fakt;
        private System.Windows.Forms.TextBox tb_event_notes;
        private System.Windows.Forms.CheckBox chk_accept;
        private System.Windows.Forms.Panel panel_btn;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

