namespace LB4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.txtDecodePhrase = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decoder Ring";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LB4.Properties.Resources.decoderRing;
            this.pictureBox1.Location = new System.Drawing.Point(269, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtEncode
            // 
            this.txtEncode.Location = new System.Drawing.Point(29, 260);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(478, 22);
            this.txtEncode.TabIndex = 2;
            // 
            // txtDecodePhrase
            // 
            this.txtDecodePhrase.Location = new System.Drawing.Point(29, 391);
            this.txtDecodePhrase.Name = "txtDecodePhrase";
            this.txtDecodePhrase.Size = new System.Drawing.Size(478, 22);
            this.txtDecodePhrase.TabIndex = 3;
            // 
            // btnEncode
            // 
            this.btnEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.Location = new System.Drawing.Point(540, 253);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(148, 56);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.Location = new System.Drawing.Point(540, 374);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(148, 55);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shift [ 0-25 ]";
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(407, 322);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(100, 22);
            this.txtShift.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txtDecodePhrase);
            this.Controls.Add(this.txtEncode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.TextBox txtDecodePhrase;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShift;
    }
}

