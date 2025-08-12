namespace FinalProject
{
    partial class ReceiptResult
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
            lblTotalPrice = new Label();
            label13 = new Label();
            label10 = new Label();
            rtbResult = new RichTextBox();
            label1 = new Label();
            lblFinalCredit = new Label();
            SuspendLayout();
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(644, 382);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(58, 20);
            lblTotalPrice.TabIndex = 36;
            lblTotalPrice.Text = "label11";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(508, 382);
            label13.Name = "label13";
            label13.Size = new Size(89, 38);
            label13.TabIndex = 33;
            label13.Text = "Total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(324, 21);
            label10.Name = "label10";
            label10.Size = new Size(131, 46);
            label10.TabIndex = 30;
            label10.Text = "Receipt";
            // 
            // rtbResult
            // 
            rtbResult.Location = new Point(26, 70);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(745, 350);
            rtbResult.TabIndex = 29;
            rtbResult.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(508, 324);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 37;
            label1.Text = "Credit:";
            // 
            // lblFinalCredit
            // 
            lblFinalCredit.AutoSize = true;
            lblFinalCredit.Location = new Point(641, 327);
            lblFinalCredit.Name = "lblFinalCredit";
            lblFinalCredit.Size = new Size(50, 20);
            lblFinalCredit.TabIndex = 38;
            lblFinalCredit.Text = "label2";
            // 
            // ReceiptResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFinalCredit);
            Controls.Add(label1);
            Controls.Add(lblTotalPrice);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(rtbResult);
            Name = "ReceiptResult";
            Text = "ReceiptResult";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalPrice;
        private Label label13;
        private Label label10;
        private RichTextBox rtbResult;
        private Label label1;
        private Label lblFinalCredit;
    }
}