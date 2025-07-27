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
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtEstimatedDelivery = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Validator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Number [ 100, 999 ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity [ 1, 12 ]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estimated Delivery Date [ 1, 30 ]";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(392, 85);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(224, 22);
            this.txtItemNumber.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(392, 157);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(224, 22);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtEstimatedDelivery
            // 
            this.txtEstimatedDelivery.Location = new System.Drawing.Point(392, 234);
            this.txtEstimatedDelivery.Name = "txtEstimatedDelivery";
            this.txtEstimatedDelivery.Size = new System.Drawing.Size(224, 22);
            this.txtEstimatedDelivery.TabIndex = 6;
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(392, 304);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(224, 42);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(91, 362);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 29);
            this.lblError.TabIndex = 8;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(94, 403);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(522, 58);
            this.lblResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtEstimatedDelivery);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtEstimatedDelivery;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblResult;
    }
}

