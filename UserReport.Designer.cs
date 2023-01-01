namespace ScheduleProgram
{
    partial class UserReport
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
            this.gridUser = new System.Windows.Forms.DataGridView();
            this.userSchedLbl = new System.Windows.Forms.Label();
            this.dropUser = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUser
            // 
            this.gridUser.AllowUserToAddRows = false;
            this.gridUser.AllowUserToDeleteRows = false;
            this.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUser.Location = new System.Drawing.Point(18, 89);
            this.gridUser.Margin = new System.Windows.Forms.Padding(2);
            this.gridUser.Name = "gridUser";
            this.gridUser.ReadOnly = true;
            this.gridUser.RowHeadersVisible = false;
            this.gridUser.RowHeadersWidth = 82;
            this.gridUser.RowTemplate.Height = 33;
            this.gridUser.Size = new System.Drawing.Size(527, 245);
            this.gridUser.TabIndex = 0;
            // 
            // userSchedLbl
            // 
            this.userSchedLbl.AutoSize = true;
            this.userSchedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSchedLbl.Location = new System.Drawing.Point(22, 40);
            this.userSchedLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userSchedLbl.Name = "userSchedLbl";
            this.userSchedLbl.Size = new System.Drawing.Size(172, 29);
            this.userSchedLbl.TabIndex = 1;
            this.userSchedLbl.Text = "User Schedule";
            // 
            // dropUser
            // 
            this.dropUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropUser.FormattingEnabled = true;
            this.dropUser.Location = new System.Drawing.Point(410, 61);
            this.dropUser.Margin = new System.Windows.Forms.Padding(2);
            this.dropUser.Name = "dropUser";
            this.dropUser.Size = new System.Drawing.Size(138, 24);
            this.dropUser.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(364, 62);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 20);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User";
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMain.Location = new System.Drawing.Point(371, 343);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(174, 38);
            this.btnReturnMain.TabIndex = 15;
            this.btnReturnMain.Text = "Return to Main Screen";
            this.btnReturnMain.UseVisualStyleBackColor = true;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(194, 343);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(174, 38);
            this.btnGenerateReport.TabIndex = 14;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // UserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 420);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dropUser);
            this.Controls.Add(this.userSchedLbl);
            this.Controls.Add(this.gridUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserReport";
            this.Text = "Appointments By Month Report";
            
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUser;
        private System.Windows.Forms.Label userSchedLbl;
        private System.Windows.Forms.ComboBox dropUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}