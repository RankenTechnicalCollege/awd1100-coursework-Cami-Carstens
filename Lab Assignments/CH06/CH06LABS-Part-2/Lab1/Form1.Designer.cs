namespace Lab1
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
            this.txtNumInput1 = new System.Windows.Forms.TextBox();
            this.txtNumInput2 = new System.Windows.Forms.TextBox();
            this.txtNumInput3 = new System.Windows.Forms.TextBox();
            this.txtNumInput4 = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = " REVERSE 4";
            // 
            // txtNumInput1
            // 
            this.txtNumInput1.Location = new System.Drawing.Point(41, 109);
            this.txtNumInput1.Name = "txtNumInput1";
            this.txtNumInput1.Size = new System.Drawing.Size(127, 22);
            this.txtNumInput1.TabIndex = 1;
            // 
            // txtNumInput2
            // 
            this.txtNumInput2.Location = new System.Drawing.Point(224, 109);
            this.txtNumInput2.Name = "txtNumInput2";
            this.txtNumInput2.Size = new System.Drawing.Size(131, 22);
            this.txtNumInput2.TabIndex = 2;
            // 
            // txtNumInput3
            // 
            this.txtNumInput3.Location = new System.Drawing.Point(421, 109);
            this.txtNumInput3.Name = "txtNumInput3";
            this.txtNumInput3.Size = new System.Drawing.Size(129, 22);
            this.txtNumInput3.TabIndex = 3;
            // 
            // txtNumInput4
            // 
            this.txtNumInput4.Location = new System.Drawing.Point(629, 109);
            this.txtNumInput4.Name = "txtNumInput4";
            this.txtNumInput4.Size = new System.Drawing.Size(124, 22);
            this.txtNumInput4.TabIndex = 4;
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.Location = new System.Drawing.Point(41, 201);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(154, 36);
            this.btnReverse.TabIndex = 5;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(251, 212);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtNumInput4);
            this.Controls.Add(this.txtNumInput3);
            this.Controls.Add(this.txtNumInput2);
            this.Controls.Add(this.txtNumInput1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumInput1;
        private System.Windows.Forms.TextBox txtNumInput2;
        private System.Windows.Forms.TextBox txtNumInput3;
        private System.Windows.Forms.TextBox txtNumInput4;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label lblResult;
    }
}

