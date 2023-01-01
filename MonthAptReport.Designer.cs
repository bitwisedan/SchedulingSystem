namespace ScheduleProgram
{
    partial class MonthAptReport
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
            this.lblMonthReport = new System.Windows.Forms.Label();
            this.dropMonth = new System.Windows.Forms.ComboBox();
            this.monthLbl = new System.Windows.Forms.Label();
            this.lblDemo = new System.Windows.Forms.Label();
            this.lblCOntractReview = new System.Windows.Forms.Label();
            this.lblPres = new System.Windows.Forms.Label();
            this.lblScrum = new System.Windows.Forms.Label();
            this.lblTotalApt = new System.Windows.Forms.Label();
            this.apptTypeLbl = new System.Windows.Forms.Label();
            this.contractReviewCount = new System.Windows.Forms.Label();
            this.demoCount = new System.Windows.Forms.Label();
            this.presentationCount = new System.Windows.Forms.Label();
            this.scrumCount = new System.Windows.Forms.Label();
            this.totalCount = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gridAptByMonth = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAptByMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonthReport
            // 
            this.lblMonthReport.AutoSize = true;
            this.lblMonthReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthReport.Location = new System.Drawing.Point(11, 9);
            this.lblMonthReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonthReport.Name = "lblMonthReport";
            this.lblMonthReport.Size = new System.Drawing.Size(395, 29);
            this.lblMonthReport.TabIndex = 1;
            this.lblMonthReport.Text = "Appointments Type Count By Month";
            // 
            // dropMonth
            // 
            this.dropMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropMonth.FormattingEnabled = true;
            this.dropMonth.Location = new System.Drawing.Point(72, 55);
            this.dropMonth.Margin = new System.Windows.Forms.Padding(2);
            this.dropMonth.Name = "dropMonth";
            this.dropMonth.Size = new System.Drawing.Size(102, 28);
            this.dropMonth.TabIndex = 2;
            // 
            // monthLbl
            // 
            this.monthLbl.AutoSize = true;
            this.monthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLbl.Location = new System.Drawing.Point(14, 58);
            this.monthLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(54, 20);
            this.monthLbl.TabIndex = 3;
            this.monthLbl.Text = "Month";
            // 
            // lblDemo
            // 
            this.lblDemo.AutoSize = true;
            this.lblDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemo.Location = new System.Drawing.Point(14, 330);
            this.lblDemo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(98, 17);
            this.lblDemo.TabIndex = 5;
            this.lblDemo.Text = "Demo Count =";
            // 
            // lblCOntractReview
            // 
            this.lblCOntractReview.AutoSize = true;
            this.lblCOntractReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOntractReview.Location = new System.Drawing.Point(14, 308);
            this.lblCOntractReview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCOntractReview.Name = "lblCOntractReview";
            this.lblCOntractReview.Size = new System.Drawing.Size(167, 17);
            this.lblCOntractReview.TabIndex = 6;
            this.lblCOntractReview.Text = "Contract Review Count = ";
            // 
            // lblPres
            // 
            this.lblPres.AutoSize = true;
            this.lblPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPres.Location = new System.Drawing.Point(14, 354);
            this.lblPres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPres.Name = "lblPres";
            this.lblPres.Size = new System.Drawing.Size(141, 17);
            this.lblPres.TabIndex = 7;
            this.lblPres.Text = "Presentation Count =";
            // 
            // lblScrum
            // 
            this.lblScrum.AutoSize = true;
            this.lblScrum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrum.Location = new System.Drawing.Point(14, 378);
            this.lblScrum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScrum.Name = "lblScrum";
            this.lblScrum.Size = new System.Drawing.Size(60, 17);
            this.lblScrum.TabIndex = 8;
            this.lblScrum.Text = "Scrum =";
            // 
            // lblTotalApt
            // 
            this.lblTotalApt.AutoSize = true;
            this.lblTotalApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalApt.Location = new System.Drawing.Point(14, 399);
            this.lblTotalApt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalApt.Name = "lblTotalApt";
            this.lblTotalApt.Size = new System.Drawing.Size(146, 17);
            this.lblTotalApt.TabIndex = 9;
            this.lblTotalApt.Text = "Total Appointments = ";
            // 
            // apptTypeLbl
            // 
            this.apptTypeLbl.AutoSize = true;
            this.apptTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptTypeLbl.Location = new System.Drawing.Point(14, 279);
            this.apptTypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apptTypeLbl.Name = "apptTypeLbl";
            this.apptTypeLbl.Size = new System.Drawing.Size(151, 18);
            this.apptTypeLbl.TabIndex = 10;
            this.apptTypeLbl.Text = "Appointment Types";
            // 
            // contractReviewCount
            // 
            this.contractReviewCount.AutoSize = true;
            this.contractReviewCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractReviewCount.Location = new System.Drawing.Point(179, 307);
            this.contractReviewCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contractReviewCount.Name = "contractReviewCount";
            this.contractReviewCount.Size = new System.Drawing.Size(0, 18);
            this.contractReviewCount.TabIndex = 12;
            // 
            // demoCount
            // 
            this.demoCount.AutoSize = true;
            this.demoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demoCount.Location = new System.Drawing.Point(112, 329);
            this.demoCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.demoCount.Name = "demoCount";
            this.demoCount.Size = new System.Drawing.Size(0, 18);
            this.demoCount.TabIndex = 13;
            // 
            // presentationCount
            // 
            this.presentationCount.AutoSize = true;
            this.presentationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentationCount.Location = new System.Drawing.Point(152, 353);
            this.presentationCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.presentationCount.Name = "presentationCount";
            this.presentationCount.Size = new System.Drawing.Size(0, 18);
            this.presentationCount.TabIndex = 14;
            // 
            // scrumCount
            // 
            this.scrumCount.AutoSize = true;
            this.scrumCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrumCount.Location = new System.Drawing.Point(75, 376);
            this.scrumCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scrumCount.Name = "scrumCount";
            this.scrumCount.Size = new System.Drawing.Size(0, 18);
            this.scrumCount.TabIndex = 15;
            // 
            // totalCount
            // 
            this.totalCount.AutoSize = true;
            this.totalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCount.Location = new System.Drawing.Point(156, 399);
            this.totalCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(0, 18);
            this.totalCount.TabIndex = 16;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(252, 307);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(174, 38);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(252, 379);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(174, 38);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return to Main Screen";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // gridAptByMonth
            // 
            this.gridAptByMonth.AllowUserToAddRows = false;
            this.gridAptByMonth.AllowUserToDeleteRows = false;
            this.gridAptByMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAptByMonth.Location = new System.Drawing.Point(17, 100);
            this.gridAptByMonth.Margin = new System.Windows.Forms.Padding(2);
            this.gridAptByMonth.Name = "gridAptByMonth";
            this.gridAptByMonth.ReadOnly = true;
            this.gridAptByMonth.RowHeadersVisible = false;
            this.gridAptByMonth.RowHeadersWidth = 82;
            this.gridAptByMonth.RowTemplate.Height = 33;
            this.gridAptByMonth.Size = new System.Drawing.Size(306, 164);
            this.gridAptByMonth.TabIndex = 20;
            // 
            // MonthAptReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 449);
            this.Controls.Add(this.gridAptByMonth);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.totalCount);
            this.Controls.Add(this.scrumCount);
            this.Controls.Add(this.presentationCount);
            this.Controls.Add(this.demoCount);
            this.Controls.Add(this.contractReviewCount);
            this.Controls.Add(this.apptTypeLbl);
            this.Controls.Add(this.lblTotalApt);
            this.Controls.Add(this.lblScrum);
            this.Controls.Add(this.lblPres);
            this.Controls.Add(this.lblCOntractReview);
            this.Controls.Add(this.lblDemo);
            this.Controls.Add(this.monthLbl);
            this.Controls.Add(this.dropMonth);
            this.Controls.Add(this.lblMonthReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MonthAptReport";
            this.Text = "Appointments By Month Report";
            this.Load += new System.EventHandler(this.MonthAptReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAptByMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMonthReport;
        private System.Windows.Forms.ComboBox dropMonth;
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.Label lblDemo;
        private System.Windows.Forms.Label lblCOntractReview;
        private System.Windows.Forms.Label lblPres;
        private System.Windows.Forms.Label lblScrum;
        private System.Windows.Forms.Label lblTotalApt;
        private System.Windows.Forms.Label apptTypeLbl;
        private System.Windows.Forms.Label contractReviewCount;
        private System.Windows.Forms.Label demoCount;
        private System.Windows.Forms.Label presentationCount;
        private System.Windows.Forms.Label scrumCount;
        private System.Windows.Forms.Label totalCount;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView gridAptByMonth;
    }
}