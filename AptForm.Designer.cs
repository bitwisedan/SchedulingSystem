namespace ScheduleProgram
{
    partial class AptForm
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
            this.apptEndTxt = new System.Windows.Forms.RichTextBox();
            this.apptCustNameLbl = new System.Windows.Forms.Label();
            this.apptTypeLbl = new System.Windows.Forms.Label();
            this.apptStartLbl = new System.Windows.Forms.Label();
            this.apptEndLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dropCustomer = new System.Windows.Forms.ComboBox();
            this.dropType = new System.Windows.Forms.ComboBox();
            this.dropStartTime = new System.Windows.Forms.DateTimePicker();
            this.dropEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apptEndTxt
            // 
            this.apptEndTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptEndTxt.Location = new System.Drawing.Point(138, 157);
            this.apptEndTxt.Margin = new System.Windows.Forms.Padding(2);
            this.apptEndTxt.Name = "apptEndTxt";
            this.apptEndTxt.Size = new System.Drawing.Size(2, 2);
            this.apptEndTxt.TabIndex = 6;
            this.apptEndTxt.Text = "";
            // 
            // apptCustNameLbl
            // 
            this.apptCustNameLbl.AutoSize = true;
            this.apptCustNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptCustNameLbl.Location = new System.Drawing.Point(9, 68);
            this.apptCustNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apptCustNameLbl.Name = "apptCustNameLbl";
            this.apptCustNameLbl.Size = new System.Drawing.Size(124, 20);
            this.apptCustNameLbl.TabIndex = 12;
            this.apptCustNameLbl.Text = "Customer Name";
            // 
            // apptTypeLbl
            // 
            this.apptTypeLbl.AutoSize = true;
            this.apptTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptTypeLbl.Location = new System.Drawing.Point(90, 98);
            this.apptTypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apptTypeLbl.Name = "apptTypeLbl";
            this.apptTypeLbl.Size = new System.Drawing.Size(43, 20);
            this.apptTypeLbl.TabIndex = 17;
            this.apptTypeLbl.Text = "Type";
            // 
            // apptStartLbl
            // 
            this.apptStartLbl.AutoSize = true;
            this.apptStartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptStartLbl.Location = new System.Drawing.Point(51, 125);
            this.apptStartLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apptStartLbl.Name = "apptStartLbl";
            this.apptStartLbl.Size = new System.Drawing.Size(82, 20);
            this.apptStartLbl.TabIndex = 19;
            this.apptStartLbl.Text = "Start Time";
            // 
            // apptEndLbl
            // 
            this.apptEndLbl.AutoSize = true;
            this.apptEndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptEndLbl.Location = new System.Drawing.Point(57, 159);
            this.apptEndLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apptEndLbl.Name = "apptEndLbl";
            this.apptEndLbl.Size = new System.Drawing.Size(76, 20);
            this.apptEndLbl.TabIndex = 20;
            this.apptEndLbl.Text = "End Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "Appointment Details";
            // 
            // dropCustomer
            // 
            this.dropCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropCustomer.FormattingEnabled = true;
            this.dropCustomer.Location = new System.Drawing.Point(139, 67);
            this.dropCustomer.Name = "dropCustomer";
            this.dropCustomer.Size = new System.Drawing.Size(195, 24);
            this.dropCustomer.TabIndex = 24;
            // 
            // dropType
            // 
            this.dropType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropType.FormattingEnabled = true;
            this.dropType.Location = new System.Drawing.Point(138, 94);
            this.dropType.Name = "dropType";
            this.dropType.Size = new System.Drawing.Size(195, 24);
            this.dropType.TabIndex = 25;
            // 
            // dropStartTime
            // 
            this.dropStartTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dropStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dropStartTime.Location = new System.Drawing.Point(139, 123);
            this.dropStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.dropStartTime.MinDate = new System.DateTime(2018, 7, 25, 0, 0, 0, 0);
            this.dropStartTime.Name = "dropStartTime";
            this.dropStartTime.Size = new System.Drawing.Size(195, 23);
            this.dropStartTime.TabIndex = 26;
            this.dropStartTime.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // dropEndTime
            // 
            this.dropEndTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dropEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dropEndTime.Location = new System.Drawing.Point(139, 155);
            this.dropEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.dropEndTime.MinDate = new System.DateTime(2018, 7, 25, 0, 0, 0, 0);
            this.dropEndTime.Name = "dropEndTime";
            this.dropEndTime.Size = new System.Drawing.Size(195, 23);
            this.dropEndTime.TabIndex = 27;
            this.dropEndTime.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(16, 226);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(246, 201);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 29);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(154, 201);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 29);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dropEndTime);
            this.Controls.Add(this.dropStartTime);
            this.Controls.Add(this.dropType);
            this.Controls.Add(this.dropCustomer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.apptEndLbl);
            this.Controls.Add(this.apptStartLbl);
            this.Controls.Add(this.apptTypeLbl);
            this.Controls.Add(this.apptCustNameLbl);
            this.Controls.Add(this.apptEndTxt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AptForm";
            this.Text = "Appointment Details";
            this.Load += new System.EventHandler(this.AptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox apptEndTxt;
        private System.Windows.Forms.Label apptCustNameLbl;
        private System.Windows.Forms.Label apptTypeLbl;
        private System.Windows.Forms.Label apptStartLbl;
        private System.Windows.Forms.Label apptEndLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblError;
        public System.Windows.Forms.ComboBox dropCustomer;
        public System.Windows.Forms.ComboBox dropType;
        public System.Windows.Forms.DateTimePicker dropStartTime;
        public System.Windows.Forms.DateTimePicker dropEndTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}