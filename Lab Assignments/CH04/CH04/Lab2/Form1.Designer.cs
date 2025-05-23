namespace Lab2
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.eggInput1 = new System.Windows.Forms.TextBox();
            this.eggInput2 = new System.Windows.Forms.TextBox();
            this.eggInput3 = new System.Windows.Forms.TextBox();
            this.eggInput4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(776, 37);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Chicken Farmer Weekly Egg Count";
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(165, 66);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(458, 23);
            this.lblTop.TabIndex = 1;
            this.lblTop.Text = "Enter the number of eggs laid by each chicken:";
            // 
            // eggInput1
            // 
            this.eggInput1.Location = new System.Drawing.Point(81, 140);
            this.eggInput1.Name = "eggInput1";
            this.eggInput1.Size = new System.Drawing.Size(122, 22);
            this.eggInput1.TabIndex = 2;
            // 
            // eggInput2
            // 
            this.eggInput2.Location = new System.Drawing.Point(250, 140);
            this.eggInput2.Name = "eggInput2";
            this.eggInput2.Size = new System.Drawing.Size(126, 22);
            this.eggInput2.TabIndex = 3;
            // 
            // eggInput3
            // 
            this.eggInput3.Location = new System.Drawing.Point(415, 140);
            this.eggInput3.Name = "eggInput3";
            this.eggInput3.Size = new System.Drawing.Size(122, 22);
            this.eggInput3.TabIndex = 4;
            // 
            // eggInput4
            // 
            this.eggInput4.Location = new System.Drawing.Point(573, 140);
            this.eggInput4.Name = "eggInput4";
            this.eggInput4.Size = new System.Drawing.Size(121, 22);
            this.eggInput4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(178, 318);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 7;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "chicken 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "chicken 2 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "chicken 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "chicken 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eggInput4);
            this.Controls.Add(this.eggInput3);
            this.Controls.Add(this.eggInput2);
            this.Controls.Add(this.eggInput1);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.TextBox eggInput1;
        private System.Windows.Forms.TextBox eggInput2;
        private System.Windows.Forms.TextBox eggInput3;
        private System.Windows.Forms.TextBox eggInput4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

