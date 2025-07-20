namespace EX1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpCreateLoan = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.chkShortTerm = new System.Windows.Forms.CheckBox();
            this.chkLongTerm = new System.Windows.Forms.CheckBox();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.lblResultName = new System.Windows.Forms.Label();
            this.lblResultLoanAndAmount = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lblNewLoanAmount = new System.Windows.Forms.Label();
            this.lblResultAccumulation = new System.Windows.Forms.Label();
            this.lblErrorResult = new System.Windows.Forms.Label();
            this.lblErrorResult2 = new System.Windows.Forms.Label();
            this.grpCreateLoan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Loan";
            // 
            // grpCreateLoan
            // 
            this.grpCreateLoan.Controls.Add(this.lblErrorResult);
            this.grpCreateLoan.Controls.Add(this.btnCreateLoan);
            this.grpCreateLoan.Controls.Add(this.chkLongTerm);
            this.grpCreateLoan.Controls.Add(this.chkShortTerm);
            this.grpCreateLoan.Controls.Add(this.txtAmount);
            this.grpCreateLoan.Controls.Add(this.txtName);
            this.grpCreateLoan.Controls.Add(this.label4);
            this.grpCreateLoan.Controls.Add(this.label3);
            this.grpCreateLoan.Controls.Add(this.label2);
            this.grpCreateLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreateLoan.Location = new System.Drawing.Point(12, 52);
            this.grpCreateLoan.Name = "grpCreateLoan";
            this.grpCreateLoan.Size = new System.Drawing.Size(776, 287);
            this.grpCreateLoan.TabIndex = 1;
            this.grpCreateLoan.TabStop = false;
            this.grpCreateLoan.Text = "Create New Loan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblErrorResult2);
            this.groupBox2.Controls.Add(this.lblResultAccumulation);
            this.groupBox2.Controls.Add(this.lblNewLoanAmount);
            this.groupBox2.Controls.Add(this.btnMakePayment);
            this.groupBox2.Controls.Add(this.lblResultLoanAndAmount);
            this.groupBox2.Controls.Add(this.lblResultName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 300);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Existing Loan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loan Type:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(592, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(140, 103);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(592, 27);
            this.txtAmount.TabIndex = 4;
            // 
            // chkShortTerm
            // 
            this.chkShortTerm.AutoSize = true;
            this.chkShortTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShortTerm.Location = new System.Drawing.Point(158, 159);
            this.chkShortTerm.Name = "chkShortTerm";
            this.chkShortTerm.Size = new System.Drawing.Size(129, 20);
            this.chkShortTerm.TabIndex = 5;
            this.chkShortTerm.Text = "Short-Term Loan";
            this.chkShortTerm.UseVisualStyleBackColor = true;
            // 
            // chkLongTerm
            // 
            this.chkLongTerm.AutoSize = true;
            this.chkLongTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLongTerm.Location = new System.Drawing.Point(158, 197);
            this.chkLongTerm.Name = "chkLongTerm";
            this.chkLongTerm.Size = new System.Drawing.Size(128, 20);
            this.chkLongTerm.TabIndex = 6;
            this.chkLongTerm.Text = "Long-Term Loan";
            this.chkLongTerm.UseVisualStyleBackColor = true;
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(31, 234);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(256, 33);
            this.btnCreateLoan.TabIndex = 7;
            this.btnCreateLoan.Text = "Create Loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // lblResultName
            // 
            this.lblResultName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultName.Location = new System.Drawing.Point(75, 27);
            this.lblResultName.Name = "lblResultName";
            this.lblResultName.Size = new System.Drawing.Size(648, 29);
            this.lblResultName.TabIndex = 0;
            // 
            // lblResultLoanAndAmount
            // 
            this.lblResultLoanAndAmount.Location = new System.Drawing.Point(80, 56);
            this.lblResultLoanAndAmount.Name = "lblResultLoanAndAmount";
            this.lblResultLoanAndAmount.Size = new System.Drawing.Size(652, 78);
            this.lblResultLoanAndAmount.TabIndex = 1;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(30, 137);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(256, 33);
            this.btnMakePayment.TabIndex = 2;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lblNewLoanAmount
            // 
            this.lblNewLoanAmount.AutoSize = true;
            this.lblNewLoanAmount.Location = new System.Drawing.Point(90, 183);
            this.lblNewLoanAmount.Name = "lblNewLoanAmount";
            this.lblNewLoanAmount.Size = new System.Drawing.Size(0, 20);
            this.lblNewLoanAmount.TabIndex = 3;
            // 
            // lblResultAccumulation
            // 
            this.lblResultAccumulation.AutoSize = true;
            this.lblResultAccumulation.Location = new System.Drawing.Point(90, 230);
            this.lblResultAccumulation.Name = "lblResultAccumulation";
            this.lblResultAccumulation.Size = new System.Drawing.Size(0, 20);
            this.lblResultAccumulation.TabIndex = 4;
            // 
            // lblErrorResult
            // 
            this.lblErrorResult.AutoSize = true;
            this.lblErrorResult.ForeColor = System.Drawing.Color.Red;
            this.lblErrorResult.Location = new System.Drawing.Point(348, 158);
            this.lblErrorResult.Name = "lblErrorResult";
            this.lblErrorResult.Size = new System.Drawing.Size(0, 20);
            this.lblErrorResult.TabIndex = 8;
            // 
            // lblErrorResult2
            // 
            this.lblErrorResult2.AutoSize = true;
            this.lblErrorResult2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorResult2.Location = new System.Drawing.Point(328, 260);
            this.lblErrorResult2.Name = "lblErrorResult2";
            this.lblErrorResult2.Size = new System.Drawing.Size(0, 20);
            this.lblErrorResult2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCreateLoan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCreateLoan.ResumeLayout(false);
            this.grpCreateLoan.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCreateLoan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkShortTerm;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.CheckBox chkLongTerm;
        private System.Windows.Forms.Label lblResultLoanAndAmount;
        private System.Windows.Forms.Label lblResultName;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblNewLoanAmount;
        private System.Windows.Forms.Label lblResultAccumulation;
        private System.Windows.Forms.Label lblErrorResult;
        private System.Windows.Forms.Label lblErrorResult2;
    }
}

