namespace Birthday_Calendar
{
    partial class EditContactsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditContactsForm));
            this.DGV_Contacts = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.DTP_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAddBday = new System.Windows.Forms.Button();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Contacts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Contacts
            // 
            this.DGV_Contacts.BackgroundColor = System.Drawing.Color.IndianRed;
            this.DGV_Contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Contacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dateOfBirth});
            this.DGV_Contacts.Location = new System.Drawing.Point(37, 94);
            this.DGV_Contacts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Contacts.MultiSelect = false;
            this.DGV_Contacts.Name = "DGV_Contacts";
            this.DGV_Contacts.ReadOnly = true;
            this.DGV_Contacts.RowHeadersWidth = 51;
            this.DGV_Contacts.Size = new System.Drawing.Size(523, 444);
            this.DGV_Contacts.TabIndex = 0;
            this.DGV_Contacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Contacts_CellClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.HeaderText = "Date of Birth";
            this.dateOfBirth.MinimumWidth = 6;
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            this.dateOfBirth.Width = 125;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(591, 513);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(305, 22);
            this.TB_Name.TabIndex = 1;
            this.TB_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Name_KeyDown);
            // 
            // DTP_DateOfBirth
            // 
            this.DTP_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DateOfBirth.Location = new System.Drawing.Point(905, 513);
            this.DTP_DateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTP_DateOfBirth.Name = "DTP_DateOfBirth";
            this.DTP_DateOfBirth.Size = new System.Drawing.Size(153, 22);
            this.DTP_DateOfBirth.TabIndex = 2;
            this.DTP_DateOfBirth.ValueChanged += new System.EventHandler(this.DTP_DateOfBirth_ValueChanged);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Edit.Location = new System.Drawing.Point(353, 559);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(233, 44);
            this.Btn_Edit.TabIndex = 3;
            this.Btn_Edit.Text = "Edit Selected Entry";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.IndianRed;
            this.BtnRemove.Location = new System.Drawing.Point(37, 559);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(233, 44);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Remove Selected Entry";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAddBday
            // 
            this.BtnAddBday.BackColor = System.Drawing.Color.IndianRed;
            this.BtnAddBday.Location = new System.Drawing.Point(692, 559);
            this.BtnAddBday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAddBday.Name = "BtnAddBday";
            this.BtnAddBday.Size = new System.Drawing.Size(233, 44);
            this.BtnAddBday.TabIndex = 3;
            this.BtnAddBday.Text = "Add Birthday";
            this.BtnAddBday.UseVisualStyleBackColor = false;
            this.BtnAddBday.Click += new System.EventHandler(this.BtnAddBday_Click);
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoEllipsis = true;
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Location = new System.Drawing.Point(21, 20);
            this.Lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Status.MaximumSize = new System.Drawing.Size(400, 148);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(69, 17);
            this.Lbl_Status.TabIndex = 4;
            this.Lbl_Status.Text = "Welcome!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_Status);
            this.groupBox1.Location = new System.Drawing.Point(591, 308);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(469, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(591, 94);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "Birthday Contacts";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 624);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MaximumSize = new System.Drawing.Size(400, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Developed by Sascha Niechciol";
            // 
            // EditContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1159, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAddBday);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.DTP_DateOfBirth);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.DGV_Contacts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditContactsForm";
            this.Text = "EditContacts";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Contacts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Contacts;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.DateTimePicker DTP_DateOfBirth;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAddBday;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
    }
}