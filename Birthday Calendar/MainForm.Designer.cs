namespace Birthday_Calendar
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.Btn_AddBday = new System.Windows.Forms.Button();
            this.Btn_ShowBdayList = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.Calendar.Location = new System.Drawing.Point(24, 18);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 1;
            // 
            // Btn_AddBday
            // 
            this.Btn_AddBday.Location = new System.Drawing.Point(225, 250);
            this.Btn_AddBday.Name = "Btn_AddBday";
            this.Btn_AddBday.Size = new System.Drawing.Size(161, 37);
            this.Btn_AddBday.TabIndex = 2;
            this.Btn_AddBday.Text = "Add Birthday";
            this.Btn_AddBday.UseVisualStyleBackColor = true;
            this.Btn_AddBday.Click += new System.EventHandler(this.Btn_AddBirthday_Click);
            // 
            // Btn_ShowBdayList
            // 
            this.Btn_ShowBdayList.Location = new System.Drawing.Point(22, 250);
            this.Btn_ShowBdayList.Name = "Btn_ShowBdayList";
            this.Btn_ShowBdayList.Size = new System.Drawing.Size(143, 37);
            this.Btn_ShowBdayList.TabIndex = 2;
            this.Btn_ShowBdayList.Text = "Show Birthday List";
            this.Btn_ShowBdayList.UseVisualStyleBackColor = true;
            this.Btn_ShowBdayList.Click += new System.EventHandler(this.Btn_ShowBdayList_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(24, 212);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(362, 20);
            this.TB_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.Btn_ShowBdayList);
            this.Controls.Add(this.Btn_AddBday);
            this.Controls.Add(this.Calendar);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button Btn_AddBday;
        private System.Windows.Forms.Button Btn_ShowBdayList;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label1;
    }
}

