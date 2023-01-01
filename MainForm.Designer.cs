namespace ScheduleProgram
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.gridAppointments = new System.Windows.Forms.DataGridView();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeletCustomer = new System.Windows.Forms.Button();
            this.btnUpdateApt = new System.Windows.Forms.Button();
            this.btnAddApt = new System.Windows.Forms.Button();
            this.btnDeleteApt = new System.Windows.Forms.Button();
            this.calAptView = new System.Windows.Forms.MonthCalendar();
            this.radWeek = new System.Windows.Forms.RadioButton();
            this.radMonth = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.radDay = new System.Windows.Forms.RadioButton();
            this.lblViewAptBy = new System.Windows.Forms.Label();
            this.btnAptByMonth = new System.Windows.Forms.Button();
            this.btnUserSchedule = new System.Windows.Forms.Button();
            this.btnAptByCustomer = new System.Windows.Forms.Button();
            this.lblReports = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCustomers
            // 
            this.gridCustomers.AllowUserToAddRows = false;
            this.gridCustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.EnableHeadersVisualStyles = false;
            this.gridCustomers.Location = new System.Drawing.Point(31, 59);
            this.gridCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.gridCustomers.MultiSelect = false;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.ReadOnly = true;
            this.gridCustomers.RowHeadersVisible = false;
            this.gridCustomers.RowHeadersWidth = 82;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.gridCustomers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCustomers.RowTemplate.Height = 33;
            this.gridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomers.Size = new System.Drawing.Size(504, 177);
            this.gridCustomers.TabIndex = 0;
            this.gridCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCustomer_CellClick);
            // 
            // gridAppointments
            // 
            this.gridAppointments.AllowUserToAddRows = false;
            this.gridAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAppointments.EnableHeadersVisualStyles = false;
            this.gridAppointments.Location = new System.Drawing.Point(31, 314);
            this.gridAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.gridAppointments.MultiSelect = false;
            this.gridAppointments.Name = "gridAppointments";
            this.gridAppointments.ReadOnly = true;
            this.gridAppointments.RowHeadersVisible = false;
            this.gridAppointments.RowHeadersWidth = 82;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.gridAppointments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAppointments.RowTemplate.Height = 33;
            this.gridAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAppointments.Size = new System.Drawing.Size(504, 177);
            this.gridAppointments.TabIndex = 1;
            this.gridAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataApt_CellClick);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(447, 240);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(88, 29);
            this.btnUpdateCustomer.TabIndex = 2;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(353, 240);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(88, 29);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeletCustomer
            // 
            this.btnDeletCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletCustomer.Location = new System.Drawing.Point(260, 240);
            this.btnDeletCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletCustomer.Name = "btnDeletCustomer";
            this.btnDeletCustomer.Size = new System.Drawing.Size(88, 29);
            this.btnDeletCustomer.TabIndex = 4;
            this.btnDeletCustomer.Text = "Delete";
            this.btnDeletCustomer.UseVisualStyleBackColor = true;
            this.btnDeletCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateApt
            // 
            this.btnUpdateApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateApt.Location = new System.Drawing.Point(447, 495);
            this.btnUpdateApt.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateApt.Name = "btnUpdateApt";
            this.btnUpdateApt.Size = new System.Drawing.Size(88, 29);
            this.btnUpdateApt.TabIndex = 5;
            this.btnUpdateApt.Text = "Update";
            this.btnUpdateApt.UseVisualStyleBackColor = true;
            this.btnUpdateApt.Click += new System.EventHandler(this.btnUpdateApt_Click);
            // 
            // btnAddApt
            // 
            this.btnAddApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddApt.Location = new System.Drawing.Point(353, 495);
            this.btnAddApt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddApt.Name = "btnAddApt";
            this.btnAddApt.Size = new System.Drawing.Size(88, 29);
            this.btnAddApt.TabIndex = 6;
            this.btnAddApt.Text = "Add";
            this.btnAddApt.UseVisualStyleBackColor = true;
            this.btnAddApt.Click += new System.EventHandler(this.btnAddApt_Click);
            // 
            // btnDeleteApt
            // 
            this.btnDeleteApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteApt.Location = new System.Drawing.Point(260, 495);
            this.btnDeleteApt.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteApt.Name = "btnDeleteApt";
            this.btnDeleteApt.Size = new System.Drawing.Size(88, 29);
            this.btnDeleteApt.TabIndex = 7;
            this.btnDeleteApt.Text = "Delete";
            this.btnDeleteApt.UseVisualStyleBackColor = true;
            this.btnDeleteApt.Click += new System.EventHandler(this.btnDeleteApt_Click);
            // 
            // calAptView
            // 
            this.calAptView.Location = new System.Drawing.Point(31, 627);
            this.calAptView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calAptView.Name = "calAptView";
            this.calAptView.TabIndex = 8;
            this.calAptView.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calAptView_DateChanged);
            this.calAptView.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calMyView_DateSelected);
            // 
            // radWeek
            // 
            this.radWeek.AutoSize = true;
            this.radWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWeek.Location = new System.Drawing.Point(87, 807);
            this.radWeek.Margin = new System.Windows.Forms.Padding(2);
            this.radWeek.Name = "radWeek";
            this.radWeek.Size = new System.Drawing.Size(62, 21);
            this.radWeek.TabIndex = 9;
            this.radWeek.TabStop = true;
            this.radWeek.Text = "Week";
            this.radWeek.UseVisualStyleBackColor = true;
            this.radWeek.CheckedChanged += new System.EventHandler(this.radWeek_CheckedChanged);
            // 
            // radMonth
            // 
            this.radMonth.AutoSize = true;
            this.radMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMonth.Location = new System.Drawing.Point(153, 807);
            this.radMonth.Margin = new System.Windows.Forms.Padding(2);
            this.radMonth.Name = "radMonth";
            this.radMonth.Size = new System.Drawing.Size(65, 21);
            this.radMonth.TabIndex = 10;
            this.radMonth.TabStop = true;
            this.radMonth.Text = "Month";
            this.radMonth.UseVisualStyleBackColor = true;
            this.radMonth.CheckedChanged += new System.EventHandler(this.radMonth_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.AllowDrop = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(447, 803);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 29);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radDay
            // 
            this.radDay.AutoSize = true;
            this.radDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.radDay.Location = new System.Drawing.Point(31, 807);
            this.radDay.Name = "radDay";
            this.radDay.Size = new System.Drawing.Size(51, 21);
            this.radDay.TabIndex = 12;
            this.radDay.TabStop = true;
            this.radDay.Text = "Day";
            this.radDay.UseVisualStyleBackColor = true;
            this.radDay.CheckedChanged += new System.EventHandler(this.radDay_CheckedChanged);
            // 
            // lblViewAptBy
            // 
            this.lblViewAptBy.AutoSize = true;
            this.lblViewAptBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAptBy.Location = new System.Drawing.Point(37, 598);
            this.lblViewAptBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewAptBy.Name = "lblViewAptBy";
            this.lblViewAptBy.Size = new System.Drawing.Size(195, 24);
            this.lblViewAptBy.TabIndex = 15;
            this.lblViewAptBy.Text = "View Appointment By:";
            // 
            // btnAptByMonth
            // 
            this.btnAptByMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAptByMonth.Location = new System.Drawing.Point(333, 627);
            this.btnAptByMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnAptByMonth.Name = "btnAptByMonth";
            this.btnAptByMonth.Size = new System.Drawing.Size(202, 42);
            this.btnAptByMonth.TabIndex = 16;
            this.btnAptByMonth.Text = "Appointments \r\nBy Month";
            this.btnAptByMonth.UseVisualStyleBackColor = true;
            this.btnAptByMonth.Click += new System.EventHandler(this.btnAptByMonth_Click);
            // 
            // btnUserSchedule
            // 
            this.btnUserSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSchedule.Location = new System.Drawing.Point(333, 679);
            this.btnUserSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserSchedule.Name = "btnUserSchedule";
            this.btnUserSchedule.Size = new System.Drawing.Size(202, 42);
            this.btnUserSchedule.TabIndex = 17;
            this.btnUserSchedule.Text = "User Schedule";
            this.btnUserSchedule.UseVisualStyleBackColor = true;
            this.btnUserSchedule.Click += new System.EventHandler(this.btnUserSchedule_Click);
            // 
            // btnAptByCustomer
            // 
            this.btnAptByCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAptByCustomer.Location = new System.Drawing.Point(333, 734);
            this.btnAptByCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAptByCustomer.Name = "btnAptByCustomer";
            this.btnAptByCustomer.Size = new System.Drawing.Size(202, 42);
            this.btnAptByCustomer.TabIndex = 18;
            this.btnAptByCustomer.Text = "Appointments \r\nBy Customer";
            this.btnAptByCustomer.UseVisualStyleBackColor = true;
            this.btnAptByCustomer.Click += new System.EventHandler(this.btnAptByCustomer_Click);
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(329, 598);
            this.lblReports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(85, 24);
            this.lblReports.TabIndex = 19;
            this.lblReports.Text = "Reports: ";
            this.lblReports.Click += new System.EventHandler(this.lblReports_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(235, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 27);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.Text = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(447, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 29);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(36, 26);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(129, 29);
            this.lblCustomers.TabIndex = 22;
            this.lblCustomers.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Appointments";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 909);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.btnAptByCustomer);
            this.Controls.Add(this.btnUserSchedule);
            this.Controls.Add(this.btnAptByMonth);
            this.Controls.Add(this.lblViewAptBy);
            this.Controls.Add(this.radDay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.radMonth);
            this.Controls.Add(this.radWeek);
            this.Controls.Add(this.calAptView);
            this.Controls.Add(this.btnDeleteApt);
            this.Controls.Add(this.btnAddApt);
            this.Controls.Add(this.btnUpdateApt);
            this.Controls.Add(this.btnDeletCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.gridAppointments);
            this.Controls.Add(this.gridCustomers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeletCustomer;
        private System.Windows.Forms.Button btnUpdateApt;
        private System.Windows.Forms.Button btnAddApt;
        private System.Windows.Forms.Button btnDeleteApt;
        private System.Windows.Forms.MonthCalendar calAptView;
        private System.Windows.Forms.RadioButton radWeek;
        private System.Windows.Forms.RadioButton radMonth;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radDay;
        private System.Windows.Forms.Label lblViewAptBy;
        private System.Windows.Forms.Button btnAptByMonth;
        private System.Windows.Forms.Button btnUserSchedule;
        private System.Windows.Forms.Button btnAptByCustomer;
        private System.Windows.Forms.Label lblReports;
        internal System.Windows.Forms.DataGridView gridAppointments;
        private System.Windows.Forms.RichTextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label label1;
    }
}