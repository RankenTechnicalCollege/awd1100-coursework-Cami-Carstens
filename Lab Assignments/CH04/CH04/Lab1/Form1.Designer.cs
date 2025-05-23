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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblMilesInput = new System.Windows.Forms.Label();
            this.lblKmInput = new System.Windows.Forms.Label();
            this.txtBoxMiles = new System.Windows.Forms.TextBox();
            this.txtBoxKm = new System.Windows.Forms.TextBox();
            this.btnToKm = new System.Windows.Forms.Button();
            this.btnToMiles = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(-4, 2);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1005, 79);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Distance Converter";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMilesInput
            // 
            this.lblMilesInput.AutoSize = true;
            this.lblMilesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilesInput.Location = new System.Drawing.Point(120, 139);
            this.lblMilesInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMilesInput.Name = "lblMilesInput";
            this.lblMilesInput.Size = new System.Drawing.Size(158, 25);
            this.lblMilesInput.TabIndex = 1;
            this.lblMilesInput.Text = "Distance in miles";
            // 
            // lblKmInput
            // 
            this.lblKmInput.AutoSize = true;
            this.lblKmInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmInput.Location = new System.Drawing.Point(618, 139);
            this.lblKmInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKmInput.Name = "lblKmInput";
            this.lblKmInput.Size = new System.Drawing.Size(201, 25);
            this.lblKmInput.TabIndex = 2;
            this.lblKmInput.Text = "Distance in kilometers";
            // 
            // txtBoxMiles
            // 
            this.txtBoxMiles.Location = new System.Drawing.Point(126, 210);
            this.txtBoxMiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxMiles.Name = "txtBoxMiles";
            this.txtBoxMiles.Size = new System.Drawing.Size(269, 27);
            this.txtBoxMiles.TabIndex = 3;
            // 
            // txtBoxKm
            // 
            this.txtBoxKm.Location = new System.Drawing.Point(624, 210);
            this.txtBoxKm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxKm.Name = "txtBoxKm";
            this.txtBoxKm.Size = new System.Drawing.Size(274, 27);
            this.txtBoxKm.TabIndex = 4;
            // 
            // btnToKm
            // 
            this.btnToKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToKm.Location = new System.Drawing.Point(126, 289);
            this.btnToKm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToKm.Name = "btnToKm";
            this.btnToKm.Size = new System.Drawing.Size(248, 29);
            this.btnToKm.TabIndex = 5;
            this.btnToKm.Text = "Convert to km";
            this.btnToKm.UseVisualStyleBackColor = true;
            this.btnToKm.Click += new System.EventHandler(this.btnToKm_Click);
            // 
            // btnToMiles
            // 
            this.btnToMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToMiles.Location = new System.Drawing.Point(624, 289);
            this.btnToMiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToMiles.Name = "btnToMiles";
            this.btnToMiles.Size = new System.Drawing.Size(245, 29);
            this.btnToMiles.TabIndex = 6;
            this.btnToMiles.Text = "Convert to miles";
            this.btnToMiles.UseVisualStyleBackColor = true;
            this.btnToMiles.Click += new System.EventHandler(this.btnToMiles_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblResult.Location = new System.Drawing.Point(460, 376);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnToMiles);
            this.Controls.Add(this.btnToKm);
            this.Controls.Add(this.txtBoxKm);
            this.Controls.Add(this.txtBoxMiles);
            this.Controls.Add(this.lblKmInput);
            this.Controls.Add(this.lblMilesInput);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblMilesInput;
        private System.Windows.Forms.Label lblKmInput;
        private System.Windows.Forms.TextBox txtBoxMiles;
        private System.Windows.Forms.TextBox txtBoxKm;
        private System.Windows.Forms.Button btnToKm;
        private System.Windows.Forms.Button btnToMiles;
        private System.Windows.Forms.Label lblResult;
    }
}

