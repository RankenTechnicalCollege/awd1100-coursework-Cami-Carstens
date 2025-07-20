namespace LB2
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
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.grpFrame = new System.Windows.Forms.GroupBox();
            this.rdbFramed = new System.Windows.Forms.RadioButton();
            this.rdbMatted = new System.Windows.Forms.RadioButton();
            this.rdbUnframed = new System.Windows.Forms.RadioButton();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.grpMaterial = new System.Windows.Forms.GroupBox();
            this.rdbGold = new System.Windows.Forms.RadioButton();
            this.rdbSilver = new System.Windows.Forms.RadioButton();
            this.rdbSteel = new System.Windows.Forms.RadioButton();
            this.rdbOak = new System.Windows.Forms.RadioButton();
            this.rdbPine = new System.Windows.Forms.RadioButton();
            this.grpStyle = new System.Windows.Forms.GroupBox();
            this.rdbEclectic = new System.Windows.Forms.RadioButton();
            this.rdbVintage = new System.Windows.Forms.RadioButton();
            this.rdbAntique = new System.Windows.Forms.RadioButton();
            this.rdbModern = new System.Windows.Forms.RadioButton();
            this.rdbSimple = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOrderResult = new System.Windows.Forms.Label();
            this.lblCostResult = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.grpFrame.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.grpMaterial.SuspendLayout();
            this.grpStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Photoshop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(63, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width (in)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(66, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height (in)";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(168, 57);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(374, 22);
            this.txtWidth.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(168, 103);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(374, 22);
            this.txtHeight.TabIndex = 4;
            // 
            // grpFrame
            // 
            this.grpFrame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpFrame.Controls.Add(this.rdbFramed);
            this.grpFrame.Controls.Add(this.rdbMatted);
            this.grpFrame.Controls.Add(this.rdbUnframed);
            this.grpFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFrame.Location = new System.Drawing.Point(45, 169);
            this.grpFrame.Name = "grpFrame";
            this.grpFrame.Size = new System.Drawing.Size(517, 134);
            this.grpFrame.TabIndex = 5;
            this.grpFrame.TabStop = false;
            this.grpFrame.Text = "Frame";
            // 
            // rdbFramed
            // 
            this.rdbFramed.AutoSize = true;
            this.rdbFramed.Location = new System.Drawing.Point(38, 101);
            this.rdbFramed.Name = "rdbFramed";
            this.rdbFramed.Size = new System.Drawing.Size(87, 24);
            this.rdbFramed.TabIndex = 2;
            this.rdbFramed.TabStop = true;
            this.rdbFramed.Text = "Framed";
            this.rdbFramed.UseVisualStyleBackColor = true;
            // 
            // rdbMatted
            // 
            this.rdbMatted.AutoSize = true;
            this.rdbMatted.Location = new System.Drawing.Point(38, 71);
            this.rdbMatted.Name = "rdbMatted";
            this.rdbMatted.Size = new System.Drawing.Size(81, 24);
            this.rdbMatted.TabIndex = 1;
            this.rdbMatted.TabStop = true;
            this.rdbMatted.Text = "Matted";
            this.rdbMatted.UseVisualStyleBackColor = true;
            // 
            // rdbUnframed
            // 
            this.rdbUnframed.AutoSize = true;
            this.rdbUnframed.Location = new System.Drawing.Point(38, 41);
            this.rdbUnframed.Name = "rdbUnframed";
            this.rdbUnframed.Size = new System.Drawing.Size(103, 24);
            this.rdbUnframed.TabIndex = 0;
            this.rdbUnframed.TabStop = true;
            this.rdbUnframed.Text = "Unframed";
            this.rdbUnframed.UseVisualStyleBackColor = true;
            // 
            // grpColor
            // 
            this.grpColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpColor.Controls.Add(this.rdbWhite);
            this.grpColor.Controls.Add(this.rdbBlue);
            this.grpColor.Controls.Add(this.rdbGreen);
            this.grpColor.Controls.Add(this.rdbRed);
            this.grpColor.Controls.Add(this.rdbBlack);
            this.grpColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColor.Location = new System.Drawing.Point(45, 324);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(140, 274);
            this.grpColor.TabIndex = 6;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(31, 223);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(67, 22);
            this.rdbWhite.TabIndex = 4;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(31, 176);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(58, 22);
            this.rdbBlue.TabIndex = 3;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(27, 129);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(70, 22);
            this.rdbGreen.TabIndex = 2;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(27, 81);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(56, 22);
            this.rdbRed.TabIndex = 1;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(27, 34);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(66, 22);
            this.rdbBlack.TabIndex = 0;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            // 
            // grpMaterial
            // 
            this.grpMaterial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpMaterial.Controls.Add(this.rdbGold);
            this.grpMaterial.Controls.Add(this.rdbSilver);
            this.grpMaterial.Controls.Add(this.rdbSteel);
            this.grpMaterial.Controls.Add(this.rdbOak);
            this.grpMaterial.Controls.Add(this.rdbPine);
            this.grpMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMaterial.Location = new System.Drawing.Point(224, 324);
            this.grpMaterial.Name = "grpMaterial";
            this.grpMaterial.Size = new System.Drawing.Size(144, 274);
            this.grpMaterial.TabIndex = 7;
            this.grpMaterial.TabStop = false;
            this.grpMaterial.Text = "Material";
            // 
            // rdbGold
            // 
            this.rdbGold.AutoSize = true;
            this.rdbGold.Location = new System.Drawing.Point(26, 223);
            this.rdbGold.Name = "rdbGold";
            this.rdbGold.Size = new System.Drawing.Size(61, 22);
            this.rdbGold.TabIndex = 4;
            this.rdbGold.TabStop = true;
            this.rdbGold.Text = "Gold";
            this.rdbGold.UseVisualStyleBackColor = true;
            // 
            // rdbSilver
            // 
            this.rdbSilver.AutoSize = true;
            this.rdbSilver.Location = new System.Drawing.Point(26, 176);
            this.rdbSilver.Name = "rdbSilver";
            this.rdbSilver.Size = new System.Drawing.Size(65, 22);
            this.rdbSilver.TabIndex = 3;
            this.rdbSilver.TabStop = true;
            this.rdbSilver.Text = "Silver";
            this.rdbSilver.UseVisualStyleBackColor = true;
            // 
            // rdbSteel
            // 
            this.rdbSteel.AutoSize = true;
            this.rdbSteel.Location = new System.Drawing.Point(26, 129);
            this.rdbSteel.Name = "rdbSteel";
            this.rdbSteel.Size = new System.Drawing.Size(62, 22);
            this.rdbSteel.TabIndex = 2;
            this.rdbSteel.TabStop = true;
            this.rdbSteel.Text = "Steel";
            this.rdbSteel.UseVisualStyleBackColor = true;
            // 
            // rdbOak
            // 
            this.rdbOak.AutoSize = true;
            this.rdbOak.Location = new System.Drawing.Point(26, 81);
            this.rdbOak.Name = "rdbOak";
            this.rdbOak.Size = new System.Drawing.Size(57, 22);
            this.rdbOak.TabIndex = 1;
            this.rdbOak.TabStop = true;
            this.rdbOak.Text = "Oak";
            this.rdbOak.UseVisualStyleBackColor = true;
            // 
            // rdbPine
            // 
            this.rdbPine.AutoSize = true;
            this.rdbPine.Location = new System.Drawing.Point(26, 34);
            this.rdbPine.Name = "rdbPine";
            this.rdbPine.Size = new System.Drawing.Size(58, 22);
            this.rdbPine.TabIndex = 0;
            this.rdbPine.TabStop = true;
            this.rdbPine.Text = "Pine";
            this.rdbPine.UseVisualStyleBackColor = true;
            // 
            // grpStyle
            // 
            this.grpStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpStyle.Controls.Add(this.rdbEclectic);
            this.grpStyle.Controls.Add(this.rdbVintage);
            this.grpStyle.Controls.Add(this.rdbAntique);
            this.grpStyle.Controls.Add(this.rdbModern);
            this.grpStyle.Controls.Add(this.rdbSimple);
            this.grpStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStyle.Location = new System.Drawing.Point(419, 324);
            this.grpStyle.Name = "grpStyle";
            this.grpStyle.Size = new System.Drawing.Size(143, 274);
            this.grpStyle.TabIndex = 8;
            this.grpStyle.TabStop = false;
            this.grpStyle.Text = "Style";
            // 
            // rdbEclectic
            // 
            this.rdbEclectic.AutoSize = true;
            this.rdbEclectic.Location = new System.Drawing.Point(26, 223);
            this.rdbEclectic.Name = "rdbEclectic";
            this.rdbEclectic.Size = new System.Drawing.Size(81, 22);
            this.rdbEclectic.TabIndex = 4;
            this.rdbEclectic.TabStop = true;
            this.rdbEclectic.Text = "Eclectic";
            this.rdbEclectic.UseVisualStyleBackColor = true;
            // 
            // rdbVintage
            // 
            this.rdbVintage.AutoSize = true;
            this.rdbVintage.Location = new System.Drawing.Point(26, 176);
            this.rdbVintage.Name = "rdbVintage";
            this.rdbVintage.Size = new System.Drawing.Size(77, 22);
            this.rdbVintage.TabIndex = 3;
            this.rdbVintage.TabStop = true;
            this.rdbVintage.Text = "Vintage";
            this.rdbVintage.UseVisualStyleBackColor = true;
            // 
            // rdbAntique
            // 
            this.rdbAntique.AutoSize = true;
            this.rdbAntique.Location = new System.Drawing.Point(26, 129);
            this.rdbAntique.Name = "rdbAntique";
            this.rdbAntique.Size = new System.Drawing.Size(77, 22);
            this.rdbAntique.TabIndex = 2;
            this.rdbAntique.TabStop = true;
            this.rdbAntique.Text = "Antique";
            this.rdbAntique.UseVisualStyleBackColor = true;
            // 
            // rdbModern
            // 
            this.rdbModern.AutoSize = true;
            this.rdbModern.Location = new System.Drawing.Point(23, 81);
            this.rdbModern.Name = "rdbModern";
            this.rdbModern.Size = new System.Drawing.Size(80, 22);
            this.rdbModern.TabIndex = 1;
            this.rdbModern.TabStop = true;
            this.rdbModern.Text = "Modern";
            this.rdbModern.UseVisualStyleBackColor = true;
            // 
            // rdbSimple
            // 
            this.rdbSimple.AutoSize = true;
            this.rdbSimple.Location = new System.Drawing.Point(24, 34);
            this.rdbSimple.Name = "rdbSimple";
            this.rdbSimple.Size = new System.Drawing.Size(74, 22);
            this.rdbSimple.TabIndex = 0;
            this.rdbSimple.TabStop = true;
            this.rdbSimple.Text = "Simple";
            this.rdbSimple.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(45, 623);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 41);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOrderResult
            // 
            this.lblOrderResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrderResult.Location = new System.Drawing.Point(45, 689);
            this.lblOrderResult.Name = "lblOrderResult";
            this.lblOrderResult.Size = new System.Drawing.Size(381, 35);
            this.lblOrderResult.TabIndex = 10;
            // 
            // lblCostResult
            // 
            this.lblCostResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCostResult.Location = new System.Drawing.Point(296, 614);
            this.lblCostResult.Name = "lblCostResult";
            this.lblCostResult.Size = new System.Drawing.Size(266, 62);
            this.lblCostResult.TabIndex = 11;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.BackColor = System.Drawing.Color.White;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(168, 137);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(374, 23);
            this.lblErrorMessage.TabIndex = 12;
            this.lblErrorMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(597, 733);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblCostResult);
            this.Controls.Add(this.lblOrderResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpStyle);
            this.Controls.Add(this.grpMaterial);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.grpFrame);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpFrame.ResumeLayout(false);
            this.grpFrame.PerformLayout();
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpMaterial.ResumeLayout(false);
            this.grpMaterial.PerformLayout();
            this.grpStyle.ResumeLayout(false);
            this.grpStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox grpFrame;
        private System.Windows.Forms.RadioButton rdbUnframed;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.GroupBox grpMaterial;
        private System.Windows.Forms.GroupBox grpStyle;
        private System.Windows.Forms.RadioButton rdbFramed;
        private System.Windows.Forms.RadioButton rdbMatted;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbGold;
        private System.Windows.Forms.RadioButton rdbSilver;
        private System.Windows.Forms.RadioButton rdbSteel;
        private System.Windows.Forms.RadioButton rdbOak;
        private System.Windows.Forms.RadioButton rdbPine;
        private System.Windows.Forms.RadioButton rdbEclectic;
        private System.Windows.Forms.RadioButton rdbVintage;
        private System.Windows.Forms.RadioButton rdbAntique;
        private System.Windows.Forms.RadioButton rdbModern;
        private System.Windows.Forms.RadioButton rdbSimple;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOrderResult;
        private System.Windows.Forms.Label lblCostResult;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

