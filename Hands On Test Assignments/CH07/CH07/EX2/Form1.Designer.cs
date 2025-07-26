namespace EX2
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
            this.btnArithmetic = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnInvalidCast = new System.Windows.Forms.Button();
            this.btnNullReference = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArithmetic
            // 
            this.btnArithmetic.BackColor = System.Drawing.Color.Aquamarine;
            this.btnArithmetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArithmetic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnArithmetic.Location = new System.Drawing.Point(54, 57);
            this.btnArithmetic.Name = "btnArithmetic";
            this.btnArithmetic.Size = new System.Drawing.Size(338, 123);
            this.btnArithmetic.TabIndex = 0;
            this.btnArithmetic.Text = "System.ArithmeticException";
            this.btnArithmetic.UseVisualStyleBackColor = false;
            this.btnArithmetic.Click += new System.EventHandler(this.btnArithmetic_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.BackColor = System.Drawing.Color.Violet;
            this.btnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormat.Location = new System.Drawing.Point(443, 57);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(327, 123);
            this.btnFormat.TabIndex = 1;
            this.btnFormat.Text = "System.FormatException";
            this.btnFormat.UseVisualStyleBackColor = false;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnInvalidCast
            // 
            this.btnInvalidCast.BackColor = System.Drawing.Color.Silver;
            this.btnInvalidCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvalidCast.Location = new System.Drawing.Point(54, 294);
            this.btnInvalidCast.Name = "btnInvalidCast";
            this.btnInvalidCast.Size = new System.Drawing.Size(338, 124);
            this.btnInvalidCast.TabIndex = 2;
            this.btnInvalidCast.Text = "System.InvalidCastException";
            this.btnInvalidCast.UseVisualStyleBackColor = false;
            this.btnInvalidCast.Click += new System.EventHandler(this.btnInvalidCast_Click);
            // 
            // btnNullReference
            // 
            this.btnNullReference.BackColor = System.Drawing.Color.Yellow;
            this.btnNullReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNullReference.Location = new System.Drawing.Point(443, 294);
            this.btnNullReference.Name = "btnNullReference";
            this.btnNullReference.Size = new System.Drawing.Size(327, 124);
            this.btnNullReference.TabIndex = 3;
            this.btnNullReference.Text = "System.NullReferenceException";
            this.btnNullReference.UseVisualStyleBackColor = false;
            this.btnNullReference.Click += new System.EventHandler(this.btnNullReference_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(100, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click for Arithmetic Exception";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(500, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click for Format Exception";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(100, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Click for Invalid Cast Exception";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(443, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Click for Null Reference Exception";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(838, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNullReference);
            this.Controls.Add(this.btnInvalidCast);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnArithmetic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArithmetic;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnInvalidCast;
        private System.Windows.Forms.Button btnNullReference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

