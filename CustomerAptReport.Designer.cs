namespace ScheduleProgram
{
    partial class CustomerAptReport
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
            this.apptByCustDgv = new System.Windows.Forms.DataGridView();
            this.lblCustomerReport = new System.Windows.Forms.Label();
            this.dropCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apptByCustDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // apptByCustDgv
            // 
            this.apptByCustDgv.AllowUserToAddRows = false;
            this.apptByCustDgv.AllowUserToDeleteRows = false;
            this.apptByCustDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptByCustDgv.Location = new System.Drawing.Point(18, 89);
            this.apptByCustDgv.Margin = new System.Windows.Forms.Padding(2);
            this.apptByCustDgv.Name = "apptByCustDgv";
            this.apptByCustDgv.ReadOnly = true;
            this.apptByCustDgv.RowHeadersVisible = false;
            this.apptByCustDgv.RowHeadersWidth = 82;
            this.apptByCustDgv.RowTemplate.Height = 33;
            this.apptByCustDgv.Size = new System.Drawing.Size(407, 177);
            this.apptByCustDgv.TabIndex = 0;
            // 
            // lblCustomerReport
            // 
            this.lblCustomerReport.AutoSize = true;
            this.lblCustomerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerReport.Location = new System.Drawing.Point(11, 9);
            this.lblCustomerReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerReport.Name = "lblCustomerReport";
            this.lblCustomerReport.Size = new System.Drawing.Size(347, 29);
            this.lblCustomerReport.TabIndex = 1;
            this.lblCustomerReport.Text = "All Appointments Per Customer";
            // 
            // dropCustomer
            // 
            this.dropCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropCustomer.FormattingEnabled = true;
            this.dropCustomer.Location = new System.Drawing.Point(262, 56);
            this.dropCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dropCustomer.Name = "dropCustomer";
            this.dropCustomer.Size = new System.Drawing.Size(166, 28);
            this.dropCustomer.TabIndex = 2;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(170, 56);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(78, 20);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Customer";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(64, 282);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(174, 38);
            this.btnGenerateReport.TabIndex = 14;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(251, 282);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(174, 38);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return to Main Screen";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // CustomerAptReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 395);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.dropCustomer);
            this.Controls.Add(this.lblCustomerReport);
            this.Controls.Add(this.apptByCustDgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerAptReport";
            this.Text = "Appointments By Customer Report";
            this.Load += new System.EventHandler(this.ApptByCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apptByCustDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView apptByCustDgv;
        private System.Windows.Forms.Label lblCustomerReport;
        private System.Windows.Forms.ComboBox dropCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnReturn;
    }
}