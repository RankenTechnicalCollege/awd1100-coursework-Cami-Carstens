﻿namespace Lab1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZipEntryBox = new System.Windows.Forms.TextBox();
            this.txtFeeResult = new System.Windows.Forms.TextBox();
            this.btnZipEntry = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zip Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delivery Fee $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome to Bella\'s Farm and Meat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(542, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter your zip code to see if we delivery to you and what your delivery cost will" +
    " be!";
            // 
            // txtZipEntryBox
            // 
            this.txtZipEntryBox.Location = new System.Drawing.Point(96, 211);
            this.txtZipEntryBox.Name = "txtZipEntryBox";
            this.txtZipEntryBox.Size = new System.Drawing.Size(176, 24);
            this.txtZipEntryBox.TabIndex = 4;
            // 
            // txtFeeResult
            // 
            this.txtFeeResult.Location = new System.Drawing.Point(432, 211);
            this.txtFeeResult.Name = "txtFeeResult";
            this.txtFeeResult.Size = new System.Drawing.Size(189, 24);
            this.txtFeeResult.TabIndex = 5;
            // 
            // btnZipEntry
            // 
            this.btnZipEntry.Location = new System.Drawing.Point(96, 266);
            this.btnZipEntry.Name = "btnZipEntry";
            this.btnZipEntry.Size = new System.Drawing.Size(139, 29);
            this.btnZipEntry.TabIndex = 6;
            this.btnZipEntry.Text = "Enter";
            this.btnZipEntry.UseVisualStyleBackColor = true;
            this.btnZipEntry.Click += new System.EventHandler(this.btnZipEntry_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "*includes dry ice pack and insulated cooler\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnZipEntry);
            this.Controls.Add(this.txtFeeResult);
            this.Controls.Add(this.txtZipEntryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZipEntryBox;
        private System.Windows.Forms.TextBox txtFeeResult;
        private System.Windows.Forms.Button btnZipEntry;
        private System.Windows.Forms.Label label5;
    }
}

