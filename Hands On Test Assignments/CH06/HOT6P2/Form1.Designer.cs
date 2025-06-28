namespace HOT6P2
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
            this.lblBanner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.lblResultTotal = new System.Windows.Forms.Label();
            this.lblInvoiceSmall = new System.Windows.Forms.Label();
            this.lblInvoiceMedium = new System.Windows.Forms.Label();
            this.lblInvoiceLarge = new System.Windows.Forms.Label();
            this.grpInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblBanner.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBanner.Location = new System.Drawing.Point(-3, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(804, 61);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Super Custom Cool Shirts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(105, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "What size shirts do you need?";
            // 
            // btnSmall
            // 
            this.btnSmall.BackColor = System.Drawing.Color.Teal;
            this.btnSmall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSmall.Location = new System.Drawing.Point(133, 132);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 52);
            this.btnSmall.TabIndex = 2;
            this.btnSmall.Text = "S";
            this.btnSmall.UseVisualStyleBackColor = false;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Teal;
            this.btnMedium.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMedium.Location = new System.Drawing.Point(304, 132);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 52);
            this.btnMedium.TabIndex = 3;
            this.btnMedium.Text = "M";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.BackColor = System.Drawing.Color.Teal;
            this.btnLarge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLarge.Location = new System.Drawing.Point(472, 132);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(75, 52);
            this.btnLarge.TabIndex = 4;
            this.btnLarge.Text = "L";
            this.btnLarge.UseVisualStyleBackColor = false;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(146, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "$9.99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(310, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "$10.99";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(483, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "$11.99";
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.lblInvoiceLarge);
            this.grpInvoice.Controls.Add(this.lblInvoiceMedium);
            this.grpInvoice.Controls.Add(this.lblInvoiceSmall);
            this.grpInvoice.Controls.Add(this.lblResultTotal);
            this.grpInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpInvoice.Location = new System.Drawing.Point(40, 201);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(618, 342);
            this.grpInvoice.TabIndex = 8;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "Shirt Order Invoice";
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearOrder.Location = new System.Drawing.Point(180, 562);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(367, 69);
            this.btnClearOrder.TabIndex = 9;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = false;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // lblResultTotal
            // 
            this.lblResultTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultTotal.Location = new System.Drawing.Point(30, 155);
            this.lblResultTotal.Name = "lblResultTotal";
            this.lblResultTotal.Size = new System.Drawing.Size(561, 102);
            this.lblResultTotal.TabIndex = 0;
            // 
            // lblInvoiceSmall
            // 
            this.lblInvoiceSmall.AutoSize = true;
            this.lblInvoiceSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceSmall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInvoiceSmall.Location = new System.Drawing.Point(15, 56);
            this.lblInvoiceSmall.Name = "lblInvoiceSmall";
            this.lblInvoiceSmall.Size = new System.Drawing.Size(0, 18);
            this.lblInvoiceSmall.TabIndex = 1;
            // 
            // lblInvoiceMedium
            // 
            this.lblInvoiceMedium.AutoSize = true;
            this.lblInvoiceMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceMedium.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInvoiceMedium.Location = new System.Drawing.Point(201, 56);
            this.lblInvoiceMedium.Name = "lblInvoiceMedium";
            this.lblInvoiceMedium.Size = new System.Drawing.Size(0, 18);
            this.lblInvoiceMedium.TabIndex = 2;
            // 
            // lblInvoiceLarge
            // 
            this.lblInvoiceLarge.AutoSize = true;
            this.lblInvoiceLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceLarge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInvoiceLarge.Location = new System.Drawing.Point(390, 56);
            this.lblInvoiceLarge.Name = "lblInvoiceLarge";
            this.lblInvoiceLarge.Size = new System.Drawing.Size(0, 18);
            this.lblInvoiceLarge.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(681, 660);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBanner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Label lblResultTotal;
        private System.Windows.Forms.Label lblInvoiceSmall;
        private System.Windows.Forms.Label lblInvoiceLarge;
        private System.Windows.Forms.Label lblInvoiceMedium;
    }
}

