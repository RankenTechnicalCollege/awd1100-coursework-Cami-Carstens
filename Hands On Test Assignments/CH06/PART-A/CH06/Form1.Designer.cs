namespace CH06
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
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnIsbn = new System.Windows.Forms.Button();
            this.btnKeyword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResultName = new System.Windows.Forms.Label();
            this.lblResultAuthor = new System.Windows.Forms.Label();
            this.lblResultDescript = new System.Windows.Forms.Label();
            this.lblResultIsbn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(962, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAST PERFECT BOOKS AND ANTIQUES\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Keyword:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(225, 85);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(298, 27);
            this.txtAuthor.TabIndex = 4;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(225, 133);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(298, 27);
            this.txtIsbn.TabIndex = 5;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(225, 189);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(298, 27);
            this.txtKeyword.TabIndex = 6;
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.Location = new System.Drawing.Point(580, 83);
            this.btnAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(113, 28);
            this.btnAuthor.TabIndex = 7;
            this.btnAuthor.Text = "Search";
            this.btnAuthor.UseVisualStyleBackColor = false;
            this.btnAuthor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIsbn
            // 
            this.btnIsbn.BackColor = System.Drawing.Color.AliceBlue;
            this.btnIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsbn.Location = new System.Drawing.Point(580, 130);
            this.btnIsbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIsbn.Name = "btnIsbn";
            this.btnIsbn.Size = new System.Drawing.Size(113, 30);
            this.btnIsbn.TabIndex = 8;
            this.btnIsbn.Text = "Search";
            this.btnIsbn.UseVisualStyleBackColor = false;
            this.btnIsbn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKeyword
            // 
            this.btnKeyword.BackColor = System.Drawing.Color.AliceBlue;
            this.btnKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyword.Location = new System.Drawing.Point(580, 189);
            this.btnKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKeyword.Name = "btnKeyword";
            this.btnKeyword.Size = new System.Drawing.Size(113, 28);
            this.btnKeyword.TabIndex = 9;
            this.btnKeyword.Text = "Search";
            this.btnKeyword.UseVisualStyleBackColor = false;
            this.btnKeyword.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "Author:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 39);
            this.label8.TabIndex = 13;
            this.label8.Text = "ISBN:";
            // 
            // lblResultName
            // 
            this.lblResultName.AutoSize = true;
            this.lblResultName.BackColor = System.Drawing.Color.AliceBlue;
            this.lblResultName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultName.Location = new System.Drawing.Point(132, 253);
            this.lblResultName.Name = "lblResultName";
            this.lblResultName.Size = new System.Drawing.Size(0, 22);
            this.lblResultName.TabIndex = 14;
            // 
            // lblResultAuthor
            // 
            this.lblResultAuthor.AutoSize = true;
            this.lblResultAuthor.BackColor = System.Drawing.Color.AliceBlue;
            this.lblResultAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultAuthor.Location = new System.Drawing.Point(146, 345);
            this.lblResultAuthor.Name = "lblResultAuthor";
            this.lblResultAuthor.Size = new System.Drawing.Size(0, 20);
            this.lblResultAuthor.TabIndex = 15;
            // 
            // lblResultDescript
            // 
            this.lblResultDescript.AutoSize = true;
            this.lblResultDescript.BackColor = System.Drawing.Color.AliceBlue;
            this.lblResultDescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultDescript.Location = new System.Drawing.Point(202, 427);
            this.lblResultDescript.Name = "lblResultDescript";
            this.lblResultDescript.Size = new System.Drawing.Size(0, 20);
            this.lblResultDescript.TabIndex = 16;
            // 
            // lblResultIsbn
            // 
            this.lblResultIsbn.AutoSize = true;
            this.lblResultIsbn.BackColor = System.Drawing.Color.AliceBlue;
            this.lblResultIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultIsbn.Location = new System.Drawing.Point(132, 513);
            this.lblResultIsbn.Name = "lblResultIsbn";
            this.lblResultIsbn.Size = new System.Drawing.Size(0, 20);
            this.lblResultIsbn.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(950, 567);
            this.Controls.Add(this.lblResultIsbn);
            this.Controls.Add(this.lblResultDescript);
            this.Controls.Add(this.lblResultAuthor);
            this.Controls.Add(this.lblResultName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKeyword);
            this.Controls.Add(this.btnIsbn);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnIsbn;
        private System.Windows.Forms.Button btnKeyword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResultName;
        private System.Windows.Forms.Label lblResultAuthor;
        private System.Windows.Forms.Label lblResultDescript;
        private System.Windows.Forms.Label lblResultIsbn;
    }
}

