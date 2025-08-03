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
            this.label2 = new System.Windows.Forms.Label();
            this.cboOccasion = new System.Windows.Forms.ComboBox();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.chkEnvelope = new System.Windows.Forms.CheckBox();
            this.chkStamp = new System.Windows.Forms.CheckBox();
            this.chkCustom = new System.Windows.Forms.CheckBox();
            this.txtCustomMessage = new System.Windows.Forms.RichTextBox();
            this.pbCardSample = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPreviewMessage = new System.Windows.Forms.Label();
            this.lblPreviewResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardSample)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Occasion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Style";
            // 
            // cboOccasion
            // 
            this.cboOccasion.FormattingEnabled = true;
            this.cboOccasion.Location = new System.Drawing.Point(133, 36);
            this.cboOccasion.Name = "cboOccasion";
            this.cboOccasion.Size = new System.Drawing.Size(311, 24);
            this.cboOccasion.TabIndex = 2;
            this.cboOccasion.SelectedIndexChanged += new System.EventHandler(this.cboOccasion_SelectedIndexChanged);
            // 
            // cboStyle
            // 
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(133, 75);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(311, 24);
            this.cboStyle.TabIndex = 3;
            this.cboStyle.SelectedIndexChanged += new System.EventHandler(this.cboStyle_SelectedIndexChanged);
            // 
            // chkEnvelope
            // 
            this.chkEnvelope.AutoSize = true;
            this.chkEnvelope.Location = new System.Drawing.Point(58, 129);
            this.chkEnvelope.Name = "chkEnvelope";
            this.chkEnvelope.Size = new System.Drawing.Size(129, 20);
            this.chkEnvelope.TabIndex = 7;
            this.chkEnvelope.Text = "Envelope ($0.25)";
            this.chkEnvelope.UseVisualStyleBackColor = true;
            this.chkEnvelope.CheckedChanged += new System.EventHandler(this.chkEnvelope_CheckedChanged);
            // 
            // chkStamp
            // 
            this.chkStamp.AutoSize = true;
            this.chkStamp.Location = new System.Drawing.Point(58, 155);
            this.chkStamp.Name = "chkStamp";
            this.chkStamp.Size = new System.Drawing.Size(110, 20);
            this.chkStamp.TabIndex = 8;
            this.chkStamp.Text = "Stamp ($0.50)";
            this.chkStamp.UseVisualStyleBackColor = true;
            this.chkStamp.CheckedChanged += new System.EventHandler(this.chkStamp_CheckedChanged);
            // 
            // chkCustom
            // 
            this.chkCustom.AutoSize = true;
            this.chkCustom.Location = new System.Drawing.Point(58, 181);
            this.chkCustom.Name = "chkCustom";
            this.chkCustom.Size = new System.Drawing.Size(176, 20);
            this.chkCustom.TabIndex = 9;
            this.chkCustom.Text = "Custom Message ($0.30)";
            this.chkCustom.UseVisualStyleBackColor = true;
            this.chkCustom.CheckedChanged += new System.EventHandler(this.chkCustom_CheckedChanged);
            // 
            // txtCustomMessage
            // 
            this.txtCustomMessage.Location = new System.Drawing.Point(12, 222);
            this.txtCustomMessage.Name = "txtCustomMessage";
            this.txtCustomMessage.Size = new System.Drawing.Size(432, 250);
            this.txtCustomMessage.TabIndex = 10;
            this.txtCustomMessage.Text = "";
            this.txtCustomMessage.TextChanged += new System.EventHandler(this.txtCustomMessage_TextChanged);
            this.txtCustomMessage.Enter += new System.EventHandler(this.Field_Enter);
            this.txtCustomMessage.Leave += new System.EventHandler(this.Field_Leave);
            // 
            // pbCardSample
            // 
            this.pbCardSample.Location = new System.Drawing.Point(458, 31);
            this.pbCardSample.Name = "pbCardSample";
            this.pbCardSample.Size = new System.Drawing.Size(529, 519);
            this.pbCardSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardSample.TabIndex = 4;
            this.pbCardSample.TabStop = false;
            this.pbCardSample.Click += new System.EventHandler(this.pbCardSample_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(141, 487);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 22);
            this.lblTotal.TabIndex = 12;
            // 
            // lblPreviewMessage
            // 
            this.lblPreviewMessage.AutoSize = true;
            this.lblPreviewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewMessage.Location = new System.Drawing.Point(30, 240);
            this.lblPreviewMessage.Name = "lblPreviewMessage";
            this.lblPreviewMessage.Size = new System.Drawing.Size(44, 16);
            this.lblPreviewMessage.TabIndex = 13;
            this.lblPreviewMessage.Text = "label4";
            // 
            // lblPreviewResult
            // 
            this.lblPreviewResult.AutoSize = true;
            this.lblPreviewResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPreviewResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewResult.Location = new System.Drawing.Point(478, 388);
            this.lblPreviewResult.Name = "lblPreviewResult";
            this.lblPreviewResult.Size = new System.Drawing.Size(0, 20);
            this.lblPreviewResult.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 562);
            this.Controls.Add(this.lblPreviewResult);
            this.Controls.Add(this.lblPreviewMessage);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomMessage);
            this.Controls.Add(this.chkCustom);
            this.Controls.Add(this.chkStamp);
            this.Controls.Add(this.chkEnvelope);
            this.Controls.Add(this.pbCardSample);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.cboOccasion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Card Designer";
            ((System.ComponentModel.ISupportInitialize)(this.pbCardSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOccasion;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.PictureBox pbCardSample;
        private System.Windows.Forms.CheckBox chkEnvelope;
        private System.Windows.Forms.CheckBox chkStamp;
        private System.Windows.Forms.CheckBox chkCustom;
        private System.Windows.Forms.RichTextBox txtCustomMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPreviewMessage;
        private System.Windows.Forms.Label lblPreviewResult;
    }
}

