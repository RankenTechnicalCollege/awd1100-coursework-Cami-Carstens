namespace Lab4
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
            this.txtSalesBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDanielle = new System.Windows.Forms.Label();
            this.lblEdward = new System.Windows.Forms.Label();
            this.lblFrancis = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTopSeller = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Sales";
            // 
            // txtSalesBox
            // 
            this.txtSalesBox.Location = new System.Drawing.Point(143, 92);
            this.txtSalesBox.Name = "txtSalesBox";
            this.txtSalesBox.Size = new System.Drawing.Size(229, 22);
            this.txtSalesBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "How much was the sale?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Who made the sale?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Danielle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edward";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Francis";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(73, 242);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 7;
            // 
            // lblDanielle
            // 
            this.lblDanielle.AutoSize = true;
            this.lblDanielle.Location = new System.Drawing.Point(70, 272);
            this.lblDanielle.Name = "lblDanielle";
            this.lblDanielle.Size = new System.Drawing.Size(0, 16);
            this.lblDanielle.TabIndex = 8;
            // 
            // lblEdward
            // 
            this.lblEdward.AutoSize = true;
            this.lblEdward.Location = new System.Drawing.Point(73, 301);
            this.lblEdward.Name = "lblEdward";
            this.lblEdward.Size = new System.Drawing.Size(0, 16);
            this.lblEdward.TabIndex = 9;
            // 
            // lblFrancis
            // 
            this.lblFrancis.AutoSize = true;
            this.lblFrancis.Location = new System.Drawing.Point(73, 332);
            this.lblFrancis.Name = "lblFrancis";
            this.lblFrancis.Size = new System.Drawing.Size(0, 16);
            this.lblFrancis.TabIndex = 10;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(76, 368);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(0, 16);
            this.lblGrandTotal.TabIndex = 11;
            // 
            // lblTopSeller
            // 
            this.lblTopSeller.AutoSize = true;
            this.lblTopSeller.Location = new System.Drawing.Point(79, 404);
            this.lblTopSeller.Name = "lblTopSeller";
            this.lblTopSeller.Size = new System.Drawing.Size(0, 16);
            this.lblTopSeller.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTopSeller);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblFrancis);
            this.Controls.Add(this.lblEdward);
            this.Controls.Add(this.lblDanielle);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalesBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDanielle;
        private System.Windows.Forms.Label lblEdward;
        private System.Windows.Forms.Label lblFrancis;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTopSeller;
    }
}

